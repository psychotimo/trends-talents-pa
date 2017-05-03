using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logic;

namespace GUI
{
    public partial class Form1 : Form
    {
        dbfuncties dbconn = new dbfuncties();
        List<patient> patientList = new List<patient>();
        int counter = 0;
        string dateformat = "dd/MM/yyyy";
        string timeformat = "HH:mm";
        public Form1()
        {
            InitializeComponent();

            fillcomboboxes();
            this.populatePatList();
            this.populateGUI(counter);


        }

        private void populatePatList()
        {
            List<patient> tempPatList = dbconn.returnAllPatientData();

            foreach (patient pat in tempPatList)
            {
                patient newpat = dbconn.returnPatientMedData(pat);
                if (newpat.Beademing == true)
                {
                    List<Beademing> beademList = dbconn.returnPatientbeademing(pat);
                    newpat.BeadList = beademList;

                }
                if (newpat.Drains == true)
                {
                    List<Drains> tempList = dbconn.returnPatientDrains(pat);
                    newpat.DrainList = tempList;
                }
                if (newpat.Infuus == true)
                {
                    List<Infuus> tempList = dbconn.returnPatientInfuus(pat);
                    newpat.InfuusList = tempList;
                }
                if (newpat.HasKathether == true)
                {
                    List<Katheter> tempList = dbconn.returnPatientKatheter(pat);
                    newpat.KathList = tempList;
                }
                if (newpat.Medicatie == true)
                {
                    List<Medicatie> tempList = dbconn.returnPatientMedicatie(pat);
                    newpat.MedicList = tempList;
                }
                if (newpat.HasNiv == true)
                {
                    List<NIV> tempList = dbconn.returnPatientNiv(pat);
                    newpat.Nivlist = tempList;
                }
                if (newpat.Onderzoek == true)
                {
                    List<Onderzoek> tempList = dbconn.returnPatientonderzoek(pat);
                    newpat.OnderzoekList = tempList;
                }
                patientList.Add(newpat);

            }
            patientList.Add(new patient(0, 0, "", "", "", DateTime.Now, ""));
        }

