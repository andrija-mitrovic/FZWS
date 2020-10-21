namespace FZWS.WinUI
{
    partial class JedMjere
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
            this.jedMjereGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jedMjereGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jedMjereGridView
            // 
            this.jedMjereGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.jedMjereGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jedMjereGridView.Location = new System.Drawing.Point(31, 71);
            this.jedMjereGridView.Name = "jedMjereGridView";
            this.jedMjereGridView.RowHeadersVisible = false;
            this.jedMjereGridView.RowTemplate.Height = 24;
            this.jedMjereGridView.Size = new System.Drawing.Size(471, 511);
            this.jedMjereGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jedinice Mjere";
            // 
            // JedMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 620);
            this.Controls.Add(this.jedMjereGridView);
            this.Controls.Add(this.label1);
            this.Name = "JedMjere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jedinice Mjere";
            ((System.ComponentModel.ISupportInitialize)(this.jedMjereGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jedMjereGridView;
        private System.Windows.Forms.Label label1;
    }
}