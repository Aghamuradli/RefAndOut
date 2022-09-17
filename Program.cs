using System;

namespace RefOutDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------Ref Keyword------
            #region MainExpression
            //int a = 5;
            //ref int b = ref a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a *= 5;
            //Console.WriteLine(b); //b ekrana yazdirdimiz halda ekrana 25 cixir cunki ikisi de eyni yaddas adresinden gelir.

            //b -= 10;
            //Console.WriteLine(a);//a ekrana yazdirdimiz halda ekrana 25 cixir cunki ikisi de eyni yaddas adresinden gelir.
            #endregion
            #region Expression2
            //int y = 10;
            //X(ref y);
            //Console.WriteLine(y);
            //void X(ref int a)
            //{
            //    a = 25;
            //}
            #endregion
            #region RefReturns
            ////RefReturns - sadece metodlarda istifade olunur.
            ////Metdlar geriye deyer dondure bilir deye obyekt de dondure bilerik . deger tipli degisenleri geriye donderirik.
            //    int a = 5;
            //    int b = X(ref a);
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);

            //    ref int X(ref int y)
            //    {
            //        y = 25;
            //        return ref y;
            //}
            #endregion
            //------Out Keyword------
            #region MainExpression
            //Out Keywordu - metodlari paramtrler uzerinden cole deyer gonderen bir keyworddur.
            //bir metodda prarametre yaradanda varsayilan olaraq o INPUTdur .
            //Eger bir metodun cole deyer gondermesini isteyirikse o OUTla isarelenmelidir.

            //int a = X(out int _b , 333 , out int _d);
            //Console.WriteLine(_b);
            //Console.WriteLine(_d);

            //int X(out int b, int c, out int d)
            //{
            //    // bir metodda out parametreleri varsa icerisinde degerleri verilmelidir ! Eks Teqdirde error nverecek .
            //    b = 25;
            //    d = 20;
            //    return 0;
            //}
            #endregion
            #region TryParse
            string a = Console.ReadLine();
            if (int.TryParse(a, out int r))
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("NO!");
            }
            #endregion
        }
    }
}
