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


    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public String RandString(int from, int to)
        {
            String value = Convert.ToString(rand.Next(from, to));
            return value;
        }
        
        private int operationCase;
        Saved saved = new Saved();

        public void FillOperationN(String num)
        {
            if (this.operationN1.Text.Length == 0)
            {
                this.operationN1.Text = num;
            }
            else if (this.operationN2.Text.Length == 0)
            {
                this.operationN2.Text = num;
            }
        }

        public void FillOperationO(String o /*, POSITON DUBOUTON A SUPPRIMER*/)     //TODO : Voir plus bas.
        {
            if (this.operationO.Text.Length == 0)
            {
                this.operationO.Text = o;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
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
                    this.result.Text = Convert.ToString(Convert.ToInt32(this.operationN1.Text) / Convert.ToInt32(this.operationN2.Text));
                    break;
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
            FillOperationN(this.n1.Text);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n2.Text);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n3.Text /*, 3*/);       //TODO : METTRE UN DEUXIEME CHAMP INDIQUANT LA POSITION, POUR POUVOIR DESACTIVER LE BOUTON CLIQUE
        }

        private void n4_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n4.Text);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            FillOperationN(this.n5.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnPlus.Text);
            operationCase = 1;
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnMoins.Text);
            operationCase = 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnMult.Text);
            operationCase = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FillOperationO(this.btnDiv.Text);
            operationCase = 4;
        }

        private void next_Click(object sender, EventArgs e)
        {


            this.operationN1.Text = "";
            this.operationN2.Text = "";
            this.operationO.Text = "";
            this.result.Text = "";
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
    }
}
