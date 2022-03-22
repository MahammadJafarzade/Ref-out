using System;

namespace Task1
{
    class Program
    {
//        Parameter olaraq integer array variable-i ve bir integer value qebul eden ve
//        hemin integer value-nu integer array-e yeni element kimi elave eden metod.
//Misal üçün int[] nums = { 1, 5, 7 } deyə bir variable-mız var.yazdığımız metodu çağırıb
//arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  { 1,5,7,3}  olmalıdır.
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 7 };
            int num = 3;
            smth(ref nums, num);
        }
        static void smth(ref int[] nums,int num)
        {
            int[] newarray = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                newarray[i] = nums[i];
            }
            newarray[nums.Length] = num;
            nums = newarray;
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}
