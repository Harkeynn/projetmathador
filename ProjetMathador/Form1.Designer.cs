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
            this.submit = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // target
            // 
            this.target.Enabled = false;
            this.target.Location = new System.Drawing.Point(3, 18);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(99, 20);
            this.target.TabIndex = 0;
            this.target.TextChanged += new System.EventHandler(this.target_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre cible";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres à utiliser";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(3, 70);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(30, 23);
            this.n1.TabIndex = 3;
            this.n1.Text = "n1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(39, 70);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(30, 23);
            this.n2.TabIndex = 4;
            this.n2.Text = "n2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(75, 70);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(30, 23);
            this.n3.TabIndex = 5;
            this.n3.Text = "n3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(111, 70);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(30, 23);
            this.n4.TabIndex = 6;
            this.n4.Text = "n4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(147, 70);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(30, 23);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // operationN1
            // 
            this.operationN1.Enabled = false;
            this.operationN1.Location = new System.Drawing.Point(7, 195);
            this.operationN1.Name = "operationN1";
            this.operationN1.Size = new System.Drawing.Size(26, 20);
            this.operationN1.TabIndex = 15;
            this.operationN1.TextChanged += new System.EventHandler(this.operationN1_TextChanged);
            // 
            // operationO
            // 
            this.operationO.Enabled = false;
            this.operationO.Location = new System.Drawing.Point(43, 195);
            this.operationO.Name = "operationO";
            this.operationO.Size = new System.Drawing.Size(26, 20);
            this.operationO.TabIndex = 16;
            this.operationO.TextChanged += new System.EventHandler(this.operationO_TextChanged);
            // 
            // operationN2
            // 
            this.operationN2.Enabled = false;
            this.operationN2.Location = new System.Drawing.Point(79, 195);
            this.operationN2.Name = "operationN2";
            this.operationN2.Size = new System.Drawing.Size(26, 20);
            this.operationN2.TabIndex = 17;
            this.operationN2.TextChanged += new System.EventHandler(this.operationN2_TextChanged);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(112, 201);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(131, 195);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(46, 20);
            this.result.TabIndex = 19;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 20);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(260, 36);
            this.generate.TabIndex = 21;
            this.generate.Text = "GÉNÉRER";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // mainPanel
            // 
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
            this.mainPanel.Location = new System.Drawing.Point(10, 74);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(262, 245);
            this.mainPanel.TabIndex = 22;
            this.mainPanel.Visible = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(182, 192);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 20;
            this.submit.Text = "Calculer";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(182, 219);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 21;
            this.next.Text = "Suivant";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 331);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.generate);
            this.Name = "Form1";
            this.Text = "Mathador";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
    }
}

