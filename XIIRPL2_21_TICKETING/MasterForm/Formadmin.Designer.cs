namespace XIIRPL2_21_TICKETING.MasterForm
{
    partial class Formadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formadmin));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button5 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 104);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 44);
            label1.Name = "label1";
            label1.Size = new Size(184, 34);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(15, 25);
            button1.Name = "button1";
            button1.Size = new Size(88, 62);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Sitka Small", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1, 366);
            button5.Name = "button5";
            button5.Size = new Size(208, 68);
            button5.TabIndex = 2;
            button5.Text = "                 Ubah Status Terbang";
            button5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(-72, 180);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(18, 10);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Small", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 67);
            button2.Name = "button2";
            button2.Size = new Size(208, 68);
            button2.TabIndex = 2;
            button2.Text = "            Master  Maskapai";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Sitka Small", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 199);
            button4.Name = "button4";
            button4.Size = new Size(208, 68);
            button4.TabIndex = 4;
            button4.Text = "             Master   \r\n  Promo";
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Sitka Small", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(208, 68);
            button6.TabIndex = 5;
            button6.Text = "                 Master Bandara";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(-3, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 459);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 407);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 27);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(46, 409);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LOGOUT";
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Small", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 132);
            button3.Name = "button3";
            button3.Size = new Size(208, 68);
            button3.TabIndex = 3;
            button3.Text = "                 Jadwal            penerbangan";
            button3.UseVisualStyleBackColor = true;
            // 
            // Formadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1010, 566);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Formadmin";
            Text = "Formadmin";
            Load += Formadmin_Load_2;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button4;
        private Button button6;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Button button3;
        private PictureBox pictureBox1;
    }
}