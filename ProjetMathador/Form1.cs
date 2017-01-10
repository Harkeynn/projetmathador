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
        private Random rand = new Random();
        private List<Button> numberPos = new List<Button>();
        private int operationCase;
        private int tryCount = 0;
        Saved saved = new Saved();

        public String RandString(int from, int to)
        {
            String value = Convert.ToString(rand.Next(from, to));
            return value;
        }


        public void FillOperationN(String num, Button button)
        {
            if (this.operationN1.Text.Length == 0)
            {
                this.numberPos.Add(button);
                this.operationN1.Text = num;
            }
            else if (this.operationN2.Text.Length == 0)
            {
                this.numberPos.Add(button);
                this.operationN2.Text = num;
            }
        }

        public void FillOperator(String o)
        {
                this.operationO.Text = o;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(this.operationN1.Text != "" && this.operationN2.Text != "" && this.operationO.Text != "")
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
                        if((Convert.ToInt32(this.operationN1.Text) % Convert.ToInt32(this.operationN2.Text)) == 0)
                        {
                            this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) / Convert.ToInt32(this.operationN2.Text));
                        }else
                        {
                            MessageBox.Show("Merci de ne faire que des divisons ayant pour résultat un entier.",
                                "Attention !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        break;
                    default:
                        Console.WriteLine("ERROR IN THE CALCULATION");
                        break;
                }
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.target.Text = RandString(1, 101);


            this.n1.Text = RandString(1, 13);
            saved.addNumber(this.n1.Text, 0);

            this.n2.Text = RandString(1, 13);
            saved.addNumber(this.n2.Text, 1);

            this.n3.Text = RandString(1, 13);
            saved.addNumber(this.n3.Text, 2);

            this.n4.Text = RandString(1, 21);
            saved.addNumber(this.n4.Text, 3);

            this.n5.Text = RandString(1, 21);
            saved.addNumber(this.n5.Text, 4);

            this.operationN1.Text = "";
            this.operationN2.Text = "";
            this.operationO.Text = "";
            this.result.Text = "";
            this.mainPanel.Visible = true;
        }
        
        private void n1_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n1.Text, this.n1);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n2.Text, this.n2);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n3.Text, this.n3);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n4.Text, this.n4);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n5.Text, this.n5);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FillOperator(this.btnPlus.Text);
            operationCase = 1;
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            FillOperator(this.btnMoins.Text);
            operationCase = 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            FillOperator(this.btnMult.Text);
            operationCase = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FillOperator(this.btnDiv.Text);
            operationCase = 4;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                this.numberPos[0].Text = "";
                this.numberPos[1].Text = this.result.Text;

                this.operationN1.Text = "";
                this.operationN2.Text = "";
                this.operationO.Text = "";
                this.operationCase = 0;
                this.numberPos.Clear();

                tryCount += 1;

                if(this.result.Text == this.target.Text)
                {
                    MessageBox.Show("VICTOIRE TUTUTUTUTUTUT",
                                "Magnifique !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }

                this.result.Text = "";
            }
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

        private void clear_Click(object sender, EventArgs e)
        {
            this.operationN1.Text = "";
            this.operationN2.Text = "";
            this.operationO.Text = "";
            this.operationCase = 0;
            this.result.Text = "";
            this.numberPos.Clear();
        }
    }



    public class Saved
    {
        public string[] generatedNumbers = new string[5];
        public String[] results;
        public int numberOfOperations;

        public void addNumber(string nb, int pos)
        {
            this.generatedNumbers[pos] = nb;
        }
    }
}
