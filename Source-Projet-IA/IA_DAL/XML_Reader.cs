using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Domain;

namespace DAL
{
    public class XML_Reader
    {
        public XmlDocument XmlFile { get; set; }
        
        public XML_Reader()
        {
            XmlFile = new XmlDocument();
            XmlFile.Load(@"./questions.xml");
        }

        public Question GetQuestion(int index)
        {
            List<String> lAnswers = new List<string>();

            string question = XmlFile.DocumentElement.ChildNodes[index].ChildNodes[0]?.InnerText;
            int nbPoints = int.Parse(XmlFile.DocumentElement.ChildNodes[index].ChildNodes[1]?.InnerText);
            int correctAnswer = int.Parse(XmlFile.DocumentElement.ChildNodes[index].ChildNodes[2]?.InnerText);
            string imgURL = XmlFile.DocumentElement.ChildNodes[index].ChildNodes[3]?.InnerText;
            lAnswers.Add(XmlFile.DocumentElement.ChildNodes[index].ChildNodes[4]?.InnerText);
            lAnswers.Add(XmlFile.DocumentElement.ChildNodes[index].ChildNodes[5]?.InnerText);
            lAnswers.Add(XmlFile.DocumentElement.ChildNodes[index].ChildNodes[6]?.InnerText);
            lAnswers.Add(XmlFile.DocumentElement.ChildNodes[index].ChildNodes[7]?.InnerText);

            return new Question(question, imgURL, lAnswers, correctAnswer, nbPoints);
        }

        public int GetNumberOfQuestions()
        {
            var nodeCount = 0;
            using (var reader = XmlReader.Create(@"./questions.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "question")
                    {
                        nodeCount++;
                    }
                }
            }
            return nodeCount;
        }
    }
}
