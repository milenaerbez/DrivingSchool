using System.Windows.Forms;

namespace Client
{
    partial class FrmPrisustva
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(419, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 484);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(419, 186);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(612, 93);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(419, 186);
            this.dataGridView3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ucitaj termine i kandidate za grupu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Dodaj prisustvo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(838, 660);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sacuvaj prisustva";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Location = new System.Drawing.Point(43, 65);
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.RowHeadersWidth = 62;
            this.dgvGrupe.RowTemplate.Height = 28;
            this.dgvGrupe.Size = new System.Drawing.Size(419, 186);
            this.dgvGrupe.TabIndex = 9;
            // 
            // FrmPrisustva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 730);
            this.Controls.Add(this.dgvGrupe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPrisustva";
            this.Text = "FrmPrisustva";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvGrupe;

        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public DataGridView DataGridView2 { get => dataGridView2; set => dataGridView2 = value; }
        public DataGridView DataGridView3 { get => dataGridView3; set => dataGridView3 = value; }
        public Button Button1 { get => button1; set => button1 = value; }
       // public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        //public Label Label1 { get => label1; set => label1 = value; }
        public Button Button2 { get => button2; set => button2 = value; }
        public Button Button3 { get => button3; set => button3 = value; }
      //  public Button Button4 { get => button4; set => button4 = value; }
        public DataGridView DgvGrupe { get => dgvGrupe; set => dgvGrupe = value; }
    }
}