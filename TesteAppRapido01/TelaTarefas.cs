using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteAppRapido01
{
    public partial class TelaTarefas : Form
    {
        public TelaTarefas()
        {
            InitializeComponent();
        }

        private void TelaTarefas_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.usuario.nome;

            Tarefa tarefa = new Tarefa();
            List<Tarefa> tarefas = tarefa.buscaTodos();

            tabelaTodasTarefas.Columns.Add("id", "ID");
            tabelaTodasTarefas.Columns.Add("descricao", "Descrição");
            tabelaTodasTarefas.Columns.Add("data", "Data");

            foreach( Tarefa t in tarefas)
            {
                tabelaTodasTarefas.Rows.Add( t.id, t.descricao, t.criado_em );
            }


            tarefas = tarefa.buscaTodosPorIdUsuario( Program.usuario.id );

            tabelaTarefasUsuario.Columns.Add("id", "ID");
            tabelaTarefasUsuario.Columns.Add("descricao", "Descrição");
            tabelaTarefasUsuario.Columns.Add("data", "Data");

            foreach (Tarefa t in tarefas)
            {
                tabelaTarefasUsuario.Rows.Add(t.id, t.descricao, t.criado_em);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            bool concluido = cboxConcluido.Checked;

            Tarefa tarefa = new Tarefa(0, Program.usuario.id, descricao, concluido, null);
            tarefa.insere( tarefa );

        }
    }
}
