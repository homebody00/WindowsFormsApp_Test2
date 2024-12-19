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
    public partial class Practice241219 : Form
    {
        public Practice241219()
        {
            InitializeComponent();

            




        }

        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            int input=0;

            switch (textBox_input.Text)
            {
                case "월요일":
                case "월":
                    input = 0;
                    break;
                case "화요일":
                case "화":
                    input = 1;
                    break;
                case "수요일":
                case "수":
                    input = 2;
                    break;
                case "목요일":
                case "목":
                    input = 3;
                    break;
                case "금요일":
                case "금":
                    input = 4;
                    break;
                case "토요일":
                case "토":
                    input = 5;
                    break;
                case "일요일":
                    case "일":
                    input = 6;
                    break;
                default:
                    textBox_result.Text = "요일을 입력해주세요.\r\n";
                    break;
            }

            switch (input)
            {
                case (int)Week.Monday:
                    textBox_result.Text = "월요일입니다.\r\n";
                    break;
                case (int)Week.Tuesday:
                    textBox_result.Text = "화요일입니다.\r\n";
                    break;
                case (int)Week.Wednesday:
                    textBox_result.Text = "수요일입니다.\r\n";
                    break;
                case (int)Week.Thursday:
                    textBox_result.Text = "목요일입니다.\r\n";
                    break;
                case (int)Week.Friday:
                    textBox_result.Text = "금요일입니다.\r\n";
                    break;
                case (int)Week.Saturday:
                    textBox_result.Text = "토요일입니다.\r\n";
                    break;
                case (int)Week.Sunday:
                    textBox_result.Text = "일요일입니다.\r\n";
                    break;
                default:
                    textBox_result.Text = "요일을 입력해주세요.\r\n";
                    break;
            }


        }

        private void textBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_input_Click(sender, e);
            }
        }
    }
}
