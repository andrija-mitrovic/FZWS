namespace FZWS.WinUI
{
    partial class LijekLager
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
            this.lijekLagerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lijekLagerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekLagerGridView
            // 
            this.lijekLagerGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lijekLagerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijekLagerGridView.Location = new System.Drawing.Point(35, 70);
            this.lijekLagerGridView.Name = "lijekLagerGridView";
            this.lijekLagerGridView.RowHeadersVisible = false;
            this.lijekLagerGridView.RowTemplate.Height = 24;
            this.lijekLagerGridView.Size = new System.Drawing.Size(471, 511);
            this.lijekLagerGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lijekovi Lager";
            // 
            // LijekLager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 615);
            this.Controls.Add(this.lijekLagerGridView);
            this.Controls.Add(this.label1);
            this.Name = "LijekLager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lijekovi Lager";
            ((System.ComponentModel.ISupportInitialize)(this.lijekLagerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lijekLagerGridView;
        private System.Windows.Forms.Label label1;
    }
}