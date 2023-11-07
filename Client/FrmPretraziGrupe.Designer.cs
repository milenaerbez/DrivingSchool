using System.Windows.Forms;

namespace Client
{
    partial class FrmPretraziGrupe
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
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.btnGodina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Location = new System.Drawing.Point(114, 29);
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.RowHeadersWidth = 62;
            this.dgvGrupe.RowTemplate.Height = 28;
            this.dgvGrupe.Size = new System.Drawing.Size(523, 224);
            this.dgvGrupe.TabIndex = 0;
            // 
            // btnGodina
            // 
            this.btnGodina.Location = new System.Drawing.Point(114, 291);
            this.btnGodina.Name = "btnGodina";
            this.btnGodina.Size = new System.Drawing.Size(153, 32);
            this.btnGodina.TabIndex = 1;
            this.btnGodina.Text = "Pretrazi";
            this.btnGodina.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "sve grupe iz godine";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(437, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 26);
            this.textBox1.TabIndex = 3;
            // 
            // FrmPretraziGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGodina);
            this.Controls.Add(this.dgvGrupe);
            this.Name = "FrmPretraziGrupe";
            this.Text = "FrmPretraziGrupe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupe;
        private System.Windows.Forms.Button btnGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        public DataGridView DgvGrupe { get => dgvGrupe; set => dgvGrupe = value; }
        public Button BtnGodina { get => btnGodina; set => btnGodina = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
    }
}