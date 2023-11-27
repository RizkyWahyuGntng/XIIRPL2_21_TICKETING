namespace XIIRPL2_21_TICKETING.MasterForm
{
    partial class Formkodepromo
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
            txtkodepromo = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtmaksimumdskon = new NumericUpDown();
            txtpersentasedskon = new NumericUpDown();
            txtdeskripsi = new TextBox();
            txtberlakusmpai = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtmaksimumdskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtpersentasedskon).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(647, 452);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 57;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(538, 452);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 56;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtkodepromo
            // 
            txtkodepromo.Location = new Point(254, 310);
            txtkodepromo.Name = "txtkodepromo";
            txtkodepromo.Size = new Size(144, 23);
            txtkodepromo.TabIndex = 54;
            txtkodepromo.TextChanged += txtkodepromo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(460, 310);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 53;
            label8.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(137, 342);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 51;
            label6.Text = "Berlaku Sampai";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(137, 371);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 50;
            label5.Text = "Persentase Diskon";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(137, 402);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 49;
            label4.Text = "Maksimum Diskon";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(137, 310);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 48;
            label3.Text = "KodePromo";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(137, 46);
            label2.Name = "label2";
            label2.Size = new Size(332, 17);
            label2.TabIndex = 47;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 8);
            label1.Name = "label1";
            label1.Size = new Size(282, 39);
            label1.TabIndex = 46;
            label1.Text = "Master Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(141, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 223);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
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
            // txtmaksimumdskon
            // 
            txtmaksimumdskon.Location = new Point(254, 400);
            txtmaksimumdskon.Name = "txtmaksimumdskon";
            txtmaksimumdskon.Size = new Size(146, 23);
            txtmaksimumdskon.TabIndex = 66;
            // 
            // txtpersentasedskon
            // 
            txtpersentasedskon.Location = new Point(254, 371);
            txtpersentasedskon.Name = "txtpersentasedskon";
            txtpersentasedskon.Size = new Size(146, 23);
            txtpersentasedskon.TabIndex = 67;
            // 
            // txtdeskripsi
            // 
            txtdeskripsi.Location = new Point(527, 310);
            txtdeskripsi.Multiline = true;
            txtdeskripsi.Name = "txtdeskripsi";
            txtdeskripsi.Size = new Size(176, 107);
            txtdeskripsi.TabIndex = 68;
            // 
            // txtberlakusmpai
            // 
            txtberlakusmpai.Location = new Point(254, 342);
            txtberlakusmpai.Name = "txtberlakusmpai";
            txtberlakusmpai.Size = new Size(144, 23);
            txtberlakusmpai.TabIndex = 69;
            txtberlakusmpai.ValueChanged += txtberlakusmpai_ValueChanged;
            // 
            // Formkodepromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 507);
            Controls.Add(txtberlakusmpai);
            Controls.Add(txtdeskripsi);
            Controls.Add(txtpersentasedskon);
            Controls.Add(txtmaksimumdskon);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtkodepromo);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Formkodepromo";
            Text = "Formkodepromo";
            Load += Formkodepromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtmaksimumdskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtpersentasedskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private TextBox txtkodepromo;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private NumericUpDown txtmaksimumdskon;
        private NumericUpDown txtpersentasedskon;
        private TextBox txtdeskripsi;
        private DateTimePicker txtberlakusmpai;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}