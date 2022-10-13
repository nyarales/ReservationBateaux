using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Connecte.Controleur;
using Connecte.Modele;      


namespace Connecte
{
    public partial class Form1 : Form
    {

        Mgr monManager;

        List<Liaison> lLiai = new List<Liaison>();
        List<Secteur> lSect = new List<Secteur>();




        public Form1()
        {
            InitializeComponent();

            monManager = new Mgr();
        }

     
        private void Form1_Load(object sender, EventArgs s)
        {


            
            lSect = monManager.chargementSectBD();
            lLiai = monManager.chargementLiaiBD();




            affiche();
        }

        public void affiche()

        {


            try
            {


                ListBoxSecteur.DataSource = null;
                ListBoxSecteur.DataSource = lSect;
                ListBoxSecteur.DisplayMember = "Libelle";


               


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ListBoxSecteur_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxLiaison.DataSource = null;
            ListBoxLiaison.DataSource = lLiai;
            ListBoxLiaison.DisplayMember = "Description";

        }








        private void Modifier(object sender, EventArgs s)
        {

            try
            {
                // Récuperer l'indice de l'employé selectionné dans la listBox
                /* int i = listBoxEmploye.SelectedIndex;
                 * 
                 * Récupérer l'employé selectionné à partir de la collection lEmp
                 * Employe emp = lEmp[i];
                 */

                // Récupérer directement l'employé selectionné

                Secteur sect = (Secteur)ListBoxSecteur.SelectedItem;

                sect.Libelle = tbSecteur.Text;

                monManager.updateLiai(lLiai);

                lLiai = monManager.chargementLiaiBD();


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void Supprimer(object sender, EventArgs s)
        {


            // A compléter

            affiche();

        }

        private void Ajouter(object sender, EventArgs s)
        {
            // à compléter

            affiche();
        }

        
    }


}










