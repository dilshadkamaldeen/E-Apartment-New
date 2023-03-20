namespace E_Apartment.Views
{
    partial class PaymentsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsView));
            this.buildingTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gunaLabel19 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewLeaseAgreement = new System.Windows.Forms.DataGridView();
            this.txtSearchParkingSpace = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteParkingSpace = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateParkingSpace = new Guna.UI.WinForms.GunaButton();
            this.btnParkingSpaceSearch = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.btnDeleteBuilding = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateBuilding = new Guna.UI.WinForms.GunaButton();
            this.btnSaveBuilding = new Guna.UI.WinForms.GunaButton();
            this.btnClearBuilding = new Guna.UI.WinForms.GunaButton();
            this.txtPaymentAmount = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.txtSearchBuilding = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuildingSearch = new Guna.UI.WinForms.GunaButton();
            this.comboPaymentType = new Guna.UI.WinForms.GunaComboBox();
            this.txtPaymentDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtLeaseAgreementId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.buildingTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaseAgreement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingTabControl
            // 
            this.buildingTabControl.Controls.Add(this.tabPage1);
            this.buildingTabControl.Controls.Add(this.tabPage2);
            this.buildingTabControl.Location = new System.Drawing.Point(47, 60);
            this.buildingTabControl.Name = "buildingTabControl";
            this.buildingTabControl.SelectedIndex = 0;
            this.buildingTabControl.Size = new System.Drawing.Size(902, 515);
            this.buildingTabControl.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gunaElipsePanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Payment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gunaLabel19
            // 
            this.gunaLabel19.AutoSize = true;
            this.gunaLabel19.Font = new System.Drawing.Font("Roboto Slab Black", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel19.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaLabel19.Location = new System.Drawing.Point(65, 9);
            this.gunaLabel19.Name = "gunaLabel19";
            this.gunaLabel19.Size = new System.Drawing.Size(190, 36);
            this.gunaLabel19.TabIndex = 21;
            this.gunaLabel19.Text = "Add Payment";
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel3.Controls.Add(this.gunaElipsePanel1);
            this.gunaElipsePanel3.Controls.Add(this.dataGridViewPayments);
            this.gunaElipsePanel3.Controls.Add(this.txtSearchBuilding);
            this.gunaElipsePanel3.Controls.Add(this.btnBuildingSearch);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(6, 38);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Size = new System.Drawing.Size(882, 435);
            this.gunaElipsePanel3.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteParkingSpace);
            this.tabPage2.Controls.Add(this.btnUpdateParkingSpace);
            this.tabPage2.Controls.Add(this.dataGridViewLeaseAgreement);
            this.tabPage2.Controls.Add(this.txtSearchParkingSpace);
            this.tabPage2.Controls.Add(this.btnParkingSpaceSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lease Agreement List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeaseAgreement
            // 
            this.dataGridViewLeaseAgreement.AllowUserToAddRows = false;
            this.dataGridViewLeaseAgreement.AllowUserToDeleteRows = false;
            this.dataGridViewLeaseAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeaseAgreement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaseAgreement.Location = new System.Drawing.Point(213, 88);
            this.dataGridViewLeaseAgreement.Name = "dataGridViewLeaseAgreement";
            this.dataGridViewLeaseAgreement.ReadOnly = true;
            this.dataGridViewLeaseAgreement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeaseAgreement.Size = new System.Drawing.Size(455, 318);
            this.dataGridViewLeaseAgreement.TabIndex = 17;
            // 
            // txtSearchParkingSpace
            // 
            this.txtSearchParkingSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchParkingSpace.BaseColor = System.Drawing.Color.White;
            this.txtSearchParkingSpace.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchParkingSpace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchParkingSpace.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchParkingSpace.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearchParkingSpace.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchParkingSpace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchParkingSpace.Location = new System.Drawing.Point(213, 31);
            this.txtSearchParkingSpace.Name = "txtSearchParkingSpace";
            this.txtSearchParkingSpace.PasswordChar = '\0';
            this.txtSearchParkingSpace.SelectedText = "";
            this.txtSearchParkingSpace.Size = new System.Drawing.Size(328, 39);
            this.txtSearchParkingSpace.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto Slab Black", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaLabel1.Location = new System.Drawing.Point(85, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(309, 36);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Payment Management";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(893, -13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 31);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnDeleteParkingSpace
            // 
            this.btnDeleteParkingSpace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteParkingSpace.AnimationHoverSpeed = 0.07F;
            this.btnDeleteParkingSpace.AnimationSpeed = 0.03F;
            this.btnDeleteParkingSpace.BaseColor = System.Drawing.Color.Red;
            this.btnDeleteParkingSpace.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteParkingSpace.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteParkingSpace.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteParkingSpace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteParkingSpace.ForeColor = System.Drawing.Color.White;
            this.btnDeleteParkingSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteParkingSpace.Image")));
            this.btnDeleteParkingSpace.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteParkingSpace.Location = new System.Drawing.Point(695, 169);
            this.btnDeleteParkingSpace.Name = "btnDeleteParkingSpace";
            this.btnDeleteParkingSpace.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDeleteParkingSpace.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteParkingSpace.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteParkingSpace.OnHoverImage = null;
            this.btnDeleteParkingSpace.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteParkingSpace.Size = new System.Drawing.Size(163, 47);
            this.btnDeleteParkingSpace.TabIndex = 26;
            this.btnDeleteParkingSpace.Text = "Delete Building";
            this.btnDeleteParkingSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateParkingSpace
            // 
            this.btnUpdateParkingSpace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateParkingSpace.AnimationHoverSpeed = 0.07F;
            this.btnUpdateParkingSpace.AnimationSpeed = 0.03F;
            this.btnUpdateParkingSpace.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateParkingSpace.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateParkingSpace.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateParkingSpace.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateParkingSpace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateParkingSpace.ForeColor = System.Drawing.Color.White;
            this.btnUpdateParkingSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateParkingSpace.Image")));
            this.btnUpdateParkingSpace.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateParkingSpace.Location = new System.Drawing.Point(695, 116);
            this.btnUpdateParkingSpace.Name = "btnUpdateParkingSpace";
            this.btnUpdateParkingSpace.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnUpdateParkingSpace.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateParkingSpace.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateParkingSpace.OnHoverImage = null;
            this.btnUpdateParkingSpace.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateParkingSpace.Size = new System.Drawing.Size(163, 47);
            this.btnUpdateParkingSpace.TabIndex = 25;
            this.btnUpdateParkingSpace.Text = "Update Building";
            // 
            // btnParkingSpaceSearch
            // 
            this.btnParkingSpaceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParkingSpaceSearch.AnimationHoverSpeed = 0.07F;
            this.btnParkingSpaceSearch.AnimationSpeed = 0.03F;
            this.btnParkingSpaceSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnParkingSpaceSearch.BorderColor = System.Drawing.Color.Black;
            this.btnParkingSpaceSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnParkingSpaceSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnParkingSpaceSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnParkingSpaceSearch.ForeColor = System.Drawing.Color.White;
            this.btnParkingSpaceSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnParkingSpaceSearch.Image")));
            this.btnParkingSpaceSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnParkingSpaceSearch.Location = new System.Drawing.Point(547, 31);
            this.btnParkingSpaceSearch.Name = "btnParkingSpaceSearch";
            this.btnParkingSpaceSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnParkingSpaceSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnParkingSpaceSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnParkingSpaceSearch.OnHoverImage = null;
            this.btnParkingSpaceSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnParkingSpaceSearch.Size = new System.Drawing.Size(107, 40);
            this.btnParkingSpaceSearch.TabIndex = 15;
            this.btnParkingSpaceSearch.Text = "Search";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::E_Apartment.Properties.Resources.building;
            this.gunaPictureBox1.Location = new System.Drawing.Point(47, 13);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox1.TabIndex = 17;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Controls.Add(this.txtLeaseAgreementId);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.txtPaymentDate);
            this.gunaElipsePanel1.Controls.Add(this.comboPaymentType);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel19);
            this.gunaElipsePanel1.Controls.Add(this.lblPaymentId);
            this.gunaElipsePanel1.Controls.Add(this.txtPaymentAmount);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel13);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel18);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel14);
            this.gunaElipsePanel1.Controls.Add(this.btnDeleteBuilding);
            this.gunaElipsePanel1.Controls.Add(this.btnUpdateBuilding);
            this.gunaElipsePanel1.Controls.Add(this.btnSaveBuilding);
            this.gunaElipsePanel1.Controls.Add(this.btnClearBuilding);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(23, 29);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(362, 377);
            this.gunaElipsePanel1.TabIndex = 19;
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentId.Location = new System.Drawing.Point(272, 22);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(16, 18);
            this.lblPaymentId.TabIndex = 30;
            this.lblPaymentId.Text = "0";
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel18.Location = new System.Drawing.Point(9, 67);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(31, 15);
            this.gunaLabel18.TabIndex = 29;
            this.gunaLabel18.Text = "Date";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel14.Location = new System.Drawing.Point(212, 67);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel14.TabIndex = 26;
            this.gunaLabel14.Text = "Payment Type";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel13.Location = new System.Drawing.Point(10, 121);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(90, 15);
            this.gunaLabel13.TabIndex = 25;
            this.gunaLabel13.Text = "Paying Amount";
            // 
            // btnDeleteBuilding
            // 
            this.btnDeleteBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteBuilding.AnimationHoverSpeed = 0.07F;
            this.btnDeleteBuilding.AnimationSpeed = 0.03F;
            this.btnDeleteBuilding.BaseColor = System.Drawing.Color.Red;
            this.btnDeleteBuilding.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteBuilding.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteBuilding.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteBuilding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteBuilding.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBuilding.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBuilding.Image")));
            this.btnDeleteBuilding.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteBuilding.Location = new System.Drawing.Point(17, 262);
            this.btnDeleteBuilding.Name = "btnDeleteBuilding";
            this.btnDeleteBuilding.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDeleteBuilding.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteBuilding.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteBuilding.OnHoverImage = null;
            this.btnDeleteBuilding.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteBuilding.Size = new System.Drawing.Size(328, 47);
            this.btnDeleteBuilding.TabIndex = 24;
            this.btnDeleteBuilding.Text = "Delete Payment";
            this.btnDeleteBuilding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateBuilding
            // 
            this.btnUpdateBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateBuilding.AnimationHoverSpeed = 0.07F;
            this.btnUpdateBuilding.AnimationSpeed = 0.03F;
            this.btnUpdateBuilding.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateBuilding.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateBuilding.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateBuilding.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateBuilding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateBuilding.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBuilding.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBuilding.Image")));
            this.btnUpdateBuilding.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateBuilding.Location = new System.Drawing.Point(215, 209);
            this.btnUpdateBuilding.Name = "btnUpdateBuilding";
            this.btnUpdateBuilding.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnUpdateBuilding.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateBuilding.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateBuilding.OnHoverImage = null;
            this.btnUpdateBuilding.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateBuilding.Size = new System.Drawing.Size(130, 47);
            this.btnUpdateBuilding.TabIndex = 23;
            this.btnUpdateBuilding.Text = "Update Payment";
            // 
            // btnSaveBuilding
            // 
            this.btnSaveBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveBuilding.AnimationHoverSpeed = 0.07F;
            this.btnSaveBuilding.AnimationSpeed = 0.03F;
            this.btnSaveBuilding.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSaveBuilding.BorderColor = System.Drawing.Color.Black;
            this.btnSaveBuilding.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveBuilding.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveBuilding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveBuilding.ForeColor = System.Drawing.Color.White;
            this.btnSaveBuilding.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBuilding.Image")));
            this.btnSaveBuilding.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveBuilding.Location = new System.Drawing.Point(99, 209);
            this.btnSaveBuilding.Name = "btnSaveBuilding";
            this.btnSaveBuilding.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSaveBuilding.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveBuilding.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveBuilding.OnHoverImage = null;
            this.btnSaveBuilding.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveBuilding.Size = new System.Drawing.Size(118, 47);
            this.btnSaveBuilding.TabIndex = 22;
            this.btnSaveBuilding.Text = "Add Payment";
            // 
            // btnClearBuilding
            // 
            this.btnClearBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearBuilding.AnimationHoverSpeed = 0.07F;
            this.btnClearBuilding.AnimationSpeed = 0.03F;
            this.btnClearBuilding.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClearBuilding.BorderColor = System.Drawing.Color.Black;
            this.btnClearBuilding.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearBuilding.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearBuilding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearBuilding.ForeColor = System.Drawing.Color.White;
            this.btnClearBuilding.Image = ((System.Drawing.Image)(resources.GetObject("btnClearBuilding.Image")));
            this.btnClearBuilding.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClearBuilding.Location = new System.Drawing.Point(17, 209);
            this.btnClearBuilding.Name = "btnClearBuilding";
            this.btnClearBuilding.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClearBuilding.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClearBuilding.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClearBuilding.OnHoverImage = null;
            this.btnClearBuilding.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearBuilding.Size = new System.Drawing.Size(83, 47);
            this.btnClearBuilding.TabIndex = 20;
            this.btnClearBuilding.Text = "Clear";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.BaseColor = System.Drawing.Color.White;
            this.txtPaymentAmount.BorderColor = System.Drawing.Color.Silver;
            this.txtPaymentAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPaymentAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPaymentAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaymentAmount.Location = new System.Drawing.Point(12, 140);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PasswordChar = '\0';
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.Size = new System.Drawing.Size(172, 30);
            this.txtPaymentAmount.TabIndex = 18;
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AllowUserToAddRows = false;
            this.dataGridViewPayments.AllowUserToDeleteRows = false;
            this.dataGridViewPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(404, 86);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.ReadOnly = true;
            this.dataGridViewPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPayments.Size = new System.Drawing.Size(455, 318);
            this.dataGridViewPayments.TabIndex = 18;
            // 
            // txtSearchBuilding
            // 
            this.txtSearchBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBuilding.BaseColor = System.Drawing.Color.White;
            this.txtSearchBuilding.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchBuilding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBuilding.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchBuilding.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearchBuilding.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchBuilding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBuilding.Location = new System.Drawing.Point(404, 29);
            this.txtSearchBuilding.Name = "txtSearchBuilding";
            this.txtSearchBuilding.PasswordChar = '\0';
            this.txtSearchBuilding.SelectedText = "";
            this.txtSearchBuilding.Size = new System.Drawing.Size(328, 39);
            this.txtSearchBuilding.TabIndex = 17;
            // 
            // btnBuildingSearch
            // 
            this.btnBuildingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildingSearch.AnimationHoverSpeed = 0.07F;
            this.btnBuildingSearch.AnimationSpeed = 0.03F;
            this.btnBuildingSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuildingSearch.BorderColor = System.Drawing.Color.Black;
            this.btnBuildingSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuildingSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuildingSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuildingSearch.ForeColor = System.Drawing.Color.White;
            this.btnBuildingSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnBuildingSearch.Image")));
            this.btnBuildingSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuildingSearch.Location = new System.Drawing.Point(738, 29);
            this.btnBuildingSearch.Name = "btnBuildingSearch";
            this.btnBuildingSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuildingSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuildingSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuildingSearch.OnHoverImage = null;
            this.btnBuildingSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuildingSearch.Size = new System.Drawing.Size(107, 40);
            this.btnBuildingSearch.TabIndex = 16;
            this.btnBuildingSearch.Text = "Search";
            // 
            // comboPaymentType
            // 
            this.comboPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.comboPaymentType.BaseColor = System.Drawing.Color.White;
            this.comboPaymentType.BorderColor = System.Drawing.Color.Silver;
            this.comboPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaymentType.FocusedColor = System.Drawing.Color.Empty;
            this.comboPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPaymentType.ForeColor = System.Drawing.Color.Black;
            this.comboPaymentType.FormattingEnabled = true;
            this.comboPaymentType.Items.AddRange(new object[] {
            "ReservationFee",
            "Advance",
            "Due"});
            this.comboPaymentType.Location = new System.Drawing.Point(215, 90);
            this.comboPaymentType.Name = "comboPaymentType";
            this.comboPaymentType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboPaymentType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboPaymentType.Size = new System.Drawing.Size(121, 26);
            this.comboPaymentType.TabIndex = 31;
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.BaseColor = System.Drawing.Color.White;
            this.txtPaymentDate.BorderColor = System.Drawing.Color.Silver;
            this.txtPaymentDate.CustomFormat = null;
            this.txtPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtPaymentDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaymentDate.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentDate.Location = new System.Drawing.Point(12, 86);
            this.txtPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtPaymentDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPaymentDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPaymentDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtPaymentDate.Size = new System.Drawing.Size(172, 30);
            this.txtPaymentDate.TabIndex = 32;
            this.txtPaymentDate.Text = "Sunday, January 15, 2023";
            this.txtPaymentDate.Value = new System.DateTime(2023, 1, 15, 9, 49, 54, 992);
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
            this.txtLeaseAgreementId.Location = new System.Drawing.Point(214, 140);
            this.txtLeaseAgreementId.Name = "txtLeaseAgreementId";
            this.txtLeaseAgreementId.PasswordChar = '\0';
            this.txtLeaseAgreementId.SelectedText = "";
            this.txtLeaseAgreementId.Size = new System.Drawing.Size(122, 30);
            this.txtLeaseAgreementId.TabIndex = 33;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(212, 121);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(112, 15);
            this.gunaLabel2.TabIndex = 34;
            this.gunaLabel2.Text = "Lease Agreement ID";
            // 
            // PaymentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 596);
            this.Controls.Add(this.buildingTabControl);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnClose);
            this.Name = "PaymentsView";
            this.Text = "PaymentsView";
            this.buildingTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gunaElipsePanel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaseAgreement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl buildingTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI.WinForms.GunaLabel gunaLabel19;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaButton btnDeleteParkingSpace;
        private Guna.UI.WinForms.GunaButton btnUpdateParkingSpace;
        private System.Windows.Forms.DataGridView dataGridViewLeaseAgreement;
        private Guna.UI.WinForms.GunaTextBox txtSearchParkingSpace;
        private Guna.UI.WinForms.GunaButton btnParkingSpaceSearch;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaDateTimePicker txtPaymentDate;
        private Guna.UI.WinForms.GunaComboBox comboPaymentType;
        private System.Windows.Forms.Label lblPaymentId;
        private Guna.UI.WinForms.GunaTextBox txtPaymentAmount;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaButton btnDeleteBuilding;
        private Guna.UI.WinForms.GunaButton btnUpdateBuilding;
        private Guna.UI.WinForms.GunaButton btnSaveBuilding;
        private Guna.UI.WinForms.GunaButton btnClearBuilding;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private Guna.UI.WinForms.GunaTextBox txtSearchBuilding;
        private Guna.UI.WinForms.GunaButton btnBuildingSearch;
        private Guna.UI.WinForms.GunaTextBox txtLeaseAgreementId;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}