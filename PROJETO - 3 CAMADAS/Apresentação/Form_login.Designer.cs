namespace PROJETO___3_CAMADAS.Apresentação
{
	partial class Form_login
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
			this.txb_usuario = new System.Windows.Forms.TextBox();
			this.txb_senha = new System.Windows.Forms.TextBox();
			this.btn_sair = new System.Windows.Forms.Button();
			this.btn_entrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// txb_usuario
			// 
			this.txb_usuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_usuario.Location = new System.Drawing.Point(46, 195);
			this.txb_usuario.Name = "txb_usuario";
			this.txb_usuario.Size = new System.Drawing.Size(179, 20);
			this.txb_usuario.TabIndex = 0;
			// 
			// txb_senha
			// 
			this.txb_senha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_senha.Location = new System.Drawing.Point(46, 264);
			this.txb_senha.Name = "txb_senha";
			this.txb_senha.PasswordChar = '*';
			this.txb_senha.Size = new System.Drawing.Size(179, 20);
			this.txb_senha.TabIndex = 1;
			// 
			// btn_sair
			// 
			this.btn_sair.BackColor = System.Drawing.Color.White;
			this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sair.ForeColor = System.Drawing.Color.Red;
			this.btn_sair.Location = new System.Drawing.Point(46, 350);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(177, 33);
			this.btn_sair.TabIndex = 3;
			this.btn_sair.Text = "SAIR";
			this.btn_sair.UseVisualStyleBackColor = false;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// btn_entrar
			// 
			this.btn_entrar.BackColor = System.Drawing.Color.White;
			this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_entrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_entrar.ForeColor = System.Drawing.Color.Green;
			this.btn_entrar.Location = new System.Drawing.Point(46, 302);
			this.btn_entrar.Name = "btn_entrar";
			this.btn_entrar.Size = new System.Drawing.Size(177, 33);
			this.btn_entrar.TabIndex = 2;
			this.btn_entrar.Text = "ENTRAR";
			this.btn_entrar.UseVisualStyleBackColor = false;
			this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(42, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "USUÁRIO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(42, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "SENHA";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(274, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Image = global::PROJETO___3_CAMADAS.Properties.Resources.teste3;
			this.pictureBox2.Location = new System.Drawing.Point(12, 26);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(239, 87);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(99, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "LOGIN";
			// 
			// Form_login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(263, 402);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_entrar);
			this.Controls.Add(this.btn_sair);
			this.Controls.Add(this.txb_senha);
			this.Controls.Add(this.txb_usuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form_login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TELA DE ACESSO";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_usuario;
		private System.Windows.Forms.TextBox txb_senha;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Button btn_entrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
	}
}