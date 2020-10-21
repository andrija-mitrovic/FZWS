namespace FZWS.WinUI
{
    partial class OrgJedinice
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
            this.ordJediniceGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordJediniceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordJediniceGridView
            // 
            this.ordJediniceGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ordJediniceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordJediniceGridView.Location = new System.Drawing.Point(36, 63);
            this.ordJediniceGridView.Name = "ordJediniceGridView";
            this.ordJediniceGridView.RowHeadersVisible = false;
            this.ordJediniceGridView.RowTemplate.Height = 24;
            this.ordJediniceGridView.Size = new System.Drawing.Size(631, 401);
            this.ordJediniceGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Organizacione Jedinice";
            // 
            // OrgJedinice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 502);
            this.Controls.Add(this.ordJediniceGridView);
            this.Controls.Add(this.label1);
            this.Name = "OrgJedinice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizacione Jedinice";
            ((System.ComponentModel.ISupportInitialize)(this.ordJediniceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordJediniceGridView;
        private System.Windows.Forms.Label label1;
    }
}