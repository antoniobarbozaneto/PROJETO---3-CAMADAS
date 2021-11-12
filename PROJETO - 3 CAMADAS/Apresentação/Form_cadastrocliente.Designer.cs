namespace PROJETO___3_CAMADAS.Apresentação
{
    partial class Form_cadastrocliente
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
			this.txb_codigocliente = new System.Windows.Forms.TextBox();
			this.txb_nomecliente = new System.Windows.Forms.TextBox();
			this.maskedtxb_cpfcliente = new System.Windows.Forms.MaskedTextBox();
			this.maskedtxb_telefonecliente = new System.Windows.Forms.MaskedTextBox();
			this.btn_limparcampos = new System.Windows.Forms.Button();
			this.btn_gravar = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.maskedtxb_rgcliente = new System.Windows.Forms.MaskedTextBox();
			this.txb_enderecocliente = new System.Windows.Forms.TextBox();
			this.txb_numenderecocliente = new System.Windows.Forms.TextBox();
			this.txb_bairrocliente = new System.Windows.Forms.TextBox();
			this.txb_cidadecliente = new System.Windows.Forms.TextBox();
			this.cxb_estadocliente = new System.Windows.Forms.ComboBox();
			this.maskedtxb_celularcliente = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.maskedtxb_cepcliente = new System.Windows.Forms.MaskedTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txb_emailcliente = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOME:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "* CPF:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "CÓDIGO:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 347);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "TELEFONE:";
			// 
			// txb_codigocliente
			// 
			this.txb_codigocliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_codigocliente.Location = new System.Drawing.Point(97, 72);
			this.txb_codigocliente.Name = "txb_codigocliente";
			this.txb_codigocliente.ReadOnly = true;
			this.txb_codigocliente.Size = new System.Drawing.Size(50, 22);
			this.txb_codigocliente.TabIndex = 1;
			// 
			// txb_nomecliente
			// 
			this.txb_nomecliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nomecliente.Location = new System.Drawing.Point(97, 100);
			this.txb_nomecliente.MaxLength = 50;
			this.txb_nomecliente.Name = "txb_nomecliente";
			this.txb_nomecliente.Size = new System.Drawing.Size(201, 22);
			this.txb_nomecliente.TabIndex = 2;
			// 
			// maskedtxb_cpfcliente
			// 
			this.maskedtxb_cpfcliente.Location = new System.Drawing.Point(97, 128);
			this.maskedtxb_cpfcliente.Mask = "000.000.000-00";
			this.maskedtxb_cpfcliente.Name = "maskedtxb_cpfcliente";
			this.maskedtxb_cpfcliente.Size = new System.Drawing.Size(201, 20);
			this.maskedtxb_cpfcliente.TabIndex = 3;
			// 
			// maskedtxb_telefonecliente
			// 
			this.maskedtxb_telefonecliente.Location = new System.Drawing.Point(97, 346);
			this.maskedtxb_telefonecliente.Mask = "(00) 0000-0000";
			this.maskedtxb_telefonecliente.Name = "maskedtxb_telefonecliente";
			this.maskedtxb_telefonecliente.Size = new System.Drawing.Size(201, 20);
			this.maskedtxb_telefonecliente.TabIndex = 11;
			// 
			// btn_limparcampos
			// 
			this.btn_limparcampos.BackColor = System.Drawing.Color.White;
			this.btn_limparcampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_limparcampos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limparcampos.Location = new System.Drawing.Point(206, 432);
			this.btn_limparcampos.Name = "btn_limparcampos";
			this.btn_limparcampos.Size = new System.Drawing.Size(92, 34);
			this.btn_limparcampos.TabIndex = 16;
			this.btn_limparcampos.Text = "LIMPAR";
			this.btn_limparcampos.UseVisualStyleBackColor = false;
			this.btn_limparcampos.Click += new System.EventHandler(this.btn_limparcampos_Click);
			// 
			// btn_gravar
			// 
			this.btn_gravar.BackColor = System.Drawing.Color.White;
			this.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_gravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gravar.ForeColor = System.Drawing.Color.Green;
			this.btn_gravar.Location = new System.Drawing.Point(10, 432);
			this.btn_gravar.Name = "btn_gravar";
			this.btn_gravar.Size = new System.Drawing.Size(92, 34);
			this.btn_gravar.TabIndex = 14;
			this.btn_gravar.Text = "GRAVAR";
			this.btn_gravar.UseVisualStyleBackColor = false;
			this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
			// 
			// btn_voltar
			// 
			this.btn_voltar.BackColor = System.Drawing.Color.White;
			this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_voltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_voltar.Location = new System.Drawing.Point(108, 432);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(92, 34);
			this.btn_voltar.TabIndex = 15;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = false;
			this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
			// 
			// maskedtxb_rgcliente
			// 
			this.maskedtxb_rgcliente.Location = new System.Drawing.Point(97, 154);
			this.maskedtxb_rgcliente.Mask = "00.000.000-0";
			this.maskedtxb_rgcliente.Name = "maskedtxb_rgcliente";
			this.maskedtxb_rgcliente.Size = new System.Drawing.Size(201, 20);
			this.maskedtxb_rgcliente.TabIndex = 4;
			// 
			// txb_enderecocliente
			// 
			this.txb_enderecocliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_enderecocliente.Location = new System.Drawing.Point(97, 180);
			this.txb_enderecocliente.MaxLength = 50;
			this.txb_enderecocliente.Name = "txb_enderecocliente";
			this.txb_enderecocliente.Size = new System.Drawing.Size(201, 22);
			this.txb_enderecocliente.TabIndex = 5;
			// 
			// txb_numenderecocliente
			// 
			this.txb_numenderecocliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_numenderecocliente.Location = new System.Drawing.Point(97, 208);
			this.txb_numenderecocliente.MaxLength = 50;
			this.txb_numenderecocliente.Name = "txb_numenderecocliente";
			this.txb_numenderecocliente.Size = new System.Drawing.Size(50, 22);
			this.txb_numenderecocliente.TabIndex = 6;
			// 
			// txb_bairrocliente
			// 
			this.txb_bairrocliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_bairrocliente.Location = new System.Drawing.Point(97, 236);
			this.txb_bairrocliente.MaxLength = 50;
			this.txb_bairrocliente.Name = "txb_bairrocliente";
			this.txb_bairrocliente.Size = new System.Drawing.Size(201, 22);
			this.txb_bairrocliente.TabIndex = 7;
			// 
			// txb_cidadecliente
			// 
			this.txb_cidadecliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_cidadecliente.Location = new System.Drawing.Point(97, 264);
			this.txb_cidadecliente.MaxLength = 50;
			this.txb_cidadecliente.Name = "txb_cidadecliente";
			this.txb_cidadecliente.Size = new System.Drawing.Size(201, 22);
			this.txb_cidadecliente.TabIndex = 8;
			// 
			// cxb_estadocliente
			// 
			this.cxb_estadocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cxb_estadocliente.FormattingEnabled = true;
			this.cxb_estadocliente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
			this.cxb_estadocliente.Location = new System.Drawing.Point(97, 292);
			this.cxb_estadocliente.Name = "cxb_estadocliente";
			this.cxb_estadocliente.Size = new System.Drawing.Size(50, 21);
			this.cxb_estadocliente.TabIndex = 9;
			// 
			// maskedtxb_celularcliente
			// 
			this.maskedtxb_celularcliente.Location = new System.Drawing.Point(97, 372);
			this.maskedtxb_celularcliente.Mask = "(00) 00000-0000";
			this.maskedtxb_celularcliente.Name = "maskedtxb_celularcliente";
			this.maskedtxb_celularcliente.Size = new System.Drawing.Size(201, 20);
			this.maskedtxb_celularcliente.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(51, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 24;
			this.label6.Text = "* RG:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(5, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 16);
			this.label7.TabIndex = 25;
			this.label7.Text = " ENDEREÇO:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(23, 211);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 16);
			this.label8.TabIndex = 26;
			this.label8.Text = "NÚMERO:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(29, 239);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 16);
			this.label9.TabIndex = 27;
			this.label9.Text = "BAIRRO:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(31, 267);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 16);
			this.label10.TabIndex = 28;
			this.label10.Text = "CIDADE:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(27, 293);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 16);
			this.label11.TabIndex = 29;
			this.label11.Text = "ESTADO:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(53, 320);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 16);
			this.label12.TabIndex = 31;
			this.label12.Text = "CEP:";
			// 
			// maskedtxb_cepcliente
			// 
			this.maskedtxb_cepcliente.Location = new System.Drawing.Point(97, 319);
			this.maskedtxb_cepcliente.Mask = "00000-000";
			this.maskedtxb_cepcliente.Name = "maskedtxb_cepcliente";
			this.maskedtxb_cepcliente.Size = new System.Drawing.Size(201, 20);
			this.maskedtxb_cepcliente.TabIndex = 10;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(19, 373);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 16);
			this.label13.TabIndex = 33;
			this.label13.Text = "CELULAR:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(35, 401);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 16);
			this.label14.TabIndex = 34;
			this.label14.Text = "E-MAIL:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(134, 471);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(164, 15);
			this.label15.TabIndex = 35;
			this.label15.Text = "(* CAMPOS OBRIGATÓRIOS)";
			// 
			// txb_emailcliente
			// 
			this.txb_emailcliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_emailcliente.Location = new System.Drawing.Point(97, 398);
			this.txb_emailcliente.MaxLength = 50;
			this.txb_emailcliente.Name = "txb_emailcliente";
			this.txb_emailcliente.Size = new System.Drawing.Size(201, 22);
			this.txb_emailcliente.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
			this.pictureBox1.Location = new System.Drawing.Point(-8, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(327, 69);
			this.pictureBox1.TabIndex = 36;
			this.pictureBox1.TabStop = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.MidnightBlue;
			this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(38, 11);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(238, 22);
			this.label16.TabIndex = 37;
			this.label16.Text = "CADASTRO DE CLIENTE";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.MidnightBlue;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(93, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 19);
			this.label5.TabIndex = 38;
			this.label5.Text = "(PESSOA FÍSICA)";
			// 
			// Form_cadastrocliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(310, 495);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txb_emailcliente);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.maskedtxb_cepcliente);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.maskedtxb_celularcliente);
			this.Controls.Add(this.cxb_estadocliente);
			this.Controls.Add(this.txb_cidadecliente);
			this.Controls.Add(this.txb_bairrocliente);
			this.Controls.Add(this.txb_numenderecocliente);
			this.Controls.Add(this.txb_enderecocliente);
			this.Controls.Add(this.maskedtxb_rgcliente);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_gravar);
			this.Controls.Add(this.btn_limparcampos);
			this.Controls.Add(this.maskedtxb_telefonecliente);
			this.Controls.Add(this.maskedtxb_cpfcliente);
			this.Controls.Add(this.txb_nomecliente);
			this.Controls.Add(this.txb_codigocliente);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form_cadastrocliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO CLIENTE";
			this.Load += new System.EventHandler(this.Form_cadastrocliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_limparcampos;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_voltar;
        public System.Windows.Forms.TextBox txb_codigocliente;
        public System.Windows.Forms.TextBox txb_nomecliente;
        public System.Windows.Forms.MaskedTextBox maskedtxb_cpfcliente;
        public System.Windows.Forms.MaskedTextBox maskedtxb_telefonecliente;
		public System.Windows.Forms.MaskedTextBox maskedtxb_rgcliente;
		public System.Windows.Forms.TextBox txb_enderecocliente;
		public System.Windows.Forms.TextBox txb_numenderecocliente;
		public System.Windows.Forms.TextBox txb_bairrocliente;
		public System.Windows.Forms.TextBox txb_cidadecliente;
		public System.Windows.Forms.MaskedTextBox maskedtxb_celularcliente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.MaskedTextBox maskedtxb_cepcliente;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		public System.Windows.Forms.TextBox txb_emailcliente;
		public System.Windows.Forms.ComboBox cxb_estadocliente;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label5;
	}
}