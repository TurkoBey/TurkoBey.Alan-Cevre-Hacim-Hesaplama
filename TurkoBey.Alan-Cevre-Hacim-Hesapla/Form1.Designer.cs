
namespace TurkoBey.Alan_Cevre_Hacim_Hesapla
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(275, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "[ Alan ] Eş Kenar Üçgen",
            "[ Alan ] Üçgen",
            "[ Alan ] Karen",
            "[ Alan ] Dikdörtgen",
            "[ Alan ] Daire",
            "[ Alan ] Yamuk",
            "[ Çevre ] Eş Kenar Üçgen",
            "[ Çevre ] Kare",
            "[ Çevre ] Dikdörtgen",
            "[ Çevre ] Beşgen",
            "[ Çevre ] Altıgen",
            "[ Çevre ] Sekizgen",
            "[ Çevre ] Çeşitkenar Yamuk",
            "[ Çevre ] İkizkenar Yamuk",
            "[ Çevre ] Paralelkenar",
            "[ Çevre ] Eş Kenar Dikdörtgen",
            "[ Çevre ] Elips",
            "[ Hacim ] Dikdörtgenler Prizması",
            "[ Hacim ] Küp",
            "[ Hacim ] Küre",
            "[ Hacim ] Silindir",
            "[ Hacim ] Koni",
            "[ Hacim ] Kare Piramit"});
            this.listBox1.Location = new System.Drawing.Point(7, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 276);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtH);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Location = new System.Drawing.Point(291, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(71, 122);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(233, 23);
            this.txtH.TabIndex = 14;
            this.txtH.Visible = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(40, 90);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(24, 17);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "c :";
            this.Label4.Visible = false;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(71, 87);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(233, 23);
            this.txtC.TabIndex = 12;
            this.txtC.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(71, 54);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(233, 23);
            this.txtB.TabIndex = 11;
            this.txtB.Visible = false;
            this.txtB.Click += new System.EventHandler(this.txtB_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 125);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(24, 17);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "h :";
            this.Label3.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(39, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(25, 17);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "a :";
            this.Label1.Visible = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(71, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(233, 23);
            this.txtA.TabIndex = 10;
            this.txtA.Visible = false;
            this.txtA.Click += new System.EventHandler(this.txtA_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(39, 57);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(25, 17);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "b :";
            this.Label2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSonuc);
            this.groupBox3.Controls.Add(this.Label7);
            this.groupBox3.Location = new System.Drawing.Point(291, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 67);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(71, 27);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(232, 23);
            this.txtSonuc.TabIndex = 5;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 31);
            this.Label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(55, 17);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "Sonuç :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHesapla);
            this.groupBox4.Location = new System.Drawing.Point(291, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 81);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(6, 16);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(308, 55);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(622, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alan-Cevre-Hacim Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtC;
        internal System.Windows.Forms.TextBox txtB;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtA;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtSonuc;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHesapla;
        internal System.Windows.Forms.TextBox txtH;
        internal System.Windows.Forms.Label Label4;
    }
}

