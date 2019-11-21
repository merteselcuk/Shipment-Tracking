namespace Sevkiyat.UI
{
    partial class FormPayersList
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
            this.btnUpdateForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddForm = new System.Windows.Forms.Button();
            this.lstPayer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUpdateForm
            // 
            this.btnUpdateForm.Location = new System.Drawing.Point(462, 369);
            this.btnUpdateForm.Name = "btnUpdateForm";
            this.btnUpdateForm.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateForm.TabIndex = 13;
            this.btnUpdateForm.Text = "Güncelle";
            this.btnUpdateForm.UseVisualStyleBackColor = true;
            this.btnUpdateForm.Click += new System.EventHandler(this.BtnUpdateForm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAddForm
            // 
            this.btnAddForm.Location = new System.Drawing.Point(462, 9);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddForm.TabIndex = 15;
            this.btnAddForm.Text = "Ekle";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // lstPayer
            // 
            this.lstPayer.FormattingEnabled = true;
            this.lstPayer.Location = new System.Drawing.Point(29, 50);
            this.lstPayer.Name = "lstPayer";
            this.lstPayer.Size = new System.Drawing.Size(508, 303);
            this.lstPayer.TabIndex = 16;
            // 
            // FormPayersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 411);
            this.Controls.Add(this.lstPayer);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateForm);
            this.Name = "FormPayersList";
            this.Text = "PayersListele";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.ListBox lstPayer;
    }
}