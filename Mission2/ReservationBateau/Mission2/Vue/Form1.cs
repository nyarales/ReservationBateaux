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

        Secteur s;

        public Form1()
        {
            InitializeComponent();

            monManager = new Mgr();
            s = new Secteur();
        }

     
        private void Form1_Load(object sender, EventArgs s)
        {
            
            lSect = monManager.chargementSectBD();

            affiche();
        }

        // Procedure Affichage pour liaison
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

        // Procedure Affichage pour liaison
        public void affiche2()

        {


            try
            {


                ListBoxLiaison.DataSource = null;
                ListBoxLiaison.DataSource = lLiai;
                ListBoxLiaison.DisplayMember = "Description";





            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
            
        // Affichage des liaisons en fonction des secteurs
        private void ListBoxSecteur_MouseClick(object sender, MouseEventArgs e)
        {
            int id = (ListBoxSecteur.SelectedIndex)+1;
            string name = ListBoxSecteur.GetItemText(ListBoxSecteur.SelectedItem);

            lLiai = monManager.chargementLiaiBD(Convert.ToString(id), name);
                 
            affiche2();

        }


        private void btnSupp_Click(object sender, EventArgs s)
        {


            Liaison l = (Liaison)ListBoxLiaison.SelectedItem;

            


            int id = (ListBoxSecteur.SelectedIndex) +1;


            string name = ListBoxSecteur.GetItemText(ListBoxSecteur.SelectedItem);



            monManager.deleteLiaison(l, Convert.ToString(id), name);
            this.Refresh();
            lLiai = monManager.chargementLiaiBD(Convert.ToString(id), name);
            affiche2();



            lLiai = monManager.chargementLiaiBD(Convert.ToString(id), name);

        }
        private void btnModif_Click(object sender, EventArgs e)
        {
         

            try
            {






                Liaison l = (Liaison)ListBoxLiaison.SelectedItem;
                l.Duree = duree.Text;
                int id = (ListBoxSecteur.SelectedIndex) + 1;

                //recuperer le nom du secteur
                string name = ListBoxSecteur.GetItemText(ListBoxSecteur.SelectedItem);


                monManager.updateLiaison(l, Convert.ToString(id), name);
                lLiai = monManager.chargementLiaiBD(Convert.ToString(id), name);


                affiche2();
                MessageBox.Show("la durée est bien modifié à : " + duree.Text + " min .");


            
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            
               Form2 f = new Form2();
                f.ShowDialog();
            
        }
    }


}










