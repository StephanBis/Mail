namespace Mail
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
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            this.iTalk_ThemeContainer = new iTalk.iTalk_ThemeContainer();
            this.iTalk_TabControl = new iTalk.iTalk_TabControl();
            this.iTalk_ContextMenuStrip = new iTalk.iTalk_ContextMenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTalk_ControlBox = new iTalk.iTalk_ControlBox();
            this.iTalk_ThemeContainer.SuspendLayout();
            this.iTalk_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_ThemeContainer
            // 
            this.iTalk_ThemeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer.Controls.Add(this.iTalk_TabControl);
            this.iTalk_ThemeContainer.Controls.Add(this.iTalk_ControlBox);
            this.iTalk_ThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer.Name = "iTalk_ThemeContainer";
            this.iTalk_ThemeContainer.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer.Sizable = true;
            this.iTalk_ThemeContainer.Size = new System.Drawing.Size(1242, 737);
            this.iTalk_ThemeContainer.SmartBounds = false;
            this.iTalk_ThemeContainer.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.iTalk_ThemeContainer.TabIndex = 0;
            this.iTalk_ThemeContainer.Text = "Mail - Hoofdscherm";
            // 
            // iTalk_TabControl
            // 
            this.iTalk_TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl.ContextMenuStrip = this.iTalk_ContextMenuStrip;
            this.iTalk_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl.Location = new System.Drawing.Point(3, 28);
            this.iTalk_TabControl.Multiline = true;
            this.iTalk_TabControl.Name = "iTalk_TabControl";
            this.iTalk_TabControl.SelectedIndex = 0;
            this.iTalk_TabControl.Size = new System.Drawing.Size(1236, 681);
            this.iTalk_TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl.TabIndex = 1;
            this.iTalk_TabControl.SelectedIndexChanged += new System.EventHandler(this.iTalk_TabControl_SelectedIndexChanged);
            // 
            // iTalk_ContextMenuStrip
            // 
            this.iTalk_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.iTalk_ContextMenuStrip.Name = "iTalk_ContextMenuStrip";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_ContextMenuStrip.Renderer = controlRenderer1;
            this.iTalk_ContextMenuStrip.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // iTalk_ControlBox
            // 
            this.iTalk_ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox.Location = new System.Drawing.Point(1161, -1);
            this.iTalk_ControlBox.Name = "iTalk_ControlBox";
            this.iTalk_ControlBox.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox.TabIndex = 0;
            this.iTalk_ControlBox.Text = "iTalk_ControlBox1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 737);
            this.ContextMenuStrip = this.iTalk_ContextMenuStrip;
            this.Controls.Add(this.iTalk_ThemeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "Main";
            this.Text = "Mail - Hoofdscherm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.iTalk_ThemeContainer.ResumeLayout(false);
            this.iTalk_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_ThemeContainer iTalk_ThemeContainer;
        private iTalk.iTalk_ControlBox iTalk_ControlBox;
        private iTalk.iTalk_TabControl iTalk_TabControl;
        private iTalk.iTalk_ContextMenuStrip iTalk_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private Email.Net.Imap.ImapClient _client;

    }
}

