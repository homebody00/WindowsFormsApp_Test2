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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region 실습. 배열.
            string[] str = new string[10];

            string s1 = "동해 물과 백두산이";
            string s2 = "토요일에 먹는 토마토";
            string s3 = "질서 있는 퇴장";
            string s4 = "그 사람의 그림자는 그랬다.";
            string s5 = "삼성 갤럭시";
            string s6 = "오늘은 왠지 더 배고프다";
            string s7 = "이름,나이,전화번호";
            string s8 = "우리 나라 만세";

            str[0] = s1.IndexOf("백두산").ToString(); // str[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            str[1] = s2.LastIndexOf("토").ToString();
            str[2] = s3.Contains("퇴").ToString();
            str[3] = s4.Replace("그", "이");
            str[4] = s5.Insert(3, "애플 ");
            str[5] = s6.Remove(7,1);
            String[] temp = s7.Split(',');
            for (int i = 0; i < temp.Length; i++)
            {
                str[6 + i] = temp[i];
            }
            str[9] = s8.Substring(3, 2);

            textBox_print.Text = "";
            for (int i = 0; i < 10; i++)
            {
                textBox_print.Text += str[i] + "\r\n";
            }
            #endregion

            



        }
    }
}
