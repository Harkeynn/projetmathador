namespace ProjetMathador
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.operationN1 = new System.Windows.Forms.TextBox();
            this.operationN2 = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.operatorsPanel = new System.Windows.Forms.Panel();
            this.numbersPanel = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.timerlbl = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.timerpoints = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.graphicTimer = new System.Windows.Forms.ProgressBar();
            this.history4 = new System.Windows.Forms.Label();
            this.history3 = new System.Windows.Forms.Label();
            this.history2 = new System.Windows.Forms.Label();
            this.history1 = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Panel();
            this.pseudo = new System.Windows.Forms.TextBox();
            this.pseudolbl = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.Button();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Jouer = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.operatorsPanel.SuspendLayout();
            this.Game.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.SystemColors.Control;
            this.target.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.target.Enabled = false;
            this.target.Location = new System.Drawing.Point(3, 18);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(99, 13);
            this.target.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre cible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres à utiliser";
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(3, 70);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(40, 23);
            this.n1.TabIndex = 3;
            this.n1.Text = "n1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(49, 70);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(40, 23);
            this.n2.TabIndex = 4;
            this.n2.Text = "n2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(95, 70);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(40, 23);
            this.n3.TabIndex = 5;
            this.n3.Text = "n3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(140, 70);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(40, 23);
            this.n4.TabIndex = 6;
            this.n4.Text = "n4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(187, 70);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(40, 23);
            this.n5.TabIndex = 7;
            this.n5.Text = "n5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(8, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(44, 5);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 23);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(8, 34);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(30, 23);
            this.btnMult.TabIndex = 11;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(44, 34);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(30, 23);
            this.btnDiv.TabIndex = 12;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Opération";
            // 
            // operationN1
            // 
            this.operationN1.BackColor = System.Drawing.SystemColors.Control;
            this.operationN1.Enabled = false;
            this.operationN1.Location = new System.Drawing.Point(27, 149);
            this.operationN1.Name = "operationN1";
            this.operationN1.Size = new System.Drawing.Size(51, 20);
            this.operationN1.TabIndex = 15;
            // 
            // operationN2
            // 
            this.operationN2.BackColor = System.Drawing.SystemColors.Control;
            this.operationN2.Enabled = false;
            this.operationN2.Location = new System.Drawing.Point(180, 149);
            this.operationN2.Name = "operationN2";
            this.operationN2.Size = new System.Drawing.Size(51, 20);
            this.operationN2.TabIndex = 17;
            // 
            // generate
            // 
            this.generate.Enabled = false;
            this.generate.Location = new System.Drawing.Point(3, 50);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(260, 36);
            this.generate.TabIndex = 21;
            this.generate.Text = "GÉNÉRER";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.operatorsPanel);
            this.mainPanel.Controls.Add(this.clear);
            this.mainPanel.Controls.Add(this.operationN2);
            this.mainPanel.Controls.Add(this.operationN1);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.n5);
            this.mainPanel.Controls.Add(this.n4);
            this.mainPanel.Controls.Add(this.n3);
            this.mainPanel.Controls.Add(this.n2);
            this.mainPanel.Controls.Add(this.n1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.target);
            this.mainPanel.Controls.Add(this.undo);
            this.mainPanel.Controls.Add(this.timerlbl);
            this.mainPanel.Controls.Add(this.minutes);
            this.mainPanel.Controls.Add(this.timerpoints);
            this.mainPanel.Controls.Add(this.seconds);
            this.mainPanel.Controls.Add(this.graphicTimer);
            this.mainPanel.Controls.Add(this.history4);
            this.mainPanel.Controls.Add(this.history3);
            this.mainPanel.Controls.Add(this.history2);
            this.mainPanel.Controls.Add(this.history1);
            this.mainPanel.Location = new System.Drawing.Point(2, 87);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(404, 302);
            this.mainPanel.TabIndex = 22;
            this.mainPanel.Visible = false;
            // 
            // operatorsPanel
            // 
            this.operatorsPanel.Controls.Add(this.numbersPanel);
            this.operatorsPanel.Controls.Add(this.btnDiv);
            this.operatorsPanel.Controls.Add(this.btnMult);
            this.operatorsPanel.Controls.Add(this.btnMinus);
            this.operatorsPanel.Controls.Add(this.btnPlus);
            this.operatorsPanel.Location = new System.Drawing.Point(88, 129);
            this.operatorsPanel.Name = "operatorsPanel";
            this.operatorsPanel.Size = new System.Drawing.Size(82, 64);
            this.operatorsPanel.TabIndex = 27;
            // 
            // numbersPanel
            // 
            this.numbersPanel.Location = new System.Drawing.Point(-82, -82);
            this.numbersPanel.Name = "numbersPanel";
            this.numbersPanel.Size = new System.Drawing.Size(172, 23);
            this.numbersPanel.TabIndex = 28;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(96, 193);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(66, 23);
            this.clear.TabIndex = 26;
            this.clear.Text = "Annuler";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(69, 219);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(114, 23);
            this.undo.TabIndex = 28;
            this.undo.Text = "Rejouer dernier coup";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // timerlbl
            // 
            this.timerlbl.AutoSize = true;
            this.timerlbl.Location = new System.Drawing.Point(8, 258);
            this.timerlbl.Name = "timerlbl";
            this.timerlbl.Size = new System.Drawing.Size(74, 13);
            this.timerlbl.TabIndex = 22;
            this.timerlbl.Text = "Temps restant";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Location = new System.Drawing.Point(186, 257);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(13, 13);
            this.minutes.TabIndex = 24;
            this.minutes.Text = "3";
            // 
            // timerpoints
            // 
            this.timerpoints.AutoSize = true;
            this.timerpoints.Location = new System.Drawing.Point(195, 256);
            this.timerpoints.Name = "timerpoints";
            this.timerpoints.Size = new System.Drawing.Size(10, 13);
            this.timerpoints.TabIndex = 23;
            this.timerpoints.Text = ":";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Location = new System.Drawing.Point(202, 257);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(19, 13);
            this.seconds.TabIndex = 25;
            this.seconds.Text = "00";
            // 
            // graphicTimer
            // 
            this.graphicTimer.Location = new System.Drawing.Point(2, 274);
            this.graphicTimer.Maximum = 180;
            this.graphicTimer.Name = "graphicTimer";
            this.graphicTimer.Size = new System.Drawing.Size(392, 23);
            this.graphicTimer.TabIndex = 27;
            // 
            // history4
            // 
            this.history4.AutoSize = true;
            this.history4.Location = new System.Drawing.Point(278, 217);
            this.history4.Name = "history4";
            this.history4.Size = new System.Drawing.Size(43, 13);
            this.history4.TabIndex = 29;
            this.history4.Text = "history4";
            // 
            // history3
            // 
            this.history3.AutoSize = true;
            this.history3.Location = new System.Drawing.Point(278, 184);
            this.history3.Name = "history3";
            this.history3.Size = new System.Drawing.Size(43, 13);
            this.history3.TabIndex = 28;
            this.history3.Text = "history3";
            // 
            // history2
            // 
            this.history2.AutoSize = true;
            this.history2.Location = new System.Drawing.Point(278, 151);
            this.history2.Name = "history2";
            this.history2.Size = new System.Drawing.Size(43, 13);
            this.history2.TabIndex = 27;
            this.history2.Text = "history2";
            // 
            // history1
            // 
            this.history1.AutoSize = true;
            this.history1.Location = new System.Drawing.Point(278, 118);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(43, 13);
            this.history1.TabIndex = 26;
            this.history1.Text = "history1";
            // 
            // Game
            // 
            this.Game.BackColor = System.Drawing.Color.Transparent;
            this.Game.Controls.Add(this.pseudo);
            this.Game.Controls.Add(this.pseudolbl);
            this.Game.Controls.Add(this.BackMenu);
            this.Game.Controls.Add(this.generate);
            this.Game.Controls.Add(this.mainPanel);
            this.Game.Location = new System.Drawing.Point(12, 12);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(411, 395);
            this.Game.TabIndex = 23;
            this.Game.Visible = false;
            // 
            // pseudo
            // 
            this.pseudo.Location = new System.Drawing.Point(53, 28);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(210, 20);
            this.pseudo.TabIndex = 25;
            this.pseudo.TextChanged += new System.EventHandler(this.EnableGenerate);
            // 
            // pseudolbl
            // 
            this.pseudolbl.AutoSize = true;
            this.pseudolbl.Location = new System.Drawing.Point(5, 31);
            this.pseudolbl.Name = "pseudolbl";
            this.pseudolbl.Size = new System.Drawing.Size(49, 13);
            this.pseudolbl.TabIndex = 24;
            this.pseudolbl.Text = "Pseudo :";
            // 
            // BackMenu
            // 
            this.BackMenu.Location = new System.Drawing.Point(77, 1);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(114, 23);
            this.BackMenu.TabIndex = 23;
            this.BackMenu.Text = "Retour au Menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.welcomePanel.Controls.Add(this.exit);
            this.welcomePanel.Controls.Add(this.label5);
            this.welcomePanel.Controls.Add(this.button1);
            this.welcomePanel.Controls.Add(this.Jouer);
            this.welcomePanel.Location = new System.Drawing.Point(575, 12);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(274, 338);
            this.welcomePanel.TabIndex = 24;
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::ProjetMathador.Properties.Resources.buttonbackground;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(62, 300);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(146, 29);
            this.exit.TabIndex = 3;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 4);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(136, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mathador";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetMathador.Properties.Resources.buttonbackground;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aide";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Jouer
            // 
            this.Jouer.BackgroundImage = global::ProjetMathador.Properties.Resources.buttonbackground;
            this.Jouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jouer.FlatAppearance.BorderSize = 0;
            this.Jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jouer.Location = new System.Drawing.Point(62, 84);
            this.Jouer.Name = "Jouer";
            this.Jouer.Size = new System.Drawing.Size(146, 41);
            this.Jouer.TabIndex = 0;
            this.Jouer.Text = "Nouvelle Partie";
            this.Jouer.UseVisualStyleBackColor = true;
            this.Jouer.Click += new System.EventHandler(this.Jouer_Click);
            // 
            // second
            // 
            this.second.Interval = 1000;
            this.second.Tick += new System.EventHandler(this.second_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 413);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.Game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mathador";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.operatorsPanel.ResumeLayout(false);
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox operationN1;
        private System.Windows.Forms.TextBox operationN2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel Game;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Button Jouer;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timerlbl;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label timerpoints;
        private System.Windows.Forms.Timer second;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ProgressBar graphicTimer;
        private System.Windows.Forms.Panel operatorsPanel;
        private System.Windows.Forms.Panel numbersPanel;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Label pseudolbl;
        private System.Windows.Forms.TextBox pseudo;
        private System.Windows.Forms.Label history4;
        private System.Windows.Forms.Label history3;
        private System.Windows.Forms.Label history2;
        private System.Windows.Forms.Label history1;
    }
}

