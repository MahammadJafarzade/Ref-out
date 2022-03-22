using System;

namespace Task2
{
    class Program
    {
//        2. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, 
//name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.
         static void Main(string[] args)
        {
            string name = " Hikmet Abbasov";
            Console.WriteLine(Fullname(ref name));
        }
        static string Fullname(ref string name)
        {
            string Fullname = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if(name[i] != ' ')
                {
                    Fullname += name[i];
                }
            }
            name = Fullname;
            return name;
        }
    }
}
