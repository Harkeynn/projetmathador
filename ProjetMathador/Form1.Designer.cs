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
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.operationN1 = new System.Windows.Forms.TextBox();
            this.operationO = new System.Windows.Forms.TextBox();
            this.operationN2 = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // target
            // 
            this.target.Enabled = false;
            this.target.Location = new System.Drawing.Point(156, 36);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(100, 20);
            this.target.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre cible";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres à utiliser";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(12, 88);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(30, 23);
            this.n1.TabIndex = 3;
            this.n1.Text = "n1";
            this.n1.UseVisualStyleBackColor = true;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(48, 88);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(30, 23);
            this.n2.TabIndex = 4;
            this.n2.Text = "n2";
            this.n2.UseVisualStyleBackColor = true;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(84, 88);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(30, 23);
            this.n3.TabIndex = 5;
            this.n3.Text = "n3";
            this.n3.UseVisualStyleBackColor = true;
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(120, 88);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(30, 23);
            this.n4.TabIndex = 6;
            this.n4.Text = "n4";
            this.n4.UseVisualStyleBackColor = true;
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(156, 88);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(30, 23);
            this.n5.TabIndex = 7;
            this.n5.Text = "n5";
            this.n5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opérateurs";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 146);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMoins
            // 
            this.btnMoins.Location = new System.Drawing.Point(48, 146);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(30, 23);
            this.btnMoins.TabIndex = 10;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(84, 146);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(30, 23);
            this.btnMult.TabIndex = 11;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(120, 146);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(30, 23);
            this.btnDiv.TabIndex = 12;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 20);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 36);
            this.button10.TabIndex = 13;
            this.button10.Text = "GÉNÉRER";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Opération";
            // 
            // operationN1
            // 
            this.operationN1.Enabled = false;
            this.operationN1.Location = new System.Drawing.Point(16, 213);
            this.operationN1.Name = "operationN1";
            this.operationN1.Size = new System.Drawing.Size(26, 20);
            this.operationN1.TabIndex = 15;
            // 
            // operationO
            // 
            this.operationO.Enabled = false;
            this.operationO.Location = new System.Drawing.Point(52, 213);
            this.operationO.Name = "operationO";
            this.operationO.Size = new System.Drawing.Size(26, 20);
            this.operationO.TabIndex = 16;
            // 
            // operationN2
            // 
            this.operationN2.Enabled = false;
            this.operationN2.Location = new System.Drawing.Point(88, 213);
            this.operationN2.Name = "operationN2";
            this.operationN2.Size = new System.Drawing.Size(26, 20);
            this.operationN2.TabIndex = 17;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(121, 219);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(140, 213);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(46, 20);
            this.result.TabIndex = 19;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(197, 211);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 20;
            this.submit.Text = "Calculer";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.operationN2);
            this.Controls.Add(this.operationO);
            this.Controls.Add(this.operationN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.target);
            this.Name = "Form1";
            this.Text = "Mathador";
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
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox operationN1;
        private System.Windows.Forms.TextBox operationO;
        private System.Windows.Forms.TextBox operationN2;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button submit;
    }
}

