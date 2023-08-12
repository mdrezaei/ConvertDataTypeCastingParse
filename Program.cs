using System;

namespace ConsoleApp12_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1234567891;
            //long b = a;
            ////long b = (long)a;//لانگ درون پرانتز استفاده نمیشه نوشتنش هم موردی ندارد
            //Console.WriteLine(a + "   " + b);
            //----------------------------------------------
            //long b = 12345678;
            //int a = b;//اینجا ارور میده و میگه حتمن باید کست انجام بشه
            //double r = 123;
            //int t = r;//اینجا ارور میده و میگه حتمن باید کست انجام بشه
            //نمیشه مثل بالا چون لانگ بزرگتر از ظرفیت اینت هست
            //حتی اگر که لانگ مقدارش کمتر از مقدار اینت باشد.مثل بالا . باز هم ممکن نیست
            //-----------------------------------------------
            //long a = 1234567891;
            //int b = (int)a;
            //Console.WriteLine(a + "   " + b);
            ////کست کردیم و لانگ که در مثال بالا به اینت تبدیل نمیشد با تاییدیه ما شد

            //long x = 123456789123;
            //int y = (int)x;
            //Console.WriteLine(x + "   " + y);//در اینجا چون لانگ بزرگنر از اینت هست با تبدیل کردنش مقداری از اطلاعات هم حذف میشود که باعث میشه که نتیجه دلخواه رو نگیریم

            //double z = 123.123;
            //int u = (int)z;
            //Console.WriteLine(z + "   " + u);

            //int q = 123;
            //double w = q;
            //Console.WriteLine(q + "   " + w);

            //string e = "123";
            //int i = (int)e;//باید در این روش هم نوع باشند یعنی مثلا عددی باشند

            //--------------------------------------------------------------------------------

            //int o = 123;
            //string p = o.ToString();
            //Console.WriteLine(o + "  " + p);

            ////int oo = p;
            //int oo = int.Parse(p);
            //Console.WriteLine(oo+1);

            //int s = 123;
            //double d = s.ToDouble();
            //دیگه نداریم دیگه:) ههه

            //------------------------------------------------------------------------------------

            //دستور پارس رشته را به عدد تبدیل میکند

            //int f = int.Parse("123");
            //Console.WriteLine(f);

            //string g = "123";
            //int h = int.Parse(g);
            //Console.WriteLine(h);

            //double a = double.Parse("123.123");
            //Console.WriteLine(a+1.1);

            //string xx = "123.123";
            //int xy = int.Parse(xx);
            //Console.WriteLine(xy);
            //ارور میده که نمیشه ایکس ایکس رو تبدیل به اینت کرد

            //int number = int.Parse("12A");
            //Console.WriteLine(number);

            //در کد بالا چون ای12 عدد نیست خطا دریافت میکنیم پس برای مدریت خطا از کد پایی استفاده میکنیم

            //int.TryParse
            //این کد عدد برنمیگرداند بلکه مقداری از نوع بول برمیگرداند. وقتی موفق باشد ترو برمیگرداند

            //int j;
            //if (int.TryParse("123", out j))
            //{
            //    Console.WriteLine("success   " + j);
            //}
            //else
            //{
            //    // failed
            //}

            //string k = "123.123";
            //double l = double.Parse(k);
            //Console.WriteLine(l);

            //------------------------------------------------

            //Convert.To...();
            //که اشنا هستیم

            //string n = "10";
            //int nn = Convert.ToInt32(n);

            //int v = 10;
            //string vv = Convert.ToString(v);

            //و باقی این کانورت دات تو ها
            //Convert.ToBoolean();
            //Convert.ToDouble();
            //...

            //-------------------------------------------------------------------------------

            //char a = '5';
            //int b = a;
            //Console.WriteLine(b);
            //int c = 5;
            //char d = (char)c;
            //Console.WriteLine(d);
            //char e = '5';
            //int f = Convert.ToInt32(e);
            //Console.WriteLine(f);

            //string g = "5";
            ////int h = (int)g;//Error
            //int h = Convert.ToInt32(g);
            //Console.WriteLine(h);

            //long i = 111111111111111;
            ////int j = Convert.ToInt32(i);//Error
            //int j = (int)i;
            //Console.WriteLine(j);

            //double k = 1.1254327;
            ////int l = Convert.ToInt32(k);
            ////Console.WriteLine(l);
            //int m = (int)k;
            //Console.WriteLine(m);




        }
    }
}
