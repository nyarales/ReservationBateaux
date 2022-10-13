using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Employe
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private double salaire;


        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)
        public string Login { get => login; set => login = value; }

        // remplace getId()
        public int Id { get => id; }


        public Employe(int unId, string unNom, string unPrenom, string unLogin, double unSalaire)
        {
            this.id = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.login = unLogin;
            this.salaire = unSalaire;
        }

        // Constructeur vide
        public Employe()
        {


        }


        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom + " Prenom : " + this.prenom + " Login : " + this.login + " Salaire : " + this.salaire;
        }
        public string Nom { get => nom; set => nom = value; }
    }
}
