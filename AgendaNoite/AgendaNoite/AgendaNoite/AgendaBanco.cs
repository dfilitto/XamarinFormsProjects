using System;
using System.Collections.Generic;
using System.Linq;
using AgendaNoite.Models;
using SQLite;

namespace AgendaNoite
{
    public class AgendaBanco
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public AgendaBanco(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Pessoa>();
        }

        public void AdicionarContato(Pessoa contato)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(contato.Nome))
                    throw new Exception("Nome em branco");
                if (string.IsNullOrEmpty(contato.Celular))
                    throw new Exception("Celular em branco");
                if (string.IsNullOrEmpty(contato.Email))
                    throw new Exception("Email em branco");
                result = conn.Insert(contato);

                StatusMessage = string.Format("{0} registro(s) adicionado(s): [Nome: {1}, e-mail: {2}, celular: {3}]", 
                    result, contato.Nome, contato.Email, contato.Celular);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Erro ao adicionar o registro. Error: {0}", ex.Message);
            }
        }

        public List<Pessoa> RecuperarContatos()
        {
            List<Pessoa> Lista = new List<Pessoa>();
            try
            {
                Lista = conn.Table<Pessoa>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Erro ao recuperar dados. {0}", ex.Message);
            }
            return Lista;
        }

        public List<Pessoa> LocalizarContatos(string nome)
        {
            List<Pessoa> Lista = new List<Pessoa>();
            try
            {
                var resp = from p in conn.Table<Pessoa>()
                        where p.Nome.ToLower().Contains(nome.ToLower())
                        select p;
                Lista = resp.ToList<Pessoa>();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Erro ao recuperar dados. {0}", ex.Message);
            }
            return Lista;
        }

        public void ExcluirContatos(int id)
        {
            try
            {
                int result = conn.Table<Pessoa>().Delete(p => p.Id == id);
                StatusMessage = string.Format("{0} registro(s) Excluidos(s): [Código: {1}]",
                    result, id);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Erro ao excluir: {0}", ex.Message);
            }
            
        }

        public Pessoa CarregarContato(int id)
        {
            Pessoa c = new Pessoa();
            try
            {
                c = conn.Table<Pessoa>().First(p => p.Id == id);
                StatusMessage = "Encontrou o contato de código: " + id;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Erro ao recuperar dados. {0}", ex.Message);
            }
            return c;
        }

        public void AtualizaContato(Pessoa p)
        {
            try
            {
                conn.Update(p);
                StatusMessage = "Atualizou o contato de código: " + p.Id;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Erro ao recuperar dados. {0}", ex.Message);
            }
        }

        
    }
}
