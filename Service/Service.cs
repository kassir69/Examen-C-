using Gestion_Commercial.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Service
{
    class Service
    {
        private DaoArticle daoArticle;
        private DaoCategorie daoCategorie;
        private DaoCommande daoCommande;
        private DaoPersonne daoPersonne;

        public Service()
        {
            daoArticle = new DaoArticle();
            daoCategorie = new DaoCategorie();
            daoCommande = new DaoCommande();
            daoPersonne = new DaoPersonne();
        }
    }
}
