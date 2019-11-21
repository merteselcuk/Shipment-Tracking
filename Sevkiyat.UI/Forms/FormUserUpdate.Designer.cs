namespace Sevkiyat.UI.Forms
{
    partial class FormUserUpdate
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
            this.lstRole = new System.Windows.Forms.ListBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.btnRoleSil = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstRole
            // 
            this.lstRole.FormattingEnabled = true;
            this.lstRole.Location = new System.Drawing.Point(138, 100);
            this.lstRole.MultiColumn = true;
            this.lstRole.Name = "lstRole";
            this.lstRole.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRole.Size = new System.Drawing.Size(179, 134);
            this.lstRole.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(138, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(179, 26);
            this.txtUserName.TabIndex = 10;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(19, 58);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(33, 20);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Rol";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(268, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Location = new System.Drawing.Point(138, 240);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(47, 17);
            this.chbActive.TabIndex = 13;
            this.chbActive.Text = "Aktif";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // btnRoleSil
            // 
            this.btnRoleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleSil.Location = new System.Drawing.Point(333, 207);
            this.btnRoleSil.Name = "btnRoleSil";
            this.btnRoleSil.Size = new System.Drawing.Size(83, 27);
            this.btnRoleSil.TabIndex = 9;
            this.btnRoleSil.Text = "Rol Sil";
            this.btnRoleSil.UseVisualStyleBackColor = true;
            this.btnRoleSil.Click += new System.EventHandler(this.BtnRoleSil_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAdd.Location = new System.Drawing.Point(333, 73);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(83, 24);
            this.btnRoleAdd.TabIndex = 9;
            this.btnRoleAdd.Text = "Rol Ekle";
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.BtnRoleAdd_Click);
            // 
            // cbxRoles
            // 
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Location = new System.Drawing.Point(138, 73);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(179, 21);
            this.cbxRoles.TabIndex = 14;
            // 
            // FormUserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 327);
            this.Controls.Add(this.cbxRoles);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.lstRole);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnRoleAdd);
            this.Controls.Add(this.btnRoleSil);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Name = "FormUserUpdate";
            this.Text = "FormUserUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRole;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.Button btnRoleSil;
        private System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.ComboBox cbxRoles;
    }
}