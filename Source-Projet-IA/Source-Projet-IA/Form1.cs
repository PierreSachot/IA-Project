using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DAL;
using Domain;
using System.IO;

namespace Source_Projet_IA
{
    public partial class Form1 : Form
    {
        private XML_Reader Reader { get; set; }
        private Question currentQuestion { get; set; }
        public Form1(XML_Reader reader)
        {
            InitializeComponent();
            Thread.Sleep(100);
            Reader = reader;
            pictureBox.Visible = false;
            labelAnswer1.Location = new Point(labelAnswer1.Location.X, 86);
            labelAnswer2.Location = new Point(labelAnswer2.Location.X, 86 + 37);
            labelAnswer3.Location = new Point(labelAnswer3.Location.X, 86 + 37*2);
            labelAnswer4.Location = new Point(labelAnswer4.Location.X, 86 + 37*3);
            LoadQuestion();
        }

        public void LoadQuestion()
        {
            Random random = new Random();
            int val = random.Next(0, 2);
            currentQuestion = Reader.GetQuestion(val);
            labelQuestion.Text = currentQuestion.Title;
            labelQuestion.Left = (this.ClientSize.Width / 2) - (labelQuestion.Width / 2);
            labelAnswer1.Text = currentQuestion.LAnswers[0];
            Console.WriteLine("session de answer 1 :"+ currentQuestion.LAnswers[0]);
            labelAnswer1.Left = (this.ClientSize.Width / 2) - (labelAnswer1.Width / 2);
            labelAnswer2.Text = currentQuestion.LAnswers[1];
            labelAnswer2.Left = (this.ClientSize.Width / 2) - (labelAnswer2.Width / 2);
            labelAnswer3.Text = currentQuestion.LAnswers[2];
            labelAnswer3.Left = (this.ClientSize.Width / 2) - (labelAnswer3.Width / 2);
            labelAnswer4.Text = currentQuestion.LAnswers[3];
            labelAnswer4.Left = (this.ClientSize.Width / 2) - (labelAnswer4.Width / 2);

            if (currentQuestion.ImgURL == "")
            {
                pictureBox.Visible = false;
                if(labelAnswer1.Location.Y == 276)
                {
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        while(labelAnswer1.Location.Y != 86)
                        {
                            labelAnswer1.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer1.Location = new Point(labelAnswer1.Location.X, labelAnswer1.Location.Y - 1);
                            }));
                            labelAnswer2.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer2.Location = new Point(labelAnswer2.Location.X, labelAnswer2.Location.Y - 1);
                            }));
                            labelAnswer3.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer3.Location = new Point(labelAnswer3.Location.X, labelAnswer3.Location.Y - 1);
                            }));
                            labelAnswer2.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer4.Location = new Point(labelAnswer4.Location.X, labelAnswer4.Location.Y - 1);
                            }));
                        }
                    }).Start();
                }
            }
            else
            {
                pictureBox.Visible = true;
                pictureBox.Image = Image.FromFile(currentQuestion.ImgURL);
                pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + labelQuestion.Height);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (labelAnswer1.Location.Y != 276 + labelQuestion.Height)
                {
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        while (labelAnswer1.Location.Y != 276+labelQuestion.Height)
                        {
                            labelAnswer1.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer1.Location = new Point(labelAnswer1.Location.X, labelAnswer1.Location.Y + 1);
                            }));
                            labelAnswer2.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer2.Location = new Point(labelAnswer2.Location.X, labelAnswer2.Location.Y + 1);
                            }));
                            labelAnswer3.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer3.Location = new Point(labelAnswer3.Location.X, labelAnswer3.Location.Y + 1);
                            }));
                            labelAnswer2.Invoke(new MethodInvoker(delegate
                            {
                                labelAnswer4.Location = new Point(labelAnswer4.Location.X, labelAnswer4.Location.Y + 1);
                            }));
                        }
                    }).Start();
                }
            }
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            LoadQuestion();
        }
    }
}
