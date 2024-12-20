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
    public partial class Practice241220 : Form
    {
        public Practice241220()
        {
            InitializeComponent();

            // 1. 학생 수 입력
            // 2. 학생 수 만큼 랜덤 점수 생성하고 각 학생에게 할당 (100점 만점)
            // 3. 학생 이름은 학생1, 학생2, ...
            // 4. 학생1의 점수: 42점 << 형태로 결과 표시 (함수 생성)


        }
        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text = string.Empty;
            string str = textBox_input.Text;
            int numberOfStudents = int.Parse(str);
            createScore(numberOfStudents);
        }

        void createScore(int a)
        {
            Random randomObj = new Random();
            for (int i = 1; i <= a; i++)
            {
                int randomValue = randomObj.Next(); // int형 난수 생성
                int score = randomValue % 101;

                string name = "학생" + i.ToString();

                printScore(name, score);
            }
        }
        

        void printScore(string name, int score)
        {
            textBox_result.Text += name + "의 점수: " + score + "점 \r\n";
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
