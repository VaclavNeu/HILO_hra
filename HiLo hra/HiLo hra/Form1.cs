namespace HiLo_hra
{
    public partial class Form1 : Form
    {
        int Cisilko;
        int Streak;
        int pocitadlo;
        int pohyb = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_generace_Click(object sender, EventArgs e)
        {
            Random rndNumber = new Random();
            Cisilko = rndNumber.Next(0, 150);
            Cislo.Text = Cisilko.ToString();
            pocitadlo = 0;
            PocitacMozek.Text = "Cislo vygenerovano";
        }

        private void btn_Hadej_Click(object sender, EventArgs e)
        {
            //  int prevodCisilko = Convert.ToInt32(Math.Round(Cislo.Text.Value, 0));
            pocitadlo++;

            int prevod = Convert.ToInt32(Math.Round(VkladCisel.Value));
            if (prevod == Cisilko)
            {
                PocitacMozek.Text = "Huraaaa, uhodl jsi cislo";
            }
            else if (prevod > Cisilko)
            {
                PocitacMozek.Text = "Jsi nad";
            }
            else if (prevod < Cisilko)
            {
                PocitacMozek.Text = "Jsi pod";
            }



            if (pocitadlo > 1)
            {
                Streak = 0;
            }
            else { Streak++; pocitadlo = 0; if (Streak == 3) { btn_Streak.Visible = true; } else { btn_Streak.Visible = false; } }

        }

        private void btn_Napoveda_Click(object sender, EventArgs e)
        {
            if (Cislo.Visible == true)
            {
                Cislo.Visible = false;
            }
            else { Cislo.Visible = true; }
        }

        private void btn_Streak_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Tak podvadeni jsme si nedomluvili!!");
            btn_generace.Enabled = false;

        }

        private void btn_Hadej_MouseHover(object sender, EventArgs e)
        {
            if (btn_Streak.Visible == true)
            {
                Random rndNumber = new Random();
                
                
                    int SouradniceX = rndNumber.Next(0, 890);
                    int SouradniceY = rndNumber.Next(0, 620);
                    btn_Hadej.Location = new Point (SouradniceX,SouradniceY);
                
                pohyb++;
                if (pohyb == 5) {  btn_Hadej.Enabled = false; MessageBox.Show("Ted si zahraju ja");Obrazek_Boss.Visible = true; }
                
            
            }
        }
    }
}
