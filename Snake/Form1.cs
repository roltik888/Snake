using System.Configuration;
using System.Drawing.Drawing2D;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Snake
{
    public partial class Form1 : Form
    {
        Random xd = new Random();
        List<Point> waz = new List<Point>();
        Point jablko = new Point();
        int score = 0;
        int highscore = 0;
        int speed = 20;
        bool moveUP = false;
        bool moveDOWN = false;
        bool moveLEFT = false;
        bool moveRIGHT = false;
        int rozmiarkwadrata = 20;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point nowaglowa = waz[0];
            if (moveDOWN == true)
            {
                nowaglowa.Y += speed;
            }
            if (moveUP == true)
            {
                nowaglowa.Y -= speed;
            }
            if (moveLEFT == true)
            {
                nowaglowa.X -= speed;
            }
            if (moveRIGHT == true)
            {
                nowaglowa.X += speed;
            }
            waz.Insert(0, nowaglowa);
            waz.RemoveAt(waz.Count - 1);
            if (nowaglowa.X == jablko.X & nowaglowa.Y == jablko.Y)
            {
                score++;
                int jablkoX = xd.Next(0, this.ClientSize.Width / rozmiarkwadrata) * rozmiarkwadrata;
                int jablkoY = xd.Next(0, this.ClientSize.Height / rozmiarkwadrata) * rozmiarkwadrata;
                jablko = new Point(jablkoX, jablkoY);
                waz.Add(waz[waz.Count - 1]);
            }
            if (nowaglowa.X >= 801 || nowaglowa.X <= -1 || nowaglowa.Y >= 601 || nowaglowa.Y <= -1)
            {
                resetgame();
            }
                Invalidate();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Red, jablko.X, jablko.Y, rozmiarkwadrata, rozmiarkwadrata);
            foreach (Point segment in waz)
            {
                g.FillRectangle(Brushes.Black, segment.X, segment.Y, rozmiarkwadrata, rozmiarkwadrata);
            }
            g.DrawString($"Score: {score}", new Font("Arial", 12), Brushes.White, 50, 10);
            g.DrawString($"High score: {highscore}", new Font("Arial", 12), Brushes.White, 400, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            waz.Add(new Point(400, 300));
            int maxrozmiarY = this.ClientSize.Height;
            int maxrozmiarX = this.ClientSize.Width;
            int jablkoX = xd.Next(0, this.ClientSize.Width / rozmiarkwadrata) * rozmiarkwadrata;
            int jablkoY = xd.Next(0, this.ClientSize.Height / rozmiarkwadrata) * rozmiarkwadrata;
            jablko = new Point(jablkoX, jablkoY);
            
        }
        private void resetgame()
        {
            timer1.Stop(); 
            MessageBox.Show("GG");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                if (moveDOWN == false)
                {
                    moveUP = true;
                    moveDOWN = false;
                    moveLEFT = false;
                    moveRIGHT = false;
                }           
            }
            if (e.KeyChar == 's')
            {
                if (moveUP == false)
                {
                    moveUP = false;
                    moveDOWN = true;
                    moveLEFT = false;
                    moveRIGHT = false;
                }
            }
            if (e.KeyChar == 'a')
            {
                if (moveRIGHT == false)
                {
                    moveUP = false;
                    moveDOWN = false;
                    moveLEFT = true;
                    moveRIGHT = false;
                }
            }
            if (e.KeyChar == 'd')
            {
                if (moveLEFT == false)
                {
                    moveUP = false;
                    moveDOWN = false;
                    moveLEFT = false;
                    moveRIGHT = true;
                }
            }
        }
    }
}
