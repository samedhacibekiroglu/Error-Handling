using System;

namespace Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                sayı = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı: " + sayı);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem bitti");
            }
        }
    }
}
