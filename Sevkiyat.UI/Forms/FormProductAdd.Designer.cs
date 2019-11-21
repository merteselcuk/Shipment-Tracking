namespace Sevkiyat.UI
{
    partial class FormProductAdd
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.lblBirimCinsi = new System.Windows.Forms.Label();
            this.cbxProductQuantityPerUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(133, 15);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(133, 86);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(9, 18);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 17);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductType.Location = new System.Drawing.Point(9, 54);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(81, 17);
            this.lblProductType.TabIndex = 7;
            this.lblProductType.Text = "Ürün Çeşidi";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.Location = new System.Drawing.Point(9, 87);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(46, 17);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Ağırlık";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(157, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // cbxProductType
            // 
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(133, 52);
            this.cbxProductType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(100, 21);
            this.cbxProductType.TabIndex = 11;
            // 
            // lblBirimCinsi
            // 
            this.lblBirimCinsi.AutoSize = true;
            this.lblBirimCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimCinsi.Location = new System.Drawing.Point(9, 121);
            this.lblBirimCinsi.Name = "lblBirimCinsi";
            this.lblBirimCinsi.Size = new System.Drawing.Size(69, 17);
            this.lblBirimCinsi.TabIndex = 7;
            this.lblBirimCinsi.Text = "BirimCinsi";
            // 
            // cbxProductQuantityPerUnit
            // 
            this.cbxProductQuantityPerUnit.FormattingEnabled = true;
            this.cbxProductQuantityPerUnit.Location = new System.Drawing.Point(133, 119);
            this.cbxProductQuantityPerUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxProductQuantityPerUnit.Name = "cbxProductQuantityPerUnit";
            this.cbxProductQuantityPerUnit.Size = new System.Drawing.Size(100, 21);
            this.cbxProductQuantityPerUnit.TabIndex = 11;
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 198);
            this.Controls.Add(this.cbxProductQuantityPerUnit);
            this.Controls.Add(this.cbxProductType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblBirimCinsi);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Name = "FormProductAdd";
            this.Text = "Product Add";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxProductType;
        private System.Windows.Forms.Label lblBirimCinsi;
        private System.Windows.Forms.ComboBox cbxProductQuantityPerUnit;
    }
}

