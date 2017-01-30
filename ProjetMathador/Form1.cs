using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            button.Enabled = false;     //Impossibilité de cliquer 2 fois sur le même bouton

            //Si les champs sont vides, ils prennent la valeur du bouton cliqué
            if (this.operationN1.Text == "" || this.operationN2.Text == "")
            {
                //Si le bouton cliqué n'est pas vide, la couleur de son background change
                if (button.Text.Length != 0)
                {
                    button.BackColor = Color.LightBlue;
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
            else    //Sinon, on indique que l'on a déjà sélectionné l'opérateur et on indique lequel à l'utilisateur
            {
                operatorFirst = true;
                switch (operationCase)
                {
                    case 1:
                        this.btnPlus.BackColor = Color.LightBlue;
                        break;
                    case 2:
                        this.btnMinus.BackColor = Color.LightBlue;
                        break;
                    case 3:
                        this.btnMult.BackColor = Color.LightBlue;
                        break;
                    case 4:
                        this.btnDiv.BackColor = Color.LightBlue;
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

            //Nettoyage de l'historique
            this.history1.Text = "";
            this.history2.Text = "";
            this.history3.Text = "";
            this.history4.Text = "";

            //Association des nombres issus du JSON (conservés dans le Numbers numbers)
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

            //Réinitialisation des compteurs d'opérateur pour le coup mathador
            this.plusUsed = false;
            this.minusUsed = false;
            this.timesUsed = false;
            this.divUsed = false;

            this.logs.Clear();
            tryCount = 0;
            ClearOperation();
        }

        public void Operation()
        {
            switch (operationCase)
            {
                //Addition
                case 1:
                    //Calcul
                    result = Convert.ToInt32(this.operationN1.Text) + Convert.ToInt32(this.operationN2.Text);

                    //Affichage du résultat dans le deuxième bouton tandis que le premier est effacé
                    this.numberPos[0].Text = "";
                    this.numberPos[1].Text = Convert.ToString(result);

                    //On compte un coup en plus
                    this.tryCount += 1;

                    //Définition de l'opérateur en String pour affichage interface
                    operatorStr = "+";

                    //Push du score du calcul (ici addition donc 1 point) dans la stack scores pour le calcul du score total en fin de manche
                    this.scores.Push(1);

                    //Définition du compteur d'opérateur pour un éventuel coup mathador
                    this.plusUsed = true;
                    break;
                //Soustraction
                case 2:
                    //Si le résultat du calcul est un négatif, on réinitialise la partie "Opération"
                    if ((Convert.ToInt32(this.operationN1.Text) - Convert.ToInt32(this.operationN2.Text)) < 0)
                    {
                        //Arrêt du chrono et affichage d'une fenêtre d'erreur
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
                    else    //Sinon, on calcule
                    {
                        result = Convert.ToInt32(this.operationN1.Text) - Convert.ToInt32(this.operationN2.Text);

                        //Affichage du résultat dans le deuxième bouton tandis que le premier est effacé
                        this.numberPos[0].Text = "";
                        this.numberPos[1].Text = Convert.ToString(result);
                        this.tryCount += 1;

                        //Définition de l'opérateur en String pour affichage interface
                        operatorStr = "-";

                        //Push du score du calcul (ici soustraction donc 2 points) dans la stack scores pour calcul du score total en fin de manche
                        this.scores.Push(2);

                        //Passage du compteur d'opérateur à true pour éventuel coup mathador
                        this.minusUsed = true;
                    }
                    break;
                //Multiplication
                case 3:
                    //Calcul
                    result = Convert.ToInt32(this.operationN1.Text) * Convert.ToInt32(this.operationN2.Text);

                    //Affichage du résultat dans le deuxième bouton tandis que le premier est effacé
                    this.numberPos[0].Text = "";
                    this.numberPos[1].Text = Convert.ToString(result);

                    //On compte un coup en plus
                    this.tryCount += 1;

                    //Définition de l'opérateur en String pour affichage interface
                    operatorStr = "x";

                    //Push du score du calcul (ici multiplication donc 1 point) dans la stack scores pour calcul du score total en fin de manche
                    this.scores.Push(1);

                    //Passage du compteur d'opérateur à true pour éventuel coup mathador
                    this.timesUsed = true;
                    break;
                //Division
                case 4:
                    //Si le modulo de l'opération est 0 (et donc que la division retourne un entier), on calcule
                    if ((Convert.ToInt32(this.operationN1.Text) % Convert.ToInt32(this.operationN2.Text)) == 0)
                    {
                        result = Convert.ToInt32(this.operationN1.Text) / Convert.ToInt32(this.operationN2.Text);

                        //Affichage du résultat dans le deuxième bouton tandis que le premier est effacé
                        this.numberPos[0].Text = "";
                        this.numberPos[1].Text = Convert.ToString(result);

                        //On avance d'un coup
                        this.tryCount += 1;

                        ////Définition de l'opérateur en string pour affichage interface
                        operatorStr = "÷";

                        //Push du score du calcul (ici division donc 3) pour calucl du score total en fin de manche
                        this.scores.Push(3);

                        //Passage du compteur d'opérateur à true pour un éventuel coup mathador
                        this.divUsed = true;
                    }
                    else
                    {
                        //Sinon, on stoppe le timer
                        second.Stop();
                        //On affiche l'erreur dans une messageBox
                        DialogResult onlyInt;
                        onlyInt = MessageBox.Show("Merci de ne faire que des divisons ayant pour résultat un entier.",
                            "Attention !",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        if (onlyInt == DialogResult.OK)
                        {
                            //Puis on réinitialise les boutons sélectionnés et la partie "Opération" en général
                            foreach (Button number in numberPos)
                            {
                                number.Enabled = true;
                            }
                            ClearOperation();
                            //Enfin, on redémarre le timer
                            second.Start();
                        }
                    }
                    break;
                default:
                    //Si aucun des cas ne convient, on retourne un message d'erreur dans la console et on réinitialise la partie "Opération"
                    Console.WriteLine("ERROR - INVALID OPERATION");
                    ClearOperation();
                    break;
            }

            //Si le switch case a retourné un résultat (donc que result n'est plus initialisé à -1)
            if (result != -1)
            {
                //On rend la deuxième case utilisée de nouveau cliquable (celle dans laquelle le résultat va être affiché pour être réutilisé)
                numberPos[1].Enabled = true;

                //On initialise un Calcul calcul avec les paramètres du calcul effectué (les 2 opérants, le résultat et l'opérateur) avant de la sérialiser
                Calcul calcul = new Calcul(Convert.ToInt32(this.operationN1.Text), Convert.ToInt32(this.operationN2.Text), result, this.operationCase);
                Log log = new Log(calcul, this.numberPos[0], this.numberPos[1]);

                this.logs.Push(log);

                string json = JsonConvert.SerializeObject(calcul.number1 + " " + operatorStr + " " + calcul.number2 + " = " + calcul.result);
                json = json.Replace("\"", "");

                //On affiche le résultat de la sérialisation (donc la calcul sous forme "a + b = c") dans le premier label de l'historique vide
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

                //Si on trouve le résultat ou si on a effectué nos 4 opérations, on arrête la manche
                if (result == Convert.ToInt32(this.target.Text) || tryCount == 4)
                {
                    //Si on trouve le résultat...
                    if (result == Convert.ToInt32(this.target.Text))
                    {
                        //... on destack scores pour ajouter chacune de ses valeurs dans l'int score qui déterminera le score total de la partie
                        while (scores.Count() > 0)
                        {
                            this.score += scores.Pop();
                        }

                        //Si tous les compteurs d'opérateurs ont été passés à true durant cette manche, on compte un coup mathador et on ajoute donc 6 points au score de la manche pour arriver à un total de 13
                        if (plusUsed && minusUsed && timesUsed && divUsed)
                        {
                            mathador = "Vous avez fait un coup mathador ! Vous voilà gratifié de 13 points pour cette manche !\n";
                            score += 6;
                        }

                        //On arrête le timer
                        second.Stop();
                        //On affiche un message box qui indique son score à l'utilisateur
                        DialogResult victory;
                        victory = MessageBox.Show(mathador + "Bravo !\nVoilà votre score : " + score,
                                "Nombre trouvé !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        if (victory == DialogResult.OK)
                        {
                            //On re-génère tous les nombres, on redémarre le timer et on réinitialise le compteur de mathador pour commencer un nouvelle manche
                            generateNumbers();
                            mathador = "";
                            second.Start();
                        }
                    }
                    //Si on a effectué nos 4 opérations
                    if (tryCount == 4)
                    {
                        //On arrête le timer
                        second.Stop();
                        //On affiche un message box qui indique à l'utilisateur qu'il n'a pas gagné cette manche
                        DialogResult loose;
                        loose = MessageBox.Show("Vous n'avez pas réussi à trouver le bon nombre",
                                "Échec",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        if (loose == DialogResult.OK)
                        {
                            //On re-génère tous les nombres, on redémarre le timer, on efface les scores de cette manche pour commencer une nouvelle manche
                            generateNumbers();
                            this.scores.Clear();
                            second.Start();
                        }
                    }
                }
            }
            //Quel que soit le cas, on réinitialise la partie "Opération"
            ClearOperation();
        }

        private void order()
        {
            //On récupère aussi toutes les lignes du fichier contenant les HighScores, en stockant chaque ligne dans une case du tableau
            string[] lines = System.IO.File.ReadAllLines(@"..\..\LeaderBoard.txt");

            /*On passe dans chaque case du tableau, donc dans chaque ligne, et on les Deserialize une par une en les stockant
            * en tant qu'objet Leaderboard, dans une liste de Leaderboard.
            * On vérifie que la ligne ne soit pas vide malgré tout.
            */
            List<Leaderboard> leaderboards = new List<Leaderboard>();
            foreach (string line in lines)
            {
                if (line != "" && line != " ")
                {
                    Leaderboard leaderboard = JsonConvert.DeserializeObject<Leaderboard>(line);
                    leaderboards.Add(leaderboard);
                }
            }

            //On crée la query qui va nous permettre de trier les objets par leur score décroissant, c'st à dire avoir un vrai classement
            IEnumerable<Leaderboard> sortedLeaderboard =
                from lead in leaderboards
                orderby lead.score descending
                select lead;

            //Cette ligne sert à effacer tout ce qui se trouve dans le fichier pour pouvoir réécrire tous les HighScores de façon "triés"
            System.IO.File.WriteAllText(@"..\..\LeaderBoard.txt", "");

            //On parcourt la liste de LeaderBoard maintenant triée pour pouvoir écrire les HighScores dans le fichier pour avoir un classement.
            foreach (Leaderboard lead in sortedLeaderboard)
            {
                //On reserialize donc l'objet pour pouvoir l'écrire dans le fichier.
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
        private void help_Click(object sender, EventArgs e)
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

            //On récupère aussi toutes les lignes du fichier contenant les HighScores, en stockant chaque ligne dans une case du tableau
            string[] lines = System.IO.File.ReadAllLines(@"..\..\LeaderBoard.txt");

            /*On passe dans chaque case du tableau, donc dans chaque ligne, et on les Deserialize une par une en les stockant
            * en tant qu'objet Leaderboard, dans une liste de Leaderboard.
            * On vérifie que la ligne ne soit pas vide malgré tout.
            */
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

                //On affichera seulement les 10 meilleurs scores du fichier
                if (i > 10)
                    break;
                //Création du label
                Label label = new Label();
                //Nommage selon i (score1, score2, etc...)
                label.Name = "score" + Convert.ToString(i);
                //Remplissage avec le pseudo puis le score
                label.Text = Convert.ToString(lead.pseudo) + " : " + Convert.ToString(lead.score) + " points.";
                //Positionnement dans le panel sur les axes x et y avec un espacement de 20 en y
                label.Location = new Point(1, (i * 20));
                //Définition automatique de la taille du label
                label.AutoSize = true;
                //Ajout du label au panel
                this.scoresDisplay.Controls.Add(label);
            }

        }

        //Retours au menu principal
        private void backMenu_Click(object sender, EventArgs e)
        {
            //On autorise la modification du pseudo
            this.pseudo.Enabled = true;
            //Réinitialisation de la partie "Opération"
            ClearOperation();
            //Gestion des panels
            this.Game.Visible = false;
            this.mainPanel.Visible = false;
            this.welcomePanel.Visible = true;
            //Réinitialisation et arrêt du timer
            this.graphicTimer.Value = 0;
            timerSeconds = 0;
            this.seconds.Text = "00";
            timerMinutes = 3;
            this.minutes.Text = "3";
            second.Stop();
            second.Enabled = false;
            //Fin de la partie
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

        //Démarrer une nouvelle manche
        private void generate_Click(object sender, EventArgs e)
        {
            generateNumbers();
            this.scores.Clear();

            //Si le joueur est à la prmière manche
            if (started == false)
            {
                started = true;

                //Blocage de la modification du pseudo
                this.pseudo.Enabled = false;

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

        //Annuler
        private void clear_Click(object sender, EventArgs e)
        {
            ClearOperation();
        }

        //Rejouer le coup précédent
        private void undo_Click(object sender, EventArgs e)
        {
            if (tryCount > 0)    //On vérifie que l'on a déjà joué un coup
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

                //Les boutons concernés sont de nouveau cliquables
                foreach (Button number in numberPos)
                {
                    number.Enabled = true;
                }

                this.numberPos[0].Text = Convert.ToString(backLog.calcul.number1);
                this.numberPos[1].Text = Convert.ToString(backLog.calcul.number2);
                this.numberPos.Clear();
                //On revient en arrière
                this.tryCount -= 1;
            }
        }

        //Timer
        private void second_Tick(object sender, EventArgs e)
        {
            //Initialisaion de la base SQLite
            SQLiteConnection.CreateFile("DB.sqlite");
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            /* On considère que le fichier ".sqlite" est déjà créé.
            * Je n'ai pas vraiment eu le temps de travailler sur la base de donnée. Je pense qu'elle marche,
            * mais j'avoue l'avoir oublié pendant notre développement.
            * Elle n'est pas très aboutie et quelque peu simpliste.
            */

            //À chaque tic, on incrémente la valeur de la progress bar de 1
            this.graphicTimer.Value++;
            //Et on décrémente le compteur de secondes
            timerSeconds--;
            if (timerSeconds < 0)
            {
                timerSeconds = 59;
                timerMinutes--;
                this.minutes.Text = Convert.ToString(timerMinutes);
            }
            //Si le compteur des secondes descend en dessous de 10, on rajoute un 0 devant le chiffre restant (pour avoir "X:06" et non "X:6")
            if (timerSeconds < 10)
            {
                this.seconds.Text = "0" + Convert.ToString(timerSeconds);
            }
            else
            {
                this.seconds.Text = Convert.ToString(timerSeconds);
            }
            //Si le compteur de secondes et le compteur de minutes sont tous les deux à 0...
            if (timerSeconds == 0 && timerMinutes == 0)
            {
                //... on arrête le timer
                second.Stop();
                //... et on indique à l'utilisateur que le temps est écoulé grâce à une message box
                DialogResult timesUp;
                //On indique son score à l'utilisateur
                timesUp = MessageBox.Show("Temps écoulé ! Merci d'avoir joué, voici votre score : " + this.score + " points.",
                    "Fin du temps !",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Information);
                //Si on clique sur "Réessayer" on recommence directement une nouvelle partie (avec le même pseudo)
                if (timesUp == DialogResult.Retry)
                {
                    started = false;
                    generate_Click(sender, e);
                    timerMinutes = 3;
                    timerSeconds = 0;
                    this.graphicTimer.Value = 0;
                }
                //Sinon on revient à la saisie du pseudo
                else
                {
                    started = false;
                    ClearOperation();
                    this.mainPanel.Visible = false;
                    this.pseudo.Enabled = true;
                }

                //Récupération du score total à la fin de la partie
                int scoreText = this.score;

                //Création d'un objet pseudo + score pour la sérialisation
                Leaderboard actualLeaderboard = new Leaderboard(this.pseudo.Text, scoreText);

                //Insertion du pseudo et du score en base de données avec la fonction Parameters
                SQLiteCommand comm = m_dbConnection.CreateCommand();
                comm.CommandText = "INSERT into leaderboard (nickname, score) values (@nickname, @score)";
                comm.Parameters.Add(new SQLiteParameter("@nickname", this.pseudo.Text));
                comm.Parameters.Add(new SQLiteParameter("@score", this.score));
                comm.ExecuteNonQuery();
                m_dbConnection.Close();

                //Sérialisation
                string json = JsonConvert.SerializeObject(actualLeaderboard);

                //Écriture dans le fichier LeaderBoard à la suite du contenu existant
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Ingesup\Cours_3eme\C#\projetmathador\ProjetMathador\LeaderBoard.txt", true))
                {
                    file.WriteLine(json + "\n");
                }

                //Tri des scores
                order();

                //Réinitialisation du score
                this.score = 0;
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

    public class Calcul         //Objet calcul stockant toutes les informations relatives à un calcul, à savoir les deux nombres, le résultat, et l'opérateur.
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

    public class Log               //Objet Log qui stock un calcul ainsi que les boutons des nombres ayant permis de faire le calcul en question, pour pouvoir les réafficher à leur position en cas de retour au calcul précedent par l'utilisateur.
    {
        public Calcul calcul;
        public List<Button> numberPos = new List<Button>();                 //Liste des deux boutons des nombres du calcul.

        public Log(Calcul calcul, Button button1, Button button2)
        {
            this.calcul = calcul;
            this.numberPos.Add(button1);
            this.numberPos.Add(button2);
        }
    }

    public class Leaderboard        //Objet Leaderboard permettant de stocker les scores et les pseudo afin de les réafficher dans le tableau des scores.
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
