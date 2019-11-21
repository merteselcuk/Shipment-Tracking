namespace Sevkiyat.UI.Forms
{
    partial class FormDriverList
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
            this.btnDriverUpdate = new System.Windows.Forms.Button();
            this.btnDriverDelete = new System.Windows.Forms.Button();
            this.btnDriverAdd = new System.Windows.Forms.Button();
            this.lstDrivers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDriverUpdate
            // 
            this.btnDriverUpdate.Location = new System.Drawing.Point(398, 371);
            this.btnDriverUpdate.Name = "btnDriverUpdate";
            this.btnDriverUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDriverUpdate.TabIndex = 2;
            this.btnDriverUpdate.Text = "Güncelle";
            this.btnDriverUpdate.UseVisualStyleBackColor = true;
            this.btnDriverUpdate.Click += new System.EventHandler(this.BtnDriverUpdate_Click);
            // 
            // btnDriverDelete
            // 
            this.btnDriverDelete.Location = new System.Drawing.Point(12, 373);
            this.btnDriverDelete.Name = "btnDriverDelete";
            this.btnDriverDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDriverDelete.TabIndex = 3;
            this.btnDriverDelete.Text = "Sil";
            this.btnDriverDelete.UseVisualStyleBackColor = true;
            this.btnDriverDelete.Click += new System.EventHandler(this.BtnDriverDelete_Click);
            // 
            // btnDriverAdd
            // 
            this.btnDriverAdd.Location = new System.Drawing.Point(398, 21);
            this.btnDriverAdd.Name = "btnDriverAdd";
            this.btnDriverAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDriverAdd.TabIndex = 4;
            this.btnDriverAdd.Text = "Ekle";
            this.btnDriverAdd.UseVisualStyleBackColor = true;
            this.btnDriverAdd.Click += new System.EventHandler(this.BtnDriverAdd_Click);
            // 
            // lstDrivers
            // 
            this.lstDrivers.FormattingEnabled = true;
            this.lstDrivers.Location = new System.Drawing.Point(12, 61);
            this.lstDrivers.Name = "lstDrivers";
            this.lstDrivers.Size = new System.Drawing.Size(461, 290);
            this.lstDrivers.TabIndex = 5;
            // 
            // FormDriverList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 408);
            this.Controls.Add(this.lstDrivers);
            this.Controls.Add(this.btnDriverAdd);
            this.Controls.Add(this.btnDriverDelete);
            this.Controls.Add(this.btnDriverUpdate);
            this.Name = "FormDriverList";
            this.Text = "Şoför Listele";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDriverUpdate;
        private System.Windows.Forms.Button btnDriverDelete;
        private System.Windows.Forms.Button btnDriverAdd;
        private System.Windows.Forms.ListBox lstDrivers;
    }
}