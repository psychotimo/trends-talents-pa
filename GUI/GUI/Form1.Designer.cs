using logic;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.behandArts = new System.Windows.Forms.ComboBox();
            this.coordArts = new System.Windows.Forms.ComboBox();
            this.kathMet5 = new System.Windows.Forms.ComboBox();
            this.kathMet4 = new System.Windows.Forms.ComboBox();
            this.kathMet3 = new System.Windows.Forms.ComboBox();
            this.kathMet2 = new System.Windows.Forms.ComboBox();
            this.kathMet1 = new System.Windows.Forms.ComboBox();
            this.dnrDrop = new System.Windows.Forms.ComboBox();
            this.niCardTromb = new System.Windows.Forms.CheckBox();
            this.cardTromb = new System.Windows.Forms.CheckBox();
            this.tempPm = new System.Windows.Forms.CheckBox();
            this.pmImp = new System.Windows.Forms.CheckBox();
            this.swangans = new System.Windows.Forms.CheckBox();
            this.cvd = new System.Windows.Forms.CheckBox();
            this.picco = new System.Windows.Forms.CheckBox();
            this.arteriele = new System.Windows.Forms.CheckBox();
            this.gif = new System.Windows.Forms.CheckBox();
            this.pciaDatum = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.pceaDatum = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.pdaDatum = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.blaasDatum = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.sondeDatum = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.thoraxDate = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.kathDate5 = new System.Windows.Forms.TextBox();
            this.kathDate2 = new System.Windows.Forms.TextBox();
            this.kathDate3 = new System.Windows.Forms.TextBox();
            this.kathDate4 = new System.Windows.Forms.TextBox();
            this.KathDate1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.thuismedicatie = new System.Windows.Forms.TextBox();
            this.anamnese = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.diagnose = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.opnameUur = new System.Windows.Forms.TextBox();
            this.ontslagUur = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.opnameDatum = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gaatNaarBox = new System.Windows.Forms.ComboBox();
            this.komtVanBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.geslachtBox = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inschrijvingsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxBox = new System.Windows.Forms.ComboBox();
            this.patNrBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label55 = new System.Windows.Forms.Label();
            this.nivFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ademStopU3 = new System.Windows.Forms.TextBox();
            this.ademStartU3 = new System.Windows.Forms.TextBox();
            this.ademStop3 = new System.Windows.Forms.DateTimePicker();
            this.ademStart3 = new System.Windows.Forms.DateTimePicker();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.ademStopU2 = new System.Windows.Forms.TextBox();
            this.ademStartU2 = new System.Windows.Forms.TextBox();
            this.ademStop2 = new System.Windows.Forms.DateTimePicker();
            this.ademStart2 = new System.Windows.Forms.DateTimePicker();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.ademStopU1 = new System.Windows.Forms.TextBox();
            this.ademStartU1 = new System.Windows.Forms.TextBox();
            this.ademStop1 = new System.Windows.Forms.DateTimePicker();
            this.ademStart1 = new System.Windows.Forms.DateTimePicker();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.medicMeth1 = new System.Windows.Forms.ComboBox();
            this.medicper1 = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.medicText1 = new System.Windows.Forms.TextBox();
            this.zalvingCheckBox = new System.Windows.Forms.CheckBox();
            this.KineCheckBox = new System.Windows.Forms.CheckBox();
            this.Dieet = new System.Windows.Forms.TextBox();
            this.svCheckbox = new System.Windows.Forms.CheckBox();
            this.teleCombo = new System.Windows.Forms.ComboBox();
            this.bloedDrukBox = new System.Windows.Forms.TextBox();
            this.pressureBox = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.ritmeBox = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.medicMeth11 = new System.Windows.Forms.ComboBox();
            this.medicper11 = new System.Windows.Forms.ComboBox();
            this.medicText11 = new System.Windows.Forms.TextBox();
            this.medicMeth2 = new System.Windows.Forms.ComboBox();
            this.medicper2 = new System.Windows.Forms.ComboBox();
            this.medicText2 = new System.Windows.Forms.TextBox();
            this.medicMeth12 = new System.Windows.Forms.ComboBox();
            this.medicper12 = new System.Windows.Forms.ComboBox();
            this.medicText12 = new System.Windows.Forms.TextBox();
            this.medicMeth3 = new System.Windows.Forms.ComboBox();
            this.medicper3 = new System.Windows.Forms.ComboBox();
            this.medicText3 = new System.Windows.Forms.TextBox();
            this.medicMeth13 = new System.Windows.Forms.ComboBox();
            this.medicper13 = new System.Windows.Forms.ComboBox();
            this.medicText13 = new System.Windows.Forms.TextBox();
            this.medicMeth4 = new System.Windows.Forms.ComboBox();
            this.medicper4 = new System.Windows.Forms.ComboBox();
            this.medicText4 = new System.Windows.Forms.TextBox();
            this.medicMeth14 = new System.Windows.Forms.ComboBox();
            this.medicper14 = new System.Windows.Forms.ComboBox();
            this.medicText14 = new System.Windows.Forms.TextBox();
            this.medicMeth5 = new System.Windows.Forms.ComboBox();
            this.medicper5 = new System.Windows.Forms.ComboBox();
            this.medicText5 = new System.Windows.Forms.TextBox();
            this.medicMeth15 = new System.Windows.Forms.ComboBox();
            this.medicper15 = new System.Windows.Forms.ComboBox();
            this.medicText15 = new System.Windows.Forms.TextBox();
            this.medicMeth10 = new System.Windows.Forms.ComboBox();
            this.medicper10 = new System.Windows.Forms.ComboBox();
            this.medicText10 = new System.Windows.Forms.TextBox();
            this.medicMeth9 = new System.Windows.Forms.ComboBox();
            this.medicper9 = new System.Windows.Forms.ComboBox();
            this.medicText9 = new System.Windows.Forms.TextBox();
            this.medicMeth8 = new System.Windows.Forms.ComboBox();
            this.medicper8 = new System.Windows.Forms.ComboBox();
            this.medicText8 = new System.Windows.Forms.TextBox();
            this.medicMeth7 = new System.Windows.Forms.ComboBox();
            this.medicper7 = new System.Windows.Forms.ComboBox();
            this.medicText7 = new System.Windows.Forms.TextBox();
            this.medicMeth6 = new System.Windows.Forms.ComboBox();
            this.medicper6 = new System.Windows.Forms.ComboBox();
            this.medicText6 = new System.Windows.Forms.TextBox();
            this.medicMeth20 = new System.Windows.Forms.ComboBox();
            this.medicper20 = new System.Windows.Forms.ComboBox();
            this.medicText20 = new System.Windows.Forms.TextBox();
            this.medicMeth19 = new System.Windows.Forms.ComboBox();
            this.medicper19 = new System.Windows.Forms.ComboBox();
            this.medicText19 = new System.Windows.Forms.TextBox();
            this.medicMeth18 = new System.Windows.Forms.ComboBox();
            this.medicper18 = new System.Windows.Forms.ComboBox();
            this.medicText18 = new System.Windows.Forms.TextBox();
            this.medicMeth17 = new System.Windows.Forms.ComboBox();
            this.medicper17 = new System.Windows.Forms.ComboBox();
            this.medicText17 = new System.Windows.Forms.TextBox();
            this.medicMeth16 = new System.Windows.Forms.ComboBox();
            this.medicper16 = new System.Windows.Forms.ComboBox();
            this.medicText16 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.infuustext1 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.infuustext2 = new System.Windows.Forms.TextBox();
            this.infuustext3 = new System.Windows.Forms.TextBox();
            this.pdaText = new System.Windows.Forms.TextBox();
            this.infuusMini1 = new System.Windows.Forms.TextBox();
            this.infuusMini2 = new System.Windows.Forms.TextBox();
            this.infuusMini3 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.pdaMini = new System.Windows.Forms.TextBox();
            this.onderzoekbox1 = new System.Windows.Forms.TextBox();
            this.onderzoekbox2 = new System.Windows.Forms.TextBox();
            this.onderzoekbox4 = new System.Windows.Forms.TextBox();
            this.onderzoekbox3 = new System.Windows.Forms.TextBox();
            this.drainbox4 = new System.Windows.Forms.TextBox();
            this.drainbox3 = new System.Windows.Forms.TextBox();
            this.drainbox2 = new System.Windows.Forms.TextBox();
            this.drainbox1 = new System.Windows.Forms.TextBox();
            this.zorgbox = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.VerslagBox = new System.Windows.Forms.TextBox();
            this.verpleegkundigeBox = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.behandArts);
            this.tabPage1.Controls.Add(this.coordArts);
            this.tabPage1.Controls.Add(this.kathMet5);
            this.tabPage1.Controls.Add(this.kathMet4);
            this.tabPage1.Controls.Add(this.kathMet3);
            this.tabPage1.Controls.Add(this.kathMet2);
            this.tabPage1.Controls.Add(this.kathMet1);
            this.tabPage1.Controls.Add(this.dnrDrop);
            this.tabPage1.Controls.Add(this.niCardTromb);
            this.tabPage1.Controls.Add(this.cardTromb);
            this.tabPage1.Controls.Add(this.tempPm);
            this.tabPage1.Controls.Add(this.pmImp);
            this.tabPage1.Controls.Add(this.swangans);
            this.tabPage1.Controls.Add(this.cvd);
            this.tabPage1.Controls.Add(this.picco);
            this.tabPage1.Controls.Add(this.arteriele);
            this.tabPage1.Controls.Add(this.gif);
            this.tabPage1.Controls.Add(this.pciaDatum);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.pceaDatum);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.pdaDatum);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.blaasDatum);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.sondeDatum);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.thoraxDate);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.kathDate5);
            this.tabPage1.Controls.Add(this.kathDate2);
            this.tabPage1.Controls.Add(this.kathDate3);
            this.tabPage1.Controls.Add(this.kathDate4);
            this.tabPage1.Controls.Add(this.KathDate1);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.thuismedicatie);
            this.tabPage1.Controls.Add(this.anamnese);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.diagnose);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.opnameUur);
            this.tabPage1.Controls.Add(this.ontslagUur);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.opnameDatum);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.gaatNaarBox);
            this.tabPage1.Controls.Add(this.komtVanBox);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.ageLabel);
            this.tabPage1.Controls.Add(this.geslachtBox);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.inschrijvingsBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.boxBox);
            this.tabPage1.Controls.Add(this.patNrBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // behandArts
            // 
            this.behandArts.FormattingEnabled = true;
            this.behandArts.Items.AddRange(new object[] {
            "Anesthesist / Intesivist",
            "Cardioloog",
            "Chirurg",
            "Endocrinoloog",
            "Gastro - Enteroloog",
            "Geriater",
            "Gynaecoloog",
            "Nefroloog",
            "Neuroloog / Psychiater",
            "Neurochirurg",
            "NKO",
            "Oftalmoloog",
            "Orthopedist / Traumatoloog",
            "Pneumoloog",
            "Plastische chirurg",
            "Paediater",
            "Stomatoloog",
            "Uroloog"});
            this.behandArts.Location = new System.Drawing.Point(560, 205);
            this.behandArts.Name = "behandArts";
            this.behandArts.Size = new System.Drawing.Size(193, 21);
            this.behandArts.TabIndex = 98;
            // 
            // coordArts
            // 
            this.coordArts.FormattingEnabled = true;
            this.coordArts.Items.AddRange(new object[] {
            "Anesthesist / Intesivist",
            "Cardioloog",
            "Chirurg",
            "Endocrinoloog",
            "Gastro - Enteroloog",
            "Geriater",
            "Gynaecoloog",
            "Nefroloog",
            "Neuroloog / Psychiater",
            "Neurochirurg",
            "NKO",
            "Oftalmoloog",
            "Orthopedist / Traumatoloog",
            "Pneumoloog",
            "Plastische chirurg",
            "Paediater",
            "Stomatoloog",
            "Uroloog"});
            this.coordArts.Location = new System.Drawing.Point(108, 205);
            this.coordArts.Name = "coordArts";
            this.coordArts.Size = new System.Drawing.Size(193, 21);
            this.coordArts.TabIndex = 97;
            // 
            // kathMet5
            // 
            this.kathMet5.FormattingEnabled = true;
            this.kathMet5.Items.AddRange(new object[] {
            "Perifeer",
            "Jugularis Duo",
            "Jugularis Trio",
            "Jugularis Quad",
            "Subclavia Duo",
            "Subclavia Trio",
            "Subclavia Quad",
            "port-a-cath",
            "basilica"});
            this.kathMet5.Location = new System.Drawing.Point(6, 527);
            this.kathMet5.Name = "kathMet5";
            this.kathMet5.Size = new System.Drawing.Size(108, 21);
            this.kathMet5.TabIndex = 96;
            // 
            // kathMet4
            // 
            this.kathMet4.FormattingEnabled = true;
            this.kathMet4.Items.AddRange(new object[] {
            "Perifeer",
            "Jugularis Duo",
            "Jugularis Trio",
            "Jugularis Quad",
            "Subclavia Duo",
            "Subclavia Trio",
            "Subclavia Quad",
            "port-a-cath",
            "basilica"});
            this.kathMet4.Location = new System.Drawing.Point(6, 494);
            this.kathMet4.Name = "kathMet4";
            this.kathMet4.Size = new System.Drawing.Size(108, 21);
            this.kathMet4.TabIndex = 95;
            // 
            // kathMet3
            // 
            this.kathMet3.FormattingEnabled = true;
            this.kathMet3.Items.AddRange(new object[] {
            "Perifeer",
            "Jugularis Duo",
            "Jugularis Trio",
            "Jugularis Quad",
            "Subclavia Duo",
            "Subclavia Trio",
            "Subclavia Quad",
            "port-a-cath",
            "basilica"});
            this.kathMet3.Location = new System.Drawing.Point(6, 468);
            this.kathMet3.Name = "kathMet3";
            this.kathMet3.Size = new System.Drawing.Size(108, 21);
            this.kathMet3.TabIndex = 94;
            // 
            // kathMet2
            // 
            this.kathMet2.FormattingEnabled = true;
            this.kathMet2.Items.AddRange(new object[] {
            "Perifeer",
            "Jugularis Duo",
            "Jugularis Trio",
            "Jugularis Quad",
            "Subclavia Duo",
            "Subclavia Trio",
            "Subclavia Quad",
            "port-a-cath",
            "basilica"});
            this.kathMet2.Location = new System.Drawing.Point(6, 441);
            this.kathMet2.Name = "kathMet2";
            this.kathMet2.Size = new System.Drawing.Size(108, 21);
            this.kathMet2.TabIndex = 93;
            // 
            // kathMet1
            // 
            this.kathMet1.FormattingEnabled = true;
            this.kathMet1.Items.AddRange(new object[] {
            "Perifeer",
            "Jugularis Duo",
            "Jugularis Trio",
            "Jugularis Quad",
            "Subclavia Duo",
            "Subclavia Trio",
            "Subclavia Quad",
            "port-a-cath",
            "basilica"});
            this.kathMet1.Location = new System.Drawing.Point(6, 417);
            this.kathMet1.Name = "kathMet1";
            this.kathMet1.Size = new System.Drawing.Size(108, 21);
            this.kathMet1.TabIndex = 92;
            // 
            // dnrDrop
            // 
            this.dnrDrop.FormattingEnabled = true;
            this.dnrDrop.Items.AddRange(new object[] {
            0,
            1,
            2,
            3});
            this.dnrDrop.Location = new System.Drawing.Point(75, 257);
            this.dnrDrop.Name = "dnrDrop";
            this.dnrDrop.Size = new System.Drawing.Size(37, 21);
            this.dnrDrop.TabIndex = 91;
            // 
            // niCardTromb
            // 
            this.niCardTromb.AutoSize = true;
            this.niCardTromb.Location = new System.Drawing.Point(555, 539);
            this.niCardTromb.Name = "niCardTromb";
            this.niCardTromb.Size = new System.Drawing.Size(143, 17);
            this.niCardTromb.TabIndex = 90;
            this.niCardTromb.Text = "Niet-Cardiale Trombolyse";
            this.niCardTromb.UseVisualStyleBackColor = true;
            // 
            // cardTromb
            // 
            this.cardTromb.AutoSize = true;
            this.cardTromb.Location = new System.Drawing.Point(555, 515);
            this.cardTromb.Name = "cardTromb";
            this.cardTromb.Size = new System.Drawing.Size(121, 17);
            this.cardTromb.TabIndex = 89;
            this.cardTromb.Text = "Cardiale Trombolyse";
            this.cardTromb.UseMnemonic = false;
            this.cardTromb.UseVisualStyleBackColor = true;
            // 
            // tempPm
            // 
            this.tempPm.AutoSize = true;
            this.tempPm.Location = new System.Drawing.Point(555, 495);
            this.tempPm.Name = "tempPm";
            this.tempPm.Size = new System.Drawing.Size(98, 17);
            this.tempPm.TabIndex = 88;
            this.tempPm.Text = "Temporaire PM";
            this.tempPm.UseVisualStyleBackColor = true;
            // 
            // pmImp
            // 
            this.pmImp.AutoSize = true;
            this.pmImp.Location = new System.Drawing.Point(555, 471);
            this.pmImp.Name = "pmImp";
            this.pmImp.Size = new System.Drawing.Size(96, 17);
            this.pmImp.TabIndex = 87;
            this.pmImp.Text = "PM-Implantatie";
            this.pmImp.UseVisualStyleBackColor = true;
            // 
            // swangans
            // 
            this.swangans.AutoSize = true;
            this.swangans.Location = new System.Drawing.Point(641, 445);
            this.swangans.Name = "swangans";
            this.swangans.Size = new System.Drawing.Size(78, 17);
            this.swangans.TabIndex = 86;
            this.swangans.Text = "SwanGans";
            this.swangans.UseVisualStyleBackColor = true;
            // 
            // cvd
            // 
            this.cvd.AutoSize = true;
            this.cvd.Location = new System.Drawing.Point(641, 423);
            this.cvd.Name = "cvd";
            this.cvd.Size = new System.Drawing.Size(48, 17);
            this.cvd.TabIndex = 85;
            this.cvd.Text = "CVD";
            this.cvd.UseVisualStyleBackColor = true;
            // 
            // picco
            // 
            this.picco.AutoSize = true;
            this.picco.Location = new System.Drawing.Point(555, 445);
            this.picco.Name = "picco";
            this.picco.Size = new System.Drawing.Size(57, 17);
            this.picco.TabIndex = 84;
            this.picco.Text = "PiCCO";
            this.picco.UseVisualStyleBackColor = true;
            // 
            // arteriele
            // 
            this.arteriele.AutoSize = true;
            this.arteriele.Location = new System.Drawing.Point(555, 423);
            this.arteriele.Name = "arteriele";
            this.arteriele.Size = new System.Drawing.Size(63, 17);
            this.arteriele.TabIndex = 83;
            this.arteriele.Text = "arteriële";
            this.arteriele.UseVisualStyleBackColor = true;
            // 
            // gif
            // 
            this.gif.AutoSize = true;
            this.gif.Location = new System.Drawing.Point(408, 6);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(43, 17);
            this.gif.TabIndex = 82;
            this.gif.Text = "GIF";
            this.gif.UseVisualStyleBackColor = true;
            // 
            // pciaDatum
            // 
            this.pciaDatum.Location = new System.Drawing.Point(466, 513);
            this.pciaDatum.Name = "pciaDatum";
            this.pciaDatum.Size = new System.Drawing.Size(79, 20);
            this.pciaDatum.TabIndex = 77;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(403, 516);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 13);
            this.label36.TabIndex = 76;
            this.label36.Text = "PCIA:";
            // 
            // pceaDatum
            // 
            this.pceaDatum.Location = new System.Drawing.Point(465, 464);
            this.pceaDatum.Name = "pceaDatum";
            this.pceaDatum.Size = new System.Drawing.Size(80, 20);
            this.pceaDatum.TabIndex = 75;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(405, 467);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(38, 13);
            this.label37.TabIndex = 74;
            this.label37.Text = "PCEA:";
            // 
            // pdaDatum
            // 
            this.pdaDatum.Location = new System.Drawing.Point(466, 421);
            this.pdaDatum.Name = "pdaDatum";
            this.pdaDatum.Size = new System.Drawing.Size(79, 20);
            this.pdaDatum.TabIndex = 73;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(404, 424);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(32, 13);
            this.label38.TabIndex = 72;
            this.label38.Text = "PDA:";
            // 
            // blaasDatum
            // 
            this.blaasDatum.Location = new System.Drawing.Point(312, 513);
            this.blaasDatum.Name = "blaasDatum";
            this.blaasDatum.Size = new System.Drawing.Size(78, 20);
            this.blaasDatum.TabIndex = 71;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(236, 516);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(65, 13);
            this.label35.TabIndex = 70;
            this.label35.Text = "Blaassonde:";
            // 
            // sondeDatum
            // 
            this.sondeDatum.Location = new System.Drawing.Point(312, 464);
            this.sondeDatum.Name = "sondeDatum";
            this.sondeDatum.Size = new System.Drawing.Size(78, 20);
            this.sondeDatum.TabIndex = 69;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(238, 467);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(66, 13);
            this.label34.TabIndex = 68;
            this.label34.Text = "Maagsonde:";
            // 
            // thoraxDate
            // 
            this.thoraxDate.Location = new System.Drawing.Point(311, 421);
            this.thoraxDate.Name = "thoraxDate";
            this.thoraxDate.Size = new System.Drawing.Size(79, 20);
            this.thoraxDate.TabIndex = 67;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(237, 424);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 13);
            this.label33.TabIndex = 66;
            this.label33.Text = "ThoraxDrain:";
            // 
            // kathDate5
            // 
            this.kathDate5.Location = new System.Drawing.Point(120, 528);
            this.kathDate5.Name = "kathDate5";
            this.kathDate5.Size = new System.Drawing.Size(100, 20);
            this.kathDate5.TabIndex = 61;
            // 
            // kathDate2
            // 
            this.kathDate2.Location = new System.Drawing.Point(120, 443);
            this.kathDate2.Name = "kathDate2";
            this.kathDate2.Size = new System.Drawing.Size(100, 20);
            this.kathDate2.TabIndex = 60;
            // 
            // kathDate3
            // 
            this.kathDate3.Location = new System.Drawing.Point(120, 469);
            this.kathDate3.Name = "kathDate3";
            this.kathDate3.Size = new System.Drawing.Size(100, 20);
            this.kathDate3.TabIndex = 59;
            // 
            // kathDate4
            // 
            this.kathDate4.Location = new System.Drawing.Point(120, 495);
            this.kathDate4.Name = "kathDate4";
            this.kathDate4.Size = new System.Drawing.Size(100, 20);
            this.kathDate4.TabIndex = 58;
            // 
            // KathDate1
            // 
            this.KathDate1.Location = new System.Drawing.Point(120, 417);
            this.KathDate1.Name = "KathDate1";
            this.KathDate1.Size = new System.Drawing.Size(100, 20);
            this.KathDate1.TabIndex = 57;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 401);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Katheters:";
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Location = new System.Drawing.Point(0, 395);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(758, 2);
            this.label27.TabIndex = 50;
            // 
            // thuismedicatie
            // 
            this.thuismedicatie.Location = new System.Drawing.Point(390, 313);
            this.thuismedicatie.Multiline = true;
            this.thuismedicatie.Name = "thuismedicatie";
            this.thuismedicatie.Size = new System.Drawing.Size(322, 79);
            this.thuismedicatie.TabIndex = 49;
            // 
            // anamnese
            // 
            this.anamnese.Location = new System.Drawing.Point(17, 313);
            this.anamnese.Multiline = true;
            this.anamnese.Name = "anamnese";
            this.anamnese.Size = new System.Drawing.Size(322, 79);
            this.anamnese.TabIndex = 48;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(387, 297);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Thuismedicatie:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 297);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Anamnese:";
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Location = new System.Drawing.Point(0, 282);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(758, 2);
            this.label24.TabIndex = 45;
            // 
            // diagnose
            // 
            this.diagnose.Location = new System.Drawing.Point(68, 231);
            this.diagnose.Name = "diagnose";
            this.diagnose.Size = new System.Drawing.Size(673, 20);
            this.diagnose.TabIndex = 44;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 262);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "DNR-Code:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 234);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Diagnose:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(463, 208);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Behandelend Arts:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Coördinerend Arts:";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(0, 202);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(758, 2);
            this.label19.TabIndex = 36;
            // 
            // opnameUur
            // 
            this.opnameUur.Location = new System.Drawing.Point(301, 144);
            this.opnameUur.Name = "opnameUur";
            this.opnameUur.Size = new System.Drawing.Size(58, 20);
            this.opnameUur.TabIndex = 35;
            // 
            // ontslagUur
            // 
            this.ontslagUur.Location = new System.Drawing.Point(301, 175);
            this.ontslagUur.Name = "ontslagUur";
            this.ontslagUur.Size = new System.Drawing.Size(58, 20);
            this.ontslagUur.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 33;
            // 
            // opnameDatum
            // 
            this.opnameDatum.Location = new System.Drawing.Point(108, 144);
            this.opnameDatum.Name = "opnameDatum";
            this.opnameDatum.Size = new System.Drawing.Size(78, 20);
            this.opnameDatum.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 31;
            // 
            // gaatNaarBox
            // 
            this.gaatNaarBox.FormattingEnabled = true;
            this.gaatNaarBox.Location = new System.Drawing.Point(465, 175);
            this.gaatNaarBox.Name = "gaatNaarBox";
            this.gaatNaarBox.Size = new System.Drawing.Size(216, 21);
            this.gaatNaarBox.TabIndex = 30;
            // 
            // komtVanBox
            // 
            this.komtVanBox.FormattingEnabled = true;
            this.komtVanBox.Location = new System.Drawing.Point(465, 140);
            this.komtVanBox.Name = "komtVanBox";
            this.komtVanBox.Size = new System.Drawing.Size(216, 21);
            this.komtVanBox.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(387, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "PT gaat naar:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(209, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Ontslaguur ICU:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ontslagdatum ICU:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(388, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "PT komt van:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(209, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Opnameuur ICU:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Opnamedatum ICU:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Opnamedatum Ziekenhuis:";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(0, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(758, 2);
            this.label11.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(602, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ageLabel.Location = new System.Drawing.Point(312, 82);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(27, 15);
            this.ageLabel.TabIndex = 18;
            this.ageLabel.Text = "age";
            // 
            // geslachtBox
            // 
            this.geslachtBox.FormattingEnabled = true;
            this.geslachtBox.Items.AddRange(new object[] {
            "M",
            "V"});
            this.geslachtBox.Location = new System.Drawing.Point(696, 47);
            this.geslachtBox.Name = "geslachtBox";
            this.geslachtBox.Size = new System.Drawing.Size(45, 21);
            this.geslachtBox.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(290, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "woonplaats:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "leeftijd:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Geboortedatum: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Geslacht:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Voornaam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Naam:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(755, 2);
            this.label4.TabIndex = 6;
            // 
            // inschrijvingsBox
            // 
            this.inschrijvingsBox.Location = new System.Drawing.Point(641, 4);
            this.inschrijvingsBox.Name = "inschrijvingsBox";
            this.inschrijvingsBox.Size = new System.Drawing.Size(100, 20);
            this.inschrijvingsBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "InschrijvingsNr:";
            // 
            // boxBox
            // 
            this.boxBox.FormattingEnabled = true;
            this.boxBox.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6});
            this.boxBox.Location = new System.Drawing.Point(290, 4);
            this.boxBox.Name = "boxBox";
            this.boxBox.Size = new System.Drawing.Size(69, 21);
            this.boxBox.TabIndex = 3;
            // 
            // patNrBox
            // 
            this.patNrBox.Location = new System.Drawing.Point(68, 4);
            this.patNrBox.Name = "patNrBox";
            this.patNrBox.Size = new System.Drawing.Size(100, 20);
            this.patNrBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Box:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PatientNr:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label55);
            this.tabPage2.Controls.Add(this.nivFlowPanel);
            this.tabPage2.Controls.Add(this.ademStopU3);
            this.tabPage2.Controls.Add(this.ademStartU3);
            this.tabPage2.Controls.Add(this.ademStop3);
            this.tabPage2.Controls.Add(this.ademStart3);
            this.tabPage2.Controls.Add(this.label52);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.label54);
            this.tabPage2.Controls.Add(this.ademStopU2);
            this.tabPage2.Controls.Add(this.ademStartU2);
            this.tabPage2.Controls.Add(this.ademStop2);
            this.tabPage2.Controls.Add(this.ademStart2);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.label50);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.ademStopU1);
            this.tabPage2.Controls.Add(this.ademStartU1);
            this.tabPage2.Controls.Add(this.ademStop1);
            this.tabPage2.Controls.Add(this.ademStart1);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.label45);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(3, 120);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(56, 25);
            this.label55.TabIndex = 60;
            this.label55.Text = "NIV:";
            // 
            // nivFlowPanel
            // 
            this.nivFlowPanel.Location = new System.Drawing.Point(0, 148);
            this.nivFlowPanel.Name = "nivFlowPanel";
            this.nivFlowPanel.Size = new System.Drawing.Size(756, 418);
            this.nivFlowPanel.TabIndex = 59;
            // 
            // ademStopU3
            // 
            this.ademStopU3.Location = new System.Drawing.Point(690, 69);
            this.ademStopU3.Name = "ademStopU3";
            this.ademStopU3.Size = new System.Drawing.Size(39, 20);
            this.ademStopU3.TabIndex = 58;
            // 
            // ademStartU3
            // 
            this.ademStartU3.Location = new System.Drawing.Point(690, 49);
            this.ademStartU3.Name = "ademStartU3";
            this.ademStartU3.Size = new System.Drawing.Size(39, 20);
            this.ademStartU3.TabIndex = 57;
            // 
            // ademStop3
            // 
            this.ademStop3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ademStop3.Location = new System.Drawing.Point(601, 69);
            this.ademStop3.Name = "ademStop3";
            this.ademStop3.Size = new System.Drawing.Size(83, 20);
            this.ademStop3.TabIndex = 56;
            // 
            // ademStart3
            // 
            this.ademStart3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ademStart3.Location = new System.Drawing.Point(601, 49);
            this.ademStart3.Name = "ademStart3";
            this.ademStart3.Size = new System.Drawing.Size(83, 20);
            this.ademStart3.TabIndex = 55;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(533, 74);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(62, 13);
            this.label52.TabIndex = 54;
            this.label52.Text = "datum stop:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(533, 49);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(62, 13);
            this.label53.TabIndex = 53;
            this.label53.Text = "datum start:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(491, 48);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(36, 39);
            this.label54.TabIndex = 52;
            this.label54.Text = "3";
            // 
            // ademStopU2
            // 
            this.ademStopU2.Location = new System.Drawing.Point(439, 69);
            this.ademStopU2.Name = "ademStopU2";
            this.ademStopU2.Size = new System.Drawing.Size(39, 20);
            this.ademStopU2.TabIndex = 51;
            // 
            // ademStartU2
            // 
            this.ademStartU2.Location = new System.Drawing.Point(439, 49);
            this.ademStartU2.Name = "ademStartU2";
            this.ademStartU2.Size = new System.Drawing.Size(39, 20);
            this.ademStartU2.TabIndex = 50;
            // 
            // ademStop2
            // 
            this.ademStop2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ademStop2.Location = new System.Drawing.Point(350, 69);
            this.ademStop2.Name = "ademStop2";
            this.ademStop2.Size = new System.Drawing.Size(83, 20);
            this.ademStop2.TabIndex = 49;
            // 
            // ademStart2
            // 
            this.ademStart2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ademStart2.Location = new System.Drawing.Point(350, 49);
            this.ademStart2.Name = "ademStart2";
            this.ademStart2.Size = new System.Drawing.Size(83, 20);
            this.ademStart2.TabIndex = 48;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(282, 74);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(62, 13);
            this.label49.TabIndex = 47;
            this.label49.Text = "datum stop:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(282, 49);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(62, 13);
            this.label50.TabIndex = 46;
            this.label50.Text = "datum start:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(252, 48);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(36, 39);
            this.label51.TabIndex = 45;
            this.label51.Text = "2";
            // 
            // ademStopU1
            // 
            this.ademStopU1.Location = new System.Drawing.Point(198, 69);
            this.ademStopU1.Name = "ademStopU1";
            this.ademStopU1.Size = new System.Drawing.Size(39, 20);
            this.ademStopU1.TabIndex = 44;
            // 
            // ademStartU1
            // 
            this.ademStartU1.Location = new System.Drawing.Point(198, 49);
            this.ademStartU1.Name = "ademStartU1";
            this.ademStartU1.Size = new System.Drawing.Size(39, 20);
            this.ademStartU1.TabIndex = 43;
            // 
            // ademStop1
            // 
            this.ademStop1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ademStop1.Location = new System.Drawing.Point(109, 69);
            this.ademStop1.Name = "ademStop1";
            this.ademStop1.Size = new System.Drawing.Size(83, 20);
            this.ademStop1.TabIndex = 42;
            // 
            // ademStart1
            // 
            this.ademStart1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ademStart1.Location = new System.Drawing.Point(109, 49);
            this.ademStart1.Name = "ademStart1";
            this.ademStart1.Size = new System.Drawing.Size(83, 20);
            this.ademStart1.TabIndex = 41;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(41, 74);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(62, 13);
            this.label48.TabIndex = 40;
            this.label48.Text = "datum stop:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(41, 49);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(62, 13);
            this.label47.TabIndex = 39;
            this.label47.Text = "datum start:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(-1, 49);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(36, 39);
            this.label46.TabIndex = 38;
            this.label46.Text = "1";
            // 
            // label45
            // 
            this.label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label45.Location = new System.Drawing.Point(0, 118);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(758, 2);
            this.label45.TabIndex = 37;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(7, 7);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(136, 25);
            this.label43.TabIndex = 0;
            this.label43.Text = "Beademing:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label60);
            this.tabPage3.Controls.Add(this.label59);
            this.tabPage3.Controls.Add(this.label58);
            this.tabPage3.Controls.Add(this.zorgbox);
            this.tabPage3.Controls.Add(this.drainbox4);
            this.tabPage3.Controls.Add(this.drainbox3);
            this.tabPage3.Controls.Add(this.drainbox2);
            this.tabPage3.Controls.Add(this.drainbox1);
            this.tabPage3.Controls.Add(this.onderzoekbox4);
            this.tabPage3.Controls.Add(this.onderzoekbox3);
            this.tabPage3.Controls.Add(this.onderzoekbox2);
            this.tabPage3.Controls.Add(this.onderzoekbox1);
            this.tabPage3.Controls.Add(this.pdaMini);
            this.tabPage3.Controls.Add(this.label57);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.infuusMini3);
            this.tabPage3.Controls.Add(this.infuusMini2);
            this.tabPage3.Controls.Add(this.infuusMini1);
            this.tabPage3.Controls.Add(this.pdaText);
            this.tabPage3.Controls.Add(this.infuustext3);
            this.tabPage3.Controls.Add(this.infuustext2);
            this.tabPage3.Controls.Add(this.label44);
            this.tabPage3.Controls.Add(this.infuustext1);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.medicMeth20);
            this.tabPage3.Controls.Add(this.medicper20);
            this.tabPage3.Controls.Add(this.medicText20);
            this.tabPage3.Controls.Add(this.medicMeth19);
            this.tabPage3.Controls.Add(this.medicper19);
            this.tabPage3.Controls.Add(this.medicText19);
            this.tabPage3.Controls.Add(this.medicMeth18);
            this.tabPage3.Controls.Add(this.medicper18);
            this.tabPage3.Controls.Add(this.medicText18);
            this.tabPage3.Controls.Add(this.medicMeth17);
            this.tabPage3.Controls.Add(this.medicper17);
            this.tabPage3.Controls.Add(this.medicText17);
            this.tabPage3.Controls.Add(this.medicMeth16);
            this.tabPage3.Controls.Add(this.medicper16);
            this.tabPage3.Controls.Add(this.medicText16);
            this.tabPage3.Controls.Add(this.medicMeth10);
            this.tabPage3.Controls.Add(this.medicper10);
            this.tabPage3.Controls.Add(this.medicText10);
            this.tabPage3.Controls.Add(this.medicMeth9);
            this.tabPage3.Controls.Add(this.medicper9);
            this.tabPage3.Controls.Add(this.medicText9);
            this.tabPage3.Controls.Add(this.medicMeth8);
            this.tabPage3.Controls.Add(this.medicper8);
            this.tabPage3.Controls.Add(this.medicText8);
            this.tabPage3.Controls.Add(this.medicMeth7);
            this.tabPage3.Controls.Add(this.medicper7);
            this.tabPage3.Controls.Add(this.medicText7);
            this.tabPage3.Controls.Add(this.medicMeth6);
            this.tabPage3.Controls.Add(this.medicper6);
            this.tabPage3.Controls.Add(this.medicText6);
            this.tabPage3.Controls.Add(this.medicMeth15);
            this.tabPage3.Controls.Add(this.medicper15);
            this.tabPage3.Controls.Add(this.medicText15);
            this.tabPage3.Controls.Add(this.medicMeth5);
            this.tabPage3.Controls.Add(this.medicper5);
            this.tabPage3.Controls.Add(this.medicText5);
            this.tabPage3.Controls.Add(this.medicMeth14);
            this.tabPage3.Controls.Add(this.medicper14);
            this.tabPage3.Controls.Add(this.medicText14);
            this.tabPage3.Controls.Add(this.medicMeth4);
            this.tabPage3.Controls.Add(this.medicper4);
            this.tabPage3.Controls.Add(this.medicText4);
            this.tabPage3.Controls.Add(this.medicMeth13);
            this.tabPage3.Controls.Add(this.medicper13);
            this.tabPage3.Controls.Add(this.medicText13);
            this.tabPage3.Controls.Add(this.medicMeth3);
            this.tabPage3.Controls.Add(this.medicper3);
            this.tabPage3.Controls.Add(this.medicText3);
            this.tabPage3.Controls.Add(this.medicMeth12);
            this.tabPage3.Controls.Add(this.medicper12);
            this.tabPage3.Controls.Add(this.medicText12);
            this.tabPage3.Controls.Add(this.medicMeth2);
            this.tabPage3.Controls.Add(this.medicper2);
            this.tabPage3.Controls.Add(this.medicText2);
            this.tabPage3.Controls.Add(this.medicMeth11);
            this.tabPage3.Controls.Add(this.medicper11);
            this.tabPage3.Controls.Add(this.medicText11);
            this.tabPage3.Controls.Add(this.medicMeth1);
            this.tabPage3.Controls.Add(this.medicper1);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.medicText1);
            this.tabPage3.Controls.Add(this.zalvingCheckBox);
            this.tabPage3.Controls.Add(this.KineCheckBox);
            this.tabPage3.Controls.Add(this.Dieet);
            this.tabPage3.Controls.Add(this.svCheckbox);
            this.tabPage3.Controls.Add(this.teleCombo);
            this.tabPage3.Controls.Add(this.bloedDrukBox);
            this.tabPage3.Controls.Add(this.pressureBox);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.ritmeBox);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // medicMeth1
            // 
            this.medicMeth1.FormattingEnabled = true;
            this.medicMeth1.Location = new System.Drawing.Point(311, 60);
            this.medicMeth1.Name = "medicMeth1";
            this.medicMeth1.Size = new System.Drawing.Size(55, 21);
            this.medicMeth1.TabIndex = 24;
            // 
            // medicper1
            // 
            this.medicper1.FormattingEnabled = true;
            this.medicper1.Location = new System.Drawing.Point(253, 60);
            this.medicper1.Name = "medicper1";
            this.medicper1.Size = new System.Drawing.Size(52, 21);
            this.medicper1.TabIndex = 23;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(6, 33);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(121, 25);
            this.label41.TabIndex = 22;
            this.label41.Text = "Medicatie:";
            // 
            // medicText1
            // 
            this.medicText1.Location = new System.Drawing.Point(3, 60);
            this.medicText1.Name = "medicText1";
            this.medicText1.Size = new System.Drawing.Size(244, 20);
            this.medicText1.TabIndex = 21;
            // 
            // zalvingCheckBox
            // 
            this.zalvingCheckBox.AutoSize = true;
            this.zalvingCheckBox.Location = new System.Drawing.Point(692, 6);
            this.zalvingCheckBox.Name = "zalvingCheckBox";
            this.zalvingCheckBox.Size = new System.Drawing.Size(61, 17);
            this.zalvingCheckBox.TabIndex = 20;
            this.zalvingCheckBox.Text = "Zalving";
            this.zalvingCheckBox.UseVisualStyleBackColor = true;
            // 
            // KineCheckBox
            // 
            this.KineCheckBox.AutoSize = true;
            this.KineCheckBox.Location = new System.Drawing.Point(643, 7);
            this.KineCheckBox.Name = "KineCheckBox";
            this.KineCheckBox.Size = new System.Drawing.Size(47, 17);
            this.KineCheckBox.TabIndex = 19;
            this.KineCheckBox.Text = "Kiné";
            this.KineCheckBox.UseVisualStyleBackColor = true;
            // 
            // Dieet
            // 
            this.Dieet.Location = new System.Drawing.Point(339, 4);
            this.Dieet.Name = "Dieet";
            this.Dieet.Size = new System.Drawing.Size(150, 20);
            this.Dieet.TabIndex = 18;
            // 
            // svCheckbox
            // 
            this.svCheckbox.AutoSize = true;
            this.svCheckbox.Location = new System.Drawing.Point(495, 6);
            this.svCheckbox.Name = "svCheckbox";
            this.svCheckbox.Size = new System.Drawing.Size(40, 17);
            this.svCheckbox.TabIndex = 17;
            this.svCheckbox.Text = "SV";
            this.svCheckbox.UseVisualStyleBackColor = true;
            // 
            // teleCombo
            // 
            this.teleCombo.FormattingEnabled = true;
            this.teleCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.teleCombo.Location = new System.Drawing.Point(606, 4);
            this.teleCombo.Name = "teleCombo";
            this.teleCombo.Size = new System.Drawing.Size(31, 21);
            this.teleCombo.TabIndex = 16;
            // 
            // bloedDrukBox
            // 
            this.bloedDrukBox.Location = new System.Drawing.Point(253, 4);
            this.bloedDrukBox.Name = "bloedDrukBox";
            this.bloedDrukBox.Size = new System.Drawing.Size(39, 20);
            this.bloedDrukBox.TabIndex = 15;
            // 
            // pressureBox
            // 
            this.pressureBox.Location = new System.Drawing.Point(176, 4);
            this.pressureBox.Name = "pressureBox";
            this.pressureBox.Size = new System.Drawing.Size(39, 20);
            this.pressureBox.TabIndex = 14;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(541, 7);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(59, 13);
            this.label40.TabIndex = 13;
            this.label40.Text = "Telemetrie:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(298, 7);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 13);
            this.label39.TabIndex = 12;
            this.label39.Text = "Dieet:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(222, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 13);
            this.label32.TabIndex = 11;
            this.label32.Text = "BD:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(153, 7);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "P:";
            // 
            // ritmeBox
            // 
            this.ritmeBox.Location = new System.Drawing.Point(47, 4);
            this.ritmeBox.Name = "ritmeBox";
            this.ritmeBox.Size = new System.Drawing.Size(79, 20);
            this.ritmeBox.TabIndex = 9;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(4, 7);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "Ritme:";
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Location = new System.Drawing.Point(1, 31);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(755, 2);
            this.label29.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // medicMeth11
            // 
            this.medicMeth11.FormattingEnabled = true;
            this.medicMeth11.Location = new System.Drawing.Point(690, 60);
            this.medicMeth11.Name = "medicMeth11";
            this.medicMeth11.Size = new System.Drawing.Size(55, 21);
            this.medicMeth11.TabIndex = 27;
            // 
            // medicper11
            // 
            this.medicper11.FormattingEnabled = true;
            this.medicper11.Location = new System.Drawing.Point(632, 60);
            this.medicper11.Name = "medicper11";
            this.medicper11.Size = new System.Drawing.Size(52, 21);
            this.medicper11.TabIndex = 26;
            // 
            // medicText11
            // 
            this.medicText11.Location = new System.Drawing.Point(382, 60);
            this.medicText11.Name = "medicText11";
            this.medicText11.Size = new System.Drawing.Size(244, 20);
            this.medicText11.TabIndex = 25;
            // 
            // medicMeth2
            // 
            this.medicMeth2.FormattingEnabled = true;
            this.medicMeth2.Location = new System.Drawing.Point(311, 86);
            this.medicMeth2.Name = "medicMeth2";
            this.medicMeth2.Size = new System.Drawing.Size(55, 21);
            this.medicMeth2.TabIndex = 30;
            // 
            // medicper2
            // 
            this.medicper2.FormattingEnabled = true;
            this.medicper2.Location = new System.Drawing.Point(253, 86);
            this.medicper2.Name = "medicper2";
            this.medicper2.Size = new System.Drawing.Size(52, 21);
            this.medicper2.TabIndex = 29;
            // 
            // medicText2
            // 
            this.medicText2.Location = new System.Drawing.Point(3, 86);
            this.medicText2.Name = "medicText2";
            this.medicText2.Size = new System.Drawing.Size(244, 20);
            this.medicText2.TabIndex = 28;
            // 
            // medicMeth12
            // 
            this.medicMeth12.FormattingEnabled = true;
            this.medicMeth12.Location = new System.Drawing.Point(690, 86);
            this.medicMeth12.Name = "medicMeth12";
            this.medicMeth12.Size = new System.Drawing.Size(55, 21);
            this.medicMeth12.TabIndex = 33;
            // 
            // medicper12
            // 
            this.medicper12.FormattingEnabled = true;
            this.medicper12.Location = new System.Drawing.Point(632, 86);
            this.medicper12.Name = "medicper12";
            this.medicper12.Size = new System.Drawing.Size(52, 21);
            this.medicper12.TabIndex = 32;
            // 
            // medicText12
            // 
            this.medicText12.Location = new System.Drawing.Point(382, 86);
            this.medicText12.Name = "medicText12";
            this.medicText12.Size = new System.Drawing.Size(244, 20);
            this.medicText12.TabIndex = 31;
            // 
            // medicMeth3
            // 
            this.medicMeth3.FormattingEnabled = true;
            this.medicMeth3.Location = new System.Drawing.Point(311, 112);
            this.medicMeth3.Name = "medicMeth3";
            this.medicMeth3.Size = new System.Drawing.Size(55, 21);
            this.medicMeth3.TabIndex = 36;
            // 
            // medicper3
            // 
            this.medicper3.FormattingEnabled = true;
            this.medicper3.Location = new System.Drawing.Point(253, 112);
            this.medicper3.Name = "medicper3";
            this.medicper3.Size = new System.Drawing.Size(52, 21);
            this.medicper3.TabIndex = 35;
            // 
            // medicText3
            // 
            this.medicText3.Location = new System.Drawing.Point(3, 112);
            this.medicText3.Name = "medicText3";
            this.medicText3.Size = new System.Drawing.Size(244, 20);
            this.medicText3.TabIndex = 34;
            // 
            // medicMeth13
            // 
            this.medicMeth13.FormattingEnabled = true;
            this.medicMeth13.Location = new System.Drawing.Point(690, 113);
            this.medicMeth13.Name = "medicMeth13";
            this.medicMeth13.Size = new System.Drawing.Size(55, 21);
            this.medicMeth13.TabIndex = 39;
            // 
            // medicper13
            // 
            this.medicper13.FormattingEnabled = true;
            this.medicper13.Location = new System.Drawing.Point(632, 113);
            this.medicper13.Name = "medicper13";
            this.medicper13.Size = new System.Drawing.Size(52, 21);
            this.medicper13.TabIndex = 38;
            // 
            // medicText13
            // 
            this.medicText13.Location = new System.Drawing.Point(382, 113);
            this.medicText13.Name = "medicText13";
            this.medicText13.Size = new System.Drawing.Size(244, 20);
            this.medicText13.TabIndex = 37;
            // 
            // medicMeth4
            // 
            this.medicMeth4.FormattingEnabled = true;
            this.medicMeth4.Location = new System.Drawing.Point(311, 138);
            this.medicMeth4.Name = "medicMeth4";
            this.medicMeth4.Size = new System.Drawing.Size(55, 21);
            this.medicMeth4.TabIndex = 42;
            // 
            // medicper4
            // 
            this.medicper4.FormattingEnabled = true;
            this.medicper4.Location = new System.Drawing.Point(253, 138);
            this.medicper4.Name = "medicper4";
            this.medicper4.Size = new System.Drawing.Size(52, 21);
            this.medicper4.TabIndex = 41;
            // 
            // medicText4
            // 
            this.medicText4.Location = new System.Drawing.Point(3, 138);
            this.medicText4.Name = "medicText4";
            this.medicText4.Size = new System.Drawing.Size(244, 20);
            this.medicText4.TabIndex = 40;
            // 
            // medicMeth14
            // 
            this.medicMeth14.FormattingEnabled = true;
            this.medicMeth14.Location = new System.Drawing.Point(690, 139);
            this.medicMeth14.Name = "medicMeth14";
            this.medicMeth14.Size = new System.Drawing.Size(55, 21);
            this.medicMeth14.TabIndex = 45;
            // 
            // medicper14
            // 
            this.medicper14.FormattingEnabled = true;
            this.medicper14.Location = new System.Drawing.Point(632, 139);
            this.medicper14.Name = "medicper14";
            this.medicper14.Size = new System.Drawing.Size(52, 21);
            this.medicper14.TabIndex = 44;
            // 
            // medicText14
            // 
            this.medicText14.Location = new System.Drawing.Point(382, 139);
            this.medicText14.Name = "medicText14";
            this.medicText14.Size = new System.Drawing.Size(244, 20);
            this.medicText14.TabIndex = 43;
            // 
            // medicMeth5
            // 
            this.medicMeth5.FormattingEnabled = true;
            this.medicMeth5.Location = new System.Drawing.Point(311, 164);
            this.medicMeth5.Name = "medicMeth5";
            this.medicMeth5.Size = new System.Drawing.Size(55, 21);
            this.medicMeth5.TabIndex = 48;
            // 
            // medicper5
            // 
            this.medicper5.FormattingEnabled = true;
            this.medicper5.Location = new System.Drawing.Point(253, 164);
            this.medicper5.Name = "medicper5";
            this.medicper5.Size = new System.Drawing.Size(52, 21);
            this.medicper5.TabIndex = 47;
            // 
            // medicText5
            // 
            this.medicText5.Location = new System.Drawing.Point(3, 164);
            this.medicText5.Name = "medicText5";
            this.medicText5.Size = new System.Drawing.Size(244, 20);
            this.medicText5.TabIndex = 46;
            // 
            // medicMeth15
            // 
            this.medicMeth15.FormattingEnabled = true;
            this.medicMeth15.Location = new System.Drawing.Point(690, 165);
            this.medicMeth15.Name = "medicMeth15";
            this.medicMeth15.Size = new System.Drawing.Size(55, 21);
            this.medicMeth15.TabIndex = 51;
            // 
            // medicper15
            // 
            this.medicper15.FormattingEnabled = true;
            this.medicper15.Location = new System.Drawing.Point(632, 165);
            this.medicper15.Name = "medicper15";
            this.medicper15.Size = new System.Drawing.Size(52, 21);
            this.medicper15.TabIndex = 50;
            // 
            // medicText15
            // 
            this.medicText15.Location = new System.Drawing.Point(382, 165);
            this.medicText15.Name = "medicText15";
            this.medicText15.Size = new System.Drawing.Size(244, 20);
            this.medicText15.TabIndex = 49;
            // 
            // medicMeth10
            // 
            this.medicMeth10.FormattingEnabled = true;
            this.medicMeth10.Location = new System.Drawing.Point(311, 294);
            this.medicMeth10.Name = "medicMeth10";
            this.medicMeth10.Size = new System.Drawing.Size(55, 21);
            this.medicMeth10.TabIndex = 66;
            // 
            // medicper10
            // 
            this.medicper10.FormattingEnabled = true;
            this.medicper10.Location = new System.Drawing.Point(253, 294);
            this.medicper10.Name = "medicper10";
            this.medicper10.Size = new System.Drawing.Size(52, 21);
            this.medicper10.TabIndex = 65;
            // 
            // medicText10
            // 
            this.medicText10.Location = new System.Drawing.Point(3, 294);
            this.medicText10.Name = "medicText10";
            this.medicText10.Size = new System.Drawing.Size(244, 20);
            this.medicText10.TabIndex = 64;
            // 
            // medicMeth9
            // 
            this.medicMeth9.FormattingEnabled = true;
            this.medicMeth9.Location = new System.Drawing.Point(311, 268);
            this.medicMeth9.Name = "medicMeth9";
            this.medicMeth9.Size = new System.Drawing.Size(55, 21);
            this.medicMeth9.TabIndex = 63;
            // 
            // medicper9
            // 
            this.medicper9.FormattingEnabled = true;
            this.medicper9.Location = new System.Drawing.Point(253, 268);
            this.medicper9.Name = "medicper9";
            this.medicper9.Size = new System.Drawing.Size(52, 21);
            this.medicper9.TabIndex = 62;
            // 
            // medicText9
            // 
            this.medicText9.Location = new System.Drawing.Point(3, 268);
            this.medicText9.Name = "medicText9";
            this.medicText9.Size = new System.Drawing.Size(244, 20);
            this.medicText9.TabIndex = 61;
            // 
            // medicMeth8
            // 
            this.medicMeth8.FormattingEnabled = true;
            this.medicMeth8.Location = new System.Drawing.Point(311, 242);
            this.medicMeth8.Name = "medicMeth8";
            this.medicMeth8.Size = new System.Drawing.Size(55, 21);
            this.medicMeth8.TabIndex = 60;
            // 
            // medicper8
            // 
            this.medicper8.FormattingEnabled = true;
            this.medicper8.Location = new System.Drawing.Point(253, 242);
            this.medicper8.Name = "medicper8";
            this.medicper8.Size = new System.Drawing.Size(52, 21);
            this.medicper8.TabIndex = 59;
            // 
            // medicText8
            // 
            this.medicText8.Location = new System.Drawing.Point(3, 242);
            this.medicText8.Name = "medicText8";
            this.medicText8.Size = new System.Drawing.Size(244, 20);
            this.medicText8.TabIndex = 58;
            // 
            // medicMeth7
            // 
            this.medicMeth7.FormattingEnabled = true;
            this.medicMeth7.Location = new System.Drawing.Point(311, 216);
            this.medicMeth7.Name = "medicMeth7";
            this.medicMeth7.Size = new System.Drawing.Size(55, 21);
            this.medicMeth7.TabIndex = 57;
            // 
            // medicper7
            // 
            this.medicper7.FormattingEnabled = true;
            this.medicper7.Location = new System.Drawing.Point(253, 216);
            this.medicper7.Name = "medicper7";
            this.medicper7.Size = new System.Drawing.Size(52, 21);
            this.medicper7.TabIndex = 56;
            // 
            // medicText7
            // 
            this.medicText7.Location = new System.Drawing.Point(3, 216);
            this.medicText7.Name = "medicText7";
            this.medicText7.Size = new System.Drawing.Size(244, 20);
            this.medicText7.TabIndex = 55;
            // 
            // medicMeth6
            // 
            this.medicMeth6.FormattingEnabled = true;
            this.medicMeth6.Location = new System.Drawing.Point(311, 190);
            this.medicMeth6.Name = "medicMeth6";
            this.medicMeth6.Size = new System.Drawing.Size(55, 21);
            this.medicMeth6.TabIndex = 54;
            // 
            // medicper6
            // 
            this.medicper6.FormattingEnabled = true;
            this.medicper6.Location = new System.Drawing.Point(253, 190);
            this.medicper6.Name = "medicper6";
            this.medicper6.Size = new System.Drawing.Size(52, 21);
            this.medicper6.TabIndex = 53;
            // 
            // medicText6
            // 
            this.medicText6.Location = new System.Drawing.Point(3, 190);
            this.medicText6.Name = "medicText6";
            this.medicText6.Size = new System.Drawing.Size(244, 20);
            this.medicText6.TabIndex = 52;
            // 
            // medicMeth20
            // 
            this.medicMeth20.FormattingEnabled = true;
            this.medicMeth20.Location = new System.Drawing.Point(690, 295);
            this.medicMeth20.Name = "medicMeth20";
            this.medicMeth20.Size = new System.Drawing.Size(55, 21);
            this.medicMeth20.TabIndex = 81;
            // 
            // medicper20
            // 
            this.medicper20.FormattingEnabled = true;
            this.medicper20.Location = new System.Drawing.Point(632, 295);
            this.medicper20.Name = "medicper20";
            this.medicper20.Size = new System.Drawing.Size(52, 21);
            this.medicper20.TabIndex = 80;
            // 
            // medicText20
            // 
            this.medicText20.Location = new System.Drawing.Point(382, 295);
            this.medicText20.Name = "medicText20";
            this.medicText20.Size = new System.Drawing.Size(244, 20);
            this.medicText20.TabIndex = 79;
            // 
            // medicMeth19
            // 
            this.medicMeth19.FormattingEnabled = true;
            this.medicMeth19.Location = new System.Drawing.Point(690, 269);
            this.medicMeth19.Name = "medicMeth19";
            this.medicMeth19.Size = new System.Drawing.Size(55, 21);
            this.medicMeth19.TabIndex = 78;
            // 
            // medicper19
            // 
            this.medicper19.FormattingEnabled = true;
            this.medicper19.Location = new System.Drawing.Point(632, 269);
            this.medicper19.Name = "medicper19";
            this.medicper19.Size = new System.Drawing.Size(52, 21);
            this.medicper19.TabIndex = 77;
            // 
            // medicText19
            // 
            this.medicText19.Location = new System.Drawing.Point(382, 269);
            this.medicText19.Name = "medicText19";
            this.medicText19.Size = new System.Drawing.Size(244, 20);
            this.medicText19.TabIndex = 76;
            // 
            // medicMeth18
            // 
            this.medicMeth18.FormattingEnabled = true;
            this.medicMeth18.Location = new System.Drawing.Point(690, 243);
            this.medicMeth18.Name = "medicMeth18";
            this.medicMeth18.Size = new System.Drawing.Size(55, 21);
            this.medicMeth18.TabIndex = 75;
            // 
            // medicper18
            // 
            this.medicper18.FormattingEnabled = true;
            this.medicper18.Location = new System.Drawing.Point(632, 243);
            this.medicper18.Name = "medicper18";
            this.medicper18.Size = new System.Drawing.Size(52, 21);
            this.medicper18.TabIndex = 74;
            // 
            // medicText18
            // 
            this.medicText18.Location = new System.Drawing.Point(382, 243);
            this.medicText18.Name = "medicText18";
            this.medicText18.Size = new System.Drawing.Size(244, 20);
            this.medicText18.TabIndex = 73;
            // 
            // medicMeth17
            // 
            this.medicMeth17.FormattingEnabled = true;
            this.medicMeth17.Location = new System.Drawing.Point(690, 217);
            this.medicMeth17.Name = "medicMeth17";
            this.medicMeth17.Size = new System.Drawing.Size(55, 21);
            this.medicMeth17.TabIndex = 72;
            // 
            // medicper17
            // 
            this.medicper17.FormattingEnabled = true;
            this.medicper17.Location = new System.Drawing.Point(632, 217);
            this.medicper17.Name = "medicper17";
            this.medicper17.Size = new System.Drawing.Size(52, 21);
            this.medicper17.TabIndex = 71;
            // 
            // medicText17
            // 
            this.medicText17.Location = new System.Drawing.Point(382, 217);
            this.medicText17.Name = "medicText17";
            this.medicText17.Size = new System.Drawing.Size(244, 20);
            this.medicText17.TabIndex = 70;
            // 
            // medicMeth16
            // 
            this.medicMeth16.FormattingEnabled = true;
            this.medicMeth16.Location = new System.Drawing.Point(690, 191);
            this.medicMeth16.Name = "medicMeth16";
            this.medicMeth16.Size = new System.Drawing.Size(55, 21);
            this.medicMeth16.TabIndex = 69;
            // 
            // medicper16
            // 
            this.medicper16.FormattingEnabled = true;
            this.medicper16.Location = new System.Drawing.Point(632, 191);
            this.medicper16.Name = "medicper16";
            this.medicper16.Size = new System.Drawing.Size(52, 21);
            this.medicper16.TabIndex = 68;
            // 
            // medicText16
            // 
            this.medicText16.Location = new System.Drawing.Point(382, 191);
            this.medicText16.Name = "medicText16";
            this.medicText16.Size = new System.Drawing.Size(244, 20);
            this.medicText16.TabIndex = 67;
            // 
            // label42
            // 
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label42.Location = new System.Drawing.Point(-2, 319);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(755, 2);
            this.label42.TabIndex = 82;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label61);
            this.tabPage4.Controls.Add(this.verpleegkundigeBox);
            this.tabPage4.Controls.Add(this.VerslagBox);
            this.tabPage4.Controls.Add(this.label62);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(756, 566);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // infuustext1
            // 
            this.infuustext1.Location = new System.Drawing.Point(3, 350);
            this.infuustext1.Name = "infuustext1";
            this.infuustext1.Size = new System.Drawing.Size(289, 20);
            this.infuustext1.TabIndex = 83;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(6, 322);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(83, 25);
            this.label44.TabIndex = 84;
            this.label44.Text = "Infuus:";
            // 
            // infuustext2
            // 
            this.infuustext2.Location = new System.Drawing.Point(3, 376);
            this.infuustext2.Name = "infuustext2";
            this.infuustext2.Size = new System.Drawing.Size(289, 20);
            this.infuustext2.TabIndex = 85;
            // 
            // infuustext3
            // 
            this.infuustext3.Location = new System.Drawing.Point(3, 402);
            this.infuustext3.Name = "infuustext3";
            this.infuustext3.Size = new System.Drawing.Size(289, 20);
            this.infuustext3.TabIndex = 86;
            // 
            // pdaText
            // 
            this.pdaText.Location = new System.Drawing.Point(382, 376);
            this.pdaText.Name = "pdaText";
            this.pdaText.Size = new System.Drawing.Size(244, 20);
            this.pdaText.TabIndex = 87;
            // 
            // infuusMini1
            // 
            this.infuusMini1.Location = new System.Drawing.Point(301, 350);
            this.infuusMini1.Name = "infuusMini1";
            this.infuusMini1.Size = new System.Drawing.Size(65, 20);
            this.infuusMini1.TabIndex = 88;
            // 
            // infuusMini2
            // 
            this.infuusMini2.Location = new System.Drawing.Point(301, 376);
            this.infuusMini2.Name = "infuusMini2";
            this.infuusMini2.Size = new System.Drawing.Size(65, 20);
            this.infuusMini2.TabIndex = 89;
            // 
            // infuusMini3
            // 
            this.infuusMini3.Location = new System.Drawing.Point(301, 402);
            this.infuusMini3.Name = "infuusMini3";
            this.infuusMini3.Size = new System.Drawing.Size(65, 20);
            this.infuusMini3.TabIndex = 90;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(379, 357);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(65, 13);
            this.label56.TabIndex = 91;
            this.label56.Text = "PDA/PCEA:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(629, 379);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(18, 13);
            this.label57.TabIndex = 92;
            this.label57.Text = "@";
            // 
            // pdaMini
            // 
            this.pdaMini.Location = new System.Drawing.Point(653, 376);
            this.pdaMini.Name = "pdaMini";
            this.pdaMini.Size = new System.Drawing.Size(77, 20);
            this.pdaMini.TabIndex = 93;
            // 
            // onderzoekbox1
            // 
            this.onderzoekbox1.Location = new System.Drawing.Point(569, 458);
            this.onderzoekbox1.Name = "onderzoekbox1";
            this.onderzoekbox1.Size = new System.Drawing.Size(184, 20);
            this.onderzoekbox1.TabIndex = 94;
            // 
            // onderzoekbox2
            // 
            this.onderzoekbox2.Location = new System.Drawing.Point(569, 484);
            this.onderzoekbox2.Name = "onderzoekbox2";
            this.onderzoekbox2.Size = new System.Drawing.Size(184, 20);
            this.onderzoekbox2.TabIndex = 95;
            // 
            // onderzoekbox4
            // 
            this.onderzoekbox4.Location = new System.Drawing.Point(569, 535);
            this.onderzoekbox4.Name = "onderzoekbox4";
            this.onderzoekbox4.Size = new System.Drawing.Size(184, 20);
            this.onderzoekbox4.TabIndex = 97;
            // 
            // onderzoekbox3
            // 
            this.onderzoekbox3.Location = new System.Drawing.Point(569, 509);
            this.onderzoekbox3.Name = "onderzoekbox3";
            this.onderzoekbox3.Size = new System.Drawing.Size(184, 20);
            this.onderzoekbox3.TabIndex = 96;
            // 
            // drainbox4
            // 
            this.drainbox4.Location = new System.Drawing.Point(339, 535);
            this.drainbox4.Name = "drainbox4";
            this.drainbox4.Size = new System.Drawing.Size(184, 20);
            this.drainbox4.TabIndex = 101;
            // 
            // drainbox3
            // 
            this.drainbox3.Location = new System.Drawing.Point(339, 509);
            this.drainbox3.Name = "drainbox3";
            this.drainbox3.Size = new System.Drawing.Size(184, 20);
            this.drainbox3.TabIndex = 100;
            // 
            // drainbox2
            // 
            this.drainbox2.Location = new System.Drawing.Point(339, 484);
            this.drainbox2.Name = "drainbox2";
            this.drainbox2.Size = new System.Drawing.Size(184, 20);
            this.drainbox2.TabIndex = 99;
            // 
            // drainbox1
            // 
            this.drainbox1.Location = new System.Drawing.Point(339, 458);
            this.drainbox1.Name = "drainbox1";
            this.drainbox1.Size = new System.Drawing.Size(184, 20);
            this.drainbox1.TabIndex = 98;
            // 
            // zorgbox
            // 
            this.zorgbox.Location = new System.Drawing.Point(3, 458);
            this.zorgbox.Multiline = true;
            this.zorgbox.Name = "zorgbox";
            this.zorgbox.Size = new System.Drawing.Size(302, 97);
            this.zorgbox.TabIndex = 102;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(6, 425);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(93, 25);
            this.label58.TabIndex = 103;
            this.label58.Text = "Zorgen:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(334, 425);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(87, 25);
            this.label59.TabIndex = 104;
            this.label59.Text = "Drains:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(564, 425);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(133, 25);
            this.label60.TabIndex = 105;
            this.label60.Text = "Onderzoek:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(6, 3);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(99, 25);
            this.label62.TabIndex = 23;
            this.label62.Text = "Verslag:";
            // 
            // VerslagBox
            // 
            this.VerslagBox.Location = new System.Drawing.Point(3, 48);
            this.VerslagBox.Multiline = true;
            this.VerslagBox.Name = "VerslagBox";
            this.VerslagBox.Size = new System.Drawing.Size(747, 512);
            this.VerslagBox.TabIndex = 35;
            // 
            // verpleegkundigeBox
            // 
            this.verpleegkundigeBox.FormattingEnabled = true;
            this.verpleegkundigeBox.Location = new System.Drawing.Point(389, 9);
            this.verpleegkundigeBox.Name = "verpleegkundigeBox";
            this.verpleegkundigeBox.Size = new System.Drawing.Size(121, 21);
            this.verpleegkundigeBox.TabIndex = 36;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(293, 12);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(90, 13);
            this.label61.TabIndex = 37;
            this.label61.Text = "Verpleegkundige:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patNrBox;
        private System.Windows.Forms.ComboBox boxBox;
        private System.Windows.Forms.TextBox inschrijvingsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ComboBox geslachtBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox gaatNaarBox;
        private System.Windows.Forms.ComboBox komtVanBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox opnameDatum;
        private System.Windows.Forms.TextBox ontslagUur;
        private System.Windows.Forms.TextBox opnameUur;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox diagnose;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox thuismedicatie;
        private System.Windows.Forms.TextBox anamnese;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox kathDate5;
        private System.Windows.Forms.TextBox kathDate2;
        private System.Windows.Forms.TextBox kathDate3;
        private System.Windows.Forms.TextBox kathDate4;
        private System.Windows.Forms.TextBox KathDate1;
        private System.Windows.Forms.TextBox pciaDatum;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox pceaDatum;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox pdaDatum;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox blaasDatum;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox sondeDatum;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox thoraxDate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DateTimePicker ademStop1;
        private System.Windows.Forms.DateTimePicker ademStart1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox ademStopU1;
        private System.Windows.Forms.TextBox ademStartU1;
        private System.Windows.Forms.TextBox ademStopU3;
        private System.Windows.Forms.TextBox ademStartU3;
        private System.Windows.Forms.DateTimePicker ademStop3;
        private System.Windows.Forms.DateTimePicker ademStart3;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox ademStopU2;
        private System.Windows.Forms.TextBox ademStartU2;
        private System.Windows.Forms.DateTimePicker ademStop2;
        private System.Windows.Forms.DateTimePicker ademStart2;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.CheckBox swangans;
        private System.Windows.Forms.CheckBox cvd;
        private System.Windows.Forms.CheckBox picco;
        private System.Windows.Forms.CheckBox arteriele;
        private System.Windows.Forms.CheckBox gif;
        private System.Windows.Forms.CheckBox niCardTromb;
        private System.Windows.Forms.CheckBox cardTromb;
        private System.Windows.Forms.CheckBox tempPm;
        private System.Windows.Forms.CheckBox pmImp;
        public System.Windows.Forms.FlowLayoutPanel nivFlowPanel;
        
       
        private System.Windows.Forms.Label label55;
        private ComboBox dnrDrop;
        private ComboBox kathMet5;
        private ComboBox kathMet4;
        private ComboBox kathMet3;
        private ComboBox kathMet2;
        private ComboBox kathMet1;
        private ComboBox behandArts;
        private ComboBox coordArts;
        private TextBox bloedDrukBox;
        private TextBox pressureBox;
        private Label label40;
        private Label label39;
        private Label label32;
        private Label label31;
        private TextBox ritmeBox;
        private Label label30;
        private Label label29;
        private CheckBox zalvingCheckBox;
        private CheckBox KineCheckBox;
        private TextBox Dieet;
        private CheckBox svCheckbox;
        private ComboBox teleCombo;
        private ComboBox medicMeth1;
        private ComboBox medicper1;
        private Label label41;
        private TextBox medicText1;
        private ComboBox medicMeth20;
        private ComboBox medicper20;
        private TextBox medicText20;
        private ComboBox medicMeth19;
        private ComboBox medicper19;
        private TextBox medicText19;
        private ComboBox medicMeth18;
        private ComboBox medicper18;
        private TextBox medicText18;
        private ComboBox medicMeth17;
        private ComboBox medicper17;
        private TextBox medicText17;
        private ComboBox medicMeth16;
        private ComboBox medicper16;
        private TextBox medicText16;
        private ComboBox medicMeth10;
        private ComboBox medicper10;
        private TextBox medicText10;
        private ComboBox medicMeth9;
        private ComboBox medicper9;
        private TextBox medicText9;
        private ComboBox medicMeth8;
        private ComboBox medicper8;
        private TextBox medicText8;
        private ComboBox medicMeth7;
        private ComboBox medicper7;
        private TextBox medicText7;
        private ComboBox medicMeth6;
        private ComboBox medicper6;
        private TextBox medicText6;
        private ComboBox medicMeth15;
        private ComboBox medicper15;
        private TextBox medicText15;
        private ComboBox medicMeth5;
        private ComboBox medicper5;
        private TextBox medicText5;
        private ComboBox medicMeth14;
        private ComboBox medicper14;
        private TextBox medicText14;
        private ComboBox medicMeth4;
        private ComboBox medicper4;
        private TextBox medicText4;
        private ComboBox medicMeth13;
        private ComboBox medicper13;
        private TextBox medicText13;
        private ComboBox medicMeth3;
        private ComboBox medicper3;
        private TextBox medicText3;
        private ComboBox medicMeth12;
        private ComboBox medicper12;
        private TextBox medicText12;
        private ComboBox medicMeth2;
        private ComboBox medicper2;
        private TextBox medicText2;
        private ComboBox medicMeth11;
        private ComboBox medicper11;
        private TextBox medicText11;
        private Label label57;
        private Label label56;
        private TextBox infuusMini3;
        private TextBox infuusMini2;
        private TextBox infuusMini1;
        private TextBox pdaText;
        private TextBox infuustext3;
        private TextBox infuustext2;
        private Label label44;
        private TextBox infuustext1;
        private Label label42;
        private TabPage tabPage4;
        private Label label60;
        private Label label59;
        private Label label58;
        private TextBox zorgbox;
        private TextBox drainbox4;
        private TextBox drainbox3;
        private TextBox drainbox2;
        private TextBox drainbox1;
        private TextBox onderzoekbox4;
        private TextBox onderzoekbox3;
        private TextBox onderzoekbox2;
        private TextBox onderzoekbox1;
        private TextBox pdaMini;
        private TextBox VerslagBox;
        private Label label62;
        private Label label61;
        private ComboBox verpleegkundigeBox;
    }
}

