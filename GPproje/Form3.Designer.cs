namespace GPproje
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            hsgldntext = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
           // timer1.Interval = 30;
            //timer1.Tick += timer1_Tick;
            // 
            // hsgldntext
            // 
            hsgldntext.BackColor = Color.Transparent;
            hsgldntext.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            hsgldntext.Location = new Point(313, 48);
            hsgldntext.Name = "hsgldntext";
            hsgldntext.Size = new Size(254, 58);
            hsgldntext.TabIndex = 0;
            hsgldntext.Text = "Hoşgeldin,";
            hsgldntext.TextAlign = ContentAlignment.MiddleCenter;
            hsgldntext.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(281, 106);
            label1.Name = "label1";
            label1.Size = new Size(348, 25);
            label1.TabIndex = 1;
            label1.Text = "Seni aramızda görmek büyük bir mutluluk!";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(264, 142);
            label2.Name = "label2";
            label2.Size = new Size(386, 50);
            label2.TabIndex = 2;
            label2.Text = "Bugünün hikayesini birlikte seçmeye ne dersin ?\r\nHaydi gel!\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(295, 204);
            label3.Name = "label3";
            label3.Size = new Size(304, 25);
            label3.TabIndex = 3;
            label3.Text = "Bugün kendini nasıl hissediyorsun?\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_grinning_face_94;
            pictureBox1.Location = new Point(197, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icons8_neutral_face_94;
            pictureBox2.Location = new Point(334, 264);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.icons8_pleading_face_94;
            pictureBox3.Location = new Point(473, 264);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.icons8_face_with_steam_from_nose_94;
            pictureBox4.Location = new Point(621, 264);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 94);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 504);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hsgldntext);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label hsgldntext;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}