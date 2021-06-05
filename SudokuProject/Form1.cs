using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuProject;

namespace SudokuProject
{
    public partial class Sudoku : Form
    {
        //level game
        private int level = 1;
        //arrray store values of textbox
        private int[,] Number = new int[10, 10];
        private Boolean[,] status = new Boolean[10, 10];
        SudokuOject data;
        public Sudoku()
        {
            InitializeComponent();
            data = new SudokuOject();
            data.Read();
            Number = data.getNumber();
            status = data.getStatus();
            connectTextBox(1);
            connectTextBox();
        }
        //kiem tra ma tran
        private Boolean check()
        {
            int[] temp = new int[9];
            //chech 3x3
            int i, j, IndexOfTemp=0;
            //check 0 - 9
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if(Number[i, j] > 9)
                    {
                        return false;
                        i = 9;
                        j = 9;
                    }
                }
            }
            //end check
            int x, y;
            for (x = 0; x < 3; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    for (i = ((x * 3) + 1); i <= ((x * 3) + 3); i++)
                    {
                        for (j = ((y * 3) + 1); j <= ((y * 3) + 3); j++)
                        {
                            if (Number[i, j] != 0)
                            {
                                temp[IndexOfTemp] = Number[i, j];
                                IndexOfTemp++;
                            }
                        }
                    }
                    IndexOfTemp--;

                    for (i = 0; i <= IndexOfTemp; i++)
                    {
                        for (j = 0; j <= IndexOfTemp; j++)
                        {
                            if (i == j)
                            {
                                continue;
                            }
                            if (temp[i] == temp[j])
                            {
                                return false;
                            }
                        }
                    }
                    IndexOfTemp = 0;
                }
            }
            //check row
            for (x = 1; x <= 9; x++)
            {
                for (y = 1; y <= 9; y++)
                {
                    if(Number[x, y] != 0)
                    {
                        temp[IndexOfTemp] = Number[x, y];
                        IndexOfTemp++;
                    }
                }
                IndexOfTemp--;
                for (i = 0; i <= IndexOfTemp; i++)
                {
                    for (j = 0; j <= IndexOfTemp; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (temp[i] == temp[j])
                        {
                            return false;
                        }
                    }
                }
                IndexOfTemp = 0;
            }
            //check cell
            for (y = 1; y <= 9; y++)
            {
                for (x = 1; x <= 9; x++)
                {
                    if (Number[x, y] != 0)
                    {
                        temp[IndexOfTemp] = Number[x, y];
                        IndexOfTemp++;
                    }
                }
                IndexOfTemp--;
                for (i = 0; i <= IndexOfTemp; i++)
                {
                    for (j = 0; j <= IndexOfTemp; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (temp[i] == temp[j])
                        {
                            return false;
                        }
                    }
                }
                IndexOfTemp = 0;
            }
            return true;
        }
        //textbox -> array
        private void connectTextBox()
        {
            //row1
            try {
                if(Number[1, 1] !=0 )
                    t11.Text = Number[1, 1].ToString();
            }
            catch(Exception e) { }
            try
            {
                if (Number[1, 2] != 0)
                    t12.Text = Number[1, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 3] != 0)
                    t13.Text = Number[1, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 4] != 0)
                    t14.Text = Number[1, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 5] != 0)
                    t15.Text = Number[1, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 6] != 0)
                    t16.Text = Number[1, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 7] != 0)
                    t17.Text = Number[1, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 8] != 0)
                    t18.Text = Number[1, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 9] != 0)
                    t19.Text = Number[1, 9].ToString();
            }
            catch (Exception e) { }
            //row2
            try
            {
                if (Number[2, 1] != 0)
                    t21.Text = Number[2, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 2] != 0)
                    t22.Text = Number[2, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 3] != 0)
                    t23.Text = Number[2, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 4] != 0)
                    t24.Text = Number[2, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 5] != 0)
                    t25.Text = Number[2, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 6] != 0)
                    t26.Text = Number[2, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 7] != 0)
                    t27.Text = Number[2, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 8] != 0)
                    t28.Text = Number[2, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 9] != 0)
                    t29.Text = Number[2, 9].ToString();
            }
            catch (Exception e) { }
            //row3
            try
            {
                if (Number[3, 1] != 0)
                    t31.Text = Number[3, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 2] != 0)
                    t32.Text = Number[3, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 3] != 0)
                    t33.Text = Number[3, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 4] != 0)
                    t34.Text = Number[3, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 5] != 0)
                    t35.Text = Number[3, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 6] != 0)
                    t36.Text = Number[3, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 7] != 0)
                    t37.Text = Number[3, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 8] != 0)
                    t38.Text = Number[3, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 9] != 0)
                    t39.Text = Number[3, 9].ToString();
            }
            catch (Exception e) { }
            //row4
            try
            {
                if (Number[4, 1] != 0)
                    t41.Text = Number[4, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 2] != 0)
                    t42.Text = Number[4, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 3] != 0)
                    t43.Text = Number[4, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 4] != 0)
                    t44.Text = Number[4, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 5] != 0)
                    t45.Text = Number[4, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 6] != 0)
                    t46.Text = Number[4, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 7] != 0)
                    t47.Text = Number[4, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 8] != 0)
                    t48.Text = Number[4, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 9] != 0)
                    t49.Text = Number[4, 9].ToString();
            }
            catch (Exception e) { }
            //row5
            try
            {
                if (Number[5, 1] != 0)
                    t51.Text = Number[5, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 2] != 0)
                    t52.Text = Number[5, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 3] != 0)
                    t53.Text = Number[5, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 4] != 0)
                    t54.Text = Number[5, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 5] != 0)
                    t55.Text = Number[5, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 6] != 0)
                    t56.Text = Number[5, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 7] != 0)
                    t57.Text = Number[5, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 8] != 0)
                    t58.Text = Number[5, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 9] != 0)
                    t59.Text = Number[5, 9].ToString();
            }
            catch (Exception e) { }
            //row6
            try
            {
                if (Number[6, 1] != 0)
                    t61.Text = Number[6, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 2] != 0)
                    t62.Text = Number[6, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 3] != 0)
                    t63.Text = Number[6, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 4] != 0)
                    t64.Text = Number[6, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 5] != 0)
                    t65.Text = Number[6, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 6] != 0)
                    t66.Text = Number[6, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 7] != 0)
                    t67.Text = Number[6, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 8] != 0)
                    t68.Text = Number[6, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 9] != 0)
                    t69.Text = Number[6, 9].ToString();
            }
            catch (Exception e) { }
            //row7
            try
            {
                if (Number[7, 1] != 0)
                    t71.Text = Number[7, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 2] != 0)
                    t72.Text = Number[7, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 3] != 0)
                    t73.Text = Number[7, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 4] != 0)
                    t74.Text = Number[7, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 5] != 0)
                    t75.Text = Number[7, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 6] != 0)
                    t76.Text = Number[7, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 7] != 0)
                    t77.Text = Number[7, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 8] != 0)
                    t78.Text = Number[7, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 9] != 0)
                    t79.Text = Number[7, 9].ToString();
            }
            catch (Exception e) { }
            //row8
            try
            {
                if (Number[8, 1] != 0)
                    t81.Text = Number[8, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 2] != 0)
                    t82.Text = Number[8, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 3] != 0)
                    t83.Text = Number[8, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 4] != 0)
                    t84.Text = Number[8, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 5] != 0)
                    t85.Text = Number[8, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 6] != 0)
                    t86.Text = Number[8, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 7] != 0)
                    t87.Text = Number[8, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 8] != 0)
                    t88.Text = Number[8, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 9] != 0)
                    t89.Text = Number[8, 9].ToString();
            }
            catch (Exception e) { }
            //row9
            try
            {
                if (Number[9, 1] != 0)
                    t91.Text = Number[9, 1].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 2] != 0)
                    t92.Text = Number[9, 2].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 3] != 0)
                    t93.Text = Number[9, 3].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 4] != 0)
                    t94.Text = Number[9, 4].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 5] != 0)
                    t95.Text = Number[9, 5].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 6] != 0)
                    t96.Text = Number[9, 6].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 7] != 0)
                    t97.Text = Number[9, 7].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 8] != 0)
                    t98.Text = Number[9, 8].ToString();
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 9] != 0)
                    t99.Text = Number[9, 9].ToString();
            }
            catch (Exception e) { }
        }

        private void connectTextBox(int color)
        {
            //row1
            try
            {
                if (Number[1, 1] != 0 && status[1, 1])
                {
                    t11.Text = Number[1, 1].ToString();
                    t11.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t11.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 2] != 0 && status[1, 2])
                { 
                    t12.Text = Number[1, 2].ToString();
                    t12.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t12.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 3] != 0 && status[1, 3]) {
                    t13.Text = Number[1, 3].ToString();
                    t13.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t13.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 4] != 0 && status[1, 4]) { 
                    t14.Text = Number[1, 4].ToString();
                    t14.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t14.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 5] != 0 && status[1, 5])
                {
                    t15.Text = Number[1, 5].ToString();
                    t15.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t15.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 6] != 0 && status[1, 6])
                {
                    t16.Text = Number[1, 6].ToString();
                    t16.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t16.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 7] != 0 && status[1, 7])
                {
                    t17.Text = Number[1, 7].ToString();
                    t17.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t17.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 8] != 0 && status[1, 8])
                {
                    t18.Text = Number[1, 8].ToString();
                    t18.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t18.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[1, 9] != 0 && status[1, 9])
                {
                    t19.Text = Number[1, 9].ToString();
                    t19.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t19.Enabled = false;
                }
            }
            catch (Exception e) { }
            //row2
            try
            {
                if (Number[2, 1] != 0 && status[2, 1])
                {
                    t21.Text = Number[2, 1].ToString();
                    t21.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t21.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 2] != 0 && status[2, 2])
                {
                    t22.Text = Number[2, 2].ToString();
                    t22.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t22.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 3] != 0 && status[2, 3])
                {
                    t23.Text = Number[2, 3].ToString();
                    t23.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t23.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 4] != 0 && status[2, 4])
                {
                    t24.Text = Number[2, 4].ToString();
                    t24.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t24.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 5] != 0 && status[2, 5])
                {
                    t25.Text = Number[2, 5].ToString();
                    t25.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t25.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 6] != 0 && status[2, 6])
                {
                    t26.Text = Number[2, 6].ToString();
                    t26.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t26.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 7] != 0 && status[2, 7])
                {
                    t27.Text = Number[2, 7].ToString();
                    t27.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t27.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 8] != 0 && status[2, 8])
                {
                    t28.Text = Number[2, 8].ToString();
                    t28.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t28.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[2, 9] != 0 && status[2, 9])
                {
                    t29.Text = Number[2, 9].ToString();
                    t29.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t29.Enabled = false;
                }
            }catch(Exception e) { }
            //row3
            try
            {
                if (Number[3, 1] != 0 && status[3, 1])
                {
                    t31.Text = Number[3, 1].ToString();
                    t31.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t31.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 2] != 0 && status[3, 2])
                {
                    t32.Text = Number[3, 2].ToString();
                    t32.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t32.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 3] != 0 && status[3, 3])
                {
                    t33.Text = Number[3, 3].ToString();
                    t33.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t33.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 4] != 0 && status[3, 4])
                {
                    t34.Text = Number[3, 4].ToString();
                    t34.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t34.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 5] != 0 && status[3, 5])
                {
                    t35.Text = Number[3, 5].ToString();
                    t35.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t35.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 6] != 0 && status[3, 6])
                {
                    t36.Text = Number[3, 6].ToString();
                    t36.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t36.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 7] != 0 && status[3, 7])
                {
                    t37.Text = Number[3, 7].ToString();
                    t37.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t37.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 8] != 0 && status[3, 8])
                {
                    t38.Text = Number[3, 8].ToString();
                    t38.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t38.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[3, 9] != 0 && status[3, 9])
                {
                    t39.Text = Number[3, 9].ToString();
                    t39.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t39.Enabled = false;
                }
            }catch(Exception e) { }
            //row4
            try
            {
                if (Number[4, 1] != 0 && status[4, 1])
                {
                    t41.Text = Number[4, 1].ToString();
                    t41.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t41.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 2] != 0 && status[4, 2])
                {
                    t42.Text = Number[4, 2].ToString();
                    t42.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t42.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 3] != 0 && status[4, 3])
                {
                    t43.Text = Number[4, 3].ToString();
                    t43.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t43.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 4] != 0 && status[4, 4])
                {
                    t44.Text = Number[4, 4].ToString();
                    t44.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t44.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 5] != 0 && status[4, 5])
                {
                    t45.Text = Number[4, 5].ToString();
                    t45.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t45.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 6] != 0 && status[4, 6])
                {
                    t46.Text = Number[4, 6].ToString();
                    t46.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t46.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 7] != 0 && status[4, 7])
                {
                    t47.Text = Number[4, 7].ToString();
                    t47.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t47.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 8] != 0 && status[4, 8])
                {
                    t48.Text = Number[4, 8].ToString();
                    t48.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t48.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[4, 9] != 0 && status[4, 9])
                {
                    t49.Text = Number[4, 9].ToString();
                    t49.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t49.Enabled = false;
                }
            }
            catch (Exception e) { }
            //row5
            try
            {
                if (Number[5, 1] != 0 && status[5, 1])
                {
                    t51.Text = Number[5, 1].ToString();
                    t51.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t51.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 2] != 0 && status[5, 2])
                {
                    t52.Text = Number[5, 2].ToString();
                    t52.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t52.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 3] != 0 && status[5, 3])
                {
                    t53.Text = Number[5, 3].ToString();
                    t53.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t53.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 4] != 0 && status[5, 4])
                {
                    t54.Text = Number[5, 4].ToString();
                    t54.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t54.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 5] != 0 && status[5, 5])
                {
                    t55.Text = Number[5, 5].ToString();
                    t55.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t55.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 6] != 0 && status[5, 6])
                {
                    t56.Text = Number[5, 6].ToString();
                    t56.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t56.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 7] != 0 && status[5, 7])
                {
                    t57.Text = Number[5, 7].ToString();
                    t57.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t57.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 8] != 0 && status[5, 8])
                {
                    t58.Text = Number[5, 8].ToString();
                    t58.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t58.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[5, 9] != 0 && status[5, 9])
                {
                    t59.Text = Number[5, 9].ToString();
                    t59.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t59.Enabled = false;
                }
            }
            catch (Exception e) { }
            //row6
            try
            {
                if (Number[6, 1] != 0 && status[6, 1])
                {
                    t61.Text = Number[6, 1].ToString();
                    t61.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t61.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 2] != 0 && status[6, 2])
                {
                    t62.Text = Number[6, 2].ToString();
                    t62.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t62.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 3] != 0 && status[6, 3])
                {
                    t63.Text = Number[6, 3].ToString();
                    t63.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t63.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 4] != 0 && status[6, 4])
                {
                    t64.Text = Number[6, 4].ToString();
                    t64.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t64.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 5] != 0 && status[6, 5])
                {
                    t65.Text = Number[6, 5].ToString();
                    t65.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t65.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 6] != 0 && status[6, 6])
                {
                    t66.Text = Number[6, 6].ToString();
                    t66.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t66.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 7] != 0 && status[6, 7])
                {
                    t67.Text = Number[6, 7].ToString();
                    t67.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t67.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 8] != 0 && status[6, 8])
                {
                    t68.Text = Number[6, 8].ToString();
                    t68.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t68.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[6, 9] != 0 && status[6, 9])
                {
                    t69.Text = Number[6, 9].ToString();
                    t69.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t69.Enabled = false;
                }
            }
            catch (Exception e) { }
            //row7
            try
            {
                if (Number[7, 1] != 0 && status[7, 1])
                {
                    t71.Text = Number[7, 1].ToString();
                    t71.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t71.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 2] != 0 && status[7, 2])
                {
                    t72.Text = Number[7, 2].ToString();
                    t72.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t72.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 3] != 0 && status[7, 3])
                {
                    t73.Text = Number[7, 3].ToString();
                    t73.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t73.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 4] != 0 && status[7, 4])
                {
                    t74.Text = Number[7, 4].ToString();
                    t74.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t74.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 5] != 0 && status[7, 5])
                {
                    t75.Text = Number[7, 5].ToString();
                    t75.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t75.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 6] != 0 && status[7, 6])
                {
                    t76.Text = Number[7, 6].ToString();
                    t76.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t76.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 7] != 0 && status[7, 7])
                {
                    t77.Text = Number[7, 7].ToString();
                    t77.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t77.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 8] != 0 && status[7, 8])
                {
                    t78.Text = Number[7, 8].ToString();
                    t78.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t78.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[7, 9] != 0 && status[7, 9])
                {
                    t79.Text = Number[7, 9].ToString();
                    t79.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t79.Enabled = false;
                }
            }
            catch (Exception e) { }
            //row8
            try
            {
                if (Number[8, 1] != 0 && status[8, 1])
                {
                    t81.Text = Number[8, 1].ToString();
                    t81.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t81.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 2] != 0 && status[8, 2])
                {
                    t82.Text = Number[8, 2].ToString();
                    t82.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t82.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 3] != 0 && status[8, 3])
                {
                    t83.Text = Number[8, 3].ToString();
                    t83.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t83.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 4] != 0 && status[8, 4])
                {
                    t84.Text = Number[8, 4].ToString();
                    t84.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t84.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 5] != 0 && status[8, 5])
                {
                    t85.Text = Number[8, 5].ToString();
                    t85.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t85.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 6] != 0 && status[8, 6])
                {
                    t86.Text = Number[8, 6].ToString();
                    t86.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t86.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 7] != 0 && status[8, 7])
                {
                    t87.Text = Number[8, 7].ToString();
                    t87.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t87.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 8] != 0 && status[8, 8])
                {
                    t88.Text = Number[8, 8].ToString();
                    t88.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t88.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[8, 9] != 0 && status[8, 9])
                {
                    t89.Text = Number[8, 9].ToString();
                    t89.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t89.Enabled = false;
                }
            }
            catch (Exception e) { }
            //row9
            try
            {
                if (Number[9, 1] != 0 && status[9, 1])
                {
                    t91.Text = Number[9, 1].ToString();
                    t91.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t91.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 2] != 0 && status[9, 2])
                {
                    t92.Text = Number[9, 2].ToString();
                    t92.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t92.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 3] != 0 && status[9, 3])
                {
                    t93.Text = Number[9, 3].ToString();
                    t93.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t93.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 4] != 0 && status[9, 4])
                {
                    t94.Text = Number[9, 4].ToString();
                    t94.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t94.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 5] != 0 && status[9, 5])
                {
                    t95.Text = Number[9, 5].ToString();
                    t95.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t95.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 6] != 0 && status[9, 6])
                {
                    t96.Text = Number[9, 6].ToString();
                    t96.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t96.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 7] != 0 && status[9, 7])
                {
                    t97.Text = Number[9, 7].ToString();
                    t97.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t97.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 8] != 0 && status[9, 8])
                {
                    t98.Text = Number[9, 8].ToString();
                    t98.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t98.Enabled = false;
                }
            }
            catch (Exception e) { }
            try
            {
                if (Number[9, 9] != 0 && status[9, 9])
                {
                    t99.Text = Number[9, 9].ToString();
                    t99.BackColor = System.Drawing.Color.DarkSeaGreen;
                    t99.Enabled = false;
                }
            }
            catch (Exception e) { }
        }
        //array -> textbox
        private void connectArray()
        {
            try
            {
                Number[1, 1] = int.Parse(t11.Text);
            }catch(Exception e){
                Number[1, 1] = 0;
            }
            try { 
                Number[1, 2] = int.Parse(t12.Text);
            }catch(Exception e) {
                Number[1, 2] = 0;
            }
            try
            {
                Number[1, 3] = int.Parse(t13.Text);
            }
            catch (Exception e) {
                Number[1, 3] = 0;
            }
            try
            {
                Number[1, 4] = int.Parse(t14.Text);
            }
            catch (Exception e) {
                Number[1, 4] = 0;
            }
            try
            {
                Number[1, 5] = int.Parse(t15.Text);
            }
            catch (Exception e) {
                Number[1, 5] = 0;
            }
            try
            {
                Number[1, 6] = int.Parse(t16.Text);
            }
            catch (Exception e) {
                Number[1, 6] = 0;
            }
            try
            {
                Number[1, 7] = int.Parse(t17.Text);
            }
            catch (Exception e) {
                Number[1, 7] = 0;
            }
            try
            {
                Number[1, 8] = int.Parse(t18.Text);
            }
            catch (Exception e) {
                Number[1, 8] = 0;
            }
            try
            {
                Number[1, 9] = int.Parse(t19.Text);
            }
            catch (Exception e) {
                Number[1, 9] = 0;
            }
            //row2
            try
            {
                Number[2, 1] = int.Parse(t21.Text);
            }
            catch (Exception e) {
                Number[2, 1] = 0;
            }
            try
            {
                Number[2, 2] = int.Parse(t22.Text);
            }
            catch (Exception e) {
                Number[2, 2] = 0;
            }
            try
            {
                Number[2, 3] = int.Parse(t23.Text);
            }
            catch (Exception e) {
                Number[2, 3] = 0;
            }
            try
            {
                Number[2, 4] = int.Parse(t24.Text);
            }
            catch (Exception e) {
                Number[2, 4] = 0;
            }
            try
            {
                Number[2, 5] = int.Parse(t25.Text);
            }
            catch (Exception e) {
                Number[2, 5] = 0;
            }
            try
            {
                Number[2, 6] = int.Parse(t26.Text);
            }
            catch (Exception e) {
                Number[2, 6] = 0;
            }
            try
            {
                Number[2, 7] = int.Parse(t27.Text);
            }
            catch (Exception e) {
                Number[2, 7] = 0;
            }
            try
            {
                Number[2, 8] = int.Parse(t28.Text);
            }
            catch (Exception e) {
                Number[2, 8] = 0;
            }
            try
            {
                Number[2, 9] = int.Parse(t29.Text);
            }
            catch (Exception e) {
                Number[2, 9] = 0;
            }
            //row3
            try
            {
                Number[3, 1] = int.Parse(t31.Text);
            }
            catch (Exception e) {
                Number[3, 1] = 0;
            }
            try
            {
                Number[3, 2] = int.Parse(t32.Text);
            }
            catch (Exception e) {
                Number[3, 2] = 0;
            }
            try
            {
                Number[3, 3] = int.Parse(t33.Text);
            }
            catch (Exception e) {
                Number[3, 3] = 0;
            }
            try
            {
                Number[3, 4] = int.Parse(t34.Text);
            }
            catch (Exception e) {
                Number[3, 4] = 0;
            }
            try
            {
                Number[3, 5] = int.Parse(t35.Text);
            }
            catch (Exception e) {
                Number[3, 5] = 0;
            }
            try
            {
                Number[3, 6] = int.Parse(t36.Text);
            }
            catch (Exception e) {
                Number[3, 6] = 0;
            }
            try
            {
                Number[3, 7] = int.Parse(t37.Text);
            }
            catch (Exception e) {
                Number[3, 7] = 0;
            }
            try
            {
                Number[3, 8] = int.Parse(t38.Text);
            }
            catch (Exception e) {
                Number[3, 8] = 0;
            }
            try
            {
                Number[3, 9] = int.Parse(t39.Text);
            }
            catch (Exception e) {
                Number[3, 9] = 0;
            }
            //row4
            try
            {
                Number[4, 1] = int.Parse(t41.Text);
            }
            catch (Exception e) {
                Number[4, 1] = 0;
            }
            try
            {
                Number[4, 2] = int.Parse(t42.Text);
            }
            catch (Exception e) {
                Number[4, 2] = 0;
            }
            try
            {
                Number[4, 3] = int.Parse(t43.Text);
            }
            catch (Exception e) {
                Number[4, 3] = 0;
            }
            try
            {
                Number[4, 4] = int.Parse(t44.Text);
            }
            catch (Exception e) {
                Number[4, 4] = 0;
            }
            try
            {
                Number[4, 5] = int.Parse(t45.Text);
            }
            catch (Exception e) {
                Number[4, 5] = 0;
            }
            try
            {
                Number[4, 6] = int.Parse(t46.Text);
            }
            catch (Exception e) {
                Number[4, 6] = 0;
            }
            try
            {
                Number[4, 7] = int.Parse(t47.Text);
            }
            catch (Exception e) {
                Number[4, 7] = 0;
            }
            try
            {
                Number[4, 8] = int.Parse(t48.Text);
            }
            catch (Exception e) {
                Number[4, 8] = 0;
            }
            try
            {
                Number[4, 9] = int.Parse(t49.Text);
            }
            catch (Exception e) {
                Number[4, 9] = 0;
            }
            //row5
            try
            {
                Number[5, 1] = int.Parse(t51.Text);
            }
            catch (Exception e) {
                Number[5, 1] = 0;
            }
            try
            {
                Number[5, 2] = int.Parse(t52.Text);
            }
            catch (Exception e) {
                Number[5, 2] = 0;
            }
            try
            {
                Number[5, 3] = int.Parse(t53.Text);
            }
            catch (Exception e) {
                Number[5, 3] = 0;
            }
            try
            {
                Number[5, 4] = int.Parse(t54.Text);
            }
            catch (Exception e) {
                Number[5, 4] = 0;
            }
            try
            {
                Number[5, 5] = int.Parse(t55.Text);
            }
            catch (Exception e) {
                Number[5, 5] = 0;
            }
            try
            {
                Number[5, 6] = int.Parse(t56.Text);
            }
            catch (Exception e) {
                Number[5, 6] = 0;
            }
            try
            {
                Number[5, 7] = int.Parse(t57.Text);
            }
            catch (Exception e) {
                Number[5, 7] = 0;
            }
            try
            {
                Number[5, 8] = int.Parse(t58.Text);
            }
            catch (Exception e) {
                Number[5, 8] = 0;
            }
            try
            {
                Number[5, 9] = int.Parse(t59.Text);
            }
            catch (Exception e) {
                Number[5, 9] = 0;
            }
            //row6
            try
            {
                Number[6, 1] = int.Parse(t61.Text);
            }
            catch (Exception e) {
                Number[6, 1] = 0;
            }
            try
            {
                Number[6, 2] = int.Parse(t62.Text);
            }
            catch (Exception e) {
                Number[6, 2] = 0;
            }
            try
            {
                Number[6, 3] = int.Parse(t63.Text);
            }
            catch (Exception e) {
                Number[6, 3] = 0;
            }
            try
            {
                Number[6, 4] = int.Parse(t64.Text);
            }
            catch (Exception e) {
                Number[6, 4] = 0;
            }
            try
            {
                Number[6, 5] = int.Parse(t65.Text);
            }
            catch (Exception e) {
                Number[6, 5] = 0;
            }
            try
            {
                Number[6, 6] = int.Parse(t66.Text);
            }
            catch (Exception e) {
                Number[6, 6] = 0;
            }
            try
            {
                Number[6, 7] = int.Parse(t67.Text);
            }
            catch (Exception e) {
                Number[6, 7] = 0;
            }
            try
            {
                Number[6, 8] = int.Parse(t68.Text);
            }
            catch (Exception e) {
                Number[6, 8] = 0;
            }
            try
            {
                Number[6, 9] = int.Parse(t69.Text);
            }
            catch (Exception e) {
                Number[6, 9] = 0;
            }
            //row7
            try
            {
                Number[7, 1] = int.Parse(t71.Text);
            }
            catch (Exception e) {
                Number[7, 1] = 0;
            }
            try
            {
                Number[7, 2] = int.Parse(t72.Text);
            }
            catch (Exception e) {
                Number[7, 2] = 0;
            }
            try
            {
                Number[7, 3] = int.Parse(t73.Text);
            }
            catch (Exception e) {
                Number[7, 3] = 0;
            }
            try
            {
                Number[7, 4] = int.Parse(t74.Text);
            }
            catch (Exception e) {
                Number[7, 4] = 0;
            }
            try
            {
                Number[7, 5] = int.Parse(t75.Text);
            }
            catch (Exception e) {
                Number[7, 5] = 0;
            }
            try
            {
                Number[7, 6] = int.Parse(t76.Text);
            }
            catch (Exception e) {
                Number[7, 6] = 0;
            }
            try
            {
                Number[7, 7] = int.Parse(t77.Text);
            }
            catch (Exception e) {
                Number[7, 7] = 0;
            }
            try
            {
                Number[7, 8] = int.Parse(t78.Text);
            }
            catch (Exception e) {
                Number[7, 8] = 0;
            }
            try
            {
                Number[7, 9] = int.Parse(t79.Text);
            }
            catch (Exception e) {
                Number[7, 9] = 0;
            }
            //row8
            try
            {
                Number[8, 1] = int.Parse(t81.Text);
            }
            catch (Exception e) {
                Number[8, 1] = 0;
            }
            try
            {
                Number[8, 2] = int.Parse(t82.Text);
            }
            catch (Exception e) {
                Number[8, 2] = 0;
            }
            try
            {
                Number[8, 3] = int.Parse(t83.Text);
            }
            catch (Exception e) {
                Number[8, 3] = 0;
            }
            try
            {
                Number[8, 4] = int.Parse(t84.Text);
            }
            catch (Exception e) {
                Number[8, 4] = 0;
            }
            try
            {
                Number[8, 5] = int.Parse(t85.Text);
            }
            catch (Exception e) {
                Number[8, 5] = 0;
            }
            try
            {
                Number[8, 6] = int.Parse(t86.Text);
            }
            catch (Exception e) {
                Number[8, 6] = 0;
            }
            try
            {
                Number[8, 7] = int.Parse(t87.Text);
            }
            catch (Exception e) {
                Number[8, 7] = 0;
            }
            try
            {
                Number[8, 8] = int.Parse(t88.Text);
            }
            catch (Exception e) {
                Number[8, 8] = 0;
            }
            try
            {
                Number[8, 9] = int.Parse(t89.Text);
            }
            catch (Exception e) {
                Number[8, 9] = 0;
            }
            //row9
            try
            {
                Number[9, 1] = int.Parse(t91.Text);
            }
            catch (Exception e) {
                Number[9, 1] = 0;
            }
            try
            {
                Number[9, 2] = int.Parse(t92.Text);
            }
            catch (Exception e) {
                Number[9, 2] = 0;
            }
            try
            {
                Number[9, 3] = int.Parse(t93.Text);
            }
            catch (Exception e) {
                Number[9, 3] = 0;
            }
            try
            {
                Number[9, 4] = int.Parse(t94.Text);
            }
            catch (Exception e) {
                Number[9, 4] = 0;
            }
            try
            {
                Number[9, 5] = int.Parse(t95.Text);
            }
            catch (Exception e) {
                Number[9, 5] = 0;
            }
            try
            {
                Number[9, 6] = int.Parse(t96.Text);
            }
            catch (Exception e) {
                Number[9, 6] = 0;
            }
            try
            {
                Number[9, 7] = int.Parse(t97.Text);
            }
            catch (Exception e) {
                Number[9, 7] = 0;
            }
            try
            {
                Number[9, 8] = int.Parse(t98.Text);
            }
            catch (Exception e) {
                Number[9, 8] = 0;
            }
            try
            {
                Number[9, 9] = int.Parse(t99.Text);
            }
            catch (Exception e) {
                Number[9, 9] = 0;
            }
            
        }
        //clear data
        private void clear()
        {
            int i = 1, j;
            //clear array
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    Number[i, j] = 0;
                }
            }
            //clear textbox
            t11.Text = "";
            t12.Text = "";
            t13.Text = "";
            t14.Text = "";
            t15.Text = "";
            t16.Text = "";
            t17.Text = "";
            t18.Text = "";
            t19.Text = "";
            t21.Text = "";
            t22.Text = "";
            t23.Text = "";
            t24.Text = "";
            t25.Text = "";
            t26.Text = "";
            t27.Text = "";
            t28.Text = "";
            t29.Text = "";
            t31.Text = "";
            t32.Text = "";
            t33.Text = "";
            t34.Text = "";
            t35.Text = "";
            t36.Text = "";
            t37.Text = "";
            t38.Text = "";
            t39.Text = "";
            t41.Text = "";
            t42.Text = "";
            t43.Text = "";
            t44.Text = "";
            t45.Text = "";
            t46.Text = "";
            t47.Text = "";
            t48.Text = "";
            t49.Text = "";
            t51.Text = "";
            t52.Text = "";
            t53.Text = "";
            t54.Text = "";
            t55.Text = "";
            t56.Text = "";
            t57.Text = "";
            t58.Text = "";
            t59.Text = "";
            t61.Text = "";
            t62.Text = "";
            t63.Text = "";
            t64.Text = "";
            t65.Text = "";
            t66.Text = "";
            t67.Text = "";
            t68.Text = "";
            t69.Text = "";
            t71.Text = "";
            t72.Text = "";
            t73.Text = "";
            t74.Text = "";
            t75.Text = "";
            t76.Text = "";
            t77.Text = "";
            t78.Text = "";
            t79.Text = "";
            t81.Text = "";
            t82.Text = "";
            t83.Text = "";
            t84.Text = "";
            t85.Text = "";
            t86.Text = "";
            t87.Text = "";
            t88.Text = "";
            t89.Text = "";
            t91.Text = "";
            t92.Text = "";
            t93.Text = "";
            t94.Text = "";
            t95.Text = "";
            t96.Text = "";
            t97.Text = "";
            t98.Text = "";
            t99.Text = "";

            t11.BackColor = System.Drawing.Color.White;
            t12.BackColor = System.Drawing.Color.White;
            t13.BackColor = System.Drawing.Color.White;
            t14.BackColor = System.Drawing.Color.White;
            t15.BackColor = System.Drawing.Color.White;
            t16.BackColor = System.Drawing.Color.White;
            t17.BackColor = System.Drawing.Color.White;
            t18.BackColor = System.Drawing.Color.White;
            t19.BackColor = System.Drawing.Color.White;

            t21.BackColor = System.Drawing.Color.White;
            t22.BackColor = System.Drawing.Color.White;
            t23.BackColor = System.Drawing.Color.White;
            t24.BackColor = System.Drawing.Color.White;
            t25.BackColor = System.Drawing.Color.White;
            t26.BackColor = System.Drawing.Color.White;
            t27.BackColor = System.Drawing.Color.White;
            t28.BackColor = System.Drawing.Color.White;
            t29.BackColor = System.Drawing.Color.White;

            t31.BackColor = System.Drawing.Color.White;
            t32.BackColor = System.Drawing.Color.White;
            t33.BackColor = System.Drawing.Color.White;
            t34.BackColor = System.Drawing.Color.White;
            t35.BackColor = System.Drawing.Color.White;
            t36.BackColor = System.Drawing.Color.White;
            t37.BackColor = System.Drawing.Color.White;
            t38.BackColor = System.Drawing.Color.White;
            t39.BackColor = System.Drawing.Color.White;

            t41.BackColor = System.Drawing.Color.White;
            t42.BackColor = System.Drawing.Color.White;
            t43.BackColor = System.Drawing.Color.White;
            t44.BackColor = System.Drawing.Color.White;
            t45.BackColor = System.Drawing.Color.White;
            t46.BackColor = System.Drawing.Color.White;
            t47.BackColor = System.Drawing.Color.White;
            t48.BackColor = System.Drawing.Color.White;
            t49.BackColor = System.Drawing.Color.White;

            t51.BackColor = System.Drawing.Color.White;
            t52.BackColor = System.Drawing.Color.White;
            t53.BackColor = System.Drawing.Color.White;
            t54.BackColor = System.Drawing.Color.White;
            t55.BackColor = System.Drawing.Color.White;
            t56.BackColor = System.Drawing.Color.White;
            t57.BackColor = System.Drawing.Color.White;
            t58.BackColor = System.Drawing.Color.White;
            t59.BackColor = System.Drawing.Color.White;

            t61.BackColor = System.Drawing.Color.White;
            t62.BackColor = System.Drawing.Color.White;
            t63.BackColor = System.Drawing.Color.White;
            t64.BackColor = System.Drawing.Color.White;
            t65.BackColor = System.Drawing.Color.White;
            t66.BackColor = System.Drawing.Color.White;
            t67.BackColor = System.Drawing.Color.White;
            t68.BackColor = System.Drawing.Color.White;
            t69.BackColor = System.Drawing.Color.White;

            t71.BackColor = System.Drawing.Color.White;
            t72.BackColor = System.Drawing.Color.White;
            t73.BackColor = System.Drawing.Color.White;
            t74.BackColor = System.Drawing.Color.White;
            t75.BackColor = System.Drawing.Color.White;
            t76.BackColor = System.Drawing.Color.White;
            t77.BackColor = System.Drawing.Color.White;
            t78.BackColor = System.Drawing.Color.White;
            t79.BackColor = System.Drawing.Color.White;

            t81.BackColor = System.Drawing.Color.White;
            t82.BackColor = System.Drawing.Color.White;
            t83.BackColor = System.Drawing.Color.White;
            t84.BackColor = System.Drawing.Color.White;
            t85.BackColor = System.Drawing.Color.White;
            t86.BackColor = System.Drawing.Color.White;
            t87.BackColor = System.Drawing.Color.White;
            t88.BackColor = System.Drawing.Color.White;
            t89.BackColor = System.Drawing.Color.White;

            t91.BackColor = System.Drawing.Color.White;
            t92.BackColor = System.Drawing.Color.White;
            t93.BackColor = System.Drawing.Color.White;
            t94.BackColor = System.Drawing.Color.White;
            t95.BackColor = System.Drawing.Color.White;
            t96.BackColor = System.Drawing.Color.White;
            t97.BackColor = System.Drawing.Color.White;
            t98.BackColor = System.Drawing.Color.White;
            t99.BackColor = System.Drawing.Color.White;

            t11.Enabled = true;
            t12.Enabled = true;
            t13.Enabled = true;
            t14.Enabled = true;
            t15.Enabled = true;
            t16.Enabled = true;
            t17.Enabled = true;
            t18.Enabled = true;
            t19.Enabled = true;

            t21.Enabled = true;
            t22.Enabled = true;
            t23.Enabled = true;
            t24.Enabled = true;
            t25.Enabled = true;
            t26.Enabled = true;
            t27.Enabled = true;
            t28.Enabled = true;
            t29.Enabled = true;

            t31.Enabled = true;
            t32.Enabled = true;
            t33.Enabled = true;
            t34.Enabled = true;
            t35.Enabled = true;
            t36.Enabled = true;
            t37.Enabled = true;
            t38.Enabled = true;
            t39.Enabled = true;

            t41.Enabled = true;
            t42.Enabled = true;
            t43.Enabled = true;
            t44.Enabled = true;
            t45.Enabled = true;
            t46.Enabled = true;
            t47.Enabled = true;
            t48.Enabled = true;
            t49.Enabled = true;

            t51.Enabled = true;
            t52.Enabled = true;
            t53.Enabled = true;
            t54.Enabled = true;
            t55.Enabled = true;
            t56.Enabled = true;
            t57.Enabled = true;
            t58.Enabled = true;
            t59.Enabled = true;

            t61.Enabled = true;
            t62.Enabled = true;
            t63.Enabled = true;
            t64.Enabled = true;
            t65.Enabled = true;
            t66.Enabled = true;
            t67.Enabled = true;
            t68.Enabled = true;
            t69.Enabled = true;

            t71.Enabled = true;
            t72.Enabled = true;
            t73.Enabled = true;
            t74.Enabled = true;
            t75.Enabled = true;
            t76.Enabled = true;
            t77.Enabled = true;
            t78.Enabled = true;
            t79.Enabled = true;

            t81.Enabled = true;
            t82.Enabled = true;
            t83.Enabled = true;
            t84.Enabled = true;
            t85.Enabled = true;
            t86.Enabled = true;
            t87.Enabled = true;
            t88.Enabled = true;
            t89.Enabled = true;

            t91.Enabled = true;
            t92.Enabled = true;
            t93.Enabled = true;
            t94.Enabled = true;
            t95.Enabled = true;
            t96.Enabled = true;
            t97.Enabled = true;
            t98.Enabled = true;
            t99.Enabled = true;
        }
        //event keyPress of 81 textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            // Lấy giá trị dạng số nguyên

        }
        //new game
        public void NewGame(int amount)
        {
            int count = 5001, found = 0;
            //random ra 25 o so sao cho thuat toan khong de qui qua 1000 lan
            //tranh nhung truong hop giai thuat giai qua lau
            //dam bao luon render ra de dung
            while (count >= 5000 || found == 0)
            {
                Random rd = new Random();
                //have 81, defult is 21
                int i = 1, j, x, y;
                //clear du lieu truoc khi render
                clear();
                //bat dau render
                //bien status de luu vet nhung o so duoc render
                //khoi tao status
                for (x = 1; x <= 9; x++)
                {
                    for (y = 1; y <= 9; y++)
                    {
                        status[x, y] = false;
                    }
                }
                //render 25 o so
                while (i <= amount)
                {
                    //x y la vi tri o so
                    //lay vi tri ngau nhien
                    x = rd.Next(1, 10);
                    y = rd.Next(1, 10);
                    //neu o so bang 0 thi render gia tri ngau nhien
                    if (Number[x, y] == 0)
                    {
                        Number[x, y] = rd.Next(1, 9);
                        if (check())
                        {
                            status[x, y] = true;
                            connectTextBox(1);
                            i++;
                        }
                        else
                        {
                            Number[x, y] = 0;
                        }
                    }
                }
                //giai game de kiem tra de ra co dung khong
                //dam bao giai thuat de qui duoi 5000 lan
                data = new SudokuOject(Number, status);
                found = data.solve(0, 0);
                count = data.count;
            }
            connectArray();
            //thong bao rong
            lbStatus.Text = "Status: ";
        }

        private void t99_KeyUp(object sender, KeyEventArgs e)
        {
            connectArray();
            if (check())
            {
                lbStatus.Text = "Status: Correct";
            }
            else
            {
                lbStatus.Text = "Status: Wrong";
            }
            if (checkSuccess())
            {
                MessageBox.Show("Congratulations!");
                switch (level)
                {
                    case 1:
                        {
                            level++;
                            NewGame(20);
                            break;
                        }
                    case 2:
                        {
                            level++;
                            NewGame(18);
                            break;
                        }
                    case 3:
                        {
                            level++;
                            NewGame(16);
                            break;
                        }
                    case 4:
                        {
                            level++;
                            NewGame(14);
                            break;
                        }
                    case 5:
                        {
                            NewGame(14);
                            break;
                        }
                }
                if(level == 1)
                {
                    level++;
                    NewGame(20);
                }
            }
        }
        //kiem tra hoan thanh
        public Boolean checkSuccess()
        {
            int x, y;
            for (x = 1; x <= 9; x++)
            {
                for (y = 1; y <= 9; y++)
                {
                    if (Number[x, y] == 0)
                    {
                        return false;
                    }
                }
            }
            return check() && true;
        }
        private void btnHint_Click(object sender, EventArgs e)
        {
            if(col.Value != null && row.Value != null) {
                int x = (col.Value <= 9 && col.Value > 0) ? Convert.ToInt32(col.Value) : 0;
                int y = (row.Value <= 9 && row.Value > 0) ? Convert.ToInt32(row.Value) : 0;
                data.solve(0, 0);
                int result = data.get(x, y);
                connectArray();
                Number[x, y] = result;
                connectTextBox();
            }
        }
        //new game lv1
        private void l1_Click(object sender, EventArgs e)
        {
            //dat lai cap do
            level = 1;
            NewGame(25);
        }
        //new game lv2
        private void l2_Click(object sender, EventArgs e)
        {
            //dat lai cap do
            level = 2;
            NewGame(20);
        }
        //new game lv3
        private void l3_Click(object sender, EventArgs e)
        {
            //dat lai cap do
            level = 3;
            NewGame(18);
        }
        //new game lv4
        private void l4_Click(object sender, EventArgs e)
        {
            //dat lai cap do
            level = 4;
            NewGame(16);
        }
        //new game lv5
        private void l5_Click(object sender, EventArgs e)
        {
            //dat lai cap do
            level = 5;
            NewGame(14);
        }
        //btn giai game
        private void solve_Click(object sender, EventArgs e)
        {
            data = new SudokuOject(Number, status);
            data.solve(0, 0);
            Number = data.getNumber();
            connectTextBox();
            lbStatus.Text = "Status: Success";
        }
        //btn luu game
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.Save();
            MessageBox.Show("Saved successfully!");
        }
        //huong dan quy luat game
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The rule of Sudoku game is to fill in the remaining boxes as long as:\n" +
                "\t- The horizontal rows: Must have enough numbers from 1 to 9, do not have the same number and do not need the correct order.\n" +
                "\t- Vertical lines: Make sure to have enough numbers from 1-9, do not have the same number, do not need to be in order.\n" +
                "\t- Each 3 x 3 area: Must have numbers 1-9 and do not have the same number in the same 3 x3 area.");
        }
    }
}
