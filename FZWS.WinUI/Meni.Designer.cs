namespace FZWS.WinUI
{
    partial class Meni
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.servisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizacioneJediniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jediniceMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekoviLagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodjaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posaljiLagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servisiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // servisiToolStripMenuItem
            // 
            this.servisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustanoveToolStripMenuItem,
            this.organizacioneJediniceToolStripMenuItem,
            this.jediniceMjereToolStripMenuItem,
            this.lijekoviLagerToolStripMenuItem,
            this.proizvodjaciToolStripMenuItem,
            this.posaljiLagerToolStripMenuItem});
            this.servisiToolStripMenuItem.Name = "servisiToolStripMenuItem";
            this.servisiToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.servisiToolStripMenuItem.Text = "Servisi";
            // 
            // ustanoveToolStripMenuItem
            // 
            this.ustanoveToolStripMenuItem.Name = "ustanoveToolStripMenuItem";
            this.ustanoveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ustanoveToolStripMenuItem.Text = "Ustanove";
            this.ustanoveToolStripMenuItem.Click += new System.EventHandler(this.ustanoveToolStripMenuItem_Click);
            // 
            // organizacioneJediniceToolStripMenuItem
            // 
            this.organizacioneJediniceToolStripMenuItem.Name = "organizacioneJediniceToolStripMenuItem";
            this.organizacioneJediniceToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.organizacioneJediniceToolStripMenuItem.Text = "Organizacione Jedinice";
            this.organizacioneJediniceToolStripMenuItem.Click += new System.EventHandler(this.organizacioneJediniceToolStripMenuItem_Click);
            // 
            // jediniceMjereToolStripMenuItem
            // 
            this.jediniceMjereToolStripMenuItem.Name = "jediniceMjereToolStripMenuItem";
            this.jediniceMjereToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.jediniceMjereToolStripMenuItem.Text = "Jedinice Mjere";
            this.jediniceMjereToolStripMenuItem.Click += new System.EventHandler(this.jediniceMjereToolStripMenuItem_Click);
            // 
            // lijekoviLagerToolStripMenuItem
            // 
            this.lijekoviLagerToolStripMenuItem.Name = "lijekoviLagerToolStripMenuItem";
            this.lijekoviLagerToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.lijekoviLagerToolStripMenuItem.Text = "Lijekovi Lager";
            this.lijekoviLagerToolStripMenuItem.Click += new System.EventHandler(this.lijekoviLagerToolStripMenuItem_Click);
            // 
            // proizvodjaciToolStripMenuItem
            // 
            this.proizvodjaciToolStripMenuItem.Name = "proizvodjaciToolStripMenuItem";
            this.proizvodjaciToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.proizvodjaciToolStripMenuItem.Text = "Proizvodjaci";
            this.proizvodjaciToolStripMenuItem.Click += new System.EventHandler(this.proizvodjaciToolStripMenuItem_Click);
            // 
            // posaljiLagerToolStripMenuItem
            // 
            this.posaljiLagerToolStripMenuItem.Name = "posaljiLagerToolStripMenuItem";
            this.posaljiLagerToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.posaljiLagerToolStripMenuItem.Text = "Posalji Lager";
            this.posaljiLagerToolStripMenuItem.Click += new System.EventHandler(this.posaljiLagerToolStripMenuItem_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 598);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fond Zdravstva WS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustanoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizacioneJediniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jediniceMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekoviLagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodjaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posaljiLagerToolStripMenuItem;
    }
}

