using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Models
{
    class Categorie
    {
        private int id;
        private String libelle;

        public Categorie()
        {
        }

        public Categorie(string libelle)
        {
            this.Libelle = libelle;
        }

        public Categorie(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public override string ToString()
        {
            return libelle;
        }
    }
}
