namespace Remax_Project.GUI
{
    partial class frmAgent
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
            this.Houses = new System.Windows.Forms.TabControl();
            this.tabHouses = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.cboSelectHouse = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHouseId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridHouses = new System.Windows.Forms.DataGridView();
            this.tabSellers = new System.Windows.Forms.TabPage();
            this.txtSHouseId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gridSellers = new System.Windows.Forms.DataGridView();
            this.tabBuyers = new System.Windows.Forms.TabPage();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBPhoneNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBuyerId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gridBuyers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelectSeller = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cboSelectBuyer = new System.Windows.Forms.ComboBox();
            this.Houses.SuspendLayout();
            this.tabHouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).BeginInit();
            this.tabSellers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSellers)).BeginInit();
            this.tabBuyers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Houses
            // 
            this.Houses.Controls.Add(this.tabHouses);
            this.Houses.Controls.Add(this.tabSellers);
            this.Houses.Controls.Add(this.tabBuyers);
            this.Houses.Location = new System.Drawing.Point(12, 127);
            this.Houses.Name = "Houses";
            this.Houses.SelectedIndex = 0;
            this.Houses.Size = new System.Drawing.Size(722, 484);
            this.Houses.TabIndex = 1;
            // 
            // tabHouses
            // 
            this.tabHouses.Controls.Add(this.label18);
            this.tabHouses.Controls.Add(this.cboSelectHouse);
            this.tabHouses.Controls.Add(this.btnDelete);
            this.tabHouses.Controls.Add(this.btnSave);
            this.tabHouses.Controls.Add(this.btnEditt);
            this.tabHouses.Controls.Add(this.btnAdd);
            this.tabHouses.Controls.Add(this.txtSize);
            this.tabHouses.Controls.Add(this.label7);
            this.tabHouses.Controls.Add(this.txtPrice);
            this.tabHouses.Controls.Add(this.label6);
            this.tabHouses.Controls.Add(this.txtAddress);
            this.tabHouses.Controls.Add(this.label5);
            this.tabHouses.Controls.Add(this.txtLocation);
            this.tabHouses.Controls.Add(this.label4);
            this.tabHouses.Controls.Add(this.txtHouseId);
            this.tabHouses.Controls.Add(this.label1);
            this.tabHouses.Controls.Add(this.gridHouses);
            this.tabHouses.Location = new System.Drawing.Point(4, 29);
            this.tabHouses.Name = "tabHouses";
            this.tabHouses.Padding = new System.Windows.Forms.Padding(3);
            this.tabHouses.Size = new System.Drawing.Size(714, 451);
            this.tabHouses.TabIndex = 0;
            this.tabHouses.Text = "Houses";
            this.tabHouses.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "Select House";
            // 
            // cboSelectHouse
            // 
            this.cboSelectHouse.FormattingEnabled = true;
            this.cboSelectHouse.Location = new System.Drawing.Point(223, 7);
            this.cboSelectHouse.Name = "cboSelectHouse";
            this.cboSelectHouse.Size = new System.Drawing.Size(179, 28);
            this.cboSelectHouse.TabIndex = 15;
            this.cboSelectHouse.SelectedIndexChanged += new System.EventHandler(this.cboSelectHouse_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(554, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 48);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(554, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 48);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEditt
            // 
            this.btnEditt.Location = new System.Drawing.Point(554, 84);
            this.btnEditt.Name = "btnEditt";
            this.btnEditt.Size = new System.Drawing.Size(96, 48);
            this.btnEditt.TabIndex = 12;
            this.btnEditt.Text = "Edit";
            this.btnEditt.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(554, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 48);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(223, 215);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(179, 27);
            this.txtSize.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Size";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(223, 182);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 27);
            this.txtPrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(223, 149);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 27);
            this.txtAddress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(223, 114);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(179, 27);
            this.txtLocation.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            // 
            // txtHouseId
            // 
            this.txtHouseId.Location = new System.Drawing.Point(223, 81);
            this.txtHouseId.Name = "txtHouseId";
            this.txtHouseId.Size = new System.Drawing.Size(179, 27);
            this.txtHouseId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reference Number";
            // 
            // gridHouses
            // 
            this.gridHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHouses.Location = new System.Drawing.Point(7, 281);
            this.gridHouses.Name = "gridHouses";
            this.gridHouses.RowTemplate.Height = 24;
            this.gridHouses.Size = new System.Drawing.Size(691, 164);
            this.gridHouses.TabIndex = 0;
            // 
            // tabSellers
            // 
            this.tabSellers.Controls.Add(this.label19);
            this.tabSellers.Controls.Add(this.cboSelectSeller);
            this.tabSellers.Controls.Add(this.txtSHouseId);
            this.tabSellers.Controls.Add(this.label8);
            this.tabSellers.Controls.Add(this.txtPhoneNumber);
            this.tabSellers.Controls.Add(this.label9);
            this.tabSellers.Controls.Add(this.txtSEmail);
            this.tabSellers.Controls.Add(this.label10);
            this.tabSellers.Controls.Add(this.txtSellerName);
            this.tabSellers.Controls.Add(this.label11);
            this.tabSellers.Controls.Add(this.txtSellerId);
            this.tabSellers.Controls.Add(this.label12);
            this.tabSellers.Controls.Add(this.gridSellers);
            this.tabSellers.Location = new System.Drawing.Point(4, 29);
            this.tabSellers.Name = "tabSellers";
            this.tabSellers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSellers.Size = new System.Drawing.Size(714, 451);
            this.tabSellers.TabIndex = 1;
            this.tabSellers.Text = "Sellers";
            this.tabSellers.UseVisualStyleBackColor = true;
            // 
            // txtSHouseId
            // 
            this.txtSHouseId.Location = new System.Drawing.Point(190, 199);
            this.txtSHouseId.Name = "txtSHouseId";
            this.txtSHouseId.Size = new System.Drawing.Size(100, 27);
            this.txtSHouseId.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "House ID";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(190, 169);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 27);
            this.txtPhoneNumber.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone Number";
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(190, 137);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(100, 27);
            this.txtSEmail.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Email";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(190, 108);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(100, 27);
            this.txtSellerName.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Name";
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(190, 73);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(100, 27);
            this.txtSellerId.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Seller ID";
            // 
            // gridSellers
            // 
            this.gridSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSellers.Location = new System.Drawing.Point(6, 250);
            this.gridSellers.Name = "gridSellers";
            this.gridSellers.RowTemplate.Height = 24;
            this.gridSellers.Size = new System.Drawing.Size(691, 164);
            this.gridSellers.TabIndex = 1;
            // 
            // tabBuyers
            // 
            this.tabBuyers.Controls.Add(this.label20);
            this.tabBuyers.Controls.Add(this.cboSelectBuyer);
            this.tabBuyers.Controls.Add(this.txtBirthdate);
            this.tabBuyers.Controls.Add(this.label13);
            this.tabBuyers.Controls.Add(this.txtBPhoneNumber);
            this.tabBuyers.Controls.Add(this.label14);
            this.tabBuyers.Controls.Add(this.txtBEmail);
            this.tabBuyers.Controls.Add(this.label15);
            this.tabBuyers.Controls.Add(this.txtBuyerName);
            this.tabBuyers.Controls.Add(this.label16);
            this.tabBuyers.Controls.Add(this.txtBuyerId);
            this.tabBuyers.Controls.Add(this.label17);
            this.tabBuyers.Controls.Add(this.gridBuyers);
            this.tabBuyers.Location = new System.Drawing.Point(4, 29);
            this.tabBuyers.Name = "tabBuyers";
            this.tabBuyers.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuyers.Size = new System.Drawing.Size(714, 451);
            this.tabBuyers.TabIndex = 2;
            this.tabBuyers.Text = "Buyers";
            this.tabBuyers.UseVisualStyleBackColor = true;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(190, 215);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(100, 27);
            this.txtBirthdate.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Birthdate";
            // 
            // txtBPhoneNumber
            // 
            this.txtBPhoneNumber.Location = new System.Drawing.Point(190, 180);
            this.txtBPhoneNumber.Name = "txtBPhoneNumber";
            this.txtBPhoneNumber.Size = new System.Drawing.Size(100, 27);
            this.txtBPhoneNumber.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Phone Number";
            // 
            // txtBEmail
            // 
            this.txtBEmail.Location = new System.Drawing.Point(190, 145);
            this.txtBEmail.Name = "txtBEmail";
            this.txtBEmail.Size = new System.Drawing.Size(100, 27);
            this.txtBEmail.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Email";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(190, 110);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(100, 27);
            this.txtBuyerName.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Name";
            // 
            // txtBuyerId
            // 
            this.txtBuyerId.Location = new System.Drawing.Point(190, 75);
            this.txtBuyerId.Name = "txtBuyerId";
            this.txtBuyerId.Size = new System.Drawing.Size(100, 27);
            this.txtBuyerId.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Buyer ID";
            // 
            // gridBuyers
            // 
            this.gridBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuyers.Location = new System.Drawing.Point(7, 251);
            this.gridBuyers.Name = "gridBuyers";
            this.gridBuyers.RowTemplate.Height = 24;
            this.gridBuyers.Size = new System.Drawing.Size(691, 164);
            this.gridBuyers.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUserId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 109);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(301, 34);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 57);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(130, 34);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(164, 27);
            this.txtUserId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID";
            // 
            // cboSelectSeller
            // 
            this.cboSelectSeller.FormattingEnabled = true;
            this.cboSelectSeller.Location = new System.Drawing.Point(190, 18);
            this.cboSelectSeller.Name = "cboSelectSeller";
            this.cboSelectSeller.Size = new System.Drawing.Size(179, 28);
            this.cboSelectSeller.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 22;
            this.label19.Text = "Select Seller";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 20);
            this.label20.TabIndex = 24;
            this.label20.Text = "Select Buyer";
            // 
            // cboSelectBuyer
            // 
            this.cboSelectBuyer.FormattingEnabled = true;
            this.cboSelectBuyer.Location = new System.Drawing.Point(190, 19);
            this.cboSelectBuyer.Name = "cboSelectBuyer";
            this.cboSelectBuyer.Size = new System.Drawing.Size(179, 28);
            this.cboSelectBuyer.TabIndex = 23;
            // 
            // frmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Houses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgent";
            this.Text = "frmAgent";
            this.Load += new System.EventHandler(this.frmAgent_Load);
            this.Houses.ResumeLayout(false);
            this.tabHouses.ResumeLayout(false);
            this.tabHouses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).EndInit();
            this.tabSellers.ResumeLayout(false);
            this.tabSellers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSellers)).EndInit();
            this.tabBuyers.ResumeLayout(false);
            this.tabBuyers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Houses;
        private System.Windows.Forms.TabPage tabHouses;
        private System.Windows.Forms.DataGridView gridHouses;
        private System.Windows.Forms.TabPage tabSellers;
        private System.Windows.Forms.DataGridView gridSellers;
        private System.Windows.Forms.TabPage tabBuyers;
        private System.Windows.Forms.DataGridView gridBuyers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHouseId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSHouseId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBuyerId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboSelectHouse;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboSelectSeller;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboSelectBuyer;
    }
}