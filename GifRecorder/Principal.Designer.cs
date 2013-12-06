﻿using System.Runtime.Versioning;
using ScreenToGif.Properties;

namespace ScreenToGif
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelTransparent = new System.Windows.Forms.Panel();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.cbModernStyle = new System.Windows.Forms.CheckBox();
            this.comboStartPauseKey = new System.Windows.Forms.ComboBox();
            this.comboStopKey = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSaveDirectly = new System.Windows.Forms.CheckBox();
            this.cbAllowEdit = new System.Windows.Forms.CheckBox();
            this.labelQuickSettings = new System.Windows.Forms.Label();
            this.cbShowCursor = new System.Windows.Forms.CheckBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnUndoOne = new System.Windows.Forms.Button();
            this.btnUndoAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDeleteFrame = new System.Windows.Forms.Button();
            this.pictureBitmap = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nenuDeleteAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.timerCapture = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timerPreStart = new System.Windows.Forms.Timer(this.components);
            this.timerCursor = new System.Windows.Forms.Timer(this.components);
            this.panelGifConfig = new System.Windows.Forms.Panel();
            this.labelQuality = new System.Windows.Forms.Label();
            this.cbLoop = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRecordPause = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numMaxFps = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnGifConfig = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.timerCapWithCursor = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelConfig.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBitmap)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panelGifConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.flowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxFps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTransparent
            // 
            this.panelTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTransparent.BackColor = System.Drawing.Color.LimeGreen;
            this.panelTransparent.Location = new System.Drawing.Point(0, 0);
            this.panelTransparent.Name = "panelTransparent";
            this.panelTransparent.Size = new System.Drawing.Size(532, 247);
            this.panelTransparent.TabIndex = 1;
            // 
            // panelConfig
            // 
            this.panelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelConfig.Controls.Add(this.cbModernStyle);
            this.panelConfig.Controls.Add(this.comboStartPauseKey);
            this.panelConfig.Controls.Add(this.comboStopKey);
            this.panelConfig.Controls.Add(this.label4);
            this.panelConfig.Controls.Add(this.label3);
            this.panelConfig.Controls.Add(this.label2);
            this.panelConfig.Controls.Add(this.cbSaveDirectly);
            this.panelConfig.Controls.Add(this.cbAllowEdit);
            this.panelConfig.Controls.Add(this.labelQuickSettings);
            this.panelConfig.Controls.Add(this.cbShowCursor);
            this.panelConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelConfig.Location = new System.Drawing.Point(0, 0);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(532, 247);
            this.panelConfig.TabIndex = 1;
            this.panelConfig.Visible = false;
            // 
            // cbModernStyle
            // 
            this.cbModernStyle.AutoSize = true;
            this.cbModernStyle.Location = new System.Drawing.Point(12, 100);
            this.cbModernStyle.Name = "cbModernStyle";
            this.cbModernStyle.Size = new System.Drawing.Size(337, 19);
            this.cbModernStyle.TabIndex = 14;
            this.cbModernStyle.Text = global::ScreenToGif.Properties.Resources.CB_ModernStyle;
            this.cbModernStyle.UseVisualStyleBackColor = true;
            // 
            // comboStartPauseKey
            // 
            this.comboStartPauseKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboStartPauseKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStartPauseKey.FormattingEnabled = true;
            this.comboStartPauseKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboStartPauseKey.Location = new System.Drawing.Point(459, 181);
            this.comboStartPauseKey.Name = "comboStartPauseKey";
            this.comboStartPauseKey.Size = new System.Drawing.Size(61, 23);
            this.comboStartPauseKey.TabIndex = 13;
            this.comboStartPauseKey.SelectedIndexChanged += new System.EventHandler(this.comboStartPauseKey_SelectedIndexChanged);
            // 
            // comboStopKey
            // 
            this.comboStopKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboStopKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStopKey.FormattingEnabled = true;
            this.comboStopKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboStopKey.Location = new System.Drawing.Point(459, 211);
            this.comboStopKey.Name = "comboStopKey";
            this.comboStopKey.Size = new System.Drawing.Size(61, 23);
            this.comboStopKey.TabIndex = 12;
            this.comboStopKey.SelectedIndexChanged += new System.EventHandler(this.comboStopKey_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = Resources.Label_Hotkeys;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = Resources.Label_Stop;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = Resources.Label_RecordPause;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSaveDirectly
            // 
            this.cbSaveDirectly.AutoSize = true;
            this.cbSaveDirectly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSaveDirectly.Location = new System.Drawing.Point(12, 75);
            this.cbSaveDirectly.Name = "cbSaveDirectly";
            this.cbSaveDirectly.Size = new System.Drawing.Size(215, 19);
            this.cbSaveDirectly.TabIndex = 5;
            this.cbSaveDirectly.Text = global::ScreenToGif.Properties.Resources.CB_SaveDesktop;
            this.cbSaveDirectly.UseVisualStyleBackColor = true;
            // 
            // cbAllowEdit
            // 
            this.cbAllowEdit.AutoSize = true;
            this.cbAllowEdit.Checked = true;
            this.cbAllowEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllowEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbAllowEdit.Location = new System.Drawing.Point(12, 50);
            this.cbAllowEdit.Name = "cbAllowEdit";
            this.cbAllowEdit.Size = new System.Drawing.Size(244, 19);
            this.cbAllowEdit.TabIndex = 2;
            this.cbAllowEdit.Text = global::ScreenToGif.Properties.Resources.CB_AllowEdit;
            this.cbAllowEdit.UseVisualStyleBackColor = true;
            // 
            // labelQuickSettings
            // 
            this.labelQuickSettings.AutoSize = true;
            this.labelQuickSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelQuickSettings.Location = new System.Drawing.Point(3, 9);
            this.labelQuickSettings.Name = "labelQuickSettings";
            this.labelQuickSettings.Size = new System.Drawing.Size(246, 15);
            this.labelQuickSettings.TabIndex = 1;
            this.labelQuickSettings.Text = Resources.Label_Title_AppSettings;
            // 
            // cbShowCursor
            // 
            this.cbShowCursor.AutoSize = true;
            this.cbShowCursor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbShowCursor.Location = new System.Drawing.Point(12, 27);
            this.cbShowCursor.Name = "cbShowCursor";
            this.cbShowCursor.Size = new System.Drawing.Size(103, 19);
            this.cbShowCursor.TabIndex = 0;
            this.cbShowCursor.Text = global::ScreenToGif.Properties.Resources.CB_ShowCursor;
            this.cbShowCursor.UseVisualStyleBackColor = true;
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelEdit.Controls.Add(this.btnUndoOne);
            this.panelEdit.Controls.Add(this.btnUndoAll);
            this.panelEdit.Controls.Add(this.btnCancel);
            this.panelEdit.Controls.Add(this.btnDone);
            this.panelEdit.Controls.Add(this.btnDeleteFrame);
            this.panelEdit.Controls.Add(this.pictureBitmap);
            this.panelEdit.Controls.Add(this.trackBar);
            this.panelEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelEdit.Location = new System.Drawing.Point(0, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(532, 247);
            this.panelEdit.TabIndex = 15;
            this.panelEdit.Visible = false;
            // 
            // btnUndoOne
            // 
            this.btnUndoOne.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUndoOne.AutoSize = true;
            this.btnUndoOne.Location = new System.Drawing.Point(143, 208);
            this.btnUndoOne.Name = "btnUndoOne";
            this.btnUndoOne.Size = new System.Drawing.Size(75, 25);
            this.btnUndoOne.TabIndex = 17;
            this.btnUndoOne.Text = global::ScreenToGif.Properties.Resources.btnUndoOne;
            this.btnUndoOne.UseVisualStyleBackColor = true;
            this.btnUndoOne.Click += new System.EventHandler(this.btnUndoOne_Click);
            // 
            // btnUndoAll
            // 
            this.btnUndoAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUndoAll.AutoSize = true;
            this.btnUndoAll.Location = new System.Drawing.Point(45, 208);
            this.btnUndoAll.Name = "btnUndoAll";
            this.btnUndoAll.Size = new System.Drawing.Size(93, 25);
            this.btnUndoAll.TabIndex = 16;
            this.btnUndoAll.Text = global::ScreenToGif.Properties.Resources.btnUndoAll;
            this.btnUndoAll.UseVisualStyleBackColor = true;
            this.btnUndoAll.Click += new System.EventHandler(this.btnUndoAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(417, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = global::ScreenToGif.Properties.Resources.btnCancel;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDone.AutoSize = true;
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(328, 208);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(83, 25);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = global::ScreenToGif.Properties.Resources.btnDone;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDeleteFrame
            // 
            this.btnDeleteFrame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteFrame.AutoSize = true;
            this.btnDeleteFrame.Location = new System.Drawing.Point(224, 208);
            this.btnDeleteFrame.Name = "btnDeleteFrame";
            this.btnDeleteFrame.Size = new System.Drawing.Size(98, 25);
            this.btnDeleteFrame.TabIndex = 13;
            this.btnDeleteFrame.Text = global::ScreenToGif.Properties.Resources.btnDeleteFrame;
            this.btnDeleteFrame.UseVisualStyleBackColor = true;
            this.btnDeleteFrame.Click += new System.EventHandler(this.btnDeleteFrame_Click);
            // 
            // pictureBitmap
            // 
            this.pictureBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBitmap.ContextMenuStrip = this.contextMenu;
            this.pictureBitmap.Location = new System.Drawing.Point(9, 9);
            this.pictureBitmap.Margin = new System.Windows.Forms.Padding(9);
            this.pictureBitmap.Name = "pictureBitmap";
            this.pictureBitmap.Size = new System.Drawing.Size(514, 158);
            this.pictureBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBitmap.TabIndex = 1;
            this.pictureBitmap.TabStop = false;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nenuDeleteAfter,
            this.menuDeleteBefore});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(237, 48);
            // 
            // nenuDeleteAfter
            // 
            this.nenuDeleteAfter.Name = "nenuDeleteAfter";
            this.nenuDeleteAfter.Size = new System.Drawing.Size(236, 22);
            this.nenuDeleteAfter.Text = global::ScreenToGif.Properties.Resources.Context_DelAfter;
            this.nenuDeleteAfter.Click += new System.EventHandler(this.nenuDeleteAfter_Click);
            // 
            // menuDeleteBefore
            // 
            this.menuDeleteBefore.Name = "menuDeleteBefore";
            this.menuDeleteBefore.Size = new System.Drawing.Size(236, 22);
            this.menuDeleteBefore.Text = global::ScreenToGif.Properties.Resources.Context_DelBefore;
            this.menuDeleteBefore.Click += new System.EventHandler(this.menuDeleteBefore_Click);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.AutoSize = false;
            this.trackBar.Location = new System.Drawing.Point(12, 179);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(508, 25);
            this.trackBar.TabIndex = 0;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // timerCapture
            // 
            this.timerCapture.Tick += new System.EventHandler(this.timerCapture_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "gif";
            this.saveFileDialog.FileName = global::ScreenToGif.Properties.Resources.SFDialog_Filename;
            this.saveFileDialog.Filter = " Gif files (*.gif)|*.gif|All files (*.*)|*.*";
            this.saveFileDialog.Title = global::ScreenToGif.Properties.Resources.SFDialog_Title;
            // 
            // timerPreStart
            // 
            this.timerPreStart.Interval = 1000;
            this.timerPreStart.Tick += new System.EventHandler(this.PreStart_Tick);
            // 
            // panelGifConfig
            // 
            this.panelGifConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGifConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelGifConfig.Controls.Add(this.labelQuality);
            this.panelGifConfig.Controls.Add(this.cbLoop);
            this.panelGifConfig.Controls.Add(this.label13);
            this.panelGifConfig.Controls.Add(this.label12);
            this.panelGifConfig.Controls.Add(this.label11);
            this.panelGifConfig.Controls.Add(this.label10);
            this.panelGifConfig.Controls.Add(this.label9);
            this.panelGifConfig.Controls.Add(this.label8);
            this.panelGifConfig.Controls.Add(this.trackBarQuality);
            this.panelGifConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGifConfig.Location = new System.Drawing.Point(0, 0);
            this.panelGifConfig.Name = "panelGifConfig";
            this.panelGifConfig.Size = new System.Drawing.Size(532, 247);
            this.panelGifConfig.TabIndex = 15;
            this.panelGifConfig.Visible = false;
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelQuality.Location = new System.Drawing.Point(169, 32);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(19, 15);
            this.labelQuality.TabIndex = 17;
            this.labelQuality.Text = "10";
            // 
            // cbLoop
            // 
            this.cbLoop.AutoSize = true;
            this.cbLoop.Location = new System.Drawing.Point(16, 105);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(91, 19);
            this.cbLoop.TabIndex = 16;
            this.cbLoop.Text = global::ScreenToGif.Properties.Resources.CB_Looped;
            this.cbLoop.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label13.Location = new System.Drawing.Point(89, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = Resources.Label_Slow;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(210)))));
            this.label12.Location = new System.Drawing.Point(235, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = Resources.Label_Fast;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label11.Location = new System.Drawing.Point(235, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = Resources.Label_Worst;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(210)))));
            this.label10.Location = new System.Drawing.Point(89, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = Resources.Label_Better;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = Resources.Label_GifSettings;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = Resources.Label_Compression;
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.AutoSize = false;
            this.trackBarQuality.Location = new System.Drawing.Point(89, 50);
            this.trackBarQuality.Maximum = 20;
            this.trackBarQuality.Minimum = 1;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(190, 25);
            this.trackBarQuality.TabIndex = 9;
            this.trackBarQuality.Value = 10;
            this.trackBarQuality.Scroll += new System.EventHandler(this.trackBarQuality_Scroll);
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.btnStop);
            this.flowPanel.Controls.Add(this.btnRecordPause);
            this.flowPanel.Controls.Add(this.tbHeight);
            this.flowPanel.Controls.Add(this.label5);
            this.flowPanel.Controls.Add(this.tbWidth);
            this.flowPanel.Controls.Add(this.label6);
            this.flowPanel.Controls.Add(this.numMaxFps);
            this.flowPanel.Controls.Add(this.label7);
            this.flowPanel.Controls.Add(this.pictureBox1);
            this.flowPanel.Controls.Add(this.btnConfig);
            this.flowPanel.Controls.Add(this.btnGifConfig);
            this.flowPanel.Controls.Add(this.btnInfo);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPanel.Location = new System.Drawing.Point(0, 248);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowPanel.Size = new System.Drawing.Size(532, 31);
            this.flowPanel.TabIndex = 16;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.AutoSize = true;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::ScreenToGif.Properties.Resources.Stop_17Red;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStop.Location = new System.Drawing.Point(462, 3);
            this.btnStop.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStop.Size = new System.Drawing.Size(69, 25);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = global::ScreenToGif.Properties.Resources.btnStop;
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseCompatibleTextRendering = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRecordPause
            // 
            this.btnRecordPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecordPause.AutoSize = true;
            this.btnRecordPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecordPause.FlatAppearance.BorderSize = 0;
            this.btnRecordPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordPause.Image = global::ScreenToGif.Properties.Resources.Play_17Green;
            this.btnRecordPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecordPause.Location = new System.Drawing.Point(379, 3);
            this.btnRecordPause.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btnRecordPause.Name = "btnRecordPause";
            this.btnRecordPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRecordPause.Size = new System.Drawing.Size(77, 25);
            this.btnRecordPause.TabIndex = 25;
            this.btnRecordPause.Text = global::ScreenToGif.Properties.Resources.btnRecordPause_Record;
            this.btnRecordPause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecordPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecordPause.UseCompatibleTextRendering = true;
            this.btnRecordPause.UseVisualStyleBackColor = true;
            this.btnRecordPause.Click += new System.EventHandler(this.btnPauseRecord_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(329, 4);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbHeight.Size = new System.Drawing.Size(46, 23);
            this.tbHeight.TabIndex = 23;
            this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHeight_KeyDown);
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            this.tbHeight.Leave += new System.EventHandler(this.tbHeight_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 8, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "X";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(262, 4);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWidth.Size = new System.Drawing.Size(46, 23);
            this.tbWidth.TabIndex = 26;
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbWidth_KeyDown);
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            this.tbWidth.Leave += new System.EventHandler(this.tbWidth_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 7, 1, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = Resources.Label_Size;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // numMaxFps
            // 
            this.numMaxFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxFps.AutoSize = true;
            this.numMaxFps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMaxFps.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMaxFps.Location = new System.Drawing.Point(165, 5);
            this.numMaxFps.Margin = new System.Windows.Forms.Padding(2, 0, 3, 3);
            this.numMaxFps.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numMaxFps.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMaxFps.Name = "numMaxFps";
            this.numMaxFps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numMaxFps.Size = new System.Drawing.Size(35, 23);
            this.numMaxFps.TabIndex = 21;
            this.toolTip.SetToolTip(this.numMaxFps, global::ScreenToGif.Properties.Resources.Tooltip_NumFPS);
            this.numMaxFps.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 7, 1, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "FPS";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScreenToGif.Properties.Resources.Separator;
            this.pictureBox1.Location = new System.Drawing.Point(131, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 23);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(104, 3);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfig.Size = new System.Drawing.Size(23, 23);
            this.btnConfig.TabIndex = 28;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnConfig, global::ScreenToGif.Properties.Resources.Tooltip_AppSettings);
            this.btnConfig.UseCompatibleTextRendering = true;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnGifConfig
            // 
            this.btnGifConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGifConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGifConfig.FlatAppearance.BorderSize = 0;
            this.btnGifConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGifConfig.Image = global::ScreenToGif.Properties.Resources.Image_17;
            this.btnGifConfig.Location = new System.Drawing.Point(79, 3);
            this.btnGifConfig.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnGifConfig.Name = "btnGifConfig";
            this.btnGifConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGifConfig.Size = new System.Drawing.Size(23, 23);
            this.btnGifConfig.TabIndex = 32;
            this.btnGifConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGifConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnGifConfig, global::ScreenToGif.Properties.Resources.Tooltip_GifSettings);
            this.btnGifConfig.UseCompatibleTextRendering = true;
            this.btnGifConfig.UseVisualStyleBackColor = true;
            this.btnGifConfig.Click += new System.EventHandler(this.btnGifConfig_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::ScreenToGif.Properties.Resources.Info_17Blue;
            this.btnInfo.Location = new System.Drawing.Point(54, 3);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInfo.Size = new System.Drawing.Size(23, 23);
            this.btnInfo.TabIndex = 29;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnInfo, global::ScreenToGif.Properties.Resources.Tooltip_Info);
            this.btnInfo.UseCompatibleTextRendering = true;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // timerCapWithCursor
            // 
            this.timerCapWithCursor.Interval = 15;
            this.timerCapWithCursor.Tick += new System.EventHandler(this.timerCapWithCursor_Tick);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
            this.toolTip.BackColor = System.Drawing.SystemColors.Menu;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(532, 279);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.panelGifConfig);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelTransparent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(266, 164);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen To Gif";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBitmap)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panelGifConfig.ResumeLayout(false);
            this.panelGifConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxFps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTransparent;
        private System.Windows.Forms.Timer timerCapture;
        private System.Windows.Forms.Label lbltopright;
        private System.Windows.Forms.Label lblbottomright;
        private System.Windows.Forms.Label lblleftbottom;
        private System.Windows.Forms.Label lbltopleft;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timerPreStart;
        private System.Windows.Forms.Timer timerCursor;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.CheckBox cbAllowEdit;
        private System.Windows.Forms.Label labelQuickSettings;
        private System.Windows.Forms.CheckBox cbShowCursor;
        private System.Windows.Forms.CheckBox cbSaveDirectly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboStartPauseKey;
        private System.Windows.Forms.ComboBox comboStopKey;
        private System.Windows.Forms.CheckBox cbModernStyle;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PictureBox pictureBitmap;
        private System.Windows.Forms.Button btnUndoOne;
        private System.Windows.Forms.Button btnUndoAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDeleteFrame;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem nenuDeleteAfter;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteBefore;
        private System.Windows.Forms.Panel panelGifConfig;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.CheckBox cbLoop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRecordPause;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMaxFps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnGifConfig;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Timer timerCapWithCursor;
        private System.Windows.Forms.ToolTip toolTip;

    }
}