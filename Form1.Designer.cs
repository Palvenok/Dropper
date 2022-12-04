﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dropper
{
    partial class Form1
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
                this.notifyIcon.Visible = false;

                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        protected override void OnClosing(CancelEventArgs e)
        {
            if(this.CollapseCheck.Checked)
                e.Cancel = true;
            this.Hide();
        }
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.PictureBox();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Dropper";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 70);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 410);
            this.panel1.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(266, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 30);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(300, 35);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.TabStop = false;
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.historyToolStripMenuItem.Image = global::Dropper.Properties.Resources.History;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyCheck,
            this.CollapseCheck,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.settingsToolStripMenuItem.Image = global::Dropper.Properties.Resources.Settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // CopyCheck
            // 
            this.CopyCheck.CheckOnClick = true;
            this.CopyCheck.Name = "CopyCheck";
            this.CopyCheck.Size = new System.Drawing.Size(171, 22);
            this.CopyCheck.Text = "Copy to Clipboard";
            // 
            // CollapseCheck
            // 
            this.CollapseCheck.Checked = true;
            this.CollapseCheck.CheckOnClick = true;
            this.CollapseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CollapseCheck.Name = "CollapseCheck";
            this.CollapseCheck.Size = new System.Drawing.Size(171, 22);
            this.CollapseCheck.Text = "Collapse on close";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "Hotkeys";
            this.toolStripMenuItem1.ToolTipText = "Alt + Shift + C - Get Color\r\nAlt + Shift + H - Show/Hide history";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Dropper.Properties.Resources.dismiss;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Dropper history";
            this.TopMost = true;
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void TrayMenuInit()
        {
            historyToolStripMenuItem.Click += MenuShowHistory_Click;
            exitToolStripMenuItem.Click += MenuExit_Click;
            CollapseCheck.CheckedChanged += SettingsChanged;
            CopyCheck.CheckedChanged += SettingsChanged;
            notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
        }

        private void TitleInit()
        {
            TitleBar.MouseDown += new MouseEventHandler(TitleMouseDown);
            TitleBar.MouseUp += new MouseEventHandler(TitleMouseUp);
            TitleBar.MouseMove += new MouseEventHandler(TitleMouseMove);
        }

        private void AddItemOnPanel(Color color)
        {
            string hexColor = Utils.HexConverter(color);
            string rgbColor = Utils.RGBConverter(color);

            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(50, 10);
            textBox.Width = 220;
            textBox.Height = 50;
            textBox.Font = new Font(textBox.Font.FontFamily, 12);
            textBox.ReadOnly = true;
            textBox.BorderStyle = BorderStyle.None;
            textBox.TabStop = false;
            textBox.BackColor = this.BackColor;
            textBox.Multiline = true;
            textBox.AcceptsReturn = true;
            textBox.AppendText($"Color: {rgbColor}\r\nHEX: {hexColor}");
            textBox.Parent = this.panel1;

            Button button = new Button();
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new System.Drawing.Point(10, 15);
            button.Size = new System.Drawing.Size(30, 30);
            button.Text = string.Empty;
            button.BackColor = color;
            button.Parent = this.panel1;
            button.Click += GetButtonColor;

            if (textBoxes.Count > 10)
            {
                buttons[0].Click -= GetButtonColor;
                buttons[0].Dispose();
                buttons.RemoveAt(0);
                textBoxes[0].Dispose();
                textBoxes.RemoveAt(0);
            }

            buttons.Add(button);
            textBoxes.Add(textBox);
        }

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem CollapseCheck;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem CopyCheck;
        private ToolStripSeparator toolStripSeparator1;
        private Button CloseButton;
        private PictureBox TitleBar;
    }
}

