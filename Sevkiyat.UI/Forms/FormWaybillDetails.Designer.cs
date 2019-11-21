namespace Sevkiyat.UI.Forms
{
    partial class FormWaybillDetails
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
            this.lbl_sender = new System.Windows.Forms.Label();
            this.lbl_billType = new System.Windows.Forms.Label();
            this.lstViewProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBllType = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.lbl_shipmentDate = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_vechile = new System.Windows.Forms.Label();
            this.lbl_driver = new System.Windows.Forms.Label();
            this.lblWayBillSelect = new System.Windows.Forms.Label();
            this.cbxWayBillSelect = new System.Windows.Forms.ComboBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblBillType = new System.Windows.Forms.Label();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblShipmentDate = new System.Windows.Forms.Label();
            this.lblSenderAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSenderPhone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSenderContact = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReceiverAddress = new System.Windows.Forms.Label();
            this.lblReceiverContact = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReceiverPhone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sender.Location = new System.Drawing.Point(-112, 141);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(60, 17);
            this.lbl_sender.TabIndex = 23;
            this.lbl_sender.Text = "Sender";
            // 
            // lbl_billType
            // 
            this.lbl_billType.AutoSize = true;
            this.lbl_billType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_billType.Location = new System.Drawing.Point(-112, 114);
            this.lbl_billType.Name = "lbl_billType";
            this.lbl_billType.Size = new System.Drawing.Size(71, 17);
            this.lbl_billType.TabIndex = 20;
            this.lbl_billType.Text = "Bill Type";
            // 
            // lstViewProducts
            // 
            this.lstViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.lstViewProducts.GridLines = true;
            this.lstViewProducts.HideSelection = false;
            this.lstViewProducts.Location = new System.Drawing.Point(17, 321);
            this.lstViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewProducts.Name = "lstViewProducts";
            this.lstViewProducts.Size = new System.Drawing.Size(876, 204);
            this.lstViewProducts.TabIndex = 43;
            this.lstViewProducts.UseCompatibleStateImageBehavior = false;
            this.lstViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 506;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Miktar Cinsi";
            this.columnHeader4.Width = 283;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 161;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSenderAddress);
            this.groupBox2.Controls.Add(this.lblSenderContact);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSenderPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(27, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(377, 125);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReceiverAddress);
            this.groupBox1.Controls.Add(this.lblReceiverContact);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblReceiverPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(467, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(377, 124);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sender";
            // 
            // lblBllType
            // 
            this.lblBllType.AutoSize = true;
            this.lblBllType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBllType.Location = new System.Drawing.Point(24, 34);
            this.lblBllType.Name = "lblBllType";
            this.lblBllType.Size = new System.Drawing.Size(71, 17);
            this.lblBllType.TabIndex = 30;
            this.lblBllType.Text = "Bill Type";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deliveryDate.Location = new System.Drawing.Point(463, 221);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(106, 17);
            this.lbl_deliveryDate.TabIndex = 29;
            this.lbl_deliveryDate.Text = "Delivery Date";
            // 
            // lbl_shipmentDate
            // 
            this.lbl_shipmentDate.AutoSize = true;
            this.lbl_shipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shipmentDate.Location = new System.Drawing.Point(24, 222);
            this.lbl_shipmentDate.Name = "lbl_shipmentDate";
            this.lbl_shipmentDate.Size = new System.Drawing.Size(114, 17);
            this.lbl_shipmentDate.TabIndex = 28;
            this.lbl_shipmentDate.Text = "Shipment Date";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receiver.Location = new System.Drawing.Point(463, 68);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(72, 17);
            this.lbl_receiver.TabIndex = 27;
            this.lbl_receiver.Text = "Receiver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(397, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ürün Listesi";
            // 
            // lbl_vechile
            // 
            this.lbl_vechile.AutoSize = true;
            this.lbl_vechile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vechile.Location = new System.Drawing.Point(24, 275);
            this.lbl_vechile.Name = "lbl_vechile";
            this.lbl_vechile.Size = new System.Drawing.Size(61, 17);
            this.lbl_vechile.TabIndex = 26;
            this.lbl_vechile.Text = "Vechile";
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_driver.Location = new System.Drawing.Point(24, 246);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(52, 17);
            this.lbl_driver.TabIndex = 24;
            this.lbl_driver.Text = "Driver";
            // 
            // lblWayBillSelect
            // 
            this.lblWayBillSelect.AutoSize = true;
            this.lblWayBillSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWayBillSelect.Location = new System.Drawing.Point(227, 9);
            this.lblWayBillSelect.Name = "lblWayBillSelect";
            this.lblWayBillSelect.Size = new System.Drawing.Size(122, 17);
            this.lblWayBillSelect.TabIndex = 30;
            this.lblWayBillSelect.Text = "Irsaliye Seçiniz:";
            // 
            // cbxWayBillSelect
            // 
            this.cbxWayBillSelect.FormattingEnabled = true;
            this.cbxWayBillSelect.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cbxWayBillSelect.Location = new System.Drawing.Point(355, 8);
            this.cbxWayBillSelect.Name = "cbxWayBillSelect";
            this.cbxWayBillSelect.Size = new System.Drawing.Size(320, 21);
            this.cbxWayBillSelect.TabIndex = 37;
            this.cbxWayBillSelect.SelectedIndexChanged += new System.EventHandler(this.CbxWayBillSelect_SelectedIndexChanged);
            // 
            // lblSender
            // 
            this.lblSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSender.Location = new System.Drawing.Point(142, 64);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(151, 23);
            this.lblSender.TabIndex = 44;
            // 
            // lblBillType
            // 
            this.lblBillType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBillType.Location = new System.Drawing.Point(142, 34);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(151, 23);
            this.lblBillType.TabIndex = 44;
            // 
            // lblReceiver
            // 
            this.lblReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiver.Location = new System.Drawing.Point(575, 68);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(151, 23);
            this.lblReceiver.TabIndex = 44;
            // 
            // lblDriver
            // 
            this.lblDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDriver.Location = new System.Drawing.Point(142, 246);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(151, 23);
            this.lblDriver.TabIndex = 44;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeliveryDate.Location = new System.Drawing.Point(575, 222);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(151, 23);
            this.lblDeliveryDate.TabIndex = 44;
            // 
            // lblVehicle
            // 
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.Location = new System.Drawing.Point(142, 276);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(151, 23);
            this.lblVehicle.TabIndex = 44;
            // 
            // lblShipmentDate
            // 
            this.lblShipmentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipmentDate.Location = new System.Drawing.Point(142, 216);
            this.lblShipmentDate.Name = "lblShipmentDate";
            this.lblShipmentDate.Size = new System.Drawing.Size(151, 23);
            this.lblShipmentDate.TabIndex = 44;
            // 
            // lblSenderAddress
            // 
            this.lblSenderAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderAddress.Location = new System.Drawing.Point(142, 88);
            this.lblSenderAddress.Name = "lblSenderAddress";
            this.lblSenderAddress.Size = new System.Drawing.Size(225, 35);
            this.lblSenderAddress.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Adres";
            // 
            // lblSenderPhone
            // 
            this.lblSenderPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderPhone.Location = new System.Drawing.Point(142, 52);
            this.lblSenderPhone.Name = "lblSenderPhone";
            this.lblSenderPhone.Size = new System.Drawing.Size(151, 23);
            this.lblSenderPhone.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Telefon";
            // 
            // lblSenderContact
            // 
            this.lblSenderContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderContact.Location = new System.Drawing.Point(142, 15);
            this.lblSenderContact.Name = "lblSenderContact";
            this.lblSenderContact.Size = new System.Drawing.Size(151, 23);
            this.lblSenderContact.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Muhattap";
            // 
            // lblReceiverAddress
            // 
            this.lblReceiverAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverAddress.Location = new System.Drawing.Point(154, 89);
            this.lblReceiverAddress.Name = "lblReceiverAddress";
            this.lblReceiverAddress.Size = new System.Drawing.Size(204, 33);
            this.lblReceiverAddress.TabIndex = 50;
            // 
            // lblReceiverContact
            // 
            this.lblReceiverContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverContact.Location = new System.Drawing.Point(154, 14);
            this.lblReceiverContact.Name = "lblReceiverContact";
            this.lblReceiverContact.Size = new System.Drawing.Size(151, 23);
            this.lblReceiverContact.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(36, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Muhattap";
            // 
            // lblReceiverPhone
            // 
            this.lblReceiverPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverPhone.Location = new System.Drawing.Point(154, 51);
            this.lblReceiverPhone.Name = "lblReceiverPhone";
            this.lblReceiverPhone.Size = new System.Drawing.Size(151, 23);
            this.lblReceiverPhone.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(36, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Telefon";
            // 
            // FormWaybillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 530);
            this.Controls.Add(this.lblShipmentDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblBillType);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lstViewProducts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxWayBillSelect);
            this.Controls.Add(this.lblWayBillSelect);
            this.Controls.Add(this.lblBllType);
            this.Controls.Add(this.lbl_deliveryDate);
            this.Controls.Add(this.lbl_shipmentDate);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_vechile);
            this.Controls.Add(this.lbl_driver);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.lbl_billType);
            this.Name = "FormWaybillDetails";
            this.Text = "FormWaybillDetails";
            this.Load += new System.EventHandler(this.FormWaybillDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.Label lbl_billType;
        private System.Windows.Forms.ListView lstViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBllType;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Label lbl_shipmentDate;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_vechile;
        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.Label lblWayBillSelect;
        private System.Windows.Forms.ComboBox cbxWayBillSelect;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblShipmentDate;
        private System.Windows.Forms.Label lblSenderAddress;
        private System.Windows.Forms.Label lblSenderContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSenderPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReceiverAddress;
        private System.Windows.Forms.Label lblReceiverContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblReceiverPhone;
        private System.Windows.Forms.Label label7;
    }
}