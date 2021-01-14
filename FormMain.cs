using System;

using System.Drawing;

using System.Windows.Forms;

namespace ElJuegoDelaVida
{
    public partial class MainForm : Form
    {
        private int longitud = 400;
        private int longitudPixel = 1;
        int[,] celulas;


        public MainForm()
        {
            InitializeComponent();

            //Inicializamos 
            celulas = new int[longitud, longitud];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            {
                comboTamaño.Items.Add(i + 1 + " px");
            }

            comboTipo.Items.Add("Cuadrado");
            comboTipo.Items.Add("Oscilador Simple");
        }

        private void PintarMatriz()
        {
            Bitmap bmp = new Bitmap(isla.Width, isla.Height);
            for(int x=0; x<longitud;x++)
            {
                for(int y=0;y<longitud;y++)
                {
                    if(celulas[x,y]==0)
                    {
                        PintarPixel(bmp, x, y, Color.White);
                    }
                    else
                    {
                        PintarPixel(bmp, x, y, Color.Black);
                    }
                }
            }
         

        }

        private void PintarPixel(Bitmap bmp, int x, int y, Color color)
        {
            for(int i=0;i<longitudPixel;i++)
            {
                for(int j=0;j<longitudPixel; j++)
                {
                    bmp.SetPixel(i + (x*longitudPixel), j + (y * longitudPixel),color);
                }
            }

            isla.Image = bmp;
        }

        private void JuegodeLaVida()
        {
            int[,] celulasTemporal = new int[longitud, longitud];
            for(int x=0;x<longitud;x++)
            {
                for (int y = 0; y < longitud; y++)
                {
                    if (celulas[x,y]==0)
                    {
                        celulasTemporal[x, y] = ReglaJuegoVida(x,y,false);
                    }
                    else
                    {
                        celulasTemporal[x, y] = ReglaJuegoVida(x, y, true);
                    }
                }
            }
            celulas = celulasTemporal;
        }

        private int ReglaJuegoVida(int x, int y, bool Vive)
        {
            int VecinasVivas = 0;
            if (x > 0&&y>0)
                if (celulas[x - 1, y - 1] == 1)
                    VecinasVivas++;

            //Celula de arriba
            if (y > 0)
                if (celulas[x, y - 1] == 1)
                    VecinasVivas++;

            //Celula derecha arriba
            if (x < longitud - 1&&y>0)
                if (celulas[x + 1, y - 1] == 1)
                    VecinasVivas++;
            //Celula de la izq
            if (x > 0)
                if (celulas[x - 1, y] == 1)
                    VecinasVivas++;
            //Celula derecha
            if (x < longitud - 1)
                if (celulas[x + 1, y] == 1)
                    VecinasVivas++;
            //Celula inf izq
            if (x > 0 && y < longitud - 1)
                if (celulas[x - 1, y + 1] == 1)
                    VecinasVivas++;

            //Celula inferior
            if (y < longitud - 1)
                if (celulas[x, y + 1] == 1)
                    VecinasVivas++;
            //Cel inf derecha
            if (x < longitud - 1&&y<longitud-1)
                if (celulas[x + 1, y+1] == 1)
                    VecinasVivas++;

            if (Vive)
                return (VecinasVivas == 2 || VecinasVivas == 3) ? 1 : 0;
            else
                return VecinasVivas == 3 ? 1 : 0;
        
                
        }
        //

        private void btnRandom_Click(object sender, EventArgs e)
        {
            btnCreacion.Enabled = true;
            for(int i=0; i< longitud;i++)
            {
                for(int j=0;j<longitud;j++)
                {
                    celulas[i, j] = 0;
                }
            }

            Random r = new Random();
            for(int i =0;i<longitud;i++)
            {
                for(int j =0; j<longitud;j++)
                {
                    celulas[i, j] = r.Next(0, 2);
                }
            }

            PintarMatriz();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            JuegodeLaVida();
            PintarMatriz();
        }

        private void comboTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            longitudPixel = comboTamaño.SelectedIndex+1;
            longitud = 400/longitudPixel;
            extincion();
        }

        private void extincion()
        {
            Bitmap bmp = new Bitmap(isla.Width, isla.Height);
            for (int x = 0; x < longitud; x++)
            {
                for (int y = 0; y < longitud; y++)
                {
                    PintarPixel(bmp, x, y, Color.White);
                }
            }

            btnCreacion.Enabled = false;
        }

        private void btnExtincion_Click(object sender, EventArgs e)
        {
            btnCreacion.Enabled = false;
            timer1.Enabled = false;
            extincion();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            extincion();
            Bitmap bmp = new Bitmap(isla.Width, isla.Height);
            
            for (int x = 0; x < longitudPixel; x++)
            {
                for (int y = 0; y < longitudPixel; y++)
                {
                    PintarPixel(bmp,x+50 ,y+50 , Color.Black);
                }
            }
            isla.Image = bmp;
        }
    }
}
