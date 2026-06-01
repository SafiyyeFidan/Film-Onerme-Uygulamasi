namespace GPproje
{
    partial class KayitForm
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
            label1 = new Label();
            label2 = new Label();
            kayitİsimtextbox = new TextBox();
            label3 = new Label();
            kayitSifretextbox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(245, 87);
            label1.Name = "label1";
            label1.Size = new Size(311, 34);
            label1.TabIndex = 0;
            label1.Text = "MOODLY'ye Kayıt Ol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 178);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            label2.Click += label2_Click;
            // 
            // kayitİsimtextbox
            // 
            kayitİsimtextbox.Location = new Point(381, 175);
            kayitİsimtextbox.Name = "kayitİsimtextbox";
            kayitİsimtextbox.Size = new Size(158, 27);
            kayitİsimtextbox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 246);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Şifre";
            // 
            // kayitSifretextbox
            // 
            kayitSifretextbox.Location = new Point(381, 246);
            kayitSifretextbox.Name = "kayitSifretextbox";
            kayitSifretextbox.PasswordChar = '*';
            kayitSifretextbox.Size = new Size(158, 27);
            kayitSifretextbox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(315, 318);
            button1.Name = "button1";
            button1.Size = new Size(162, 39);
            button1.TabIndex = 5;
            button1.Text = "Hesabımı Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnKayitOl_Click;
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(kayitSifretextbox);
            Controls.Add(label3);
            Controls.Add(kayitİsimtextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KayitForm";
            Text = "KayitForm";
            Load += KayitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kayitİsimtextbox;
        private Label label3;
        private TextBox kayitSifretextbox;
        private Button button1;
    }
}