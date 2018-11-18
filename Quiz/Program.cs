using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> quizQuestions = new List<Question>();

            Question q = new Question("What is your job");
            q.Answer = "software";
            presentQuestion(q);

        }

        public static void presentQuestion(Question q)
        {
            q.display();
            Console.WriteLine("Your answer: ");
            String input = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(input));
            Console.ReadLine();
        }

    }
}

