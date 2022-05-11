using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity;
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
                "2.У игрока и у бота, либо у другого игрока, есть очки в количестве 1000. В каждом раунде все делают ставку: 10% от очков - минимум и 30% от очков - максимум\n" +
                "3.Один раунд длится до 3-х побед одного игрока. В начале раунда игроки делают депозит в размере 50 очков и играют, после могут поднять ставку, спасовать или играть дальше.\n" +
                "4.Выигравшим считается тот, кто выиграл 3 раунда. Очки трех выигранных раундов суммируются и отправляются в таблицу лидеров.";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void StartWithBot_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();   
        }
    }
}
