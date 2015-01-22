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
    class Cell : Button
    {
        public Cell(Cell[,] cell, int pX, int pY, int delta, Random rand, int ButName)
        {
            this.Name = "Btn" + ButName.ToString();
            this.Text = rand.Next(0, 2).ToString();
            this.Location = new Point(pX + (delta) * 32, pY);
              
            this.Size = new Size(33, 35);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            if (this.Text == "0")
                this.ForeColor = Color.Blue;
            else
                this.ForeColor = Color.Green;
            this.Cursor = Cursors.Hand;

        }
    }
}
