namespace Yurt_Kayıt_Program
{
    partial class borc
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
            this.ogrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamborc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanborc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrid,
            this.odano,
            this.ogradsoyad,
            this.toplamborc,
            this.kalanborc});
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogrid
            // 
            this.ogrid.DataPropertyName = "ogrid";
            this.ogrid.HeaderText = "Öğrenci Numarası";
            this.ogrid.Name = "ogrid";
            this.ogrid.ReadOnly = true;
            this.ogrid.Width = 80;
            // 
            // odano
            // 
            this.odano.DataPropertyName = "odano";
            this.odano.HeaderText = "Oda Numarası";
            this.odano.Name = "odano";
            this.odano.ReadOnly = true;
            this.odano.Width = 80;
            // 
            // ogradsoyad
            // 
            this.ogradsoyad.DataPropertyName = "ogradsoyad";
            this.ogradsoyad.HeaderText = "Öğrenci Adı Soyadı";
            this.ogradsoyad.Name = "ogradsoyad";
            this.ogradsoyad.ReadOnly = true;
            this.ogradsoyad.Width = 140;
            // 
            // toplamborc
            // 
            this.toplamborc.DataPropertyName = "toplamborc";
            this.toplamborc.HeaderText = "Toplam Borç";
            this.toplamborc.Name = "toplamborc";
            this.toplamborc.ReadOnly = true;
            // 
            // kalanborc
            // 
            this.kalanborc.DataPropertyName = "kalanborc";
            this.kalanborc.HeaderText = "Kalan Borç";
            this.kalanborc.Name = "kalanborc";
            this.kalanborc.ReadOnly = true;
            // 
            // borc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 340);
            this.Controls.Add(this.dataGridView1);
            this.Name = "borc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borç Bilgileri";
            this.Load += new System.EventHandler(this.borc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn odano;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamborc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanborc;
    }
}