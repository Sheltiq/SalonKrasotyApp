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
    public partial class MainFrm : Form
    {
        List<Product> lstFormatData = new List<Product>();
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SortCmb.SelectedIndex = 0;
            List<string> lstFiltr = Program.db.Manufacturer.Select(a => a.Name).OrderBy(s => s).ToList();
            lstFiltr.Insert(0, "Все производители");
            FiltrCmb.DataSource = lstFiltr;
            FiltrCmb.SelectedIndex = 0;
            manufacturerBindingSource.DataSource = Program.db.Manufacturer.ToList();
            productBindingSource.DataSource = Program.db.Product.ToList();
        }

        private void produtcDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void productDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0) return;

            if (productDataGridView[5, e.RowIndex].Value == null)
                return;

            bool isactive = (bool)productDataGridView[5, e.RowIndex].Value;
            if (isactive == false) { e.CellStyle.BackColor = Color.LightGray;}
        }

        string search = "";
        string sort = "Без сортировки";
        string fltr = "Все производители";

        public void Podgotovka()
        {
            lstFormatData = Program.db.Product.ToList();
            if (fltr != "Все производители")
            {
                lstFormatData = lstFormatData.Where(p => (p.Manufacturer.Name == fltr)).ToList();
            }
            if(search != "")
            {
                lstFormatData = lstFormatData.Where(p => p.Title.Contains(search)).ToList();
                if (lstFormatData.Count == 0)
                {
                    MessageBox.Show("Строка " + search + " нигде не найдена!");
                }
            }
            if (sort != "Без сортировки")
            {
                if(sort == "Название")
                {
                    if(!DownChk.Checked)
                        lstFormatData = lstFormatData.OrderBy(p => p.Title).ToList();
                    else
                        lstFormatData = lstFormatData.OrderByDescending(p => p.Title).ToList();
                }
                if (sort == "Стоимость")
                {
                    if (!DownChk.Checked)
                        lstFormatData = lstFormatData.OrderBy(p => p.Cost).ToList();
                    else
                        lstFormatData = lstFormatData.OrderByDescending(p => p.Cost).ToList();
                }
            }
            RangeLbl.Text = $"Всего товаров: {lstFormatData.Count}";
            productBindingSource.DataSource = lstFormatData;
        }

        private void FiltrCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fltr = FiltrCmb.Text;
            Podgotovka();
        }

        private void SortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = SortCmb.Text;
            Podgotovka();
        }

        private void DownChk_CheckedChanged(object sender, EventArgs e)
        {
            Podgotovka();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            search = SearchTxt.Text;
            Podgotovka();
        }
    }
}
