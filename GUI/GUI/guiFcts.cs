using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logic;

namespace GUI
{
    public class guiFcts
    {
        public static List<Panel> getNivPanels(List<NIV> nivlist) {
            int counter = 0;
            List<Panel> panelList = new List<Panel>();
            if (nivlist.Count != 0)
            {
                foreach (var thisNiv in nivlist)
                {
                    counter++;

                    
                    System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
                    panel1.SuspendLayout();
                    //instantiate items
                    System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                    System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
                    System.Windows.Forms.DateTimePicker dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
                    System.Windows.Forms.DateTimePicker dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
                    System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
                    //initiate items
                    textBox1.Location = new System.Drawing.Point(195, 23);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(39, 20);
                    textBox1.TabIndex = 51;
                    textBox1.Text = thisNiv.stop.TimeOfDay.ToString("hh\\:mm");

                    textBox2.Location = new System.Drawing.Point(195, 3);
                    textBox2.Name = "textBox2";
                    textBox2.Size = new System.Drawing.Size(39, 20);
                    textBox2.TabIndex = 50;
                    textBox2.Text = thisNiv.start.TimeOfDay.ToString("hh\\:mm"); 

                    dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                    dateTimePicker1.Location = new System.Drawing.Point(106, 23);
                    dateTimePicker1.Name = "dateTimePicker1";
                    dateTimePicker1.Size = new System.Drawing.Size(83, 20);
                    dateTimePicker1.TabIndex = 49;
                    dateTimePicker1.Text = thisNiv.stop.Date.ToString();

                    dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                    dateTimePicker2.Location = new System.Drawing.Point(106, 3);
                    dateTimePicker2.Name = "dateTimePicker2";
                    dateTimePicker2.Size = new System.Drawing.Size(83, 20);
                    dateTimePicker2.TabIndex = 48;
                    dateTimePicker2.Text = thisNiv.start.Date.ToString(); 

                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(38, 28);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(62, 13);
                    label1.TabIndex = 47;
                    label1.Text = "datum stop:";

                    label2.AutoSize = true;
                    label2.Location = new System.Drawing.Point(38, 3);
                    label2.Name = "label2";
                    label2.Size = new System.Drawing.Size(62, 13);
                    label2.TabIndex = 46;
                    label2.Text = "datum start:";

                    label3.AutoSize = true;
                    label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label3.Location = new System.Drawing.Point(-4, 3);
                    label3.Name = "label3";
                    label3.Size = new System.Drawing.Size(36, 39);
                    label3.TabIndex = 45;
                    label3.Text = Convert.ToString(counter);
                    //add to panel
                    panel1.Controls.Add(textBox1);
                    panel1.Controls.Add(textBox2);
                    panel1.Controls.Add(dateTimePicker1);
                    panel1.Controls.Add(dateTimePicker2);
                    panel1.Controls.Add(label1);
                    panel1.Controls.Add(label2);
                    panel1.Controls.Add(label3);
                    panel1.Location = new System.Drawing.Point(3, 3);
                    panel1.Name = "panel" + counter;
                    panel1.Size = new System.Drawing.Size(243, 59);
                    panel1.TabIndex = 0;

                    panel1.ResumeLayout(false);
                    panel1.PerformLayout();
                    panelList.Add(panel1);
                }
            }
            counter++;

            System.Windows.Forms.Panel panel2 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            //instantiate items
            System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.DateTimePicker dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            System.Windows.Forms.DateTimePicker dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
            //initiate items
            textBox3.Location = new System.Drawing.Point(195, 23);
            textBox3.Name = "textBox1";
            textBox3.Size = new System.Drawing.Size(39, 20);
            textBox3.TabIndex = 51;

            textBox4.Location = new System.Drawing.Point(195, 3);
            textBox4.Name = "textBox2";
            textBox4.Size = new System.Drawing.Size(39, 20);
            textBox4.TabIndex = 50;

            dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker3.Location = new System.Drawing.Point(106, 23);
            dateTimePicker3.Name = "dateTimePicker1";
            dateTimePicker3.Size = new System.Drawing.Size(83, 20);
            dateTimePicker3.TabIndex = 49;

            dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker4.Location = new System.Drawing.Point(106, 3);
            dateTimePicker4.Name = "dateTimePicker2";
            dateTimePicker4.Size = new System.Drawing.Size(83, 20);
            dateTimePicker4.TabIndex = 48;

            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(38, 28);
            label4.Name = "label1";
            label4.Size = new System.Drawing.Size(62, 13);
            label4.TabIndex = 47;
            label4.Text = "datum stop:";

            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(38, 3);
            label5.Name = "label2";
            label5.Size = new System.Drawing.Size(62, 13);
            label5.TabIndex = 46;
            label5.Text = "datum start:";

            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(-4, 3);
            label6.Name = "label3";
            label6.Size = new System.Drawing.Size(36, 39);
            label6.TabIndex = 45;
            label6.Text = Convert.ToString(counter);
            //add to panel
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(dateTimePicker4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel" + counter;
            panel2.Size = new System.Drawing.Size(243, 59);
            panel2.TabIndex = 0;
                 
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelList.Add(panel2);
                 
                 
            return panelList;
        }

        public static string[] getDiensten()
        {
            List<string> dienstLijst=new List<string>();
            dienstLijst.Add("Daghospitaal Geneeskunde 1 (DH D1)");
            dienstLijst.Add("Daghospitaal Geneeskunde 2 W(DH D2)");
            dienstLijst.Add("Daghospitaal Geriatrie W(DH G)");
            dienstLijst.Add("Daghospitaal Heelkunde 1 (DH C1)");
            dienstLijst.Add("Daghospitaal Heelkunde 2  (DH C2)");
            dienstLijst.Add("Geneeskunde 1 (D1)");
            dienstLijst.Add("Geneeskunde 2 (D2)");
            dienstLijst.Add("Geriatrie 1 W(G1)");
            dienstLijst.Add("Geriatrie 2 W(G2)");
            dienstLijst.Add("Heelkunde 1 (C1)");
            dienstLijst.Add("Heelkunde 2 (C2)");
            dienstLijst.Add("Heelkunde 3 (C3)");
            dienstLijst.Add("Materniteit(M)");
            dienstLijst.Add("Mortuarium");
            dienstLijst.Add("Operatiekwartier(OK)");
            dienstLijst.Add("OperatieKwartier W(OK)");
            dienstLijst.Add("SP Locomotorisch(SP)");
            dienstLijst.Add("Spoedgevallen(SP)");
            dienstLijst.Add("Spoedgevallen W(SP)");
            dienstLijst.Add("UZA");
            dienstLijst.Add("UZ Gent");
            dienstLijst.Add("Consultatie");
            dienstLijst.Add("Imelda Bonheiden");
            dienstLijst.Add("Thuis");
            dienstLijst.Add("Andere");
            

            return dienstLijst.ToArray();
        }

    }
}





