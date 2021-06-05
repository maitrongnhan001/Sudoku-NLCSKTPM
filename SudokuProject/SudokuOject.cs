using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProject
{
    class SudokuOject
    {
        private int[,] Number = new int[10, 10];
        private Boolean[,] Status = new Boolean[10, 10];
        public SudokuOject() { }
        public SudokuOject(int[,] number, Boolean[,] status)
        {
            Number = number;
            Status = status;
            //luu tru ma tran so va trang thai vao object
        }
        //lay du lieu ma tran tu object
        public int[,] getNumber()
        {
            return Number;
        }
        public Boolean[,] getStatus()
        {
            return Status;
        }
        public int get(int x, int y)
        {
            return Number[x, y];
        }
        //kiem tra ma tran co dang hop le
        private Boolean check()
        {
            int[] temp = new int[9];
            //chech 3x3
            int i, j, IndexOfTemp = 0;
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
        static Boolean checkStatusElement = true;
        //dem so lan de qui
        public int count = 0;
        public int solve(int x, int y)
        {
            //moi lan de qui tang len 1
            count++;
            if (count == 5000)
            {
                //gioi han de qui 5000 lan
                return 1;
            }
            if (x == 9 && y == 9)
            {
                //da giai toi o cuoi
                return 1;
            }
            else
            {
                //chua toi o cuoi thi thay doi vi tri chuyen sang o tiep theo
                if (x == 0 && y == 0)
                {
                    x++;
                    y++;
                }
                else
                {
                    if (x <= 9 && y < 9)
                    {
                        y++;
                    }
                    else
                    {
                        if (x < 9 && y == 9)
                        {
                            x++;
                            y = 1;
                        }
                    }
                }
            }
            int value;
                //neu o do khong phai la o so cua đề thi dat gia tri
                if (!Status[x, y])
                {
                    for (value = 1; value <= 9; value++)
                    {
                        Number[x, y] = value;
                    //kiem tra gia tri co dung khong
                    if (check())
                        {
                            //dung thi de qui toi o tiep theo (nhanh tiep theo)
                            int a = solve(x, y);
                            if (a == 1)
                            {
                                //de qui tra ve bien a
                                return 1;
                            }
                            else
                            {
                                //a = 0 thi quay lui
                                Number[x, y] = 0;
                            }
                        }
                    }
                }
                else
                {
                    //neu la o so cua de bai thi de qui sang o tiep theo (nhanh tiep theo)
                    return solve(x, y);
                }
            //chay het vong lap
            //khong tim duoc gia tri phu hop
            Number[x, y] = 0;
            return 0;
        }
        public void Save()
        {
            //ghi du lieu cua ma tran sudoku vao trong file data
            //ghi du lieu cua ma tran trang thai vao file status
            File.Delete("Data.txt");
            File.Delete("Status.txt");
            StreamWriter WirteData = new StreamWriter("Data.txt");
            StreamWriter WirteStatus = new StreamWriter("Status.txt");
            int i, j;
            for(i = 1; i <= 9; i++)
            {
                for(j = 1; j <= 9; j++)
                {
                    WirteData.WriteLine(Number[i, j]);
                    WirteStatus.WriteLine(Status[i, j]);
                }
            }
            WirteData.Close();
            WirteStatus.Close();
        }
        public void Read()
        {
            //doc du lieu cua ma tran sudoku vao trong file data
            //doc du lieu cua ma tran trang thai vao file status
            StreamReader readData = new StreamReader("Data.txt");
            StreamReader readStatus = new StreamReader("Status.txt");
            int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    Number[i, j] = Convert.ToInt32(readData.ReadLine());
                    Status[i, j] = Convert.ToBoolean(readStatus.ReadLine());
                }
            }
            readData.Close();
            readStatus.Close();
        }
    }
}