        private void populateGUI(int counter)
        {
            cleanGui();
            this.patNrBox.Text = patientList[counter].Id.ToString();
            this.boxBox.Text = patientList[counter].Box.ToString();
            this.gif.Checked = patientList[counter].Gif;
            this.inschrijvingsBox.Text = patientList[counter].Inschrijvingsnr.ToString();
            this.naamBox.Text = patientList[counter].Naam;
            this.voornaamBox.Text = patientList[counter].Voornaam;

            if (patientList[counter].Geslacht.ToUpper() == "MAN" || patientList[counter].Geslacht.ToUpper() == "M")
            {
                this.geslachtBox.Text = "M";
            }
            else
            {
                this.geslachtBox.Text = "V";
            }
            this.geboortedatumBox.Text = patientList[counter].Geboortedatum.ToString(dateformat);
            //leeftijdberekening, huidig jaar-geboortejaar, rekening houden met huidige datum voor of na verjaardag
            DateTime vandaag = DateTime.Today;
            int leeftijd = vandaag.Year - patientList[counter].Geboortedatum.Year;
            if (vandaag < patientList[counter].Geboortedatum.AddYears(leeftijd))
            {
                leeftijd--;
            }
            this.ageLabel.Text = leeftijd.ToString();
            this.woonplaatsbox.Text = patientList[counter].Woonplaats;

            this.opnameDatum.Text = patientList[counter].TijdOpname.ToString(dateformat);
            this.opnameUur.Text = patientList[counter].TijdOpname.ToString(timeformat);
            this.ontslagDatumBox.Text = patientList[counter].TijdOntslag.ToString(dateformat);
            this.ontslagUur.Text = patientList[counter].TijdOntslag.ToString(timeformat);
            this.komtVanBox.Text = patientList[counter].Komtvan;
            this.gaatNaarBox.Text = patientList[counter].Gaatnaar;
            this.gaatnaarKamer.Text = patientList[counter].Gaatnaarkamer.ToString();

            this.coordArts.Text = patientList[counter].CoordArts;
            this.behandArts.Text = patientList[counter].BehandelArts;
            this.diagnose.Text = patientList[counter].Diagnose;
            this.dnrDrop.Text = patientList[counter].DnrCode.ToString();
            this.anamnese.Text = patientList[counter].Anamnese;
            this.thuismedicatie.Text = patientList[counter].ThuisMed;


            if (patientList[counter].HasKathether)
            {
                #region populate katheters wanneer nodig
                for (int i = 1; i <= patientList[counter].KathList.Count(); i++)
                {
                    string tempKathMetName = "kathMet" + i;
                    string tempKathDateName = "kathDate" + i;

                    var tempKathMetNode = this.Controls.Find(tempKathMetName, true);
                    var tempKathDateNode = this.Controls.Find(tempKathDateName, true);

                    tempKathMetNode[0].Text = patientList[counter].KathList[i - 1].KathType;
                    tempKathDateNode[0].Text = patientList[counter].KathList[i - 1].KathDatum.ToString("dd-MM-yyyy");

                }
                #endregion
            }

            this.thoraxDate.Text = patientList[counter].Thoraxdrain.ToString(dateformat);
            this.sondeDatum.Text = patientList[counter].Maagsonde.ToString(dateformat);
            this.blaasDatum.Text = patientList[counter].Blaassonde.ToString(dateformat);
            this.pdaDatum.Text = patientList[counter].Pda.ToString(dateformat);
            this.pceaDatum.Text = patientList[counter].Pcea.ToString(dateformat);
            this.pciaDatum.Text = patientList[counter].Pcia.ToString(dateformat);

            this.arteriele.Checked = patientList[counter].Arterieel;
            this.picco.Checked = patientList[counter].Picco;
            this.cvd.Checked = patientList[counter].Cvd;
            this.swangans.Checked = patientList[counter].SwanGans;
            this.pmImp.Checked = patientList[counter].PMimplant1;
            this.tempPm.Checked = patientList[counter].TempoPM;
            this.cardTromb.Checked = patientList[counter].CardiaTromb;
            this.niCardTromb.Checked = patientList[counter].NietCardTromb;
            //tab2
            if (patientList[counter].Beademing)
            {
                #region populate beademing
                for (int i = 0; i < patientList[counter].BeadList.Count(); i++)
                {
                    if (i == 0)
                    {
                        this.ademStart1.Text = patientList[counter].BeadList[i].BeadStart.ToString(dateformat);
                        this.ademStartU1.Text = patientList[counter].BeadList[i].BeadStart.ToString(timeformat);
                        this.ademStop1.Text = patientList[counter].BeadList[i].BeadStop.ToString(dateformat);
                        this.ademStopU1.Text = patientList[counter].BeadList[i].BeadStop.ToString(timeformat);
                    }
                    if (i == 1)
                    {
                        this.ademStart2.Text = patientList[counter].BeadList[i].BeadStart.ToString(dateformat);
                        this.ademStartU2.Text = patientList[counter].BeadList[i].BeadStart.ToString(timeformat);
                        this.ademStop2.Text = patientList[counter].BeadList[i].BeadStop.ToString(dateformat);
                        this.ademStopU2.Text = patientList[counter].BeadList[i].BeadStop.ToString(timeformat);
                    }
                    if (i == 2)
                    {
                        this.ademStart3.Text = patientList[counter].BeadList[i].BeadStart.ToString(dateformat);
                        this.ademStartU3.Text = patientList[counter].BeadList[i].BeadStart.ToString(timeformat);
                        this.ademStop3.Text = patientList[counter].BeadList[i].BeadStop.ToString(dateformat);
                        this.ademStopU3.Text = patientList[counter].BeadList[i].BeadStop.ToString(timeformat);
                    }
                    #endregion

                }
            }

            if (patientList[counter].HasNiv)
            {
                List<Panel> panelList = guiFcts.getNivPanels(patientList[counter].Nivlist);
                foreach (var paneel in panelList)
                {
                    this.nivFlowPanel.Controls.Add(paneel);
                }
            }
            else
            {
                List<Panel> panelList = guiFcts.get1NivPanel();
                foreach (var paneel in panelList)
                {
                    this.nivFlowPanel.Controls.Add(paneel);
                }

            }
            //tab3
            this.ritmeBox.Text = patientList[counter].Ritme;
            this.pressureBox.Text = patientList[counter].WhatIsP.ToString();
            this.bloedDrukBox.Text = patientList[counter].Bd;
            this.Dieet.Text = patientList[counter].Dieet;
            this.svCheckbox.Checked = patientList[counter].Sv;
            this.teleCombo.Text = patientList[counter].Telemetrie.ToString();
            this.KineCheckBox.Checked = patientList[counter].Kine;
            this.zalvingCheckBox.Checked = patientList[counter].Zalving;


            if (patientList[counter].Medicatie)
            {
                #region populate medicatielijst
                for (int i = 1; i <= patientList[counter].MedicList.Count(); i++)
                {
                    string tempTextName = "medicText" + i;
                    string tempAantName = "medicper" + i;
                    string tempMethName = "medicMeth" + i;
                    var tempTextNode = this.Controls.Find(tempTextName, true);
                    var tempAantNode = this.Controls.Find(tempAantName, true);
                    var tempMetNode = this.Controls.Find(tempMethName, true);
                    tempTextNode[0].Text = patientList[counter].MedicList[i - 1].MedicatieType;
                    tempAantNode[0].Text = patientList[counter].MedicList[i - 1].Aantal.ToString();
                    tempMetNode[0].Text = patientList[counter].MedicList[i - 1].Manier;
                }
                #endregion
            }
            else
            {
                for (int i = 1; i <= 20; i++)
                {
                    string tempTextName = "medicText" + i;
                    string tempAantName = "medicper" + i;
                    string tempMethName = "medicMeth" + i;
                    var tempTextNode = this.Controls.Find(tempTextName, true);
                    var tempAantNode = this.Controls.Find(tempAantName, true);
                    var tempMetNode = this.Controls.Find(tempMethName, true);
                    tempTextNode[0].Text = "";
                    tempAantNode[0].Text = "";
                    tempMetNode[0].Text = "";
                }

            }
            if (patientList[counter].Infuus)
            {
                #region populate infuus
                for (int i = 1; i <= patientList[counter].InfuusList.Count(); i++)
                {
                    string tempinfuusName = "infuustext" + i;
                    string tempinfMiniName = "infuusMini" + i;

                    var tempTextNode = this.Controls.Find(tempinfuusName, true);
                    var tempMiniNode = this.Controls.Find(tempinfMiniName, true);

                    tempTextNode[0].Text = patientList[counter].InfuusList[i - 1].InfuusData;
                    tempMiniNode[0].Text = patientList[counter].InfuusList[i - 1].UrenAanGehangen.ToString();

                }
                #endregion

            }

            this.pdaText.Text = patientList[counter].PceaUitleg;
            this.pdaMini.Text = patientList[counter].PceaUitlegAt1;
            this.zorgbox.Text = patientList[counter].Zorgen;

            if (patientList[counter].Drains)
            {
                #region populate drains
                for (int i = 1; i <= patientList[counter].DrainList.Count(); i++)
                {
                    string tempDrainName = "drainbox" + i;
                    var tempDrainNode = this.Controls.Find(tempDrainName, true);
                    tempDrainNode[0].Text = patientList[counter].DrainList[i - 1].DrainInfo;

                }
                #endregion
            }

            if (patientList[counter].Onderzoek)
            {
                #region populate onderzoek
                for (int i = 1; i <= patientList[counter].OnderzoekList.Count(); i++)
                {
                    string tempOndName = "onderzoekbox" + i;
                    var tempOndNode = this.Controls.Find(tempOndName, true);
                    tempOndNode[0].Text = patientList[counter].OnderzoekList[i - 1].OnderzoekInfo;

                }
                #endregion
            }

            //tab4
            this.verpleegkundigeBox.Text = patientList[counter].Verpleegkundige;
            this.VerslagBox.Text = patientList[counter].Verslag;

            //overviewlabel

            this.fullnameLabel.Text = "naam: " + patientList[counter].Naam + " , " + patientList[counter].Voornaam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                MessageBox.Show("u kan niet verder terug");
            }
            else
            {
                counter--;

                populateGUI(counter);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter + 1 < patientList.Count())
            {
                counter++;

                populateGUI(counter);
            }
            else
            {
                MessageBox.Show("laatste patient bereikt");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter = patientList.Count() - 1;

            populateGUI(counter);
        }

