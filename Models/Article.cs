using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Models
{
    class Article
    {
        //Attributs
        private int id;
        private String reference;
        private int stock;
        private int prix;
        private String libelle;
        private Categorie cat;

        //Contructeurs
        //SUrcharge
        //Par Défaut
        public Article()
        {
        }
        //Insertion
        public Article(string reference, int stock, int prix, string libelle, Categorie cat)
        {
            this.Reference = reference;
            this.Stock = stock;
            this.Prix = prix;
            this.Libelle = libelle;
            this.Cat = cat;
        }
        //Selection
        public Article(int id, string reference, int stock, int prix, string libelle, Categorie cat)
        {
            this.Id = id;
            this.Reference = reference;
            this.Stock = stock;
            this.Prix = prix;
            this.Libelle = libelle;
            this.Cat = cat;
        }
        //Get et Set=> Propreties
        public int Id { get => id; set => id = value; }
        public string Reference { get => reference; set => reference = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Prix { get => prix; set => prix = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        internal Categorie Cat { get => cat; set => cat = value; }
        //ToSring()
        public override string ToString()
        {
            return libelle;
        }
        

    }
}
