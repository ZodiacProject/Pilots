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
                CreateField();

                PressButton();
        }
        private void CreateField()
        {
       
            Random rand = new Random();
            int max = (int)numbGame.Value;
            cell = new Cell[max, max];
            int pX = 120;
            int pY = 125;
            int ButName = 1;
            int matrixParam = 0; //пареметр для рисования матрицы
            int delta = 1;
            sizeFieldLabel.Text = "Вы выбрали сейф размером: " + max.ToString() + " X " + max.ToString();
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    if (matrixParam != i)
                    {
                        pY += 35;
                        delta = 1;
                        matrixParam = i;// определение строки
                    }
                    if (matrixParam == i)
                    {
                        cell[i, j] = new Cell(cell, pX, pY, delta, rand, ButName);
                        delta++;
                    }

                   this.Controls.Add(cell[i, j]);
                    ButName++;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "1")
            {
                btn.Text = "0";
                btn.ForeColor = Color.Blue;
              //  MessageBox.Show(btn.Name);
            }
            else if (btn.Text == "0")
            {
                btn.Text = "1";
                btn.ForeColor = Color.Green;
            }
            UpdateField(btn);
        }
     
        private void PressButton()
        {
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                      cell[i, j].Click += new EventHandler(ButtonClick);
                    //  MessageBox.Show("" + cell[i,j].Name + " " + cell[i, j].Text);     
                }
            }
        }
        private void UpdateField(Button btn)
        {
            MessageBox.Show("" + btn.Name);
        }
    }
}
