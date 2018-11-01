namespace Editor
{
    partial class FW_Editor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FW_Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MI_Datei = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Speichern_Unter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_Beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Bearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Ausschneiden = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Kopieren = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Einfügen = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Fragezeichen = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RTB_Editor = new System.Windows.Forms.RichTextBox();
            this.TSB_Neu = new System.Windows.Forms.ToolStripButton();
            this.TSB_Speichern = new System.Windows.Forms.ToolStripButton();
            this.TSB_Öffnen = new System.Windows.Forms.ToolStripButton();
            this.MI_Neu = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Öffnen = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Speichern = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Datei,
            this.MI_Bearbeiten,
            this.MI_Fragezeichen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MI_Datei
            // 
            this.MI_Datei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Neu,
            this.MI_Öffnen,
            this.MI_Speichern,
            this.MI_Speichern_Unter,
            this.toolStripMenuItem1,
            this.MI_Beenden});
            this.MI_Datei.Name = "MI_Datei";
            this.MI_Datei.Size = new System.Drawing.Size(46, 20);
            this.MI_Datei.Text = "Datei";
            // 
            // MI_Speichern_Unter
            // 
            this.MI_Speichern_Unter.Image = ((System.Drawing.Image)(resources.GetObject("MI_Speichern_Unter.Image")));
            this.MI_Speichern_Unter.Name = "MI_Speichern_Unter";
            this.MI_Speichern_Unter.Size = new System.Drawing.Size(180, 22);
            this.MI_Speichern_Unter.Text = "Speichern unter...";
            this.MI_Speichern_Unter.Click += new System.EventHandler(this.MI_Speichern_Unter_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MI_Beenden
            // 
            this.MI_Beenden.Name = "MI_Beenden";
            this.MI_Beenden.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MI_Beenden.Size = new System.Drawing.Size(180, 22);
            this.MI_Beenden.Text = "Beenden";
            this.MI_Beenden.Click += new System.EventHandler(this.MI_Beenden_Click);
            // 
            // MI_Bearbeiten
            // 
            this.MI_Bearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Ausschneiden,
            this.MI_Kopieren,
            this.MI_Einfügen});
            this.MI_Bearbeiten.Name = "MI_Bearbeiten";
            this.MI_Bearbeiten.Size = new System.Drawing.Size(75, 20);
            this.MI_Bearbeiten.Text = "Bearbeiten";
            // 
            // MI_Ausschneiden
            // 
            this.MI_Ausschneiden.Name = "MI_Ausschneiden";
            this.MI_Ausschneiden.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MI_Ausschneiden.Size = new System.Drawing.Size(191, 22);
            this.MI_Ausschneiden.Text = "Ausschneiden";
            this.MI_Ausschneiden.Click += new System.EventHandler(this.MI_Ausschneiden_Click);
            // 
            // MI_Kopieren
            // 
            this.MI_Kopieren.Name = "MI_Kopieren";
            this.MI_Kopieren.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MI_Kopieren.Size = new System.Drawing.Size(191, 22);
            this.MI_Kopieren.Text = "Kopieren";
            this.MI_Kopieren.Click += new System.EventHandler(this.MI_Kopieren_Click);
            // 
            // MI_Einfügen
            // 
            this.MI_Einfügen.Name = "MI_Einfügen";
            this.MI_Einfügen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MI_Einfügen.Size = new System.Drawing.Size(191, 22);
            this.MI_Einfügen.Text = "Einfügen";
            this.MI_Einfügen.Click += new System.EventHandler(this.MI_Einfügen_Click);
            // 
            // MI_Fragezeichen
            // 
            this.MI_Fragezeichen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Info});
            this.MI_Fragezeichen.Name = "MI_Fragezeichen";
            this.MI_Fragezeichen.Size = new System.Drawing.Size(24, 20);
            this.MI_Fragezeichen.Text = "?";
            // 
            // MI_Info
            // 
            this.MI_Info.Name = "MI_Info";
            this.MI_Info.Size = new System.Drawing.Size(95, 22);
            this.MI_Info.Text = "Info";
            this.MI_Info.Click += new System.EventHandler(this.MI_Info_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel1.Text = "Bereit";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.RTB_Editor);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(750, 354);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 404);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Neu,
            this.TSB_Speichern,
            this.TSB_Öffnen});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // RTB_Editor
            // 
            this.RTB_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Editor.Location = new System.Drawing.Point(0, 0);
            this.RTB_Editor.Name = "RTB_Editor";
            this.RTB_Editor.Size = new System.Drawing.Size(750, 354);
            this.RTB_Editor.TabIndex = 0;
            this.RTB_Editor.Text = "";
            this.RTB_Editor.TextChanged += new System.EventHandler(this.RTB_Editor_TextChanged);
            // 
            // TSB_Neu
            // 
            this.TSB_Neu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Neu.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Neu.Image")));
            this.TSB_Neu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Neu.Name = "TSB_Neu";
            this.TSB_Neu.Size = new System.Drawing.Size(23, 22);
            this.TSB_Neu.Text = "&Neu";
            this.TSB_Neu.Click += new System.EventHandler(this.TSB_Neu_Click);
            // 
            // TSB_Speichern
            // 
            this.TSB_Speichern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Speichern.Image = global::Editor.Properties.Resources.saveHS;
            this.TSB_Speichern.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Speichern.Name = "TSB_Speichern";
            this.TSB_Speichern.Size = new System.Drawing.Size(23, 22);
            this.TSB_Speichern.Text = "&Speichern";
            this.TSB_Speichern.Click += new System.EventHandler(this.TSB_Speichern_Click);
            // 
            // TSB_Öffnen
            // 
            this.TSB_Öffnen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Öffnen.Image = global::Editor.Properties.Resources.openHS;
            this.TSB_Öffnen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Öffnen.Name = "TSB_Öffnen";
            this.TSB_Öffnen.Size = new System.Drawing.Size(23, 22);
            this.TSB_Öffnen.Text = "&Oeffnen";
            this.TSB_Öffnen.Click += new System.EventHandler(this.TSB_Öffnen_Click);
            // 
            // MI_Neu
            // 
            this.MI_Neu.Image = ((System.Drawing.Image)(resources.GetObject("MI_Neu.Image")));
            this.MI_Neu.Name = "MI_Neu";
            this.MI_Neu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MI_Neu.Size = new System.Drawing.Size(180, 22);
            this.MI_Neu.Text = "Neu";
            this.MI_Neu.Click += new System.EventHandler(this.MI_Neu_Click);
            // 
            // MI_Öffnen
            // 
            this.MI_Öffnen.Image = global::Editor.Properties.Resources.openHS;
            this.MI_Öffnen.Name = "MI_Öffnen";
            this.MI_Öffnen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MI_Öffnen.Size = new System.Drawing.Size(180, 22);
            this.MI_Öffnen.Text = "Öffnen";
            this.MI_Öffnen.Click += new System.EventHandler(this.MI_Öffnen_Click);
            // 
            // MI_Speichern
            // 
            this.MI_Speichern.Image = global::Editor.Properties.Resources.saveHS;
            this.MI_Speichern.Name = "MI_Speichern";
            this.MI_Speichern.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MI_Speichern.Size = new System.Drawing.Size(180, 22);
            this.MI_Speichern.Text = "Speichern";
            this.MI_Speichern.Click += new System.EventHandler(this.MI_Speichern_Click);
            // 
            // FW_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FW_Editor";
            this.Text = "Editor v1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MI_Datei;
        private System.Windows.Forms.ToolStripMenuItem MI_Neu;
        private System.Windows.Forms.ToolStripMenuItem MI_Öffnen;
        private System.Windows.Forms.ToolStripMenuItem MI_Speichern;
        private System.Windows.Forms.ToolStripMenuItem MI_Speichern_Unter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MI_Beenden;
        private System.Windows.Forms.ToolStripMenuItem MI_Bearbeiten;
        private System.Windows.Forms.ToolStripMenuItem MI_Ausschneiden;
        private System.Windows.Forms.ToolStripMenuItem MI_Kopieren;
        private System.Windows.Forms.ToolStripMenuItem MI_Einfügen;
        private System.Windows.Forms.ToolStripMenuItem MI_Fragezeichen;
        private System.Windows.Forms.ToolStripMenuItem MI_Info;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox RTB_Editor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Neu;
        private System.Windows.Forms.ToolStripButton TSB_Speichern;
        private System.Windows.Forms.ToolStripButton TSB_Öffnen;
    }
}

