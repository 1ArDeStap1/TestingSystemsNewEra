using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    
    class OPK
    {
        public int OPK_ID;
        public string OPK_DESCRIPTION;
        public decimal OPK_PERCENT;

        public override string ToString()
        {
            return OPK_DESCRIPTION;
        }
    }

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
        public OPK opk;
        public string cont;
        public Bitmap image;
        public string description;
        public Answer[] answers;
        public int[] correct;
        public bool answered;
        public bool right;
        public int id;
        public int type_id;
        public Dictionary<int, string> textAnswer;

        public Question(int id,string cont, Bitmap image, Answer[] answers, int[] correct, Dictionary<int, string> correctText, OPK Opk, string description = "", bool mix = false, int type = 1)
        {
            this.id = id;
            this.cont = cont;
            this.image = image;
            this.description = description;
            this.answers = answers;
            this.correct = correct;
            if (mix) this.mix();
            this.type_id = type;
            this.textAnswer = correctText;
            this.opk = Opk;
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

        public bool setAnswer(Dictionary<int, string> givedAnswers, ref List<int> answersIds, int answerType = 1)
        {
            if (answerType == 1)
            {
                answered = right = true;
                int CorrectsCurrentAnswers = 0;
                int wrongAnswers = 0;
                foreach (var givedAnswer in givedAnswers)
                {
                    answersIds.Add(answers[givedAnswer.Key].id);
                    if (Array.IndexOf(correct, givedAnswer.Key) == -1)
                    {

                        right = false;
                        wrongAnswers++;

                    }
                    else
                    {
                        CorrectsCurrentAnswers++;
                    }

                }
                if (CorrectsCurrentAnswers == correct.Length && wrongAnswers == 0)
                {
                    right = true;
                    return true;
                }
                else
                {
                    right = false;
                    return false;
                }
            }
            else if (answerType == 2)
            {
                answered = right = true;
                foreach (var tempAnswer in textAnswer)
                {
                    if (tempAnswer.Value == givedAnswers[answers[0].id])
                    {
                        answersIds.Add(tempAnswer.Key);
                        return true;
                    }
                }
                right = false;
                return false;

            }
            else if (answerType == 3 || answerType == 5)
            {
                answered = right = true;
                foreach (var tempAnswer in textAnswer)
                {
                    try
                    {
                        if (tempAnswer.Value == givedAnswers[answers[0].id])
                        {
                            answersIds.Add(tempAnswer.Key);
                            return true;
                        }
                    } catch {

                        right = false;
                        return false;
                    
                    }
                }
                right = false;
                return false;

            }
            else if (answerType == 4)
            {
                answered = right = true;
                foreach (var givedAnswer in givedAnswers)
                {
                    answersIds.Add(answers[givedAnswer.Key].id);
                    if (Array.IndexOf(correct, givedAnswer.Key) == -1)
                    {

                        right = false;
                        return false;

                    }
                    else
                    {
                        right = true;
                        return true;
                    }

                }
                ////////////
                ///////////
            }
                return true;
        }
    }

    class Questions
    {
        public Question[] questions;
        public Dictionary<int, string> answers;
        public int answerType = 1;
        public List<int> answersIds = new List<int>();
        public int lastAnswersCount;
        public int now = -1;
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
            if ((answers != null) && (answers.Count > 0) && (!returned))
            {
                questions[now].setAnswer(answers, ref answersIds, questions[now].type_id);
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
                return new Question(0,"", new Bitmap(10, 10), new Answer[1] { new Answer() }, new int[1] { 0 }, new Dictionary<int, string>(), new OPK());
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
