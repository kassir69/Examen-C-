using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Models
{
    abstract class Personne
    {
        private int id;
        private String nomComplet;
        private String type;
        private String login;
        private String password;

        public int Id { get => id; set => id = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public string Type { get => type; set => type = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public Personne()
        {
        }

        public Personne(int id, string nomComplet)
        {
            this.Id = id;
            this.NomComplet = nomComplet;
        }

        public Personne(string nomComplet)
        {
            this.NomComplet = nomComplet;
        }

        public Personne(string login, string password) : this(login)
        {
            this.Login = login;
            this.Password = password;
        }
    }
}