        private patient getNewPatient()
        {
            int patientnr = 0;
            int inschrijvingsnr = 0;
            if (int.TryParse(this.patNrBox.Text, out patientnr) && int.TryParse(this.inschrijvingsBox.Text, out inschrijvingsnr))
            {
                try
                {

                    DateTime tempdate = DateTime.Parse(this.geboortedatumBox.Text);
                    patient tempPat = new patient(patientnr, inschrijvingsnr, this.naamBox.Text, this.voornaamBox.Text, this.geslachtBox.Text, tempdate, this.woonplaatsbox.Text); ;


                    int tempbox;

                    if (int.TryParse(this.boxBox.Text, out tempbox))
                    {
                        tempPat.Box = tempbox;
                    };
                    tempPat.Gif = this.gif.Checked;
                    char[] timedelimiter = { ':', ',', '.' };
                    DateTime tempopname = DateTime.Parse(this.opnameDatum.Text);

                    string[] opnamesplit = this.opnameUur.Text.Split(timedelimiter, System.StringSplitOptions.RemoveEmptyEntries);
                    tempopname = tempopname.AddHours(Convert.ToDouble(opnamesplit[0]));
                    tempopname = tempopname.AddMinutes(Convert.ToDouble(opnamesplit[1]));
                    tempPat.TijdOpname = tempopname;
                    DateTime tempontslag = DateTime.Parse(this.ontslagDatumBox.Text);

                    string[] ontslagsplit = this.ontslagUur.Text.Split(timedelimiter, System.StringSplitOptions.RemoveEmptyEntries);
                    tempontslag = tempontslag.AddHours(Convert.ToDouble(ontslagsplit[0]));
                    tempontslag = tempontslag.AddMinutes(Convert.ToDouble(ontslagsplit[1]));
                    tempPat.TijdOntslag = tempontslag;
                    tempPat.Komtvan = this.komtVanBox.Text;
                    tempPat.Gaatnaar = this.gaatNaarBox.Text;
                    if (this.gaatnaarKamer.Text != "")
                    {
                        tempPat.Gaatnaarkamer = Convert.ToInt32(this.gaatnaarKamer.Text);
                    }

                    tempPat.CoordArts = this.coordArts.Text;
                    tempPat.BehandelArts = this.behandArts.Text;
                    tempPat.Diagnose = this.diagnose.Text;
                    tempPat.DnrCode = Convert.ToInt32(this.dnrDrop.Text);
                    tempPat.Anamnese = this.anamnese.Text;
                    tempPat.ThuisMed = this.thuismedicatie.Text;

                    List<Katheter> tempKathlist = new List<Katheter>();
                    tempPat.HasKathether = false;
                    for (int i = 1; i <= 5; i++)
                    {
                        string tempkathmet = "kathMet" + i;
                        string tempkathDate = "kathDate" + i;
                        var kathmet = this.Controls.Find(tempkathmet, true);
                        var kathDate = this.Controls.Find(tempkathDate, true);
                        if (kathmet[0].Text != "" && kathDate[0].Text != "")
                        {
                            tempPat.HasKathether = true;
                            tempKathlist.Add(new Katheter(kathmet[0].Text, DateTime.Parse(kathDate[0].Text)));
                        }
                    }
                    tempPat.KathList = tempKathlist;


                    tempPat.Thoraxdrain = DateTime.Parse(this.thoraxDate.Text);
                    tempPat.Maagsonde = DateTime.Parse(this.sondeDatum.Text);
                    tempPat.Blaassonde = DateTime.Parse(this.sondeDatum.Text);
                    tempPat.Pda = DateTime.Parse(this.pdaDatum.Text);
                    tempPat.Pcea = DateTime.Parse(this.pceaDatum.Text);
                    tempPat.Pcia = DateTime.Parse(this.pciaDatum.Text);

                    tempPat.Arterieel = this.arteriele.Checked;
                    tempPat.Picco = this.picco.Checked;
                    tempPat.Cvd = this.cvd.Checked;
                    tempPat.SwanGans = this.swangans.Checked;
                    tempPat.PMimplant1 = this.pmImp.Checked;
                    tempPat.TempoPM = this.tempPm.Checked;
                    tempPat.CardiaTromb = this.cardTromb.Checked;
                    tempPat.NietCardTromb = this.niCardTromb.Checked;
                    //tab2

                    List<Beademing> tempademlist = new List<Beademing>();
                    tempPat.Beademing = false;
                    for (int i = 1; i <= 3; i++)
                    {
                        string tempAdemStart = "ademStart" + i;
                        string tempAdemStartU = "ademStartU" + i;
                        string tempAdemStop = "ademStop" + i;
                        string tempAdemStopU = "ademStopU" + i;

                        var ademstart = this.Controls.Find(tempAdemStart, true);
                        var ademstartu = this.Controls.Find(tempAdemStartU, true);
                        var ademstop = this.Controls.Find(tempAdemStop, true);
                        var ademstopu = this.Controls.Find(tempAdemStopU, true);
                        if (ademstart[0].Text != "" && ademstartu[0].Text != "")
                        {
                            DateTime tempAdemsta = DateTime.Parse(ademstart[0].Text);
                            DateTime tempAdemsto;
                            string[] ademstartsplit = ademstartu[0].Text.Split(timedelimiter, System.StringSplitOptions.RemoveEmptyEntries);
                            tempAdemsta = tempAdemsta.AddHours(Convert.ToDouble(ademstartsplit[0]));
                            tempAdemsta = tempAdemsta.AddMinutes(Convert.ToDouble(ademstartsplit[1]));

                            if (ademstop[0].Text != "" && ademstopu[0].Text != "")
                            {
                                tempAdemsto = DateTime.Parse(ademstop[0].Text);
                                string[] ademstopsplit = ademstopu[0].Text.Split(timedelimiter, System.StringSplitOptions.RemoveEmptyEntries);
                                tempAdemsto = tempAdemsto.AddHours(Convert.ToDouble(ademstopsplit[0]));
                                tempAdemsto = tempAdemsto.AddMinutes(Convert.ToDouble(ademstopsplit[1]));
                            }
                            else
                            {
                                tempAdemsto = DateTime.MinValue;
                            }
                            tempPat.Beademing = true;
                            tempademlist.Add(new Beademing(tempAdemsta, tempAdemsto));
                        }
                    }
                    tempPat.BeadList = tempademlist;

                    List<NIV> tempNivList = new List<NIV>();
                    tempPat.HasNiv = false;
                    for (int i = 1; i <= nivFlowPanel.Controls.Count; i++)
                    {
                        string tempstopNiv = "stopniv" + i;
                        string tempstopNivU = "stopnivU" + i;
                        string tempstartniv = "startniv" + i;
                        string tempstartnivU = "startnivU" + i;

                        var startNiv = this.Controls.Find(tempstartniv, true);
                        var startNivU = this.Controls.Find(tempstartnivU, true);
                        var stopNiv = this.Controls.Find(tempstopNiv, true);
                        var stopNivU = this.Controls.Find(tempstopNivU, true);
                        if (startNiv[0].Text != "" && startNivU[0].Text != "")
                        {
                            DateTime tempnivstart = DateTime.Parse(startNiv[0].Text);

                            string[] nivstartsplit = startNivU[0].Text.Split(timedelimiter, System.StringSplitOptions.RemoveEmptyEntries);
                            tempnivstart = tempnivstart.AddHours(Convert.ToDouble(nivstartsplit[0]));
                            tempnivstart = tempnivstart.AddMinutes(Convert.ToDouble(nivstartsplit[1]));
                            DateTime tempnivstop;
                            if (stopNiv[0].Text != "" && stopNivU[0].Text != "")
                            {
                                tempnivstop = DateTime.Parse(stopNiv[0].Text);
                                string[] nivstopsplit = stopNivU[0].Text.Split(timedelimiter, System.StringSplitOptions.RemoveEmptyEntries);
                                tempnivstop = tempnivstop.AddHours(Convert.ToDouble(nivstopsplit[0]));
                                tempnivstop = tempnivstop.AddMinutes(Convert.ToDouble(nivstopsplit[1]));
                            }
                            else
                            {
                                tempnivstop = DateTime.MinValue;
                            }
                            tempPat.HasNiv = true;
                            tempNivList.Add(new NIV(tempnivstart, tempnivstop));

                        }
                    }
                    tempPat.Nivlist = tempNivList;



                    //tab3

                    tempPat.Ritme = this.ritmeBox.Text;
                    tempPat.WhatIsP = Convert.ToInt32(this.pressureBox.Text);
                    tempPat.Bd = this.bloedDrukBox.Text;
                    tempPat.Dieet = this.Dieet.Text;
                    tempPat.Sv = this.svCheckbox.Checked;
                    tempPat.Telemetrie = Convert.ToInt32(this.teleCombo.Text);
                    tempPat.Kine = this.KineCheckBox.Checked;
                    tempPat.Zalving = this.zalvingCheckBox.Checked;

                    List<Medicatie> tempMedicList = new List<Medicatie>();
                    tempPat.Medicatie = false;
                    for (int i = 1; i <= 20; i++)
                    {
                        string tempTextName = "medicText" + i;
                        string tempAantName = "medicper" + i;
                        string tempMethName = "medicMeth" + i;
                        var tempTextNode = this.Controls.Find(tempTextName, true);
                        var tempAantNode = this.Controls.Find(tempAantName, true);
                        var tempMetNode = this.Controls.Find(tempMethName, true);
                        if (tempTextNode[0].Text != "")
                        {
                            tempPat.Medicatie = true;
                            tempMedicList.Add(new Medicatie(tempTextNode[0].Text, Convert.ToInt32(tempAantNode[0].Text), tempMetNode[0].Text));

                        }
                    }
                    tempPat.MedicList = tempMedicList;

                    List<Infuus> tempInfuusList = new List<Infuus>();
                    tempPat.Infuus = false;

                    for (int i = 1; i <= 3; i++)
                    {
                        string tempinfuusName = "infuustext" + i;
                        string tempinfMiniName = "infuusMini" + i;

                        var tempTextNode = this.Controls.Find(tempinfuusName, true);
                        var tempMiniNode = this.Controls.Find(tempinfMiniName, true);
                        if (tempTextNode[0].Text != "")
                        {
                            tempPat.Infuus = true;
                            tempInfuusList.Add(new Infuus(tempTextNode[0].Text, Convert.ToInt32(tempMiniNode[0].Text)));

                        }


                    }
                    tempPat.InfuusList = tempInfuusList;

                    tempPat.PceaUitleg = this.pdaText.Text;
                    tempPat.PceaUitlegAt1 = this.pdaMini.Text;
                    tempPat.Zorgen = this.zorgbox.Text;


                    List<Drains> tempDrainList = new List<Drains>();
                    tempPat.Drains = false;

                    for (int i = 1; i <= 4; i++)
                    {
                        string tempDrainName = "drainbox" + i;
                        var tempDrainNode = this.Controls.Find(tempDrainName, true);
                        if (tempDrainNode[0].Text != "")
                        {
                            tempPat.Drains = true;
                            tempDrainList.Add(new Drains(tempDrainNode[0].Text));
                        }


                    }
                    tempPat.DrainList = tempDrainList;


                    var tempOnderzoekList = new List<Onderzoek>();
                    tempPat.Onderzoek = false;
                    for (int i = 1; i <= 4; i++)
                    {
                        string tempOndName = "onderzoekbox" + i;
                        var tempOndNode = this.Controls.Find(tempOndName, true);
                        if (tempOndNode[0].Text != "")
                        {
                            tempPat.Onderzoek = true;
                            tempOnderzoekList.Add(new Onderzoek(tempOndNode[0].Text));
                        }


                    }
                    tempPat.OnderzoekList = tempOnderzoekList;


                    //tab4
                    tempPat.Verpleegkundige = this.verpleegkundigeBox.Text;
                    tempPat.Verslag = this.VerslagBox.Text;
                    return tempPat;

                }
                catch (FormatException e)
                {
                    MessageBox.Show("een datum is incorrect geformatteerd: " + e.Message);
                    return new patient(999999999, 0, "", "", "", DateTime.Now, "");
                }
                catch (InvalidCastException e)
                {
                    MessageBox.Show("een datum is incorrect geformatteerd: " + e.Message);
                    return new patient(999999999, 0, "", "", "", DateTime.Now, "");
                }


            }
            else
            {
                MessageBox.Show("gelieve enkel positieve gehele getallen in te vullen bij patientNr en inschrijvingsNr");
                return patientList[patientList.Count() - 1];
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            patient patie = getNewPatient();
            if (patie.Id != 999999999)
            {
                if (patie.Id == 0)
                {
                    dbconn.addpatient(patie);
                    patientList.Clear();
                    populatePatList();
                    counter = patientList.Count() - 1;
                    fillcomboboxes();
                    populateGUI(counter);
                }
                else
                {
                    dbconn.updatepatient(patie);
                    patientList.Clear();
                    populatePatList();
                    fillcomboboxes();
                    populateGUI(counter);
                }
            }



        }



        private void cleanGui()
        {
            this.patNrBox.Text = "";
            this.boxBox.Text = "";
            this.gif.Checked = false;
            this.inschrijvingsBox.Text = "";
            this.naamBox.Text = "";
            this.voornaamBox.Text = "";
            this.geslachtBox.Text = "";
            this.geboortedatumBox.Text = "";
            this.ageLabel.Text = "";
            this.woonplaatsbox.Text = "";

            this.opnameDatum.Text = "";
            this.opnameUur.Text = "";
            this.ontslagDatumBox.Text = "";
            this.ontslagUur.Text = "";
            this.komtVanBox.Text = "";
            this.gaatNaarBox.Text = "";
            this.gaatnaarKamer.Text = "";

            this.coordArts.Text = "";
            this.behandArts.Text = "";
            this.diagnose.Text = "";
            this.dnrDrop.Text = "";
            this.anamnese.Text = "";
            this.thuismedicatie.Text = "";

            #region clean katheters
            for (int i = 1; i <= 5; i++)
            {
                string tempKathMetName = "kathMet" + i;
                string tempKathDateName = "kathDate" + i;

                var tempKathMetNode = this.Controls.Find(tempKathMetName, true);
                var tempKathDateNode = this.Controls.Find(tempKathDateName, true);

                tempKathMetNode[0].Text = "";
                tempKathDateNode[0].Text = "";
            }
            #endregion


            this.thoraxDate.Text = "";
            this.sondeDatum.Text = "";
            this.blaasDatum.Text = "";
            this.pdaDatum.Text = "";
            this.pceaDatum.Text = "";
            this.pciaDatum.Text = "";

            this.arteriele.Checked = false;
            this.picco.Checked = false;
            this.cvd.Checked = false;
            this.swangans.Checked = false;
            this.pmImp.Checked = false;
            this.tempPm.Checked = false;
            this.cardTromb.Checked = false;
            this.niCardTromb.Checked = false;
            //tab2

            #region clean beademing
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    this.ademStart1.Text = DateTime.Today.ToString(dateformat);
                    this.ademStartU1.Text = "00:00";
                    this.ademStop1.Text = DateTime.Today.ToString(dateformat);
                    this.ademStopU1.Text = "00:00";
                }
                if (i == 1)
                {
                    this.ademStart2.Text = DateTime.Today.ToString(dateformat);
                    this.ademStartU2.Text = "00:00";
                    this.ademStop2.Text = DateTime.Today.ToString(dateformat);
                    this.ademStopU2.Text = "00:00";
                }
                if (i == 2)
                {
                    this.ademStart3.Text = DateTime.Today.ToString(dateformat);
                    this.ademStartU3.Text = "00:00";
                    this.ademStop3.Text = DateTime.Today.ToString(dateformat);
                    this.ademStopU3.Text = "00:00";
                }
                #endregion

            }


