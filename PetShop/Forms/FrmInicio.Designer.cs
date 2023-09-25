namespace PetShop.Forms
{
    partial class FrmInicio
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
            this.LblFechar = new System.Windows.Forms.Label();
            this.BtnMeCadastrar = new System.Windows.Forms.Button();
            this.BtnFazerLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFechar
            // 
            this.LblFechar.AutoSize = true;
            this.LblFechar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechar.Location = new System.Drawing.Point(67, 25);
            this.LblFechar.Name = "LblFechar";
            this.LblFechar.Size = new System.Drawing.Size(73, 22);
            this.LblFechar.TabIndex = 14;
            this.LblFechar.Text = "Fechar";
            this.LblFechar.Click += new System.EventHandler(this.LblFechar_Click);
            // 
            // BtnMeCadastrar
            // 
            this.BtnMeCadastrar.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMeCadastrar.Location = new System.Drawing.Point(319, 308);
            this.BtnMeCadastrar.Name = "BtnMeCadastrar";
            this.BtnMeCadastrar.Size = new System.Drawing.Size(151, 40);
            this.BtnMeCadastrar.TabIndex = 13;
            this.BtnMeCadastrar.Text = "Me Cadastrar";
            this.BtnMeCadastrar.UseVisualStyleBackColor = true;
            this.BtnMeCadastrar.Click += new System.EventHandler(this.BtnMeCadastrar_Click);
            // 
            // BtnFazerLogin
            // 
            this.BtnFazerLogin.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFazerLogin.Location = new System.Drawing.Point(95, 308);
            this.BtnFazerLogin.Name = "BtnFazerLogin";
            this.BtnFazerLogin.Size = new System.Drawing.Size(143, 40);
            this.BtnFazerLogin.TabIndex = 12;
            this.BtnFazerLogin.Text = "Fazer Login";
            this.BtnFazerLogin.UseVisualStyleBackColor = true;
            this.BtnFazerLogin.Click += new System.EventHandler(this.BtnFazerLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 110);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bem vindo ao\r\nCapra Rações";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::PetShop.Properties.Resources.img_cachorro;
            this.pictureBox3.Location = new System.Drawing.Point(528, 359);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 142);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PetShop.Properties.Resources.img_botao_redondo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 46);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PetShop.Properties.Resources.img_patas;
            this.pictureBox1.Location = new System.Drawing.Point(588, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 303);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(830, 500);
            this.Controls.Add(this.LblFechar);
            this.Controls.Add(this.BtnMeCadastrar);
            this.Controls.Add(this.BtnFazerLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFechar;
        private System.Windows.Forms.Button BtnMeCadastrar;
        private System.Windows.Forms.Button BtnFazerLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}