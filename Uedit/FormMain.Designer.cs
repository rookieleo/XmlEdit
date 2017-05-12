namespace Uedit
{
    partial class FormMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Text");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("ActiveText");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Image");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("ActiveImage");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("BackGroundImage");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Table");
            this.pContainer = new System.Windows.Forms.Panel();
            this.ms_File = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_New = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_Preview = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.pg_ControlProperty = new System.Windows.Forms.PropertyGrid();
            this.lv_Tool = new System.Windows.Forms.ListView();
            this.ms_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.AllowDrop = true;
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.BackColor = System.Drawing.Color.White;
            this.pContainer.Location = new System.Drawing.Point(181, 28);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(598, 850);
            this.pContainer.TabIndex = 1;
            this.pContainer.Visible = false;
            this.pContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.pContainer_DragDrop);
            this.pContainer.DragEnter += new System.Windows.Forms.DragEventHandler(this.pContainer_DragEnter);
            // 
            // ms_File
            // 
            this.ms_File.BackColor = System.Drawing.SystemColors.Control;
            this.ms_File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ms_File.Location = new System.Drawing.Point(0, 0);
            this.ms_File.Name = "ms_File";
            this.ms_File.Size = new System.Drawing.Size(997, 25);
            this.ms_File.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_New,
            this.ms_Open,
            this.toolStripSeparator1,
            this.ms_Save,
            this.toolStripSeparator2,
            this.ms_Preview,
            this.ms_Close,
            this.ms_Setting});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ms_New
            // 
            this.ms_New.Name = "ms_New";
            this.ms_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ms_New.Size = new System.Drawing.Size(257, 22);
            this.ms_New.Text = "New Report Template";
            this.ms_New.Click += new System.EventHandler(this.MenuItemClickEvent);
            // 
            // ms_Open
            // 
            this.ms_Open.Name = "ms_Open";
            this.ms_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ms_Open.Size = new System.Drawing.Size(257, 22);
            this.ms_Open.Text = "Open Report Template";
            this.ms_Open.Click += new System.EventHandler(this.MenuItemClickEvent);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // ms_Save
            // 
            this.ms_Save.Enabled = false;
            this.ms_Save.Name = "ms_Save";
            this.ms_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ms_Save.Size = new System.Drawing.Size(257, 22);
            this.ms_Save.Text = "Save";
            this.ms_Save.Click += new System.EventHandler(this.MenuItemClickEvent);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // ms_Preview
            // 
            this.ms_Preview.Enabled = false;
            this.ms_Preview.Name = "ms_Preview";
            this.ms_Preview.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ms_Preview.Size = new System.Drawing.Size(257, 22);
            this.ms_Preview.Text = "Preview";
            this.ms_Preview.Click += new System.EventHandler(this.MenuItemClickEvent);
            // 
            // ms_Close
            // 
            this.ms_Close.Enabled = false;
            this.ms_Close.Name = "ms_Close";
            this.ms_Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.ms_Close.Size = new System.Drawing.Size(257, 22);
            this.ms_Close.Text = "Close Current Report";
            this.ms_Close.Click += new System.EventHandler(this.MenuItemClickEvent);
            // 
            // ms_Setting
            // 
            this.ms_Setting.Enabled = false;
            this.ms_Setting.Name = "ms_Setting";
            this.ms_Setting.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ms_Setting.Size = new System.Drawing.Size(257, 22);
            this.ms_Setting.Text = "Setting";
            this.ms_Setting.Click += new System.EventHandler(this.MenuItemClickEvent);
            // 
            // pg_ControlProperty
            // 
            this.pg_ControlProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pg_ControlProperty.Location = new System.Drawing.Point(785, 28);
            this.pg_ControlProperty.Name = "pg_ControlProperty";
            this.pg_ControlProperty.Size = new System.Drawing.Size(212, 850);
            this.pg_ControlProperty.TabIndex = 4;
            this.pg_ControlProperty.Visible = false;
            // 
            // lv_Tool
            // 
            this.lv_Tool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_Tool.Font = new System.Drawing.Font("KaiTi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_Tool.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lv_Tool.Location = new System.Drawing.Point(0, 25);
            this.lv_Tool.Name = "lv_Tool";
            this.lv_Tool.Size = new System.Drawing.Size(175, 850);
            this.lv_Tool.TabIndex = 5;
            this.lv_Tool.UseCompatibleStateImageBehavior = false;
            this.lv_Tool.View = System.Windows.Forms.View.SmallIcon;
            this.lv_Tool.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lv_Tool_ItemDrag);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 878);
            this.Controls.Add(this.lv_Tool);
            this.Controls.Add(this.pg_ControlProperty);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.ms_File);
            this.MainMenuStrip = this.ms_File;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML编辑器";
            this.ms_File.ResumeLayout(false);
            this.ms_File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.MenuStrip ms_File;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_New;
        private System.Windows.Forms.ToolStripMenuItem ms_Save;
        private System.Windows.Forms.PropertyGrid pg_ControlProperty;
        private System.Windows.Forms.ToolStripMenuItem ms_Preview;
        private System.Windows.Forms.ToolStripMenuItem ms_Open;
        private System.Windows.Forms.ToolStripMenuItem ms_Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ms_Setting;
        private System.Windows.Forms.ListView lv_Tool;
    }
}

