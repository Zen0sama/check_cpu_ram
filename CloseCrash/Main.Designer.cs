﻿
namespace CloseCrash
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMain = new ns1.SiticonePanel();
            this.panelForm = new ns1.SiticonePanel();
            this.panelControl = new ns1.SiticonePanel();
            this.tbTimeCleanRam = new ns1.SiticoneTextBox();
            this.siticoneLabel1 = new ns1.SiticoneLabel();
            this.btnCleanRam = new ns1.SiticoneGradientButton();
            this.btnCheckCrash = new ns1.SiticoneGradientButton();
            this.dataGridAcc = new ns1.SiticoneDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTab = new ns1.SiticonePanel();
            this.gbClean = new ns1.SiticoneGroupBox();
            this.lbTimeClean = new System.Windows.Forms.Label();
            this.gbCrash = new ns1.SiticoneGroupBox();
            this.lbTabCrash = new ns1.SiticoneLabel();
            this.gbTab = new ns1.SiticoneGroupBox();
            this.lbTabRuning = new ns1.SiticoneLabel();
            this.panelAvatar = new ns1.SiticonePanel();
            this.ptAvatar = new ns1.SiticonePictureBox();
            this.panelStatus = new ns1.SiticonePanel();
            this.prbDisk = new ns1.SiticoneProgressBar();
            this.prbCPU = new ns1.SiticoneProgressBar();
            this.prbRam = new ns1.SiticoneProgressBar();
            this.lbPercentDisk = new ns1.SiticoneLabel();
            this.lbPercentCPU = new ns1.SiticoneLabel();
            this.lbPercentRam = new ns1.SiticoneLabel();
            this.lbDisk = new ns1.SiticoneLabel();
            this.lbCpu = new ns1.SiticoneLabel();
            this.lbRam = new ns1.SiticoneLabel();
            this.btnMiniSize = new ns1.SiticoneButton();
            this.btnCloseApp = new ns1.SiticoneButton();
            this.lbTitle = new ns1.SiticoneLabel();
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.siticoneElipse2 = new ns1.SiticoneElipse(this.components);
            this.siticoneElipse3 = new ns1.SiticoneElipse(this.components);
            this.siticoneElipse4 = new ns1.SiticoneElipse(this.components);
            this.siticoneElipse5 = new ns1.SiticoneElipse(this.components);
            this.siticoneElipse6 = new ns1.SiticoneElipse(this.components);
            this.siticoneElipse7 = new ns1.SiticoneElipse(this.components);
            this.siticoneDragControl1 = new ns1.SiticoneDragControl(this.components);
            this.timerComputed = new System.Windows.Forms.Timer(this.components);
            this.timerLoadProcess = new System.Windows.Forms.Timer(this.components);
            this.siticoneElipse8 = new ns1.SiticoneElipse(this.components);
            this.timerCleanRam = new System.Windows.Forms.Timer(this.components);
            this.btHelp = new ns1.SiticoneGradientButton();
            this.panelMain.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcc)).BeginInit();
            this.panelTab.SuspendLayout();
            this.gbClean.SuspendLayout();
            this.gbCrash.SuspendLayout();
            this.gbTab.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAvatar)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.btnMiniSize);
            this.panelMain.Controls.Add(this.btnCloseApp);
            this.panelMain.Controls.Add(this.lbTitle);
            this.panelMain.ForeColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Parent = this.panelMain;
            this.panelMain.Size = new System.Drawing.Size(923, 588);
            this.panelMain.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.panelForm.Controls.Add(this.panelControl);
            this.panelForm.Controls.Add(this.dataGridAcc);
            this.panelForm.Controls.Add(this.panelTab);
            this.panelForm.Controls.Add(this.panelAvatar);
            this.panelForm.Controls.Add(this.panelStatus);
            this.panelForm.Location = new System.Drawing.Point(12, 40);
            this.panelForm.Name = "panelForm";
            this.panelForm.ShadowDecoration.Parent = this.panelForm;
            this.panelForm.Size = new System.Drawing.Size(895, 536);
            this.panelForm.TabIndex = 3;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panelControl.Controls.Add(this.btHelp);
            this.panelControl.Controls.Add(this.tbTimeCleanRam);
            this.panelControl.Controls.Add(this.siticoneLabel1);
            this.panelControl.Controls.Add(this.btnCleanRam);
            this.panelControl.Controls.Add(this.btnCheckCrash);
            this.panelControl.Location = new System.Drawing.Point(10, 166);
            this.panelControl.Name = "panelControl";
            this.panelControl.ShadowDecoration.Parent = this.panelControl;
            this.panelControl.Size = new System.Drawing.Size(150, 358);
            this.panelControl.TabIndex = 5;
            // 
            // tbTimeCleanRam
            // 
            this.tbTimeCleanRam.BackColor = System.Drawing.Color.Transparent;
            this.tbTimeCleanRam.BorderColor = System.Drawing.Color.Black;
            this.tbTimeCleanRam.BorderRadius = 5;
            this.tbTimeCleanRam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimeCleanRam.DefaultText = "120";
            this.tbTimeCleanRam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimeCleanRam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimeCleanRam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimeCleanRam.DisabledState.Parent = this.tbTimeCleanRam;
            this.tbTimeCleanRam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimeCleanRam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimeCleanRam.FocusedState.Parent = this.tbTimeCleanRam;
            this.tbTimeCleanRam.ForeColor = System.Drawing.Color.Black;
            this.tbTimeCleanRam.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimeCleanRam.HoveredState.Parent = this.tbTimeCleanRam;
            this.tbTimeCleanRam.Location = new System.Drawing.Point(78, 157);
            this.tbTimeCleanRam.Margin = new System.Windows.Forms.Padding(7);
            this.tbTimeCleanRam.Name = "tbTimeCleanRam";
            this.tbTimeCleanRam.PasswordChar = '\0';
            this.tbTimeCleanRam.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbTimeCleanRam.PlaceholderText = "";
            this.tbTimeCleanRam.SelectedText = "";
            this.tbTimeCleanRam.ShadowDecoration.Parent = this.tbTimeCleanRam;
            this.tbTimeCleanRam.Size = new System.Drawing.Size(62, 45);
            this.tbTimeCleanRam.TabIndex = 4;
            this.tbTimeCleanRam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.AutoSize = false;
            this.siticoneLabel1.AutoSizeHeightOnly = true;
            this.siticoneLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(10, 157);
            this.siticoneLabel1.MinimumSize = new System.Drawing.Size(38, 45);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(62, 45);
            this.siticoneLabel1.TabIndex = 3;
            this.siticoneLabel1.Text = "Delay Clean";
            this.siticoneLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCleanRam
            // 
            this.btnCleanRam.BorderRadius = 5;
            this.btnCleanRam.CheckedState.Parent = this.btnCleanRam;
            this.btnCleanRam.CustomImages.Parent = this.btnCleanRam;
            this.btnCleanRam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.btnCleanRam.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.btnCleanRam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanRam.ForeColor = System.Drawing.Color.White;
            this.btnCleanRam.HoveredState.Parent = this.btnCleanRam;
            this.btnCleanRam.Image = ((System.Drawing.Image)(resources.GetObject("btnCleanRam.Image")));
            this.btnCleanRam.Location = new System.Drawing.Point(10, 93);
            this.btnCleanRam.Name = "btnCleanRam";
            this.btnCleanRam.ShadowDecoration.Parent = this.btnCleanRam;
            this.btnCleanRam.Size = new System.Drawing.Size(130, 45);
            this.btnCleanRam.TabIndex = 1;
            this.btnCleanRam.Text = "CLEAN RAM";
            this.btnCleanRam.Click += new System.EventHandler(this.btnCleanRam_Click);
            // 
            // btnCheckCrash
            // 
            this.btnCheckCrash.BorderRadius = 5;
            this.btnCheckCrash.CheckedState.Parent = this.btnCheckCrash;
            this.btnCheckCrash.CustomImages.Parent = this.btnCheckCrash;
            this.btnCheckCrash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.btnCheckCrash.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.btnCheckCrash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCrash.ForeColor = System.Drawing.Color.White;
            this.btnCheckCrash.HoveredState.Parent = this.btnCheckCrash;
            this.btnCheckCrash.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckCrash.Image")));
            this.btnCheckCrash.Location = new System.Drawing.Point(10, 28);
            this.btnCheckCrash.Name = "btnCheckCrash";
            this.btnCheckCrash.ShadowDecoration.Parent = this.btnCheckCrash;
            this.btnCheckCrash.Size = new System.Drawing.Size(130, 45);
            this.btnCheckCrash.TabIndex = 0;
            this.btnCheckCrash.Text = "CHECK CRASH";
            this.btnCheckCrash.Click += new System.EventHandler(this.btnCheckCrash_Click);
            // 
            // dataGridAcc
            // 
            this.dataGridAcc.AllowUserToAddRows = false;
            this.dataGridAcc.AllowUserToDeleteRows = false;
            this.dataGridAcc.AllowUserToResizeColumns = false;
            this.dataGridAcc.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataGridAcc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAcc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.dataGridAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridAcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridAcc.ColumnHeadersHeight = 25;
            this.dataGridAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.subname,
            this.ram,
            this.pid});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAcc.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridAcc.EnableHeadersVisualStyles = false;
            this.dataGridAcc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridAcc.Location = new System.Drawing.Point(166, 166);
            this.dataGridAcc.MultiSelect = false;
            this.dataGridAcc.Name = "dataGridAcc";
            this.dataGridAcc.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAcc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridAcc.RowHeadersVisible = false;
            this.dataGridAcc.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAcc.RowTemplate.Height = 25;
            this.dataGridAcc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAcc.Size = new System.Drawing.Size(717, 358);
            this.dataGridAcc.TabIndex = 4;
            this.dataGridAcc.Theme = ns5.DataGridViewPresetThemes.Dark;
            this.dataGridAcc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataGridAcc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridAcc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridAcc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridAcc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridAcc.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.dataGridAcc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridAcc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataGridAcc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAcc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAcc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridAcc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAcc.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridAcc.ThemeStyle.ReadOnly = true;
            this.dataGridAcc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataGridAcc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridAcc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAcc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridAcc.ThemeStyle.RowsStyle.Height = 25;
            this.dataGridAcc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataGridAcc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // id
            // 
            this.id.FillWeight = 50.76143F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 128.9436F;
            this.name.HeaderText = "Process Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // subname
            // 
            this.subname.FillWeight = 95.67568F;
            this.subname.HeaderText = "Main Title";
            this.subname.Name = "subname";
            this.subname.ReadOnly = true;
            // 
            // ram
            // 
            this.ram.FillWeight = 128.9436F;
            this.ram.HeaderText = "Ram";
            this.ram.Name = "ram";
            this.ram.ReadOnly = true;
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.FillWeight = 95.67568F;
            this.pid.HeaderText = "PID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panelTab.Controls.Add(this.gbClean);
            this.panelTab.Controls.Add(this.gbCrash);
            this.panelTab.Controls.Add(this.gbTab);
            this.panelTab.Location = new System.Drawing.Point(166, 10);
            this.panelTab.Name = "panelTab";
            this.panelTab.ShadowDecoration.Parent = this.panelTab;
            this.panelTab.Size = new System.Drawing.Size(307, 150);
            this.panelTab.TabIndex = 2;
            // 
            // gbClean
            // 
            this.gbClean.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.gbClean.BorderRadius = 10;
            this.gbClean.Controls.Add(this.lbTimeClean);
            this.gbClean.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.gbClean.FillColor = System.Drawing.Color.Transparent;
            this.gbClean.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClean.ForeColor = System.Drawing.Color.White;
            this.gbClean.Location = new System.Drawing.Point(205, 10);
            this.gbClean.Name = "gbClean";
            this.gbClean.ShadowDecoration.Parent = this.gbClean;
            this.gbClean.Size = new System.Drawing.Size(91, 130);
            this.gbClean.TabIndex = 1;
            this.gbClean.Text = "CLEAN:";
            this.gbClean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTimeClean
            // 
            this.lbTimeClean.AutoSize = true;
            this.lbTimeClean.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTimeClean.Location = new System.Drawing.Point(18, 64);
            this.lbTimeClean.Margin = new System.Windows.Forms.Padding(0);
            this.lbTimeClean.MinimumSize = new System.Drawing.Size(60, 37);
            this.lbTimeClean.Name = "lbTimeClean";
            this.lbTimeClean.Size = new System.Drawing.Size(60, 37);
            this.lbTimeClean.TabIndex = 0;
            this.lbTimeClean.Text = "--";
            this.lbTimeClean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCrash
            // 
            this.gbCrash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.gbCrash.BorderRadius = 10;
            this.gbCrash.Controls.Add(this.lbTabCrash);
            this.gbCrash.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.gbCrash.FillColor = System.Drawing.Color.Transparent;
            this.gbCrash.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrash.ForeColor = System.Drawing.Color.White;
            this.gbCrash.Location = new System.Drawing.Point(107, 10);
            this.gbCrash.Name = "gbCrash";
            this.gbCrash.ShadowDecoration.Parent = this.gbCrash;
            this.gbCrash.Size = new System.Drawing.Size(91, 130);
            this.gbCrash.TabIndex = 1;
            this.gbCrash.Text = "CRASH:";
            this.gbCrash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTabCrash
            // 
            this.lbTabCrash.BackColor = System.Drawing.Color.Transparent;
            this.lbTabCrash.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabCrash.Location = new System.Drawing.Point(34, 62);
            this.lbTabCrash.Name = "lbTabCrash";
            this.lbTabCrash.Size = new System.Drawing.Size(25, 39);
            this.lbTabCrash.TabIndex = 1;
            this.lbTabCrash.Text = "--";
            this.lbTabCrash.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTab
            // 
            this.gbTab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.gbTab.BorderRadius = 10;
            this.gbTab.Controls.Add(this.lbTabRuning);
            this.gbTab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.gbTab.FillColor = System.Drawing.Color.Transparent;
            this.gbTab.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTab.ForeColor = System.Drawing.Color.White;
            this.gbTab.Location = new System.Drawing.Point(10, 10);
            this.gbTab.Name = "gbTab";
            this.gbTab.ShadowDecoration.Parent = this.gbTab;
            this.gbTab.Size = new System.Drawing.Size(91, 130);
            this.gbTab.TabIndex = 0;
            this.gbTab.Text = "TAB:";
            this.gbTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTabRuning
            // 
            this.lbTabRuning.BackColor = System.Drawing.Color.Transparent;
            this.lbTabRuning.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabRuning.Location = new System.Drawing.Point(27, 62);
            this.lbTabRuning.MinimumSize = new System.Drawing.Size(35, 39);
            this.lbTabRuning.Name = "lbTabRuning";
            this.lbTabRuning.Size = new System.Drawing.Size(35, 39);
            this.lbTabRuning.TabIndex = 0;
            this.lbTabRuning.Text = "--";
            this.lbTabRuning.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panelAvatar.Controls.Add(this.ptAvatar);
            this.panelAvatar.Location = new System.Drawing.Point(10, 10);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.ShadowDecoration.Parent = this.panelAvatar;
            this.panelAvatar.Size = new System.Drawing.Size(150, 150);
            this.panelAvatar.TabIndex = 1;
            // 
            // ptAvatar
            // 
            this.ptAvatar.BorderRadius = 60;
            this.ptAvatar.Image = ((System.Drawing.Image)(resources.GetObject("ptAvatar.Image")));
            this.ptAvatar.Location = new System.Drawing.Point(10, 10);
            this.ptAvatar.Name = "ptAvatar";
            this.ptAvatar.ShadowDecoration.Parent = this.ptAvatar;
            this.ptAvatar.Size = new System.Drawing.Size(130, 130);
            this.ptAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAvatar.TabIndex = 0;
            this.ptAvatar.TabStop = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panelStatus.Controls.Add(this.prbDisk);
            this.panelStatus.Controls.Add(this.prbCPU);
            this.panelStatus.Controls.Add(this.prbRam);
            this.panelStatus.Controls.Add(this.lbPercentDisk);
            this.panelStatus.Controls.Add(this.lbPercentCPU);
            this.panelStatus.Controls.Add(this.lbPercentRam);
            this.panelStatus.Controls.Add(this.lbDisk);
            this.panelStatus.Controls.Add(this.lbCpu);
            this.panelStatus.Controls.Add(this.lbRam);
            this.panelStatus.Location = new System.Drawing.Point(479, 10);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.ShadowDecoration.Parent = this.panelStatus;
            this.panelStatus.Size = new System.Drawing.Size(404, 150);
            this.panelStatus.TabIndex = 0;
            // 
            // prbDisk
            // 
            this.prbDisk.BorderRadius = 2;
            this.prbDisk.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.prbDisk.Location = new System.Drawing.Point(67, 118);
            this.prbDisk.Name = "prbDisk";
            this.prbDisk.ProgressColor2 = System.Drawing.Color.Red;
            this.prbDisk.ShadowDecoration.Parent = this.prbDisk;
            this.prbDisk.Size = new System.Drawing.Size(280, 11);
            this.prbDisk.TabIndex = 13;
            this.prbDisk.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // prbCPU
            // 
            this.prbCPU.BorderRadius = 2;
            this.prbCPU.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.prbCPU.Location = new System.Drawing.Point(67, 71);
            this.prbCPU.Name = "prbCPU";
            this.prbCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.prbCPU.ProgressColor2 = System.Drawing.Color.Red;
            this.prbCPU.ShadowDecoration.Parent = this.prbCPU;
            this.prbCPU.Size = new System.Drawing.Size(280, 11);
            this.prbCPU.TabIndex = 12;
            this.prbCPU.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // prbRam
            // 
            this.prbRam.BorderRadius = 2;
            this.prbRam.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.prbRam.Location = new System.Drawing.Point(67, 20);
            this.prbRam.Name = "prbRam";
            this.prbRam.ProgressColor = System.Drawing.Color.Yellow;
            this.prbRam.ProgressColor2 = System.Drawing.Color.Red;
            this.prbRam.ShadowDecoration.Parent = this.prbRam;
            this.prbRam.Size = new System.Drawing.Size(280, 11);
            this.prbRam.TabIndex = 11;
            this.prbRam.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lbPercentDisk
            // 
            this.lbPercentDisk.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentDisk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentDisk.Location = new System.Drawing.Point(356, 113);
            this.lbPercentDisk.Name = "lbPercentDisk";
            this.lbPercentDisk.Size = new System.Drawing.Size(33, 19);
            this.lbPercentDisk.TabIndex = 10;
            this.lbPercentDisk.Text = "100%";
            // 
            // lbPercentCPU
            // 
            this.lbPercentCPU.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentCPU.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentCPU.Location = new System.Drawing.Point(356, 65);
            this.lbPercentCPU.Name = "lbPercentCPU";
            this.lbPercentCPU.Size = new System.Drawing.Size(33, 19);
            this.lbPercentCPU.TabIndex = 9;
            this.lbPercentCPU.Text = "100%";
            // 
            // lbPercentRam
            // 
            this.lbPercentRam.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentRam.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentRam.Location = new System.Drawing.Point(356, 14);
            this.lbPercentRam.Name = "lbPercentRam";
            this.lbPercentRam.Size = new System.Drawing.Size(33, 19);
            this.lbPercentRam.TabIndex = 8;
            this.lbPercentRam.Text = "100%";
            // 
            // lbDisk
            // 
            this.lbDisk.BackColor = System.Drawing.Color.Transparent;
            this.lbDisk.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisk.ForeColor = System.Drawing.Color.Lime;
            this.lbDisk.Location = new System.Drawing.Point(10, 109);
            this.lbDisk.Name = "lbDisk";
            this.lbDisk.Size = new System.Drawing.Size(50, 27);
            this.lbDisk.TabIndex = 7;
            this.lbDisk.Text = "DISK:";
            // 
            // lbCpu
            // 
            this.lbCpu.BackColor = System.Drawing.Color.Transparent;
            this.lbCpu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpu.ForeColor = System.Drawing.Color.Aqua;
            this.lbCpu.Location = new System.Drawing.Point(10, 61);
            this.lbCpu.Name = "lbCpu";
            this.lbCpu.Size = new System.Drawing.Size(44, 27);
            this.lbCpu.TabIndex = 5;
            this.lbCpu.Text = "CPU:";
            // 
            // lbRam
            // 
            this.lbRam.BackColor = System.Drawing.Color.Transparent;
            this.lbRam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRam.ForeColor = System.Drawing.Color.Yellow;
            this.lbRam.Location = new System.Drawing.Point(10, 10);
            this.lbRam.Name = "lbRam";
            this.lbRam.Size = new System.Drawing.Size(51, 27);
            this.lbRam.TabIndex = 3;
            this.lbRam.Text = "RAM: ";
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.BorderColor = System.Drawing.Color.White;
            this.btnMiniSize.BorderRadius = 5;
            this.btnMiniSize.BorderThickness = 2;
            this.btnMiniSize.CheckedState.Parent = this.btnMiniSize;
            this.btnMiniSize.CustomImages.Parent = this.btnMiniSize;
            this.btnMiniSize.FillColor = System.Drawing.Color.Transparent;
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniSize.ForeColor = System.Drawing.Color.White;
            this.btnMiniSize.HoveredState.Parent = this.btnMiniSize;
            this.btnMiniSize.Location = new System.Drawing.Point(840, 4);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.ShadowDecoration.Parent = this.btnMiniSize;
            this.btnMiniSize.Size = new System.Drawing.Size(30, 30);
            this.btnMiniSize.TabIndex = 2;
            this.btnMiniSize.Text = "-";
            this.btnMiniSize.Click += new System.EventHandler(this.btnMiniSize_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BorderColor = System.Drawing.Color.White;
            this.btnCloseApp.BorderRadius = 5;
            this.btnCloseApp.BorderThickness = 2;
            this.btnCloseApp.CheckedState.Parent = this.btnCloseApp;
            this.btnCloseApp.CustomImages.Parent = this.btnCloseApp;
            this.btnCloseApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.HoveredState.Parent = this.btnCloseApp;
            this.btnCloseApp.Location = new System.Drawing.Point(876, 4);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.ShadowDecoration.Parent = this.btnCloseApp;
            this.btnCloseApp.Size = new System.Drawing.Size(30, 30);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Zilla Slab SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(416, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tool Clean Ram & Close Crash - Tool.Wibu247.Net";
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 30;
            this.siticoneElipse2.TargetControl = this.panelForm;
            // 
            // siticoneElipse3
            // 
            this.siticoneElipse3.BorderRadius = 30;
            this.siticoneElipse3.TargetControl = this.panelStatus;
            // 
            // siticoneElipse4
            // 
            this.siticoneElipse4.BorderRadius = 30;
            this.siticoneElipse4.TargetControl = this.panelAvatar;
            // 
            // siticoneElipse5
            // 
            this.siticoneElipse5.BorderRadius = 30;
            this.siticoneElipse5.TargetControl = this.panelTab;
            // 
            // siticoneElipse6
            // 
            this.siticoneElipse6.BorderRadius = 30;
            this.siticoneElipse6.TargetControl = this.dataGridAcc;
            // 
            // siticoneElipse7
            // 
            this.siticoneElipse7.BorderRadius = 30;
            this.siticoneElipse7.TargetControl = this.panelControl;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panelMain;
            // 
            // timerComputed
            // 
            this.timerComputed.Interval = 2000;
            this.timerComputed.Tick += new System.EventHandler(this.timerComputed_Tick);
            // 
            // timerLoadProcess
            // 
            this.timerLoadProcess.Interval = 2000;
            this.timerLoadProcess.Tick += new System.EventHandler(this.timerLoadProcess_Tick);
            // 
            // siticoneElipse8
            // 
            this.siticoneElipse8.BorderRadius = 5;
            this.siticoneElipse8.TargetControl = this.siticoneLabel1;
            // 
            // timerCleanRam
            // 
            this.timerCleanRam.Interval = 1000;
            this.timerCleanRam.Tick += new System.EventHandler(this.timerCleanRam_Tick);
            // 
            // btHelp
            // 
            this.btHelp.BorderRadius = 5;
            this.btHelp.CheckedState.Parent = this.btHelp;
            this.btHelp.CustomImages.Parent = this.btHelp;
            this.btHelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.btHelp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.btHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.ForeColor = System.Drawing.Color.White;
            this.btHelp.HoveredState.Parent = this.btHelp;
            this.btHelp.Image = ((System.Drawing.Image)(resources.GetObject("btHelp.Image")));
            this.btHelp.Location = new System.Drawing.Point(10, 221);
            this.btHelp.Name = "btHelp";
            this.btHelp.ShadowDecoration.Parent = this.btHelp;
            this.btHelp.Size = new System.Drawing.Size(130, 45);
            this.btHelp.TabIndex = 5;
            this.btHelp.Text = "HƯỚNG DẪN";
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 588);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool.Wibu247.Net";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcc)).EndInit();
            this.panelTab.ResumeLayout(false);
            this.gbClean.ResumeLayout(false);
            this.gbClean.PerformLayout();
            this.gbCrash.ResumeLayout(false);
            this.gbCrash.PerformLayout();
            this.gbTab.ResumeLayout(false);
            this.gbTab.PerformLayout();
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptAvatar)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticonePanel panelMain;
        private ns1.SiticoneButton btnMiniSize;
        private ns1.SiticoneButton btnCloseApp;
        private ns1.SiticoneLabel lbTitle;
        private ns1.SiticoneElipse siticoneElipse1;
        private ns1.SiticonePanel panelForm;
        private ns1.SiticoneElipse siticoneElipse2;
        private ns1.SiticonePanel panelStatus;
        private ns1.SiticoneElipse siticoneElipse3;
        private ns1.SiticonePanel panelTab;
        private ns1.SiticonePanel panelAvatar;
        private ns1.SiticoneElipse siticoneElipse4;
        private ns1.SiticoneElipse siticoneElipse5;
        private ns1.SiticonePictureBox ptAvatar;
        private ns1.SiticoneElipse siticoneElipse6;
        private ns1.SiticoneLabel lbRam;
        private ns1.SiticoneLabel lbPercentRam;
        private ns1.SiticoneLabel lbDisk;
        private ns1.SiticoneLabel lbCpu;
        private ns1.SiticoneLabel lbPercentDisk;
        private ns1.SiticoneLabel lbPercentCPU;
        private ns1.SiticoneGroupBox gbClean;
        private ns1.SiticoneGroupBox gbCrash;
        private ns1.SiticoneLabel lbTabCrash;
        private ns1.SiticoneGroupBox gbTab;
        private ns1.SiticoneLabel lbTabRuning;
        private ns1.SiticoneDataGridView dataGridAcc;
        private ns1.SiticonePanel panelControl;
        private ns1.SiticoneElipse siticoneElipse7;
        private ns1.SiticoneGradientButton btnCleanRam;
        private ns1.SiticoneGradientButton btnCheckCrash;
        private ns1.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Timer timerComputed;
        private ns1.SiticoneProgressBar prbDisk;
        private ns1.SiticoneProgressBar prbCPU;
        private ns1.SiticoneProgressBar prbRam;
        private System.Windows.Forms.Timer timerLoadProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private ns1.SiticoneLabel siticoneLabel1;
        private ns1.SiticoneElipse siticoneElipse8;
        private ns1.SiticoneTextBox tbTimeCleanRam;
        private System.Windows.Forms.Timer timerCleanRam;
        private System.Windows.Forms.Label lbTimeClean;
        private ns1.SiticoneGradientButton btHelp;
    }
}

