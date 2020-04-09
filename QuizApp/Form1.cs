using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        // radio buttons that show the answers
        private List<RadioButton> QuizRadioButtons;

        // Question objects
        private List<Question> QuizQuestions;

        // current index in quizQuestions
        private int CurrentQuestionIndex;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            QuizRadioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4 };

            Question q1 = new Question("What does a cow say?", "Moo", new List<string> { "Oink", "Meow", "Hello" }, 1);
            Question q2 = new Question("What does a cat say?", "Meow", new List<string> { "Oink", "Moo", "Hello" }, 2);
            Question q3 = new Question("What does a pig say?", "Oink", new List<string> { "Moo", "Meow", "Hello" }, 3);
            Question q4 = new Question("What does a person say?", "Hello", new List<string> { "Oink", "Meow", "Moo" }, 4);

            QuizQuestions = new List<Question> { q1, q2, q3, q4 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentQuestionIndex = 0;
            btnNextQuestion.Enabled = false;
            DisplayQuestion(0);
        }

        private void DisplayQuestion(int questionIndex)
        {
            Question question = QuizQuestions[questionIndex];
            List<string> answers = question.AllAnswers;

            lblQuestion.Text = question.QuestionText;
            lblResult.Text = "???";
            btnNextQuestion.Enabled = false;
            btnCheckAnswer.Enabled = true;

            // uncheck all radio buttons and set their texts to the question's answers
            for (int i = 0; i < QuizRadioButtons.Count; i++)
            {
                QuizRadioButtons[i].Checked = false;
                QuizRadioButtons[i].Text = answers[i];
            }
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            string answer = null;
            btnNextQuestion.Enabled = true;
            btnCheckAnswer.Enabled = false;
            btnNextQuestion.Focus();

            // find the checked radio button, if there is one
            foreach (RadioButton rb in QuizRadioButtons)
            {
                if (rb.Checked)
                {
                    answer = rb.Text;
                    break;
                }
            }

            // if no radio button is checked
            if (answer == null)
            {
                MessageBox.Show("No answer selected", "No answer");
            }
            else
            {
                Question question = QuizQuestions[CurrentQuestionIndex];

                // check answer, display result, and add to score if correct
                bool isCorrect = question.CheckAnswer(answer);

                if (isCorrect)
                {
                    lblResult.Text = "Correct!";
                    score += question.Points;
                }
                else
                {
                    lblResult.Text = $"Incorrect. The correct answer was {question.CorrectAnswer}.";
                }
            }

            // check if the game is over
            if (CurrentQuestionIndex + 1 >= QuizQuestions.Count)
            {
                GameOver();
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            CurrentQuestionIndex++;
            DisplayQuestion(CurrentQuestionIndex);
        }

        private void GameOver()
        {
            // disable buttons
            btnCheckAnswer.Enabled = false;
            btnNextQuestion.Enabled = false;

            // show result of quiz and ask if player wants to play again
            DialogResult result = MessageBox.Show($"Score: {score}\n\nPlay again?", "Game Over!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) // if yes, reset score and question index, and show the first question
            {
                CurrentQuestionIndex = 0;
                score = 0;
                DisplayQuestion(0);
            }
            else // if no, quit
            {
                this.Dispose();
            }
        }
    }
}
