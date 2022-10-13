using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Liaison
    {
        private string id;
        private string idDepart;
        private string idArrivee;
        private string duree;
        private string arrivee;
    

    public string Duree { get => duree; set => duree = value; }

    // remplace getId()
    public string Id { get => id; }

    public string IdRegrouper { get => id; }

    public string IdArrivee { get => idArrivee; set => idArrivee = value; }

    public string Arrivee { get => arrivee; set => arrivee = value; }



        //Constructeur
        public Liaison(string arrivee , string unIdDepart , string unIdArrive, string uneDuree)
    {
            this.arrivee = arrivee;
            this.idDepart = unIdDepart;
            this.idArrivee = unIdArrive;
            this.Duree = uneDuree;
    }

    // Constructeur vide
    public Liaison()
    {



    }


        // pour afficher la liste par la suite
        public string Description
        {
            get => "Depart : " + this.idDepart + " en destination de  : " + this.arrivee + " durée : " + this.duree + " min .";
        }
    }
}


