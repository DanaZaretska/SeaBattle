using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEA_BATTLE_PROJECT
{
    public partial class Functions : Form1
    {
        public static void seaBattleGridsPrepare(DataGridView gridLeft, DataGridView gridRight, int[,] matrix)
        {
            gridLeft.RowCount = 11;
            gridLeft.ColumnCount = 11;

            gridRight.RowCount = 11;
            gridRight.ColumnCount = 11;

            char[] symbols = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    gridLeft.Rows[i].Height = 27;
                    gridRight.Rows[i].Height = 27;
                }

                if (i != 10)
                {
                    gridLeft.Rows[i + 1].Cells[0].Value = i + 1;
                    gridRight.Rows[i + 1].Cells[0].Value = i + 1;

                    gridLeft.Rows[0].Cells[i + 1].Value = symbols[i];
                    gridRight.Rows[0].Cells[i + 1].Value = symbols[i];

                    gridLeft.Rows[i + 1].Cells[0].Style.BackColor = Color.White;
                    gridRight.Rows[i + 1].Cells[0].Style.BackColor = Color.White;

                    gridLeft.Rows[0].Cells[i + 1].Style.BackColor = Color.White;
                    gridRight.Rows[0].Cells[i + 1].Style.BackColor = Color.White;

                    for (int j = 0; j < 10; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            gridLeft.Rows[0].Cells[0].Style.BackColor = Color.White;
            gridRight.Rows[0].Cells[0].Style.BackColor = Color.White;
        }

        public static int countOneNums(int[,] matrix)
        {
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        count += 1;
                    }
                }
            }

            return count;
        }

        public static void extraCellsIgnore(DataGridView dataGrid)
        {
            for (int i = 0; i < 10; i++)
            {
                if (dataGrid.Rows[i + 1].Cells[0].Selected ||
                    dataGrid.Rows[0].Cells[i + 1].Selected)
                {
                    dataGrid.Rows[i + 1].Cells[0].Selected = false;
                    dataGrid.Rows[0].Cells[i + 1].Selected = false;
                }
            }

            if (dataGrid.Rows[0].Cells[0].Selected)
            {
                dataGrid.Rows[0].Cells[0].Selected = false;
            }
        }

        public static void matrixZerosFill(int[,] matrix)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public static void quarternaryShipGenerate(int[,] matrix, int upDown, Random rand)
        {
            if (upDown == 0)
            {
                int quartRow = rand.Next(0, 7);
                int quartColumn = rand.Next(0, 10);

                while (!Functions.generateAble(matrix, upDown, 4, quartRow, quartColumn))
                {
                    quartRow = rand.Next(0, 7);
                    quartColumn = rand.Next(0, 10);
                }

                for (int i = 0; i < 4; i++)
                {
                    matrix[quartRow + i, quartColumn] = 1;

                    if (quartRow >= 1)
                    {
                        matrix[quartRow - 1, quartColumn] = 2;
                    }

                    if (quartRow <= 5)
                    {
                        matrix[quartRow + 4, quartColumn] = 2;
                    }

                    if (quartColumn >= 1)
                    {
                        matrix[quartRow + i, quartColumn - 1] = 2;
                    }

                    if (quartColumn <= 8)
                    {
                        matrix[quartRow + i, quartColumn + 1] = 2;
                    }

                    if (quartRow >= 1 && quartColumn >= 1)
                    {
                        matrix[quartRow - 1, quartColumn - 1] = 2;
                    }

                    if (quartRow <= 5 && quartColumn <= 8)
                    {
                        matrix[quartRow + 4, quartColumn + 1] = 2;
                    }

                    if (quartRow >= 1 && quartColumn <= 8)
                    {
                        matrix[quartRow - 1, quartColumn + 1] = 2;
                    }

                    if (quartRow <= 5 && quartColumn >= 1)
                    {
                        matrix[quartRow + 4, quartColumn - 1] = 2;
                    }
                }
            }

            if (upDown == 1)
            {
                int quartRow = rand.Next(0, 10);
                int quartColumn = rand.Next(0, 7);

                while (!Functions.generateAble(matrix, upDown, 4, quartRow, quartColumn))
                {
                    quartRow = rand.Next(0, 10);
                    quartColumn = rand.Next(0, 7);
                }

                for (int i = 0; i < 4; i++)
                {
                    matrix[quartRow, quartColumn + i] = 1;

                    if (quartColumn >= 1)
                    {
                        matrix[quartRow, quartColumn - 1] = 2;
                    }

                    if (quartColumn <= 5)
                    {
                        matrix[quartRow, quartColumn + 4] = 2;
                    }

                    if (quartRow >= 1)
                    {
                        matrix[quartRow - 1, quartColumn + i] = 2;
                    }

                    if (quartRow <= 8)
                    {
                        matrix[quartRow + 1, quartColumn + i] = 2;
                    }

                    if (quartRow >= 1 && quartColumn >= 1)
                    {
                        matrix[quartRow - 1, quartColumn - 1] = 2;
                    }

                    if (quartRow <= 8 && quartColumn <= 5)
                    {
                        matrix[quartRow + 1, quartColumn + 4] = 2;
                    }

                    if (quartRow <= 8 && quartColumn >= 1)
                    {
                        matrix[quartRow + 1, quartColumn - 1] = 2;
                    }

                    if (quartRow >= 1 && quartColumn <= 5)
                    {
                        matrix[quartRow - 1, quartColumn + 4] = 2;
                    }
                }
            }
        }

        public static void tripleShipGenerate(int[,] matrix, int upDown, Random rand)
        {
            if (upDown == 0)
            {
                int tripleRow = rand.Next(0, 8);
                int tripleColumn = rand.Next(0, 10);

                while (!Functions.generateAble(matrix, upDown, 3, tripleRow, tripleColumn))
                {
                    tripleRow = rand.Next(0, 8);
                    tripleColumn = rand.Next(0, 10);
                }

                for (int i = 0; i < 3; i++)
                {
                    matrix[tripleRow + i, tripleColumn] = 1;

                    if (tripleRow >= 1)
                    {
                            if (matrix[tripleRow - 1, tripleColumn] == 0)
                                matrix[tripleRow - 1, tripleColumn] = 2;
                    }

                    if (tripleRow <= 6)
                    {
                        if (matrix[tripleRow + 3, tripleColumn] == 0)
                            matrix[tripleRow + 3, tripleColumn] = 2;
                    }

                    if (tripleColumn >= 1)
                    {
                        if (matrix[tripleRow + i, tripleColumn - 1] == 0)
                            matrix[tripleRow + i, tripleColumn - 1] = 2;
                    }

                    if (tripleColumn <= 8)
                    {
                        if (matrix[tripleRow + i, tripleColumn + 1] == 0)
                            matrix[tripleRow + i, tripleColumn + 1] = 2;
                    }

                    if (tripleRow >= 1 && tripleColumn >= 1)
                    {
                        if (matrix[tripleRow - 1, tripleColumn - 1] == 0)
                            matrix[tripleRow - 1, tripleColumn - 1] = 2;
                    }

                    if (tripleRow <= 6 && tripleColumn <= 8)
                    {
                        if (matrix[tripleRow + 3, tripleColumn + 1] == 0)
                            matrix[tripleRow + 3, tripleColumn + 1] = 2;
                    }

                    if (tripleRow >= 1 && tripleColumn <= 8)
                    {
                        if (matrix[tripleRow - 1, tripleColumn + 1] == 0)
                            matrix[tripleRow - 1, tripleColumn + 1] = 2;
                    }

                    if (tripleRow <= 6 && tripleColumn >= 1)
                    {
                        if (matrix[tripleRow + 3, tripleColumn - 1] == 0)
                            matrix[tripleRow + 3, tripleColumn - 1] = 2;
                    }        
                }
            }

            if (upDown == 1)
            {
                
                int tripleRow = rand.Next(0, 10);
                int tripleColumn = rand.Next(0, 8);

                while (!Functions.generateAble(matrix, upDown, 3, tripleRow, tripleColumn))
                {
                    tripleRow = rand.Next(0, 10);
                    tripleColumn = rand.Next(0, 8);
                }

                for (int i = 0; i < 3; i++)
                {
                    matrix[tripleRow, tripleColumn + i] = 1;

                    if (tripleColumn >= 1)
                    {
                        if (matrix[tripleRow, tripleColumn - 1] == 0)
                            matrix[tripleRow, tripleColumn - 1] = 2;
                    }

                    if (tripleColumn <= 6)
                    {
                        if (matrix[tripleRow, tripleColumn + 3] == 0)
                            matrix[tripleRow, tripleColumn + 3] = 2;
                    }

                    if (tripleRow >= 1)
                    {
                        if (matrix[tripleRow - 1, tripleColumn + i] == 0)
                            matrix[tripleRow - 1, tripleColumn + i] = 2;
                    }

                    if (tripleRow <= 8)
                    {
                        if (matrix[tripleRow + 1, tripleColumn + i] == 0)
                            matrix[tripleRow + 1, tripleColumn + i] = 2;
                    }

                    if (tripleRow >= 1 && tripleColumn >= 1)
                    {
                        if (matrix[tripleRow - 1, tripleColumn - 1] == 0)
                            matrix[tripleRow - 1, tripleColumn - 1] = 2;
                    }

                    if (tripleRow <= 8 && tripleColumn <= 6)
                    {
                        if (matrix[tripleRow + 1, tripleColumn + 3] == 0)
                            matrix[tripleRow + 1, tripleColumn + 3] = 2;
                    }

                    if (tripleRow <= 8 && tripleColumn >= 1)
                    {
                        if (matrix[tripleRow + 1, tripleColumn - 1] == 0)
                            matrix[tripleRow + 1, tripleColumn - 1] = 2;
                    }

                    if (tripleRow >= 1 && tripleColumn <= 6)
                    {
                        if (matrix[tripleRow - 1, tripleColumn + 3] == 0)
                            matrix[tripleRow - 1, tripleColumn + 3] = 2;
                    }
                }
            }
        }

        public static void doubleShipGenerate(int[,] matrix, int upDown, Random rand)
        {
            if (upDown == 0)
            {
                int doubleRow = rand.Next(0, 9);
                int doubleColumn = rand.Next(0, 10);

                while (!Functions.generateAble(matrix, upDown, 2, doubleRow, doubleColumn))
                {
                    doubleRow = rand.Next(0, 9);
                    doubleColumn = rand.Next(0, 10);
                }

                for (int i = 0; i < 2; i++)
                {
                    matrix[doubleRow + i, doubleColumn] = 1;

                    if (doubleRow >= 1)
                    {
                        matrix[doubleRow - 1, doubleColumn] = 2;
                    }

                    if (doubleRow <= 7)
                    {
                        matrix[doubleRow + 2, doubleColumn] = 2;
                    }

                    if (doubleColumn >= 1)
                    {
                        matrix[doubleRow + i, doubleColumn - 1] = 2;
                    }

                    if (doubleColumn <= 8)
                    {
                        matrix[doubleRow + i, doubleColumn + 1] = 2;
                    }

                    if (doubleRow >= 1 && doubleColumn >= 1)
                    {
                        matrix[doubleRow - 1, doubleColumn - 1] = 2;
                    }

                    if (doubleRow <= 7 && doubleColumn <= 8)
                    {
                        matrix[doubleRow + 2, doubleColumn + 1] = 2;
                    }

                    if (doubleRow >= 1 && doubleColumn <= 8)
                    {
                        matrix[doubleRow - 1, doubleColumn + 1] = 2;
                    }

                    if (doubleRow <= 7 && doubleColumn >= 1)
                    {
                        matrix[doubleRow + 2, doubleColumn - 1] = 2;
                    }
                }
            }

            if (upDown == 1)
            {
                int doubleRow = rand.Next(0, 10);
                int doubleColumn = rand.Next(0, 9);

                while (!Functions.generateAble(matrix, upDown, 2, doubleRow, doubleColumn))
                {
                    doubleRow = rand.Next(0, 10);
                    doubleColumn = rand.Next(0, 9);
                }

                for (int i = 0; i < 2; i++)
                {
                    matrix[doubleRow, doubleColumn + i] = 1;

                    if (doubleColumn >= 1)
                    {
                        matrix[doubleRow, doubleColumn - 1] = 2;
                    }

                    if (doubleColumn <= 7)
                    {
                        matrix[doubleRow, doubleColumn + 2] = 2;
                    }

                    if (doubleRow >= 1)
                    {
                        matrix[doubleRow - 1, doubleColumn + i] = 2;
                    }

                    if (doubleRow <= 8)
                    {
                        matrix[doubleRow + 1, doubleColumn + i] = 2;
                    }

                    if (doubleRow >= 1 && doubleColumn >= 1)
                    {
                        matrix[doubleRow - 1, doubleColumn - 1] = 2;
                    }

                    if (doubleRow <= 8 && doubleColumn <= 7)
                    {
                        matrix[doubleRow + 1, doubleColumn + 2] = 2;
                    }

                    if (doubleRow <= 8 && doubleColumn >= 1)
                    {
                        matrix[doubleRow + 1, doubleColumn - 1] = 2;
                    }

                    if (doubleRow >= 1 && doubleColumn <= 7)
                    {
                        matrix[doubleRow - 1, doubleColumn + 2] = 2;
                    }
                }
            }
        }

        public static void singleShipGenerate(int[,] matrix, int upDown, Random rand)
        {
            for (int k = 0; k < 4; k++)
            {
                int singleRow = rand.Next(0, 10);
                int singleColumn = rand.Next(0, 10);

                while (!Functions.generateAble(matrix, upDown, 1, singleRow, singleColumn))
                {
                    singleRow = rand.Next(0, 10);
                    singleColumn = rand.Next(0, 10);
                }

                matrix[singleRow, singleColumn] = 1;

                if (singleRow >= 1)
                {
                    matrix[singleRow - 1, singleColumn] = 2;
                }

                if (singleRow <= 8)
                {
                    matrix[singleRow + 1, singleColumn] = 2;
                }

                if (singleColumn >= 1)
                {
                    matrix[singleRow, singleColumn - 1] = 2;
                }

                if (singleColumn <= 8)
                {
                    matrix[singleRow, singleColumn + 1] = 2;
                }

                if (singleRow >= 1 && singleColumn >= 1)
                {
                    matrix[singleRow - 1, singleColumn - 1] = 2;
                }

                if (singleRow <= 8 && singleColumn <= 8)
                {
                    matrix[singleRow + 1, singleColumn + 1] = 2;
                }

                if (singleRow >= 1 && singleColumn <= 8)
                {
                    matrix[singleRow - 1, singleColumn + 1] = 2;
                }

                if (singleRow <= 8 && singleColumn >= 1)
                {
                    matrix[singleRow + 1, singleColumn - 1] = 2;
                }
            }
        }

        public static void selectionSynchronize(int[,] matrix, DataGridView dataGrid)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        dataGrid.Rows[i + 1].Cells[j + 1].Selected = true;
                    }
                }
            }
        }

        public static bool generateAble(int[,] matrix, int upDown, int shipSize, int startRow, int startColumn)
        {
            bool able = true;

            if (upDown == 0)
            {
                for (int i = 0; i < shipSize; i++)
                {
                    if (matrix[i + startRow, startColumn] == 1)
                    {
                        able = false;
                    }

                    if (startRow != 0)
                    {
                        if (matrix[startRow - 1, startColumn] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startRow != 10 - shipSize)
                    {
                        if (matrix[startRow + shipSize, startColumn] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 0)
                    {
                        if (matrix[i + startRow, startColumn - 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 9)
                    {
                        if (matrix[i + startRow, startColumn + 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 0 && startRow != 0)
                    {
                        if (matrix[startRow - 1, startColumn - 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 9 && startRow != 0)
                    {
                        if (matrix[startRow - 1, startColumn + 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 9 && startRow != 10 - shipSize)
                    {
                        if (matrix[startRow + shipSize, startColumn + 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 0 && startRow != 10 - shipSize)
                    {
                        if (matrix[startRow + shipSize, startColumn - 1] == 1)
                        {
                            able = false;
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < shipSize; i++)
                {
                    if (matrix[startRow, i + startColumn] == 1)
                    {
                        able = false;
                    }

                    if (startColumn != 0)
                    {
                        if (matrix[startRow, startColumn - 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 10 - shipSize)
                    {
                        if (matrix[startRow, startColumn + shipSize] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startRow != 0)
                    {
                        if (matrix[startRow - 1, startColumn + i] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startRow != 9)
                    {
                        if (matrix[startRow + 1, startColumn + i] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 0 && startRow != 0)
                    {
                        if (matrix[startRow - 1, startColumn - 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 0 && startRow != 9)
                    {
                        if (matrix[startRow + 1, startColumn - 1] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 10 - shipSize && startRow != 9)
                    {
                        if (matrix[startRow + 1, startColumn + shipSize] == 1)
                        {
                            able = false;
                        }
                    }

                    if (startColumn != 10 - shipSize && startRow != 0)
                    {
                        if (matrix[startRow - 1, startColumn + shipSize] == 1)
                        {
                            able = false;
                        }
                    }
                }
            }

            return able;
        }

        // computer ships generation & matrix output in textbox2
        public static void computerShipsGeneration(int[,] matrix, DataGridView computerGrid)
        {
            computerGrid.ClearSelection();
            matrixZerosFill(matrix);

            Random rand = new Random();

            int upDown = rand.Next(0, 2);
            quarternaryShipGenerate(matrix, upDown, rand);

            for (int k = 0; k < 2; k++)
            {
                upDown = rand.Next(0, 2);
                tripleShipGenerate(matrix, upDown, rand);
            }

            for (int k = 0; k < 3; k++)
            {
                upDown = rand.Next(0, 2);
                doubleShipGenerate(matrix, upDown, rand);
            }

            singleShipGenerate(matrix, upDown, rand);
            selectionSynchronize(matrix, computerGrid);

        }


        public static void computerShipsDestroying(int[,] matrix, DataGridView dataGrid)
        {
            extraCellsIgnore(dataGrid);
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i == dataGrid.CurrentCell.RowIndex  && j == dataGrid.CurrentCell.ColumnIndex)
                    {
                        if (matrix[i - 1, j - 1] == 1)
                        {
                            dataGrid.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            dataGrid.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                        }
                    }
                }
            }
        }


    }
}