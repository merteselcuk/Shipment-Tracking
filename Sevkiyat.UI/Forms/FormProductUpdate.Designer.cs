namespace Sevkiyat.UI.Forms
{
    partial class FormProductUpdate
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
            this.cbxProductQuantityPerUnit = new System.Windows.Forms.ComboBox();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBirimCinsi = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.chxActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbxProductQuantityPerUnit
            // 
            this.cbxProductQuantityPerUnit.FormattingEnabled = true;
            this.cbxProductQuantityPerUnit.Location = new System.Drawing.Point(151, 134);
            this.cbxProductQuantityPerUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProductQuantityPerUnit.Name = "cbxProductQuantityPerUnit";
            this.cbxProductQuantityPerUnit.Size = new System.Drawing.Size(100, 21);
            this.cbxProductQuantityPerUnit.TabIndex = 19;
            // 
            // cbxProductType
            // 
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(151, 67);
            this.cbxProductType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(100, 21);
            this.cbxProductType.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(176, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.Location = new System.Drawing.Point(27, 102);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(46, 17);
            this.lblWeight.TabIndex = 17;
            this.lblWeight.Text = "Ağırlık";
            // 
            // lblBirimCinsi
            // 
            this.lblBirimCinsi.AutoSize = true;
            this.lblBirimCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimCinsi.Location = new System.Drawing.Point(27, 136);
            this.lblBirimCinsi.Name = "lblBirimCinsi";
            this.lblBirimCinsi.Size = new System.Drawing.Size(69, 17);
            this.lblBirimCinsi.TabIndex = 15;
            this.lblBirimCinsi.Text = "BirimCinsi";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductType.Location = new System.Drawing.Point(27, 69);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(81, 17);
            this.lblProductType.TabIndex = 16;
            this.lblProductType.Text = "Ürün Çeşidi";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(27, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 17);
            this.lblProductName.TabIndex = 14;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(151, 101);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 13;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(151, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 12;
            // 
            // chxActive
            // 
            this.chxActive.AutoSize = true;
            this.chxActive.Location = new System.Drawing.Point(151, 171);
            this.chxActive.Name = "chxActive";
            this.chxActive.Size = new System.Drawing.Size(47, 17);
            this.chxActive.TabIndex = 27;
            this.chxActive.Text = "Aktif";
            this.chxActive.UseVisualStyleBackColor = true;
            // 
            // FormProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 277);
            this.Controls.Add(this.chxActive);
            this.Controls.Add(this.cbxProductQuantityPerUnit);
            this.Controls.Add(this.cbxProductType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblBirimCinsi);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Name = "FormProductUpdate";
            this.Text = "FormProductUpdate";
            this.Load += new System.EventHandler(this.FormProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProductQuantityPerUnit;
        private System.Windows.Forms.ComboBox cbxProductType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBirimCinsi;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.CheckBox chxActive;
    }
}