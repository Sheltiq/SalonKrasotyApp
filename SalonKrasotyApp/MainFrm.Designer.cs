namespace SalonKrasotyApp
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DownChk = new System.Windows.Forms.CheckBox();
            this.FiltrCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RangeLbl = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CostChangeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товары салона красоты";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(10, 94);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.RowTemplate.Height = 40;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(763, 379);
            this.productDataGridView.TabIndex = 1;
            this.productDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.productDataGridView_CellFormatting);
            this.productDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.produtcDataGridView_DataError);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(57, 68);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(139, 23);
            this.SearchTxt.TabIndex = 2;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // SortCmb
            // 
            this.SortCmb.FormattingEnabled = true;
            this.SortCmb.Items.AddRange(new object[] {
            "Без сортировки",
            "Название",
            "Стоимость"});
            this.SortCmb.Location = new System.Drawing.Point(285, 68);
            this.SortCmb.Name = "SortCmb";
            this.SortCmb.Size = new System.Drawing.Size(138, 24);
            this.SortCmb.TabIndex = 4;
            this.SortCmb.SelectedIndexChanged += new System.EventHandler(this.SortCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сортировка";
            // 
            // DownChk
            // 
            this.DownChk.AutoSize = true;
            this.DownChk.Location = new System.Drawing.Point(431, 68);
            this.DownChk.Name = "DownChk";
            this.DownChk.Size = new System.Drawing.Size(91, 21);
            this.DownChk.TabIndex = 6;
            this.DownChk.Text = "убывание";
            this.DownChk.UseVisualStyleBackColor = true;
            this.DownChk.CheckedChanged += new System.EventHandler(this.DownChk_CheckedChanged);
            // 
            // FiltrCmb
            // 
            this.FiltrCmb.FormattingEnabled = true;
            this.FiltrCmb.Items.AddRange(new object[] {
            "Все типы"});
            this.FiltrCmb.Location = new System.Drawing.Point(556, 68);
            this.FiltrCmb.Name = "FiltrCmb";
            this.FiltrCmb.Size = new System.Drawing.Size(157, 24);
            this.FiltrCmb.TabIndex = 7;
            this.FiltrCmb.SelectedIndexChanged += new System.EventHandler(this.FiltrCmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фильтрация";
            // 
            // RangeLbl
            // 
            this.RangeLbl.AutoSize = true;
            this.RangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangeLbl.Location = new System.Drawing.Point(239, 476);
            this.RangeLbl.Name = "RangeLbl";
            this.RangeLbl.Size = new System.Drawing.Size(124, 20);
            this.RangeLbl.TabIndex = 9;
            this.RangeLbl.Text = "Всего товаров:";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(13, 502);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(164, 23);
            this.AddProductBtn.TabIndex = 10;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(183, 502);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(154, 23);
            this.EditProductBtn.TabIndex = 11;
            this.EditProductBtn.Text = "Изменить товар";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(343, 502);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(145, 23);
            this.DeleteProductBtn.TabIndex = 12;
            this.DeleteProductBtn.Text = "Удалить товар";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 46;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerIDDataGridViewTextBoxColumn
            // 
            this.manufacturerIDDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.DataSource = this.manufacturerBindingSource;
            this.manufacturerIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.manufacturerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.manufacturerIDDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerIDDataGridViewTextBoxColumn.Name = "manufacturerIDDataGridViewTextBoxColumn";
            this.manufacturerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manufacturerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.manufacturerIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.manufacturerIDDataGridViewTextBoxColumn.Width = 135;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.Manufacturer);
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.costDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 103;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.Product);
            // 
            // CostChangeBtn
            // 
            this.CostChangeBtn.Location = new System.Drawing.Point(12, 531);
            this.CostChangeBtn.Name = "CostChangeBtn";
            this.CostChangeBtn.Size = new System.Drawing.Size(165, 23);
            this.CostChangeBtn.TabIndex = 13;
            this.CostChangeBtn.Text = "Изменить стоим. на ...";
            this.CostChangeBtn.UseVisualStyleBackColor = true;
            this.CostChangeBtn.Click += new System.EventHandler(this.CostChangeBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CostChangeBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.RangeLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FiltrCmb);
            this.Controls.Add(this.DownChk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SortCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.Text = "Информационная система «Салон красоты»‎ ";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SortCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DownChk;
        private System.Windows.Forms.ComboBox FiltrCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RangeLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn manufacturerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button CostChangeBtn;
    }
}

