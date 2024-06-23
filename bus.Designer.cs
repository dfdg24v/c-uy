namespace WindowsFormsApp1
{
    partial class bus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bus));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bustbl = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Supbtn = new System.Windows.Forms.Button();
            this.Modbtn = new System.Windows.Forms.Button();
            this.ajoutbtn = new System.Windows.Forms.Button();
            this.busmark = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bnumparc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bcolor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bmitrage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bnumchassi = new System.Windows.Forms.TextBox();
            this.bmatricul = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.castumer = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bustbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(62, 712);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Exit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(63, 667);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(5, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chauffeurs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(29, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 89);
            this.panel2.TabIndex = 17;
            // 
            // bustbl
            // 
            this.bustbl.BackgroundColor = System.Drawing.Color.White;
            this.bustbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bustbl.GridColor = System.Drawing.Color.IndianRed;
            this.bustbl.Location = new System.Drawing.Point(3, 364);
            this.bustbl.Name = "bustbl";
            this.bustbl.RowHeadersWidth = 62;
            this.bustbl.RowTemplate.Height = 28;
            this.bustbl.Size = new System.Drawing.Size(1011, 399);
            this.bustbl.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Supbtn
            // 
            this.Supbtn.BackColor = System.Drawing.Color.LawnGreen;
            this.Supbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supbtn.ForeColor = System.Drawing.Color.Snow;
            this.Supbtn.Location = new System.Drawing.Point(771, 287);
            this.Supbtn.Name = "Supbtn";
            this.Supbtn.Size = new System.Drawing.Size(147, 40);
            this.Supbtn.TabIndex = 22;
            this.Supbtn.Text = "Supprimer";
            this.Supbtn.UseVisualStyleBackColor = false;
            // 
            // Modbtn
            // 
            this.Modbtn.BackColor = System.Drawing.Color.Red;
            this.Modbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modbtn.ForeColor = System.Drawing.Color.Snow;
            this.Modbtn.Location = new System.Drawing.Point(427, 287);
            this.Modbtn.Name = "Modbtn";
            this.Modbtn.Size = new System.Drawing.Size(147, 40);
            this.Modbtn.TabIndex = 21;
            this.Modbtn.Text = "Modifier";
            this.Modbtn.UseVisualStyleBackColor = false;
            // 
            // ajoutbtn
            // 
            this.ajoutbtn.BackColor = System.Drawing.Color.Blue;
            this.ajoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajoutbtn.ForeColor = System.Drawing.Color.Snow;
            this.ajoutbtn.Location = new System.Drawing.Point(112, 287);
            this.ajoutbtn.Name = "ajoutbtn";
            this.ajoutbtn.Size = new System.Drawing.Size(147, 40);
            this.ajoutbtn.TabIndex = 19;
            this.ajoutbtn.Text = "Ajoutier";
            this.ajoutbtn.UseVisualStyleBackColor = false;
            this.ajoutbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // busmark
            // 
            this.busmark.BackColor = System.Drawing.Color.White;
            this.busmark.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busmark.ForeColor = System.Drawing.Color.DodgerBlue;
            this.busmark.FormattingEnabled = true;
            this.busmark.Location = new System.Drawing.Point(59, 117);
            this.busmark.Name = "busmark";
            this.busmark.Size = new System.Drawing.Size(212, 34);
            this.busmark.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(404, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Num_parc";
            // 
            // bnumparc
            // 
            this.bnumparc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnumparc.Location = new System.Drawing.Point(404, 117);
            this.bnumparc.Multiline = true;
            this.bnumparc.Name = "bnumparc";
            this.bnumparc.Size = new System.Drawing.Size(212, 34);
            this.bnumparc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(453, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "Les Bus";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bcolor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bmitrage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bnumchassi);
            this.panel1.Controls.Add(this.bmatricul);
            this.panel1.Controls.Add(this.bustbl);
            this.panel1.Controls.Add(this.Supbtn);
            this.panel1.Controls.Add(this.Modbtn);
            this.panel1.Controls.Add(this.ajoutbtn);
            this.panel1.Controls.Add(this.busmark);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bnumparc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(160, 12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1017, 766);
            this.panel1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(59, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "Mark";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(743, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 26);
            this.label11.TabIndex = 31;
            this.label11.Text = "Matricul";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(743, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "color";
            // 
            // bcolor
            // 
            this.bcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcolor.Location = new System.Drawing.Point(743, 213);
            this.bcolor.Name = "bcolor";
            this.bcolor.Size = new System.Drawing.Size(212, 35);
            this.bcolor.TabIndex = 29;
            this.bcolor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(404, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kilomètrage";
            // 
            // bmitrage
            // 
            this.bmitrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmitrage.Location = new System.Drawing.Point(404, 213);
            this.bmitrage.Name = "bmitrage";
            this.bmitrage.Size = new System.Drawing.Size(212, 35);
            this.bmitrage.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(59, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Num_chassis";
            // 
            // bnumchassi
            // 
            this.bnumchassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnumchassi.Location = new System.Drawing.Point(59, 213);
            this.bnumchassi.Name = "bnumchassi";
            this.bnumchassi.Size = new System.Drawing.Size(212, 35);
            this.bnumchassi.TabIndex = 25;
            this.bnumchassi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bmatricul
            // 
            this.bmatricul.BackColor = System.Drawing.Color.White;
            this.bmatricul.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmatricul.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bmatricul.FormattingEnabled = true;
            this.bmatricul.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.bmatricul.Location = new System.Drawing.Point(743, 117);
            this.bmatricul.Name = "bmatricul";
            this.bmatricul.Size = new System.Drawing.Size(212, 34);
            this.bmatricul.TabIndex = 24;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(45, 200);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(50, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Les Bus";
            // 
            // castumer
            // 
            this.castumer.AutoSize = true;
            this.castumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castumer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.castumer.Location = new System.Drawing.Point(12, 249);
            this.castumer.Name = "castumer";
            this.castumer.Size = new System.Drawing.Size(142, 20);
            this.castumer.TabIndex = 20;
            this.castumer.Text = "maint-Prèvontive";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(63, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(63, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(63, 365);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(3, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dommand dintvan";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(63, 463);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(47, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "bon_Travil";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(63, 562);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(60, 60);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 29;
            this.pictureBox8.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(47, 625);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Dashboard";
            // 
            // bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 813);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.castumer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bustbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView bustbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Supbtn;
        private System.Windows.Forms.Button Modbtn;
        private System.Windows.Forms.Button ajoutbtn;
        private System.Windows.Forms.ComboBox busmark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bnumparc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label castumer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bmatricul;
        private System.Windows.Forms.TextBox bnumchassi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bcolor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bmitrage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label13;
    }
}