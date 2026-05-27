using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Snake
{
    public partial class Form1 : Form
    {
        Random xd = new Random();
        List<Point> waz = new List<Point>();
        Point jablko = new Point();
        int score = 1;
        int highscore = 1;
        int speed = 20;
        bool moveUP = false;
        bool moveDOWN = false;
        bool moveLEFT = false;
        bool moveRIGHT = false;
        bool lastMoveUP = false;
        bool lastMoveDOWN = false;
        bool lastMoveLEFT = false;
        bool lastMoveRIGHT = false;
        int rozmiarkwadrata = 20;
        bool jablkozjedzone = false;
        bool cheat = false;
        bool normal = true;
        int dlawygrania;
        bool win = false;
        bool pokazano = false;
        int Forpaint = 15;
        bool dobremiejscedlajabłka;
        int jablkoY;
        int jablkoX;
        bool timerdodano = false;
        int dodatkowaspeed = 0;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lastMoveUP = moveUP;
            lastMoveDOWN = moveDOWN;
            lastMoveLEFT = moveLEFT;
            lastMoveRIGHT = moveRIGHT;
            bool czydodano = false;
            if (score > highscore && czydodano == false)
            {
                czydodano = true;
                highscore = score;
                czydodano = false;
            }
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
            if (normal == true)
            {
                for (int i = 1; i < waz.Count; i++)
                {
                    if (nowaglowa.X == waz[i].X && nowaglowa.Y == waz[i].Y)
                    {
                        resetgame();
                        return;
                    }
                }
            }
            waz.Insert(0, nowaglowa);
            if (nowaglowa.X == jablko.X && nowaglowa.Y == jablko.Y && jablkozjedzone == false)
            {
                timerdodano = false;
                if (timerdodano == false) {
                timer1.Interval -= 1;
                    timerdodano = true;
                    dodatkowaspeed++;
                }
                jablkozjedzone = true;
                if (normal == true)
                {
                    score++;
                }
                dobremiejscedlajabłka = false;
                while (dobremiejscedlajabłka == false)
                {
                    jablkoX = xd.Next(0, this.ClientSize.Width / rozmiarkwadrata) * rozmiarkwadrata;
                    jablkoY = xd.Next(0, this.ClientSize.Height / rozmiarkwadrata) * rozmiarkwadrata;
                    dobremiejscedlajabłka = true;
                    foreach (Point segment in waz)
                    {
                        if (jablkoX == segment.X && jablkoY == segment.Y)
                        {
                            dobremiejscedlajabłka = false;
                            break;
                        }

                    }
                }
                jablko = new Point(jablkoX, jablkoY);
                if (cheat == true)
                {
                    for (int i = 1; i < 20; i++)
                    {
                        waz.Add(waz[waz.Count - 1]);
                    }
                   
                }
                waz.Add(waz[waz.Count - 1]);
                jablkozjedzone = false;
            }
            if (score == dlawygrania)
            {

                if (!pokazano)
                {
                    pokazano = true;
                    resetgame1();
                    MessageBox.Show("Wygrałeś");
                }
            }
            else
            {
                waz.RemoveAt(waz.Count - 1);
            }
            if (normal == true)
            {
               
                if (nowaglowa.X >= 761 || nowaglowa.X <= -1 || nowaglowa.Y >= 541 || nowaglowa.Y <= -1)
                {
                    resetgame();
                }
            }
            if (cheat == true)
            {
                if (nowaglowa.X >= 761)
                {
                    moveRIGHT = false;
                    moveLEFT = true;
                    moveUP = false;
                    moveDOWN = false;
                }
                if (nowaglowa.X <= -1)
                {
                    moveLEFT = false;
                    moveRIGHT = true;
                    moveUP = false;
                    moveDOWN = false;
                }
                if (nowaglowa.Y >= 541)
                {
                    moveDOWN = false;
                    moveUP = true;
                    moveLEFT = false;
                    moveRIGHT = false;
                }
                if (nowaglowa.Y <= -1)
                {
                    moveUP = false;
                    moveDOWN = true;
                    moveLEFT = false;
                    moveRIGHT = false;
                }
            }
            Invalidate();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int p = rozmiarkwadrata / 5;
            int[,] grafikaJablka = new int[5, 5] {
        { 0, 0, 2, 2, 0 },
        { 0, 1, 1, 1, 0 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 0, 1, 1, 1, 0 }
    };
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Brush kolorPiksela = null;
                    if (grafikaJablka[row, col] == 1) kolorPiksela = Brushes.Red;
                    else if (grafikaJablka[row, col] == 2) kolorPiksela = Brushes.LimeGreen;

                    if (kolorPiksela != null)
                    {
                        g.FillRectangle(kolorPiksela, jablko.X + (col * p), jablko.Y + (row * p), p, p);
                    }
                }
            }
            foreach (Point segment in waz)
            {
                g.FillRectangle(Brushes.Black, segment.X, segment.Y, rozmiarkwadrata, rozmiarkwadrata);
            }
            int gg = rozmiarkwadrata / 5;
            int[,] grafikawenza = new int[5, 5] {
        { 1, 1, 2, 1, 1 },
        { 1, 1, 2, 1, 1 },
        { 2, 2, 2, 2, 2 },
        { 1, 1, 2, 1, 1 },
        { 1, 1, 2, 1, 1 }
    };
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Brush kolorPiksela = null;
                    if (grafikawenza[row, col] == 1) kolorPiksela = Brushes.Black;
                    else if (grafikawenza[row, col] == 2) kolorPiksela = Brushes.White;

                    if (kolorPiksela != null)
                    {
                        g.FillRectangle(kolorPiksela, waz[0].X + (col * gg), waz[0].Y + (row * gg), gg, gg);
                    }
                }
            }
            for (int x = 0; x < this.Width; x += rozmiarkwadrata)
                g.DrawLine(Pens.DarkGreen, x, 0, x, this.Height);

            for (int y = 0; y < this.Height; y += rozmiarkwadrata)
                g.DrawLine(Pens.DarkGreen, 0, y, this.Width, y);
            if (normal == true)
            {
                g.DrawString($"Score: {score}", new Font("Arial", 12), Brushes.White, 50, 10);
                g.DrawString($"Speed: {dodatkowaspeed}", new Font("Arial", 12), Brushes.White, 300, 10);
                g.DrawString($"High score: {highscore}", new Font("Arial", 12), Brushes.White, 600, 10);
            }
            if (cheat == true)
            {
                g.DrawString($"Nie działa z cheat  modem", new Font("Arial", 12), Brushes.White, 50, 10);
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
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
            MessageBox.Show("Lose :( \t" +
                $"Your score: {score} \t" +
                $"Your Highest score: {highscore} \t");
            score = 1;
            moveUP = false;
            moveDOWN = false;
            moveLEFT = false;
            moveRIGHT = false;
            jablkozjedzone = false;
            waz.Clear();
            waz.Add(new Point(400, 300));
            panelmenu.Visible = true;
            int jablkoX = xd.Next(0, this.ClientSize.Width / rozmiarkwadrata) * rozmiarkwadrata;
            int jablkoY = xd.Next(0, this.ClientSize.Height / rozmiarkwadrata) * rozmiarkwadrata;
            jablko = new Point(jablkoX, jablkoY);
        }
        private void resetgame1()
        {
            timer1.Stop();
            score = 1;
            moveUP = false;
            moveDOWN = false;
            moveLEFT = false;
            moveRIGHT = false;
            jablkozjedzone = false;
            waz.Clear();
            waz.Add(new Point(400, 300));
            panelmenu.Visible = true;
            int jablkoX = xd.Next(0, this.ClientSize.Width / rozmiarkwadrata) * rozmiarkwadrata;
            int jablkoY = xd.Next(0, this.ClientSize.Height / rozmiarkwadrata) * rozmiarkwadrata;
            jablko = new Point(jablkoX, jablkoY);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnEasys_Click(object sender, EventArgs e)
        {
            panelmenu.Visible = false;
            this.Focus();
            dlawygrania = 50;
            timer1.Interval = 200;
            timer1.Start();
        }


        private void BtnHards_Click(object sender, EventArgs e)
        {
            panelmenu.Visible = false;
            this.Focus();
            dlawygrania = 300;
            timer1.Interval = 50;
            timer1.Start();
        }

        private void BtnMediums_Click_1(object sender, EventArgs e)
        {
            panelmenu.Visible = false;
            this.Focus();
            dlawygrania = 150;
            timer1.Interval = 100;
            timer1.Start();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                resetgame1();
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (!lastMoveDOWN)
                {
                    if (moveDOWN == false)
                    {
                        moveUP = true;
                        moveDOWN = false;
                        moveLEFT = false;
                        moveRIGHT = false;
                    }
                }
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (!lastMoveUP)
                {
                    if (moveUP == false)
                    {
                        moveUP = false;
                        moveDOWN = true;
                        moveLEFT = false;
                        moveRIGHT = false;
                    }
                }
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (!lastMoveRIGHT)
                {
                    if (moveRIGHT == false)
                    {
                        moveUP = false;
                        moveDOWN = false;
                        moveLEFT = true;
                        moveRIGHT = false;
                    }
                }
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (!lastMoveLEFT)
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

        private void CheatBtn_Click(object sender, EventArgs e)
        {
            cheat = true;
            normal = false;
            MessageBox.Show("Cheat mode włączony");
        }

        private void NormBtn_Click(object sender, EventArgs e)
        {
            normal = true;
            cheat = false;
            MessageBox.Show("Cheat mode wyłączony");
        }
    }
}
