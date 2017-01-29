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
        private int operationCase;
        private Random rand = new Random();
        public int timerSeconds = 0;
        public int timerMinutes = 3;
        private List<Button> numberPos = new List<Button>();
        private Stack<Log> logs = new Stack<Log>();
        private int tryCount = 0;
        Saved saved = new Saved();

        public String RandString(int from, int to)
        {
            String value = Convert.ToString(rand.Next(from, to));
            return value;
        }

        public void FillOperationN(String num, Button button)
        {
            if(this.operationN1.Text == "" || this.operationN2.Text == "")
            {
                if(button.Text.Length != 0)
                {
                    button.BackColor = Color.Aqua;
                }
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
           
        }

        public void FillOperationO(String o, Button button)
        {
            if (this.operationO.Text.Length == 0)
            {
                this.operationO.Text = o;
                button.BackColor = Color.Aqua;
            }
        }

        public void ClearOperation()
        {
            foreach (Button btn in numberPos)
            {
                btn.BackColor = Color.Transparent;
            }
            this.operationN1.Text = "";
            this.operationN2.Text = "";
            this.operationO.Text = "";
            this.result.Text = "";
            this.numberPos.Clear();
            switch (operationCase)
            {
                case 1:
                    this.btnPlus.BackColor = Color.Transparent;
                    break;
                case 2:
                    this.btnMinus.BackColor = Color.Transparent;
                    break;
                case 3:
                    this.btnMult.BackColor = Color.Transparent;
                    break;
                case 4:
                    this.btnDiv.BackColor = Color.Transparent;
                    break;
                default:
                    Console.WriteLine("ERROR - IMPOSSIBLE TO CLEAR THE OPERATION");
                    break;
            }
            this.operationCase = 0;
        }

        public Form1()
        {
            InitializeComponent();
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

            ClearOperation();
            this.logs.Clear();
            this.mainPanel.Visible = true;
            timerMinutes = 3;
            timerSeconds = 0;
            second.Enabled = true;
            second.Start();
            this.graphicTimer.Value = 0;
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
            operationCase = 1;
            FillOperationO(this.btnPlus.Text, this.btnPlus);
            this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) + Convert.ToInt32(this.operationN2.Text));
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnMinus.Text, this.btnMinus);
            operationCase = 2;
            if ((Convert.ToInt32(this.operationN1.Text) - Convert.ToInt32(this.operationN2.Text)) < 0)
            {
                DialogResult onlyPositive;
                onlyPositive = MessageBox.Show("Merci de ne faire que des soustractions ayant pour résultat un nombre positif.",
                    "Attention !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                if (onlyPositive == DialogResult.OK)
                {
                    ClearOperation();
                }
            }
            else
            {
                this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) - Convert.ToInt32(this.operationN2.Text));
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnMult.Text, this.btnMult);
            operationCase = 3;
            this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) * Convert.ToInt32(this.operationN2.Text));
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnDiv.Text, this.btnDiv);
            operationCase = 4;
            if ((Convert.ToInt32(this.operationN1.Text) % Convert.ToInt32(this.operationN2.Text)) == 0)
            {
                this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) / Convert.ToInt32(this.operationN2.Text));
            }
            else
            {
                DialogResult onlyInt;
                onlyInt = MessageBox.Show("Merci de ne faire que des divisons ayant pour résultat un entier.",
                    "Attention !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                if (onlyInt == DialogResult.OK)
                {
                    ClearOperation();
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                this.numberPos[0].Text = "";
                this.numberPos[1].Text = this.result.Text;
                ClearOperation();

                this.tryCount += 1;

                if (this.result.Text == this.target.Text || tryCount == 4)
                {
                    if (this.result.Text == this.target.Text)
                    {
                        second.Stop();
                        second.Enabled = false;
                        DialogResult victory;
                        victory = MessageBox.Show("VICTOIRE TUTUTUTUTUTUT",
                                "Magnifique !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        if (victory == DialogResult.OK)
                        {
                            backMenu_Click(sender, e);
                        }
                    }

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
            ClearOperation();
            this.Game.Visible = false;
            this.mainPanel.Visible = false;
            this.welcomePanel.Visible = true;
            this.graphicTimer.Value = 0;
            timerSeconds = 0;
            timerMinutes = 3;
            second.Stop();
            second.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void second_Tick(object sender, EventArgs e)
        {
            this.graphicTimer.Value++;
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
                if (timesUp == DialogResult.Retry)
                {
                    generate_Click(sender, e);
                    timerMinutes = 3;
                    timerSeconds = 0;
                    this.graphicTimer.Value = 0;
                }
                else
                {
                    ClearOperation();
                    this.mainPanel.Visible = false;
                }
                
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearOperation();
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

    public class Calcul
    {
        public int number1, number2, result, oper;

        public Calcul(int n1, int n2, int res, int oper)
        {
            this.number1 = n1;
            this.number2 = n2;
            this.result = res;
            this.oper = oper;
        }
    }

    public class Log
    {
        public Calcul calcul;
        public List<Button> numberPos = new List<Button>();

        public Log(Calcul calcul, Button button1, Button button2)
        {
            this.calcul = calcul;
            this.numberPos.Add(button1);
            this.numberPos.Add(button2);
        }
    }
}
