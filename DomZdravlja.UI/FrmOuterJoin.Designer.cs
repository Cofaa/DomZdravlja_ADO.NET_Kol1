namespace DomZdravlja.UI
{
    partial class FrmOuterJoin
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
            this.dgvLinqJoin = new System.Windows.Forms.DataGridView();
            this.dgvMethodJoin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinqJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodJoin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLinqJoin
            // 
            this.dgvLinqJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinqJoin.Location = new System.Drawing.Point(218, 12);
            this.dgvLinqJoin.Name = "dgvLinqJoin";
            this.dgvLinqJoin.Size = new System.Drawing.Size(402, 149);
            this.dgvLinqJoin.TabIndex = 0;
            this.dgvLinqJoin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvMethodJoin
            // 
            this.dgvMethodJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMethodJoin.Location = new System.Drawing.Point(218, 177);
            this.dgvMethodJoin.Name = "dgvMethodJoin";
            this.dgvMethodJoin.Size = new System.Drawing.Size(402, 152);
            this.dgvMethodJoin.TabIndex = 1;
            // 
            // FrmOuterJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMethodJoin);
            this.Controls.Add(this.dgvLinqJoin);
            this.Name = "FrmOuterJoin";
            this.Text = "FrmOuterJoin";
            this.Load += new System.EventHandler(this.FrmOuterJoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinqJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodJoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLinqJoin;
        private System.Windows.Forms.DataGridView dgvMethodJoin;
    }
}