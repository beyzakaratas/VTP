namespace WindowsFormsApplication3
{
    partial class text
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textşifre = new System.Windows.Forms.TextBox();
            this.textposta = new System.Windows.Forms.TextBox();
            this.radiokadın = new System.Windows.Forms.RadioButton();
            this.radioerkek = new System.Windows.Forms.RadioButton();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.rtbkayıt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadınız:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifreniz:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail adresiniz:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textad
            // 
            this.textad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textad.BackColor = System.Drawing.SystemColors.Window;
            this.textad.Location = new System.Drawing.Point(297, 11);
            this.textad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(247, 29);
            this.textad.TabIndex = 5;
            this.textad.Click += new System.EventHandler(this.beyz);
            this.textad.TextChanged += new System.EventHandler(this.textad_TextChanged);
            this.textad.Enter += new System.EventHandler(this.textad_Enter);
            // 
            // textsoyad
            // 
            this.textsoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textsoyad.Location = new System.Drawing.Point(297, 47);
            this.textsoyad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(247, 29);
            this.textsoyad.TabIndex = 6;
            this.textsoyad.Enter += new System.EventHandler(this.textsoyad_Enter);
            // 
            // textşifre
            // 
            this.textşifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textşifre.Location = new System.Drawing.Point(297, 82);
            this.textşifre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textşifre.MaxLength = 10;
            this.textşifre.Name = "textşifre";
            this.textşifre.PasswordChar = '*';
            this.textşifre.Size = new System.Drawing.Size(247, 29);
            this.textşifre.TabIndex = 7;
            this.textşifre.Enter += new System.EventHandler(this.textşifre_Enter);
            // 
            // textposta
            // 
            this.textposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textposta.Location = new System.Drawing.Point(297, 120);
            this.textposta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textposta.Name = "textposta";
            this.textposta.Size = new System.Drawing.Size(247, 29);
            this.textposta.TabIndex = 8;
            this.textposta.Enter += new System.EventHandler(this.textposta_Enter);
            // 
            // radiokadın
            // 
            this.radiokadın.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radiokadın.AutoSize = true;
            this.radiokadın.Location = new System.Drawing.Point(297, 166);
            this.radiokadın.Margin = new System.Windows.Forms.Padding(4);
            this.radiokadın.Name = "radiokadın";
            this.radiokadın.Size = new System.Drawing.Size(73, 28);
            this.radiokadın.TabIndex = 10;
            this.radiokadın.TabStop = true;
            this.radiokadın.Text = "kadın";
            this.radiokadın.UseVisualStyleBackColor = true;
            // 
            // radioerkek
            // 
            this.radioerkek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioerkek.AutoSize = true;
            this.radioerkek.Location = new System.Drawing.Point(378, 166);
            this.radioerkek.Margin = new System.Windows.Forms.Padding(4);
            this.radioerkek.Name = "radioerkek";
            this.radioerkek.Size = new System.Drawing.Size(74, 28);
            this.radioerkek.TabIndex = 11;
            this.radioerkek.TabStop = true;
            this.radioerkek.Text = "erkek";
            this.radioerkek.UseVisualStyleBackColor = true;
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonkaydet.ForeColor = System.Drawing.Color.Purple;
            this.buttonkaydet.Location = new System.Drawing.Point(54, 216);
            this.buttonkaydet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(490, 46);
            this.buttonkaydet.TabIndex = 12;
            this.buttonkaydet.Text = "kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // rtbkayıt
            // 
            this.rtbkayıt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbkayıt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbkayıt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtbkayıt.Location = new System.Drawing.Point(54, 298);
            this.rtbkayıt.Name = "rtbkayıt";
            this.rtbkayıt.Size = new System.Drawing.Size(490, 222);
            this.rtbkayıt.TabIndex = 13;
            this.rtbkayıt.Text = "";
            // 
            // text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 555);
            this.Controls.Add(this.rtbkayıt);
            this.Controls.Add(this.buttonkaydet);
            this.Controls.Add(this.radioerkek);
            this.Controls.Add(this.radiokadın);
            this.Controls.Add(this.textposta);
            this.Controls.Add(this.textşifre);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "text";
            this.Text = "kayıt formu";
            this.Click += new System.EventHandler(this.text_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textşifre;
        private System.Windows.Forms.TextBox textposta;
        private System.Windows.Forms.RadioButton radiokadın;
        private System.Windows.Forms.RadioButton radioerkek;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.RichTextBox rtbkayıt;
    }
}

