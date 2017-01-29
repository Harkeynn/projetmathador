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
        private bool started = false;
        private int result = -1;
        private int operationCase = 0;
        private bool operatorFirst = false;
        private Random rand = new Random();
        public int timerSeconds = 0;
        public int timerMinutes = 3;
        private List<Button> numberPos = new List<Button>();
        private Stack<Log> logs = new Stack<Log>();
        private int tryCount = 0;
        Saved saved = new Saved();

        public void EnableGenerate(object sender, EventArgs e)
        {
            this.generate.Enabled = true;
        }

        public String RandString(int from, int to)
        {
            String value = Convert.ToString(rand.Next(from, to));
            return value;
        }

        public void Operation()
        {
            switch (operationCase)
            {
                case 1:
                    result = Convert.ToInt32(this.operationN1.Text) + Convert.ToInt32(this.operationN2.Text);
                    this.numberPos[0].Text = "";
                    this.numberPos[1].Text = Convert.ToString(result);
                    this.tryCount += 1;
                    break;
                case 2:
                    if ((Convert.ToInt32(this.operationN1.Text) - Convert.ToInt32(this.operationN2.Text)) < 0)
                    {
                        second.Stop();
                        DialogResult onlyPositive;
                        onlyPositive = MessageBox.Show("Merci de ne faire que des soustractions ayant pour résultat un nombre positif.",
                            "Attention !",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        if (onlyPositive == DialogResult.OK)
                        {
                            ClearOperation();
                            second.Start();
                        }
                    }
                    else
                    {
                        result = Convert.ToInt32(this.operationN1.Text) - Convert.ToInt32(this.operationN2.Text);
                        this.numberPos[0].Text = "";
                        this.numberPos[1].Text = Convert.ToString(result);
                        this.tryCount += 1;
                    }
                    break;
                case 3:
                    result = Convert.ToInt32(this.operationN1.Text) * Convert.ToInt32(this.operationN2.Text);
                    this.numberPos[0].Text = "";
                    this.numberPos[1].Text = Convert.ToString(result);
                    this.tryCount += 1;
                    break;
                case 4:
                    if ((Convert.ToInt32(this.operationN1.Text) % Convert.ToInt32(this.operationN2.Text)) == 0)
                    {
                        result = Convert.ToInt32(this.operationN1.Text) / Convert.ToInt32(this.operationN2.Text);
                        this.numberPos[0].Text = "";
                        this.numberPos[1].Text = Convert.ToString(result);
                        this.tryCount += 1;
                    }
                    else
                    {
                        second.Stop();
                        DialogResult onlyInt;
                        onlyInt = MessageBox.Show("Merci de ne faire que des divisons ayant pour résultat un entier.",
                            "Attention !",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        if (onlyInt == DialogResult.OK)
                        {
                            ClearOperation();
                            second.Start();
                        }
                    }
                    break;
                default:
                    Console.WriteLine("ERROR - INVALID OPERATION");
                    ClearOperation();
                    break;
            }

            if (result == Convert.ToInt32(this.target.Text) || tryCount == 4)
            {
                if (result == Convert.ToInt32(this.target.Text))
                {
                    second.Stop();
                    DialogResult victory;
                    victory = MessageBox.Show("Bravo !",
                            "Nombre trouvé !",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    if (victory == DialogResult.OK)
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

                        this.logs.Clear();
                        tryCount = 0;
                        ClearOperation();
                        second.Start();
                    }
                }
                if (tryCount == 4)
                {
                    second.Stop();
                    DialogResult loose;
                    loose = MessageBox.Show("Vous n'avez pas réussi à trouver le bon nombre",
                            "Échec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    if (loose == DialogResult.OK)
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

                        this.logs.Clear();
                        tryCount = 0;
                        ClearOperation();
                        second.Start();
                    }
                }
            }
            ClearOperation();
        }
        
        public void FillOperationN(String num, Button button)
        {
            if (this.operationN1.Text == "" || this.operationN2.Text == "")
            {
                if (button.Text.Length != 0)
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
                if (this.operationN2.Text != "" && operatorFirst == true)
                {
                    Operation();
                }
            }

        }

        public void FillOperationO()
        {
            if (this.operationN2.Text.Length != 0)
            {
                Operation();
            }
            else
            {
                operatorFirst = true;
                switch (operationCase)
                {
                    case 1:
                        this.btnPlus.BackColor = Color.Aqua;
                        break;
                    case 2:
                        this.btnMinus.BackColor = Color.Aqua;
                        break;
                    case 3:
                        this.btnMult.BackColor = Color.Aqua;
                        break;
                    case 4:
                        this.btnDiv.BackColor = Color.Aqua;
                        break;
                    default:
                        Console.WriteLine("ERROR - IMPOSSIBLE TO CLEAR THE OPERATION");
                        break;
                }
            }
        }

        public void ClearOperator()
        {
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
        }

        public void ClearOperation()
        {
            foreach (Button btn in numberPos)
            {
                btn.BackColor = Color.Transparent;
            }
            this.operationN1.Text = "";
            this.operationN2.Text = "";
            result = -1;
            this.numberPos.Clear();
            ClearOperator();
            operatorFirst = false;
            this.operationCase = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void pseudo_LostFocus(object sender, EventArgs e)
        {
            if(this.pseudo.Text.Length != 0)
            {
                this.generate.Enabled = true;
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

            this.logs.Clear();
            tryCount = 0;
            ClearOperation();

            if (started == false)
            {
                this.pseudo.Enabled = false;
                started = true;
                this.mainPanel.Visible = true;
                timerMinutes = 3;
                timerSeconds = 0;
                second.Enabled = true;
                second.Start();
                this.graphicTimer.Value = 0;
            }
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
            ClearOperator();
            operationCase = 1;
            FillOperationO();
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            ClearOperator();
            operationCase = 2;
            FillOperationO();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            ClearOperator();
            operationCase = 3;
            FillOperationO();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ClearOperator();
            operationCase = 4;
            FillOperationO();
        }

        private void Jouer_Click(object sender, EventArgs e)
        {
            this.welcomePanel.Visible = false;
            this.Game.Visible = true;
        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.pseudo.Enabled = true;
            ClearOperation();
            this.Game.Visible = false;
            this.mainPanel.Visible = false;
            this.welcomePanel.Visible = true;
            this.graphicTimer.Value = 0;
            timerSeconds = 0;
            this.seconds.Text = "00";
            timerMinutes = 3;
            this.minutes.Text = "3";
            second.Stop();
            second.Enabled = false;
            started = false;
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
                    started = false;
                    generate_Click(sender, e);
                    timerMinutes = 3;
                    timerSeconds = 0;
                    this.graphicTimer.Value = 0;
                }
                else
                {
                    started = false;
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
