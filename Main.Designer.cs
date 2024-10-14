namespace skidsploit
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
            this.Execute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.ExecuteFile = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.Attach = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Editor = new System.Windows.Forms.RichTextBox();
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ballsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Execute.Location = new System.Drawing.Point(12, 244);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(72, 27);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "assassinate";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear.Location = new System.Drawing.Point(90, 244);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(58, 27);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "halcyon";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveFile.Location = new System.Drawing.Point(154, 244);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(70, 27);
            this.SaveFile.TabIndex = 2;
            this.SaveFile.Text = "free book";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ExecuteFile
            // 
            this.ExecuteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExecuteFile.Location = new System.Drawing.Point(230, 244);
            this.ExecuteFile.Name = "ExecuteFile";
            this.ExecuteFile.Size = new System.Drawing.Size(98, 27);
            this.ExecuteFile.TabIndex = 3;
            this.ExecuteFile.Text = "assassinate book";
            this.ExecuteFile.UseVisualStyleBackColor = true;
            this.ExecuteFile.Click += new System.EventHandler(this.ExecuteFile_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadFile.Location = new System.Drawing.Point(334, 244);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(80, 27);
            this.LoadFile.TabIndex = 4;
            this.LoadFile.Text = "amount book";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // Attach
            // 
            this.Attach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Attach.Location = new System.Drawing.Point(420, 244);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(36, 27);
            this.Attach.TabIndex = 5;
            this.Attach.Text = "add";
            this.Attach.UseVisualStyleBackColor = true;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Location = new System.Drawing.Point(582, 244);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(143, 27);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "benefit";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Editor
            // 
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Editor.Location = new System.Drawing.Point(12, 13);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(564, 225);
            this.Editor.TabIndex = 7;
            this.Editor.Text = "print(\"skidsploit on top frfr\")";
            // 
            // ScriptList
            // 
            this.ScriptList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.Location = new System.Drawing.Point(582, 13);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(143, 225);
            this.ScriptList.TabIndex = 8;
            this.ScriptList.SelectedIndexChanged += new System.EventHandler(this.ScriptList_SelectedIndexChanged);
            this.ScriptList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScriptList_MouseDown);
            // 
            // Tick
            // 
            this.Tick.Enabled = true;
            this.Tick.Interval = 10;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ballsToolStripMenuItem,
            this.loadInEditorToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // ballsToolStripMenuItem
            // 
            this.ballsToolStripMenuItem.Name = "ballsToolStripMenuItem";
            this.ballsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ballsToolStripMenuItem.Text = "execute";
            this.ballsToolStripMenuItem.Click += new System.EventHandler(this.ballsToolStripMenuItem_Click);
            // 
            // loadInEditorToolStripMenuItem
            // 
            this.loadInEditorToolStripMenuItem.Name = "loadInEditorToolStripMenuItem";
            this.loadInEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadInEditorToolStripMenuItem.Text = "load into editor";
            this.loadInEditorToolStripMenuItem.Click += new System.EventHandler(this.loadInEditorToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "refresh";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 283);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.ExecuteFile);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skidsploit";
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button ExecuteFile;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.RichTextBox Editor;
        private System.Windows.Forms.ListBox ScriptList;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ballsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadInEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

