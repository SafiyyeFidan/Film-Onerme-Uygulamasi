namespace GPproje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            timer1 = new System.Windows.Forms.Timer(components);
            girisİsimLbl = new Label();
            girisSifrelbl = new Label();
            girisİsimtextbox = new TextBox();
            girisSifretextbox = new TextBox();
            giristextbox = new Button();
            checkBox1 = new CheckBox();
            label7 = new Label();
            button7 = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // girisİsimLbl
            // 
            girisİsimLbl.AutoSize = true;
            girisİsimLbl.BackColor = Color.Transparent;
            girisİsimLbl.Location = new Point(216, 109);
            girisİsimLbl.Name = "girisİsimLbl";
            girisİsimLbl.Size = new Size(99, 20);
            girisİsimLbl.TabIndex = 0;
            girisİsimLbl.Text = "Kullanıcı Adı :";
            girisİsimLbl.Click += label1_Click;
            // 
            // girisSifrelbl
            // 
            girisSifrelbl.AutoSize = true;
            girisSifrelbl.BackColor = Color.Transparent;
            girisSifrelbl.Location = new Point(216, 180);
            girisSifrelbl.Name = "girisSifrelbl";
            girisSifrelbl.Size = new Size(110, 20);
            girisSifrelbl.TabIndex = 1;
            girisSifrelbl.Text = "Kullanıcı Şifre : ";
            // 
            // girisİsimtextbox
            // 
            girisİsimtextbox.Location = new Point(415, 109);
            girisİsimtextbox.Name = "girisİsimtextbox";
            girisİsimtextbox.Size = new Size(125, 27);
            girisİsimtextbox.TabIndex = 2;
            girisİsimtextbox.TextChanged += girisİsimtextbox_TextChanged;
            // 
            // girisSifretextbox
            // 
            girisSifretextbox.Location = new Point(415, 177);
            girisSifretextbox.Name = "girisSifretextbox";
            girisSifretextbox.PasswordChar = '*';
            girisSifretextbox.Size = new Size(125, 27);
            girisSifretextbox.TabIndex = 3;
            // 
            // giristextbox
            // 
            giristextbox.BackColor = Color.Transparent;
            giristextbox.Location = new Point(322, 275);
            giristextbox.Name = "giristextbox";
            giristextbox.Size = new Size(94, 29);
            giristextbox.TabIndex = 4;
            giristextbox.Text = "Giriş Yap";
            giristextbox.UseVisualStyleBackColor = false;
            giristextbox.Click += giristextbox_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(503, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(258, 331);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 6;
            label7.Text = "Hesabın yok mu?";
            // 
            // button7
            // 
            button7.BackColor = Color.Salmon;
            button7.Location = new Point(406, 324);
            button7.Name = "button7";
            button7.Size = new Size(106, 34);
            button7.TabIndex = 7;
            button7.Text = "Kayıt Ol";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(giristextbox);
            Controls.Add(girisİsimLbl);
            Controls.Add(girisSifrelbl);
            Controls.Add(girisİsimtextbox);
            Controls.Add(girisSifretextbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MOODLY";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label girisİsimLbl;
        private Label girisSifrelbl;
        private TextBox girisİsimtextbox;
        private TextBox girisSifretextbox;
        private Button giristextbox;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label label7;
        private Button button7;
    }
}