using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.Modele;

namespace Connecte.DAL
{
    public class LiaisonDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "mlr1";

        private static string uid = "ibrany";

        private static string mdp = "PermisDeConduite";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Mise à jour d'une liaison

        public static void updateLiaison(Liaison l, string id, string name)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec(" update liaison   set duree=" + l.Duree + " where ID_REGROUPER=" + id + " and  ID_ARRIVEE=" + l.IdArrivee);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }
        public static void deleteLiaison(Liaison l, string id, string name)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec(" delete from liaison  where ID_REGROUPER=" + id + " and  ID_ARRIVEE=" + l.IdArrivee);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }
        // Récupération de la liste des liaisons
        public static List<Liaison> GetLiaison(string id, string name)
        {

            List<Liaison> lc = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select  LIBELLE , NOM , duree , ID_ARRIVEE from  secteur S  ,port P  , liaison L where   P.ID=L.ID_ARRIVEE and S.LIBELLE='" + name + "' and L.ID_REGROUPER=" + id);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    string depart = (string)reader.GetValue(0);
                    string  arrivee = (string)reader.GetValue(1);
                    string duree = (string)reader.GetValue(3);
                    string arrive = (string)reader.GetValue(2);
                    



                    //Instanciation d'une liaison
                    l = new Liaison(depart, arrivee ,duree, arrive);

                    // Ajout de cet liaison à la liste 
                    lc.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }




}

