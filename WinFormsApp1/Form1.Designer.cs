namespace WinFormsApp1
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            checkedListBox1 = new CheckedListBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox3 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            comboBox4 = new ComboBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox5 = new ComboBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            textBox8 = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(473, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(592, 61);
            textBox1.TabIndex = 0;
            textBox1.Text = "Formulir Pendaftaran Mahasiswa \r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 225);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(254, 368);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 51);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(144, 13);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(128, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 13);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "laki_laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 31);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 254);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 7;
            label1.Text = "Nama : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 381);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 8;
            label2.Text = "Gender : ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 470);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 9;
            label3.Text = "agama :";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "islam", "kristen ", "konghucu", "katolik", "hindu" });
            comboBox1.Location = new Point(254, 470);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 33);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 524);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 11;
            label4.Text = "tanggal :";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Transparent;
            dateTimePicker1.Location = new Point(254, 518);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 337);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 13;
            label5.Text = "umur :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 716);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 15;
            label6.Text = "Olahraga favorit : ";
            label6.Click += label6_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "sepak bola", "basket ", "voli", "bulu tangkis ", "berenang ", "lari", "bersepeda ", "lain-lain" });
            checkedListBox1.Location = new Point(306, 716);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(248, 116);
            checkedListBox1.TabIndex = 16;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 429);
            label7.Name = "label7";
            label7.Size = new Size(153, 25);
            label7.TabIndex = 17;
            label7.Text = "golongan darah : ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A", "A+", "A-", "B", "B+", "B-", "O", "lain-lain" });
            comboBox2.Location = new Point(299, 429);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(255, 33);
            comboBox2.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 576);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 19;
            label8.Text = "tempat tinggal : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(144, 616);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 21;
            label9.Text = "asrama : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(254, 649);
            label10.Name = "label10";
            label10.Size = new Size(429, 42);
            label10.TabIndex = 23;
            label10.Text = "(keterangan : *outsiders memilih opsi lainnya dan bagi yang \r\nasrama pilih sesuai asrama boys dan girl*)\r\n";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "crystal", "guesthouse", "genset", "edelweis ", "jasmin ", "annex", "bougenfill", "lainnya" });
            comboBox3.Location = new Point(292, 613);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(262, 33);
            comboBox3.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(144, 689);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(155, 289);
            label12.Name = "label12";
            label12.Size = new Size(56, 25);
            label12.TabIndex = 26;
            label12.Text = "asal : ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(254, 289);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 31);
            textBox4.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(740, 254);
            label13.Name = "label13";
            label13.Size = new Size(164, 25);
            label13.TabIndex = 28;
            label13.Text = "status mahasiswa : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(712, 383);
            label14.Name = "label14";
            label14.Size = new Size(192, 25);
            label14.TabIndex = 29;
            label14.Text = "tingkat dan semester : ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(817, 437);
            label15.Name = "label15";
            label15.Size = new Size(87, 25);
            label15.TabIndex = 30;
            label15.Text = "fakultas : ";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(821, 478);
            label16.Name = "label16";
            label16.Size = new Size(83, 25);
            label16.TabIndex = 31;
            label16.Text = "jurusan : ";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(844, 295);
            label17.Name = "label17";
            label17.Size = new Size(60, 25);
            label17.TabIndex = 32;
            label17.Text = "NIM : ";
            label17.Click += label17_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(748, 337);
            label18.Name = "label18";
            label18.Size = new Size(156, 25);
            label18.TabIndex = 33;
            label18.Text = "nomor registrasi : ";
            label18.Click += label18_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "mahasiswa lama", "mahasiswa baru", "mahasiswa labor" });
            comboBox4.Location = new Point(900, 251);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(194, 33);
            comboBox4.TabIndex = 34;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(901, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(193, 31);
            textBox5.TabIndex = 35;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(904, 337);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(190, 31);
            textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(904, 383);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(190, 31);
            textBox7.TabIndex = 37;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Fakultas Ilmu Komputer", "Fakultas ekonomi dan bisnis", "Fakultas keperawatan", "Fakultas Keguruan dan ilmu keguruan", "Fakultas filsafat", "Fakultas arsitektur", "pascajarjana magister manejemen" });
            comboBox5.Location = new Point(901, 429);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(194, 33);
            comboBox5.TabIndex = 38;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(900, 478);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(193, 31);
            textBox8.TabIndex = 39;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(831, 524);
            label19.Name = "label19";
            label19.Size = new Size(73, 25);
            label19.TabIndex = 40;
            label19.Text = "no hp : ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(833, 572);
            label20.Name = "label20";
            label20.Size = new Size(71, 25);
            label20.TabIndex = 41;
            label20.Text = "Gmail : ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(712, 621);
            label21.Name = "label21";
            label21.Size = new Size(221, 25);
            label21.TabIndex = 42;
            label21.Text = "pekerjaan orang tua/wali : ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(740, 666);
            label22.Name = "label22";
            label22.Size = new Size(192, 25);
            label22.TabIndex = 43;
            label22.Text = "no hp orang tua/wali : ";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(901, 524);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(194, 31);
            textBox9.TabIndex = 44;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(899, 569);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(258, 31);
            textBox10.TabIndex = 45;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(929, 621);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(194, 31);
            textBox11.TabIndex = 46;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(929, 660);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(194, 31);
            textBox12.TabIndex = 47;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(283, 571);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 29);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "asrama";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(398, 571);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(111, 29);
            checkBox2.TabIndex = 50;
            checkBox2.Text = "outsiders";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 844);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(textBox8);
            Controls.Add(comboBox5);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(comboBox4);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBox4);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(comboBox3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(checkedListBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "form1";
            Text = "  ";
            Load += form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private CheckedListBox checkedListBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label9;
        private Label label10;
        private ComboBox comboBox3;
        private Label label11;
        private Label label12;
        private TextBox textBox4;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private ComboBox comboBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox5;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private TextBox textBox8;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
