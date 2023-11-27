namespace XIIRPL2_21_TICKETING.MasterForm
{
    partial class Tiket_saya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiket_saya));
            label7 = new Label();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 50);
            label7.Name = "label7";
            label7.Size = new Size(227, 15);
            label7.TabIndex = 21;
            label7.Text = "Semua tiket yang aktif akan muncul disini";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(15, 16);
            button2.Name = "button2";
            button2.Size = new Size(33, 28);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 13);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 19;
            label1.Text = "Detail Penerbangan";
            // 
            // panel1
            // 
            panel1.Location = new Point(25, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 339);
            panel1.TabIndex = 22;
            // 
            // Tiket_saya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Tiket_saya";
            Text = "Tiket_saya";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button button2;
        private Label label1;
        private Panel panel1;
    }
}