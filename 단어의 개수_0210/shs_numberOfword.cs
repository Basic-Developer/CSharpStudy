using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{

    class Quiz_1
    {

        private string data;
        private int count = 0;
        string[] ArrData;

        public void Input()
        {
            data = Console.ReadLine();
            CountBlank();
            CheckBlank();
        }

        private void CountBlank()                           // 공백의 갯수를 이용하여 단어갯수 카운트
        {
            ArrData = data.Split(' ');
            count = ArrData.Length;
        }

        private void CheckBlank()                          // 맨 앞/뒤 공백 체크 및 카운트 차감
        {
            if (ArrData[0].Length == 0)
                count--;
            if (ArrData[ArrData.Length - 1].Length == 0)
                count--;
        }

        public int Result() { return count; }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Quiz_1 quiz1 = new Quiz_1();

            quiz1.Input();

            Console.WriteLine(quiz1.Result());
        }

    }
}