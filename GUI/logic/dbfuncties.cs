using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace logic
{

    public class dbfuncties
    {
        Singleton dbConn = new Singleton();


        public List<patient> returnAllPatientData()
        {
            MySqlDataReader reader = null;
            List<patient> patList = new List<patient>();
            try
            {
                string stmt = "SELECT * FROM patientData";
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    patList.Add(new patient(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7)));
                }

                dbConn.closeConn();
                return patList;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }
        public patient returnPatientMedData(patient pat)
        {
            MySqlDataReader reader = null;
            try
            {
                patient newpat = pat;
                string stmt = "SELECT * FROM patientMedic WHERE ID=" + pat.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(1)) { newpat.Box = reader.GetInt32(1); }
                    if (!reader.IsDBNull(2)) { newpat.TijdOpname = reader.GetDateTime(2); }

                    if (!reader.IsDBNull(3)) { newpat.TijdOntslag = reader.GetDateTime(3); }
                    if (!reader.IsDBNull(4)) { newpat.Komtvan = reader.GetString(4); }
                    if (!reader.IsDBNull(5)) { newpat.Gaatnaar = reader.GetString(5); }
                    if (!reader.IsDBNull(6)) { newpat.Gaatnaarkamer = reader.GetInt32(6); }
                    if (!reader.IsDBNull(7)) { newpat.CoordArts = reader.GetString(7); }
                    if (!reader.IsDBNull(8)) { newpat.BehandelArts = reader.GetString(8); }
                    if (!reader.IsDBNull(9)) { newpat.Diagnose = reader.GetString(9); }
                    if (!reader.IsDBNull(10)) { newpat.DnrCode = reader.GetInt32(10); }
                    if (!reader.IsDBNull(11)) { newpat.Anamnese = reader.GetString(11); }
                    if (!reader.IsDBNull(12)) { newpat.ThuisMed = reader.GetString(12); }
                    if (!reader.IsDBNull(13)) { newpat.HasKathether = reader.GetBoolean(13); }
                    if (!reader.IsDBNull(14)) { newpat.Arterieel = reader.GetBoolean(14); }
                    if (!reader.IsDBNull(15)) { newpat.Cvd = reader.GetBoolean(15); }
                    if (!reader.IsDBNull(16)) { newpat.Picco = reader.GetBoolean(16); }
                    if (!reader.IsDBNull(17)) { newpat.SwanGans = reader.GetBoolean(17); }
                    if (!reader.IsDBNull(18)) { newpat.TempoPM = reader.GetBoolean(18); }
                    if (!reader.IsDBNull(19)) { newpat.PMimplant1 = reader.GetBoolean(19); }
                    if (!reader.IsDBNull(20)) { newpat.CardiaTromb = reader.GetBoolean(20); }
                    if (!reader.IsDBNull(21)) { newpat.NietCardTromb = reader.GetBoolean(21); }
                    if (!reader.IsDBNull(22)) { newpat.Gif = reader.GetBoolean(22); }
                    if (!reader.IsDBNull(23)) { newpat.RefMZG = reader.GetBoolean(23); }
                    if (!reader.IsDBNull(24)) { newpat.Thoraxdrain = reader.GetDateTime(24); }
                    if (!reader.IsDBNull(25)) { newpat.Maagsonde = reader.GetDateTime(25); }
                    if (!reader.IsDBNull(26)) { newpat.Blaassonde = reader.GetDateTime(26); }
                    if (!reader.IsDBNull(27)) { newpat.Pda = reader.GetDateTime(27); }
                    if (!reader.IsDBNull(28)) { newpat.Pcea = reader.GetDateTime(28); }
                    if (!reader.IsDBNull(29)) { newpat.Pcia = reader.GetDateTime(29); }
                    if (!reader.IsDBNull(30)) { newpat.Beademing = reader.GetBoolean(30); }
                    if (!reader.IsDBNull(31)) { newpat.HasNiv = reader.GetBoolean(31); }
                    if (!reader.IsDBNull(32)) { newpat.Ritme = reader.GetString(32); }
                    if (!reader.IsDBNull(33)) { newpat.WhatIsP = reader.GetInt32(33); }
                    if (!reader.IsDBNull(34)) { newpat.Bd = reader.GetString(34); }
                    if (!reader.IsDBNull(35)) { newpat.Dieet = reader.GetString(35); }
                    if (!reader.IsDBNull(36)) { newpat.Sv = reader.GetBoolean(36); }
                    if (!reader.IsDBNull(37)) { newpat.Telemetrie = reader.GetInt32(37); }
                    if (!reader.IsDBNull(38)) { newpat.Kine = reader.GetBoolean(38); }
                    if (!reader.IsDBNull(39)) { newpat.Zalving = reader.GetBoolean(39); }
                    if (!reader.IsDBNull(40)) { newpat.Medicatie = reader.GetBoolean(40); }
                    if (!reader.IsDBNull(41)) { newpat.Infuus = reader.GetBoolean(41); }
                    if (!reader.IsDBNull(42)) { newpat.PceaUitleg = reader.GetString(42); }
                    if (!reader.IsDBNull(43)) { newpat.PceaUitlegAt1 = reader.GetString(43); }
                    if (!reader.IsDBNull(44)) { newpat.Drains = reader.GetBoolean(44); }
                    if (!reader.IsDBNull(45)) { newpat.Onderzoek = reader.GetBoolean(45); }
                    if (!reader.IsDBNull(46)) { newpat.Zorgen = reader.GetString(46); }
                    if (!reader.IsDBNull(47)) { newpat.Verpleegkundige = reader.GetString(47); }
                    if (!reader.IsDBNull(48)) { newpat.Verslag = reader.GetString(49); }
                }

                dbConn.closeConn();
                return newpat;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public MySqlDataReader returnPatientbeademing(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM beademing WHERE PatID=" + id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                dbConn.closeConn();
                return reader;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public MySqlDataReader returnPatientDrains(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM drains WHERE PatID=" + id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                dbConn.closeConn();
                return reader;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }


        public MySqlDataReader returnPatientInfuus(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM infuus WHERE PatID=" + id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                dbConn.closeConn();
                return reader;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }


        public MySqlDataReader returnPatientKatheter(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM katheter WHERE PatID=" + id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                dbConn.closeConn();
                return reader;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public MySqlDataReader returnPatientMedicatie(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM medicatie WHERE PatID=" + id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                dbConn.closeConn();
                return reader;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }


        public MySqlDataReader returnPatientNiv(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM NIV WHERE PatID=" + id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                dbConn.closeConn();
                return reader;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public MySqlDataReader returnPatientonderzoek(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM onderzoek WHERE PatID=" + id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                dbConn.closeConn();
                return reader;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

    }
}
