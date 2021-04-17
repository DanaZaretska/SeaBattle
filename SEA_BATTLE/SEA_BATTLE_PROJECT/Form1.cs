using System;
using System.Windows.Forms;

namespace SEA_BATTLE_PROJECT
{
    public partial class Form1 : Form
    {
        int[,] coordinatesMatrix = new int[10, 10];
        int[,] coordinatesMatrix2 = new int[10, 10];

        public Form1()
        {
            InitializeComponent();

            Functions.seaBattleGridsPrepare(playerGrid, computerGrid, coordinatesMatrix);
            Functions.computerShipsGeneration(coordinatesMatrix2, computerGrid);

            textBox2.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    textBox2.Text += (coordinatesMatrix2[i, j] + "  ");
                }

                textBox2.Text += ("\r\n");
            }
        }

        private void playerGrid_SelectionChanged(object sender, EventArgs e)
        {
            Functions.extraCellsIgnore(playerGrid);

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (playerGrid.Rows[i].Cells[j].Selected)
                    {
                        coordinatesMatrix[i - 1, j - 1] = 1;
                    }
                }
            }

            /*
            if (Functions.countOneNums(coordinatesMatrix) <= 20)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (coordinatesMatrix[i, j] == 1)
                        {
                            playerGrid.Rows[i + 1].Cells[j + 1].Selected = true;
                        }
                    }
                }
            }*/
            
        }

        private void computerGrid_SelectionChanged(object sender, EventArgs e)
        {
            Functions.extraCellsIgnore(computerGrid);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            playerGrid.ClearSelection();
            Functions.matrixZerosFill(coordinatesMatrix);

            Random rand = new Random();

            int upDown = rand.Next(0, 2);
            Functions.quarternaryShipGenerate(coordinatesMatrix, upDown, rand);

            for (int k = 0; k < 2; k++)
            {
                upDown = rand.Next(0, 2);
                Functions.tripleShipGenerate(coordinatesMatrix, upDown, rand);
            }

            for (int k = 0; k < 3; k++)
            {
                upDown = rand.Next(0, 2);
                Functions.doubleShipGenerate(coordinatesMatrix, upDown, rand);
            }

            Functions.singleShipGenerate(coordinatesMatrix, upDown, rand);

            Functions.selectionSynchronize(coordinatesMatrix, playerGrid);

            textBox1.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    textBox1.Text += (coordinatesMatrix[i, j] + "  ");
                }

                textBox1.Text += ("\r\n");
            }
        }

        private void computerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //computerGrid.ClearSelection();
            //Functions.computerShipsDestroying(coordinatesMatrix2, computerGrid);
        }

        private void computerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            computerGrid.ClearSelection();
            Functions.computerShipsDestroying(coordinatesMatrix2, computerGrid);
        }
    }
}
