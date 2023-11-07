using System.Windows.Forms;

namespace Client.Kandidat
{
    partial class FrmIzmenaKandidata
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtBrLicne = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtUnosPrezime = new System.Windows.Forms.TextBox();
            this.txtUnosIme = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(585, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(519, 33);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(153, 26);
            this.btnPretraga.TabIndex = 1;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(261, 33);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(242, 26);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtBrLicne
            // 
            this.txtBrLicne.Location = new System.Drawing.Point(209, 451);
            this.txtBrLicne.Name = "txtBrLicne";
            this.txtBrLicne.Size = new System.Drawing.Size(291, 26);
            this.txtBrLicne.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 504);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtUnosPrezime
            // 
            this.txtUnosPrezime.Location = new System.Drawing.Point(209, 402);
            this.txtUnosPrezime.Name = "txtUnosPrezime";
            this.txtUnosPrezime.Size = new System.Drawing.Size(291, 26);
            this.txtUnosPrezime.TabIndex = 7;
            // 
            // txtUnosIme
            // 
            this.txtUnosIme.Location = new System.Drawing.Point(209, 349);
            this.txtUnosIme.Name = "txtUnosIme";
            this.txtUnosIme.Size = new System.Drawing.Size(291, 26);
            this.txtUnosIme.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(261, 613);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(169, 26);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sacuvaj izmene";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Broj licne karte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum rodjenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pretraga po prezimenu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(543, 349);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(453, 236);
            this.dataGridView2.TabIndex = 15;
            // 
            // FrmIzmenaKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 756);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtUnosIme);
            this.Controls.Add(this.txtUnosPrezime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBrLicne);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmIzmenaKandidata";
            this.Text = "FrmIzmenaKandidata";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtBrLicne;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtUnosPrezime;
        private System.Windows.Forms.TextBox txtUnosIme;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DataGridView dataGridView2;

        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtBrLicne { get => txtBrLicne; set => txtBrLicne = value; }
        public DateTimePicker DateTimePicker1 { get => dateTimePicker1; set => dateTimePicker1 = value; }
        public TextBox TxtUnosPrezime { get => txtUnosPrezime; set => txtUnosPrezime = value; }
        public TextBox TxtUnosIme { get => txtUnosIme; set => txtUnosIme = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public DataGridView DataGridView2 { get => dataGridView2; set => dataGridView2 = value; }
    }
}