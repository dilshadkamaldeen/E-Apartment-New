namespace E_Apartment.Views
{
    partial class Usersview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usersview));
            this.btnClose = new System.Windows.Forms.Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.buildingTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUserSearch = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenantId = new Guna.UI.WinForms.GunaTextBox();
            this.lblUserId = new Guna.UI.WinForms.GunaLabel();
            this.comboUserRole = new Guna.UI.WinForms.GunaComboBox();
            this.checkBoxUserStatus = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnUserDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUserUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnSaveUser = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.txtUserPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUserName = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.txtUserSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.buildingTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(958, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 31);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaLabel1.Location = new System.Drawing.Point(57, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(251, 31);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "User Management";
            // 
            // buildingTabControl
            // 
            this.buildingTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildingTabControl.Controls.Add(this.tabPage2);
            this.buildingTabControl.Location = new System.Drawing.Point(19, 51);
            this.buildingTabControl.Name = "buildingTabControl";
            this.buildingTabControl.SelectedIndex = 0;
            this.buildingTabControl.Size = new System.Drawing.Size(888, 463);
            this.buildingTabControl.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUserSearch);
            this.tabPage2.Controls.Add(this.gunaElipsePanel1);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Controls.Add(this.txtUserSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSearch.AnimationHoverSpeed = 0.07F;
            this.btnUserSearch.AnimationSpeed = 0.03F;
            this.btnUserSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnUserSearch.BorderColor = System.Drawing.Color.Black;
            this.btnUserSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUserSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnUserSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserSearch.ForeColor = System.Drawing.Color.White;
            this.btnUserSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSearch.Image")));
            this.btnUserSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUserSearch.Location = new System.Drawing.Point(751, 29);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUserSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUserSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUserSearch.OnHoverImage = null;
            this.btnUserSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnUserSearch.Size = new System.Drawing.Size(107, 40);
            this.btnUserSearch.TabIndex = 19;
            this.btnUserSearch.Text = "Search";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Controls.Add(this.btnRefresh);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.txtTenantId);
            this.gunaElipsePanel1.Controls.Add(this.lblUserId);
            this.gunaElipsePanel1.Controls.Add(this.comboUserRole);
            this.gunaElipsePanel1.Controls.Add(this.checkBoxUserStatus);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel5);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel6);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel7);
            this.gunaElipsePanel1.Controls.Add(this.btnUserDelete);
            this.gunaElipsePanel1.Controls.Add(this.btnUserUpdate);
            this.gunaElipsePanel1.Controls.Add(this.btnSaveUser);
            this.gunaElipsePanel1.Controls.Add(this.gunaButton4);
            this.gunaElipsePanel1.Controls.Add(this.txtUserPassword);
            this.gunaElipsePanel1.Controls.Add(this.txtUserName);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(22, 30);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(362, 377);
            this.gunaElipsePanel1.TabIndex = 18;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Silver;
            this.btnRefresh.Location = new System.Drawing.Point(25, 315);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 48);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(181, 124);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel2.TabIndex = 38;
            this.gunaLabel2.Text = "Tenant Id";
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
            this.txtTenantId.Location = new System.Drawing.Point(184, 143);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.PasswordChar = '\0';
            this.txtTenantId.ReadOnly = true;
            this.txtTenantId.SelectedText = "";
            this.txtTenantId.Size = new System.Drawing.Size(92, 30);
            this.txtTenantId.TabIndex = 37;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserId.Location = new System.Drawing.Point(244, 22);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(13, 15);
            this.lblUserId.TabIndex = 36;
            this.lblUserId.Text = "0";
            // 
            // comboUserRole
            // 
            this.comboUserRole.BackColor = System.Drawing.Color.Transparent;
            this.comboUserRole.BaseColor = System.Drawing.Color.White;
            this.comboUserRole.BorderColor = System.Drawing.Color.Silver;
            this.comboUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUserRole.FocusedColor = System.Drawing.Color.Empty;
            this.comboUserRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboUserRole.ForeColor = System.Drawing.Color.Black;
            this.comboUserRole.FormattingEnabled = true;
            this.comboUserRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Customer"});
            this.comboUserRole.Location = new System.Drawing.Point(182, 86);
            this.comboUserRole.Name = "comboUserRole";
            this.comboUserRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboUserRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboUserRole.Size = new System.Drawing.Size(121, 26);
            this.comboUserRole.TabIndex = 35;
            this.comboUserRole.SelectedIndexChanged += new System.EventHandler(this.comboUserRole_SelectedIndexChanged);
            // 
            // checkBoxUserStatus
            // 
            this.checkBoxUserStatus.BaseColor = System.Drawing.Color.White;
            this.checkBoxUserStatus.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxUserStatus.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxUserStatus.FillColor = System.Drawing.Color.White;
            this.checkBoxUserStatus.Location = new System.Drawing.Point(284, 153);
            this.checkBoxUserStatus.Name = "checkBoxUserStatus";
            this.checkBoxUserStatus.Size = new System.Drawing.Size(61, 20);
            this.checkBoxUserStatus.TabIndex = 34;
            this.checkBoxUserStatus.Text = "Active";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(282, 134);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel3.TabIndex = 33;
            this.gunaLabel3.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 30;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaLabel4.Location = new System.Drawing.Point(31, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(201, 31);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Add New User";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(18, 124);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(83, 15);
            this.gunaLabel5.TabIndex = 29;
            this.gunaLabel5.Text = "User Password";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(178, 67);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel6.TabIndex = 26;
            this.gunaLabel6.Text = "User Role";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(18, 67);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(65, 15);
            this.gunaLabel7.TabIndex = 25;
            this.gunaLabel7.Text = "User Name";
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserDelete.AnimationHoverSpeed = 0.07F;
            this.btnUserDelete.AnimationSpeed = 0.03F;
            this.btnUserDelete.BaseColor = System.Drawing.Color.Red;
            this.btnUserDelete.BorderColor = System.Drawing.Color.Black;
            this.btnUserDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUserDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnUserDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserDelete.ForeColor = System.Drawing.Color.White;
            this.btnUserDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnUserDelete.Image")));
            this.btnUserDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUserDelete.Location = new System.Drawing.Point(17, 262);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUserDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUserDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUserDelete.OnHoverImage = null;
            this.btnUserDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnUserDelete.Size = new System.Drawing.Size(328, 47);
            this.btnUserDelete.TabIndex = 24;
            this.btnUserDelete.Text = "Delete User";
            this.btnUserDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUserUpdate.AnimationSpeed = 0.03F;
            this.btnUserUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUserUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUserUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUserUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUserUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUserUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUserUpdate.Image")));
            this.btnUserUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUserUpdate.Location = new System.Drawing.Point(227, 209);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnUserUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUserUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUserUpdate.OnHoverImage = null;
            this.btnUserUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUserUpdate.Size = new System.Drawing.Size(118, 47);
            this.btnUserUpdate.TabIndex = 23;
            this.btnUserUpdate.Text = "Update User";
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveUser.AnimationHoverSpeed = 0.07F;
            this.btnSaveUser.AnimationSpeed = 0.03F;
            this.btnSaveUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSaveUser.BorderColor = System.Drawing.Color.Black;
            this.btnSaveUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Image")));
            this.btnSaveUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveUser.Location = new System.Drawing.Point(106, 209);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSaveUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveUser.OnHoverImage = null;
            this.btnSaveUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveUser.Size = new System.Drawing.Size(108, 47);
            this.btnSaveUser.TabIndex = 22;
            this.btnSaveUser.Text = "Save User";
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(17, 209);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(83, 47);
            this.gunaButton4.TabIndex = 20;
            this.gunaButton4.Text = "Clear";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BaseColor = System.Drawing.Color.White;
            this.txtUserPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserPassword.Location = new System.Drawing.Point(21, 143);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '\0';
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.Size = new System.Drawing.Size(122, 30);
            this.txtUserPassword.TabIndex = 19;
            // 
            // txtUserName
            // 
            this.txtUserName.BaseColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.Location = new System.Drawing.Point(20, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(123, 30);
            this.txtUserName.TabIndex = 18;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(403, 87);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(455, 318);
            this.dataGridViewUsers.TabIndex = 17;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserSearch.BaseColor = System.Drawing.Color.White;
            this.txtUserSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtUserSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserSearch.Location = new System.Drawing.Point(403, 30);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.PasswordChar = '\0';
            this.txtUserSearch.SelectedText = "";
            this.txtUserSearch.Size = new System.Drawing.Size(328, 39);
            this.txtUserSearch.TabIndex = 16;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::E_Apartment.Properties.Resources.building;
            this.gunaPictureBox1.Location = new System.Drawing.Point(19, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox1.TabIndex = 12;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Usersview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 489);
            this.Controls.Add(this.buildingTabControl);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Usersview";
            this.Text = "Usersview";
            this.buildingTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TabControl buildingTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaButton btnUserSearch;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaCheckBox checkBoxUserStatus;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton btnUserDelete;
        private Guna.UI.WinForms.GunaButton btnUserUpdate;
        private Guna.UI.WinForms.GunaButton btnSaveUser;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaTextBox txtUserPassword;
        private Guna.UI.WinForms.GunaTextBox txtUserName;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private Guna.UI.WinForms.GunaTextBox txtUserSearch;
        private Guna.UI.WinForms.GunaComboBox comboUserRole;
        private Guna.UI.WinForms.GunaLabel lblUserId;
        private Guna.UI.WinForms.GunaTextBox txtTenantId;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Button btnRefresh;
    }
}