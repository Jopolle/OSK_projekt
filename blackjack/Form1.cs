namespace blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicjalizujTalie();
            rozdaj();
        }
        private void InicjalizujTalie()
        {
            talia = new List<Karta>();
            string[] kolory = { "spades", "clubs", "hearts", "diamonds" };
            string[] wartosci = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
            int[] punkty = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

            foreach (var kolor in kolory)
            {
                for (int i = 0; i < wartosci.Length; i++)
                {
                    talia.Add(new Karta(kolor, wartosci[i], punkty[i]));
                }
            }
        }
        private int Shuffle()
        {
            Random rng = new Random();
            return rng.Next(0, 52);

        }
        private void update()
        {
            this.label_value.Text = "Hand value: " + this.hand_score.ToString();
            this.label_chips.Text = "Your chips: " + this.points.ToString();
            this.label_bet.Text = "Bet size: " + this.bet_size.ToString();
            this.label_dealer_hand.Text = "Dealer hand Value: " + this.dealer_score.ToString();
        }
        public void rozdaj()
        {
            Karta k1 = talia[Shuffle()];
            Karta k2 = talia[Shuffle()];
            Karta d1 = talia[Shuffle()];
            zeruj();



            this.player3.Image = null;
            this.player4.Image = null;
            this.player5.Image = null;
            this.player6.Image = null;

            this.dealer3.Image = null;
            this.dealer4.Image = null;
            this.dealer5.Image = null;
            this.dealer6.Image = null;

            //
            //this.dealer1.Image = (Image)Properties.Resources.ResourceManager.GetObject(k1.ToStringName());
            //this.player1.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k1.ToStringName());
            this.player1.Image = (Image)Properties.Resources.ResourceManager.GetObject(k1.ToStringName());
            this.hand_score += k1.Punkty;
            this.card_counter++;
            //this.player2.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k2.ToStringName());
            this.player2.Image = (Image)Properties.Resources.ResourceManager.GetObject(k2.ToStringName());

            this.hand_score += k2.Punkty;
            this.card_counter++;


            //this.dealer2.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + d1.ToStringName());
            this.dealer2.Image = (Image)Properties.Resources.ResourceManager.GetObject(d1.ToStringName());
            this.dealer_counter++;
            this.timer_counter++;
            this.dealer_score += d1.Punkty;
            //this.dealer1.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\rewers.png");
            this.dealer1.Image = Properties.Resources.rewers;

            update();
        }
        private void zeruj()
        {
            this.card_counter = 0;
            this.hand_score = 0;
            this.dealer_score = 0;
            this.dealer_counter = 0;
            this.bet_size = 0;
            this.textBox1.Text = null;
            this.timer_counter = 0;
            this.label_err.Hide();
            this.label_bet_err.Hide();
            this.timer1.Stop();
            update();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hit_button_Click(object sender, EventArgs e)
        {
            this.label_bet_err.Hide();
            if (bet_size > 0 && dealer_on!)
            {
                Karta k = talia[Shuffle()];
                switch (card_counter)
                {

                    case 2:
                        //this.player3.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
                        this.player3.Image = (Image)Properties.Resources.ResourceManager.GetObject(k.ToStringName());
                        this.hand_score += k.Punkty;
                        card_counter++;
                        break;
                    case 3:
                        //this.player4.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
                        this.player4.Image = (Image)Properties.Resources.ResourceManager.GetObject(k.ToStringName());

                        this.hand_score += k.Punkty;
                        card_counter++;
                        break;
                    case 4:
                        //this.player5.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
                        this.player5.Image = (Image)Properties.Resources.ResourceManager.GetObject(k.ToStringName());
                        this.hand_score += k.Punkty;
                        card_counter++;
                        break;
                    case 5:
                        //this.player6.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
                        this.player6.Image = (Image)Properties.Resources.ResourceManager.GetObject(k.ToStringName());
                        this.hand_score += k.Punkty;
                        card_counter++;
                        break;

                }
            }
            else
            {
                this.label_bet_err.Show();
            }

            //this.player1.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
            update();
            if (this.hand_score > 21)
            {
                Form2 noweOkno = new Form2(this);
                noweOkno.ShowDialog();
            }
            //this.label_score.Text = "Karta wywołana to: " + talia[34].ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void deal_Click(object sender, EventArgs e)
        {
            rozdaj();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dealer_score < 16) {
                Karta d = talia[Shuffle()];
                switch (this.timer_counter)
                {
                    case 1:
                        this.dealer1.Image = (Image)Properties.Resources.ResourceManager.GetObject(d.ToStringName());
                        this.dealer_score += d.Punkty;
                        this.dealer_counter++;
                        this.timer_counter = 2;
                        break;
                    case 2:
                        this.dealer3.Image = (Image)Properties.Resources.ResourceManager.GetObject(d.ToStringName());
                        this.dealer_score += d.Punkty;
                        this.dealer_counter++;
                        this.timer_counter = 3;
                        break;
                    case 3:
                        this.dealer4.Image = (Image)Properties.Resources.ResourceManager.GetObject(d.ToStringName());
                        this.dealer_score += d.Punkty;
                        this.dealer_counter++;
                        this.timer_counter = 4;
                        break;
                    case 4:
                        this.dealer5.Image = (Image)Properties.Resources.ResourceManager.GetObject(d.ToStringName());
                        this.dealer_score += d.Punkty;
                        this.dealer_counter++;
                        this.timer_counter = 5;
                        break;
                    case 5:
                        this.dealer6.Image = (Image)Properties.Resources.ResourceManager.GetObject(d.ToStringName());
                        this.dealer_score += d.Punkty;
                        this.dealer_counter++;
                        this.timer_counter = 6;
                        break;
                } 
            }
            else
            {

            }
            update();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bet_size = Int32.Parse(this.textBox1.Text);
            this.label_err.Hide();
            if (bet_size > this.points)
            {
                this.label_err.Show();

            }
            else if (bet_size < 0)
            {
                this.label_err.Show();
            }
            else
            {
                this.points -= bet_size;
            }
            update();
        }

        private void stand_button_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.dealer_on = true;

        }
    }
}
