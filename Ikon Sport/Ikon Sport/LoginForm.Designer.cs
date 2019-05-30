namespace Ikon_Sport
{
    partial class IkonSportForm
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
            this.ExitBTN = new System.Windows.Forms.Button();
            this.BrandPAN = new System.Windows.Forms.Panel();
            this.LogoLB = new System.Windows.Forms.Label();
            this.KodeLB = new System.Windows.Forms.Label();
            this.KodeTB = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.NytLogin = new System.Windows.Forms.Button();
            this.TestLabel = new System.Windows.Forms.Label();
            this.brugernavnTB = new System.Windows.Forms.TextBox();
            this.BrugernavnLB = new System.Windows.Forms.Label();
            this.LoginLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.snydBTN = new System.Windows.Forms.Button();
            this.SidebarPN.SuspendLayout();
            this.BrandPAN.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarPN
            // 
            this.SidebarPN.Controls.Add(this.ExitBTN);
            this.SidebarPN.Controls.Add(this.BrandPAN);
            this.SidebarPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPN.Location = new System.Drawing.Point(0, 0);
            this.SidebarPN.Name = "SidebarPN";
            this.SidebarPN.Size = new System.Drawing.Size(250, 750);
            this.SidebarPN.TabIndex = 0;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(0, 626);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(250, 124);
            this.ExitBTN.TabIndex = 1;
            this.ExitBTN.Text = "EXIT";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
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
            // KodeLB
            // 
            this.KodeLB.AutoSize = true;
            this.KodeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeLB.ForeColor = System.Drawing.Color.White;
            this.KodeLB.Location = new System.Drawing.Point(85, 157);
            this.KodeLB.Name = "KodeLB";
            this.KodeLB.Size = new System.Drawing.Size(71, 29);
            this.KodeLB.TabIndex = 9;
            this.KodeLB.Text = "Kode";
            // 
            // KodeTB
            // 
            this.KodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeTB.Location = new System.Drawing.Point(162, 154);
            this.KodeTB.Name = "KodeTB";
            this.KodeTB.PasswordChar = '*';
            this.KodeTB.Size = new System.Drawing.Size(498, 35);
            this.KodeTB.TabIndex = 3;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(293, 238);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(226, 66);
            this.LoginBTN.TabIndex = 6;
            this.LoginBTN.Text = "Enter";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // NytLogin
            // 
            this.NytLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NytLogin.FlatAppearance.BorderSize = 0;
            this.NytLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NytLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NytLogin.ForeColor = System.Drawing.Color.Cyan;
            this.NytLogin.Location = new System.Drawing.Point(303, 195);
            this.NytLogin.Name = "NytLogin";
            this.NytLogin.Size = new System.Drawing.Size(204, 37);
            this.NytLogin.TabIndex = 7;
            this.NytLogin.Text = "Nyt login";
            this.NytLogin.UseVisualStyleBackColor = true;
            this.NytLogin.Click += new System.EventHandler(this.NytLogin_Click);
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestLabel.ForeColor = System.Drawing.Color.White;
            this.TestLabel.Location = new System.Drawing.Point(157, 73);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(0, 29);
            this.TestLabel.TabIndex = 10;
            // 
            // brugernavnTB
            // 
            this.brugernavnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brugernavnTB.Location = new System.Drawing.Point(162, 106);
            this.brugernavnTB.Name = "brugernavnTB";
            this.brugernavnTB.Size = new System.Drawing.Size(498, 35);
            this.brugernavnTB.TabIndex = 2;
            // 
            // BrugernavnLB
            // 
            this.BrugernavnLB.AutoSize = true;
            this.BrugernavnLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrugernavnLB.ForeColor = System.Drawing.Color.White;
            this.BrugernavnLB.Location = new System.Drawing.Point(20, 109);
            this.BrugernavnLB.Name = "BrugernavnLB";
            this.BrugernavnLB.Size = new System.Drawing.Size(136, 29);
            this.BrugernavnLB.TabIndex = 8;
            this.BrugernavnLB.Text = "Brugernavn";
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLB.ForeColor = System.Drawing.Color.White;
            this.LoginLB.Location = new System.Drawing.Point(350, 23);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(138, 40);
            this.LoginLB.TabIndex = 5;
            this.LoginLB.Text = "LOG IN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.snydBTN);
            this.panel1.Controls.Add(this.NytLogin);
            this.panel1.Controls.Add(this.LoginLB);
            this.panel1.Controls.Add(this.BrugernavnLB);
            this.panel1.Controls.Add(this.KodeLB);
            this.panel1.Controls.Add(this.KodeTB);
            this.panel1.Controls.Add(this.LoginBTN);
            this.panel1.Controls.Add(this.TestLabel);
            this.panel1.Controls.Add(this.brugernavnTB);
            this.panel1.Location = new System.Drawing.Point(280, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 451);
            this.panel1.TabIndex = 11;
            // 
            // snydBTN
            // 
            this.snydBTN.Location = new System.Drawing.Point(318, 310);
            this.snydBTN.Name = "snydBTN";
            this.snydBTN.Size = new System.Drawing.Size(179, 63);
            this.snydBTN.TabIndex = 11;
            this.snydBTN.Text = "Snyd";
            this.snydBTN.UseVisualStyleBackColor = true;
            this.snydBTN.Click += new System.EventHandler(this.SnydBTN_Click);
            // 
            // IkonSportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1237, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidebarPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IkonSportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SidebarPN.ResumeLayout(false);
            this.BrandPAN.ResumeLayout(false);
            this.BrandPAN.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPN;
        private System.Windows.Forms.Panel BrandPAN;
        private System.Windows.Forms.Label LogoLB;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label KodeLB;
        private System.Windows.Forms.TextBox KodeTB;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button NytLogin;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.TextBox brugernavnTB;
        private System.Windows.Forms.Label BrugernavnLB;
        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button snydBTN;
    }
}

