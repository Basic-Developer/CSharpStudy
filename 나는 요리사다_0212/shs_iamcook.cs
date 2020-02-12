using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{

    class Quiz_3
    {

        private int Max = 0, Sum = 0, Winner = 0;
        private string[] Score;
        private string Data;

        public void Input() { CheckWinner(); }


        private void CheckWinner()
        {
            for (int i = 0; i < 5; i++)
            {
                Data = Console.ReadLine();

                Score = Data.Split(' ');

                for (int j = 0; j < Score.Length; Sum += Int32.Parse(Score[j++])) ;

                if (Max < Sum)
                {
                    Max = Sum;
                    Winner = i + 1;
                }
                Sum = 0;
            }
        }

        public void Result()
        {
            Console.WriteLine("{0} {1}", Winner, Max);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Quiz_3 quiz3 = new Quiz_3();
            quiz3.Input();
            quiz3.Result();
        }

    }
}