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
        List<string> generatedNumbers = new List<string>();
        private int operationCase;
        private Random rand = new Random();
        public String RandString(int from, int to)
        {
            String value = Convert.ToString(rand.Next(from, to));
            generatedNumbers.Add(value);
            return value;
        }

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
            foreach(var number in generatedNumbers)
            {
                if(number == num)
                {
                    generatedNumbers.Remove(number);
                }
            }
        }

        public void FillOperationO(String o)
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
            generatedNumbers.Add(this.result.Text);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.target.Text = RandString(1, 101);
            this.n1.Text = RandString(1, 13);
            this.n2.Text = RandString(1, 13);
            this.n3.Text = RandString(1, 13);
            this.n4.Text = RandString(1, 21);
            this.n5.Text = RandString(1, 21);
            this.operationN1.Text = "";
            this.operationN2.Text = "";
            this.operationO.Text = "";
            this.result.Text = "";
            this.mainPanel.Visible = true;
        }

        private void target_TextChanged(object sender, EventArgs e)
        {

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
            FillOperationN(this.n3.Text);
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

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

        }

        private void operationN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void operationO_TextChanged(object sender, EventArgs e)
        {

        }

        private void operationN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            Console.WriteLine(generatedNumbers);
            //recup taille generatedNumbers et switch case pour cacher les boutons
        }
    }
}
