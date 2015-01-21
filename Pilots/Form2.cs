using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilots
{
    public partial class Child : Form
    {
        Cell[,] cell;
        public Child(MainForm parent)
        {
            InitializeComponent();
            MdiParent = parent;    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
                btnStart.Enabled = false;
                numbGame.Enabled = false;
                //-----------------------------/

               
              int max = (int)numbGame.Value;
              Cell Start = new Cell();
              Start.MakeField(cell, max);
            

// main cycle ***


           
        }
    }
}
