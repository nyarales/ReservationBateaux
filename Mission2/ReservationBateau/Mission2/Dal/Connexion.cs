using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Connecte
    {

        /**
         * Classe de connexion à une base de données
         */
        public class ConnexionSql
        {
            private static ConnexionSql connection = null;

            private MySqlConnection mysqlCn;

            private static readonly object mylock = new object();

            private string connString;


            private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
            {


                try
                {
                    connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                    uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                    try
                    {
                        mysqlCn = new MySqlConnection(connString);
                    }
                    catch (Exception sect)
                    {
                        throw (sect);
                    }
                }
                catch (Exception sect)
                {
                    throw (sect);
                }



            }



            /**
             * méthode de création d'une instance de connexion si elle n'existe pas (singleton)
             */
            public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
            {

                lock ((mylock))
                {

                    try
                    {


                        if (null == connection)
                        { // Premier appel
                            connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);

                        }

                    }
                    catch (Exception sect)
                    {
                        throw (sect);


                    }
                    return connection;

                }
            }





            /**
             * Ouverture de la connexion
             */
            public void openConnection()
            {
                try
                {
                    mysqlCn.Open();
                }
                catch (Exception sect)
                {
                    throw (sect);
                }
            }

            /**
             * Fermeture de la connexion
             */
            public void closeConnection()
            {
                if (mysqlCn.State == System.Data.ConnectionState.Open)
                    mysqlCn.Close();
            }

            /**
             * Exécutiuon d'une requête
             */
            public MySqlCommand reqExec(string req)
            {
                MySqlCommand mysqlCom = new MySqlCommand(req, this.mysqlCn);
                return (mysqlCom);
            }


        }

    }
