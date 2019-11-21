namespace Sevkiyat.UI
{
    partial class FormWayBillUpdate
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
            this.lstViewProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxSender = new System.Windows.Forms.ComboBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cbxWaybillType = new System.Windows.Forms.ComboBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShipDate = new System.Windows.Forms.DateTimePicker();
            this.cbxReceiver = new System.Windows.Forms.ComboBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.cbxVehicle = new System.Windows.Forms.ComboBox();
            this.cbxDriver = new System.Windows.Forms.ComboBox();
            this.lbl_billType = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.lbl_shipmentDate = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vechile = new System.Windows.Forms.Label();
            this.lbl_driver = new System.Windows.Forms.Label();
            this.lblWaybillID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxWayBillID = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSenderAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSenderPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSenderContact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReceiverAddress = new System.Windows.Forms.Label();
            this.lblReceiverContact = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReceiverPhone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewProducts
            // 
            this.lstViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.lstViewProducts.GridLines = true;
            this.lstViewProducts.HideSelection = false;
            this.lstViewProducts.Location = new System.Drawing.Point(11, 322);
            this.lstViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewProducts.Name = "lstViewProducts";
            this.lstViewProducts.Size = new System.Drawing.Size(876, 204);
            this.lstViewProducts.TabIndex = 41;
            this.lstViewProducts.UseCompatibleStateImageBehavior = false;
            this.lstViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 743;
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
            // cbxSender
            // 
            this.cbxSender.FormattingEnabled = true;
            this.cbxSender.Location = new System.Drawing.Point(198, 69);
            this.cbxSender.Name = "cbxSender";
            this.cbxSender.Size = new System.Drawing.Size(121, 21);
            this.cbxSender.TabIndex = 38;
            this.cbxSender.SelectedIndexChanged += new System.EventHandler(this.CbxSender_SelectedIndexChanged);
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sender.Location = new System.Drawing.Point(11, 69);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(78, 17);
            this.lbl_sender.TabIndex = 37;
            this.lbl_sender.Text = "Gönderici";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(767, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 25);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirm.Location = new System.Drawing.Point(793, 638);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(120, 25);
            this.btn_confirm.TabIndex = 35;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(38, 638);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 25);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cbxWaybillType
            // 
            this.cbxWaybillType.FormattingEnabled = true;
            this.cbxWaybillType.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cbxWaybillType.Location = new System.Drawing.Point(198, 42);
            this.cbxWaybillType.Name = "cbxWaybillType";
            this.cbxWaybillType.Size = new System.Drawing.Size(121, 21);
            this.cbxWaybillType.TabIndex = 33;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(606, 220);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDeliveryDate.TabIndex = 32;
            // 
            // dtpShipDate
            // 
            this.dtpShipDate.Location = new System.Drawing.Point(198, 220);
            this.dtpShipDate.Name = "dtpShipDate";
            this.dtpShipDate.Size = new System.Drawing.Size(121, 20);
            this.dtpShipDate.TabIndex = 31;
            // 
            // cbxReceiver
            // 
            this.cbxReceiver.FormattingEnabled = true;
            this.cbxReceiver.Location = new System.Drawing.Point(617, 69);
            this.cbxReceiver.Name = "cbxReceiver";
            this.cbxReceiver.Size = new System.Drawing.Size(121, 21);
            this.cbxReceiver.TabIndex = 30;
            this.cbxReceiver.SelectedIndexChanged += new System.EventHandler(this.CbxReceiver_SelectedIndexChanged);
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(490, 252);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(237, 21);
            this.cbxProduct.TabIndex = 29;
            // 
            // cbxVehicle
            // 
            this.cbxVehicle.FormattingEnabled = true;
            this.cbxVehicle.Location = new System.Drawing.Point(198, 287);
            this.cbxVehicle.Name = "cbxVehicle";
            this.cbxVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbxVehicle.TabIndex = 28;
            // 
            // cbxDriver
            // 
            this.cbxDriver.FormattingEnabled = true;
            this.cbxDriver.Location = new System.Drawing.Point(198, 255);
            this.cbxDriver.Name = "cbxDriver";
            this.cbxDriver.Size = new System.Drawing.Size(121, 21);
            this.cbxDriver.TabIndex = 27;
            // 
            // lbl_billType
            // 
            this.lbl_billType.AutoSize = true;
            this.lbl_billType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_billType.Location = new System.Drawing.Point(11, 42);
            this.lbl_billType.Name = "lbl_billType";
            this.lbl_billType.Size = new System.Drawing.Size(92, 17);
            this.lbl_billType.TabIndex = 26;
            this.lbl_billType.Text = "İrsaliye Tipi";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deliveryDate.Location = new System.Drawing.Point(434, 220);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(103, 17);
            this.lbl_deliveryDate.TabIndex = 25;
            this.lbl_deliveryDate.Text = "Ulaşım Tarihi";
            // 
            // lbl_shipmentDate
            // 
            this.lbl_shipmentDate.AutoSize = true;
            this.lbl_shipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shipmentDate.Location = new System.Drawing.Point(11, 220);
            this.lbl_shipmentDate.Name = "lbl_shipmentDate";
            this.lbl_shipmentDate.Size = new System.Drawing.Size(113, 17);
            this.lbl_shipmentDate.TabIndex = 24;
            this.lbl_shipmentDate.Text = "Gönderi Tarihi";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receiver.Location = new System.Drawing.Point(437, 69);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(38, 17);
            this.lbl_receiver.TabIndex = 23;
            this.lbl_receiver.Text = "Alıcı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(436, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ürün";
            // 
            // lbl_vechile
            // 
            this.lbl_vechile.AutoSize = true;
            this.lbl_vechile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vechile.Location = new System.Drawing.Point(11, 287);
            this.lbl_vechile.Name = "lbl_vechile";
            this.lbl_vechile.Size = new System.Drawing.Size(41, 17);
            this.lbl_vechile.TabIndex = 22;
            this.lbl_vechile.Text = "Araç";
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_driver.Location = new System.Drawing.Point(11, 255);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(59, 17);
            this.lbl_driver.TabIndex = 20;
            this.lbl_driver.Text = "Sürücü";
            // 
            // lblWaybillID
            // 
            this.lblWaybillID.AutoSize = true;
            this.lblWaybillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaybillID.Location = new System.Drawing.Point(11, 9);
            this.lblWaybillID.Name = "lblWaybillID";
            this.lblWaybillID.Size = new System.Drawing.Size(105, 17);
            this.lblWaybillID.TabIndex = 44;
            this.lblWaybillID.Text = "İrsaliye kodu:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(11, 546);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 25);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Seçili Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(767, 546);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 25);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cbxWayBillID
            // 
            this.cbxWayBillID.FormattingEnabled = true;
            this.cbxWayBillID.Location = new System.Drawing.Point(198, 9);
            this.cbxWayBillID.Name = "cbxWayBillID";
            this.cbxWayBillID.Size = new System.Drawing.Size(121, 21);
            this.cbxWayBillID.TabIndex = 47;
            this.cbxWayBillID.SelectedIndexChanged += new System.EventHandler(this.CbxWayBillID_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(499, 287);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(56, 20);
            this.nudQuantity.TabIndex = 49;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(437, 290);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(41, 17);
            this.lblQuantity.TabIndex = 48;
            this.lblQuantity.Text = "Adet";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(655, 290);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(105, 20);
            this.txtDescription.TabIndex = 51;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(559, 291);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 17);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSenderAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblSenderPhone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblSenderContact);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(377, 125);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // lblSenderAddress
            // 
            this.lblSenderAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderAddress.Location = new System.Drawing.Point(147, 88);
            this.lblSenderAddress.Name = "lblSenderAddress";
            this.lblSenderAddress.Size = new System.Drawing.Size(225, 35);
            this.lblSenderAddress.TabIndex = 46;
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
            // lblSenderPhone
            // 
            this.lblSenderPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenderPhone.Location = new System.Drawing.Point(147, 52);
            this.lblSenderPhone.Name = "lblSenderPhone";
            this.lblSenderPhone.Size = new System.Drawing.Size(151, 23);
            this.lblSenderPhone.TabIndex = 46;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReceiverAddress);
            this.groupBox1.Controls.Add(this.lblReceiverContact);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblReceiverPhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(454, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(377, 124);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblReceiverAddress
            // 
            this.lblReceiverAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverAddress.Location = new System.Drawing.Point(168, 89);
            this.lblReceiverAddress.Name = "lblReceiverAddress";
            this.lblReceiverAddress.Size = new System.Drawing.Size(204, 33);
            this.lblReceiverAddress.TabIndex = 46;
            // 
            // lblReceiverContact
            // 
            this.lblReceiverContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverContact.Location = new System.Drawing.Point(168, 14);
            this.lblReceiverContact.Name = "lblReceiverContact";
            this.lblReceiverContact.Size = new System.Drawing.Size(151, 23);
            this.lblReceiverContact.TabIndex = 46;
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
            // lblReceiverPhone
            // 
            this.lblReceiverPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiverPhone.Location = new System.Drawing.Point(168, 51);
            this.lblReceiverPhone.Name = "lblReceiverPhone";
            this.lblReceiverPhone.Size = new System.Drawing.Size(151, 23);
            this.lblReceiverPhone.TabIndex = 46;
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
            // FormWayBillUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cbxWayBillID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblWaybillID);
            this.Controls.Add(this.lstViewProducts);
            this.Controls.Add(this.cbxSender);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cbxWaybillType);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.dtpShipDate);
            this.Controls.Add(this.cbxReceiver);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.cbxVehicle);
            this.Controls.Add(this.cbxDriver);
            this.Controls.Add(this.lbl_billType);
            this.Controls.Add(this.lbl_deliveryDate);
            this.Controls.Add(this.lbl_shipmentDate);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_vechile);
            this.Controls.Add(this.lbl_driver);
            this.Name = "FormWayBillUpdate";
            this.Text = "FormWayBillUpdate";
            this.Load += new System.EventHandler(this.FormWayBillUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbxSender;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cbxWaybillType;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpShipDate;
        private System.Windows.Forms.ComboBox cbxReceiver;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.ComboBox cbxVehicle;
        private System.Windows.Forms.ComboBox cbxDriver;
        private System.Windows.Forms.Label lbl_billType;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Label lbl_shipmentDate;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_vechile;
        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.Label lblWaybillID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxWayBillID;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSenderAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSenderPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSenderContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReceiverAddress;
        private System.Windows.Forms.Label lblReceiverContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReceiverPhone;
        private System.Windows.Forms.Label label9;
    }
}