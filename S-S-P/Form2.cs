using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_S_P
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Rules.Text = "Правила:\n1.Играется как в обычные камень-ножницы-бумага.\n" +
                "2.У игрока и у бота(либо другого игрока, не факт) есть очки. В каждом раунде каждый делает ставку: 10% от очков - минимум и 30% от очков - максимум\n" +
                "3.Раунд делится на 2 стадии, которые определят выигравшего. В первой игроки делают депозит в размере 50 очков и играют. Во второй игроки могут поднять ставку, спасовать или играть дальше." +
                "4.Выигравшим считается тот, кто выиграл 3 раза";
        }
    }
}
