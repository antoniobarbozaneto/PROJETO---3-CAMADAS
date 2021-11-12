namespace PROJETO___3_CAMADAS.Apresentação
{
	partial class Form_cadastrousuario
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
			this.txb_codigousuario = new System.Windows.Forms.TextBox();
			this.txb_nomeusuario = new System.Windows.Forms.TextBox();
			this.txb_senhausuario = new System.Windows.Forms.TextBox();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.btn_gravar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(40, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "CÓDIGO:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(50, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "SENHA:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(54, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "NOME:";
			// 
			// txb_codigousuario
			// 
			this.txb_codigousuario.Location = new System.Drawing.Point(115, 60);
			this.txb_codigousuario.Name = "txb_codigousuario";
			this.txb_codigousuario.ReadOnly = true;
			this.txb_codigousuario.Size = new System.Drawing.Size(86, 20);
			this.txb_codigousuario.TabIndex = 1;
			// 
			// txb_nomeusuario
			// 
			this.txb_nomeusuario.Location = new System.Drawing.Point(115, 86);
			this.txb_nomeusuario.Name = "txb_nomeusuario";
			this.txb_nomeusuario.Size = new System.Drawing.Size(165, 20);
			this.txb_nomeusuario.TabIndex = 2;
			// 
			// txb_senhausuario
			// 
			this.txb_senhausuario.Location = new System.Drawing.Point(115, 112);
			this.txb_senhausuario.Name = "txb_senhausuario";
			this.txb_senhausuario.Size = new System.Drawing.Size(165, 20);
			this.txb_senhausuario.TabIndex = 3;
			// 
			// btn_limpar
			// 
			this.btn_limpar.BackColor = System.Drawing.Color.White;
			this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_limpar.Location = new System.Drawing.Point(229, 142);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(92, 34);
			this.btn_limpar.TabIndex = 6;
			this.btn_limpar.Text = "LIMPAR";
			this.btn_limpar.UseVisualStyleBackColor = false;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// btn_voltar
			// 
			this.btn_voltar.BackColor = System.Drawing.Color.White;
			this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_voltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_voltar.Location = new System.Drawing.Point(131, 142);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(92, 34);
			this.btn_voltar.TabIndex = 5;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = false;
			this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
			// 
			// btn_gravar
			// 
			this.btn_gravar.BackColor = System.Drawing.Color.White;
			this.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_gravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_gravar.ForeColor = System.Drawing.Color.Green;
			this.btn_gravar.Location = new System.Drawing.Point(33, 142);
			this.btn_gravar.Name = "btn_gravar";
			this.btn_gravar.Size = new System.Drawing.Size(92, 34);
			this.btn_gravar.TabIndex = 4;
			this.btn_gravar.Text = "GRAVAR";
			this.btn_gravar.UseVisualStyleBackColor = false;
			this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
			this.pictureBox1.Location = new System.Drawing.Point(-6, -7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(356, 56);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.MidnightBlue;
			this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(62, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(208, 22);
			this.label4.TabIndex = 11;
			this.label4.Text = "CADASTRO USUÁRIO";
			// 
			// Form_cadastrousuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(342, 191);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_gravar);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.txb_senhausuario);
			this.Controls.Add(this.txb_nomeusuario);
			this.Controls.Add(this.txb_codigousuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form_cadastrousuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO USUÁRIO";
			this.Load += new System.EventHandler(this.Form_cadastrousuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_voltar;
		public System.Windows.Forms.TextBox txb_codigousuario;
		public System.Windows.Forms.TextBox txb_nomeusuario;
		public System.Windows.Forms.TextBox txb_senhausuario;
		private System.Windows.Forms.Button btn_gravar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
	}
}