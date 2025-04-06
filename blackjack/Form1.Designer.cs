namespace blackjack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Karta> talia;
        private List<Karta> reka;
        private bool dealer_on = false;
        private int timer_counter = 0;
        private int points = 100;
        public int bet_size = 0;
        private int card_counter = 0;
        private int dealer_counter = 0;
        private int hand_score = 0;
        private int dealer_score = 0;
        private bool win_lose = false;
        private int bet = 0;
        private int ile_asow_gracz = 0;
        private int ile_asow_dealer = 0;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            hit_button = new Button();
            stand_button = new Button();
            label_value = new Label();
            textBox1 = new TextBox();
            label_bet = new Label();
            dealer1 = new PictureBox();
            dealer2 = new PictureBox();
            dealer3 = new PictureBox();
            dealer4 = new PictureBox();
            player4 = new PictureBox();
            player3 = new PictureBox();
            player2 = new PictureBox();
            player1 = new PictureBox();
            player5 = new PictureBox();
            dealer5 = new PictureBox();
            player6 = new PictureBox();
            dealer6 = new PictureBox();
            deal = new Button();
            label_chips = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label_err = new Label();
            label_bet_err = new Label();
            label_dealer_hand = new Label();
            ((System.ComponentModel.ISupportInitialize)dealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer6).BeginInit();
            SuspendLayout();
            // 
            // hit_button
            // 
            hit_button.Location = new Point(113, 617);
            hit_button.Margin = new Padding(3, 4, 3, 4);
            hit_button.Name = "hit_button";
            hit_button.Size = new Size(117, 148);
            hit_button.TabIndex = 0;
            hit_button.Text = "Hit";
            hit_button.UseVisualStyleBackColor = true;
            hit_button.Click += hit_button_Click;
            // 
            // stand_button
            // 
            stand_button.Location = new Point(256, 617);
            stand_button.Margin = new Padding(3, 4, 3, 4);
            stand_button.Name = "stand_button";
            stand_button.Size = new Size(117, 148);
            stand_button.TabIndex = 1;
            stand_button.Text = "Stand";
            stand_button.UseVisualStyleBackColor = true;
            stand_button.Click += stand_button_Click;
            // 
            // label_value
            // 
            label_value.AutoSize = true;
            label_value.Location = new Point(90, 534);
            label_value.Name = "label_value";
            label_value.Size = new Size(85, 20);
            label_value.TabIndex = 2;
            label_value.Text = "Hand Value";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(543, 678);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 27);
            textBox1.TabIndex = 3;
            // 
            // label_bet
            // 
            label_bet.AutoSize = true;
            label_bet.Location = new Point(410, 681);
            label_bet.Name = "label_bet";
            label_bet.Size = new Size(77, 20);
            label_bet.TabIndex = 4;
            label_bet.Text = "Bet Size: 0";
            // 
            // dealer1
            // 
            dealer1.BackColor = Color.Transparent;
            dealer1.BackgroundImageLayout = ImageLayout.None;
            dealer1.Location = new Point(93, 69);
            dealer1.Margin = new Padding(3, 4, 3, 4);
            dealer1.Name = "dealer1";
            dealer1.Size = new Size(120, 196);
            dealer1.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer1.TabIndex = 5;
            dealer1.TabStop = false;
            dealer1.Click += pictureBox1_Click;
            // 
            // dealer2
            // 
            dealer2.BackColor = Color.Transparent;
            dealer2.BackgroundImageLayout = ImageLayout.None;
            dealer2.Location = new Point(219, 69);
            dealer2.Margin = new Padding(3, 4, 3, 4);
            dealer2.Name = "dealer2";
            dealer2.Size = new Size(120, 196);
            dealer2.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer2.TabIndex = 6;
            dealer2.TabStop = false;
            // 
            // dealer3
            // 
            dealer3.BackColor = Color.Transparent;
            dealer3.BackgroundImageLayout = ImageLayout.None;
            dealer3.Location = new Point(346, 69);
            dealer3.Margin = new Padding(3, 4, 3, 4);
            dealer3.Name = "dealer3";
            dealer3.Size = new Size(120, 196);
            dealer3.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer3.TabIndex = 7;
            dealer3.TabStop = false;
            // 
            // dealer4
            // 
            dealer4.BackColor = Color.Transparent;
            dealer4.BackgroundImageLayout = ImageLayout.None;
            dealer4.Location = new Point(474, 69);
            dealer4.Margin = new Padding(3, 4, 3, 4);
            dealer4.Name = "dealer4";
            dealer4.Size = new Size(120, 196);
            dealer4.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer4.TabIndex = 8;
            dealer4.TabStop = false;
            // 
            // player4
            // 
            player4.BackColor = Color.Transparent;
            player4.BackgroundImageLayout = ImageLayout.None;
            player4.Location = new Point(474, 317);
            player4.Margin = new Padding(3, 4, 3, 4);
            player4.Name = "player4";
            player4.Size = new Size(120, 196);
            player4.SizeMode = PictureBoxSizeMode.StretchImage;
            player4.TabIndex = 12;
            player4.TabStop = false;
            // 
            // player3
            // 
            player3.BackColor = Color.Transparent;
            player3.BackgroundImageLayout = ImageLayout.None;
            player3.Location = new Point(346, 317);
            player3.Margin = new Padding(3, 4, 3, 4);
            player3.Name = "player3";
            player3.Size = new Size(120, 196);
            player3.SizeMode = PictureBoxSizeMode.StretchImage;
            player3.TabIndex = 11;
            player3.TabStop = false;
            // 
            // player2
            // 
            player2.BackColor = Color.Transparent;
            player2.BackgroundImageLayout = ImageLayout.None;
            player2.Location = new Point(219, 317);
            player2.Margin = new Padding(3, 4, 3, 4);
            player2.Name = "player2";
            player2.Size = new Size(120, 196);
            player2.SizeMode = PictureBoxSizeMode.StretchImage;
            player2.TabIndex = 10;
            player2.TabStop = false;
            player2.Click += pictureBox7_Click;
            // 
            // player1
            // 
            player1.BackColor = Color.Transparent;
            player1.BackgroundImageLayout = ImageLayout.None;
            player1.Location = new Point(93, 317);
            player1.Margin = new Padding(3, 4, 3, 4);
            player1.Name = "player1";
            player1.Size = new Size(120, 196);
            player1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1.TabIndex = 9;
            player1.TabStop = false;
            // 
            // player5
            // 
            player5.BackColor = Color.Transparent;
            player5.BackgroundImageLayout = ImageLayout.None;
            player5.Location = new Point(601, 317);
            player5.Margin = new Padding(3, 4, 3, 4);
            player5.Name = "player5";
            player5.Size = new Size(120, 196);
            player5.SizeMode = PictureBoxSizeMode.StretchImage;
            player5.TabIndex = 14;
            player5.TabStop = false;
            // 
            // dealer5
            // 
            dealer5.BackColor = Color.Transparent;
            dealer5.BackgroundImageLayout = ImageLayout.None;
            dealer5.Location = new Point(601, 69);
            dealer5.Margin = new Padding(3, 4, 3, 4);
            dealer5.Name = "dealer5";
            dealer5.Size = new Size(120, 196);
            dealer5.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer5.TabIndex = 13;
            dealer5.TabStop = false;
            // 
            // player6
            // 
            player6.BackColor = Color.Transparent;
            player6.BackgroundImageLayout = ImageLayout.None;
            player6.Location = new Point(728, 317);
            player6.Margin = new Padding(3, 4, 3, 4);
            player6.Name = "player6";
            player6.Size = new Size(120, 196);
            player6.SizeMode = PictureBoxSizeMode.StretchImage;
            player6.TabIndex = 16;
            player6.TabStop = false;
            // 
            // dealer6
            // 
            dealer6.BackColor = Color.Transparent;
            dealer6.BackgroundImageLayout = ImageLayout.None;
            dealer6.Location = new Point(728, 69);
            dealer6.Margin = new Padding(3, 4, 3, 4);
            dealer6.Name = "dealer6";
            dealer6.Size = new Size(120, 196);
            dealer6.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer6.TabIndex = 15;
            dealer6.TabStop = false;
            // 
            // deal
            // 
            deal.Location = new Point(410, 735);
            deal.Margin = new Padding(3, 4, 3, 4);
            deal.Name = "deal";
            deal.Size = new Size(57, 31);
            deal.TabIndex = 17;
            deal.Text = "Deal";
            deal.UseVisualStyleBackColor = true;
            deal.Click += deal_Click;
            // 
            // label_chips
            // 
            label_chips.AutoSize = true;
            label_chips.Location = new Point(410, 617);
            label_chips.Name = "label_chips";
            label_chips.Size = new Size(107, 20);
            label_chips.TabIndex = 18;
            label_chips.Text = "Your chips: 100";
            label_chips.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(627, 676);
            button1.Name = "button1";
            button1.Size = new Size(51, 29);
            button1.TabIndex = 19;
            button1.Text = "Bet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label_err
            // 
            label_err.AutoSize = true;
            label_err.Location = new Point(708, 680);
            label_err.Name = "label_err";
            label_err.Size = new Size(209, 20);
            label_err.TabIndex = 20;
            label_err.Text = "You don't have enough money";
            label_err.Click += label2_Click_1;
            // 
            // label_bet_err
            // 
            label_bet_err.AutoSize = true;
            label_bet_err.Location = new Point(545, 616);
            label_bet_err.Name = "label_bet_err";
            label_bet_err.Size = new Size(162, 20);
            label_bet_err.TabIndex = 21;
            label_bet_err.Text = "You have to bet to play";
            // 
            // label_dealer_hand
            // 
            label_dealer_hand.AutoSize = true;
            label_dealer_hand.Location = new Point(90, 272);
            label_dealer_hand.Name = "label_dealer_hand";
            label_dealer_hand.Size = new Size(133, 20);
            label_dealer_hand.TabIndex = 22;
            label_dealer_hand.Text = "Dealer Hand Value";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(950, 849);
            Controls.Add(label_dealer_hand);
            Controls.Add(label_bet_err);
            Controls.Add(label_err);
            Controls.Add(button1);
            Controls.Add(label_chips);
            Controls.Add(deal);
            Controls.Add(player6);
            Controls.Add(dealer6);
            Controls.Add(player5);
            Controls.Add(dealer5);
            Controls.Add(player4);
            Controls.Add(player3);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(dealer4);
            Controls.Add(dealer3);
            Controls.Add(dealer2);
            Controls.Add(dealer1);
            Controls.Add(label_bet);
            Controls.Add(textBox1);
            Controls.Add(label_value);
            Controls.Add(stand_button);
            Controls.Add(hit_button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer4).EndInit();
            ((System.ComponentModel.ISupportInitialize)player4).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer5).EndInit();
            ((System.ComponentModel.ISupportInitialize)player6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hit_button;
        private Button stand_button;
        private Label label_value;
        private TextBox textBox1;
        private Label label_bet;
        private PictureBox dealer1;
        private PictureBox dealer2;
        private PictureBox dealer3;
        private PictureBox dealer4;
        private PictureBox player4;
        private PictureBox player3;
        private PictureBox player2;
        private PictureBox player1;
        private PictureBox player5;
        private PictureBox dealer5;
        private PictureBox player6;
        private PictureBox dealer6;
        private Button deal;
        private Label label_chips;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label_err;
        private Label label_bet_err;
        private Label label_dealer_hand;
    }
}
