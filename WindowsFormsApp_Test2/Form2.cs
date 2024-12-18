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

            //string str = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            //// 1
            //int num = str.indexof("-");
            //string firststr = str.remove(num, 3);
            //textbox_print.text = "1. " + firststr + "\r\n";

            //// 2
            //string[] stringarray = new string[10];

            //int[] temp = new int[3];

            //temp[0] = str.indexof("얼마나");
            //temp[1] = str.indexof("천천히");
            //temp[2] = str.indexof("가는지");

            //for (int i =0; i < temp.length; i++)
            //{
            //    stringarray[i] = str.substring(temp[i], 3);
            //}

            //textbox_print.text += "2. ";
            //for (int i = 0; i < 3; i++)
            //{
            //    textbox_print.text += stringarray[i] + "\r\n";
            //}


            //// 3
            //string secondstr = str.replace(".", "");
            //secondstr = secondstr.replace("-", "");
            //secondstr = secondstr.replace(" ", ",");

            //textbox_print.text += "3. " + secondstr + "\r\n";

            #endregion

            Console.WriteLine("Hello");
        }
    }
}
