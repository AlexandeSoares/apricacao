namespace apricacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoenvia = new System.Windows.Forms.Button();
            this.botaocancelar = new System.Windows.Forms.Button();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoenvia
            // 
            this.botaoenvia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botaoenvia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoenvia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoenvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoenvia.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.botaoenvia.Location = new System.Drawing.Point(304, 251);
            this.botaoenvia.Name = "botaoenvia";
            this.botaoenvia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botaoenvia.Size = new System.Drawing.Size(75, 34);
            this.botaoenvia.TabIndex = 0;
            this.botaoenvia.Text = "enviar";
            this.botaoenvia.UseVisualStyleBackColor = false;
            this.botaoenvia.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaocancelar
            // 
            this.botaocancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botaocancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaocancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaocancelar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.botaocancelar.Location = new System.Drawing.Point(385, 251);
            this.botaocancelar.Name = "botaocancelar";
            this.botaocancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botaocancelar.Size = new System.Drawing.Size(86, 34);
            this.botaocancelar.TabIndex = 1;
            this.botaocancelar.Text = "cancelar";
            this.botaocancelar.UseMnemonic = false;
            this.botaocancelar.UseVisualStyleBackColor = false;
            this.botaocancelar.UseWaitCursor = true;
            this.botaocancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(304, 225);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(167, 20);
            this.textsenha.TabIndex = 2;
            this.textsenha.TextChanged += new System.EventHandler(this.textsenha_TextChanged);
            // 
            // textlogin
            // 
            this.textlogin.Location = new System.Drawing.Point(304, 199);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(167, 20);
            this.textlogin.TabIndex = 3;
            this.textlogin.TextChanged += new System.EventHandler(this.textlogin_TextChanged);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.SystemColors.Control;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(251, 199);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(43, 16);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.senha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(251, 225);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(48, 16);
            this.senha.TabIndex = 5;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.botaocancelar);
            this.Controls.Add(this.botaoenvia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Aplicação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoenvia;
        private System.Windows.Forms.Button botaocancelar;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label senha;
    }
}

