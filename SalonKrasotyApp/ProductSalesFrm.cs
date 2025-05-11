using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonKrasotyApp.ModelEF;

namespace SalonKrasotyApp
{
    public partial class ProductSalesFrm : Form
    {
        public Product prd { get; set; } = null;
        public ProductSalesFrm()
        {
            InitializeComponent();
        }

        private void ProductSalesFrm_Load(object sender, EventArgs e)
        {
            List<string> lstFiltr = Program.db.Product.Select(x => x.Title).OrderBy(x => x).ToList();
            FiltrCmb.DataSource = lstFiltr;
            FiltrCmb.SelectedIndex = lstFiltr.FindIndex(s => s == prd.Title);

            productBindingSource.DataSource = Program.db.Product.ToList();
            productSaleBindingSource.DataSource = Program.db.ProductSale.Where(s => s.ProductID == prd.ID).OrderBy(s => s.SaleDate).ToList();
            ProductLbl.Text = prd.Title;
        }

        private void productSaleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditSaleFrm form = new AddEditSaleFrm();
            form.prdSale = null;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productSaleBindingSource.DataSource = Program.db.ProductSale.Where(p => p.ProductID == prd.ID).OrderBy(s => s.SaleDate).ToList();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProductSale prdSale = (ProductSale)productSaleBindingSource.Current;
            AddEditSaleFrm form = new AddEditSaleFrm();
            form.prdSale = prdSale;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productSaleBindingSource.DataSource = Program.db.ProductSale.Where(p => p.ProductID == prd.ID).ToList();
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ProductSale prdSale = (ProductSale)productSaleBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить данные о продаже - " + prdSale.Product.Title, "Удаление данных о продаже", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Program.db.ProductSale.Remove(prdSale);
                try
                {
                    Program.db.SaveChanges();
                    // Обновляем источник данных, чтобы изменения отобразились в списке
                    productSaleBindingSource.DataSource = Program.db.ProductSale
                        .Where(s => s.ProductID == prd.ID)
                        .OrderBy(s => s.SaleDate)
                        .ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла ошибка " + ex.Message);
                }
            }
        }

        private void FiltrCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = FiltrCmb.Text;
            productSaleBindingSource.DataSource = Program.db.ProductSale.Where(p => p.Product.Title == title).ToList();
            ProductLbl.Text = title;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
