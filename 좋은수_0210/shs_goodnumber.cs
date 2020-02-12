using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{

    class Quiz_2
    {

        private string data;
        private int N = 0, index = 0, count = 0;
        private string[] disc_char;
        private int[] disc_int;

        public void Input()
        {

            N = Convert.ToInt32(Console.ReadLine());                // 수열의 갯수 입력
            data = Console.ReadLine();
            disc_int = new int[N];
            SetDisc();
            CntDisc();

        }

        private void SetDisc()
        {
            disc_char = data.Split(' ');
            for (int i = 0; i < N; disc_int[i] = Int32.Parse(disc_char[i++]));
        }

        private void CntDisc()
        {
            while (index < N)
            {
                // 중복을 포함한 3개의 숫자 선택
                for (int first = 0; first < index; first++)                             // 첫번째
                {
                    for (int second = first; second < index; second++)                  // 두번째           
                    {
                        for (int third = second; third < index; third++)                // 세번째
                        {
                            if (disc_int[first] + disc_int[second] + disc_int[third] == disc_int[index])                    // 선택한 세 수의 합이 기준 값과 같으면 카운트
                            {
                                count++;
                                first = second = third = index;                                         // 루프종료를 위한 설정
                            }
                        }
                    }
                }
                index++;
            }
        }

        public int Result() { return count; }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Quiz_2 quiz2 = new Quiz_2();
            quiz2.Input();
            Console.WriteLine(quiz2.Result());
        }

    }
}