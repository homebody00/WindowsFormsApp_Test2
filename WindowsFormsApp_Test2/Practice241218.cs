using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Test2
{
    public partial class Practice241218 : Form
    {
        public Practice241218()
        {
            InitializeComponent();
            int num1 = 201;
            int num2 = 10;

            int[] result = getShareAndRest(num1, num2);

            textBox_print.Text = num1 + " / " + num2 + " = " + result[0] + "\r\n";
            textBox_print.Text += num1 + " % " + num2 + " = " + result[1];



        }

        int[] getShareAndRest(int a, int b)
        {
            int[] intArray = new int[3];

            intArray[0] = a / b;
            intArray[1] = a % b;

            return intArray;
        }
    }
}
