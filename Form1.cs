using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsHA
{
    public partial class Form1 : Form
    {
        private bool _areValuesValid = false;
        private float _value1 = 0;
        private float _value2 = 0;
        private Operands.PerformCalculation _pc;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operand = comboBox1.SelectedItem.ToString();
            switch(operand)
            {
                case "Add":
                    _pc = new Operands.PerformCalculation(Operands.Add);
                    break;
                case "Subtract":
                    _pc = new Operands.PerformCalculation(Operands.Subtract);
                    break;                
                case "Multiply":
                    _pc = new Operands.PerformCalculation(Operands.Multiply);
                    break;                
                case "POW":
                    _pc = new Operands.PerformCalculation(Operands.Pow);
                    break;
                case "AND":
                    _pc = new Operands.PerformCalculation(Operands.And);
                    break;
                case "OR":
                    _pc = new Operands.PerformCalculation(Operands.Or);
                    break;
                default:
                    break;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ValidateTextAsNumber(sender as TextBox, ref _value1);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            ValidateTextAsNumber(sender as TextBox, ref _value2);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_areValuesValid || _pc == null) 
                return;
            label1.Text = _pc.Invoke(_value1, _value2).ToString();
        }
        
        private void ValidateTextAsNumber(TextBox tBox, ref float num)
        {
            if (!float.TryParse(tBox.Text, out float value))
            {
                tBox.ForeColor = Color.Red;
                _areValuesValid = false;
                return;
            }
            tBox.ForeColor = Color.Green;
            num = value;
            _areValuesValid = true;
        }
    }
}
