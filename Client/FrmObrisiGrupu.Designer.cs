using System.Windows.Forms;

namespace Client
{
    partial class FrmObrisiGrupu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnVratiGrupe = new System.Windows.Forms.Button();
            this.txtBrisanjeGod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(650, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obriši grupu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVratiGrupe
            // 
            this.btnVratiGrupe.Location = new System.Drawing.Point(90, 36);
            this.btnVratiGrupe.Name = "btnVratiGrupe";
            this.btnVratiGrupe.Size = new System.Drawing.Size(258, 54);
            this.btnVratiGrupe.TabIndex = 2;
            this.btnVratiGrupe.Text = "Učitaj grupe iz godine:";
            this.btnVratiGrupe.UseVisualStyleBackColor = true;
            // 
            // txtBrisanjeGod
            // 
            this.txtBrisanjeGod.Location = new System.Drawing.Point(404, 50);
            this.txtBrisanjeGod.Name = "txtBrisanjeGod";
            this.txtBrisanjeGod.Size = new System.Drawing.Size(211, 26);
            this.txtBrisanjeGod.TabIndex = 3;
            // 
            // FrmObrisiGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 479);
            this.Controls.Add(this.txtBrisanjeGod);
            this.Controls.Add(this.btnVratiGrupe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmObrisiGrupu";
            this.Text = "FrmObrisiGrupu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Button btnVratiGrupe;
        private TextBox txtBrisanjeGod;

        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Button Button1 { get => button1; set => button1 = value; }
        public Button BtnVratiGrupe { get => btnVratiGrupe; set => btnVratiGrupe = value; }
        public TextBox TxtBrisanjeGod { get => txtBrisanjeGod; set => txtBrisanjeGod = value; }
    }
}