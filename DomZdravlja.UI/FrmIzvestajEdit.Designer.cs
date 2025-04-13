namespace DomZdravlja.UI
{
    partial class FrmIzvestajEdit
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
            this.txtNazivIzvestaja = new System.Windows.Forms.TextBox();
            this.txtBrojPacijenata = new System.Windows.Forms.TextBox();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.lblSluzbaID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNazivIzvestaja
            // 
            this.txtNazivIzvestaja.Location = new System.Drawing.Point(57, 64);
            this.txtNazivIzvestaja.Name = "txtNazivIzvestaja";
            this.txtNazivIzvestaja.Size = new System.Drawing.Size(100, 20);
            this.txtNazivIzvestaja.TabIndex = 0;
            // 
            // txtBrojPacijenata
            // 
            this.txtBrojPacijenata.Location = new System.Drawing.Point(57, 129);
            this.txtBrojPacijenata.Name = "txtBrojPacijenata";
            this.txtBrojPacijenata.Size = new System.Drawing.Size(100, 20);
            this.txtBrojPacijenata.TabIndex = 1;
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(57, 182);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumKreiranja.TabIndex = 2;
            // 
            // lblSluzbaID
            // 
            this.lblSluzbaID.AutoSize = true;
            this.lblSluzbaID.Location = new System.Drawing.Point(54, 31);
            this.lblSluzbaID.Name = "lblSluzbaID";
            this.lblSluzbaID.Size = new System.Drawing.Size(0, 13);
            this.lblSluzbaID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv Izvestaja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj Pacijenata";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Upisi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // FrmIzvestajEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSluzbaID);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.txtBrojPacijenata);
            this.Controls.Add(this.txtNazivIzvestaja);
            this.Name = "FrmIzvestajEdit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmIzvestajEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivIzvestaja;
        private System.Windows.Forms.TextBox txtBrojPacijenata;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.Label lblSluzbaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}