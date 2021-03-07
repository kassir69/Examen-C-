using Gestion_Commercial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Dao
{
    class DaoPersonne : IDao<Personne>
    {
        public int insert(Personne personne)
        {
            throw new NotImplementedException();
        }

        List<User> findUser(User user)
        {
            List<User> lUsers = new List<User>();
            String sql = string.Format("INSERT INTO `personne` (`nom_complet`, `type`, `login`, `password`, `tel`, `adresse`, `commande_id`) VALUES(?,?,?,?,?,?,?); ");
        }
    }
}

