using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            int answer = randGen.Next(1, 7);

            switch (answer)
            {
                case 1:
                    outputLabel.Text = "Highly unlikely";
                    break;
                case 2:
                    outputLabel.Text = "Don't count on it";
                    break;
                case 3:
                    outputLabel.Text = "Maybe";
                    break;
                case 4:
                    outputLabel.Text = "Likely";
                    break;
                case 5:
                    outputLabel.Text = "Definitly";
                    break;
                case 6:
                    outputLabel.Text = "The chances are high";
                    break;
                default:
                    break;
            }
        }
    }
}
