using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Liaison
    {
        private int id;
        private int idRegrouper;
        private int idDepart;
        private int idArrivee;
        private string duree;
    

    public string Duree { get => duree; set => duree = value; }

    // remplace getId()
    public int Id { get => id; }

    public int IdRegrouper { get => id; }

    public int IdDepart { get => id; }
    public int IdArrivee { get => id; }



        public Liaison(int unId, int unIdRegrouper ,int unIdDepart ,int unIdArrive, string uneDuree)
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


