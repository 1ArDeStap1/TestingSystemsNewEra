using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{

    class Answer
    {
        public int id;
        public string content;

        public override string ToString()
        {
            return content;
        }
    }

    class Question
    {
        public string cont;
        public Bitmap image;
        public Answer[] answers;
        public int[] correct;
        public bool answered;
        public bool right;
        public int id;

        public Question(int id,string cont, Bitmap image, Answer[] answers, int[] correct, bool mix = false)
        {
            this.id = id;
            this.cont = cont;
            this.image = image;
            this.answers = answers;
            this.correct = correct;
            if (mix) this.mix();
        }

        private void mix()
        {
            /*int[] lCorrect = correct;
            correct = new int[0];
            string[] tmp = new string[answers.Length];
            List<int> free = new List<int>();
            for (int i = 0; i < answers.Length; i++)
            {
                free.Add(i);
            }
            Random rand = new Random();
            int el = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                el = rand.Next(free.Count - 1);
                tmp[i] = answers[free[el]];
                free.RemoveAt(el);
                int isCorrect = Array.IndexOf(lCorrect, i);
                if (isCorrect > -1)
                {
                    Array.Resize<int>(ref correct, correct.Length + 1);
                    correct[correct.Length-1] = i;
                    lCorrect[isCorrect] = -1;
                }
            }
            answers = tmp;*/
        }

        public bool setAnswer(int[] givedAnswers, ref List<int> answersIds)
        {
            answered = right = true;
            for (int i = 0; i < givedAnswers.Length; i++) {
                answersIds.Add(answers[givedAnswers[i]].id);
                if (Array.IndexOf(correct, givedAnswers[i]) == -1)
                {
                    
                    right = false;
                    return false;
                }
            }
            ////////////
            ///////////
            return true;
        }
    }

    class Questions
    {
        Question[] questions;
        public int[] answers;
        public List<int> answersIds = new List<int>();
        public int lastAnswersCount;
        int now = -1;
        bool returned = false;

        public int Count
        {
            get
            {
                return questions.Length;
            }
        }

        public bool isEnd()
        {
            if (now == questions.Length - 1) return true;
            return false;
        }

        public Question nextQuestion()
        {
            if ((answers != null) && (answers.Length > 0) && (!returned))
            {
                questions[now].setAnswer(answers, ref answersIds);
            }
            returned = false;
            now++;
            if (now != questions.Length)
            {
                return questions[now];
            }
            else
            {
                now--;
                return new Question(0,"", new Bitmap(10, 10), new Answer[1] { new Answer() }, new int[1] { 0 });
            }
        }

        public bool backQuestion()
        {
            if (now > 0)
            {
                answersIds.RemoveRange((answersIds.Count - lastAnswersCount) - 1, lastAnswersCount);
                lastAnswersCount = 0;
                returned = true;
                now -= 2;
                return true;
            }
            return false;
        }

        public Questions(Question[] questions)
        {
            this.questions = questions;
            mix();
        }

        public int rightsCount
        {
            get
            {
                int r = 0;
                for (int i = 0; i < questions.Length; i++)
                    if (questions[i].answered)
                    {
                        if (questions[i].right)
                            r++;
                    }
                    else break;
                return r;
            }
        }

        public void mix()
        {
            Program.RandomizeList(questions);
            /*Question[] tmp = new Question[questions.Length];
            List<int> free = new List<int>();
            free.
            for (int i = 0; i < questions.Length; i++)
            {
                free.Add(i);
            }
            Random rand = new Random();
            int el = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                el = rand.Next(free.Count - 1);
                tmp[i] = questions[free[el]];
                free.RemoveAt(el);
            }
            questions = tmp;*/
        }
    }
}
