using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace p1Calc
{
    public partial class fCalc : Form // Constructor de la clase
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string operation = string.Empty;
        string operationbf = string.Empty;
        public fCalc() //llamada al constructor de la clase
        {
            InitializeComponent();
            input = "";
        }
        //......................................................................
        private void bDigit_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            this.txtResultado.Text = input;
        }
        private void bCE_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
        public void calculation()
        {
            //MessageBox.Show("calculation ");
            Double num1, num2;
            num1 = double.Parse(operand1, CultureInfo.InvariantCulture);
            num2 = double.Parse(operand2, CultureInfo.InvariantCulture);

            //MessageBox.Show(" doing calculation");       
           
            if (operation == "+")
            {
                txtResultado.Text = (num1 + num2).ToString();
            }
            else if (operation == "-")
            {
                txtResultado.Text = (num1 - num2).ToString();
            }
            else if (operation == "X")
            {
                txtResultado.Text = (num1 * num2).ToString();
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    txtResultado.Text = (num1 / num2).ToString();
                }
                else
                {
                    txtResultado.Text = "DIV/Zero!";
                }
            }
            input = String.Empty;
            operand1 = String.Empty;
            operand2 = String.Empty;
            operand1 = txtResultado.Text;
            operation = String.Empty;
            //MessageBox.Show("nuevo valor en operand1 y limpiando valor en operand1 y 2");
            //this.txtResultado.Text = "";
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text.ToString();
            if (operation == "=") // si vienes del igual 
            {
                //MessageBox.Show("si vienes del igual");
                if (operand1 != "" && this.txtResultado.Text != "") //si el operador1 NO esta vacio
                {                    
                    this.txtResultado.Text = "";
                    //MessageBox.Show("operand2 = input");
                    operand2 = input;
                    operation = b.Text.ToString();
                    operation = operationbf;
                    this.calculation();
                }
                else  //si el operador1 esta vacio
                {
                    //MessageBox.Show("si el operador1 SI esta vacio");
                    this.txtResultado.Text = "";
                    //MessageBox.Show("operand1 = input");
                    operand1 = input;
                    operation = b.Text.ToString();
                    input = String.Empty;
                }
            }
            else // si NO vienes del igual 
            {
                //MessageBox.Show("si NO vienes del igual ");
                operationbf = operation;
                if (operand1 == "")
                {
                    //MessageBox.Show("si NO vienes del igual y operand1 vacio ");
                    this.txtResultado.Text = "";
                    operand1 = input;
                    //MessageBox.Show("operand1 = input");
                    operation = b.Text.ToString();
                    input = String.Empty;
                }
                else
                {                    
                    if (operand1 != "" && operand2 == "" && input == "")
                    {
                        //MessageBox.Show("si NO vienes del igual y operand1 lleno opera2 vacio input vacio ");
                        this.txtResultado.Text = "";
                    }
                    else
                    {
                        //MessageBox.Show("si NO vienes del igual y operand1 lleno ");
                        this.txtResultado.Text = "";
                        operand2 = input;
                        //MessageBox.Show("operand2 = input");
                        operation = b.Text.ToString();
                        input = String.Empty;
                        this.calculation();
                    }
                }
            }
        }
    }
}






     

