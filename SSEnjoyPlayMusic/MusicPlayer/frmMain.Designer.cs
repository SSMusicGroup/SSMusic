﻿namespace MusicPlayer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPLaylist = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_BaiHat_PL = new System.Windows.Forms.ComboBox();
            this.txt_Them_PL = new System.Windows.Forms.TextBox();
            this.cboPlayList = new System.Windows.Forms.ComboBox();
            this.dgvPlaylist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axWMP_main = new AxWMPLib.AxWindowsMediaPlayer();
            this.gbBaihat = new System.Windows.Forms.GroupBox();
            this.dgvBaiHat = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbox_ListNhac = new System.Windows.Forms.ListBox();
            this.gbCaSi = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_baiHat_CaSi = new System.Windows.Forms.ComboBox();
            this.btn_Them_CaSi = new System.Windows.Forms.Button();
            this.txt_Them_Casi = new System.Windows.Forms.TextBox();
            this.dgvCaSi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_CaSi = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.time_song = new System.Windows.Forms.Timer(this.components);
            this.menuBaiHat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmTênCaSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBàiHátVàoPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.PB_Timer = new Bunifu.Framework.UI.BunifuProgressBar();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_time_start = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_time_end = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_next_song = new Bunifu.Framework.UI.BunifuImageButton();
            this.play = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Action = new Bunifu.Framework.UI.BunifuImageButton();
            this.ImgBtnRanDom = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Stop_song = new Bunifu.Framework.UI.BunifuImageButton();
            this.IgmBtnRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back_Song = new Bunifu.Framework.UI.BunifuImageButton();
            this.pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Name_Song = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.lbl_AmLuong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_AmLuong = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPhatBaiHat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhatAllBaiHat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Them_baiHatByCaSi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhat_CaSi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhatAll_CaSi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Them_BHinPL = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Them_Playlist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhat_PLaylist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhatAll_PLaylist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ShowWMP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Casi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_PlayList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_NowPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Browser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_BaiHat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Min = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Max = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPLaylist.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_main)).BeginInit();
            this.gbBaihat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiHat)).BeginInit();
            this.gbCaSi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaSi)).BeginInit();
            this.menuBaiHat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Action)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBtnRanDom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop_song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgmBtnRepeat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back_Song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AmLuong)).BeginInit();
            this.pn_menu.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(200, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(698, 382);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pn_menu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 574);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.bunifuGradientPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(302, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(692, 570);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbBaihat);
            this.panel1.Controls.Add(this.lbox_ListNhac);
            this.panel1.Controls.Add(this.gbCaSi);
            this.panel1.Controls.Add(this.gbPLaylist);
            this.panel1.Controls.Add(this.axWMP_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 366);
            this.panel1.TabIndex = 3;
            // 
            // gbPLaylist
            // 
            this.gbPLaylist.BackColor = System.Drawing.Color.PowderBlue;
            this.gbPLaylist.Controls.Add(this.groupBox2);
            this.gbPLaylist.Controls.Add(this.btn_Them_Playlist);
            this.gbPLaylist.Controls.Add(this.txt_Them_PL);
            this.gbPLaylist.Controls.Add(this.btnPhat_PLaylist);
            this.gbPLaylist.Controls.Add(this.btnPhatAll_PLaylist);
            this.gbPLaylist.Controls.Add(this.cboPlayList);
            this.gbPLaylist.Controls.Add(this.dgvPlaylist);
            this.gbPLaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPLaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbPLaylist.Location = new System.Drawing.Point(0, 0);
            this.gbPLaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPLaylist.Name = "gbPLaylist";
            this.gbPLaylist.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPLaylist.Size = new System.Drawing.Size(686, 366);
            this.gbPLaylist.TabIndex = 3;
            this.gbPLaylist.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Them_BHinPL);
            this.groupBox2.Controls.Add(this.cbo_BaiHat_PL);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(323, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(347, 130);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm bài hát";
            // 
            // cbo_BaiHat_PL
            // 
            this.cbo_BaiHat_PL.FormattingEnabled = true;
            this.cbo_BaiHat_PL.Location = new System.Drawing.Point(9, 33);
            this.cbo_BaiHat_PL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_BaiHat_PL.Name = "cbo_BaiHat_PL";
            this.cbo_BaiHat_PL.Size = new System.Drawing.Size(335, 28);
            this.cbo_BaiHat_PL.TabIndex = 0;
            // 
            // txt_Them_PL
            // 
            this.txt_Them_PL.Location = new System.Drawing.Point(5, 85);
            this.txt_Them_PL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Them_PL.Name = "txt_Them_PL";
            this.txt_Them_PL.Size = new System.Drawing.Size(309, 22);
            this.txt_Them_PL.TabIndex = 9;
            // 
            // cboPlayList
            // 
            this.cboPlayList.FormattingEnabled = true;
            this.cboPlayList.Location = new System.Drawing.Point(4, 11);
            this.cboPlayList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPlayList.Name = "cboPlayList";
            this.cboPlayList.Size = new System.Drawing.Size(311, 24);
            this.cboPlayList.TabIndex = 5;
            this.cboPlayList.SelectedIndexChanged += new System.EventHandler(this.cboPlayList_SelectedIndexChanged);
            this.cboPlayList.SelectedValueChanged += new System.EventHandler(this.cboPlayList_SelectedValueChanged);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.AllowUserToAddRows = false;
            this.dgvPlaylist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPlaylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaylist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlaylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlaylist.DefaultCellStyle = dataGridViewCellStyle39;
            this.dgvPlaylist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPlaylist.DoubleBuffered = true;
            this.dgvPlaylist.EnableHeadersVisualStyles = false;
            this.dgvPlaylist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvPlaylist.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPlaylist.Location = new System.Drawing.Point(4, 148);
            this.dgvPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.ReadOnly = true;
            this.dgvPlaylist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlaylist.RowHeadersVisible = false;
            this.dgvPlaylist.Size = new System.Drawing.Size(678, 214);
            this.dgvPlaylist.TabIndex = 4;
            this.dgvPlaylist.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlaylist_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tenBaiHat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bài hát";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // axWMP_main
            // 
            this.axWMP_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWMP_main.Enabled = true;
            this.axWMP_main.Location = new System.Drawing.Point(0, 0);
            this.axWMP_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWMP_main.Name = "axWMP_main";
            this.axWMP_main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP_main.OcxState")));
            this.axWMP_main.Size = new System.Drawing.Size(686, 366);
            this.axWMP_main.TabIndex = 0;
            this.axWMP_main.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWMP_main_PlayStateChange);
            // 
            // gbBaihat
            // 
            this.gbBaihat.BackColor = System.Drawing.Color.PowderBlue;
            this.gbBaihat.Controls.Add(this.btnPhatBaiHat);
            this.gbBaihat.Controls.Add(this.btnPhatAllBaiHat);
            this.gbBaihat.Controls.Add(this.dgvBaiHat);
            this.gbBaihat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBaihat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbBaihat.Location = new System.Drawing.Point(0, 0);
            this.gbBaihat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBaihat.Name = "gbBaihat";
            this.gbBaihat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBaihat.Size = new System.Drawing.Size(686, 366);
            this.gbBaihat.TabIndex = 6;
            this.gbBaihat.TabStop = false;
            // 
            // dgvBaiHat
            // 
            this.dgvBaiHat.AllowUserToAddRows = false;
            this.dgvBaiHat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBaiHat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvBaiHat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaiHat.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBaiHat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaiHat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaiHat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvBaiHat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaiHat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaiHat.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgvBaiHat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBaiHat.DoubleBuffered = true;
            this.dgvBaiHat.EnableHeadersVisualStyles = false;
            this.dgvBaiHat.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvBaiHat.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBaiHat.Location = new System.Drawing.Point(4, 86);
            this.dgvBaiHat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBaiHat.Name = "dgvBaiHat";
            this.dgvBaiHat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBaiHat.RowHeadersVisible = false;
            this.dgvBaiHat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaiHat.Size = new System.Drawing.Size(678, 276);
            this.dgvBaiHat.TabIndex = 4;
            this.dgvBaiHat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBaiHat_CellMouseClick);
            this.dgvBaiHat.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBaiHat_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenBaiHat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Bài hát";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // lbox_ListNhac
            // 
            this.lbox_ListNhac.BackColor = System.Drawing.Color.PowderBlue;
            this.lbox_ListNhac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_ListNhac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_ListNhac.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbox_ListNhac.ForeColor = System.Drawing.Color.LightCoral;
            this.lbox_ListNhac.FormattingEnabled = true;
            this.lbox_ListNhac.ItemHeight = 23;
            this.lbox_ListNhac.Location = new System.Drawing.Point(0, 0);
            this.lbox_ListNhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox_ListNhac.Name = "lbox_ListNhac";
            this.lbox_ListNhac.Size = new System.Drawing.Size(686, 366);
            this.lbox_ListNhac.TabIndex = 1;
            this.lbox_ListNhac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbox_ListNhac_MouseClick);
            this.lbox_ListNhac.SelectedIndexChanged += new System.EventHandler(this.lbox_ListNhac_SelectedIndexChanged);
            // 
            // gbCaSi
            // 
            this.gbCaSi.BackColor = System.Drawing.Color.PowderBlue;
            this.gbCaSi.Controls.Add(this.groupBox1);
            this.gbCaSi.Controls.Add(this.btn_Them_CaSi);
            this.gbCaSi.Controls.Add(this.txt_Them_Casi);
            this.gbCaSi.Controls.Add(this.btnPhat_CaSi);
            this.gbCaSi.Controls.Add(this.btnPhatAll_CaSi);
            this.gbCaSi.Controls.Add(this.dgvCaSi);
            this.gbCaSi.Controls.Add(this.cbo_CaSi);
            this.gbCaSi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCaSi.Location = new System.Drawing.Point(0, 0);
            this.gbCaSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCaSi.Name = "gbCaSi";
            this.gbCaSi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCaSi.Size = new System.Drawing.Size(686, 366);
            this.gbCaSi.TabIndex = 2;
            this.gbCaSi.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Them_baiHatByCaSi);
            this.groupBox1.Controls.Add(this.cbo_baiHat_CaSi);
            this.groupBox1.Location = new System.Drawing.Point(331, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(343, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm vào bài hát";
            // 
            // cbo_baiHat_CaSi
            // 
            this.cbo_baiHat_CaSi.FormattingEnabled = true;
            this.cbo_baiHat_CaSi.Location = new System.Drawing.Point(9, 21);
            this.cbo_baiHat_CaSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_baiHat_CaSi.Name = "cbo_baiHat_CaSi";
            this.cbo_baiHat_CaSi.Size = new System.Drawing.Size(289, 24);
            this.cbo_baiHat_CaSi.TabIndex = 0;
            // 
            // btn_Them_CaSi
            // 
            this.btn_Them_CaSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them_CaSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them_CaSi.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_Them_CaSi.Location = new System.Drawing.Point(110, 114);
            this.btn_Them_CaSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them_CaSi.Name = "btn_Them_CaSi";
            this.btn_Them_CaSi.Size = new System.Drawing.Size(113, 27);
            this.btn_Them_CaSi.TabIndex = 10;
            this.btn_Them_CaSi.Text = "Thêm ca sĩ";
            this.btn_Them_CaSi.UseVisualStyleBackColor = true;
            this.btn_Them_CaSi.Click += new System.EventHandler(this.btn_Them_CaSi_Click);
            // 
            // txt_Them_Casi
            // 
            this.txt_Them_Casi.Location = new System.Drawing.Point(4, 84);
            this.txt_Them_Casi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Them_Casi.Name = "txt_Them_Casi";
            this.txt_Them_Casi.Size = new System.Drawing.Size(318, 22);
            this.txt_Them_Casi.TabIndex = 9;
            // 
            // dgvCaSi
            // 
            this.dgvCaSi.AllowUserToAddRows = false;
            this.dgvCaSi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCaSi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            this.dgvCaSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaSi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCaSi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaSi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaSi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvCaSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaSi.DefaultCellStyle = dataGridViewCellStyle45;
            this.dgvCaSi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCaSi.DoubleBuffered = true;
            this.dgvCaSi.EnableHeadersVisualStyles = false;
            this.dgvCaSi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCaSi.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCaSi.Location = new System.Drawing.Point(4, 148);
            this.dgvCaSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCaSi.Name = "dgvCaSi";
            this.dgvCaSi.ReadOnly = true;
            this.dgvCaSi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCaSi.RowHeadersVisible = false;
            this.dgvCaSi.Size = new System.Drawing.Size(678, 214);
            this.dgvCaSi.TabIndex = 3;
            this.dgvCaSi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCaSi_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenBaiHat";
            this.Column1.HeaderText = "Bài hát";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cbo_CaSi
            // 
            this.cbo_CaSi.FormattingEnabled = true;
            this.cbo_CaSi.Location = new System.Drawing.Point(5, 11);
            this.cbo_CaSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_CaSi.Name = "cbo_CaSi";
            this.cbo_CaSi.Size = new System.Drawing.Size(317, 24);
            this.cbo_CaSi.TabIndex = 2;
            this.cbo_CaSi.SelectedIndexChanged += new System.EventHandler(this.cbo_CaSi_SelectedIndexChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.tableLayoutPanel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.tableLayoutPanel5;
            this.bunifuDragControl3.Vertical = true;
            // 
            // time_song
            // 
            this.time_song.Tick += new System.EventHandler(this.time_song_Tick);
            // 
            // menuBaiHat
            // 
            this.menuBaiHat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBaiHat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmTênCaSĩToolStripMenuItem,
            this.thêmBàiHátVàoPlaylistToolStripMenuItem});
            this.menuBaiHat.Name = "menuBaiHat";
            this.menuBaiHat.Size = new System.Drawing.Size(252, 52);
            // 
            // thêmTênCaSĩToolStripMenuItem
            // 
            this.thêmTênCaSĩToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.thêmTênCaSĩToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thêmTênCaSĩToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.thêmTênCaSĩToolStripMenuItem.Name = "thêmTênCaSĩToolStripMenuItem";
            this.thêmTênCaSĩToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.thêmTênCaSĩToolStripMenuItem.Text = "Thêm tên ca sĩ";
            // 
            // thêmBàiHátVàoPlaylistToolStripMenuItem
            // 
            this.thêmBàiHátVàoPlaylistToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.thêmBàiHátVàoPlaylistToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thêmBàiHátVàoPlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.thêmBàiHátVàoPlaylistToolStripMenuItem.Name = "thêmBàiHátVàoPlaylistToolStripMenuItem";
            this.thêmBàiHátVàoPlaylistToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.thêmBàiHátVàoPlaylistToolStripMenuItem.Text = "Thêm bài hát vào playlist";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.tableLayoutPanel7);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MediumAquamarine;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkCyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 372);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(686, 196);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.PB_Timer, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(686, 196);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // PB_Timer
            // 
            this.PB_Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Timer.BackColor = System.Drawing.Color.Silver;
            this.PB_Timer.BorderRadius = 5;
            this.PB_Timer.Location = new System.Drawing.Point(5, 8);
            this.PB_Timer.Margin = new System.Windows.Forms.Padding(5);
            this.PB_Timer.MaximumValue = 100;
            this.PB_Timer.Name = "PB_Timer";
            this.PB_Timer.ProgressColor = System.Drawing.Color.Teal;
            this.PB_Timer.Size = new System.Drawing.Size(676, 12);
            this.PB_Timer.TabIndex = 0;
            this.PB_Timer.Value = 100;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.34375F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.69531F));
            this.tableLayoutPanel8.Controls.Add(this.lbl_time_start, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lbl_time_end, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(680, 35);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // lbl_time_start
            // 
            this.lbl_time_start.AutoSize = true;
            this.lbl_time_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_time_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_start.Location = new System.Drawing.Point(3, 0);
            this.lbl_time_start.Name = "lbl_time_start";
            this.lbl_time_start.Size = new System.Drawing.Size(61, 35);
            this.lbl_time_start.TabIndex = 0;
            this.lbl_time_start.Text = "00:00";
            // 
            // lbl_time_end
            // 
            this.lbl_time_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time_end.AutoSize = true;
            this.lbl_time_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_end.Location = new System.Drawing.Point(627, 0);
            this.lbl_time_end.Name = "lbl_time_end";
            this.lbl_time_end.Size = new System.Drawing.Size(50, 20);
            this.lbl_time_end.TabIndex = 1;
            this.lbl_time_end.Text = "00:00";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel9.ColumnCount = 8;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.29412F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.558824F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.panel3, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_Action, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.ImgBtnRanDom, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_Stop_song, 5, 0);
            this.tableLayoutPanel9.Controls.Add(this.IgmBtnRepeat, 6, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 128);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(680, 66);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_next_song);
            this.panel3.Controls.Add(this.play);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(345, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 62);
            this.panel3.TabIndex = 7;
            // 
            // btn_next_song
            // 
            this.btn_next_song.BackColor = System.Drawing.Color.Transparent;
            this.btn_next_song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_next_song.Image = global::MusicPlayer.Properties.Resources.next;
            this.btn_next_song.ImageActive = null;
            this.btn_next_song.Location = new System.Drawing.Point(0, 0);
            this.btn_next_song.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next_song.Name = "btn_next_song";
            this.btn_next_song.Size = new System.Drawing.Size(59, 62);
            this.btn_next_song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next_song.TabIndex = 2;
            this.btn_next_song.TabStop = false;
            this.btn_next_song.Zoom = 10;
            this.btn_next_song.Click += new System.EventHandler(this.btn_next_song_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Image = global::MusicPlayer.Properties.Resources.pause_100px;
            this.play.ImageActive = null;
            this.play.Location = new System.Drawing.Point(3, 10);
            this.play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(49, 41);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 1;
            this.play.TabStop = false;
            this.play.Zoom = 10;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // btn_Action
            // 
            this.btn_Action.BackColor = System.Drawing.Color.Transparent;
            this.btn_Action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Action.Image = global::MusicPlayer.Properties.Resources.pause_100px;
            this.btn_Action.ImageActive = null;
            this.btn_Action.Location = new System.Drawing.Point(275, 2);
            this.btn_Action.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(64, 62);
            this.btn_Action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Action.TabIndex = 0;
            this.btn_Action.TabStop = false;
            this.btn_Action.Zoom = 10;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // ImgBtnRanDom
            // 
            this.ImgBtnRanDom.BackColor = System.Drawing.Color.Transparent;
            this.ImgBtnRanDom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgBtnRanDom.Image = global::MusicPlayer.Properties.Resources.shuffle_100px;
            this.ImgBtnRanDom.ImageActive = null;
            this.ImgBtnRanDom.Location = new System.Drawing.Point(139, 2);
            this.ImgBtnRanDom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImgBtnRanDom.Name = "ImgBtnRanDom";
            this.ImgBtnRanDom.Size = new System.Drawing.Size(62, 62);
            this.ImgBtnRanDom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBtnRanDom.TabIndex = 3;
            this.ImgBtnRanDom.TabStop = false;
            this.ImgBtnRanDom.Zoom = 10;
            this.ImgBtnRanDom.Click += new System.EventHandler(this.ImgBtnRanDom_Click);
            // 
            // btn_Stop_song
            // 
            this.btn_Stop_song.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop_song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Stop_song.Image = global::MusicPlayer.Properties.Resources.stop_100px;
            this.btn_Stop_song.ImageActive = null;
            this.btn_Stop_song.Location = new System.Drawing.Point(410, 2);
            this.btn_Stop_song.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Stop_song.Name = "btn_Stop_song";
            this.btn_Stop_song.Size = new System.Drawing.Size(62, 62);
            this.btn_Stop_song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Stop_song.TabIndex = 4;
            this.btn_Stop_song.TabStop = false;
            this.btn_Stop_song.Zoom = 10;
            this.btn_Stop_song.Click += new System.EventHandler(this.btn_Stop_song_Click);
            // 
            // IgmBtnRepeat
            // 
            this.IgmBtnRepeat.BackColor = System.Drawing.Color.Transparent;
            this.IgmBtnRepeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IgmBtnRepeat.Image = global::MusicPlayer.Properties.Resources.available_updates_100px;
            this.IgmBtnRepeat.ImageActive = null;
            this.IgmBtnRepeat.Location = new System.Drawing.Point(478, 2);
            this.IgmBtnRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IgmBtnRepeat.Name = "IgmBtnRepeat";
            this.IgmBtnRepeat.Size = new System.Drawing.Size(62, 62);
            this.IgmBtnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IgmBtnRepeat.TabIndex = 5;
            this.IgmBtnRepeat.TabStop = false;
            this.IgmBtnRepeat.Zoom = 10;
            this.IgmBtnRepeat.Click += new System.EventHandler(this.IgmBtnRepeat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_back_Song);
            this.panel2.Controls.Add(this.pause);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(207, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 62);
            this.panel2.TabIndex = 6;
            // 
            // btn_back_Song
            // 
            this.btn_back_Song.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_Song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_back_Song.Image = global::MusicPlayer.Properties.Resources.back_to_100px;
            this.btn_back_Song.ImageActive = null;
            this.btn_back_Song.Location = new System.Drawing.Point(0, 0);
            this.btn_back_Song.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back_Song.Name = "btn_back_Song";
            this.btn_back_Song.Size = new System.Drawing.Size(62, 62);
            this.btn_back_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back_Song.TabIndex = 1;
            this.btn_back_Song.TabStop = false;
            this.btn_back_Song.Zoom = 10;
            this.btn_back_Song.Click += new System.EventHandler(this.btn_back_Song_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Image = global::MusicPlayer.Properties.Resources.play_100px;
            this.pause.ImageActive = null;
            this.pause.Location = new System.Drawing.Point(0, 7);
            this.pause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(59, 44);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause.TabIndex = 1;
            this.pause.TabStop = false;
            this.pause.Zoom = 10;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel10.Controls.Add(this.lbl_Name_Song, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.bunifuSlider1, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.lbl_AmLuong, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.btn_AmLuong, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(680, 54);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // lbl_Name_Song
            // 
            this.lbl_Name_Song.AutoSize = true;
            this.lbl_Name_Song.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Song.Location = new System.Drawing.Point(3, 0);
            this.lbl_Name_Song.Name = "lbl_Name_Song";
            this.lbl_Name_Song.Size = new System.Drawing.Size(104, 23);
            this.lbl_Name_Song.TabIndex = 0;
            this.lbl_Name_Song.Text = "Tên bài hát";
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.Tomato;
            this.bunifuSlider1.Location = new System.Drawing.Point(467, 9);
            this.bunifuSlider1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(160, 35);
            this.bunifuSlider1.TabIndex = 1;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // lbl_AmLuong
            // 
            this.lbl_AmLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AmLuong.AutoSize = true;
            this.lbl_AmLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmLuong.Location = new System.Drawing.Point(635, 15);
            this.lbl_AmLuong.Name = "lbl_AmLuong";
            this.lbl_AmLuong.Size = new System.Drawing.Size(42, 24);
            this.lbl_AmLuong.TabIndex = 2;
            this.lbl_AmLuong.Text = "100";
            // 
            // btn_AmLuong
            // 
            this.btn_AmLuong.BackColor = System.Drawing.Color.Transparent;
            this.btn_AmLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AmLuong.Image = global::MusicPlayer.Properties.Resources.audio_100px;
            this.btn_AmLuong.ImageActive = null;
            this.btn_AmLuong.Location = new System.Drawing.Point(397, 2);
            this.btn_AmLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AmLuong.Name = "btn_AmLuong";
            this.btn_AmLuong.Size = new System.Drawing.Size(62, 50);
            this.btn_AmLuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AmLuong.TabIndex = 3;
            this.btn_AmLuong.TabStop = false;
            this.btn_AmLuong.Zoom = 100;
            this.btn_AmLuong.Click += new System.EventHandler(this.btn_AmLuong_Click);
            // 
            // btnPhatBaiHat
            // 
            this.btnPhatBaiHat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatBaiHat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatBaiHat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhatBaiHat.BorderRadius = 0;
            this.btnPhatBaiHat.ButtonText = "Phát";
            this.btnPhatBaiHat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhatBaiHat.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhatBaiHat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhatBaiHat.Iconimage = global::MusicPlayer.Properties.Resources.circled_play_100px;
            this.btnPhatBaiHat.Iconimage_right = null;
            this.btnPhatBaiHat.Iconimage_right_Selected = null;
            this.btnPhatBaiHat.Iconimage_Selected = null;
            this.btnPhatBaiHat.IconMarginLeft = 0;
            this.btnPhatBaiHat.IconMarginRight = 0;
            this.btnPhatBaiHat.IconRightVisible = true;
            this.btnPhatBaiHat.IconRightZoom = 0D;
            this.btnPhatBaiHat.IconVisible = true;
            this.btnPhatBaiHat.IconZoom = 90D;
            this.btnPhatBaiHat.IsTab = false;
            this.btnPhatBaiHat.Location = new System.Drawing.Point(353, 11);
            this.btnPhatBaiHat.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhatBaiHat.Name = "btnPhatBaiHat";
            this.btnPhatBaiHat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatBaiHat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPhatBaiHat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhatBaiHat.selected = false;
            this.btnPhatBaiHat.Size = new System.Drawing.Size(321, 59);
            this.btnPhatBaiHat.TabIndex = 6;
            this.btnPhatBaiHat.Text = "Phát";
            this.btnPhatBaiHat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhatBaiHat.Textcolor = System.Drawing.Color.White;
            this.btnPhatBaiHat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhatBaiHat.Click += new System.EventHandler(this.btnPhatBaiHat_Click);
            // 
            // btnPhatAllBaiHat
            // 
            this.btnPhatAllBaiHat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAllBaiHat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAllBaiHat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhatAllBaiHat.BorderRadius = 0;
            this.btnPhatAllBaiHat.ButtonText = "Phát tất cả";
            this.btnPhatAllBaiHat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhatAllBaiHat.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhatAllBaiHat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhatAllBaiHat.Iconimage = global::MusicPlayer.Properties.Resources.video_playlist_100px;
            this.btnPhatAllBaiHat.Iconimage_right = null;
            this.btnPhatAllBaiHat.Iconimage_right_Selected = null;
            this.btnPhatAllBaiHat.Iconimage_Selected = null;
            this.btnPhatAllBaiHat.IconMarginLeft = 0;
            this.btnPhatAllBaiHat.IconMarginRight = 0;
            this.btnPhatAllBaiHat.IconRightVisible = true;
            this.btnPhatAllBaiHat.IconRightZoom = 0D;
            this.btnPhatAllBaiHat.IconVisible = true;
            this.btnPhatAllBaiHat.IconZoom = 90D;
            this.btnPhatAllBaiHat.IsTab = false;
            this.btnPhatAllBaiHat.Location = new System.Drawing.Point(11, 11);
            this.btnPhatAllBaiHat.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhatAllBaiHat.Name = "btnPhatAllBaiHat";
            this.btnPhatAllBaiHat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAllBaiHat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPhatAllBaiHat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhatAllBaiHat.selected = false;
            this.btnPhatAllBaiHat.Size = new System.Drawing.Size(321, 59);
            this.btnPhatAllBaiHat.TabIndex = 5;
            this.btnPhatAllBaiHat.Text = "Phát tất cả";
            this.btnPhatAllBaiHat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhatAllBaiHat.Textcolor = System.Drawing.Color.White;
            this.btnPhatAllBaiHat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhatAllBaiHat.Click += new System.EventHandler(this.btnPhatAllBaiHat_Click);
            // 
            // btn_Them_baiHatByCaSi
            // 
            this.btn_Them_baiHatByCaSi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_baiHatByCaSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_baiHatByCaSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them_baiHatByCaSi.BorderRadius = 0;
            this.btn_Them_baiHatByCaSi.ButtonText = "Thêm";
            this.btn_Them_baiHatByCaSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them_baiHatByCaSi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Them_baiHatByCaSi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Them_baiHatByCaSi.Iconimage = global::MusicPlayer.Properties.Resources.add_new_100px;
            this.btn_Them_baiHatByCaSi.Iconimage_right = null;
            this.btn_Them_baiHatByCaSi.Iconimage_right_Selected = null;
            this.btn_Them_baiHatByCaSi.Iconimage_Selected = null;
            this.btn_Them_baiHatByCaSi.IconMarginLeft = 0;
            this.btn_Them_baiHatByCaSi.IconMarginRight = 0;
            this.btn_Them_baiHatByCaSi.IconRightVisible = true;
            this.btn_Them_baiHatByCaSi.IconRightZoom = 0D;
            this.btn_Them_baiHatByCaSi.IconVisible = true;
            this.btn_Them_baiHatByCaSi.IconZoom = 90D;
            this.btn_Them_baiHatByCaSi.IsTab = false;
            this.btn_Them_baiHatByCaSi.Location = new System.Drawing.Point(11, 53);
            this.btn_Them_baiHatByCaSi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Them_baiHatByCaSi.Name = "btn_Them_baiHatByCaSi";
            this.btn_Them_baiHatByCaSi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_baiHatByCaSi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Them_baiHatByCaSi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Them_baiHatByCaSi.selected = false;
            this.btn_Them_baiHatByCaSi.Size = new System.Drawing.Size(149, 46);
            this.btn_Them_baiHatByCaSi.TabIndex = 9;
            this.btn_Them_baiHatByCaSi.Text = "Thêm";
            this.btn_Them_baiHatByCaSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Them_baiHatByCaSi.Textcolor = System.Drawing.Color.White;
            this.btn_Them_baiHatByCaSi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_baiHatByCaSi.Click += new System.EventHandler(this.btn_Them_baiHatByCaSi_Click);
            // 
            // btnPhat_CaSi
            // 
            this.btnPhat_CaSi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhat_CaSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhat_CaSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhat_CaSi.BorderRadius = 0;
            this.btnPhat_CaSi.ButtonText = "Phát";
            this.btnPhat_CaSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhat_CaSi.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhat_CaSi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhat_CaSi.Iconimage = global::MusicPlayer.Properties.Resources.circled_play_100px;
            this.btnPhat_CaSi.Iconimage_right = null;
            this.btnPhat_CaSi.Iconimage_right_Selected = null;
            this.btnPhat_CaSi.Iconimage_Selected = null;
            this.btnPhat_CaSi.IconMarginLeft = 0;
            this.btnPhat_CaSi.IconMarginRight = 0;
            this.btnPhat_CaSi.IconRightVisible = true;
            this.btnPhat_CaSi.IconRightZoom = 0D;
            this.btnPhat_CaSi.IconVisible = true;
            this.btnPhat_CaSi.IconZoom = 90D;
            this.btnPhat_CaSi.IsTab = false;
            this.btnPhat_CaSi.Location = new System.Drawing.Point(173, 44);
            this.btnPhat_CaSi.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhat_CaSi.Name = "btnPhat_CaSi";
            this.btnPhat_CaSi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhat_CaSi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPhat_CaSi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhat_CaSi.selected = false;
            this.btnPhat_CaSi.Size = new System.Drawing.Size(149, 34);
            this.btnPhat_CaSi.TabIndex = 8;
            this.btnPhat_CaSi.Text = "Phát";
            this.btnPhat_CaSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhat_CaSi.Textcolor = System.Drawing.Color.White;
            this.btnPhat_CaSi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhat_CaSi.Click += new System.EventHandler(this.btnPhat_CaSi_Click);
            // 
            // btnPhatAll_CaSi
            // 
            this.btnPhatAll_CaSi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAll_CaSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAll_CaSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhatAll_CaSi.BorderRadius = 0;
            this.btnPhatAll_CaSi.ButtonText = "Phát tất cả";
            this.btnPhatAll_CaSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhatAll_CaSi.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhatAll_CaSi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhatAll_CaSi.Iconimage = global::MusicPlayer.Properties.Resources.video_playlist_100px;
            this.btnPhatAll_CaSi.Iconimage_right = null;
            this.btnPhatAll_CaSi.Iconimage_right_Selected = null;
            this.btnPhatAll_CaSi.Iconimage_Selected = null;
            this.btnPhatAll_CaSi.IconMarginLeft = 0;
            this.btnPhatAll_CaSi.IconMarginRight = 0;
            this.btnPhatAll_CaSi.IconRightVisible = true;
            this.btnPhatAll_CaSi.IconRightZoom = 0D;
            this.btnPhatAll_CaSi.IconVisible = true;
            this.btnPhatAll_CaSi.IconZoom = 90D;
            this.btnPhatAll_CaSi.IsTab = false;
            this.btnPhatAll_CaSi.Location = new System.Drawing.Point(3, 44);
            this.btnPhatAll_CaSi.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhatAll_CaSi.Name = "btnPhatAll_CaSi";
            this.btnPhatAll_CaSi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAll_CaSi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPhatAll_CaSi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhatAll_CaSi.selected = false;
            this.btnPhatAll_CaSi.Size = new System.Drawing.Size(149, 34);
            this.btnPhatAll_CaSi.TabIndex = 7;
            this.btnPhatAll_CaSi.Text = "Phát tất cả";
            this.btnPhatAll_CaSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhatAll_CaSi.Textcolor = System.Drawing.Color.White;
            this.btnPhatAll_CaSi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhatAll_CaSi.Click += new System.EventHandler(this.btnPhatAll_CaSi_Click);
            // 
            // btn_Them_BHinPL
            // 
            this.btn_Them_BHinPL.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_BHinPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_BHinPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them_BHinPL.BorderRadius = 0;
            this.btn_Them_BHinPL.ButtonText = "Thêm";
            this.btn_Them_BHinPL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them_BHinPL.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Them_BHinPL.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Them_BHinPL.Iconimage = global::MusicPlayer.Properties.Resources.add_new_100px;
            this.btn_Them_BHinPL.Iconimage_right = null;
            this.btn_Them_BHinPL.Iconimage_right_Selected = null;
            this.btn_Them_BHinPL.Iconimage_Selected = null;
            this.btn_Them_BHinPL.IconMarginLeft = 0;
            this.btn_Them_BHinPL.IconMarginRight = 0;
            this.btn_Them_BHinPL.IconRightVisible = true;
            this.btn_Them_BHinPL.IconRightZoom = 0D;
            this.btn_Them_BHinPL.IconVisible = true;
            this.btn_Them_BHinPL.IconZoom = 90D;
            this.btn_Them_BHinPL.IsTab = false;
            this.btn_Them_BHinPL.Location = new System.Drawing.Point(9, 70);
            this.btn_Them_BHinPL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Them_BHinPL.Name = "btn_Them_BHinPL";
            this.btn_Them_BHinPL.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_BHinPL.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Them_BHinPL.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Them_BHinPL.selected = false;
            this.btn_Them_BHinPL.Size = new System.Drawing.Size(171, 36);
            this.btn_Them_BHinPL.TabIndex = 11;
            this.btn_Them_BHinPL.Text = "Thêm";
            this.btn_Them_BHinPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Them_BHinPL.Textcolor = System.Drawing.Color.White;
            this.btn_Them_BHinPL.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_BHinPL.Click += new System.EventHandler(this.btn_Them_BHinPL_Click);
            // 
            // btn_Them_Playlist
            // 
            this.btn_Them_Playlist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_Playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them_Playlist.BorderRadius = 0;
            this.btn_Them_Playlist.ButtonText = "Thêm playlist";
            this.btn_Them_Playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them_Playlist.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Them_Playlist.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Them_Playlist.Iconimage = global::MusicPlayer.Properties.Resources.add_new_100px;
            this.btn_Them_Playlist.Iconimage_right = null;
            this.btn_Them_Playlist.Iconimage_right_Selected = null;
            this.btn_Them_Playlist.Iconimage_Selected = null;
            this.btn_Them_Playlist.IconMarginLeft = 0;
            this.btn_Them_Playlist.IconMarginRight = 0;
            this.btn_Them_Playlist.IconRightVisible = true;
            this.btn_Them_Playlist.IconRightZoom = 0D;
            this.btn_Them_Playlist.IconVisible = true;
            this.btn_Them_Playlist.IconZoom = 90D;
            this.btn_Them_Playlist.IsTab = false;
            this.btn_Them_Playlist.Location = new System.Drawing.Point(71, 114);
            this.btn_Them_Playlist.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Them_Playlist.Name = "btn_Them_Playlist";
            this.btn_Them_Playlist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Them_Playlist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Them_Playlist.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Them_Playlist.selected = false;
            this.btn_Them_Playlist.Size = new System.Drawing.Size(179, 30);
            this.btn_Them_Playlist.TabIndex = 10;
            this.btn_Them_Playlist.Text = "Thêm playlist";
            this.btn_Them_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Them_Playlist.Textcolor = System.Drawing.Color.White;
            this.btn_Them_Playlist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_Playlist.Click += new System.EventHandler(this.btn_Them_Playlist_Click);
            // 
            // btnPhat_PLaylist
            // 
            this.btnPhat_PLaylist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhat_PLaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhat_PLaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhat_PLaylist.BorderRadius = 0;
            this.btnPhat_PLaylist.ButtonText = "Phát";
            this.btnPhat_PLaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhat_PLaylist.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhat_PLaylist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhat_PLaylist.Iconimage = global::MusicPlayer.Properties.Resources.circled_play_100px;
            this.btnPhat_PLaylist.Iconimage_right = null;
            this.btnPhat_PLaylist.Iconimage_right_Selected = null;
            this.btnPhat_PLaylist.Iconimage_Selected = null;
            this.btnPhat_PLaylist.IconMarginLeft = 0;
            this.btnPhat_PLaylist.IconMarginRight = 0;
            this.btnPhat_PLaylist.IconRightVisible = true;
            this.btnPhat_PLaylist.IconRightZoom = 0D;
            this.btnPhat_PLaylist.IconVisible = true;
            this.btnPhat_PLaylist.IconZoom = 90D;
            this.btnPhat_PLaylist.IsTab = false;
            this.btnPhat_PLaylist.Location = new System.Drawing.Point(164, 44);
            this.btnPhat_PLaylist.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhat_PLaylist.Name = "btnPhat_PLaylist";
            this.btnPhat_PLaylist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhat_PLaylist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPhat_PLaylist.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhat_PLaylist.selected = false;
            this.btnPhat_PLaylist.Size = new System.Drawing.Size(149, 33);
            this.btnPhat_PLaylist.TabIndex = 8;
            this.btnPhat_PLaylist.Text = "Phát";
            this.btnPhat_PLaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhat_PLaylist.Textcolor = System.Drawing.Color.White;
            this.btnPhat_PLaylist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhat_PLaylist.Click += new System.EventHandler(this.btnPhat_PLaylist_Click);
            // 
            // btnPhatAll_PLaylist
            // 
            this.btnPhatAll_PLaylist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAll_PLaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAll_PLaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhatAll_PLaylist.BorderRadius = 0;
            this.btnPhatAll_PLaylist.ButtonText = "Phát tất cả";
            this.btnPhatAll_PLaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhatAll_PLaylist.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhatAll_PLaylist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhatAll_PLaylist.Iconimage = global::MusicPlayer.Properties.Resources.video_playlist_100px;
            this.btnPhatAll_PLaylist.Iconimage_right = null;
            this.btnPhatAll_PLaylist.Iconimage_right_Selected = null;
            this.btnPhatAll_PLaylist.Iconimage_Selected = null;
            this.btnPhatAll_PLaylist.IconMarginLeft = 0;
            this.btnPhatAll_PLaylist.IconMarginRight = 0;
            this.btnPhatAll_PLaylist.IconRightVisible = true;
            this.btnPhatAll_PLaylist.IconRightZoom = 0D;
            this.btnPhatAll_PLaylist.IconVisible = true;
            this.btnPhatAll_PLaylist.IconZoom = 90D;
            this.btnPhatAll_PLaylist.IsTab = false;
            this.btnPhatAll_PLaylist.Location = new System.Drawing.Point(5, 44);
            this.btnPhatAll_PLaylist.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhatAll_PLaylist.Name = "btnPhatAll_PLaylist";
            this.btnPhatAll_PLaylist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPhatAll_PLaylist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPhatAll_PLaylist.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhatAll_PLaylist.selected = false;
            this.btnPhatAll_PLaylist.Size = new System.Drawing.Size(149, 33);
            this.btnPhatAll_PLaylist.TabIndex = 7;
            this.btnPhatAll_PLaylist.Text = "Phát tất cả";
            this.btnPhatAll_PLaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhatAll_PLaylist.Textcolor = System.Drawing.Color.White;
            this.btnPhatAll_PLaylist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhatAll_PLaylist.Click += new System.EventHandler(this.btnPhatAll_PLaylist_Click);
            // 
            // pn_menu
            // 
            this.pn_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_menu.BackgroundImage")));
            this.pn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_menu.Controls.Add(this.tableLayoutPanel3);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_menu.GradientBottomLeft = System.Drawing.Color.Turquoise;
            this.pn_menu.GradientBottomRight = System.Drawing.Color.MediumAquamarine;
            this.pn_menu.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.pn_menu.GradientTopRight = System.Drawing.Color.DarkCyan;
            this.pn_menu.Location = new System.Drawing.Point(3, 2);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Quality = 10;
            this.pn_menu.Size = new System.Drawing.Size(293, 570);
            this.pn_menu.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(293, 570);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.52448F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.3986F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(287, 110);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MusicPlayer.Properties.Resources.music_100px;
            this.pictureBox1.Location = new System.Drawing.Point(76, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btn_ShowWMP, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_Casi, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.btn_PlayList, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.btn_NowPlay, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.btn_Browser, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.btn_BaiHat, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 230);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(287, 338);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // btn_ShowWMP
            // 
            this.btn_ShowWMP.Activecolor = System.Drawing.Color.Blue;
            this.btn_ShowWMP.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowWMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowWMP.BorderRadius = 0;
            this.btn_ShowWMP.ButtonText = "Media";
            this.btn_ShowWMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowWMP.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ShowWMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowWMP.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ShowWMP.Iconimage = global::MusicPlayer.Properties.Resources.tv_show_100px;
            this.btn_ShowWMP.Iconimage_right = null;
            this.btn_ShowWMP.Iconimage_right_Selected = null;
            this.btn_ShowWMP.Iconimage_Selected = null;
            this.btn_ShowWMP.IconMarginLeft = 0;
            this.btn_ShowWMP.IconMarginRight = 0;
            this.btn_ShowWMP.IconRightVisible = true;
            this.btn_ShowWMP.IconRightZoom = 0D;
            this.btn_ShowWMP.IconVisible = true;
            this.btn_ShowWMP.IconZoom = 90D;
            this.btn_ShowWMP.IsTab = false;
            this.btn_ShowWMP.Location = new System.Drawing.Point(5, 5);
            this.btn_ShowWMP.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ShowWMP.Name = "btn_ShowWMP";
            this.btn_ShowWMP.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_ShowWMP.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_ShowWMP.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_ShowWMP.selected = false;
            this.btn_ShowWMP.Size = new System.Drawing.Size(277, 44);
            this.btn_ShowWMP.TabIndex = 5;
            this.btn_ShowWMP.Text = "Media";
            this.btn_ShowWMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ShowWMP.Textcolor = System.Drawing.Color.White;
            this.btn_ShowWMP.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowWMP.Click += new System.EventHandler(this.btn_ShowWMP_Click);
            // 
            // btn_Casi
            // 
            this.btn_Casi.Activecolor = System.Drawing.Color.Blue;
            this.btn_Casi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Casi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Casi.BorderRadius = 0;
            this.btn_Casi.ButtonText = "Ca sĩ";
            this.btn_Casi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Casi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Casi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Casi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Casi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Casi.Iconimage = global::MusicPlayer.Properties.Resources.edit_user_100px;
            this.btn_Casi.Iconimage_right = null;
            this.btn_Casi.Iconimage_right_Selected = null;
            this.btn_Casi.Iconimage_Selected = null;
            this.btn_Casi.IconMarginLeft = 0;
            this.btn_Casi.IconMarginRight = 0;
            this.btn_Casi.IconRightVisible = true;
            this.btn_Casi.IconRightZoom = 0D;
            this.btn_Casi.IconVisible = true;
            this.btn_Casi.IconZoom = 90D;
            this.btn_Casi.IsTab = false;
            this.btn_Casi.Location = new System.Drawing.Point(5, 113);
            this.btn_Casi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Casi.Name = "btn_Casi";
            this.btn_Casi.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Casi.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Casi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Casi.selected = false;
            this.btn_Casi.Size = new System.Drawing.Size(277, 44);
            this.btn_Casi.TabIndex = 4;
            this.btn_Casi.Text = "Ca sĩ";
            this.btn_Casi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Casi.Textcolor = System.Drawing.Color.White;
            this.btn_Casi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Casi.Click += new System.EventHandler(this.btn_Casi_Click);
            // 
            // btn_PlayList
            // 
            this.btn_PlayList.Activecolor = System.Drawing.Color.Blue;
            this.btn_PlayList.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayList.BorderRadius = 0;
            this.btn_PlayList.ButtonText = "Danh sách";
            this.btn_PlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlayList.DisabledColor = System.Drawing.Color.Gray;
            this.btn_PlayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayList.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_PlayList.Iconimage = global::MusicPlayer.Properties.Resources.checklist_100px;
            this.btn_PlayList.Iconimage_right = null;
            this.btn_PlayList.Iconimage_right_Selected = null;
            this.btn_PlayList.Iconimage_Selected = null;
            this.btn_PlayList.IconMarginLeft = 0;
            this.btn_PlayList.IconMarginRight = 0;
            this.btn_PlayList.IconRightVisible = true;
            this.btn_PlayList.IconRightZoom = 0D;
            this.btn_PlayList.IconVisible = true;
            this.btn_PlayList.IconZoom = 90D;
            this.btn_PlayList.IsTab = false;
            this.btn_PlayList.Location = new System.Drawing.Point(5, 167);
            this.btn_PlayList.Margin = new System.Windows.Forms.Padding(5);
            this.btn_PlayList.Name = "btn_PlayList";
            this.btn_PlayList.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_PlayList.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_PlayList.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_PlayList.selected = false;
            this.btn_PlayList.Size = new System.Drawing.Size(277, 44);
            this.btn_PlayList.TabIndex = 0;
            this.btn_PlayList.Text = "Danh sách";
            this.btn_PlayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PlayList.Textcolor = System.Drawing.Color.White;
            this.btn_PlayList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayList.Click += new System.EventHandler(this.btn_PlayList_Click);
            // 
            // btn_NowPlay
            // 
            this.btn_NowPlay.Activecolor = System.Drawing.Color.Blue;
            this.btn_NowPlay.BackColor = System.Drawing.Color.Transparent;
            this.btn_NowPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NowPlay.BorderRadius = 0;
            this.btn_NowPlay.ButtonText = "Đang phát";
            this.btn_NowPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NowPlay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_NowPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NowPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NowPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_NowPlay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_NowPlay.Iconimage")));
            this.btn_NowPlay.Iconimage_right = null;
            this.btn_NowPlay.Iconimage_right_Selected = null;
            this.btn_NowPlay.Iconimage_Selected = null;
            this.btn_NowPlay.IconMarginLeft = 0;
            this.btn_NowPlay.IconMarginRight = 0;
            this.btn_NowPlay.IconRightVisible = true;
            this.btn_NowPlay.IconRightZoom = 0D;
            this.btn_NowPlay.IconVisible = true;
            this.btn_NowPlay.IconZoom = 90D;
            this.btn_NowPlay.IsTab = false;
            this.btn_NowPlay.Location = new System.Drawing.Point(5, 221);
            this.btn_NowPlay.Margin = new System.Windows.Forms.Padding(5);
            this.btn_NowPlay.Name = "btn_NowPlay";
            this.btn_NowPlay.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_NowPlay.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_NowPlay.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_NowPlay.selected = false;
            this.btn_NowPlay.Size = new System.Drawing.Size(277, 44);
            this.btn_NowPlay.TabIndex = 1;
            this.btn_NowPlay.Text = "Đang phát";
            this.btn_NowPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NowPlay.Textcolor = System.Drawing.Color.White;
            this.btn_NowPlay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NowPlay.Click += new System.EventHandler(this.btn_NowPlay_Click);
            // 
            // btn_Browser
            // 
            this.btn_Browser.Activecolor = System.Drawing.Color.Blue;
            this.btn_Browser.BackColor = System.Drawing.Color.Transparent;
            this.btn_Browser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Browser.BorderRadius = 0;
            this.btn_Browser.ButtonText = "Thư mục";
            this.btn_Browser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Browser.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Browser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browser.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Browser.Iconimage = global::MusicPlayer.Properties.Resources.folder_100px;
            this.btn_Browser.Iconimage_right = null;
            this.btn_Browser.Iconimage_right_Selected = null;
            this.btn_Browser.Iconimage_Selected = null;
            this.btn_Browser.IconMarginLeft = 0;
            this.btn_Browser.IconMarginRight = 0;
            this.btn_Browser.IconRightVisible = true;
            this.btn_Browser.IconRightZoom = 0D;
            this.btn_Browser.IconVisible = true;
            this.btn_Browser.IconZoom = 90D;
            this.btn_Browser.IsTab = false;
            this.btn_Browser.Location = new System.Drawing.Point(5, 275);
            this.btn_Browser.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Browser.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Browser.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Browser.selected = false;
            this.btn_Browser.Size = new System.Drawing.Size(277, 58);
            this.btn_Browser.TabIndex = 2;
            this.btn_Browser.Text = "Thư mục";
            this.btn_Browser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Browser.Textcolor = System.Drawing.Color.White;
            this.btn_Browser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // btn_BaiHat
            // 
            this.btn_BaiHat.Activecolor = System.Drawing.Color.Blue;
            this.btn_BaiHat.BackColor = System.Drawing.Color.Transparent;
            this.btn_BaiHat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BaiHat.BorderRadius = 0;
            this.btn_BaiHat.ButtonText = "Bài hát";
            this.btn_BaiHat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BaiHat.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaiHat.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BaiHat.Iconimage = global::MusicPlayer.Properties.Resources.music_folder_100px;
            this.btn_BaiHat.Iconimage_right = null;
            this.btn_BaiHat.Iconimage_right_Selected = null;
            this.btn_BaiHat.Iconimage_Selected = null;
            this.btn_BaiHat.IconMarginLeft = 0;
            this.btn_BaiHat.IconMarginRight = 0;
            this.btn_BaiHat.IconRightVisible = true;
            this.btn_BaiHat.IconRightZoom = 0D;
            this.btn_BaiHat.IconVisible = true;
            this.btn_BaiHat.IconZoom = 90D;
            this.btn_BaiHat.IsTab = false;
            this.btn_BaiHat.Location = new System.Drawing.Point(5, 59);
            this.btn_BaiHat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BaiHat.Name = "btn_BaiHat";
            this.btn_BaiHat.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_BaiHat.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_BaiHat.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_BaiHat.selected = false;
            this.btn_BaiHat.Size = new System.Drawing.Size(277, 44);
            this.btn_BaiHat.TabIndex = 3;
            this.btn_BaiHat.Text = "Bài hát";
            this.btn_BaiHat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BaiHat.Textcolor = System.Drawing.Color.White;
            this.btn_BaiHat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaiHat.Click += new System.EventHandler(this.btn_BaiHat_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Min, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Max, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Close, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(287, 53);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btn_Min
            // 
            this.btn_Min.BackColor = System.Drawing.Color.Transparent;
            this.btn_Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Min.Image = global::MusicPlayer.Properties.Resources.minimize_window_100px;
            this.btn_Min.ImageActive = null;
            this.btn_Min.Location = new System.Drawing.Point(3, 2);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(88, 49);
            this.btn_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Min.TabIndex = 0;
            this.btn_Min.TabStop = false;
            this.btn_Min.Zoom = 10;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.BackColor = System.Drawing.Color.Transparent;
            this.btn_Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Max.Image = global::MusicPlayer.Properties.Resources.maximize_window_100px;
            this.btn_Max.ImageActive = null;
            this.btn_Max.Location = new System.Drawing.Point(97, 2);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(91, 49);
            this.btn_Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Max.TabIndex = 1;
            this.btn_Max.TabStop = false;
            this.btn_Max.Zoom = 10;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.Image = global::MusicPlayer.Properties.Resources.close_window_100px;
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(194, 2);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 49);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 2;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbPLaylist.ResumeLayout(false);
            this.gbPLaylist.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_main)).EndInit();
            this.gbBaihat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiHat)).EndInit();
            this.gbCaSi.ResumeLayout(false);
            this.gbCaSi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaSi)).EndInit();
            this.menuBaiHat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Action)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBtnRanDom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop_song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IgmBtnRepeat)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back_Song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AmLuong)).EndInit();
            this.pn_menu.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuGradientPanel pn_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_PlayList;
        private Bunifu.Framework.UI.BunifuFlatButton btn_NowPlay;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Browser;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Bunifu.Framework.UI.BunifuImageButton btn_Min;
        private Bunifu.Framework.UI.BunifuImageButton btn_Max;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private Bunifu.Framework.UI.BunifuProgressBar PB_Timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_time_start;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_time_end;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Name_Song;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AmLuong;
        private Bunifu.Framework.UI.BunifuImageButton btn_AmLuong;
        private Bunifu.Framework.UI.BunifuImageButton btn_Action;
        private Bunifu.Framework.UI.BunifuImageButton btn_back_Song;
        private Bunifu.Framework.UI.BunifuImageButton btn_next_song;
        private Bunifu.Framework.UI.BunifuImageButton ImgBtnRanDom;
        private Bunifu.Framework.UI.BunifuImageButton btn_Stop_song;
        private Bunifu.Framework.UI.BunifuImageButton IgmBtnRepeat;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWMP_main;
        private System.Windows.Forms.ListBox lbox_ListNhac;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton play;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton pause;
        private System.Windows.Forms.Timer time_song;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Casi;
        private System.Windows.Forms.GroupBox gbCaSi;
        private System.Windows.Forms.GroupBox gbPLaylist;
        private System.Windows.Forms.GroupBox gbBaihat;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBaiHat;
        private System.Windows.Forms.ComboBox cboPlayList;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPlaylist;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCaSi;
        private System.Windows.Forms.ComboBox cbo_CaSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhatBaiHat;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhatAllBaiHat;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhat_CaSi;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhatAll_CaSi;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhat_PLaylist;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhatAll_PLaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip menuBaiHat;
        private System.Windows.Forms.ToolStripMenuItem thêmTênCaSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmBàiHátVàoPlaylistToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txt_Them_Casi;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Them_baiHatByCaSi;
        private System.Windows.Forms.ComboBox cbo_baiHat_CaSi;
        private System.Windows.Forms.TextBox txt_Them_PL;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Them_Playlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Them_BHinPL;
        private System.Windows.Forms.ComboBox cbo_BaiHat_PL;
        private System.Windows.Forms.Button btn_Them_CaSi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ShowWMP;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BaiHat;
    }
}