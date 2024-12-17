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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            #region 실습. 문자열.

            string str = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            // 1
            int num = str.IndexOf("-");
            string firstStr = str.Remove(num, 3);
            textBox_print.Text = "1. " + firstStr + "\r\n";

            // 2
            string[] stringArray = new string[10];

            int[] temp = new int[3];

            temp[0] = str.IndexOf("얼마나");
            temp[1] = str.IndexOf("천천히");
            temp[2] = str.IndexOf("가는지");

            for (int i =0; i < temp.Length; i++)
            {
                stringArray[i] = str.Substring(temp[i], 3);
            }

            textBox_print.Text += "2. ";
            for (int i = 0; i < 3; i++)
            {
                textBox_print.Text += stringArray[i] + "\r\n";
            }


            // 3
            string secondStr = str.Replace(".", "");
            secondStr = secondStr.Replace("-", "");
            secondStr = secondStr.Replace(" ", ",");

            textBox_print.Text += "3. " + secondStr + "\r\n";

            #endregion
        }
    }
}
