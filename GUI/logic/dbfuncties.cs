using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;

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
                    patList.Add(new patient(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetString(6)));
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
                    if (!reader.IsDBNull(48)) { newpat.Verslag = reader.GetString(48); }
                }

                dbConn.closeConn();
                return newpat;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public List<Beademing> returnPatientbeademing(patient patient)
        {
            MySqlDataReader reader = null;
            List<Beademing> beademList = new List<Beademing>();
            try
            {
                string stmt = "SELECT * FROM beademing WHERE PatID=" + patient.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    beademList.Add(new Beademing(reader.GetDateTime(2), reader.GetDateTime(3)));
                }
                dbConn.closeConn();
                return beademList;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public List<Drains> returnPatientDrains(patient patient)
        {
            MySqlDataReader reader = null;
            List<Drains> drainlist = new List<Drains>();
            try
            {
                string stmt = "SELECT * FROM drains WHERE PatID=" + patient.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    drainlist.Add(new Drains(reader.GetString(2)));
                }
                dbConn.closeConn();
                return drainlist;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }


        public List<Infuus> returnPatientInfuus(patient patient)
        {
            MySqlDataReader reader = null;
            List<Infuus> infuusList = new List<Infuus>();
            try
            {
                string stmt = "SELECT * FROM infuus WHERE PatID=" + patient.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    infuusList.Add(new Infuus(reader.GetString(2), reader.GetInt32(3)));
                }
                dbConn.closeConn();
                return infuusList;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }


        public List<Katheter> returnPatientKatheter(patient patient)
        {
            MySqlDataReader reader = null;
            List<Katheter> kathList = new List<Katheter>();
            try
            {
                string stmt = "SELECT * FROM katheter WHERE PatID=" + patient.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kathList.Add(new Katheter(reader.GetString(2), reader.GetDateTime(3)));
                }
                dbConn.closeConn();
                return kathList;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public List<Medicatie> returnPatientMedicatie(patient patient)
        {
            MySqlDataReader reader = null;
            List<Medicatie> mediList = new List<Medicatie>();
            try
            {
                string stmt = "SELECT * FROM medicatie WHERE PatID=" + patient.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mediList.Add(new Medicatie(reader.GetString(2), reader.GetInt32(3), reader.GetString(4)));
                }
                dbConn.closeConn();
                return mediList;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }


        public List<NIV> returnPatientNiv(patient patient)
        {
            List<NIV> nivlist = new List<NIV>();
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM NIV WHERE PatID=" + patient.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nivlist.Add(new NIV(reader.GetDateTime(2), reader.GetDateTime(3)));
                }
                dbConn.closeConn();
                return nivlist;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public List<Onderzoek> returnPatientonderzoek(patient patient)
        {
            List<Onderzoek> onderzoekList = new List<Onderzoek>();
            MySqlDataReader reader = null;
            try
            {
                string stmt = "SELECT * FROM onderzoek WHERE PatID=" + patient.Id;
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    onderzoekList.Add(new Onderzoek(reader.GetString(2)));
                }
                dbConn.closeConn();
                return onderzoekList;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }
        }

        public List<string> getWoonplaatsen()
        {
            try
            {
                List<string> woonplaatsenlijst = new List<string>();
                MySqlDataReader reader = null;
                string stmt = "SELECT * FROM woonplaats ";
                MySqlCommand cmd = new MySqlCommand(stmt, dbConn.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    woonplaatsenlijst.Add(reader.GetString(1));
                }
                dbConn.closeConn();
                return woonplaatsenlijst;

            }
            catch (MySqlException ex)
            {
                throw new FieldAccessException("Error: " + ex.ToString());
            }

        }


        public bool addpatient(patient pat)
        {
            try
            {
                string sqlDateFormat = "yyyy/MM/dd H:mm";
                string gebDatum = pat.Geboortedatum.ToString(sqlDateFormat);
                dbConn.closeConn();
                string stmt = "Insert Into patientData(inschrijvingsnr,naam,voornaam,geslacht,geboortedatum,woonplaats) Values('" + pat.Inschrijvingsnr + "','" + pat.Naam + "','" + pat.Voornaam + "','" + pat.Geslacht + "','" + gebDatum + "','" + pat.Woonplaats + "');select last_insert_id();  ";
                MySqlCommand insertcommand = new MySqlCommand(stmt, dbConn.getConn());

                int newID = Convert.ToInt32(insertcommand.ExecuteScalar());

                string opnameDatum = pat.TijdOpname.ToString(sqlDateFormat);
                string ontslagDatum = pat.TijdOntslag.ToString(sqlDateFormat);
                string thoraxDatum = pat.Thoraxdrain.ToString(sqlDateFormat);
                string maagDatum = pat.Maagsonde.ToString(sqlDateFormat);
                string blaasDatum = pat.Blaassonde.ToString(sqlDateFormat);
                string pdaDatum = pat.Pda.ToString(sqlDateFormat);
                string pceaDatum = pat.Pcea.ToString(sqlDateFormat);
                string pciaDatum = pat.Pcia.ToString(sqlDateFormat);
                insertcommand.Parameters.Clear();
                insertcommand.CommandText = "Insert INTO patientMedic Values('" + newID + "','" + pat.Box + "','" + opnameDatum + "','" + ontslagDatum + "','" + pat.Komtvan + "','" + pat.Gaatnaar + "','" + pat.Gaatnaarkamer + "','" + pat.CoordArts + "','" + pat.BehandelArts + "','" + pat.Diagnose + "','" +
                    pat.DnrCode + "','" + pat.Anamnese + "','" + pat.ThuisMed + "','" + Convert.ToInt32(pat.HasKathether) + "','" + Convert.ToInt32(pat.Arterieel) + "','" + Convert.ToInt32(pat.Cvd) + "','" + Convert.ToInt32(pat.Picco) + "','" + Convert.ToInt32(pat.SwanGans) + "','" + Convert.ToInt32(pat.TempoPM) + "','"
                    + Convert.ToInt32(pat.PMimplant1) + "','" + Convert.ToInt32(pat.CardiaTromb) + "','" + Convert.ToInt32(pat.NietCardTromb) + "','" + Convert.ToInt32(pat.Gif) + "','" + Convert.ToInt32(pat.RefMZG) + "','" + thoraxDatum + "','" + maagDatum + "','" + blaasDatum + "','" + pdaDatum + "','" + pceaDatum + "','"
                    + pciaDatum + "','" + Convert.ToInt32(pat.Beademing) + "','" + Convert.ToInt32(pat.HasNiv) + "','" + pat.Ritme + "','" + pat.WhatIsP + "','" + pat.Bd + "','" + pat.Dieet + "','" + Convert.ToInt32(pat.Sv) + "','" + pat.Telemetrie + "','" + Convert.ToInt32(pat.Kine) + "','" + Convert.ToInt32(pat.Zalving)
                    + "','" + Convert.ToInt32(pat.Medicatie) + "','" + Convert.ToInt32(pat.Infuus) + "','" + pat.PceaUitleg + "','" + pat.PceaUitlegAt1 + "','" + Convert.ToInt32(pat.Drains) + "','" + pat.Onderzoek + "','" + pat.Zorgen + "','" + pat.Verpleegkundige + "','" + pat.Verslag + "');";
                insertcommand.ExecuteNonQuery();

                if (pat.Beademing)
                {
                    string beademDatum;
                    string beademStopDatum;
                    foreach (Beademing bead in pat.BeadList)
                    {
                        beademDatum = bead.BeadStart.ToString(sqlDateFormat);
                        beademStopDatum = bead.BeadStop.ToString(sqlDateFormat);
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into beademing VALUES (null,'" + newID + "','" + beademDatum + "','" + beademStopDatum + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                if (pat.Drains)
                {
                    foreach (Drains drain in pat.DrainList)
                    {
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into drains VALUES (null,'" + newID + "','" + drain.DrainInfo + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                if (pat.Drains)
                {
                    foreach (Drains drain in pat.DrainList)
                    {
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into drains VALUES (null,'" + newID + "','" + drain.DrainInfo + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                if (pat.Infuus)
                {
                    foreach (Infuus fuus in pat.InfuusList)
                    {
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into infuus VALUES (null,'" + newID + "','" + fuus.InfuusData + "','" + fuus.UrenAanGehangen + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                if (pat.HasKathether)
                {
                    string kathDatum;
                    foreach (Katheter kath in pat.KathList)
                    {
                        kathDatum = kath.KathDatum.ToString(sqlDateFormat);
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into katheter VALUES (null,'" + newID + "','" + kath.KathType + "','" + kathDatum + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                if (pat.Medicatie)
                {
                    foreach (Medicatie medic in pat.MedicList)
                    {
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into medicatie VALUES (null,'" + newID + "','" + medic.MedicatieType + "','" + medic.Aantal + "','" + medic.Manier + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                if (pat.HasNiv)
                {
                    string nivstartDatum;
                    string nivStopDatum;
                    foreach (NIV nivtje in pat.Nivlist)
                    {
                        nivstartDatum = nivtje.Start.ToString(sqlDateFormat);
                        nivStopDatum = nivtje.Stop.ToString(sqlDateFormat);
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into NIV VALUES (null,'" + newID + "','" + nivstartDatum + "','" + nivStopDatum + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                if (pat.Onderzoek)
                {
                    foreach (Onderzoek onderz in pat.OnderzoekList)
                    {
                        insertcommand.Parameters.Clear();
                        insertcommand.CommandText = "insert into onderzoek VALUES (null,'" + newID + "','" + onderz.OnderzoekInfo + "');";
                        insertcommand.ExecuteNonQuery();
                    }
                }
                MySqlDataReader reader;
                insertcommand.Parameters.Clear();
                insertcommand.CommandText = "select * from woonplaats";
                reader = insertcommand.ExecuteReader();
                bool alreadyInList = false;
                while (reader.Read())
                {
                    if (reader.GetString(1) == pat.Woonplaats)
                    {
                        alreadyInList = true;
                    }
                }
                if (!alreadyInList)
                {
                    insertcommand.Parameters.Clear();
                    insertcommand.CommandText = "insert into woonplaats values(null,'" + pat.Woonplaats + "');";
                    insertcommand.ExecuteNonQuery();
                }

                dbConn.closeConn();


                return true;
            }
            catch (Exception e)
            {
                string a = e.Message;
                return false;
            }
        }
        public bool updatepatient(patient pat)
        {
            string sqlDateFormat = "yyyy/MM/dd H:mm";
            dbConn.closeConn();
            string gebDatum = pat.Geboortedatum.ToString(sqlDateFormat);
            string stmt = "update patientData set inschrijvingsnr='" + pat.Inschrijvingsnr + "',naam='" + pat.Naam + "',voornaam='" + pat.Voornaam + "',geslacht='" + pat.Geslacht + "',geboortedatum='" + gebDatum + "',woonplaats='" + pat.Woonplaats + "' where ID='" + pat.Id + "' ;";
            MySqlCommand updatecommand = new MySqlCommand(stmt, dbConn.getConn());
            updatecommand.ExecuteNonQuery();

            int newID = pat.Id;

            updatecommand.Parameters.Clear();
            string opnameDatum = pat.TijdOpname.ToString(sqlDateFormat);
            string ontslagDatum = pat.TijdOntslag.ToString(sqlDateFormat);
            string thoraxDatum = pat.Thoraxdrain.ToString(sqlDateFormat);
            string maagDatum = pat.Maagsonde.ToString(sqlDateFormat);
            string blaasDatum = pat.Blaassonde.ToString(sqlDateFormat);
            string pdaDatum = pat.Pda.ToString(sqlDateFormat);
            string pceaDatum = pat.Pcea.ToString(sqlDateFormat);
            string pciaDatum = pat.Pcia.ToString(sqlDateFormat);




            updatecommand.CommandText = "update patientMedic set box='" + pat.Box + "',datumOpname='" + opnameDatum + "',datumOntslag='" + ontslagDatum + "',komtvandienst='" + pat.Komtvan + "',gaatnaardienst='" + pat.Gaatnaar + "',ontslagkamer='" + pat.Gaatnaarkamer + "',coordinerendeArts='" + pat.CoordArts + "',behandelendeArts='" + pat.BehandelArts + "',diagnose='" + pat.Diagnose +
                "',DNR='" + pat.DnrCode + "',anamnese='" + pat.Anamnese + "',thuismedicatie='" + pat.ThuisMed + "',katheter='" + Convert.ToInt32(pat.HasKathether) + "',arteriel='" + Convert.ToInt32(pat.Arterieel) + "',cvd='" + Convert.ToInt32(pat.Cvd) + "',picco='" + Convert.ToInt32(pat.Picco) + "',swanGans='" + Convert.ToInt32(pat.SwanGans) + "',temporairePM='" + Convert.ToInt32(pat.TempoPM) + "',PMimplantatie='" + Convert.ToInt32(pat.PMimplant1)
                + "',cardialeTrombo='" + Convert.ToInt32(pat.CardiaTromb) + "',nietCardialeTrombo='" + Convert.ToInt32(pat.NietCardTromb) + "',gift='" + Convert.ToInt32(pat.Gif) + "',refMzg='" + Convert.ToInt32(pat.RefMZG) + "',thoraxDrain='" + thoraxDatum + "',maagsonde='" + maagDatum + "',blaassonde='" + blaasDatum + "',PDA='" + pdaDatum + "',PCEA='" + pceaDatum + "',PCIA='" + pciaDatum + "',beademing='" + Convert.ToInt32(pat.Beademing) + "',niv='"
                + Convert.ToInt32(pat.HasNiv) + "',ritme='" + pat.Ritme + "',P='" + pat.WhatIsP + "',BD='" + pat.Bd + "',dieet='" + pat.Dieet + "',SV='" + Convert.ToInt32(pat.Sv) + "',telemetrie='" + pat.Telemetrie + "',kine='" + Convert.ToInt32(pat.Kine) + "',zalving='" + Convert.ToInt32(pat.Zalving) + "',medicatie='" + Convert.ToInt32(pat.Medicatie) + "',infuus='" + Convert.ToInt32(pat.Infuus) + "',PDAPCEA='" + pat.PceaUitleg + "',PCEAPDAX='" + pat.PceaUitlegAt1 + "',drains='" + Convert.ToInt32(pat.Drains) + "',onderzoek='" + Convert.ToInt32(pat.Onderzoek) + "',zorgen='" + pat.Zorgen + "',vpk='" + pat.Verpleegkundige + "',verslag='" + pat.Verslag + "' where ID='" + newID + "';";
            updatecommand.ExecuteNonQuery();

            if (pat.Beademing)
            {
                #region add/update beademing
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "select * from beademing WHERE PatID='" + newID + "';";
                MySqlDataReader reader = null;
                reader = updatecommand.ExecuteReader();
                int counter = 0;
                List<string> commandList = new List<string>();
                string beademStartDatum;
                string beademStopDatum;
                while (reader.Read())
                {
                    beademStartDatum = pat.BeadList[counter].BeadStart.ToString(sqlDateFormat);
                    beademStopDatum = pat.BeadList[counter].BeadStop.ToString(sqlDateFormat);
                    commandList.Add("update beademing SET datumStart='" + beademStartDatum + "',datumStop='" + beademStopDatum + "' where ID='" + reader.GetInt32(0) + "';");

                }
                reader.Close();
                for (int i = 0; i < commandList.Count(); i++)
                {
                    updatecommand.Parameters.Clear();
                    updatecommand.CommandText = commandList[i];
                    updatecommand.ExecuteNonQuery();
                    counter++;
                }
                counter++;
                if (pat.BeadList.Count > counter)
                {
                    while (pat.BeadList.Count > counter)
                    {
                        {
                            beademStartDatum = pat.BeadList[counter].BeadStart.ToString(sqlDateFormat);
                            beademStopDatum = pat.BeadList[counter].BeadStop.ToString(sqlDateFormat);
                            updatecommand.Parameters.Clear();
                            updatecommand.CommandText = "insert into beademing VALUES (null,'" + newID + "','" + beademStartDatum + "','" + beademStopDatum + "');";
                            updatecommand.ExecuteNonQuery();
                            counter++;
                        }
                    }
                }
                #endregion
            }
            if (pat.Drains)
            {
                #region add/update drains
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "select * from drains WHERE PatID='" + newID + "';";
                MySqlDataReader reader = null;
                reader = updatecommand.ExecuteReader();
                int counter = 0;
                List<string> commandList = new List<string>();
                while (reader.Read())
                {

                    commandList.Add("update drains SET draininfo='" + pat.DrainList[counter].DrainInfo + "' where ID='" + reader.GetInt32(0) + "';");


                }
                reader.Close();
                for (int i = 0; i < commandList.Count(); i++)
                {
                    updatecommand.Parameters.Clear();
                    updatecommand.CommandText = commandList[i];
                    updatecommand.ExecuteNonQuery();
                    counter++;
                }
                if (pat.BeadList.Count > counter)
                {
                    while (pat.DrainList.Count > counter)
                    {
                        {
                            updatecommand.Parameters.Clear();
                            updatecommand.CommandText = "insert into drains VALUES (null,'" + newID + "','" + pat.DrainList[counter].DrainInfo + "');";
                            updatecommand.ExecuteNonQuery();
                            counter++;
                        }
                    }
                }
                #endregion
            }
            if (pat.Infuus)
            {
                #region add/update infuus
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "select * from infuus WHERE PatID='" + newID + "';";
                MySqlDataReader reader = null;
                List<string> commandList = new List<string>();
                reader = updatecommand.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    commandList.Add("update infuus SET infuusType='" + pat.InfuusList[counter].InfuusData + "',infuusHoeveel='" + pat.InfuusList[counter].UrenAanGehangen + "' where ID='" + reader.GetInt32(0) + "';");

                }
                reader.Close();
                for (int i = 0; i < commandList.Count(); i++)
                {
                    updatecommand.Parameters.Clear();
                    updatecommand.CommandText = commandList[i];
                    updatecommand.ExecuteNonQuery();
                    counter++;
                }
                if (pat.InfuusList.Count > counter)
                {
                    while (pat.InfuusList.Count > counter)
                    {
                        {
                            updatecommand.Parameters.Clear();
                            updatecommand.CommandText = "insert into infuus VALUES (null,'" + newID + "','" + pat.InfuusList[counter].InfuusData + "','" + pat.InfuusList[counter].UrenAanGehangen + "');";
                            updatecommand.ExecuteNonQuery();
                            counter++;
                        }
                    }
                }
                #endregion
            }

            if (pat.HasKathether)
            {
                #region add/update katheter
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "select * from katheter WHERE PatID='" + newID + "';";
                MySqlDataReader reader = null;
                List<string> commandList = new List<string>();
                reader = updatecommand.ExecuteReader();
                int counter = 0;
                string kathDatum;
                while (reader.Read())
                {
                    kathDatum = pat.KathList[counter].KathDatum.ToString(sqlDateFormat);
                    commandList.Add("update katheter SET KatheterType='" + pat.KathList[counter].KathType + "',datum='" + kathDatum + "' where ID='" + reader.GetInt32(0) + "';");


                }
                reader.Close();
                for (int i = 0; i < commandList.Count(); i++)
                {
                    updatecommand.Parameters.Clear();
                    updatecommand.CommandText = commandList[i];
                    updatecommand.ExecuteNonQuery();
                    counter++;
                }
                if (pat.KathList.Count > counter)
                {
                    while (pat.KathList.Count > counter)
                    {
                        {
                            kathDatum = pat.KathList[counter].KathDatum.ToString(sqlDateFormat);
                            updatecommand.Parameters.Clear();
                            updatecommand.CommandText = "insert into katheter VALUES (null,'" + newID + "','" + pat.KathList[counter].KathType + "','" + kathDatum + "');";
                            updatecommand.ExecuteNonQuery();
                            counter++;
                        }
                    }

                }
                #endregion
            }
            if (pat.Medicatie)
            {
                #region add/update medicatie
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "select * from medicatie WHERE PatID='" + newID + "';";
                MySqlDataReader reader = null;
                List<string> commandList = new List<string>();
                reader = updatecommand.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    commandList.Add("update medicatie SET type='" + pat.MedicList[counter].MedicatieType + "',aantal='" + pat.MedicList[counter].Aantal + "',methode='" + pat.MedicList[counter].Manier + "' where ID='" + reader.GetInt32(0) + "';");


                }
                reader.Close();
                for (int i = 0; i < commandList.Count(); i++)
                {
                    updatecommand.Parameters.Clear();
                    updatecommand.CommandText = commandList[i];
                    updatecommand.ExecuteNonQuery();
                    counter++;
                }
                if (pat.MedicList.Count > counter)
                {
                    while (pat.MedicList.Count > counter)
                    {
                        {
                            updatecommand.Parameters.Clear();
                            updatecommand.CommandText = "insert into medicatie VALUES (null,'" + newID + "','" + pat.MedicList[counter].MedicatieType + "','" + pat.MedicList[counter].Aantal + "','" + pat.MedicList[counter].Manier + "');";
                            updatecommand.ExecuteNonQuery();
                            counter++;
                        }
                    }

                }
                #endregion
            }
            if (pat.HasNiv)
            {
                #region add/update NIV
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "select * from NIV WHERE PatID='" + newID + "';";
                MySqlDataReader reader = null;
                List<string> commandList = new List<string>();
                reader = updatecommand.ExecuteReader();
                int counter = 0;
                string nivStartDatum;
                string nivStopdatum;
                while (reader.Read())
                {
                    nivStartDatum = pat.Nivlist[counter].Start.ToString(sqlDateFormat);
                    nivStopdatum = pat.Nivlist[counter].Stop.ToString(sqlDateFormat);
                    commandList.Add("update NIV SET datumStart='" + nivStartDatum + "',datumStop='" + nivStopdatum + "' where ID='" + reader.GetInt32(0) + "';");


                }
                reader.Close();
                for (int i = 0; i < commandList.Count(); i++)
                {
                    updatecommand.Parameters.Clear();
                    updatecommand.CommandText = commandList[i];
                    updatecommand.ExecuteNonQuery();
                    counter++;
                }
                if (pat.Nivlist.Count > counter)
                {
                    while (pat.Nivlist.Count > counter)
                    {
                        {
                            updatecommand.Parameters.Clear();
                            updatecommand.CommandText = "insert into NIV VALUES (null,'" + newID + "','" + pat.Nivlist[counter].Start + "','" + pat.Nivlist[counter].Stop + "');";
                            updatecommand.ExecuteNonQuery();
                            counter++;
                        }
                    }

                }
                #endregion

            }
            if (pat.Onderzoek)
            {
                #region add/update onderzoek
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "select * from onderzoek WHERE PatID='" + newID + "';";
                MySqlDataReader reader = null;
                List<string> commandList = new List<string>();
                reader = updatecommand.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    commandList.Add("update onderzoek SET onderzoekInfo='" + pat.OnderzoekList[counter].OnderzoekInfo + "' where ID='" + reader.GetInt32(0) + "';");


                }
                reader.Close();
                for (int i = 0; i < commandList.Count(); i++)
                {
                    updatecommand.Parameters.Clear();
                    updatecommand.CommandText = commandList[i];
                    updatecommand.ExecuteNonQuery();
                    counter++;
                }
                if (pat.OnderzoekList.Count > counter)
                {
                    while (pat.OnderzoekList.Count > counter)
                    {
                        {
                            updatecommand.Parameters.Clear();
                            updatecommand.CommandText = "insert into onderzoek VALUES (null,'" + newID + "','" + pat.OnderzoekList[counter].OnderzoekInfo + "');";
                            updatecommand.ExecuteNonQuery();
                            counter++;
                        }
                    }

                }
                #endregion
            }
            

            MySqlDataReader woonplaatsreader;
            updatecommand.Parameters.Clear();
            updatecommand.CommandText = "select * from woonplaats";
            woonplaatsreader = updatecommand.ExecuteReader();
            bool alreadyInList = false;
            while (woonplaatsreader.Read())
            {
                if (woonplaatsreader.GetString(1) == pat.Woonplaats)
                {
                    alreadyInList = true;
                }
            }
            woonplaatsreader.Close();
            if (!alreadyInList)
            {
                updatecommand.Parameters.Clear();
                updatecommand.CommandText = "insert into woonplaats values(null,'" + pat.Woonplaats + "');";
                updatecommand.ExecuteNonQuery();
            }


            dbConn.closeConn();


            return true;

        }


    }
}
