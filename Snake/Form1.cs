namespace Snake
{
    public partial class Form1 : Form
    {
        int score = 0;
        int highscore = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
