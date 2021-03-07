using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Models
{
    class Commande
    {
        private int id;
        private String libelle;
        private int prix;
        private String qte;

        public Commande()
        {
        }

        public Commande(string libelle, int prix, string qte)
        {
            this.Libelle = libelle;
            this.Prix = prix;
            this.Qte = qte;
        }

        public Commande(int id, string libelle, int prix, string qte)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.Prix = prix;
            this.Qte = qte;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int Prix { get => prix; set => prix = value; }
        public string Qte { get => qte; set => qte = value; }

        public override string ToString()
        {
            return libelle;
        }
    }
}
