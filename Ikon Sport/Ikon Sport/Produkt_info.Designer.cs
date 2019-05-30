namespace Ikon_Sport
{
    partial class Produkt_info
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
            this.SidebarPN = new System.Windows.Forms.Panel();
            this.LogudBTN = new System.Windows.Forms.Button();
            this.MedlemBTN = new System.Windows.Forms.Button();
            this.OrdreBTN = new System.Windows.Forms.Button();
            this.BrandPAN = new System.Windows.Forms.Panel();
            this.LogoLB = new System.Windows.Forms.Label();
            this.ProduktDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VisKunCB = new System.Windows.Forms.ComboBox();
            this.SidebarPN.SuspendLayout();
            this.BrandPAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarPN
            // 
            this.SidebarPN.Controls.Add(this.LogudBTN);
            this.SidebarPN.Controls.Add(this.MedlemBTN);
            this.SidebarPN.Controls.Add(this.OrdreBTN);
            this.SidebarPN.Controls.Add(this.BrandPAN);
            this.SidebarPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPN.Location = new System.Drawing.Point(0, 0);
            this.SidebarPN.Name = "SidebarPN";
            this.SidebarPN.Size = new System.Drawing.Size(250, 749);
            this.SidebarPN.TabIndex = 12;
            // 
            // LogudBTN
            // 
            this.LogudBTN.Location = new System.Drawing.Point(-1, 623);
            this.LogudBTN.Name = "LogudBTN";
            this.LogudBTN.Size = new System.Drawing.Size(249, 126);
            this.LogudBTN.TabIndex = 4;
            this.LogudBTN.Text = "LOG UD";
            this.LogudBTN.UseVisualStyleBackColor = true;
            this.LogudBTN.Click += new System.EventHandler(this.LogudBTN_Click);
            // 
            // MedlemBTN
            // 
            this.MedlemBTN.Location = new System.Drawing.Point(0, 223);
            this.MedlemBTN.Name = "MedlemBTN";
            this.MedlemBTN.Size = new System.Drawing.Size(249, 126);
            this.MedlemBTN.TabIndex = 3;
            this.MedlemBTN.Text = "OPRET MEDLEM";
            this.MedlemBTN.UseVisualStyleBackColor = true;
            this.MedlemBTN.Click += new System.EventHandler(this.MedlemBTN_Click);
            // 
            // OrdreBTN
            // 
            this.OrdreBTN.Location = new System.Drawing.Point(0, 100);
            this.OrdreBTN.Name = "OrdreBTN";
            this.OrdreBTN.Size = new System.Drawing.Size(249, 126);
            this.OrdreBTN.TabIndex = 2;
            this.OrdreBTN.Text = "OPRET ORDRE";
            this.OrdreBTN.UseVisualStyleBackColor = true;
            // 
            // BrandPAN
            // 
            this.BrandPAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(81)))), ((int)(((byte)(118)))));
            this.BrandPAN.Controls.Add(this.LogoLB);
            this.BrandPAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrandPAN.Location = new System.Drawing.Point(0, 0);
            this.BrandPAN.Name = "BrandPAN";
            this.BrandPAN.Size = new System.Drawing.Size(250, 100);
            this.BrandPAN.TabIndex = 0;
            // 
            // LogoLB
            // 
            this.LogoLB.AutoSize = true;
            this.LogoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLB.ForeColor = System.Drawing.Color.White;
            this.LogoLB.Location = new System.Drawing.Point(12, 29);
            this.LogoLB.Name = "LogoLB";
            this.LogoLB.Size = new System.Drawing.Size(223, 37);
            this.LogoLB.TabIndex = 0;
            this.LogoLB.Text = "IKON SPORT";
            // 
            // ProduktDGV
            // 
            this.ProduktDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProduktDGV.Location = new System.Drawing.Point(593, 12);
            this.ProduktDGV.Name = "ProduktDGV";
            this.ProduktDGV.RowTemplate.Height = 28;
            this.ProduktDGV.Size = new System.Drawing.Size(561, 725);
            this.ProduktDGV.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Produkt information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(273, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vis kun";
            // 
            // VisKunCB
            // 
            this.VisKunCB.FormattingEnabled = true;
            this.VisKunCB.Location = new System.Drawing.Point(356, 150);
            this.VisKunCB.Name = "VisKunCB";
            this.VisKunCB.Size = new System.Drawing.Size(184, 28);
            this.VisKunCB.TabIndex = 17;
            // 
            // Produkt_info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1166, 749);
            this.Controls.Add(this.VisKunCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProduktDGV);
            this.Controls.Add(this.SidebarPN);
            this.Name = "Produkt_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordre";
            this.Load += new System.EventHandler(this.Ordre_Load);
            this.SidebarPN.ResumeLayout(false);
            this.BrandPAN.ResumeLayout(false);
            this.BrandPAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPN;
        private System.Windows.Forms.Button LogudBTN;
        private System.Windows.Forms.Button MedlemBTN;
        private System.Windows.Forms.Button OrdreBTN;
        private System.Windows.Forms.Panel BrandPAN;
        private System.Windows.Forms.Label LogoLB;
        private System.Windows.Forms.DataGridView ProduktDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VisKunCB;
    }
}