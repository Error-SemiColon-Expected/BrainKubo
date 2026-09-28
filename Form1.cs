using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETA
{
    public partial class Form1 : Form
    {
        int correct;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 25;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correct)
            {
                score++;
            }

            questionNumber++;

            if (questionNumber > totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                DialogResult result = MessageBox.Show(
                    "Session terminated!" + Environment.NewLine +
                    "You answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to close application",
                    "Game Over",
                    MessageBoxButtons.OK
                );

                if (result == DialogResult.OK)
                {
                    Form2 f2 = new Form2();
                    f2.Show();
            
                    this.Close(); 
                }

                score = 0;
                questionNumber = 1;
                askQuestion(questionNumber);
            }
            else
            {
                askQuestion(questionNumber);
            }
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.img1;
                    lblQuestion.Text = "In what year did the Philippines gain independence?";
                    lblNum.Text = "#1";
                    button1.Text = "1946";
                    button2.Text = "1939";
                    button3.Text = "1899";
                    button4.Text = "1896";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.img2;
                    lblQuestion.Text = "What type of language originated from the streets and is considered the lowest form of language used by people?";
                    lblNum.Text = "#2";
                    button1.Text = "Kolokyal";
                    button2.Text = "balbal";
                    button3.Text = "Pormal";
                    button4.Text = "Lalawiganin";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.img3;
                    lblQuestion.Text = "Which Filipino cultural practice involves a man serenading a woman to express his feelings?";
                    lblNum.Text = "#3";
                    button1.Text = "Pag-aalay";
                    button2.Text = "Pag-igib";
                    button3.Text = "Ligaw/Panliligaw";
                    button4.Text = "Pagtatapat";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.img4;
                    lblQuestion.Text = "In what place was the Philippine national hero Jose Rizal executed?";
                    lblNum.Text = "#4";
                    button1.Text = "Intramuros";
                    button2.Text = "Bagumbayan";
                    button3.Text = "Malolos";
                    button4.Text = "Cavite";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 2;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.img5;
                    lblQuestion.Text = "For how many years was the Philippines under Spanish rule?";
                    lblNum.Text = "#5";
                    button1.Text = "300 years";
                    button2.Text = "333 years";
                    button3.Text = "250 years";
                    button4.Text = "420 years";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.img6;
                    lblQuestion.Text = "In what year was Tagalog declared as the basis of the national language?";
                    lblNum.Text = "#6";
                    button1.Text = "1937";
                    button2.Text = "1940";
                    button3.Text = "1925";
                    button4.Text = "1969";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 1;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.img7;
                    lblQuestion.Text = "Who is considered the father of the Philippine national language?";
                    lblNum.Text = "#7";
                    button1.Text = "Manuel Roxas";
                    button2.Text = "Manuel L. Quezon";
                    button3.Text = "Andres Bonifacio";
                    button4.Text = "Emilio Aguinaldo";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 2;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.img8;
                    lblQuestion.Text = "Where can you find the historic Tirad Pass, where Filipinos fought against the Americans?";
                    lblNum.Text = "#8";
                    button1.Text = "Cavite";
                    button2.Text = "Laguna";
                    button3.Text = "Pangasinan";
                    button4.Text = "Ilocos Sur";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 4;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.img9;
                    lblQuestion.Text = "Who led the Filipinos in the Battle of Tirad Pass?";
                    lblNum.Text = "#9";
                    button1.Text = "Antonio Luna";
                    button2.Text = "Andres Bonifacio";
                    button3.Text = "Gregorio del Pilar";
                    button4.Text = "Apolinario Mabini";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 3;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.img10;
                    lblQuestion.Text = "He is a Filipino general often called the forgotten president of the Philippines.";
                    lblNum.Text = "#10";
                    button1.Text = "Miguel Malvar";
                    button2.Text = "Macario Sakay";
                    button3.Text = "Andres Bonifacio";
                    button4.Text = "Artemio Ricarte";

                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                    correct = 1;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.img11;
                    lblQuestion.Text = "Who was the first president of the Philippines, and in what year did he assume office?";
                    lblNum.Text = "#11";
                    button1.Text = "Jose Rizal, 1896";
                    button2.Text = "Manuel L. Quezon, 1935";
                    button3.Text = "Emilio Aguinaldo, 1899";
                    button4.Text = "Andres Bonifacio, 1897";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 3;
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.img12;
                    lblQuestion.Text = "What is the name of the largest island in the Philippines by land area?";
                    lblNum.Text = "#12";
                    button1.Text = "Mindanao";
                    button2.Text = "Palawan";
                    button3.Text = "Visayas";
                    button4.Text = "Luzon";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 4;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.img13;
                    lblQuestion.Text = "What Country did not or attempted to colonize the Philippines during Colonial Times";
                    lblNum.Text = "#13";
                    button1.Text = "France";
                    button2.Text = "Germany";
                    button3.Text = "Great Britain";
                    button4.Text = "Spain";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 1;
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.img21;
                    lblQuestion.Text = "How do you say 'good morning' in Ilocano?";
                    lblNum.Text = "#14";
                    button1.Text = "Noche Buena";
                    button2.Text = "Naimbag a bigat";
                    button3.Text = "¡Buenos días!";
                    button4.Text = "Selamat Pagi";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 2;
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.img15;
                    lblQuestion.Text = "What language was the national anthem \"Lupang Hinirang\" orginally written in?";
                    lblNum.Text = "#15";
                    button1.Text = "Visaya";
                    button2.Text = "Tagalog";
                    button3.Text = "Spanish";
                    button4.Text = "English";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 3;
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.img16;
                    lblQuestion.Text = "How many regions does the Philippines have?";
                    lblNum.Text = "#16";
                    button1.Text = "82";
                    button2.Text = "15";
                    button3.Text = "17";
                    button4.Text = "79";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 3;
                    break;

                case 17:
                    pictureBox1.Image = Properties.Resources.img17;
                    lblQuestion.Text = "What is the Spanish-based Creole language spoken in Zamboanga?";
                    lblNum.Text = "#17";
                    button1.Text = "Waray";
                    button2.Text = "Tagalog";
                    button3.Text = "Cebuano";
                    button4.Text = "Chavacano";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 4;
                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources.img18;
                    lblQuestion.Text = "What is the origin of the Filipino greeting 'kumusta' and how is it used today?";
                    lblNum.Text = "#18";
                    button1.Text = "Spanish \"¿Cómo está?\"";
                    button2.Text = "French \"Comment ça va? \"";
                    button3.Text = "Romanian, \"Ce mai faci\"";
                    button4.Text = "Italian \"Come stai?\"";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 1;
                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources.img19;
                    lblQuestion.Text = "What is the NEW tourism slogan of the Philippines?";
                    lblNum.Text = "#19";
                    button1.Text = "Mabuhay";
                    button2.Text = "Wag mong subukan";
                    button3.Text = "Love the Philippines";
                    button4.Text = "It's more fun in the Philippines";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 3;
                    break;

                case 20:
                    pictureBox1.Image = Properties.Resources.img20;
                    lblQuestion.Text = "What is the traditional Filipino alphabet called, used before the Spanish colonization of the Philippines?";
                    lblNum.Text = "#20";
                    button1.Text = "Alibata";
                    button2.Text = "Baybayin";
                    button3.Text = "Abugida";
                    button4.Text = "Alpabeto";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 2;
                    break;

                case 21:
                    pictureBox1.Image = Properties.Resources.img21;
                    lblQuestion.Text = "What is the Ilocano word for 'friend'?";
                    lblNum.Text = "#21";
                    button1.Text = "Mahal";
                    button2.Text = "Barkada";
                    button3.Text = "Gayyem";
                    button4.Text = "Kaibigan";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 3;
                    break;

                case 22:
                    pictureBox1.Image = Properties.Resources.image22;
                    lblQuestion.Text = "How do you say 'I love you' in Cebuano?";
                    lblNum.Text = "#22";
                    button1.Text = "Gihigugma tika";
                    button2.Text = "Mahal kita";
                    button3.Text = "Inom tayo";
                    button4.Text = "Salamat";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 1;
                    break;

                case 23:
                    pictureBox1.Image = Properties.Resources.img23;
                    lblQuestion.Text = "What is the Kapampangan term for 'goodbye'?";
                    lblNum.Text = "#23";
                    button1.Text = "Sige";
                    button2.Text = "Paalam";
                    button3.Text = "Ingat";
                    button4.Text = "Adios";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 2;
                    break;

                case 24:
                    pictureBox1.Image = Properties.Resources.img24;
                    lblQuestion.Text = "How do you say 'family' in Hiligaynon (Ilonggo)?";
                    lblNum.Text = "#24";
                    button1.Text = "Ka pamilya";
                    button2.Text = "tropa";
                    button3.Text = "Kapitbahay";
                    button4.Text = "Pamilya";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 4;
                    break;

                case 25:
                    pictureBox1.Image = Properties.Resources.img25;
                    lblQuestion.Text = "What language is closest to Tagalog outside of the Philippines?";
                    lblNum.Text = "#25";
                    button1.Text = "Cebuano";
                    button2.Text = "Visaya";
                    button3.Text = "Malay";
                    button4.Text = "Bahasa Indonesia";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    correct = 4;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 300000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {        
            timer1.Stop();
            this.Close();
        }

        // paiyak napo ako ser
    }
}