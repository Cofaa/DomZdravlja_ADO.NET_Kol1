namespace DomZdravlja.UI
{
    partial class FrmMainMasterDetail
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
            this.cmbSluzba = new System.Windows.Forms.ComboBox();
            this.dgvIzvestaji = new System.Windows.Forms.DataGridView();
            this.Novi = new System.Windows.Forms.Button();
            this.Izvezi = new System.Windows.Forms.Button();
            this.Obrisi = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.txtOpisSluzbe = new System.Windows.Forms.TextBox();
            this.dtpDatumOsnivanja = new System.Windows.Forms.DateTimePicker();
            this.btnOuterJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaji)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSluzba
            // 
            this.cmbSluzba.FormattingEnabled = true;
            this.cmbSluzba.Location = new System.Drawing.Point(345, 32);
            this.cmbSluzba.Name = "cmbSluzba";
            this.cmbSluzba.Size = new System.Drawing.Size(186, 21);
            this.cmbSluzba.TabIndex = 0;
            this.cmbSluzba.SelectedIndexChanged += new System.EventHandler(this.cmbSluzba_SelectedIndexChanged);
            // 
            // dgvIzvestaji
            // 
            this.dgvIzvestaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvestaji.Location = new System.Drawing.Point(26, 99);
            this.dgvIzvestaji.Name = "dgvIzvestaji";
            this.dgvIzvestaji.Size = new System.Drawing.Size(887, 381);
            this.dgvIzvestaji.TabIndex = 3;
            this.dgvIzvestaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIzvestaji_CellContentClick);
            // 
            // Novi
            // 
            this.Novi.Location = new System.Drawing.Point(26, 486);
            this.Novi.Name = "Novi";
            this.Novi.Size = new System.Drawing.Size(100, 46);
            this.Novi.TabIndex = 4;
            this.Novi.Text = "Novi";
            this.Novi.UseVisualStyleBackColor = true;
            this.Novi.Click += new System.EventHandler(this.Novi_Click);
            // 
            // Izvezi
            // 
            this.Izvezi.Location = new System.Drawing.Point(404, 486);
            this.Izvezi.Name = "Izvezi";
            this.Izvezi.Size = new System.Drawing.Size(127, 46);
            this.Izvezi.TabIndex = 5;
            this.Izvezi.Text = "Izvezi u XML";
            this.Izvezi.UseVisualStyleBackColor = true;
            this.Izvezi.Click += new System.EventHandler(this.btnXmlExport_Click);
            // 
            // Obrisi
            // 
            this.Obrisi.Location = new System.Drawing.Point(822, 486);
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Size = new System.Drawing.Size(103, 46);
            this.Obrisi.TabIndex = 6;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseVisualStyleBackColor = true;
            this.Obrisi.Click += new System.EventHandler(this.Obrisi_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(161, 486);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(105, 46);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // txtOpisSluzbe
            // 
            this.txtOpisSluzbe.Location = new System.Drawing.Point(649, 32);
            this.txtOpisSluzbe.Name = "txtOpisSluzbe";
            this.txtOpisSluzbe.Size = new System.Drawing.Size(100, 20);
            this.txtOpisSluzbe.TabIndex = 8;
            // 
            // dtpDatumOsnivanja
            // 
            this.dtpDatumOsnivanja.Location = new System.Drawing.Point(598, 58);
            this.dtpDatumOsnivanja.Name = "dtpDatumOsnivanja";
            this.dtpDatumOsnivanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOsnivanja.TabIndex = 9;
            // 
            // btnOuterJoin
            // 
            this.btnOuterJoin.Location = new System.Drawing.Point(404, 547);
            this.btnOuterJoin.Name = "btnOuterJoin";
            this.btnOuterJoin.Size = new System.Drawing.Size(120, 37);
            this.btnOuterJoin.TabIndex = 10;
            this.btnOuterJoin.Text = "Prikazi Zaposlene";
            this.btnOuterJoin.UseVisualStyleBackColor = true;
            this.btnOuterJoin.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMainMasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 596);
            this.Controls.Add(this.btnOuterJoin);
            this.Controls.Add(this.dtpDatumOsnivanja);
            this.Controls.Add(this.txtOpisSluzbe);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Obrisi);
            this.Controls.Add(this.Izvezi);
            this.Controls.Add(this.Novi);
            this.Controls.Add(this.dgvIzvestaji);
            this.Controls.Add(this.cmbSluzba);
            this.Name = "FrmMainMasterDetail";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.FrmMainMasterDetail_load);
            this.Leave += new System.EventHandler(this.FrmMainMasterDetail_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSluzba;
        private System.Windows.Forms.DataGridView dgvIzvestaji;
        private System.Windows.Forms.Button Novi;
        private System.Windows.Forms.Button Izvezi;
        private System.Windows.Forms.Button Obrisi;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox txtOpisSluzbe;
        private System.Windows.Forms.DateTimePicker dtpDatumOsnivanja;
        private System.Windows.Forms.Button btnOuterJoin;
    }
}

