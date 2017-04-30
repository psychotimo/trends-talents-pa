using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class patient
    {

        private int id;
        private int inschrijvingsnr;
        private string naam;
        private string voornaam;
        private string geslacht;
        private DateTime geboortedatum;
        private string woonplaats;
        private int box;
        private DateTime tijdOpname;
        private DateTime tijdOntslag;
        private string komtvan;
        private string gaatnaar;
        private int gaatnaarkamer;
        private string coordArts;
        private string behandelArts;
        private string diagnose;
        private int dnrCode;
        private string anamnese;
        private string thuisMed;
        private bool hasKathether;
        private List<Katheter> kathList;
        private bool arterieel;
        private bool cvd;
        private bool picco;
        private bool swanGans;
        private bool tempoPM;
        private bool PMimplant;
        private bool cardiaTromb;
        private bool nietCardTromb;
        private bool gif;
        private bool refMZG;
        private DateTime thoraxdrain;
        private DateTime maagsonde;
        private DateTime blaassonde;
        private DateTime pda;
        private DateTime pcea;
        private DateTime pcia;
        private bool beademing;
        private List<Beademing> beadList;
        private bool hasNiv;
        private List<NIV> nivlist;
        private string ritme;
        private int whatIsP;
        private string bd;
        private string dieet;
        private bool sv;
        private int telemetrie;
        private bool kine;
        private bool zalving;
        private bool medicatie;
        private List<Medicatie> medicList;
        private bool infuus;
        private List<Infuus> infuusList;
        private string pceaUitleg;
        private string PceaUitlegAt;
        private bool drains;
        private List<string> drainList;
        private bool onderzoek;
        private List<string> onderzoekList;
        private string zorgen;
        private string verpleegkundige;
        private string verslag;

        #region all props in here
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public int Inschrijvingsnr
        {
            get { return inschrijvingsnr; }
            set { inschrijvingsnr = value; }
        }


        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
            }
        }

        public string Voornaam
        {
            get
            {
                return voornaam;
            }

            set
            {
                voornaam = value;
            }
        }

        public string Geslacht
        {
            get
            {
                return geslacht;
            }

            set
            {
                geslacht = value;
            }
        }

        public DateTime Geboortedatum
        {
            get
            {
                return geboortedatum;
            }

            set
            {
                geboortedatum = value;
            }
        }

        public string Woonplaats
        {
            get
            {
                return woonplaats;
            }

            set
            {
                woonplaats = value;
            }
        }

        public int Box
        {
            get
            {
                return box;
            }

            set
            {
                box = value;
            }
        }

        public DateTime TijdOpname
        {
            get
            {
                return tijdOpname;
            }

            set
            {
                tijdOpname = value;
            }
        }

        public DateTime TijdOntslag
        {
            get
            {
                return tijdOntslag;
            }

            set
            {
                tijdOntslag = value;
            }
        }

        public string Komtvan
        {
            get
            {
                return komtvan;
            }

            set
            {
                komtvan = value;
            }
        }


        public string Gaatnaar
        {
            get
            {
                return gaatnaar;
            }

            set
            {
                gaatnaar = value;
            }
        }

        public int Gaatnaarkamer
        {
            get
            {
                return gaatnaarkamer;
            }

            set
            {
                gaatnaarkamer = value;
            }
        }

        public string CoordArts
        {
            get
            {
                return coordArts;
            }

            set
            {
                coordArts = value;
            }
        }

        public string BehandelArts
        {
            get
            {
                return behandelArts;
            }

            set
            {
                behandelArts = value;
            }
        }

        public string Diagnose
        {
            get
            {
                return diagnose;
            }

            set
            {
                diagnose = value;
            }
        }

        public int DnrCode
        {
            get
            {
                return dnrCode;
            }

            set
            {
                dnrCode = value;
            }
        }

        public string Anamnese
        {
            get
            {
                return anamnese;
            }

            set
            {
                anamnese = value;
            }
        }

        public string ThuisMed
        {
            get
            {
                return thuisMed;
            }

            set
            {
                thuisMed = value;
            }
        }

        public bool HasKathether
        {
            get
            {
                return hasKathether;
            }

            set
            {
                hasKathether = value;
            }
        }

        public List<Katheter> KathList
        {
            get
            {
                return kathList;
            }

            set
            {
                kathList = value;
            }
        }

        public bool Arterieel
        {
            get
            {
                return arterieel;
            }

            set
            {
                arterieel = value;
            }
        }

        public bool Cvd
        {
            get
            {
                return cvd;
            }

            set
            {
                cvd = value;
            }
        }

        public bool Picco
        {
            get
            {
                return picco;
            }

            set
            {
                picco = value;
            }
        }

        public bool SwanGans
        {
            get
            {
                return swanGans;
            }

            set
            {
                swanGans = value;
            }
        }

        public bool TempoPM
        {
            get
            {
                return tempoPM;
            }

            set
            {
                tempoPM = value;
            }
        }

        public bool PMimplant1
        {
            get
            {
                return PMimplant;
            }

            set
            {
                PMimplant = value;
            }
        }

        public bool CardiaTromb
        {
            get
            {
                return cardiaTromb;
            }

            set
            {
                cardiaTromb = value;
            }
        }

        public bool NietCardTromb
        {
            get
            {
                return nietCardTromb;
            }

            set
            {
                nietCardTromb = value;
            }
        }

        public bool Gif
        {
            get
            {
                return gif;
            }

            set
            {
                gif = value;
            }
        }

        public bool RefMZG
        {
            get
            {
                return refMZG;
            }

            set
            {
                refMZG = value;
            }
        }

        public DateTime Thoraxdrain
        {
            get
            {
                return thoraxdrain;
            }

            set
            {
                thoraxdrain = value;
            }
        }

        public DateTime Maagsonde
        {
            get
            {
                return maagsonde;
            }

            set
            {
                maagsonde = value;
            }
        }

        public DateTime Blaassonde
        {
            get
            {
                return blaassonde;
            }

            set
            {
                blaassonde = value;
            }
        }

        public DateTime Pda
        {
            get
            {
                return pda;
            }

            set
            {
                pda = value;
            }
        }

        public DateTime Pcea
        {
            get
            {
                return pcea;
            }

            set
            {
                pcea = value;
            }
        }

        public DateTime Pcia
        {
            get
            {
                return pcia;
            }

            set
            {
                pcia = value;
            }
        }

        public bool Beademing
        {
            get
            {
                return beademing;
            }

            set
            {
                beademing = value;
            }
        }

        public List<Beademing> BeadList
        {
            get
            {
                return beadList;
            }

            set
            {
                beadList = value;
            }
        }

        public bool HasNiv
        {
            get
            {
                return hasNiv;
            }

            set
            {
                hasNiv = value;
            }
        }

        public List<NIV> Nivlist
        {
            get
            {
                return nivlist;
            }

            set
            {
                nivlist = value;
            }
        }

        public string Ritme
        {
            get
            {
                return ritme;
            }

            set
            {
                ritme = value;
            }
        }

        public int WhatIsP
        {
            get
            {
                return whatIsP;
            }

            set
            {
                whatIsP = value;
            }
        }

        public string Bd
        {
            get
            {
                return bd;
            }

            set
            {
                bd = value;
            }
        }

        public string Dieet
        {
            get
            {
                return dieet;
            }

            set
            {
                dieet = value;
            }
        }

        public bool Sv
        {
            get
            {
                return sv;
            }

            set
            {
                sv = value;
            }
        }

        public int Telemetrie
        {
            get
            {
                return telemetrie;
            }

            set
            {
                telemetrie = value;
            }
        }

        public bool Kine
        {
            get
            {
                return kine;
            }

            set
            {
                kine = value;
            }
        }

        public bool Zalving
        {
            get
            {
                return zalving;
            }

            set
            {
                zalving = value;
            }
        }

        public bool Medicatie
        {
            get
            {
                return medicatie;
            }

            set
            {
                medicatie = value;
            }
        }

        public List<Medicatie> MedicList
        {
            get
            {
                return medicList;
            }

            set
            {
                medicList = value;
            }
        }

        public bool Infuus
        {
            get
            {
                return infuus;
            }

            set
            {
                infuus = value;
            }
        }

        public List<Infuus> InfuusList
        {
            get
            {
                return infuusList;
            }

            set
            {
                infuusList = value;
            }
        }

        public string PceaUitleg
        {
            get
            {
                return pceaUitleg;
            }

            set
            {
                pceaUitleg = value;
            }
        }

        public string PceaUitlegAt1
        {
            get
            {
                return PceaUitlegAt;
            }

            set
            {
                PceaUitlegAt = value;
            }
        }

        public bool Drains
        {
            get
            {
                return drains;
            }

            set
            {
                drains = value;
            }
        }

        public List<string> DrainList
        {
            get
            {
                return drainList;
            }

            set
            {
                drainList = value;
            }
        }

        public bool Onderzoek
        {
            get
            {
                return onderzoek;
            }

            set
            {
                onderzoek = value;
            }
        }

        public List<string> OnderzoekList
        {
            get
            {
                return onderzoekList;
            }

            set
            {
                onderzoekList = value;
            }
        }

        public string Zorgen
        {
            get
            {
                return zorgen;
            }

            set
            {
                zorgen = value;
            }
        }

        public string Verpleegkundige
        {
            get
            {
                return verpleegkundige;
            }

            set
            {
                verpleegkundige = value;
            }
        }

        public string Verslag
        {
            get
            {
                return verslag;
            }

            set
            {
                verslag = value;
            }
        }
        #endregion





        public patient(int id, int inschrijvingsnr, string naam, string voornaam, string geslacht, DateTime geboortedatum, string woonplaats)
        {
            this.id = id;
            this.inschrijvingsnr = inschrijvingsnr;
            this.Naam = naam;
            this.Voornaam = voornaam;
            this.Geslacht = geslacht;
            this.Geboortedatum = geboortedatum;
            this.Woonplaats = woonplaats;

        }

        public void setMedData(int box, DateTime tijdOpname, DateTime tijdOntslag, string komtvan, string gaatnaar, int gaatnaarkamer, string coordArts, string behandelArts, string diagnose, int dnrCode, string anamnese, string thuisMed,
            bool hasKathether, List<Katheter> kathList, bool arterieel, bool cvd, bool picco, bool swanGans, bool tempoPM, bool PMimplant, bool cardiaTromb, bool nietCardTromb, bool gif, bool refMZG, DateTime thoraxdrain, DateTime maagsonde,
            DateTime blaassonde, DateTime pda, DateTime pcea, DateTime pcia, bool beademing, List<Beademing> beadList, bool hasNiv, List<NIV> nivlist, string ritme, int whatIsP, string bd, string dieet, bool sv, int telemetrie, bool kine,
            bool zalving, bool medicatie, List<Medicatie> medicList, bool infuus, List<Infuus> infuusList, string pceaUitleg, string PceaUitlegAt, bool drains, List<string> drainList, bool onderzoek, List<string> onderzoekList, string zorgen, string verpleegkundige, string verslag)
        {

        }
    }
}
