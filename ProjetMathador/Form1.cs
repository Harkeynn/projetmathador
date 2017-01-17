using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMathador
{
    public partial class Form1 : Form
    {
        public class Serial
        {
            public String[] generatedNumbers { get; set; }
            public String[] results { get; set; }
            public int numberOfOperations { get; set; }
        }
        private int operationCase;
        Serial serial = new Serial();
        private Random rand = new Random();
        public int timerSeconds = 0;
        public int timerMinutes = 3;
        public String RandString(int from, int to)
        {
            String value = Convert.ToString(rand.Next(from, to));
            return value;
        }

        public void FillOperationN(String num)
        {
            if (this.operationN1.Text.Length == 0)
            {
                this.operationN1.Text = num;
            }
            else if (this.operationN2.Text.Length == 0)
            {
                this.operationN2.Text = num;
            }
        }

        public void FillOperationO(String o)
        {
            if (this.operationO.Text.Length == 0)
            {
                this.operationO.Text = o;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            switch (operationCase)
            {
                case 1:
                    this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) + Convert.ToInt32(this.operationN2.Text));
                    break;
                case 2:
                    this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) - Convert.ToInt32(this.operationN2.Text));
                    break;
                case 3:
                    this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) * Convert.ToInt32(this.operationN2.Text));
                    break;
                case 4:
                    this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) / Convert.ToInt32(this.operationN2.Text));
                    break;
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.target.Text = RandString(1, 101);
            this.n1.Text = RandString(1, 13);
            this.n2.Text = RandString(1, 13);
            this.n3.Text = RandString(1, 13);
            this.n4.Text = RandString(1, 21);
            this.n5.Text = RandString(1, 21);
            this.operationN1.Text = "";
            this.operationN2.Text = "";
            this.operationO.Text = "";
            this.result.Text = "";
            this.mainPanel.Visible = true;
            second.Enabled = true;
            second.Start();
        }

        private void target_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n1.Text);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n2.Text);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n3.Text);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n4.Text);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n5.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnPlus.Text);
            operationCase = 1;
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnMoins.Text);
            operationCase = 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnMult.Text);
            operationCase = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnDiv.Text);
            operationCase = 4;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

        }

        private void operationN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void operationO_TextChanged(object sender, EventArgs e)
        {

        }

        private void operationN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            //recup taille generatedNumbers et switch case pour cacher les boutons
        }

        private void Jouer_Click(object sender, EventArgs e)
        {
            this.welcomePanel.Visible = false;
            this.Game.Visible = true;
        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Game.Visible = false;
            this.welcomePanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void second_Tick(object sender, EventArgs e)
        {
            timerSeconds--;
            if (timerSeconds<0)
            {
                timerSeconds = 59;
                timerMinutes--;
                this.minutes.Text = Convert.ToString(timerMinutes);
            }

            if (timerSeconds < 10)
            {
                this.seconds.Text = "0" + Convert.ToString(timerSeconds);
            }
            else
            {
                this.seconds.Text = Convert.ToString(timerSeconds);
            }

            if(timerSeconds == 0 && timerMinutes == 0)
            {
                second.Stop();
                second.Enabled = false;
                DialogResult timesUp;
                timesUp = MessageBox.Show("Fin du temps !",
                    "Perdu",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Information);
                if (timesUp == System.Windows.Forms.DialogResult.Retry)
                {
                    generate_Click(sender, e);
                    timerMinutes = 3;
                    timerSeconds = 0;
                }
                else
                {
                    this.mainPanel.Visible = false;
                }
                
            }
        }
    }
}
