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

        List<Employe> lEmp = new List<Employe>();



        public Form1()
        {
            InitializeComponent();

            monManager = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            lEmp = monManager.chargementEmpBD();


            affiche();
        }

        public void affiche()

        {


            try
            {


                listBoxEmploye.DataSource = null;
                listBoxEmploye.DataSource = lEmp;
                listBoxEmploye.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }








        private void button1_Click(object sender, EventArgs e)
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

                Employe emp = (Employe)listBoxEmploye.SelectedItem;

                emp.Login = tbLogin.Text;

                monManager.updateEmploye(emp);

                lEmp = monManager.chargementEmpBD();


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {


            // A compléter

            affiche();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // à compléter

            affiche();
        }



    }


}










