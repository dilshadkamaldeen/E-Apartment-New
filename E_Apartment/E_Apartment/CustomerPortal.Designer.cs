namespace E_Apartment
{
    partial class CustomerPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPortal));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeaseAgreementId = new Guna.UI.WinForms.GunaTextBox();
            this.txtTenantId = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRequest = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtExtensionPeriods = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboStatus = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewExtension = new System.Windows.Forms.DataGridView();
            this.dataGridViewReserve = new System.Windows.Forms.DataGridView();
            this.dataGridViewOccupied = new System.Windows.Forms.DataGridView();
            this.dataGridViewApplication = new System.Windows.Forms.DataGridView();
            this.lblTenantId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccupied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Portal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(39, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 343);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewReserve);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reservation Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewOccupied);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Occupied Apartments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewApplication);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Applications";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewExtension);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.comboStatus);
            this.tabPage4.Controls.Add(this.txtExtensionPeriods);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.btnRequest);
            this.tabPage4.Controls.Add(this.txtTenantId);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtLeaseAgreementId);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(785, 317);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Request Lease Extension";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lease Agreement ID ";
            // 
            // txtLeaseAgreementId
            // 
            this.txtLeaseAgreementId.BaseColor = System.Drawing.Color.White;
            this.txtLeaseAgreementId.BorderColor = System.Drawing.Color.Silver;
            this.txtLeaseAgreementId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLeaseAgreementId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLeaseAgreementId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLeaseAgreementId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLeaseAgreementId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLeaseAgreementId.Location = new System.Drawing.Point(24, 45);
            this.txtLeaseAgreementId.Name = "txtLeaseAgreementId";
            this.txtLeaseAgreementId.PasswordChar = '\0';
            this.txtLeaseAgreementId.SelectedText = "";
            this.txtLeaseAgreementId.Size = new System.Drawing.Size(160, 30);
            this.txtLeaseAgreementId.TabIndex = 1;
            // 
            // txtTenantId
            // 
            this.txtTenantId.BaseColor = System.Drawing.Color.White;
            this.txtTenantId.BorderColor = System.Drawing.Color.Silver;
            this.txtTenantId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenantId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenantId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenantId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenantId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenantId.Location = new System.Drawing.Point(198, 45);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.PasswordChar = '\0';
            this.txtTenantId.SelectedText = "";
            this.txtTenantId.Size = new System.Drawing.Size(160, 30);
            this.txtTenantId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tenant ID ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUserName.Location = new System.Drawing.Point(703, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 18);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Jafran Jemal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Welcome ";
            // 
            // btnRequest
            // 
            this.btnRequest.AnimationHoverSpeed = 0.07F;
            this.btnRequest.AnimationSpeed = 0.03F;
            this.btnRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRequest.BorderColor = System.Drawing.Color.Black;
            this.btnRequest.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRequest.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRequest.CheckedForeColor = System.Drawing.Color.White;
            this.btnRequest.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRequest.CheckedImage")));
            this.btnRequest.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRequest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRequest.FocusedColor = System.Drawing.Color.Empty;
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnRequest.Image")));
            this.btnRequest.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRequest.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRequest.Location = new System.Drawing.Point(490, 91);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRequest.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRequest.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRequest.OnHoverImage = null;
            this.btnRequest.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRequest.OnPressedColor = System.Drawing.Color.Black;
            this.btnRequest.Size = new System.Drawing.Size(171, 38);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Make Request";
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // txtExtensionPeriods
            // 
            this.txtExtensionPeriods.BaseColor = System.Drawing.Color.White;
            this.txtExtensionPeriods.BorderColor = System.Drawing.Color.Silver;
            this.txtExtensionPeriods.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtensionPeriods.FocusedBaseColor = System.Drawing.Color.White;
            this.txtExtensionPeriods.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtExtensionPeriods.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtExtensionPeriods.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExtensionPeriods.Location = new System.Drawing.Point(374, 45);
            this.txtExtensionPeriods.Name = "txtExtensionPeriods";
            this.txtExtensionPeriods.PasswordChar = '\0';
            this.txtExtensionPeriods.SelectedText = "";
            this.txtExtensionPeriods.Size = new System.Drawing.Size(160, 30);
            this.txtExtensionPeriods.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Extension Periods in Month";
            // 
            // comboStatus
            // 
            this.comboStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboStatus.BaseColor = System.Drawing.Color.White;
            this.comboStatus.BorderColor = System.Drawing.Color.Silver;
            this.comboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FocusedColor = System.Drawing.Color.Empty;
            this.comboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboStatus.ForeColor = System.Drawing.Color.Black;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Request"});
            this.comboStatus.Location = new System.Drawing.Point(540, 49);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboStatus.Size = new System.Drawing.Size(121, 26);
            this.comboStatus.StartIndex = 0;
            this.comboStatus.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status";
            // 
            // dataGridViewExtension
            // 
            this.dataGridViewExtension.AllowUserToAddRows = false;
            this.dataGridViewExtension.AllowUserToDeleteRows = false;
            this.dataGridViewExtension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtension.Location = new System.Drawing.Point(24, 168);
            this.dataGridViewExtension.Name = "dataGridViewExtension";
            this.dataGridViewExtension.ReadOnly = true;
            this.dataGridViewExtension.Size = new System.Drawing.Size(740, 129);
            this.dataGridViewExtension.TabIndex = 9;
            // 
            // dataGridViewReserve
            // 
            this.dataGridViewReserve.AllowUserToAddRows = false;
            this.dataGridViewReserve.AllowUserToDeleteRows = false;
            this.dataGridViewReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserve.Location = new System.Drawing.Point(21, 54);
            this.dataGridViewReserve.Name = "dataGridViewReserve";
            this.dataGridViewReserve.ReadOnly = true;
            this.dataGridViewReserve.Size = new System.Drawing.Size(742, 242);
            this.dataGridViewReserve.TabIndex = 0;
            // 
            // dataGridViewOccupied
            // 
            this.dataGridViewOccupied.AllowUserToAddRows = false;
            this.dataGridViewOccupied.AllowUserToDeleteRows = false;
            this.dataGridViewOccupied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOccupied.Location = new System.Drawing.Point(21, 42);
            this.dataGridViewOccupied.Name = "dataGridViewOccupied";
            this.dataGridViewOccupied.ReadOnly = true;
            this.dataGridViewOccupied.Size = new System.Drawing.Size(744, 248);
            this.dataGridViewOccupied.TabIndex = 0;
            // 
            // dataGridViewApplication
            // 
            this.dataGridViewApplication.AllowUserToAddRows = false;
            this.dataGridViewApplication.AllowUserToDeleteRows = false;
            this.dataGridViewApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplication.Location = new System.Drawing.Point(24, 28);
            this.dataGridViewApplication.Name = "dataGridViewApplication";
            this.dataGridViewApplication.ReadOnly = true;
            this.dataGridViewApplication.Size = new System.Drawing.Size(735, 271);
            this.dataGridViewApplication.TabIndex = 0;
            // 
            // lblTenantId
            // 
            this.lblTenantId.AutoSize = true;
            this.lblTenantId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenantId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTenantId.Location = new System.Drawing.Point(780, 49);
            this.lblTenantId.Name = "lblTenantId";
            this.lblTenantId.Size = new System.Drawing.Size(16, 18);
            this.lblTenantId.TabIndex = 4;
            this.lblTenantId.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(677, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Your Tenant ID : ";
            // 
            // CustomerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTenantId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerPortal";
            this.Text = "CustomerPortal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccupied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Guna.UI.WinForms.GunaAdvenceButton btnRequest;
        private Guna.UI.WinForms.GunaTextBox txtTenantId;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtLeaseAgreementId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox comboStatus;
        private Guna.UI.WinForms.GunaTextBox txtExtensionPeriods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewReserve;
        private System.Windows.Forms.DataGridView dataGridViewOccupied;
        private System.Windows.Forms.DataGridView dataGridViewApplication;
        private System.Windows.Forms.DataGridView dataGridViewExtension;
        private System.Windows.Forms.Label lblTenantId;
        private System.Windows.Forms.Label label8;
    }
}