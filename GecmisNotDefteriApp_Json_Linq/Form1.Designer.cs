
namespace GecmisNotDefteriApp_Json_Linq
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lstMesajlar = new System.Windows.Forms.ListBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsMesajlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFavori = new System.Windows.Forms.ToolStripMenuItem();
            this.chkSadeceFavoriler = new System.Windows.Forms.CheckBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tsmiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMesajlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMesajlar
            // 
            this.lstMesajlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMesajlar.FormattingEnabled = true;
            this.lstMesajlar.ItemHeight = 25;
            this.lstMesajlar.Location = new System.Drawing.Point(12, 82);
            this.lstMesajlar.Name = "lstMesajlar";
            this.lstMesajlar.Size = new System.Drawing.Size(439, 554);
            this.lstMesajlar.TabIndex = 2;
            this.lstMesajlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMesajlar_KeyDown);
            this.lstMesajlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMesajlar_MouseDoubleClick);
            this.lstMesajlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstMesajlar_MouseDown);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMesaj.Location = new System.Drawing.Point(65, 6);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(287, 32);
            this.txtMesaj.TabIndex = 0;
            this.txtMesaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMesaj_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(358, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 34);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not:";
            // 
            // cmsMesajlar
            // 
            this.cmsMesajlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSil,
            this.tsmiFavori,
            this.tsmiDuzenle});
            this.cmsMesajlar.Name = "cmsMesajlar";
            this.cmsMesajlar.Size = new System.Drawing.Size(182, 70);
            this.cmsMesajlar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMesajlar_ItemClicked);
            // 
            // tsmiSil
            // 
            this.tsmiSil.Name = "tsmiSil";
            this.tsmiSil.Size = new System.Drawing.Size(181, 22);
            this.tsmiSil.Text = "Sil";
            // 
            // tsmiFavori
            // 
            this.tsmiFavori.Name = "tsmiFavori";
            this.tsmiFavori.Size = new System.Drawing.Size(181, 22);
            this.tsmiFavori.Text = "Favorilere Ekle/Çıkar";
            // 
            // chkSadeceFavoriler
            // 
            this.chkSadeceFavoriler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSadeceFavoriler.AutoSize = true;
            this.chkSadeceFavoriler.Location = new System.Drawing.Point(405, 45);
            this.chkSadeceFavoriler.Name = "chkSadeceFavoriler";
            this.chkSadeceFavoriler.Size = new System.Drawing.Size(46, 30);
            this.chkSadeceFavoriler.TabIndex = 4;
            this.chkSadeceFavoriler.Text = "★";
            this.chkSadeceFavoriler.UseVisualStyleBackColor = true;
            this.chkSadeceFavoriler.CheckedChanged += new System.EventHandler(this.chkSadeceFavoriler_CheckedChanged);
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Location = new System.Drawing.Point(68, 44);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(333, 32);
            this.txtAra.TabIndex = 5;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ara:";
            // 
            // tsmiDuzenle
            // 
            this.tsmiDuzenle.Name = "tsmiDuzenle";
            this.tsmiDuzenle.Size = new System.Drawing.Size(181, 22);
            this.tsmiDuzenle.Text = "Düzenle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.chkSadeceFavoriler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lstMesajlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Geçmiş Notlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cmsMesajlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMesajlar;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsMesajlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSil;
        private System.Windows.Forms.ToolStripMenuItem tsmiFavori;
        private System.Windows.Forms.CheckBox chkSadeceFavoriler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDuzenle;
    }
}

