namespace BaiBaoBTL
{
    partial class BC_5Tour
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
            this.dgv5Tour = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5Tour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv5Tour
            // 
            this.dgv5Tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5Tour.Location = new System.Drawing.Point(87, 143);
            this.dgv5Tour.Name = "dgv5Tour";
            this.dgv5Tour.Size = new System.Drawing.Size(627, 243);
            this.dgv5Tour.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(142, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOP 5 TOUR CÓ NGƯỜI ĐĂNG KÍ NHIỀU NHẤT";
            // 
            // BC_5Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv5Tour);
            this.Controls.Add(this.label1);
            this.Name = "BC_5Tour";
            this.Text = "Báo cáo 5 tour có người đăng ký nhiều nhất";
            this.Load += new System.EventHandler(this.BC_5Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv5Tour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv5Tour;
        private System.Windows.Forms.Label label1;
    }
}