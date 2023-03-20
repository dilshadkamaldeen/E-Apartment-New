namespace E_Apartment.Views
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboUserType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnReports = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPayments = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReservation = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLeasing = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTanents = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnParkingSpace = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnBuildingsManagement = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnPayments);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnLeasing);
            this.panel1.Controls.Add(this.btnTanents);
            this.panel1.Controls.Add(this.btnParkingSpace);
            this.panel1.Controls.Add(this.gunaSeparator1);
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Controls.Add(this.btnBuildingsManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 661);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(8, 133);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(184, 10);
            this.gunaSeparator1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.gunaButton2);
            this.panel2.Controls.Add(this.gunaCirclePictureBox2);
            this.panel2.Controls.Add(this.comboUserType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 56);
            this.panel2.TabIndex = 4;
            // 
            // comboUserType
            // 
            this.comboUserType.BackColor = System.Drawing.Color.Transparent;
            this.comboUserType.BaseColor = System.Drawing.Color.White;
            this.comboUserType.BorderColor = System.Drawing.Color.White;
            this.comboUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUserType.FocusedColor = System.Drawing.Color.Empty;
            this.comboUserType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboUserType.ForeColor = System.Drawing.Color.Black;
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Admin"});
            this.comboUserType.Location = new System.Drawing.Point(854, 15);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboUserType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboUserType.Size = new System.Drawing.Size(87, 26);
            this.comboUserType.StartIndex = 0;
            this.comboUserType.TabIndex = 6;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::E_Apartment.Properties.Resources.logout_rounded_up_32px;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(937, 12);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(44, 29);
            this.gunaButton2.TabIndex = 10;
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.Yellow;
            this.gunaCirclePictureBox2.Image = global::E_Apartment.Properties.Resources.profile;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(820, 15);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(28, 26);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 7;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // btnReports
            // 
            this.btnReports.AnimationHoverSpeed = 0.07F;
            this.btnReports.AnimationSpeed = 0.03F;
            this.btnReports.BaseColor = System.Drawing.Color.White;
            this.btnReports.BorderColor = System.Drawing.Color.Black;
            this.btnReports.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReports.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReports.CheckedForeColor = System.Drawing.Color.White;
            this.btnReports.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnReports.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReports.FocusedColor = System.Drawing.Color.Empty;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReports.Image = global::E_Apartment.Properties.Resources.report_file_24px;
            this.btnReports.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReports.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReports.Location = new System.Drawing.Point(8, 444);
            this.btnReports.Name = "btnReports";
            this.btnReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReports.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReports.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReports.OnHoverImage = global::E_Apartment.Properties.Resources.search_32px1;
            this.btnReports.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReports.OnPressedColor = System.Drawing.Color.Black;
            this.btnReports.Size = new System.Drawing.Size(184, 42);
            this.btnReports.TabIndex = 16;
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.AnimationHoverSpeed = 0.07F;
            this.btnPayments.AnimationSpeed = 0.03F;
            this.btnPayments.BaseColor = System.Drawing.Color.White;
            this.btnPayments.BorderColor = System.Drawing.Color.Black;
            this.btnPayments.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPayments.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPayments.CheckedForeColor = System.Drawing.Color.White;
            this.btnPayments.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnPayments.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPayments.FocusedColor = System.Drawing.Color.Empty;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPayments.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPayments.Image = global::E_Apartment.Properties.Resources.us_dollar_circled_30px;
            this.btnPayments.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPayments.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPayments.Location = new System.Drawing.Point(8, 396);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPayments.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPayments.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPayments.OnHoverImage = global::E_Apartment.Properties.Resources.search_32px1;
            this.btnPayments.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPayments.OnPressedColor = System.Drawing.Color.Black;
            this.btnPayments.Size = new System.Drawing.Size(184, 42);
            this.btnPayments.TabIndex = 15;
            this.btnPayments.Text = "Payments";
            // 
            // btnUser
            // 
            this.btnUser.AnimationHoverSpeed = 0.07F;
            this.btnUser.AnimationSpeed = 0.03F;
            this.btnUser.BaseColor = System.Drawing.Color.White;
            this.btnUser.BorderColor = System.Drawing.Color.Black;
            this.btnUser.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUser.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUser.CheckedForeColor = System.Drawing.Color.White;
            this.btnUser.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnUser.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUser.Image = global::E_Apartment.Properties.Resources.User_Menu_Male_64px1;
            this.btnUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUser.Location = new System.Drawing.Point(8, 492);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = global::E_Apartment.Properties.Resources.search_32px1;
            this.btnUser.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnUser.Size = new System.Drawing.Size(184, 42);
            this.btnUser.TabIndex = 14;
            this.btnUser.Text = "Users";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.AnimationHoverSpeed = 0.07F;
            this.btnReservation.AnimationSpeed = 0.03F;
            this.btnReservation.BaseColor = System.Drawing.Color.White;
            this.btnReservation.BorderColor = System.Drawing.Color.Black;
            this.btnReservation.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReservation.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReservation.CheckedForeColor = System.Drawing.Color.White;
            this.btnReservation.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnReservation.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservation.FocusedColor = System.Drawing.Color.Empty;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReservation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReservation.Image = global::E_Apartment.Properties.Resources.building;
            this.btnReservation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReservation.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReservation.Location = new System.Drawing.Point(8, 301);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReservation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReservation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReservation.OnHoverImage = global::E_Apartment.Properties.Resources.search_32px1;
            this.btnReservation.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReservation.OnPressedColor = System.Drawing.Color.Black;
            this.btnReservation.Size = new System.Drawing.Size(184, 42);
            this.btnReservation.TabIndex = 11;
            this.btnReservation.Text = "Reservation";
            // 
            // btnLeasing
            // 
            this.btnLeasing.AnimationHoverSpeed = 0.07F;
            this.btnLeasing.AnimationSpeed = 0.03F;
            this.btnLeasing.BaseColor = System.Drawing.Color.White;
            this.btnLeasing.BorderColor = System.Drawing.Color.Black;
            this.btnLeasing.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLeasing.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLeasing.CheckedForeColor = System.Drawing.Color.White;
            this.btnLeasing.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnLeasing.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLeasing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeasing.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLeasing.FocusedColor = System.Drawing.Color.Empty;
            this.btnLeasing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLeasing.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLeasing.Image = global::E_Apartment.Properties.Resources.lease_32px;
            this.btnLeasing.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLeasing.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLeasing.Location = new System.Drawing.Point(8, 348);
            this.btnLeasing.Name = "btnLeasing";
            this.btnLeasing.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLeasing.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLeasing.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLeasing.OnHoverImage = global::E_Apartment.Properties.Resources.search_32px1;
            this.btnLeasing.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLeasing.OnPressedColor = System.Drawing.Color.Black;
            this.btnLeasing.Size = new System.Drawing.Size(184, 42);
            this.btnLeasing.TabIndex = 10;
            this.btnLeasing.Text = "Leasing Agreement";
            // 
            // btnTanents
            // 
            this.btnTanents.AnimationHoverSpeed = 0.07F;
            this.btnTanents.AnimationSpeed = 0.03F;
            this.btnTanents.BaseColor = System.Drawing.Color.White;
            this.btnTanents.BorderColor = System.Drawing.Color.Black;
            this.btnTanents.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTanents.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTanents.CheckedForeColor = System.Drawing.Color.White;
            this.btnTanents.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnTanents.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTanents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTanents.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTanents.FocusedColor = System.Drawing.Color.Empty;
            this.btnTanents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTanents.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTanents.Image = global::E_Apartment.Properties.Resources.User_Menu_Male_64px;
            this.btnTanents.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTanents.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTanents.Location = new System.Drawing.Point(8, 253);
            this.btnTanents.Name = "btnTanents";
            this.btnTanents.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTanents.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTanents.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTanents.OnHoverImage = global::E_Apartment.Properties.Resources.User_Menu_Male_64px;
            this.btnTanents.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTanents.OnPressedColor = System.Drawing.Color.Black;
            this.btnTanents.Size = new System.Drawing.Size(184, 42);
            this.btnTanents.TabIndex = 9;
            this.btnTanents.Text = "Tanents";
            // 
            // btnParkingSpace
            // 
            this.btnParkingSpace.AnimationHoverSpeed = 0.07F;
            this.btnParkingSpace.AnimationSpeed = 0.03F;
            this.btnParkingSpace.BaseColor = System.Drawing.Color.White;
            this.btnParkingSpace.BorderColor = System.Drawing.Color.Black;
            this.btnParkingSpace.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnParkingSpace.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnParkingSpace.CheckedForeColor = System.Drawing.Color.White;
            this.btnParkingSpace.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnParkingSpace.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnParkingSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParkingSpace.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnParkingSpace.FocusedColor = System.Drawing.Color.Empty;
            this.btnParkingSpace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnParkingSpace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnParkingSpace.Image = global::E_Apartment.Properties.Resources.building;
            this.btnParkingSpace.ImageSize = new System.Drawing.Size(20, 20);
            this.btnParkingSpace.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnParkingSpace.Location = new System.Drawing.Point(8, 205);
            this.btnParkingSpace.Name = "btnParkingSpace";
            this.btnParkingSpace.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnParkingSpace.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnParkingSpace.OnHoverForeColor = System.Drawing.Color.White;
            this.btnParkingSpace.OnHoverImage = global::E_Apartment.Properties.Resources.building_hover;
            this.btnParkingSpace.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnParkingSpace.OnPressedColor = System.Drawing.Color.Black;
            this.btnParkingSpace.Size = new System.Drawing.Size(184, 42);
            this.btnParkingSpace.TabIndex = 8;
            this.btnParkingSpace.Text = "Parking Space";
            this.btnParkingSpace.Click += new System.EventHandler(this.btnParkingSpace_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::E_Apartment.Properties.Resources.logo;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(37, 15);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(116, 112);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 5;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // btnBuildingsManagement
            // 
            this.btnBuildingsManagement.AnimationHoverSpeed = 0.07F;
            this.btnBuildingsManagement.AnimationSpeed = 0.03F;
            this.btnBuildingsManagement.BaseColor = System.Drawing.Color.White;
            this.btnBuildingsManagement.BorderColor = System.Drawing.Color.Black;
            this.btnBuildingsManagement.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBuildingsManagement.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBuildingsManagement.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuildingsManagement.CheckedImage = global::E_Apartment.Properties.Resources.building;
            this.btnBuildingsManagement.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBuildingsManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuildingsManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuildingsManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuildingsManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuildingsManagement.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuildingsManagement.Image = global::E_Apartment.Properties.Resources.building;
            this.btnBuildingsManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuildingsManagement.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuildingsManagement.Location = new System.Drawing.Point(8, 157);
            this.btnBuildingsManagement.Name = "btnBuildingsManagement";
            this.btnBuildingsManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuildingsManagement.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuildingsManagement.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuildingsManagement.OnHoverImage = global::E_Apartment.Properties.Resources.building_hover;
            this.btnBuildingsManagement.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuildingsManagement.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuildingsManagement.Size = new System.Drawing.Size(184, 42);
            this.btnBuildingsManagement.TabIndex = 0;
            this.btnBuildingsManagement.Text = "Buildings";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnBuildingsManagement;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaComboBox comboUserType;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaAdvenceButton btnParkingSpace;
        private Guna.UI.WinForms.GunaAdvenceButton btnTanents;
        private Guna.UI.WinForms.GunaAdvenceButton btnLeasing;
        private Guna.UI.WinForms.GunaAdvenceButton btnReservation;
        private Guna.UI.WinForms.GunaAdvenceButton btnUser;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaAdvenceButton btnPayments;
        private Guna.UI.WinForms.GunaAdvenceButton btnReports;
    }
}