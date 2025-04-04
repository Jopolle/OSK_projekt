using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class Form2 : Form
    {
        public Form2(Form1 f)
        {
            InitializeComponent();
            rodzic = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rodzic.rozdaj();
            this.Close();
        }
    }
}
