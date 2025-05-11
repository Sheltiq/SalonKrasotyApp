namespace SalonKrasotyApp
{
    partial class AddEditProductFrm
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
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label mainImagePathLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label manufacturerIDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProductFrm));
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.mainImagePathTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerIDComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ProductPic = new System.Windows.Forms.PictureBox();
            this.SelectPictBtn = new System.Windows.Forms.Button();
            costLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            mainImagePathLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(28, 285);
            costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(47, 17);
            costLabel.TabIndex = 1;
            costLabel.Text = "Цена:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(25, 134);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 17);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Описание:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(28, 56);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(25, 333);
            isActiveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(88, 17);
            isActiveLabel.TabIndex = 7;
            isActiveLabel.Text = "Активный ?:";
            // 
            // mainImagePathLabel
            // 
            mainImagePathLabel.AutoSize = true;
            mainImagePathLabel.Location = new System.Drawing.Point(28, 199);
            mainImagePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainImagePathLabel.Name = "mainImagePathLabel";
            mainImagePathLabel.Size = new System.Drawing.Size(92, 17);
            mainImagePathLabel.TabIndex = 9;
            mainImagePathLabel.Text = "Путь к фото:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(25, 96);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(76, 17);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Название:";
            // 
            // manufacturerIDLabel1
            // 
            manufacturerIDLabel1.AutoSize = true;
            manufacturerIDLabel1.Location = new System.Drawing.Point(28, 247);
            manufacturerIDLabel1.Name = "manufacturerIDLabel1";
            manufacturerIDLabel1.Size = new System.Drawing.Size(114, 17);
            manufacturerIDLabel1.TabIndex = 14;
            manufacturerIDLabel1.Text = "Производитель:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.Product);
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(176, 285);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(137, 23);
            this.costTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(178, 134);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(177, 46);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(178, 53);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(137, 23);
            this.iDTextBox.TabIndex = 6;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(176, 327);
            this.isActiveCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(139, 30);
            this.isActiveCheckBox.TabIndex = 8;
            this.isActiveCheckBox.Text = "товар в продаже";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainImagePathTextBox
            // 
            this.mainImagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MainImagePath", true));
            this.mainImagePathTextBox.Location = new System.Drawing.Point(178, 199);
            this.mainImagePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainImagePathTextBox.Name = "mainImagePathTextBox";
            this.mainImagePathTextBox.Size = new System.Drawing.Size(302, 23);
            this.mainImagePathTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(178, 96);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(137, 23);
            this.titleTextBox.TabIndex = 14;
            // 
            // manufacturerIDComboBox
            // 
            this.manufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerID", true));
            this.manufacturerIDComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIDComboBox.DisplayMember = "Name";
            this.manufacturerIDComboBox.FormattingEnabled = true;
            this.manufacturerIDComboBox.Location = new System.Drawing.Point(178, 247);
            this.manufacturerIDComboBox.Name = "manufacturerIDComboBox";
            this.manufacturerIDComboBox.Size = new System.Drawing.Size(137, 24);
            this.manufacturerIDComboBox.TabIndex = 15;
            this.manufacturerIDComboBox.ValueMember = "ID";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.Manufacturer);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(124, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(46, 17);
            this.TitleLbl.TabIndex = 16;
            this.TitleLbl.Text = "label1";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(31, 411);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 30);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(178, 411);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(127, 30);
            this.ExitBtn.TabIndex = 18;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ProductPic
            // 
            this.ProductPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPic.Location = new System.Drawing.Point(418, 24);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(135, 127);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPic.TabIndex = 19;
            this.ProductPic.TabStop = false;
            // 
            // SelectPictBtn
            // 
            this.SelectPictBtn.Location = new System.Drawing.Point(449, 157);
            this.SelectPictBtn.Name = "SelectPictBtn";
            this.SelectPictBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectPictBtn.TabIndex = 20;
            this.SelectPictBtn.Text = "Выбор";
            this.SelectPictBtn.UseVisualStyleBackColor = true;
            this.SelectPictBtn.Click += new System.EventHandler(this.SelectPictBtn_Click);
            // 
            // AddEditProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.SelectPictBtn);
            this.Controls.Add(this.ProductPic);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(manufacturerIDLabel1);
            this.Controls.Add(this.manufacturerIDComboBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(isActiveLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(mainImagePathLabel);
            this.Controls.Add(this.mainImagePathTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditProductFrm";
            this.Text = "Добавление и редактирование товара";
            this.Load += new System.EventHandler(this.AddEditProductFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox mainImagePathTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox manufacturerIDComboBox;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox ProductPic;
        private System.Windows.Forms.Button SelectPictBtn;
    }
}