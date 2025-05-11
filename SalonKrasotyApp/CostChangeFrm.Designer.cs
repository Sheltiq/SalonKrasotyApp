namespace SalonKrasotyApp
{
    partial class CostChangeFrm
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
            this.EditCostBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddCostTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditCostBtn
            // 
            this.EditCostBtn.Location = new System.Drawing.Point(73, 74);
            this.EditCostBtn.Name = "EditCostBtn";
            this.EditCostBtn.Size = new System.Drawing.Size(75, 23);
            this.EditCostBtn.TabIndex = 0;
            this.EditCostBtn.Text = "Изменить";
            this.EditCostBtn.UseVisualStyleBackColor = true;
            this.EditCostBtn.Click += new System.EventHandler(this.EditCostBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(207, 74);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddCostTxt
            // 
            this.AddCostTxt.Location = new System.Drawing.Point(237, 30);
            this.AddCostTxt.Name = "AddCostTxt";
            this.AddCostTxt.Size = new System.Drawing.Size(125, 20);
            this.AddCostTxt.TabIndex = 2;
            this.AddCostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCostTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "На сколько надо изменить стоимость :";
            // 
            // CostChangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCostTxt);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditCostBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CostChangeFrm";
            this.Text = "Изменение мин. стоимости товаров";
            this.Load += new System.EventHandler(this.CostChangeFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditCostBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox AddCostTxt;
        private System.Windows.Forms.Label label1;
    }
}