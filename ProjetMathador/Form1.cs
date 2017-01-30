﻿using Newtonsoft.Json;
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
        private String operatorStr = null;
        private bool operatorFirst = false;
        public int timerSeconds = 0;
        public int timerMinutes = 3;
        private List<Button> numberPos = new List<Button>();
        private Stack<Log> logs = new Stack<Log>();
        private Stack<int> scores = new Stack<int>();
        private int score = 0;
        private int tryCount = 0;
        private bool plusUsed = false;
        private bool minusUsed = false;
        private bool timesUsed = false;
        private bool divUsed = false;
        private string mathador;
        Saved saved = new Saved();

        public void EnableGenerate(object sender, EventArgs e)
        {
            this.generate.Enabled = true;
        }

        public String RandString()
        {
            Random rand = new Random();
            String numbersJson = @"{'n1' : '" + rand.Next(1, 13) + "','n2' : '" + rand.Next(1, 13) + "','n3' : '" + rand.Next(1, 13) + "','n4' : '" + rand.Next(1, 21) + "','n5' : '" + rand.Next(1, 21) + "','target' : '" + rand.Next(1, 101) + "'}";
            return numbersJson;
        }

        public void generateNumbers()
        {
            String numbersJson = RandString();
            Numbers numbers = JsonConvert.DeserializeObject<Numbers>(numbersJson);
            this.history1.Text = "";
            this.history2.Text = "";
            this.history3.Text = "";
            this.history4.Text = "";

            this.target.Text = Convert.ToString(numbers.target);

            this.n1.Text = Convert.ToString(numbers.n1);
            this.n1.Enabled = true;
            saved.addNumber(this.n1.Text, 0);

            this.n2.Text = Convert.ToString(numbers.n2);
            this.n2.Enabled = true;
            saved.addNumber(this.n2.Text, 1);

            this.n3.Text = Convert.ToString(numbers.n3);
            this.n3.Enabled = true;
            saved.addNumber(this.n3.Text, 2);

            this.n4.Text = Convert.ToString(numbers.n4);
            this.n4.Enabled = true;
            saved.addNumber(this.n4.Text, 3);

            this.n5.Text = Convert.ToString(numbers.n5);
            this.n5.Enabled = true;
            saved.addNumber(this.n5.Text, 4);
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
                    operatorStr = "+";
                    this.scores.Push(1);
                    this.plusUsed = true;
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
                            foreach (Button number in numberPos)
                            {
                                number.Enabled = true;
                            }
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
                        operatorStr = "-";
                        this.scores.Push(2);
                        this.minusUsed = true;
                    }
                    break;
                case 3:
                    result = Convert.ToInt32(this.operationN1.Text) * Convert.ToInt32(this.operationN2.Text);
                    this.numberPos[0].Text = "";
                    this.numberPos[1].Text = Convert.ToString(result);
                    this.tryCount += 1;
                    operatorStr = "x";
                    this.scores.Push(1);
                    this.timesUsed = true;
                    break;
                case 4:
                    if ((Convert.ToInt32(this.operationN1.Text) % Convert.ToInt32(this.operationN2.Text)) == 0)
                    {
                        result = Convert.ToInt32(this.operationN1.Text) / Convert.ToInt32(this.operationN2.Text);
                        this.numberPos[0].Text = "";
                        this.numberPos[1].Text = Convert.ToString(result);
                        this.tryCount += 1;
                        operatorStr = "÷";
                        this.scores.Push(3);
                        this.divUsed = true;
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
                            foreach (Button number in numberPos)
                            {
                                number.Enabled = true;
                            }
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

            if (result != -1)
            {
                numberPos[1].Enabled = true;
                Calcul calcul = new Calcul(Convert.ToInt32(this.operationN1.Text), Convert.ToInt32(this.operationN2.Text), result, this.operationCase);
                Log log = new Log(calcul, this.numberPos[0], this.numberPos[1]);

                this.logs.Push(log);

                string json = JsonConvert.SerializeObject(calcul.number1 + " " + operatorStr + " " + calcul.number2 + " = " + calcul.result);
                json = json.Replace("\"", "");

                if (this.history1.Text == "")
                {
                    this.history1.Text = json;
                }
                else if (this.history2.Text == "")
                {
                    this.history2.Text = json;
                }
                else if (this.history3.Text == "")
                {
                    this.history3.Text = json;
                }
                else if (this.history4.Text == "")
                {
                    this.history4.Text = json;
                }

                Console.WriteLine(json);

                if (result == Convert.ToInt32(this.target.Text) || tryCount == 4)
                {
                    if (result == Convert.ToInt32(this.target.Text))
                    {
                        while (scores.Count() > 0)
                        {
                            this.score += scores.Pop();
                        }
                        if (plusUsed && minusUsed && timesUsed && divUsed)
                        {
                            mathador = "Vous avez fait un coup mathador ! Vous voilà gratifié de 13 points pour cette manche !\n";
                            score += 6;
                        }
                        second.Stop();
                        DialogResult victory;
                        victory = MessageBox.Show(mathador + "Bravo !\nVoilà votre score : " + score,
                                "Nombre trouvé !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        if (victory == DialogResult.OK)
                        {
                            generateNumbers();
                            mathador = "";
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
                            generateNumbers();
                            this.logs.Clear();
                            this.scores.Clear();
                            tryCount = 0;
                            ClearOperation();
                            second.Start();
                        }
                    }
                }
            }
            ClearOperation();
        }

        public void FillOperationN(String num, Button button)
        {
            button.Enabled = false;
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
                    button.Enabled = true;
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
                if (btn.Text != "")
                {
                    btn.Enabled = true;
                }
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
            if (this.pseudo.Text.Length != 0)
            {
                this.generate.Enabled = true;
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            generateNumbers();
            this.logs.Clear();
            this.scores.Clear();
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
            if (timerSeconds < 0)
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

            if (timerSeconds == 0 && timerMinutes == 0)
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

                int scoreText = this.score;

                Leaderboard actualLeaderboard = new Leaderboard(this.pseudo.Text, scoreText);

                string json = JsonConvert.SerializeObject(actualLeaderboard);
                //System.IO.File.WriteAllText(@"D:\Ingesup\Cours_3eme\C#\projetmathador\ProjetMathador\LeaderBoard.txt", json);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Ingesup\Cours_3eme\C#\projetmathador\ProjetMathador\LeaderBoard.txt", true))
                    {
                        file.WriteLine(json + "\n");
                    }

                order();

                this.score = 0;
            }
        }

        private void order()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Ingesup\Cours_3eme\C#\projetmathador\ProjetMathador\LeaderBoard.txt");

            List<Leaderboard> leaderboards = new List<Leaderboard>();

            foreach (string line in lines)
            {
                if(line != "" && line != " ")
                {
                    Leaderboard leaderboard = JsonConvert.DeserializeObject<Leaderboard>(line);
                    Console.WriteLine("Score du LeaderBoard : ");
                    Console.WriteLine(leaderboard.score);
                    leaderboards.Add(leaderboard);
                }
            }

            IEnumerable<Leaderboard> sortedLeaderboard =
                from lead in leaderboards
                orderby lead.score descending
                select lead;

            System.IO.File.WriteAllText(@"D:\Ingesup\Cours_3eme\C#\projetmathador\ProjetMathador\LeaderBoard.txt", "");
            foreach (Leaderboard lead in sortedLeaderboard)
            {
                string leadString = JsonConvert.SerializeObject(lead);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Ingesup\Cours_3eme\C#\projetmathador\ProjetMathador\LeaderBoard.txt", true))
                {
                    file.WriteLine(leadString + "\n");
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearOperation();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (tryCount > 0)
            {
                Log backLog = logs.Pop();
                this.scores.Pop();

                if (this.history2.Text == "")
                {
                    this.history1.Text = "";
                }
                else if (this.history3.Text == "")
                {
                    this.history2.Text = "";
                }
                else if (this.history4.Text == "")
                {
                    this.history3.Text = "";
                }

                ClearOperation();
                this.operationCase = backLog.calcul.oper;
                this.numberPos.Add(backLog.numberPos[0]);
                this.numberPos.Add(backLog.numberPos[1]);
                foreach (Button number in numberPos)
                {
                    number.Enabled = true;
                }
                this.numberPos[0].Text = Convert.ToString(backLog.calcul.number1);
                this.numberPos[1].Text = Convert.ToString(backLog.calcul.number2);
                this.numberPos.Clear();
                this.tryCount -= 1;
            }
        }

        private void helpBack_Click(object sender, EventArgs e)
        {
            this.helpPanel.Visible = false;
            this.welcomePanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.helpPanel.Visible = true;
            this.welcomePanel.Visible = false;
        }

        private void scoreBoard_Click(object sender, EventArgs e)
        {
            this.scoresPanel.Visible = true;
            this.welcomePanel.Visible = false;

            string[] lines = System.IO.File.ReadAllLines(@"D:\Ingesup\Cours_3eme\C#\projetmathador\ProjetMathador\LeaderBoard.txt");

            List<Leaderboard> leaderboards = new List<Leaderboard>();

            foreach (string line in lines)
            {
                if (line != "" && line != " ")
                {
                    Leaderboard leaderboard = JsonConvert.DeserializeObject<Leaderboard>(line);
                    leaderboards.Add(leaderboard);
                }
            }

            int i = 0;

            foreach (Leaderboard lead in leaderboards)
            {
                i++;

                if (i > 10)
                    break;

                Label label = new Label();
                label.Name = "score" + Convert.ToString(i);
                label.Text = Convert.ToString(lead.pseudo) + " : " + Convert.ToString(lead.score) + " points.";
                label.Location = new Point(1, (i*20));
                label.AutoSize = true;
                this.scoresDisplay.Controls.Add(label);
            }
            
        }

        private void scoreBoardBack_Click(object sender, EventArgs e)
        {
            this.scoresDisplay.Controls.Clear();
            this.scoresPanel.Visible = false;
            this.welcomePanel.Visible = true;
        }
    }



    public class Numbers
    {
        public int n1, n2, n3, n4, n5, target;
        public Numbers(int n1, int n2, int n3, int n4, int n5, int target)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
            this.n4 = n4;
            this.n5 = n5;
            this.target = target;
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

    public class Leaderboard
    {
        public string pseudo;
        public int score;

        public Leaderboard(string pseudo, int score)
        {
            this.pseudo = pseudo;
            this.score = score;
        }
    }
}
