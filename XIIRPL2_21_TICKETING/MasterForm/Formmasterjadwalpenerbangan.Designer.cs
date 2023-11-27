namespace XIIRPL2_21_TICKETING.MasterForm
{
    partial class Formmasterjadwalpenerbangan
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
            button2 = new Button();
            button1 = new Button();
            txtMaskapai = new ComboBox();
            txtKodePenerbangan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtKe = new ComboBox();
            txtDari = new ComboBox();
            txtTanggal = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            txtWaktuPenerbangan = new TextBox();
            txtDurasiPenerbangan = new TextBox();
            txtHargaPerTiket = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(671, 460);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 35;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(548, 460);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(159, 387);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(144, 23);
            txtMaskapai.TabIndex = 31;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(159, 295);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(144, 23);
            txtKodePenerbangan.TabIndex = 28;
            txtKodePenerbangan.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(365, 295);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 27;
            label8.Text = "Tanggal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(365, 327);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 26;
            label7.Text = "Waktu penerbangan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(44, 327);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 25;
            label6.Text = "Dari";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 356);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 24;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 387);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 23;
            label4.Text = "Maskapai";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 295);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 22;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(46, 31);
            label2.Name = "label2";
            label2.Size = new Size(294, 17);
            label2.TabIndex = 21;
            label2.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, -7);
            label1.Name = "label1";
            label1.Size = new Size(389, 39);
            label1.TabIndex = 20;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(46, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 223);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Resizable = DataGridViewTriState.True;
            BtnEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Resizable = DataGridViewTriState.True;
            BtnDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(159, 356);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(144, 23);
            txtKe.TabIndex = 36;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(159, 327);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(144, 23);
            txtDari.TabIndex = 37;
            // 
            // txtTanggal
            // 
            txtTanggal.FormattingEnabled = true;
            txtTanggal.Location = new Point(488, 295);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(144, 23);
            txtTanggal.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(365, 387);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 40;
            label10.Text = "Harga per tiket";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(365, 356);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 41;
            label11.Text = "Durasi Penerbangan";
            // 
            // txtWaktuPenerbangan
            // 
            txtWaktuPenerbangan.Location = new Point(488, 327);
            txtWaktuPenerbangan.Name = "txtWaktuPenerbangan";
            txtWaktuPenerbangan.Size = new Size(144, 23);
            txtWaktuPenerbangan.TabIndex = 42;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(488, 356);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(144, 23);
            txtDurasiPenerbangan.TabIndex = 43;
            txtDurasiPenerbangan.TextChanged += textBox3_TextChanged;
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(488, 385);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(146, 23);
            txtHargaPerTiket.TabIndex = 44;
            // 
            // Formmasterjadwalpenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 515);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(txtWaktuPenerbangan);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtTanggal);
            Controls.Add(txtDari);
            Controls.Add(txtKe);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtMaskapai);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Formmasterjadwalpenerbangan";
            Text = "Formmasterjadwalpenerbangan";
            Load += Formmasterjadwalpenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox txtMaskapai;
        private TextBox txtKodePenerbangan;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox txtKe;
        private ComboBox txtDari;
        private ComboBox txtTanggal;
        private Label label10;
        private Label label11;
        private TextBox txtWaktuPenerbangan;
        private TextBox txtDurasiPenerbangan;
        private NumericUpDown txtHargaPerTiket;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}