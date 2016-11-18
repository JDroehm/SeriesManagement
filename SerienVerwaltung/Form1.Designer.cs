namespace SerienVerwaltung
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmData
            // 
            this.tsmData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.tsmData.Name = "tsmData";
            this.tsmData.Size = new System.Drawing.Size(43, 20);
            this.tsmData.Text = "Data";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Neue Serie";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seriesToolStripMenuItem,
            this.actorToolStripMenuItem,
            this.producerToolStripMenuItem,
            this.streamingToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // seriesToolStripMenuItem
            // 
            this.seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            this.seriesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.seriesToolStripMenuItem.Text = "series";
            this.seriesToolStripMenuItem.Click += new System.EventHandler(this.seriesToolStripMenuItem_Click);
            // 
            // actorToolStripMenuItem
            // 
            this.actorToolStripMenuItem.Name = "actorToolStripMenuItem";
            this.actorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.actorToolStripMenuItem.Text = "actor";
            this.actorToolStripMenuItem.Click += new System.EventHandler(this.actorToolStripMenuItem_Click);
            // 
            // producerToolStripMenuItem
            // 
            this.producerToolStripMenuItem.Name = "producerToolStripMenuItem";
            this.producerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.producerToolStripMenuItem.Text = "producer";
            this.producerToolStripMenuItem.Click += new System.EventHandler(this.producerToolStripMenuItem_Click);
            // 
            // streamingToolStripMenuItem
            // 
            this.streamingToolStripMenuItem.Name = "streamingToolStripMenuItem";
            this.streamingToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.streamingToolStripMenuItem.Text = "streaming";
            this.streamingToolStripMenuItem.Click += new System.EventHandler(this.streamingToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.genreToolStripMenuItem.Text = "genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // dataGridTable
            // 
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Location = new System.Drawing.Point(33, 49);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.Size = new System.Drawing.Size(648, 369);
            this.dataGridTable.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 516);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmData;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

