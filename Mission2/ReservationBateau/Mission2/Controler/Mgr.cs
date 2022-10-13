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

        LiaisonDAO secDAO = new LiaisonDAO();

        List<Liaison> MaListeLiaison;

        public Mgr()
        {

            MaListeLiaison = new List<Liaison>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Liaison> chargementLiaiBD()
        {

            MaListeLiaison = LiaisonDAO.GetLiaison();

            return (MaListeLiaison);
        }


        // Mise à jour d'un employé  dans la DAL
        public void updateLiai(Liaison e)
        {

            LiaisonDAO.updateLiaison(e);

        }

    }
}
