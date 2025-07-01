﻿namespace OpPOS.Views.Employees
{
    partial class FrmHorary
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorary));
            this.label7 = new System.Windows.Forms.Label();
            this.DgvHoraries = new System.Windows.Forms.DataGridView();
            this.PbxSearch = new System.Windows.Forms.PictureBox();
            this.PbxCancel = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PbxClose = new System.Windows.Forms.PictureBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnPaperbin = new System.Windows.Forms.ToolStripButton();
            this.TxtHoraryCode = new System.Windows.Forms.TextBox();
            this.DtpInitialHour = new System.Windows.Forms.DateTimePicker();
            this.DtpFinalHour = new System.Windows.Forms.DateTimePicker();
            this.PbxDestroy = new System.Windows.Forms.PictureBox();
            this.PbxRecovery = new System.Windows.Forms.PictureBox();
            this.TtpDestroy = new System.Windows.Forms.ToolTip(this.components);
            this.TtpRecovery = new System.Windows.Forms.ToolTip(this.components);
            this.TlpSelectRow = new System.Windows.Forms.ToolTip(this.components);
            this.PbxPrint = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoraries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClose)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDestroy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRecovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(172, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 106;
            this.label7.Text = "Hora final:";
            // 
            // DgvHoraries
            // 
            this.DgvHoraries.AllowUserToAddRows = false;
            this.DgvHoraries.AllowUserToDeleteRows = false;
            this.DgvHoraries.AllowUserToResizeColumns = false;
            this.DgvHoraries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvHoraries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHoraries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHoraries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgvHoraries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHoraries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRIPCION,
            this.HORA_INICIO,
            this.HORA_FINAL,
            this.REGISTRO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHoraries.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHoraries.Location = new System.Drawing.Point(14, 239);
            this.DgvHoraries.Name = "DgvHoraries";
            this.DgvHoraries.ReadOnly = true;
            this.DgvHoraries.RowHeadersVisible = false;
            this.DgvHoraries.RowHeadersWidth = 62;
            this.DgvHoraries.RowTemplate.Height = 28;
            this.DgvHoraries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHoraries.Size = new System.Drawing.Size(645, 287);
            this.DgvHoraries.TabIndex = 105;
            this.TlpSelectRow.SetToolTip(this.DgvHoraries, "Doble click para seleccionar registro.");
            this.DgvHoraries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHoraries_CellDoubleClick);
            // 
            // PbxSearch
            // 
            this.PbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxSearch.BackColor = System.Drawing.Color.Transparent;
            this.PbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("PbxSearch.Image")));
            this.PbxSearch.Location = new System.Drawing.Point(599, 200);
            this.PbxSearch.Name = "PbxSearch";
            this.PbxSearch.Size = new System.Drawing.Size(26, 27);
            this.PbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxSearch.TabIndex = 104;
            this.PbxSearch.TabStop = false;
            this.PbxSearch.Click += new System.EventHandler(this.PbxSearch_Click);
            // 
            // PbxCancel
            // 
            this.PbxCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCancel.BackColor = System.Drawing.Color.Transparent;
            this.PbxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxCancel.Image = ((System.Drawing.Image)(resources.GetObject("PbxCancel.Image")));
            this.PbxCancel.Location = new System.Drawing.Point(632, 200);
            this.PbxCancel.Name = "PbxCancel";
            this.PbxCancel.Size = new System.Drawing.Size(26, 27);
            this.PbxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCancel.TabIndex = 103;
            this.PbxCancel.TabStop = false;
            this.PbxCancel.Click += new System.EventHandler(this.PbxCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 102;
            this.label6.Text = "Buscar:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.TxtSearch.Location = new System.Drawing.Point(93, 200);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(388, 26);
            this.TxtSearch.TabIndex = 93;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.LblName.Location = new System.Drawing.Point(10, 130);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(113, 22);
            this.LblName.TabIndex = 100;
            this.LblName.Text = "Hora inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(172, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 98;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 97;
            this.label1.Text = "Código:";
            // 
            // PbxClose
            // 
            this.PbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.PbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxClose.Image = ((System.Drawing.Image)(resources.GetObject("PbxClose.Image")));
            this.PbxClose.Location = new System.Drawing.Point(646, 7);
            this.PbxClose.Name = "PbxClose";
            this.PbxClose.Size = new System.Drawing.Size(27, 26);
            this.PbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxClose.TabIndex = 96;
            this.PbxClose.TabStop = false;
            this.PbxClose.Click += new System.EventHandler(this.PbxClose_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.TxtDescription.Location = new System.Drawing.Point(176, 91);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDescription.MaxLength = 30;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(386, 26);
            this.TxtDescription.TabIndex = 85;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.toolStripSeparator1,
            this.BtnEdit,
            this.toolStripSeparator2,
            this.BtnDelete,
            this.toolStripSeparator3,
            this.BtnSave,
            this.toolStripSeparator4,
            this.BtnCancel,
            this.toolStripSeparator5,
            this.BtnPaperbin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 42);
            this.toolStrip1.TabIndex = 95;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(88, 37);
            this.BtnNew.Text = "Nuevo";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(80, 37);
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 37);
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 37);
            this.BtnSave.Text = "Guardar";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 37);
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 42);
            // 
            // BtnPaperbin
            // 
            this.BtnPaperbin.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaperbin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPaperbin.Image = ((System.Drawing.Image)(resources.GetObject("BtnPaperbin.Image")));
            this.BtnPaperbin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPaperbin.Name = "BtnPaperbin";
            this.BtnPaperbin.Size = new System.Drawing.Size(108, 37);
            this.BtnPaperbin.Text = "Papelera";
            this.BtnPaperbin.Click += new System.EventHandler(this.BtnPaperbin_Click);
            // 
            // TxtHoraryCode
            // 
            this.TxtHoraryCode.BackColor = System.Drawing.SystemColors.Control;
            this.TxtHoraryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHoraryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.TxtHoraryCode.Location = new System.Drawing.Point(13, 91);
            this.TxtHoraryCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtHoraryCode.Name = "TxtHoraryCode";
            this.TxtHoraryCode.ReadOnly = true;
            this.TxtHoraryCode.Size = new System.Drawing.Size(144, 26);
            this.TxtHoraryCode.TabIndex = 94;
            // 
            // DtpInitialHour
            // 
            this.DtpInitialHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpInitialHour.Location = new System.Drawing.Point(16, 161);
            this.DtpInitialHour.Name = "DtpInitialHour";
            this.DtpInitialHour.ShowUpDown = true;
            this.DtpInitialHour.Size = new System.Drawing.Size(141, 26);
            this.DtpInitialHour.TabIndex = 107;
            // 
            // DtpFinalHour
            // 
            this.DtpFinalHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpFinalHour.Location = new System.Drawing.Point(176, 161);
            this.DtpFinalHour.Name = "DtpFinalHour";
            this.DtpFinalHour.ShowUpDown = true;
            this.DtpFinalHour.Size = new System.Drawing.Size(141, 26);
            this.DtpFinalHour.TabIndex = 108;
            // 
            // PbxDestroy
            // 
            this.PbxDestroy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxDestroy.BackColor = System.Drawing.Color.Transparent;
            this.PbxDestroy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxDestroy.Image = ((System.Drawing.Image)(resources.GetObject("PbxDestroy.Image")));
            this.PbxDestroy.Location = new System.Drawing.Point(534, 200);
            this.PbxDestroy.Name = "PbxDestroy";
            this.PbxDestroy.Size = new System.Drawing.Size(26, 27);
            this.PbxDestroy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxDestroy.TabIndex = 110;
            this.PbxDestroy.TabStop = false;
            this.TtpDestroy.SetToolTip(this.PbxDestroy, "Destruir el registro definitivamente de la base de datos");
            this.PbxDestroy.Visible = false;
            this.PbxDestroy.Click += new System.EventHandler(this.PbxDestroy_Click);
            // 
            // PbxRecovery
            // 
            this.PbxRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxRecovery.BackColor = System.Drawing.Color.Transparent;
            this.PbxRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxRecovery.Image = ((System.Drawing.Image)(resources.GetObject("PbxRecovery.Image")));
            this.PbxRecovery.Location = new System.Drawing.Point(501, 200);
            this.PbxRecovery.Name = "PbxRecovery";
            this.PbxRecovery.Size = new System.Drawing.Size(26, 27);
            this.PbxRecovery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxRecovery.TabIndex = 109;
            this.PbxRecovery.TabStop = false;
            this.TtpRecovery.SetToolTip(this.PbxRecovery, "Recuperar registro de papelera");
            this.PbxRecovery.Visible = false;
            this.PbxRecovery.Click += new System.EventHandler(this.PbxRecovery_Click);
            // 
            // TtpDestroy
            // 
            this.TtpDestroy.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TtpDestroy.ToolTipTitle = "Destruir";
            // 
            // TtpRecovery
            // 
            this.TtpRecovery.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TtpRecovery.ToolTipTitle = "Recuperar ";
            // 
            // TlpSelectRow
            // 
            this.TlpSelectRow.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TlpSelectRow.ToolTipTitle = "Seleccionar";
            // 
            // PbxPrint
            // 
            this.PbxPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxPrint.BackColor = System.Drawing.Color.Transparent;
            this.PbxPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxPrint.Image = ((System.Drawing.Image)(resources.GetObject("PbxPrint.Image")));
            this.PbxPrint.Location = new System.Drawing.Point(566, 200);
            this.PbxPrint.Name = "PbxPrint";
            this.PbxPrint.Size = new System.Drawing.Size(26, 27);
            this.PbxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPrint.TabIndex = 145;
            this.PbxPrint.TabStop = false;
            this.PbxPrint.Click += new System.EventHandler(this.PbxPrint_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCIÓN";
            this.DESCRIPCION.MinimumWidth = 8;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // HORA_INICIO
            // 
            this.HORA_INICIO.HeaderText = "HORA INICIO";
            this.HORA_INICIO.MinimumWidth = 8;
            this.HORA_INICIO.Name = "HORA_INICIO";
            this.HORA_INICIO.ReadOnly = true;
            // 
            // HORA_FINAL
            // 
            this.HORA_FINAL.HeaderText = "HORA FINAL";
            this.HORA_FINAL.MinimumWidth = 8;
            this.HORA_FINAL.Name = "HORA_FINAL";
            this.HORA_FINAL.ReadOnly = true;
            // 
            // REGISTRO
            // 
            this.REGISTRO.HeaderText = "REGISTRO";
            this.REGISTRO.MinimumWidth = 8;
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.ReadOnly = true;
            // 
            // FrmHorary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(676, 537);
            this.Controls.Add(this.PbxPrint);
            this.Controls.Add(this.PbxDestroy);
            this.Controls.Add(this.PbxRecovery);
            this.Controls.Add(this.DtpFinalHour);
            this.Controls.Add(this.DtpInitialHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvHoraries);
            this.Controls.Add(this.PbxSearch);
            this.Controls.Add(this.PbxCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbxClose);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TxtHoraryCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHorary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horary";
            this.Load += new System.EventHandler(this.FrmHorary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoraries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClose)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDestroy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRecovery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvHoraries;
        private System.Windows.Forms.PictureBox PbxSearch;
        private System.Windows.Forms.PictureBox PbxCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbxClose;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TextBox TxtHoraryCode;
        private System.Windows.Forms.DateTimePicker DtpInitialHour;
        private System.Windows.Forms.DateTimePicker DtpFinalHour;
        private System.Windows.Forms.PictureBox PbxDestroy;
        private System.Windows.Forms.PictureBox PbxRecovery;
        private System.Windows.Forms.ToolStripButton BtnPaperbin;
        private System.Windows.Forms.ToolTip TtpDestroy;
        private System.Windows.Forms.ToolTip TtpRecovery;
        private System.Windows.Forms.ToolTip TlpSelectRow;
        private System.Windows.Forms.PictureBox PbxPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_INICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_FINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO;
    }
}