using logic;
using Novacode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class print
    {

        public static void patientPrint(patient pat)
        {
            string template = @"TransferbladTemplate.docx";
            using (DocX doc = DocX.Load(template))
            {
                doc.AddCustomProperty(new CustomProperty("VolgNr", pat.Id));
                doc.AddCustomProperty(new CustomProperty("InschrNR", pat.Inschrijvingsnr));
                doc.AddCustomProperty(new CustomProperty("NaaM", pat.Naam));
                doc.AddCustomProperty(new CustomProperty("VoorNaaM", pat.Voornaam));
                doc.AddCustomProperty(new CustomProperty("gebDatum", pat.Geboortedatum.ToString()));
                doc.AddCustomProperty(new CustomProperty("opnameDat", pat.TijdOpname.ToString()));
                doc.AddCustomProperty(new CustomProperty("ontslagDat", pat.TijdOntslag.ToString()));
                doc.AddCustomProperty(new CustomProperty("Artsen", pat.BehandelArts));
                doc.AddCustomProperty(new CustomProperty("AnamNese", pat.Anamnese));
                doc.AddCustomProperty(new CustomProperty("thuisMed", pat.ThuisMed));
                doc.AddCustomProperty(new CustomProperty("RitMe", pat.Ritme));
                doc.AddCustomProperty(new CustomProperty("pP", pat.WhatIsP));
                doc.AddCustomProperty(new CustomProperty("BDD", pat.Bd));
                doc.AddCustomProperty(new CustomProperty("Dieet", pat.Dieet));
                doc.AddCustomProperty(new CustomProperty("SV", pat.Sv));
                doc.AddCustomProperty(new CustomProperty("Diagno", pat.Diagnose));
                doc.AddCustomProperty(new CustomProperty("ZorGen", pat.Zorgen));
                doc.AddCustomProperty(new CustomProperty("Verslag", pat.Verslag));
                doc.AddCustomProperty(new CustomProperty("teleMetrie", pat.Telemetrie.ToString()));
                doc.AddCustomProperty(new CustomProperty("ZalVing", pat.Zalving));
                doc.AddCustomProperty(new CustomProperty("KinE", pat.Kine));
                doc.SaveAs("printPat.docx");

            }
            Process.Start("WINWORD.EXE", "printPat.docx");
        }

    }
}
