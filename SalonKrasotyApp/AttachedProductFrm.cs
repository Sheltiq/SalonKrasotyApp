﻿using System;
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
    public partial class AttachedProductFrm : Form
    {
        public Product prod { get; set; }
        public AttachedProductFrm()
        {
            InitializeComponent();
        }

        private void AttachedProductFrm_Load(object sender, EventArgs e)
        {
            NameLbl.Text = prod.Title;
            productBindingSource.DataSource = prod.Product1.OrderBy(p => p.Title).ToList();
        }
        DialogResult dr = DialogResult.Cancel;

        private void EditBtn_Click(object sender, EventArgs e)
        {
            AddEditAttachedFrm form = new AddEditAttachedFrm();
            form.prod = prod;
            dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productBindingSource.DataSource = prod.Product1.OrderBy(prod => prod.Title).ToList();
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = dr;
        }
    }
}