            nivFlowPanel.Controls.Clear();

            //tab3
            this.ritmeBox.Text = "";
            this.pressureBox.Text = "";
            this.bloedDrukBox.Text = "";
            this.Dieet.Text = "";
            this.svCheckbox.Checked = false;
            this.teleCombo.Text = "";
            this.KineCheckBox.Checked = false;
            this.zalvingCheckBox.Checked = false;



            #region clean medicatielijst
            for (int i = 1; i <= 20; i++)
            {
                string tempTextName = "medicText" + i;
                string tempAantName = "medicper" + i;
                string tempMethName = "medicMeth" + i;
                var tempTextNode = this.Controls.Find(tempTextName, true);
                var tempAantNode = this.Controls.Find(tempAantName, true);
                var tempMetNode = this.Controls.Find(tempMethName, true);
                tempTextNode[0].Text = "";
                tempAantNode[0].Text = "";
                tempMetNode[0].Text = "";
            }
            #endregion


            #region clean infuus
            for (int i = 1; i <= 3; i++)
            {
                string tempinfuusName = "infuustext" + i;
                string tempinfMiniName = "infuusMini" + i;

                var tempTextNode = this.Controls.Find(tempinfuusName, true);
                var tempMiniNode = this.Controls.Find(tempinfMiniName, true);

                tempTextNode[0].Text = "";
                tempMiniNode[0].Text = "";

            }
            #endregion



