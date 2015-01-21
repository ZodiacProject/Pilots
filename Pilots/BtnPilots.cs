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
        private int labParam = 1;// p параметр для создания новых label + labParam
        private int matrixParam = 0; //пареметр для рисования матрицы
        private int X = 120;
        private int Y = 125;
        private int delta = 1;
 
    public void MakeField(Cell[,] cell, int max)
    {
      Random rand = new Random();
      cell = new Cell[max, max];
      int i = 0, j = 0;
      for (i = 0; i < cell.GetLength(0); i++)
                {
                    for (j = 0; j < cell.GetLength(1); j++, labParam++)
                    {
                        cell[i, j] = new Cell();
                        cell[i, j].Name = "Btn" + labParam.ToString();
                        cell[i, j].Text = rand.Next(0, 2).ToString();

                        if (matrixParam != i)
                        {
                            Y += 35;
                            delta = 1;
                            matrixParam = i;// определение строки
                        }
                        if (matrixParam == i)
                        {
                            cell[i, j].Location = new Point(X + (delta) * 32, Y);
                            delta++;
                        }
                        cell[i, j].Size = new Size(33, 35);
                        cell[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                        if (cell[i, j].Text == "0")
                            cell[i, j].ForeColor = Color.Blue;
                        else
                            cell[i, j].ForeColor = Color.Green;
                        cell[i, j].Cursor = Cursors.Hand;
                       // lab.DoubleClick += new EventHandler(this.labelMain_Click);
                       // lab.Click += new System.EventHandler(this.labelMain_Click);
                        this.Controls.Add(cell[i, j]);
                    }
                }

    }
    }
}
