using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace Source_Projet_IA
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XML_Reader reader = new XML_Reader();
            Question q = reader.GetQuestion(0);
            Console.WriteLine("Question : "+q.Title);
            Console.WriteLine("img url : " + q.ImgURL);
            Console.WriteLine("Correct answer : " + q.CorrectAnswer);
            Console.WriteLine("a- "+q.LAnswers[0]);
            Console.WriteLine("b- " + q.LAnswers[1]);
            Console.WriteLine("c- " + q.LAnswers[2]);
            Console.WriteLine("d- " + q.LAnswers[3]);
            Application.Run(new Form1(reader));
        }
    }
}
