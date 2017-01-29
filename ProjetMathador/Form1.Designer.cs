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
            this.target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.operationN1 = new System.Windows.Forms.TextBox();
            this.operationO = new System.Windows.Forms.TextBox();
            this.operationN2 = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.undo = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Panel();
            this.BackMenu = new System.Windows.Forms.Button();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.Jouer = new System.Windows.Forms.Button();
            this.calcul1 = new System.Windows.Forms.Label();
            this.calcul2 = new System.Windows.Forms.Label();
            this.calcul3 = new System.Windows.Forms.Label();
            this.calcul4 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.Game.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // target
            // 
            this.target.Enabled = false;
            this.target.Location = new System.Drawing.Point(3, 18);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(99, 20);
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
            this.n1.Size = new System.Drawing.Size(39, 23);
            this.n1.TabIndex = 3;
            this.n1.Text = "n1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(48, 70);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(39, 23);
            this.n2.TabIndex = 4;
            this.n2.Text = "n2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(93, 70);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(39, 23);
            this.n3.TabIndex = 5;
            this.n3.Text = "n3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(138, 70);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(39, 23);
            this.n4.TabIndex = 6;
            this.n4.Text = "n4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(183, 70);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(39, 23);
            this.n5.TabIndex = 7;
            this.n5.Text = "n5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opérateurs";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(3, 128);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Location = new System.Drawing.Point(39, 128);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(30, 23);
            this.btnMoins.TabIndex = 10;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(75, 128);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(30, 23);
            this.btnMult.TabIndex = 11;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(111, 128);
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
            this.label4.Location = new System.Drawing.Point(4, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Opération";
            // 
            // operationN1
            // 
            this.operationN1.Enabled = false;
            this.operationN1.Location = new System.Drawing.Point(7, 195);
            this.operationN1.Name = "operationN1";
            this.operationN1.Size = new System.Drawing.Size(26, 20);
            this.operationN1.TabIndex = 15;
            // 
            // operationO
            // 
            this.operationO.Enabled = false;
            this.operationO.Location = new System.Drawing.Point(43, 195);
            this.operationO.Name = "operationO";
            this.operationO.Size = new System.Drawing.Size(26, 20);
            this.operationO.TabIndex = 16;
            // 
            // operationN2
            // 
            this.operationN2.Enabled = false;
            this.operationN2.Location = new System.Drawing.Point(79, 195);
            this.operationN2.Name = "operationN2";
            this.operationN2.Size = new System.Drawing.Size(26, 20);
            this.operationN2.TabIndex = 17;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(112, 198);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(131, 195);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(46, 20);
            this.result.TabIndex = 19;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(3, 33);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(260, 36);
            this.generate.TabIndex = 21;
            this.generate.Text = "GÉNÉRER";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.undo);
            this.mainPanel.Controls.Add(this.clear);
            this.mainPanel.Controls.Add(this.next);
            this.mainPanel.Controls.Add(this.submit);
            this.mainPanel.Controls.Add(this.result);
            this.mainPanel.Controls.Add(this.equal);
            this.mainPanel.Controls.Add(this.operationN2);
            this.mainPanel.Controls.Add(this.operationO);
            this.mainPanel.Controls.Add(this.operationN1);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.btnDiv);
            this.mainPanel.Controls.Add(this.btnMult);
            this.mainPanel.Controls.Add(this.btnMoins);
            this.mainPanel.Controls.Add(this.btnPlus);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.n5);
            this.mainPanel.Controls.Add(this.n4);
            this.mainPanel.Controls.Add(this.n3);
            this.mainPanel.Controls.Add(this.n2);
            this.mainPanel.Controls.Add(this.n1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.target);
            this.mainPanel.Location = new System.Drawing.Point(2, 87);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(262, 245);
            this.mainPanel.TabIndex = 22;
            this.mainPanel.Visible = false;
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(182, 159);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(75, 23);
            this.undo.TabIndex = 23;
            this.undo.Text = "Undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(182, 220);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 22;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(50, 219);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 21;
            this.next.Text = "Suivant";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(182, 193);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 25);
            this.submit.TabIndex = 20;
            this.submit.Text = "Calculer";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Game
            // 
            this.Game.Controls.Add(this.BackMenu);
            this.Game.Controls.Add(this.generate);
            this.Game.Controls.Add(this.mainPanel);
            this.Game.Location = new System.Drawing.Point(12, 12);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(267, 334);
            this.Game.TabIndex = 23;
            this.Game.Visible = false;
            // 
            // BackMenu
            // 
            this.BackMenu.Location = new System.Drawing.Point(77, 4);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(114, 23);
            this.BackMenu.TabIndex = 23;
            this.BackMenu.Text = "Retour au Menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.welcomePanel.Controls.Add(this.Jouer);
            this.welcomePanel.Location = new System.Drawing.Point(5, 12);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(274, 338);
            this.welcomePanel.TabIndex = 24;
            // 
            // Jouer
            // 
            this.Jouer.Location = new System.Drawing.Point(62, 137);
            this.Jouer.Name = "Jouer";
            this.Jouer.Size = new System.Drawing.Size(146, 62);
            this.Jouer.TabIndex = 0;
            this.Jouer.Text = "Jouons !";
            this.Jouer.UseVisualStyleBackColor = true;
            this.Jouer.Click += new System.EventHandler(this.Jouer_Click);
            // 
            // calcul1
            // 
            this.calcul1.AutoSize = true;
            this.calcul1.Location = new System.Drawing.Point(354, 12);
            this.calcul1.Name = "calcul1";
            this.calcul1.Size = new System.Drawing.Size(35, 13);
            this.calcul1.TabIndex = 25;
            this.calcul1.Text = "label5";
            // 
            // calcul2
            // 
            this.calcul2.AutoSize = true;
            this.calcul2.Location = new System.Drawing.Point(354, 45);
            this.calcul2.Name = "calcul2";
            this.calcul2.Size = new System.Drawing.Size(35, 13);
            this.calcul2.TabIndex = 26;
            this.calcul2.Text = "label5";
            // 
            // calcul3
            // 
            this.calcul3.AutoSize = true;
            this.calcul3.Location = new System.Drawing.Point(354, 78);
            this.calcul3.Name = "calcul3";
            this.calcul3.Size = new System.Drawing.Size(35, 13);
            this.calcul3.TabIndex = 27;
            this.calcul3.Text = "label6";
            // 
            // calcul4
            // 
            this.calcul4.AutoSize = true;
            this.calcul4.Location = new System.Drawing.Point(354, 110);
            this.calcul4.Name = "calcul4";
            this.calcul4.Size = new System.Drawing.Size(35, 13);
            this.calcul4.TabIndex = 28;
            this.calcul4.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 358);
            this.Controls.Add(this.calcul4);
            this.Controls.Add(this.calcul3);
            this.Controls.Add(this.calcul2);
            this.Controls.Add(this.calcul1);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.Game);
            this.Name = "Form1";
            this.Text = "Mathador";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.Game.ResumeLayout(false);
            this.welcomePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox operationN1;
        private System.Windows.Forms.TextBox operationO;
        private System.Windows.Forms.TextBox operationN2;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Panel Game;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Button Jouer;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Label calcul1;
        private System.Windows.Forms.Label calcul2;
        private System.Windows.Forms.Label calcul3;
        private System.Windows.Forms.Label calcul4;
    }
}

