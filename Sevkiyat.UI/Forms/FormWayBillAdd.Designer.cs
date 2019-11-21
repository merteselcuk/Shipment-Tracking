namespace Sevkiyat.UI
{
    partial class FormWayBillAdd
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
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblShipmentDate = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblBillType = new System.Windows.Forms.Label();
            this.cbxDriver = new System.Windows.Forms.ComboBox();
            this.cbxVehicle = new System.Windows.Forms.ComboBox();
            this.cbxReceiver = new System.Windows.Forms.ComboBox();
            this.dtpShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.cbxBillType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbxSender = new System.Windows.Forms.ComboBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductConfirm = new System.Windows.Forms.Button();
            this.lstViewWayBill = new System.Windows.Forms.ListView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSenderContact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSenderPhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSenderAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReceiverContact = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReceiverPhone = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblReceiverAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDriver.Location = new System.Drawing.Point(24, 231);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(59, 17);
            this.lblDriver.TabIndex = 0;
            this.lblDriver.Text = "Sürücü";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVehicle.Location = new System.Drawing.Point(24, 263);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(41, 17);
            this.lblVehicle.TabIndex = 1;
            this.lblVehicle.Text = "Araç";
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReceiver.Location = new System.Drawing.Point(463, 45);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(38, 17);
            this.lblReceiver.TabIndex = 3;
            this.lblReceiver.Text = "Alıcı";
            // 
            // lblShipmentDate
            // 
            this.lblShipmentDate.AutoSize = true;
            this.lblShipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShipmentDate.Location = new System.Drawing.Point(24, 196);
            this.lblShipmentDate.Name = "lblShipmentDate";
            this.lblShipmentDate.Size = new System.Drawing.Size(130, 17);
            this.lblShipmentDate.TabIndex = 4;
            this.lblShipmentDate.Text = "Yola Çıkım Tarihi";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(455, 196);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(102, 17);
            this.lblDeliveryDate.TabIndex = 5;
            this.lblDeliveryDate.Text = "Teslim Tarihi";
            // 
            // lblBillType
            // 
            this.lblBillType.AutoSize = true;
            this.lblBillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillType.Location = new System.Drawing.Point(24, 18);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(87, 17);
            this.lblBillType.TabIndex = 6;
            this.lblBillType.Text = "Fatura Tipi";
            // 
            // cbxDriver
            // 
            this.cbxDriver.FormattingEnabled = true;
            this.cbxDriver.Location = new System.Drawing.Point(204, 231);
            this.cbxDriver.Name = "cbxDriver";
            this.cbxDriver.Size = new System.Drawing.Size(121, 21);
            this.cbxDriver.TabIndex = 8;
            // 
            // cbxVehicle
            // 
            this.cbxVehicle.FormattingEnabled = true;
            this.cbxVehicle.Location = new System.Drawing.Point(204, 263);
            this.cbxVehicle.Name = "cbxVehicle";
            this.cbxVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbxVehicle.TabIndex = 9;
            // 
            // cbxReceiver
            // 
            this.cbxReceiver.FormattingEnabled = true;
            this.cbxReceiver.Location = new System.Drawing.Point(643, 45);
            this.cbxReceiver.Name = "cbxReceiver";
            this.cbxReceiver.Size = new System.Drawing.Size(121, 21);
            this.cbxReceiver.TabIndex = 10;
            this.cbxReceiver.SelectedIndexChanged += new System.EventHandler(this.CbxReceiver_SelectedIndexChanged);
            // 
            // dtpShipmentDate
            // 
            this.dtpShipmentDate.Location = new System.Drawing.Point(204, 196);
            this.dtpShipmentDate.Name = "dtpShipmentDate";
            this.dtpShipmentDate.Size = new System.Drawing.Size(121, 20);
            this.dtpShipmentDate.TabIndex = 11;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(635, 196);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDeliveryDate.TabIndex = 12;
            // 
            // cbxBillType
            // 
            this.cbxBillType.FormattingEnabled = true;
            this.cbxBillType.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cbxBillType.Location = new System.Drawing.Point(204, 18);
            this.cbxBillType.Name = "cbxBillType";
            this.cbxBillType.Size = new System.Drawing.Size(121, 21);
            this.cbxBillType.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(17, 517);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 25);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.Location = new System.Drawing.Point(772, 517);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 25);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // cbxSender
            // 
            this.cbxSender.FormattingEnabled = true;
            this.cbxSender.Location = new System.Drawing.Point(204, 42);
            this.cbxSender.Name = "cbxSender";
            this.cbxSender.Size = new System.Drawing.Size(121, 21);
            this.cbxSender.TabIndex = 17;
            this.cbxSender.SelectedIndexChanged += new System.EventHandler(this.CbxSender_SelectedIndexChanged);
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSender.Location = new System.Drawing.Point(24, 45);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(78, 17);
            this.lblSender.TabIndex = 16;
            this.lblSender.Text = "Gönderici";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReceiverAddress);
            this.groupBox1.Controls.Add(this.lblReceiverContact);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblReceiverPhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(467, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(377, 124);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSenderAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblSenderPhone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblSenderContact);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(27, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(377, 125);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // btnProductConfirm
            // 
            this.btnProductConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductConfirm.Location = new System.Drawing.Point(815, 257);
            this.btnProductConfirm.Name = "btnProductConfirm";
            this.btnProductConfirm.Size = new System.Drawing.Size(78, 25);
            this.btnProductConfirm.TabIndex = 15;
            this.btnProductConfirm.Text = "Ekle";
            this.btnProductConfirm.UseVisualStyleBackColor = true;
            this.btnProductConfirm.Click += new System.EventHandler(this.BtnProductConfirm_Click);
            // 
            // lstViewWayBill
            // 
            this.lstViewWayBill.GridLines = true;
            this.lstViewWayBill.HideSelection = false;
            this.lstViewWayBill.Location = new System.Drawing.Point(17, 298);
            this.lstViewWayBill.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewWayBill.Name = "lstViewWayBill";
            this.lstViewWayBill.Size = new System.Drawing.Size(876, 204);
            this.lstViewWayBill.TabIndex = 19;
            this.lstViewWayBill.UseCompatibleStateImageBehavior = false;
            this.lstViewWayBill.View = System.Windows.Forms.View.Details;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.Location = new System.Drawing.Point(446, 233);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(43, 17);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Ürün";
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(508, 231);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(248, 21);
            this.cbxProduct.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(446, 263);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(41, 17);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Adet";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(508, 260);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(59, 20);
            this.nudQuantity.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(689, 259);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(120, 20);
            this.txtDescription.TabIndex = 21;
            // 
            // lblSenderContact
            // 
            this.lblSenderContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderContact.Location = new System.Drawing.Point(147, 15);
            this.lblSenderContact.Name = "lblSenderContact";
            this.lblSenderContact.Size = new System.Drawing.Size(151, 23);
            this.lblSenderContact.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Muhattap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Telefon";
            // 
            // lblSenderPhone
            // 
            this.lblSenderPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderPhone.Location = new System.Drawing.Point(147, 52);
            this.lblSenderPhone.Name = "lblSenderPhone";
            this.lblSenderPhone.Size = new System.Drawing.Size(151, 23);
            this.lblSenderPhone.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Adres";
            // 
            // lblSenderAddress
            // 
            this.lblSenderAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderAddress.Location = new System.Drawing.Point(147, 88);
            this.lblSenderAddress.Name = "lblSenderAddress";
            this.lblSenderAddress.Size = new System.Drawing.Size(225, 35);
            this.lblSenderAddress.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Muhattap";
            // 
            // lblReceiverContact
            // 
            this.lblReceiverContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverContact.Location = new System.Drawing.Point(168, 14);
            this.lblReceiverContact.Name = "lblReceiverContact";
            this.lblReceiverContact.Size = new System.Drawing.Size(151, 23);
            this.lblReceiverContact.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(50, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Telefon";
            // 
            // lblReceiverPhone
            // 
            this.lblReceiverPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverPhone.Location = new System.Drawing.Point(168, 51);
            this.lblReceiverPhone.Name = "lblReceiverPhone";
            this.lblReceiverPhone.Size = new System.Drawing.Size(151, 23);
            this.lblReceiverPhone.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(50, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Adres";
            // 
            // lblReceiverAddress
            // 
            this.lblReceiverAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverAddress.Location = new System.Drawing.Point(168, 89);
            this.lblReceiverAddress.Name = "lblReceiverAddress";
            this.lblReceiverAddress.Size = new System.Drawing.Size(204, 33);
            this.lblReceiverAddress.TabIndex = 46;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(583, 261);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // FormWayBillAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 548);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lstViewWayBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxSender);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.btnProductConfirm);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbxBillType);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.dtpShipmentDate);
            this.Controls.Add(this.cbxReceiver);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.cbxVehicle);
            this.Controls.Add(this.cbxDriver);
            this.Controls.Add(this.lblBillType);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblShipmentDate);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblDriver);
            this.Name = "FormWayBillAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Waybill";
            this.Load += new System.EventHandler(this.FormWayBillAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblShipmentDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.ComboBox cbxDriver;
        private System.Windows.Forms.ComboBox cbxVehicle;
        private System.Windows.Forms.ComboBox cbxReceiver;
        private System.Windows.Forms.DateTimePicker dtpShipmentDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.ComboBox cbxBillType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cbxSender;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProductConfirm;
        private System.Windows.Forms.ListView lstViewWayBill;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblReceiverAddress;
        private System.Windows.Forms.Label lblReceiverContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReceiverPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSenderAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSenderPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSenderContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescription;
    }
}