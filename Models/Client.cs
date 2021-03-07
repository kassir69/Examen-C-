using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial.Models
{
    class Client:Personne
    {
        private int telephone;
        private String adresse;
        private int commande_id;

        public Client()
        {
            Type = "Client";
        }

        public Client(int telephone, string adresse, int commande_id)
        {
            this.Telephone = telephone;
            this.Adresse = adresse;
            this.Commande_id = commande_id;
        }

        public int Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Commande_id { get => commande_id; set => commande_id = value; }

        public override string ToString()
        {
            return adresse;
        }
    }
}
