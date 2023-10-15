namespace Lista5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int ques = 0;
            while (ques != 11)
            {
                Console.WriteLine("escolha a questao de 1 a 10 e pressione 0 para parar");
                ques = int.Parse(Console.ReadLine());
                if (ques == 0)
                    break;
                else if (ques == 1)
                    Questao01.rodar();
                else if (ques == 2)
                    Questao02.rodar();
                else if (ques == 3)
                    Questao03.rodar();
                else if (ques == 4)
                    Questao04.rodar();
                else if (ques == 5)
                    Questao05.rodar();
                else if (ques == 6)
                    Questao06.rodar();
                else if (ques == 7)
                    Questao07.rodar();
                else if (ques == 8)
                    Questao08.rodar();
                else if (ques == 9)
                    Questao09.rodar();
                else if (ques == 10)
                    Questao10.rodar();
            }
        }
    }
}