namespace Remax_Project.GUI
{
    partial class frmUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridHouses = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtRefNumber = new System.Windows.Forms.TextBox();
            this.radRefNumber = new System.Windows.Forms.RadioButton();
            this.radEmployeeId = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Houses";
            // 
            // gridHouses
            // 
            this.gridHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHouses.Location = new System.Drawing.Point(12, 380);
            this.gridHouses.Name = "gridHouses";
            this.gridHouses.RowTemplate.Height = 24;
            this.gridHouses.Size = new System.Drawing.Size(699, 198);
            this.gridHouses.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboAgent);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtRefNumber);
            this.groupBox1.Controls.Add(this.radRefNumber);
            this.groupBox1.Controls.Add(this.radEmployeeId);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(234, 32);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(201, 28);
            this.cboAgent.TabIndex = 12;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(453, 32);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(83, 69);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // txtRefNumber
            // 
            this.txtRefNumber.Location = new System.Drawing.Point(234, 77);
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.Size = new System.Drawing.Size(203, 27);
            this.txtRefNumber.TabIndex = 10;
            // 
            // radRefNumber
            // 
            this.radRefNumber.AutoSize = true;
            this.radRefNumber.Location = new System.Drawing.Point(0, 77);
            this.radRefNumber.Name = "radRefNumber";
            this.radRefNumber.Size = new System.Drawing.Size(212, 24);
            this.radRefNumber.TabIndex = 9;
            this.radRefNumber.TabStop = true;
            this.radRefNumber.Text = "by Reference Number";
            this.radRefNumber.UseVisualStyleBackColor = true;
            // 
            // radEmployeeId
            // 
            this.radEmployeeId.AutoSize = true;
            this.radEmployeeId.Location = new System.Drawing.Point(0, 32);
            this.radEmployeeId.Name = "radEmployeeId";
            this.radEmployeeId.Size = new System.Drawing.Size(161, 24);
            this.radEmployeeId.TabIndex = 8;
            this.radEmployeeId.TabStop = true;
            this.radEmployeeId.Text = "by Employee ID";
            this.radEmployeeId.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridHouses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridHouses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtRefNumber;
        private System.Windows.Forms.RadioButton radRefNumber;
        private System.Windows.Forms.RadioButton radEmployeeId;
    }
}