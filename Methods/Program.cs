
using System;


namespace Methods

{

    // Out ve Ref arasindaki fark:
    // Ref 'de num1 mutlaka set edilmiş olmali (yani değer atanmiş olmali) ama out'da böyle bir gereklilik yok
    class Methods
    {
        static void Main(string[] args)
        {
            Add();
            Add2(20, 30);
        

            int num1 = 50;
            int num2 = 80;
            var result = Add3(ref num1, num2);

            Console.WriteLine(result);
            Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int num1 = 20, int num2 = 40)
        {
            var result = num1 + num2;
            return result;
        }

        static int Add3(ref int num1, int num2)
        {
            num1 = 45;
            return num1 + num2;
        }
    }
}
