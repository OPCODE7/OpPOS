namespace OpPOS.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PnlAdminSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEntries = new System.Windows.Forms.Button();
            this.TstPrincipal = new System.Windows.Forms.ToolStrip();
            this.SprMiembros = new System.Windows.Forms.ToolStripSeparator();
            this.BtnReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnRptBills = new System.Windows.Forms.ToolStripMenuItem();
            this.RptFinancialIncomes = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCheckInReport = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCheckOutReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCheckIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCheckout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnManageUsers = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPermissions = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnUserPermissions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnConfig = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnCompanyData = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBillRanges = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConfigServer = new System.Windows.Forms.ToolStripMenuItem();
            this.StPrincipal = new System.Windows.Forms.StatusStrip();
            this.LblUserLogged = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.LblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.PbxLogout = new System.Windows.Forms.PictureBox();
            this.PbxLeave = new System.Windows.Forms.PictureBox();
            this.PnlAdminSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TstPrincipal.SuspendLayout();
            this.StPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlAdminSideBar
            // 
            this.PnlAdminSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.PnlAdminSideBar.Controls.Add(this.pictureBox1);
            this.PnlAdminSideBar.Controls.Add(this.BtnEntries);
            this.PnlAdminSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlAdminSideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PnlAdminSideBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PnlAdminSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlAdminSideBar.Name = "PnlAdminSideBar";
            this.PnlAdminSideBar.Size = new System.Drawing.Size(226, 711);
            this.PnlAdminSideBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEntries
            // 
            this.BtnEntries.BackColor = System.Drawing.Color.Teal;
            this.BtnEntries.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntries.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEntries.Location = new System.Drawing.Point(3, 101);
            this.BtnEntries.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BtnEntries.Name = "BtnEntries";
            this.BtnEntries.Size = new System.Drawing.Size(211, 54);
            this.BtnEntries.TabIndex = 2;
            this.BtnEntries.Text = "Entradas";
            this.BtnEntries.UseVisualStyleBackColor = false;
            // 
            // TstPrincipal
            // 
            this.TstPrincipal.AutoSize = false;
            this.TstPrincipal.BackColor = System.Drawing.Color.Teal;
            this.TstPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SprMiembros,
            this.BtnReports,
            this.toolStripSeparator1,
            this.BtnCheckIn,
            this.toolStripSeparator5,
            this.BtnCheckout,
            this.toolStripSeparator3,
            this.BtnManageUsers,
            this.toolStripSeparator4,
            this.BtnConfig});
            this.TstPrincipal.Location = new System.Drawing.Point(226, 0);
            this.TstPrincipal.Name = "TstPrincipal";
            this.TstPrincipal.Size = new System.Drawing.Size(1024, 41);
            this.TstPrincipal.TabIndex = 40;
            this.TstPrincipal.Text = "toolStrip1";
            // 
            // SprMiembros
            // 
            this.SprMiembros.Name = "SprMiembros";
            this.SprMiembros.Size = new System.Drawing.Size(6, 41);
            // 
            // BtnReports
            // 
            this.BtnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRptBills,
            this.RptFinancialIncomes,
            this.BtnCheckInReport,
            this.BtnCheckOutReport});
            this.BtnReports.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(105, 36);
            this.BtnReports.Text = "Reportes";
            // 
            // BtnRptBills
            // 
            this.BtnRptBills.BackColor = System.Drawing.Color.Teal;
            this.BtnRptBills.ForeColor = System.Drawing.Color.White;
            this.BtnRptBills.Name = "BtnRptBills";
            this.BtnRptBills.Size = new System.Drawing.Size(290, 34);
            this.BtnRptBills.Text = "Facturas";
            // 
            // RptFinancialIncomes
            // 
            this.RptFinancialIncomes.BackColor = System.Drawing.Color.Teal;
            this.RptFinancialIncomes.ForeColor = System.Drawing.Color.White;
            this.RptFinancialIncomes.Name = "RptFinancialIncomes";
            this.RptFinancialIncomes.Size = new System.Drawing.Size(290, 34);
            this.RptFinancialIncomes.Text = "Ingresos Financieros";
            // 
            // BtnCheckInReport
            // 
            this.BtnCheckInReport.BackColor = System.Drawing.Color.Teal;
            this.BtnCheckInReport.ForeColor = System.Drawing.Color.White;
            this.BtnCheckInReport.Name = "BtnCheckInReport";
            this.BtnCheckInReport.Size = new System.Drawing.Size(290, 34);
            this.BtnCheckInReport.Text = "Entradas";
            // 
            // BtnCheckOutReport
            // 
            this.BtnCheckOutReport.BackColor = System.Drawing.Color.Teal;
            this.BtnCheckOutReport.ForeColor = System.Drawing.Color.White;
            this.BtnCheckOutReport.Name = "BtnCheckOutReport";
            this.BtnCheckOutReport.Size = new System.Drawing.Size(290, 34);
            this.BtnCheckOutReport.Text = "Salidas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(97, 36);
            this.BtnCheckIn.Text = "Check-In";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 41);
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCheckout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(112, 36);
            this.BtnCheckout.Text = "Check-Out";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // BtnManageUsers
            // 
            this.BtnManageUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRoles,
            this.BtnPermissions,
            this.BtnUsers,
            this.BtnUserPermissions});
            this.BtnManageUsers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("BtnManageUsers.Image")));
            this.BtnManageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnManageUsers.Name = "BtnManageUsers";
            this.BtnManageUsers.Size = new System.Drawing.Size(196, 36);
            this.BtnManageUsers.Text = "Gestión usuarios";
            // 
            // BtnRoles
            // 
            this.BtnRoles.BackColor = System.Drawing.Color.Teal;
            this.BtnRoles.ForeColor = System.Drawing.Color.White;
            this.BtnRoles.Name = "BtnRoles";
            this.BtnRoles.Size = new System.Drawing.Size(287, 34);
            this.BtnRoles.Text = "Roles";
            // 
            // BtnPermissions
            // 
            this.BtnPermissions.BackColor = System.Drawing.Color.Teal;
            this.BtnPermissions.ForeColor = System.Drawing.Color.White;
            this.BtnPermissions.Name = "BtnPermissions";
            this.BtnPermissions.Size = new System.Drawing.Size(287, 34);
            this.BtnPermissions.Text = "Permisos";
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.Teal;
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(287, 34);
            this.BtnUsers.Text = "Usuarios";
            // 
            // BtnUserPermissions
            // 
            this.BtnUserPermissions.BackColor = System.Drawing.Color.Teal;
            this.BtnUserPermissions.ForeColor = System.Drawing.Color.White;
            this.BtnUserPermissions.Name = "BtnUserPermissions";
            this.BtnUserPermissions.Size = new System.Drawing.Size(287, 34);
            this.BtnUserPermissions.Text = "Configurar permisos";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // BtnConfig
            // 
            this.BtnConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCompanyData,
            this.BtnBillRanges,
            this.BtnConfigServer});
            this.BtnConfig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConfig.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfig.Image")));
            this.BtnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(110, 36);
            this.BtnConfig.Text = "Config";
            // 
            // BtnCompanyData
            // 
            this.BtnCompanyData.BackColor = System.Drawing.Color.Teal;
            this.BtnCompanyData.ForeColor = System.Drawing.Color.White;
            this.BtnCompanyData.Name = "BtnCompanyData";
            this.BtnCompanyData.Size = new System.Drawing.Size(286, 34);
            this.BtnCompanyData.Text = "Empresa";
            // 
            // BtnBillRanges
            // 
            this.BtnBillRanges.BackColor = System.Drawing.Color.Teal;
            this.BtnBillRanges.ForeColor = System.Drawing.Color.White;
            this.BtnBillRanges.Name = "BtnBillRanges";
            this.BtnBillRanges.Size = new System.Drawing.Size(286, 34);
            this.BtnBillRanges.Text = "Rangos Facturacion";
            // 
            // BtnConfigServer
            // 
            this.BtnConfigServer.BackColor = System.Drawing.Color.Teal;
            this.BtnConfigServer.ForeColor = System.Drawing.Color.White;
            this.BtnConfigServer.Name = "BtnConfigServer";
            this.BtnConfigServer.Size = new System.Drawing.Size(286, 34);
            this.BtnConfigServer.Text = "Servidor";
            // 
            // StPrincipal
            // 
            this.StPrincipal.AutoSize = false;
            this.StPrincipal.BackColor = System.Drawing.Color.Teal;
            this.StPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUserLogged,
            this.toolStripSeparator6,
            this.LblFecha,
            this.toolStripSeparator7,
            this.LblRole,
            this.toolStripSeparator8});
            this.StPrincipal.Location = new System.Drawing.Point(226, 675);
            this.StPrincipal.Name = "StPrincipal";
            this.StPrincipal.Size = new System.Drawing.Size(1024, 36);
            this.StPrincipal.TabIndex = 43;
            this.StPrincipal.Text = "statusStrip1";
            // 
            // LblUserLogged
            // 
            this.LblUserLogged.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserLogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUserLogged.Name = "LblUserLogged";
            this.LblUserLogged.Size = new System.Drawing.Size(34, 29);
            this.LblUserLogged.Text = "---";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 36);
            // 
            // LblFecha
            // 
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(34, 29);
            this.LblFecha.Text = "---";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 36);
            // 
            // LblRole
            // 
            this.LblRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(34, 29);
            this.LblRole.Text = "---";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 36);
            // 
            // PbxLogout
            // 
            this.PbxLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxLogout.BackColor = System.Drawing.Color.Teal;
            this.PbxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxLogout.Location = new System.Drawing.Point(1213, 0);
            this.PbxLogout.Name = "PbxLogout";
            this.PbxLogout.Size = new System.Drawing.Size(30, 40);
            this.PbxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogout.TabIndex = 41;
            this.PbxLogout.TabStop = false;
            // 
            // PbxLeave
            // 
            this.PbxLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxLeave.BackColor = System.Drawing.Color.Teal;
            this.PbxLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxLeave.Location = new System.Drawing.Point(1177, 0);
            this.PbxLeave.Name = "PbxLeave";
            this.PbxLeave.Size = new System.Drawing.Size(30, 40);
            this.PbxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLeave.TabIndex = 45;
            this.PbxLeave.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 711);
            this.Controls.Add(this.PbxLeave);
            this.Controls.Add(this.StPrincipal);
            this.Controls.Add(this.PbxLogout);
            this.Controls.Add(this.TstPrincipal);
            this.Controls.Add(this.PnlAdminSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlAdminSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TstPrincipal.ResumeLayout(false);
            this.TstPrincipal.PerformLayout();
            this.StPrincipal.ResumeLayout(false);
            this.StPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLeave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PnlAdminSideBar;
        private System.Windows.Forms.ToolStrip TstPrincipal;
        private System.Windows.Forms.ToolStripSeparator SprMiembros;
        private System.Windows.Forms.ToolStripDropDownButton BtnReports;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button BtnEntries;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton BtnCheckIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton BtnManageUsers;
        private System.Windows.Forms.ToolStripMenuItem BtnRoles;
        private System.Windows.Forms.ToolStripMenuItem BtnPermissions;
        private System.Windows.Forms.ToolStripMenuItem BtnUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BtnCheckout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton BtnConfig;
        private System.Windows.Forms.ToolStripMenuItem BtnCompanyData;
        private System.Windows.Forms.ToolStripMenuItem BtnBillRanges;
        private System.Windows.Forms.StatusStrip StPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel LblUserLogged;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel LblFecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel LblRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem BtnUserPermissions;
        private System.Windows.Forms.PictureBox PbxLogout;
        private System.Windows.Forms.ToolStripMenuItem BtnConfigServer;
        private System.Windows.Forms.ToolStripMenuItem BtnRptBills;
        private System.Windows.Forms.ToolStripMenuItem RptFinancialIncomes;
        private System.Windows.Forms.ToolStripMenuItem BtnCheckInReport;
        private System.Windows.Forms.ToolStripMenuItem BtnCheckOutReport;
        private System.Windows.Forms.PictureBox PbxLeave;

    }
}