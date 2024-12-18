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
        #region 실습1. 함수.
        //public practice241218()
        //{
        //    initializecomponent();
        //    int num1 = 201;
        //    int num2 = 10;

        //    int[] result = getshareandrest(num1, num2);

        //    textbox_print.text = num1 + " / " + num2 + " = " + result[0] + "\r\n";
        //    textbox_print.text += num1 + " % " + num2 + " = " + result[1];
        //}

        //int[] getshareandrest(int a, int b)
        //{
        //    int[] intarray = new int[3];

        //    intarray[0] = a / b;
        //    intarray[1] = a % b;

        //    return intarray;
        //}
        #endregion

        public Practice241218()
        {
            InitializeComponent();

            bool result = throwCoin(false);

            textBox_print.Text = result.ToString() + "\r\n";
        }

        bool throwCoin(bool a)
        {
            Random randomObj = new Random();
            int randomValue = randomObj.Next(); // int형 난수 생성
            randomValue %= 2;

            if (randomValue == 1)
            {
                if (a == true)
                {
                    return true;
                }
                else
                    return false;
            }
            else if (randomValue == 0)
            {
                if (a == false)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

    }
}
