using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Models
{
    class User:Personne
    {
        public User()
        {
            Type = "User";
        }
        public User(String nomComplet, String login, string password)
        {
            this.NomComplet = nomComplet;
            this.Login = login;
            this.Password = password;
        }

    }
}