            this.pdaText.Text = "";
            this.pdaMini.Text = "";
            this.zorgbox.Text = "";


            #region clean drains
            for (int i = 1; i <= 4; i++)
            {
                string tempDrainName = "drainbox" + i;
                var tempDrainNode = this.Controls.Find(tempDrainName, true);
                tempDrainNode[0].Text = "";

            }
            #endregion



            #region clean onderzoek
            for (int i = 1; i <= 4; i++)
            {
                string tempOndName = "onderzoekbox" + i;
                var tempOndNode = this.Controls.Find(tempOndName, true);
                tempOndNode[0].Text = "";

            }
            #endregion


            //tab4
            this.verpleegkundigeBox.Text = "";
            this.VerslagBox.Text = "";
        }


        private void fillcomboboxes()
        {



            for (int i = 1; i <= 20; i++)
            {
                string tempAantName = "medicper" + i;
                string tempMethName = "medicMeth" + i;

                var tempAantNode = this.Controls.Find(tempAantName, true);
                var tempMetNode = this.Controls.Find(tempMethName, true);

                ComboBox tempaantalcombobox = tempAantNode[0] as ComboBox;
                ComboBox tempMethbox = tempMetNode[0] as ComboBox;
                if (tempaantalcombobox is ComboBox || tempMethbox is ComboBox)
                {
                    tempaantalcombobox.Items.Clear();
                    tempaantalcombobox.Items.AddRange(guiFcts.getMedicAantallen());
                    tempMethbox.Items.Clear();
                    tempMethbox.Items.AddRange(guiFcts.getMedicMethodes());

                }

            }
            this.komtVanBox.Items.Clear();
            this.komtVanBox.Items.AddRange(guiFcts.getDiensten());
            this.gaatNaarBox.Items.Clear();
            this.gaatNaarBox.Items.AddRange(guiFcts.getDiensten());
            this.woonplaatsbox.Items.Clear();
            this.woonplaatsbox.Items.AddRange(dbconn.getWoonplaatsen().ToArray());
            this.verpleegkundigeBox.Items.Clear();
            this.verpleegkundigeBox.Items.AddRange(dbconn.getVerpleegkundigen().ToArray());
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print.patientPrint(patientList[counter]);
        }
    }
}
