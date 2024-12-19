using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Test2
{
    public partial class Practice241218 : Form
    {
        public Practice241218()
        {
            InitializeComponent();




        }

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

        #region 실습2. if문
        //public Practice241218()
        //{
        //    InitializeComponent();

        //    bool result = coinTossGame(false);

        //    textBox_print.Text = result.ToString() + "\r\n";
        //}

        //bool coinTossGame(bool a)
        //{
        //    Random randomObj = new Random();
        //    int randomValue = randomObj.Next(); // int형 난수 생성
        //    randomValue %= 2;
        //    bool coin = randomValue == 1;

        //    if (coin == a)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //}
        #endregion

        private void button_input_Click(object sender, EventArgs e)
        {
            bool choice;
            bool gameResult;

            if (textBox_input.Text.ToLower() == "true")
            {
                choice = true;
                gameResult = coinTossGame(choice);

                textBox_result.Text = "입력하신 값은 " + choice + " 입니다.\r\n";
                textBox_result.Text += "동전 던지기 결과...\r\n";

                if (gameResult == true)
                    textBox_result.Text += "승리!\r\n";
                else
                    textBox_result.Text += "패배\r\n";
            }
            else if (textBox_input.Text.ToLower() == "false")
            {
                choice = false;
                gameResult = coinTossGame(choice);

                textBox_result.Text = "입력하신 값은 " + choice + " 입니다.\r\n";
                textBox_result.Text += "동전 던지기 결과...\r\n";

                if (gameResult == true)
                    textBox_result.Text += "승리!\r\n";
                else
                    textBox_result.Text += "패배\r\n";
            }
            else 
                textBox_result.Text = "라디오 버튼을 눌러 입력해주세요.\r\n";


            textBox_input.Text = string.Empty;
        }

        private void radioButton_True_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text == "" || textBox_input.Text == "false" || textBox_input.Text == "true")
            {
                textBox_input.Text = "true";
            }
            else
            {
                textBox_result.Text = "라디오 버튼을 눌러 입력해주세요.\r\n";
            }
        }

        private void radioButton_False_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text == "" || textBox_input.Text == "false" || textBox_input.Text == "true")
            {
                textBox_input.Text = "false";
            }
            else
            {
                textBox_result.Text = "라디오 버튼을 눌러 입력해주세요.\r\n";
            }
        }

        bool coinTossGame(bool a)
        {
            Random randomObj = new Random();
            int randomValue = randomObj.Next(); // int형 난수 생성
            randomValue %= 2;
            bool coin = randomValue == 1;

            if (coin == a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
