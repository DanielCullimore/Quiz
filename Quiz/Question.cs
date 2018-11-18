using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Question
    {
        private String text = "";
        private String answer = "";
        private int difficulty;
        private String category;


        public Question(String text)
        {
            this.text = text;
            this.difficulty = difficulty;
            this.category = category;
            this.answer = answer;
        }

        public void addText(String extraText)
        {
            this.text = this.text + " " + extraText;
        }

        public String Text { set; get; }

        public virtual int Difficulty{set; get;}

        public virtual String Category { set; get; }

        public virtual String Answer { set; get; }

        public virtual Boolean checkAnswer(String response)
        {
            String expectedAnswer = this.Answer;
            String inputAnswer = response.Trim().ToLower();

            if (expectedAnswer.Equals(inputAnswer))
            {
                Console.WriteLine("Answer is correct");
                return true;
            }
            else
            {
                Console.WriteLine("Answer is not correct");
                return false;
            }
        }

        public virtual String toString()
        {
            return this.GetType().Name;
        }


        public virtual void display()
        {
            Console.WriteLine(this.text);
        }

    }
}
