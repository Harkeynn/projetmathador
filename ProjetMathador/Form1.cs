using Newtonsoft.Json;
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
        private bool plusUsed = false;
        private bool minusUsed = false;
        private bool timesUsed = false;
        private bool divUsed = false;
        private bool operatorFirst = false;
        private int operationCase = 0;
        private int score = 0;
        private int result = -1;
        private int timerSeconds = 0;
        private int timerMinutes = 3;
        private int tryCount = 0;
        private List<Button> numberPos = new List<Button>();
        private Stack<Log> logs = new Stack<Log>();
        private Stack<int> scores = new Stack<int>();
        private String operatorStr = null;
        private string mathador;

        //Génération aléatoire de nombres puis passage au format JSON
        public String RandString()
        {
            Random rand = new Random();
            String numbersJson = @"{'n1' : '" + rand.Next(1, 13) + "','n2' : '" + rand.Next(1, 13) + "','n3' : '" + rand.Next(1, 13) + "','n4' : '" + rand.Next(1, 21) + "','n5' : '" + rand.Next(1, 21) + "','target' : '" + rand.Next(1, 101) + "'}";
            return numbersJson;
        }
        
        //Nettoyage de la partie "Opération"
        public void ClearOperation()
        {
            //Les boutons concernés et qui n'ont pas déjà été utilisés (qui ne sont pas vides) sont de nouveau cliquables
            foreach (Button btn in numberPos)
            {
                btn.BackColor = Color.Transparent;
                if (btn.Text != "")
                {
                    btn.Enabled = true;
                }
            }

            //Remise à zéro des champs et du résultat
            this.operationN1.Text = "";
            this.operationN2.Text = "";
            result = -1;
            this.numberPos.Clear();
            ClearOperator();
            operatorFirst = false;
            this.operationCase = 0;
        }

        //Nettoyage de l'opérateur sélectionné (remise à zéro du background)
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
                    break;
            }
        }

        //Le bouton "GÉNÉRER" est cliquable
        public void EnableGenerate(object sender, EventArgs e)
        {
            this.generate.Enabled = true;
        }

        //Remplissage des champs de la partie "Opération"
        public void FillOperationN(String num, Button button)
        {
            button.Enabled = false; //Impossibilité de cliquer 2 fois sur le même bouton
            //Si les champs sont vides, ils prennent la valeur du bouton cliqué
            if (this.operationN1.Text == "" || this.operationN2.Text == "")
            {
                //Si le bouton cliqué n'est pas vide, la couleur de son background change
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
                //Si l'opérateur a déjà été sélectionné, on calcule le résultat et on rend les boutons concernés de nouveau cliquables
                if (this.operationN2.Text != "" && operatorFirst == true)
                {
                    Operation();
                    button.Enabled = true;
                }
            }

        }

        //Sélection de l'opérateur
        public void FillOperationO()
        {
            //Si les nombres ont déjà été sélectionnés, on calcule le résultat
            if (this.operationN2.Text.Length != 0)
            {
                Operation();
            }
            else //Sinon, on indique que l'on a déjà sélectionné l'opérateur et on indique lequel à l'utilisateur
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

        //Entrée des valeurs des nombres aléatoires sur les boutons
        public void generateNumbers()
        {
            String numbersJson = RandString();
            //Désérialisation du JSON 
            Numbers numbers = JsonConvert.DeserializeObject<Numbers>(numbersJson);
            this.history1.Text = "";
            this.history2.Text = "";
            this.history3.Text = "";
            this.history4.Text = "";

            this.target.Text = Convert.ToString(numbers.target);

            this.n1.Text = Convert.ToString(numbers.n1);
            this.n1.Enabled = true;

            this.n2.Text = Convert.ToString(numbers.n2);
            this.n2.Enabled = true;

            this.n3.Text = Convert.ToString(numbers.n3);
            this.n3.Enabled = true;

            this.n4.Text = Convert.ToString(numbers.n4);
            this.n4.Enabled = true;

            this.n5.Text = Convert.ToString(numbers.n5);
            this.n5.Enabled = true;
            
            this.logs.Clear();
            tryCount = 0;
            ClearOperation();
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

        public void order()
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\LeaderBoard.txt");

            List<Leaderboard> leaderboards = new List<Leaderboard>();

            foreach (string line in lines)
            {
                if (line != "" && line != " ")
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

            System.IO.File.WriteAllText(@"..\..\LeaderBoard.txt", "");
            foreach (Leaderboard lead in sortedLeaderboard)
            {
                string leadString = JsonConvert.SerializeObject(lead);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\LeaderBoard.txt", true))
                {
                    file.WriteLine(leadString + "\n");
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Gestion des panels
        //
        //Panel de jeu
        private void Jouer_Click(object sender, EventArgs e)
        {
            this.welcomePanel.Visible = false;
            this.Game.Visible = true;
        }

        //Panel d'aide
        private void toHelp_Click(object sender, EventArgs e)
        {
            this.helpPanel.Visible = true;
            this.welcomePanel.Visible = false;
        }

        //Panel des scores
        private void scoreBoard_Click(object sender, EventArgs e)
        {
            //Gestion des panels
            this.scoresPanel.Visible = true;
            this.welcomePanel.Visible = false;

            //Lecture du fichier LeaderBoard.txt puis passage de chaque ligne dans une liste de Leaderboards
            string[] lines = System.IO.File.ReadAllLines(@"..\..\LeaderBoard.txt");
            List<Leaderboard> leaderboards = new List<Leaderboard>();
            foreach (string line in lines)
            {
                if (line != "" && line != " ")
                {
                    Leaderboard leaderboard = JsonConvert.DeserializeObject<Leaderboard>(line);
                    leaderboards.Add(leaderboard);
                }
            }

            //Affichage des scores sous formes de labels
            int i = 0;
            foreach (Leaderboard lead in leaderboards)
            {
                i++;

                if (i > 10)
                    break;
                //Création du label
                Label label = new Label();
                //Nomage (score1, score2, etc...)
                label.Name = "score" + Convert.ToString(i);
                //Ajout et formatage du contenu
                label.Text = Convert.ToString(lead.pseudo) + " : " + Convert.ToString(lead.score) + " points.";
                //Positionnement
                label.Location = new Point(1, (i * 20));
                //Taille automatique
                label.AutoSize = true;
                //Ajout du label au panel
                this.scoresDisplay.Controls.Add(label);
            }

        }

        //Retours au menu principal
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
        private void helpBack_Click(object sender, EventArgs e)
        {
            this.helpPanel.Visible = false;
            this.welcomePanel.Visible = true;
        }
        private void scoreBoardBack_Click(object sender, EventArgs e)
        {
            this.scoresDisplay.Controls.Clear();
            this.scoresPanel.Visible = false;
            this.welcomePanel.Visible = true;
        }
        //

        //Quitter l'application
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boutons des opérateurs
        //
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
        //

        //Démarrer une nouvelle manche
        private void generate_Click(object sender, EventArgs e)
        {
            generateNumbers();
            this.logs.Clear();
            this.scores.Clear();
            tryCount = 0;
            ClearOperation();

            //Si le joueur est à la prmière manche
            if (started == false)
            {
                started = true;

                //Blocage de la modification du pseudo
                this.pseudo.ReadOnly = true;

                //Affichage du jeu
                this.mainPanel.Visible = true;

                //Réinitialisation et démarrage du timer
                timerMinutes = 3;
                timerSeconds = 0;
                second.Enabled = true;
                second.Start();
                this.graphicTimer.Value = 0;
            }
        }


        //Boutons des nombres générés
        //
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
        //

        //Annuler
        private void clear_Click(object sender, EventArgs e)
        {
            ClearOperation();
        }

        //Rejouer le coup précédent
        private void undo_Click(object sender, EventArgs e)
        {
            if (tryCount > 0) //On vérifie que l'on a déjà joué un coup
            {
                Log backLog = logs.Pop();
                this.scores.Pop();

                //Suppression de la dernière entrée de l'historique
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
                //Retour des nombres précédents sur les boutons concernés
                this.numberPos.Add(backLog.numberPos[0]);
                this.numberPos.Add(backLog.numberPos[1]);
                this.numberPos[0].Text = Convert.ToString(backLog.calcul.number1);
                this.numberPos[1].Text = Convert.ToString(backLog.calcul.number2);
                //Les boutons concernés sont de nouveau cliquables
                foreach (Button number in numberPos)
                {
                    number.Enabled = true;
                }
                this.numberPos.Clear();
                //On revient en arrière
                this.tryCount -= 1;
            }
        }

        //Timer
        private void second_Tick(object sender, EventArgs e)
        {
            // 1
            this.graphicTimer.Value++;
            // 2
            timerSeconds--;
            if (timerSeconds < 0)
            {
                timerSeconds = 00;
                timerMinutes--;
                this.minutes.Text = Convert.ToString(timerMinutes);
            }
            // 3
            if (timerSeconds < 10)
            {
                this.seconds.Text = "0" + Convert.ToString(timerSeconds);
            }
            else
            {
                this.seconds.Text = Convert.ToString(timerSeconds);
            }
            // 4
            if (timerSeconds == 0 && timerMinutes == 0)
            {
                // 4.1
                second.Stop();
                // 4.2
                DialogResult timesUp;
                timesUp = MessageBox.Show("Fin du temps !",
                    "Fin",
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
                    this.pseudo.ReadOnly = true;
                }


                //Récupération du score total à la fin de la partie
                int scoreText = this.score;

                //Création d'un objet pseudo + score pour la sérialisation
                Leaderboard actualLeaderboard = new Leaderboard(this.pseudo.Text, scoreText);
                
                //Sérialisation
                string json = JsonConvert.SerializeObject(actualLeaderboard);

                //Écriture dans le fichier LeaderBoard à la suite du contenu existant
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\LeaderBoard.txt", true))
                {
                    file.WriteLine(json + "\n");
                }

                //Tri des scores
                order();

                //Réinitialisation du score
                this.score = -1;
            }
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
