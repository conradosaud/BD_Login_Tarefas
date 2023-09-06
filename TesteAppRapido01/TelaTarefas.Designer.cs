namespace TesteAppRapido01
{
    partial class TelaTarefas
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
            this.tabelaTodasTarefas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cboxConcluido = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSairDaConta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabelaTarefasUsuario = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTodasTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTarefasUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaTodasTarefas
            // 
            this.tabelaTodasTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTodasTarefas.Location = new System.Drawing.Point(321, 77);
            this.tabelaTodasTarefas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabelaTodasTarefas.Name = "tabelaTodasTarefas";
            this.tabelaTodasTarefas.RowHeadersWidth = 62;
            this.tabelaTodasTarefas.RowTemplate.Height = 25;
            this.tabelaTodasTarefas.Size = new System.Drawing.Size(347, 185);
            this.tabelaTodasTarefas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição da tarefa:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(17, 77);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(274, 31);
            this.txtDescricao.TabIndex = 2;
            // 
            // cboxConcluido
            // 
            this.cboxConcluido.AutoSize = true;
            this.cboxConcluido.Location = new System.Drawing.Point(17, 125);
            this.cboxConcluido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxConcluido.Name = "cboxConcluido";
            this.cboxConcluido.Size = new System.Drawing.Size(118, 29);
            this.cboxConcluido.TabIndex = 3;
            this.cboxConcluido.Text = "Concluído";
            this.cboxConcluido.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(17, 187);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(276, 45);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSairDaConta
            // 
            this.btnSairDaConta.Location = new System.Drawing.Point(154, 470);
            this.btnSairDaConta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSairDaConta.Name = "btnSairDaConta";
            this.btnSairDaConta.Size = new System.Drawing.Size(139, 37);
            this.btnSairDaConta.TabIndex = 5;
            this.btnSairDaConta.Text = "Sair da conta";
            this.btnSairDaConta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Todas as tarefas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tarefas de";
            // 
            // tabelaTarefasUsuario
            // 
            this.tabelaTarefasUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTarefasUsuario.Location = new System.Drawing.Point(321, 322);
            this.tabelaTarefasUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabelaTarefasUsuario.Name = "tabelaTarefasUsuario";
            this.tabelaTarefasUsuario.RowHeadersWidth = 62;
            this.tabelaTarefasUsuario.RowTemplate.Height = 25;
            this.tabelaTarefasUsuario.Size = new System.Drawing.Size(347, 185);
            this.tabelaTarefasUsuario.TabIndex = 7;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(414, 292);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 25);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "usuário";
            // 
            // TelaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 533);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabelaTarefasUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSairDaConta);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboxConcluido);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabelaTodasTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelaTarefas";
            this.Text = "TelaTarefas";
            this.Load += new System.EventHandler(this.TelaTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTodasTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTarefasUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tabelaTodasTarefas;
        private Label label1;
        private TextBox txtDescricao;
        private CheckBox cboxConcluido;
        private Button btnSalvar;
        private Button btnSairDaConta;
        private Label label2;
        private Label label3;
        private DataGridView tabelaTarefasUsuario;
        private Label lblUsuario;
    }
}