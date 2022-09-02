namespace _11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSeviye = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_liste = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.matDogru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.matYanlis = new System.Windows.Forms.TextBox();
            this.turkceDogru = new System.Windows.Forms.TextBox();
            this.turkceYanlis = new System.Windows.Forms.TextBox();
            this.button_yenihesap = new System.Windows.Forms.Button();
            this.sosyalDogru = new System.Windows.Forms.TextBox();
            this.toplamNet = new System.Windows.Forms.Label();
            this.sosyalYanlis = new System.Windows.Forms.TextBox();
            this.toplamDogru = new System.Windows.Forms.Label();
            this.fenDogru = new System.Windows.Forms.TextBox();
            this.toplamYanlis = new System.Windows.Forms.Label();
            this.fenYanlis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_hesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sonucFen = new System.Windows.Forms.Label();
            this.sonucMat = new System.Windows.Forms.Label();
            this.sonucSosyal = new System.Windows.Forms.Label();
            this.sonucTurkce = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(-13, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(752, 483);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "--------------------------NET HESAPLAMA UYGULAMASI------------------------------";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.txtSeviye);
            this.groupBox3.Controls.Add(this.txtAd);
            this.groupBox3.Controls.Add(this.txtNo);
            this.groupBox3.Controls.Add(this.txtSoyad);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(24, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 191);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÖĞRENCİ";
            // 
            // txtSeviye
            // 
            this.txtSeviye.BackColor = System.Drawing.Color.Silver;
            this.txtSeviye.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeviye.ForeColor = System.Drawing.Color.Black;
            this.txtSeviye.FormattingEnabled = true;
            this.txtSeviye.Items.AddRange(new object[] {
            "Mezun",
            "Lise",
            "Ortaokul",
            "İlkokul"});
            this.txtSeviye.Location = new System.Drawing.Point(121, 140);
            this.txtSeviye.Name = "txtSeviye";
            this.txtSeviye.Size = new System.Drawing.Size(101, 29);
            this.txtSeviye.TabIndex = 33;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Silver;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Location = new System.Drawing.Point(121, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(101, 29);
            this.txtAd.TabIndex = 30;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Silver;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.Location = new System.Drawing.Point(121, 70);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(101, 29);
            this.txtSoyad.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(70, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 28);
            this.label16.TabIndex = 34;
            this.label16.Text = "Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(37, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 28);
            this.label13.TabIndex = 37;
            this.label13.Text = "Seviyesi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(45, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 28);
            this.label15.TabIndex = 35;
            this.label15.Text = "Soyadı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightGray;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(21, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 28);
            this.label14.TabIndex = 36;
            this.label14.Text = "Numarası:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_liste);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.matDogru);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.matYanlis);
            this.groupBox2.Controls.Add(this.turkceDogru);
            this.groupBox2.Controls.Add(this.turkceYanlis);
            this.groupBox2.Controls.Add(this.button_yenihesap);
            this.groupBox2.Controls.Add(this.sosyalDogru);
            this.groupBox2.Controls.Add(this.toplamNet);
            this.groupBox2.Controls.Add(this.sosyalYanlis);
            this.groupBox2.Controls.Add(this.toplamDogru);
            this.groupBox2.Controls.Add(this.fenDogru);
            this.groupBox2.Controls.Add(this.toplamYanlis);
            this.groupBox2.Controls.Add(this.fenYanlis);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button_hesapla);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sonucFen);
            this.groupBox2.Controls.Add(this.sonucMat);
            this.groupBox2.Controls.Add(this.sonucSosyal);
            this.groupBox2.Controls.Add(this.sonucTurkce);
            this.groupBox2.Location = new System.Drawing.Point(379, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 434);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematik:";
            // 
            // button_liste
            // 
            this.button_liste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_liste.Enabled = false;
            this.button_liste.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_liste.ForeColor = System.Drawing.Color.White;
            this.button_liste.Location = new System.Drawing.Point(10, 368);
            this.button_liste.Name = "button_liste";
            this.button_liste.Size = new System.Drawing.Size(166, 50);
            this.button_liste.TabIndex = 41;
            this.button_liste.Text = "LİSTEYE KAYDET";
            this.button_liste.UseVisualStyleBackColor = false;
            this.button_liste.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sosyal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fen:";
            // 
            // matDogru
            // 
            this.matDogru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.matDogru.Enabled = false;
            this.matDogru.ForeColor = System.Drawing.Color.White;
            this.matDogru.Location = new System.Drawing.Point(124, 61);
            this.matDogru.Name = "matDogru";
            this.matDogru.Size = new System.Drawing.Size(44, 29);
            this.matDogru.TabIndex = 4;
            this.matDogru.TextChanged += new System.EventHandler(this.matDogru_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(133, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(182, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y";
            // 
            // matYanlis
            // 
            this.matYanlis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.matYanlis.Enabled = false;
            this.matYanlis.ForeColor = System.Drawing.Color.White;
            this.matYanlis.Location = new System.Drawing.Point(170, 61);
            this.matYanlis.Multiline = true;
            this.matYanlis.Name = "matYanlis";
            this.matYanlis.Size = new System.Drawing.Size(44, 29);
            this.matYanlis.TabIndex = 7;
            this.matYanlis.TextChanged += new System.EventHandler(this.matYanlis_TextChanged);
            // 
            // turkceDogru
            // 
            this.turkceDogru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.turkceDogru.Enabled = false;
            this.turkceDogru.ForeColor = System.Drawing.Color.White;
            this.turkceDogru.Location = new System.Drawing.Point(124, 97);
            this.turkceDogru.Name = "turkceDogru";
            this.turkceDogru.Size = new System.Drawing.Size(44, 29);
            this.turkceDogru.TabIndex = 8;
            this.turkceDogru.TextChanged += new System.EventHandler(this.turkceDogru_TextChanged);
            // 
            // turkceYanlis
            // 
            this.turkceYanlis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.turkceYanlis.Enabled = false;
            this.turkceYanlis.ForeColor = System.Drawing.Color.White;
            this.turkceYanlis.Location = new System.Drawing.Point(170, 97);
            this.turkceYanlis.Name = "turkceYanlis";
            this.turkceYanlis.Size = new System.Drawing.Size(44, 29);
            this.turkceYanlis.TabIndex = 9;
            this.turkceYanlis.TextChanged += new System.EventHandler(this.turkceYanlis_TextChanged);
            // 
            // button_yenihesap
            // 
            this.button_yenihesap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_yenihesap.Enabled = false;
            this.button_yenihesap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button_yenihesap.ForeColor = System.Drawing.Color.White;
            this.button_yenihesap.Location = new System.Drawing.Point(182, 318);
            this.button_yenihesap.Name = "button_yenihesap";
            this.button_yenihesap.Size = new System.Drawing.Size(155, 44);
            this.button_yenihesap.TabIndex = 29;
            this.button_yenihesap.Text = "NET HESAPLA";
            this.button_yenihesap.UseVisualStyleBackColor = false;
            this.button_yenihesap.Click += new System.EventHandler(this.button_yenihesap_Click);
            // 
            // sosyalDogru
            // 
            this.sosyalDogru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sosyalDogru.Enabled = false;
            this.sosyalDogru.ForeColor = System.Drawing.Color.White;
            this.sosyalDogru.Location = new System.Drawing.Point(124, 132);
            this.sosyalDogru.Name = "sosyalDogru";
            this.sosyalDogru.Size = new System.Drawing.Size(44, 29);
            this.sosyalDogru.TabIndex = 10;
            this.sosyalDogru.TextChanged += new System.EventHandler(this.sosyalDogru_TextChanged);
            // 
            // toplamNet
            // 
            this.toplamNet.AutoSize = true;
            this.toplamNet.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamNet.Location = new System.Drawing.Point(151, 277);
            this.toplamNet.Name = "toplamNet";
            this.toplamNet.Size = new System.Drawing.Size(19, 23);
            this.toplamNet.TabIndex = 28;
            this.toplamNet.Text = "x";
            this.toplamNet.Visible = false;
            // 
            // sosyalYanlis
            // 
            this.sosyalYanlis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sosyalYanlis.Enabled = false;
            this.sosyalYanlis.ForeColor = System.Drawing.Color.White;
            this.sosyalYanlis.Location = new System.Drawing.Point(170, 132);
            this.sosyalYanlis.Name = "sosyalYanlis";
            this.sosyalYanlis.Size = new System.Drawing.Size(44, 29);
            this.sosyalYanlis.TabIndex = 11;
            this.sosyalYanlis.TextChanged += new System.EventHandler(this.sosyalYanlis_TextChanged);
            // 
            // toplamDogru
            // 
            this.toplamDogru.AutoSize = true;
            this.toplamDogru.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamDogru.Location = new System.Drawing.Point(151, 216);
            this.toplamDogru.Name = "toplamDogru";
            this.toplamDogru.Size = new System.Drawing.Size(19, 23);
            this.toplamDogru.TabIndex = 27;
            this.toplamDogru.Text = "x";
            this.toplamDogru.Visible = false;
            // 
            // fenDogru
            // 
            this.fenDogru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fenDogru.Enabled = false;
            this.fenDogru.ForeColor = System.Drawing.Color.White;
            this.fenDogru.Location = new System.Drawing.Point(124, 167);
            this.fenDogru.Name = "fenDogru";
            this.fenDogru.Size = new System.Drawing.Size(44, 29);
            this.fenDogru.TabIndex = 12;
            this.fenDogru.TextChanged += new System.EventHandler(this.fenDogru_TextChanged);
            // 
            // toplamYanlis
            // 
            this.toplamYanlis.AutoSize = true;
            this.toplamYanlis.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamYanlis.Location = new System.Drawing.Point(152, 246);
            this.toplamYanlis.Name = "toplamYanlis";
            this.toplamYanlis.Size = new System.Drawing.Size(19, 23);
            this.toplamYanlis.TabIndex = 26;
            this.toplamYanlis.Text = "x";
            this.toplamYanlis.Visible = false;
            // 
            // fenYanlis
            // 
            this.fenYanlis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fenYanlis.Enabled = false;
            this.fenYanlis.ForeColor = System.Drawing.Color.White;
            this.fenYanlis.Location = new System.Drawing.Point(170, 167);
            this.fenYanlis.Name = "fenYanlis";
            this.fenYanlis.Size = new System.Drawing.Size(44, 29);
            this.fenYanlis.TabIndex = 13;
            this.fenYanlis.TextChanged += new System.EventHandler(this.fenYanlis_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightBlue;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Toplam Net:    ";
            this.label12.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(220, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Net:";
            this.label7.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Toplam Yanlış: ";
            this.label11.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(220, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Net:";
            this.label8.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.LightBlue;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(15, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 23);
            this.label17.TabIndex = 23;
            this.label17.Text = "Toplam Doğru:";
            this.label17.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(220, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Net:";
            this.label9.Visible = false;
            // 
            // button_hesapla
            // 
            this.button_hesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_hesapla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hesapla.ForeColor = System.Drawing.Color.White;
            this.button_hesapla.Location = new System.Drawing.Point(9, 318);
            this.button_hesapla.Name = "button_hesapla";
            this.button_hesapla.Size = new System.Drawing.Size(167, 44);
            this.button_hesapla.TabIndex = 14;
            this.button_hesapla.Text = "ÖĞRENCİYİ KAYDET";
            this.button_hesapla.UseVisualStyleBackColor = false;
            this.button_hesapla.Click += new System.EventHandler(this.button_hesapla_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(220, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Net:";
            this.label10.Visible = false;
            // 
            // sonucFen
            // 
            this.sonucFen.AutoSize = true;
            this.sonucFen.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucFen.ForeColor = System.Drawing.Color.Black;
            this.sonucFen.Location = new System.Drawing.Point(270, 170);
            this.sonucFen.Name = "sonucFen";
            this.sonucFen.Size = new System.Drawing.Size(19, 23);
            this.sonucFen.TabIndex = 22;
            this.sonucFen.Text = "x";
            this.sonucFen.Visible = false;
            // 
            // sonucMat
            // 
            this.sonucMat.AutoSize = true;
            this.sonucMat.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucMat.ForeColor = System.Drawing.Color.Black;
            this.sonucMat.Location = new System.Drawing.Point(270, 64);
            this.sonucMat.Name = "sonucMat";
            this.sonucMat.Size = new System.Drawing.Size(19, 23);
            this.sonucMat.TabIndex = 19;
            this.sonucMat.Text = "x";
            this.sonucMat.Visible = false;
            // 
            // sonucSosyal
            // 
            this.sonucSosyal.AutoSize = true;
            this.sonucSosyal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucSosyal.ForeColor = System.Drawing.Color.Black;
            this.sonucSosyal.Location = new System.Drawing.Point(270, 135);
            this.sonucSosyal.Name = "sonucSosyal";
            this.sonucSosyal.Size = new System.Drawing.Size(19, 23);
            this.sonucSosyal.TabIndex = 21;
            this.sonucSosyal.Text = "x";
            this.sonucSosyal.Visible = false;
            // 
            // sonucTurkce
            // 
            this.sonucTurkce.AutoSize = true;
            this.sonucTurkce.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucTurkce.ForeColor = System.Drawing.Color.Black;
            this.sonucTurkce.Location = new System.Drawing.Point(270, 100);
            this.sonucTurkce.Name = "sonucTurkce";
            this.sonucTurkce.Size = new System.Drawing.Size(19, 23);
            this.sonucTurkce.TabIndex = 20;
            this.sonucTurkce.Text = "x";
            this.sonucTurkce.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Silver;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(344, 244);
            this.listBox1.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(182, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 42;
            this.button1.Text = "YENİ NET HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.Silver;
            this.txtNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.ForeColor = System.Drawing.Color.Black;
            this.txtNo.Location = new System.Drawing.Point(121, 105);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(101, 29);
            this.txtNo.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 480);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_hesapla;
        private System.Windows.Forms.TextBox fenYanlis;
        private System.Windows.Forms.TextBox fenDogru;
        private System.Windows.Forms.TextBox sosyalYanlis;
        private System.Windows.Forms.TextBox sosyalDogru;
        private System.Windows.Forms.TextBox turkceYanlis;
        private System.Windows.Forms.TextBox turkceDogru;
        private System.Windows.Forms.TextBox matYanlis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox matDogru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtSeviye;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button button_yenihesap;
        private System.Windows.Forms.Label toplamNet;
        private System.Windows.Forms.Label toplamDogru;
        private System.Windows.Forms.Label toplamYanlis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label sonucFen;
        private System.Windows.Forms.Label sonucSosyal;
        private System.Windows.Forms.Label sonucTurkce;
        private System.Windows.Forms.Label sonucMat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_liste;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNo;
    }
}

