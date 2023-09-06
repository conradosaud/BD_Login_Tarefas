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
    internal class Usuario
    {

        public int id;
        public string nome;
        public string email;
        public string senha;

        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public List<Usuario> buscaTodos()
        {

            string query = "SELECT nome FROM usuarios;";

            DataTable resultados = ConexaoClasse.executaQuery(query);
            if (resultados == null)
                return null;

            List<Usuario> usuarios = new List<Usuario>();
            foreach (DataRow row in resultados.Rows)
            {
                Usuario usuario = carregaDados(row);
                usuarios.Add(usuario);
            }

            return usuarios;

        }

        public Usuario login( string email, string senha)
        {
            string query = $"SELECT * FROM usuarios WHERE email = '{email}' AND senha = '{senha}';";
            DataTable resultados = ConexaoClasse.executaQuery(query);
            if (resultados.Rows.Count == 0)
                return null;

            Usuario usuario = carregaDados(resultados.Rows[0]);
            return usuario;
        }

        public Usuario buscaPorId(int id)
        {
            string query = "SELECT * FROM usuarios WHERE id = " + id + " LIMIT 1;";

            DataTable resultados = ConexaoClasse.executaQuery(query);
            if (resultados.Rows.Count == 0)
                return null;

            Usuario usuario = carregaDados(resultados.Rows[0]);
            return usuario;

        }

        public void insere(Usuario usuario)
        {
            string query = $"INSERT INTO usuarios (nome, email, senha) VALUES ('{usuario.nome}', '{usuario.email}', '{usuario.senha}');";
            ConexaoClasse.executaQuery(query);
        }


        private Usuario carregaDados(DataRow row)
        {
            int id = int.Parse(row["id"].ToString());
            string nome = row["nome"].ToString();
            string email = row["email"].ToString();
            string senha = row["senha"].ToString();

            Usuario usuario = new Usuario(id, nome, email, senha);
            return usuario;
        }

    }
}