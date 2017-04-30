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
        public Form1()
        {
            InitializeComponent();
            NIV pew=new NIV(1, 1, new DateTime(1990, 12,1 , 12, 30, 30), DateTime.Now);
            var pewlist = new List<NIV>();
            pewlist.Add(pew);
            List<Panel> panelList = guiFcts.getNivPanels(pewlist);
            foreach (var paneel in panelList)
            {
                this.nivFlowPanel.Controls.Add(paneel);
            }
            this.komtVanBox.Items.AddRange(guiFcts.getDiensten());
            this.gaatNaarBox.Items.AddRange(guiFcts.getDiensten());
           
            
        }

  
    }
}
