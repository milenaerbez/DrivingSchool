namespace Client
{
    partial class GlavniMeni
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kandidatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKandidataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiKandidataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniKandidataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napraviGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTermineZaGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiGrupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisustvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPrisustvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kandidatiToolStripMenuItem,
            this.grupeToolStripMenuItem,
            this.prisustvaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kandidatiToolStripMenuItem
            // 
            this.kandidatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKandidataToolStripMenuItem,
            this.obrišiKandidataToolStripMenuItem,
            this.izmeniKandidataToolStripMenuItem});
            this.kandidatiToolStripMenuItem.Name = "kandidatiToolStripMenuItem";
            this.kandidatiToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.kandidatiToolStripMenuItem.Text = "Kandidati";
            // 
            // dodajKandidataToolStripMenuItem
            // 
            this.dodajKandidataToolStripMenuItem.Name = "dodajKandidataToolStripMenuItem";
            this.dodajKandidataToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dodajKandidataToolStripMenuItem.Text = "Dodaj kandidata";
            this.dodajKandidataToolStripMenuItem.Click += new System.EventHandler(this.dodajKandidataToolStripMenuItem_Click);
            // 
            // obrišiKandidataToolStripMenuItem
            // 
            this.obrišiKandidataToolStripMenuItem.Name = "obrišiKandidataToolStripMenuItem";
            this.obrišiKandidataToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.obrišiKandidataToolStripMenuItem.Text = "Obriši kandidata";
            this.obrišiKandidataToolStripMenuItem.Click += new System.EventHandler(this.obrišiKandidataToolStripMenuItem_Click);
            // 
            // izmeniKandidataToolStripMenuItem
            // 
            this.izmeniKandidataToolStripMenuItem.Name = "izmeniKandidataToolStripMenuItem";
            this.izmeniKandidataToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.izmeniKandidataToolStripMenuItem.Text = "Izmeni kandidata";
            this.izmeniKandidataToolStripMenuItem.Click += new System.EventHandler(this.izmeniKandidataToolStripMenuItem_Click);
            // 
            // grupeToolStripMenuItem
            // 
            this.grupeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.napraviGrupuToolStripMenuItem,
            this.dodajTermineZaGrupuToolStripMenuItem,
            this.obrišiGrupuToolStripMenuItem,
            this.pretražiGrupeToolStripMenuItem});
            this.grupeToolStripMenuItem.Name = "grupeToolStripMenuItem";
            this.grupeToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.grupeToolStripMenuItem.Text = "Grupe";
            // 
            // napraviGrupuToolStripMenuItem
            // 
            this.napraviGrupuToolStripMenuItem.Name = "napraviGrupuToolStripMenuItem";
            this.napraviGrupuToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.napraviGrupuToolStripMenuItem.Text = "Napravi grupu";
            this.napraviGrupuToolStripMenuItem.Click += new System.EventHandler(this.napraviGrupuToolStripMenuItem_Click);
            // 
            // dodajTermineZaGrupuToolStripMenuItem
            // 
            this.dodajTermineZaGrupuToolStripMenuItem.Name = "dodajTermineZaGrupuToolStripMenuItem";
            this.dodajTermineZaGrupuToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.dodajTermineZaGrupuToolStripMenuItem.Text = "Dodaj termine za grupu";
            this.dodajTermineZaGrupuToolStripMenuItem.Click += new System.EventHandler(this.dodajTermineZaGrupuToolStripMenuItem_Click);
            // 
            // obrišiGrupuToolStripMenuItem
            // 
            this.obrišiGrupuToolStripMenuItem.Name = "obrišiGrupuToolStripMenuItem";
            this.obrišiGrupuToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.obrišiGrupuToolStripMenuItem.Text = "Obriši grupu";
            this.obrišiGrupuToolStripMenuItem.Click += new System.EventHandler(this.obrišiGrupuToolStripMenuItem_Click);
            // 
            // pretražiGrupeToolStripMenuItem
            // 
            this.pretražiGrupeToolStripMenuItem.Name = "pretražiGrupeToolStripMenuItem";
            this.pretražiGrupeToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.pretražiGrupeToolStripMenuItem.Text = "Pretraži grupe";
            this.pretražiGrupeToolStripMenuItem.Click += new System.EventHandler(this.pretražiGrupeToolStripMenuItem_Click);
            // 
            // prisustvaToolStripMenuItem
            // 
            this.prisustvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPrisustvoToolStripMenuItem});
            this.prisustvaToolStripMenuItem.Name = "prisustvaToolStripMenuItem";
            this.prisustvaToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.prisustvaToolStripMenuItem.Text = "Prisustva";
            // 
            // dodajPrisustvoToolStripMenuItem
            // 
            this.dodajPrisustvoToolStripMenuItem.Name = "dodajPrisustvoToolStripMenuItem";
            this.dodajPrisustvoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dodajPrisustvoToolStripMenuItem.Text = "Dodaj prisustvo";
            this.dodajPrisustvoToolStripMenuItem.Click += new System.EventHandler(this.dodajPrisustvoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // GlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavniMeni";
            this.Text = "GlavniMeni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kandidatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKandidataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiKandidataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisustvaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem napraviGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniKandidataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTermineZaGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPrisustvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiGrupeToolStripMenuItem;
    }
}