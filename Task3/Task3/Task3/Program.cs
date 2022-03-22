using System;

namespace Task3
{
    class Program
    {
        //3. Qəbul etdiyi integer parametrə həmin parametrin dəyərinin ən yaxın kökaltı dəyərini mənimsədən
        //    metod - misal üçün, int num = 35 variable-mız var.
        //    Bu variable-ı həmin metoda göndərdikdə variable-ın dəyəri 5 olmalıdır.

        static void Main(string[] args)
        {
            int num = 63;
            kok(ref num);
        }
        static void kok(ref int n)
        {
             int i = 1;
            while(i*i<n)
            {
                i++;
            }
             Console.WriteLine(i-1);

        }
    }
}
