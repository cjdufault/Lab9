using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Question
    {
        public Question(string question, string correctAnswer, List<string> wrongAnswers, int points)
        {
            QuestionText = question;
            CorrectAnswer = correctAnswer;
            WrongAnswers = wrongAnswers;
            Points = points;
        }

        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> WrongAnswers { get; set; }
        public int Points { get; set; }
        public List<string> AllAnswers
        {
            get
            {
                List<string> allAnswers = new List<string>();

                // add correct and wrong answers to list of all answers
                allAnswers.Add(CorrectAnswer);
                allAnswers.AddRange(WrongAnswers);

                Random random = new Random();
                List<string> shuffledAnswers = new List<string>();

                while (allAnswers.Count > 0) 
                {
                    // remove an answer at a random index in allAnswers
                    int index = random.Next(allAnswers.Count);
                    string answer = allAnswers[index];
                    allAnswers.RemoveAt(index);

                    // insert that answer at a random index in shuffledAnswers
                    int insertIndex = random.Next(shuffledAnswers.Count);
                    shuffledAnswers.Insert(insertIndex, answer);
                }

                return shuffledAnswers;
            }
        }

        public bool CheckAnswer(string chosenAnswer)
        {
            return chosenAnswer.Equals(CorrectAnswer);
        }
    }
}
