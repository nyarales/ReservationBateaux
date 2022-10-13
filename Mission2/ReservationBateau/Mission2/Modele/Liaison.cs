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
        private string idRegrouper;
        private string idDepart;
        private string idArrivee;
        private string duree;
    

    public string Duree { get => duree; set => duree = value; }

    // remplace getId()
    public string Id { get => id; }

    public string IdRegrouper { get => id; }

    public string IdDepart { get => id; }
    public string IdArrivee { get => id; }



        public Liaison(string unId, string unIdRegrouper , string unIdDepart , string unIdArrive, string uneDuree)
    {
            this.id = unId;
            this.idRegrouper = unIdRegrouper;
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
        get => "Id : " + this.id + "Id_Regrouper : "+this.idRegrouper+"Id_Départ : "+this.idDepart+"Id_Arrivee : "+this.idArrivee+" Durée : " + this.duree;
    }
}
}


