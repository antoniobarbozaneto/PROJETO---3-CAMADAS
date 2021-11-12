namespace PROJETO___3_CAMADAS.Apresentação
{
	partial class Form_consultausuario
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
			this.txb_consultausuario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_atualizarGridView = new System.Windows.Forms.Button();
			this.btn_editar = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.dataGridView_Usuario = new System.Windows.Forms.DataGridView();
			this.btn_buscar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txb_consultausuario
			// 
			this.txb_consultausuario.Location = new System.Drawing.Point(20, 77);
			this.txb_consultausuario.Name = "txb_consultausuario";
			this.txb_consultausuario.Size = new System.Drawing.Size(273, 20);
			this.txb_consultausuario.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(17, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "PESQUISAR";
			// 
			// btn_atualizarGridView
			// 
			this.btn_atualizarGridView.BackColor = System.Drawing.Color.White;
			this.btn_atualizarGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_atualizarGridView.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btn_atualizarGridView.ForeColor = System.Drawing.Color.Blue;
			this.btn_atualizarGridView.Location = new System.Drawing.Point(20, 290);
			this.btn_atualizarGridView.Name = "btn_atualizarGridView";
			this.btn_atualizarGridView.Size = new System.Drawing.Size(86, 40);
			this.btn_atualizarGridView.TabIndex = 8;
			this.btn_atualizarGridView.Text = "ATUALIZAR LISTA";
			this.btn_atualizarGridView.UseVisualStyleBackColor = false;
			this.btn_atualizarGridView.Click += new System.EventHandler(this.btn_atualizarGridView_Click);
			// 
			// btn_editar
			// 
			this.btn_editar.BackColor = System.Drawing.Color.White;
			this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editar.Location = new System.Drawing.Point(112, 290);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(86, 41);
			this.btn_editar.TabIndex = 9;
			this.btn_editar.Text = "EDITAR";
			this.btn_editar.UseVisualStyleBackColor = false;
			this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
			// 
			// btn_excluir
			// 
			this.btn_excluir.BackColor = System.Drawing.Color.White;
			this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.ForeColor = System.Drawing.Color.Red;
			this.btn_excluir.Location = new System.Drawing.Point(204, 290);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(86, 41);
			this.btn_excluir.TabIndex = 10;
			this.btn_excluir.Text = "EXCLUIR";
			this.btn_excluir.UseVisualStyleBackColor = false;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// btn_voltar
			// 
			this.btn_voltar.BackColor = System.Drawing.Color.White;
			this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_voltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_voltar.Location = new System.Drawing.Point(296, 290);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(86, 41);
			this.btn_voltar.TabIndex = 11;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = false;
			this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
			// 
			// dataGridView_Usuario
			// 
			this.dataGridView_Usuario.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Usuario.Location = new System.Drawing.Point(20, 108);
			this.dataGridView_Usuario.Name = "dataGridView_Usuario";
			this.dataGridView_Usuario.ReadOnly = true;
			this.dataGridView_Usuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dataGridView_Usuario.Size = new System.Drawing.Size(362, 176);
			this.dataGridView_Usuario.TabIndex = 12;
			this.dataGridView_Usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Usuario_CellContentClick);
			// 
			// btn_buscar
			// 
			this.btn_buscar.BackColor = System.Drawing.Color.White;
			this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_buscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_buscar.Location = new System.Drawing.Point(299, 70);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.Size = new System.Drawing.Size(81, 32);
			this.btn_buscar.TabIndex = 13;
			this.btn_buscar.Text = "BUSCAR";
			this.btn_buscar.UseVisualStyleBackColor = false;
			this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
			this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(412, 50);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(73, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 24);
			this.label2.TabIndex = 15;
			this.label2.Text = "CONSULTA USUÁRIOS";
			// 
			// Form_consultausuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.ClientSize = new System.Drawing.Size(400, 343);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_buscar);
			this.Controls.Add(this.dataGridView_Usuario);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_editar);
			this.Controls.Add(this.btn_atualizarGridView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txb_consultausuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form_consultausuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CONSULTA USUÁRIO";
			this.Load += new System.EventHandler(this.Form_consultausuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_consultausuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_atualizarGridView;
		private System.Windows.Forms.Button btn_editar;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_voltar;
		public System.Windows.Forms.DataGridView dataGridView_Usuario;
		private System.Windows.Forms.Button btn_buscar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
	}
}