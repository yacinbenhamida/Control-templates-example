using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TD_N2
{
    class CompetiteurCRUD
    {
        public static Competiteur getCompetiteur() 
        {
            Competiteur cmp = null;
            try
            {
                SqlConnection cnx = Connexion.getCon();
               SqlCommand cmd = new SqlCommand("SELECT * FROM competiteur Where classement = (Select MIN(classement) from competiteur)", cnx);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) 
                {
                    int id = rd.GetInt32(0);
                    string nom = rd.GetString(1);
                    int clas = rd.GetInt32(2);
                    string etab = rd.GetString(3);
                    cmp = new Competiteur(id,nom,clas,etab);
                }
                rd.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { Connexion.closeCon(); }
            return cmp;

        }
        public static List<Competiteur> ListerCompt() 
        {
            List<Competiteur> lstComp = new List<Competiteur>();
            Competiteur cmp = null;
            try
            {
                SqlConnection cnx = Connexion.getCon();
                SqlCommand cmd = new SqlCommand("SELECT * FROM competiteur", cnx);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id = rd.GetInt32(0);
                    string nom = rd.GetString(1);
                    int clas = rd.GetInt32(2);
                    string etab = rd.GetString(3);
                    cmp = new Competiteur(id, nom, clas, etab);
                    lstComp.Add(cmp);
                }
                rd.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { Connexion.closeCon(); }
            return lstComp;
        }
        public static void AjouterCompetiteur(Competiteur p) 
        {
            try
            {
                SqlConnection cnx = Connexion.getCon();
                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM competiteur where cin=" + p.Cin, cnx);
                int verif = (int)cmd.ExecuteScalar();
                if (verif == 0) 
                {
                    cmd.CommandText = "INSERT INTO competiteur(cin,nom,classement,etablissement) VALUES (@cin,@nom,@clas,@etab)";
                    cmd.Parameters.Add("@cin", SqlDbType.Int,4).Value = p.Cin;
                    cmd.Parameters.Add("@nom", SqlDbType.VarChar,50).Value = p.Nom;
                    cmd.Parameters.Add("@clas", SqlDbType.Int,4).Value = p.Classement;
                    cmd.Parameters.Add("@etab", SqlDbType.VarChar,50).Value = p.Etablissement;
                    cmd.ExecuteNonQuery();
                }
                
            }
            catch (SqlException ex) { throw ex; }
            finally { Connexion.closeCon(); }
        }


    }
}
