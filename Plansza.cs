using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silnik
{
    public partial class Plansza : Form
    {
        public Plansza()
        {
            InitializeComponent();
        }
        Bitmap Mapa = new Bitmap(1000, 500);

        int NumerNarzedzia = 0;
        bool IsPainting = false;
        int[] WspolrzedneKursora = new int[2];
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Mapa.SetPixel(i, j, Color.Red);
                }
            }

            Tlo.Image = Mapa;

        }

        private void  SetPixel(int x, int y, Color kolor)
        {
            try
            {
                Mapa.SetPixel(x, y, kolor);
                Tlo.Image = Mapa;
            }
            catch(Exception)
            {

            }
        }
        private Color GetPixel(int x, int y)
        {
            return Mapa.GetPixel(x, y);
        }

        private void Tlo_MouseDown(object sender, MouseEventArgs e)
        {
            switch (NumerNarzedzia)
            {
                case 0:
                    {
                        IsPainting = true;
                        break;
                    }
                case 1:
                    {
                        WspolrzedneKursora[0] = e.X;
                        WspolrzedneKursora[1] = e.X;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Default case");
                        break;
                    }
            }
        }

        private void Tlo_MouseUp(object sender, MouseEventArgs e)
        {
            switch (NumerNarzedzia)
            {
                case 0:
                    {
                        IsPainting = false;
                        break;
                    }
                case 1:
                    {
                        StworzLinie(e.X, e.Y);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Default case");
                        break;
                    }
            }
        }

        private void Tlo_MouseMove(object sender, MouseEventArgs e)
        {
            switch(NumerNarzedzia)
            {
                case 0:
                    {
                        if (IsPainting == true)
                        {
                            SetPixel(e.X, e.Y, Color.White);
                        }
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Default case");
                        break;
                    }
            }

            CoordsPosition();
        }

        private void CoordsPosition()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);

            int xCoordinate = Cursor.Position.X;
            int yCoordinate = Cursor.Position.Y;

            Coords.Text = "X:" + xCoordinate + " " + "Y:" + yCoordinate;
        }

        private void Pedzel_Click(object sender, EventArgs e)
        {
            NumerNarzedzia = 0;
        }

        private void Linia_Click(object sender, EventArgs e)
        {
            NumerNarzedzia = 1;
        }

        private void StworzLinie(int XKoncowe, int YKoncowe)
        {
            MessageBox.Show(WspolrzedneKursora[0] + ":" + WspolrzedneKursora[1] + "     " + XKoncowe + ":" + YKoncowe);

        }
    }
}
