using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Connecte.Modele;


namespace Connecte.Controleur
{
    public class Mgr
    {

        EmployeDAO empDAO = new EmployeDAO();

        List<Employe> maListeEmploye;

        public Mgr()
        {

            maListeEmploye = new List<Employe>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Employe> chargementEmpBD()
        {

            maListeEmploye = EmployeDAO.getEmployes();

            return (maListeEmploye);
        }


        // Mise à jour d'un employé  dans la DAL
        public void updateEmploye(Employe e)
        {

            EmployeDAO.updateEmploye(e);

        }

    }
}
