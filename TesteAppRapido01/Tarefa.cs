using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAppRapido01;

namespace TesteAppRapido01
{
    internal class Tarefa
    {

        public int id;
        public int usuario_id;
        public string descricao;
        public bool concluido;
        public string criado_em;

        public Tarefa()
        {

        }

        public Tarefa(int id, int usuario_id, string descricao, bool concluido, string criado_em)
        {
            this.id = id;
            this.usuario_id = usuario_id;
            this.descricao = descricao;
            this.concluido = concluido;
            this.criado_em = criado_em;
        }

        public List<Tarefa> buscaTodos()
        {

            string query = "SELECT * FROM tarefas;";

            DataTable resultados = ConexaoClasse.executaQuery(query);
            if (resultados == null)
                return null;

            List<Tarefa> tarefas = new List<Tarefa>();
            foreach (DataRow row in resultados.Rows)
            {
                Tarefa tarefa = carregaDados(row);
                tarefas.Add(tarefa);
            }

            return tarefas;

        }

        public List<Tarefa> buscaTodosPorIdUsuario( int id_usuario )
        {

            string query = $"SELECT * FROM tarefas WHERE id_usuario = {id_usuario};";

            DataTable resultados = ConexaoClasse.executaQuery(query);
            if (resultados == null)
                return null;

            List<Tarefa> tarefas = new List<Tarefa>();
            foreach (DataRow row in resultados.Rows)
            {
                Tarefa tarefa = carregaDados(row);
                tarefas.Add(tarefa);
            }

            return tarefas;

        }

        public Tarefa buscaPorId(int id)
        {
            string query = "SELECT * FROM tarefas WHERE id = " + id + " LIMIT 1;";

            DataTable resultados = ConexaoClasse.executaQuery(query);
            if (resultados.Rows.Count == 0)
                return null;

            Tarefa tarefa = carregaDados(resultados.Rows[0]);
            return tarefa;

        }

        public void insere(Tarefa tarefa)
        {
            string query = $"INSERT INTO tarefas (id_usuario, descricao, status) VALUES ({tarefa.usuario_id}, '{tarefa.descricao}', {tarefa.concluido});";
            ConexaoClasse.executaQuery(query);
        }


        private Tarefa carregaDados(DataRow row)
        {
            int id = int.Parse(row["id"].ToString());
            int usuario_id = int.Parse(row["id_usuario"].ToString());
            string descricao = row["descricao"].ToString();
            bool concluido = row["concluido"].ToString() == "1" ? true : false;
            string criado_em = row["criado_em"].ToString();

            Tarefa tarefa = new Tarefa(id, 0, descricao, concluido, criado_em);
            return tarefa;
        }

    }
}