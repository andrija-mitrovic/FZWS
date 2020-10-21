namespace FZWS.WinUI
{
    partial class Proizvodjaci
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
            this.proizvodjaciGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodjaciGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // proizvodjaciGridView
            // 
            this.proizvodjaciGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.proizvodjaciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodjaciGridView.Location = new System.Drawing.Point(34, 71);
            this.proizvodjaciGridView.Name = "proizvodjaciGridView";
            this.proizvodjaciGridView.RowHeadersVisible = false;
            this.proizvodjaciGridView.RowTemplate.Height = 24;
            this.proizvodjaciGridView.Size = new System.Drawing.Size(471, 511);
            this.proizvodjaciGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proizvodjaci";
            // 
            // Proizvodjaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 621);
            this.Controls.Add(this.proizvodjaciGridView);
            this.Controls.Add(this.label1);
            this.Name = "Proizvodjaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodjaci";
            ((System.ComponentModel.ISupportInitialize)(this.proizvodjaciGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proizvodjaciGridView;
        private System.Windows.Forms.Label label1;
    }
}