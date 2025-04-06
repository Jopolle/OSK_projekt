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


            //reka.Add(k1);
            //reka.Add(k2);
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
            this.bet = 0;
            this.textBox1.Text = null;
            this.timer_counter = 0;
            this.label_err.Hide();
            this.label_bet_err.Hide();
            this.timer1.Stop();
            this.button1.Show();
            //this.reka.Clear();
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
            this.button1.Hide();
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
                        //reka.Add(k);
                        break;
                    case 3:
                        //this.player4.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
                        this.player4.Image = (Image)Properties.Resources.ResourceManager.GetObject(k.ToStringName());

                        this.hand_score += k.Punkty;
                        card_counter++;
                        //reka.Add(k);
                        break;
                    case 4:
                        //this.player5.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
                        this.player5.Image = (Image)Properties.Resources.ResourceManager.GetObject(k.ToStringName());
                        this.hand_score += k.Punkty;
                        card_counter++;
                        //reka.Add(k);
                        break;
                    case 5:
                        //this.player6.Load("C:\\Users\\pawel\\source\\repos\\blackjack\\bin\\cards\\" + k.ToStringName());
                        this.player6.Image = (Image)Properties.Resources.ResourceManager.GetObject(k.ToStringName());
                        this.hand_score += k.Punkty;
                        card_counter++;
                        //reka.Add(k);
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
            //else if (reka.Contains())
            //{

            //}
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
            if (this.dealer_on)
            {
                if (dealer_score < 16)
                {
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
                    timer1.Stop();
                    check_win();
                }
            }
            update();


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bet = Int32.Parse(this.textBox1.Text);
            bet_size += bet;
            this.label_err.Hide();
            if (bet > this.points)
            {
                this.label_err.Show();

            }
            else if (bet_size < 0)
            {
                this.label_err.Show();
            }
            else
            {
                this.points -= bet;
            }
            update();
        }

        private void stand_button_Click(object sender, EventArgs e)
        {
            this.button1.Hide();
            if (bet_size > 0)
            {
                this.timer1.Start();
                this.dealer_on = true;
            }
            else
            {
                this.label_bet_err.Show();
            }
            update();

        }
        private void check_win()
        {

            if (this.dealer_score > 21)
            {
                Form3 noweOkno2 = new Form3(this);
                noweOkno2.ShowDialog();
                points += bet_size * 2;
            }
            else if (this.hand_score <= this.dealer_score)
            {
                Form2 noweOkno = new Form2(this);
                noweOkno.ShowDialog();
            }
            else if (this.hand_score > this.dealer_score)
            {
                Form3 noweOkno2 = new Form3(this);
                noweOkno2.ShowDialog();
                points += bet_size * 2;
            }


        }

        private void zegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void zegar_value_Click(object sender, EventArgs e)
        {

        }

        // Timer do obsługi zegara
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isDigital)
            {
                digital_value.Text = DateTime.Now.ToString("HH:mm:ss");
                digital_value.Visible = true;
                analog_value.Visible = false;
            }
            else
            {
                digital_value.Visible = false;
                analog_value.Visible = true;
                analog_value.Invalidate();
            }
        }

        private void cyfrowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDigital = true;
        }

        private void analogowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDigital = false;
        }

        // Funkcja do rysowania zegara analogowego
        private void analog_value_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DateTime now = DateTime.Now;
            int centerX = analog_value.Width / 2;
            int centerY = analog_value.Height / 2;
            int radius = Math.Min(centerX, centerY) - 5;

            // Wypełnienie tarczy
            using (Brush whiteBrush = new SolidBrush(Color.White))
            {
                g.FillEllipse(whiteBrush, centerX - radius, centerY - radius, radius * 2, radius * 2);
            }

            // Obramówka tarczy
            using (Pen thickCircle = new Pen(Color.Black, 3.5f)) 
            {
                g.DrawEllipse(thickCircle, centerX - radius, centerY - radius, radius * 2, radius * 2);
            }


            // Rozmieszczenie kresek dookoła tarczy zegara
            for (int i = 0; i < 12; i++)
            {
                double angle = Math.PI * i / 6;
                int innerRadius = radius - 10;
                int outerRadius = radius;

                int x1 = centerX + (int)(innerRadius * Math.Sin(angle));
                int y1 = centerY - (int)(innerRadius * Math.Cos(angle));
                int x2 = centerX + (int)(outerRadius * Math.Sin(angle));
                int y2 = centerY - (int)(outerRadius * Math.Cos(angle));

                using (Pen tickPen = new Pen(Color.Black, 2f))
                {
                    g.DrawLine(tickPen, x1, y1, x2, y2);
                }
            }
            
            // Wykorzystanie funkcji do rysowania wszytskich wskazówek
            DrawHand(g, now.Second * 6, radius - 10, Color.Red, 2f, centerX, centerY);                      // wskazowka sekundowa
            DrawHand(g, now.Minute * 6, radius - 20, Color.Black, 3f, centerX, centerY);                    // wskazowka minutowa
            DrawHand(g, now.Hour * 30 + now.Minute / 2, radius - 30, Color.Black, 3.5f, centerX, centerY);  // wskazowka godzinowa

            using (Font font = new Font("Arial", 12, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                // Zapisywanie cyfer na cyferblacie
                g.DrawString("12", font, brush, centerX - 13, centerY - radius + 10);              
                g.DrawString("3", font, brush, centerX + radius - 24, centerY - 10);              
                g.DrawString("6", font, brush, centerX - 7, centerY + radius - 28);              
                g.DrawString("9", font, brush, centerX - radius + 10, centerY - 10);                
            }
        }

        //Funkcja rysująca wskazowki zegara analogowego z zaleznosci trygonometrycznych
        private void DrawHand(Graphics g, float angleDegrees, int length, Color color, float thickness, int cx, int cy)
        {
            double angleRad = Math.PI * angleDegrees / 180.0; // Zamiana ze stopni na radiany
            // Obliczanie punktu końcowego linii ktora bedzie rysowana
            int x = cx + (int)(length * Math.Sin(angleRad));  
            int y = cy - (int)(length * Math.Cos(angleRad));
            // Faktyczne rysowanie linii
            using (Pen pen = new Pen(color, thickness))
            {
                g.DrawLine(pen, cx, cy, x, y);
            }
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.stolik;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void granatowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] imageData = Properties.Resources.text_2;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                this.BackgroundImage = Image.FromStream(ms);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void bordowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] imageData = Properties.Resources.text_3;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                this.BackgroundImage = Image.FromStream(ms);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }

}
