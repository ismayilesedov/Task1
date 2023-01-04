namespace Taskkk111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}



#region MyTask1
internal class task1
{
    static void Task1()
    {
        //4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.
        Console.WriteLine("       Programa xosh gelmisiniz ");
        Console.Write("a :");
    label1:
        string inputvalue = Console.ReadLine();
        int a;
        int.TryParse(inputvalue, out a);

        if (int.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
        }
        if (a >= 1000 && a < 9999)
        {
            a = 70000 + a;
            a = a * 10 + 8;

            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto label1;

        }
    }
}

#endregion

#region MyTask2
internal class task2
{
    static void Task2()
    {
        // 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir
        Console.WriteLine("       Programa xosh gelmisiniz ");
        Console.WriteLine("a: ");
    label1:
        string inputvalue = Console.ReadLine();
        int a;
        int a1;
        int.TryParse(inputvalue, out a);
        if (int.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
            return;

        }
        if (a <= 1000 && a > 100)
        {
            a1 = (a * 1000);
            a1 = a1 + a;
            Console.WriteLine("Cavab :" + a1);
            return;

        }
        else
        {
            Console.WriteLine("duzgun ededi daxil edin");
            goto label1;

        }
    }
}
#endregion

#region MyTask3
internal class task3
{
    static void Task3()
    {
        //5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap
        Console.WriteLine("       Programa xosh gelmisiniz ");
        Console.Write("a : ");
    label1:
        string inputvalue = Console.ReadLine();
        double a;
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto label1;
            return;

        }
        if (a <= 100000 && a > 10000)
        {
            a = (a * 18) / 100;
            a = (a * 3) / 100;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto label1;
        }
    }
}
#endregion

#region MyTask4
internal class task4
{
    static void Task4()
    {
        // 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap
        Console.WriteLine("       Programa xosh gelmisiniz ");
        Console.Write("a: ");
    label1:
        double a;
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto label1;
        }
        if (a > 99 && a <= 999)
        {
            a = a * 10;
            a = a + 7;
            a = (a * 7) / 100;
            Console.WriteLine("Cavab :" + a);
            return;

        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto label1;
        }


    }
}
#endregion

#region MyTask5
internal class task5
{
    static void Task5()
    {
        //4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.
        Console.WriteLine("       Programa xosh gelmisiniz ");
        Console.WriteLine("a: ");
    label1:
        double a;
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)

        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
        }
        if (a > 999 && a <= 9999)
        {
            a = 40000 + a;
            a = a * 100 + 44;
            a = (a * 44) / 100;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Ededi duzgun daxil edin");
            goto label1;
        }
    }
}
#endregion

#region MyTask6
internal class task6
{
    static void Task6()
    {
        //4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap.
        Console.WriteLine("       Programa xosh gelmisiniz ");
        Console.WriteLine("4 reqemli ededi daxil edin: ");
        double a;

    label1:
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;

        }
        if (a > 999 && a <= 9999)
        {
            a = (a * 20) / 100;
            a = (a * 10) / 100;
            a = a * a;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto label1;
        }
    }
}
#endregion

#region MyTask7
internal class task7
{
    static void Task7()
    {
        //2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap
        Console.WriteLine("       Programa xosh gelmisiniz ");
        double a;
        double b;
    label1:
        Console.WriteLine("5 reqemli ededi daxil edin: ");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin: ");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
        }

        if (a > 9999 && a <= 99999 && (b > 9999 && b <= 99999))
        {
            a = a + b;
            a = 500000 + a;
            a = a * 10;
            a = a + 5;
            a = (a * 5) / 100;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto label1;
        }
    }
}
#endregion

#region MyTask8
internal class task8
{
    static void Task8()
    {
        //2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.I ededin 4%-ni tap.sonra II ededin 9% ni tap.
        //Sonra Cavalari toplayib 10 %ni tap.
        {
            Console.WriteLine("       Programa xosh gelmisiniz ");
            double a;
            double b;
        label1:
            Console.WriteLine("4 reqemli ededi daxil edin: ");
            string inputvalue = Console.ReadLine();
            double.TryParse(inputvalue, out a);
            if (double.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Tam eded daxil edin");
                goto label1;
            }
            Console.WriteLine("7 reqemli ededi daxil edin: ");
            string inputvalue2 = Console.ReadLine();
            double.TryParse(inputvalue2, out b);
            if (double.TryParse(inputvalue2, out b) != true)
            {
                Console.WriteLine("Tam eded daxil edin");
                goto label1;
            }
            if (a > 999 && a <= 9999 && (b > 999999 && b <= 9999999))
            {
                a = (a * 4) / 100;
                b = (b * 9) / 100;
                a = a + b;
                a = (a * 10) / 100;
                Console.WriteLine("Cavab :" + a);
                return;
            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }
        }
    }
}
#endregion

#region MyTask9
internal class task9
{
    //3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.
    static void Task9()
    {

        double a;
        double b;
        double c;
        Console.WriteLine("       Programa xosh gelmisiniz ");
    label1:
        Console.WriteLine("6 reqemli ededi daxil edin: ");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin: ");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin: ");
        string inputvalue3 = Console.ReadLine();
        double.TryParse(inputvalue3, out c);
        if (double.TryParse(inputvalue3, out c) != true)
        {
            Console.WriteLine("Tam eded daxil edin");
            goto label1;
        }
        if (a > 99999 && a <= 999999 && (b > 99999 && b <= 999999) && (c > 99999 && c <= 999999))
        {
            a = (a * 10) / 100;
            b = (b * 10) / 100;
            c = (c * 10) / 100;
            a = a + b + c;
            a = (a * 10) / 100;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("duzgun ededi daxil edin");
            goto label1;
        }
    }
}
#endregion

#region MyTask10
internal class task10
{
    // 3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
    //Neticeleri bir birinden cix.Alinan cavabin ustune III ededin 7% faizini gel
    static void Task10()
    {

        double a;
        double b;
        double c;
        Console.WriteLine("       Programa xosh gelmisiniz ");
    Label1:
        Console.WriteLine("4 reqemli ededi daxil edin");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("4 reqemli ededi daxil edin");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("4 reqemli ededi daxil edin");
        string inputvalue3 = Console.ReadLine();
        double.TryParse(inputvalue3, out c);
        if (double.TryParse(inputvalue3, out c) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        if (a > 999 && a <= 9999 && (b > 999 && b <= 9999) && (c > 999 && c <= 9999))
        {
            a = (a * 1) / 100;
            b = (b * 2) / 100;
            c = (c * 3) / 100;
            a = a - b - c;
            c = (c * 7) / 100;
            a = a + c;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto Label1;
        }
    }
}
#endregion

#region MyTask11
internal class Task11
{
    // 4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel. 
    // Sonra cavablari vur birbirine.Alinan neticeden III ededin 3%-ni cix.
    static void task11()
    {
        double a;
        double b;
        double c;
        double d;
        Console.WriteLine("         Programa xosh gelmisiniz");
    Label1:
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue3 = Console.ReadLine();
        double.TryParse(inputvalue3, out c);
        if (double.TryParse(inputvalue3, out c) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue4 = Console.ReadLine();
        double.TryParse(inputvalue4, out d);
        if (double.TryParse(inputvalue4, out d) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        if (a > 9999 && a <= 99999 && (b > 9999 && b <= 99999) && (c > 9999 && c <= 99999) && (d > 9999 && d <= 99999))
        {
            a = a + c;
            b = b + d;
            a = a * b;
            c = (c * 3) / 100;
            a = a - c;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
        }

    }
}
#endregion

#region MyTask12
internal class task12
{
    static void Task12()
    {
        //4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla. 
        //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.
        double a; double a1;
        double b;
        double c;
        double d;

        Console.WriteLine("      Programa xosh gelmisiniz");
    Label1:
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue3 = Console.ReadLine();
        double.TryParse(inputvalue3, out c);
        if (double.TryParse(inputvalue3, out c) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue4 = Console.ReadLine();
        double.TryParse(inputvalue4, out d);
        if (double.TryParse(inputvalue4, out d) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        if (a > 99999 && a <= 999999 && (b > 99999 && b <= 999999) && (c > 99999 && c <= 999999) && (d > 99999 && d <= 999999))
        {
            a = (a * 10) / 100;
            b = (b * 10) / 100;
            c = (c * 10) / 100;
            d = (d * 10) / 100;
            a1 = a + b + c + d;
            a = (a * 15) / 100;
            b = (b * 15) / 100;
            c = (c * 15) / 100;
            d = (d * 15) / 100;
            a = a + b + c + d;
            a = a1 + a;
            a = (a * 10) / 100;
            a = (a * 11) / 100;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto Label1;
        }
    }
}
#endregion

#region MyTask13
internal class task13
{
    static void Task13()
    //  5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine. 
    //Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.
    {
        double a; double d;
        double b; double e;
        double c;

        Console.WriteLine("      Programa xosh gelmisiniz");
    Label1:
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue3 = Console.ReadLine();
        double.TryParse(inputvalue3, out c);
        if (double.TryParse(inputvalue3, out c) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("3 reqemli ededi daxil edin");
        string inputvalue4 = Console.ReadLine();
        double.TryParse(inputvalue4, out d);
        if (double.TryParse(inputvalue4, out d) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("3 reqemli ededi daxil edin");
        string inputvalue5 = Console.ReadLine();
        double.TryParse(inputvalue5, out e);
        if (double.TryParse(inputvalue5, out e) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        if (a > 9999 && a <= 99999 && (b > 9999 && b <= 99999) && (c > 9999 && c <= 99999) && (d > 99 && d <= 999) && (e > 99 && e <= 999))
        {
            a = (a * 5) / 100;
            b = (b * 5) / 100;
            c = (c * 5) / 100;
            a = a * b * c;
            d = (d * 3) / 100;
            e = (e * 3) / 100;
            d = a + e;
            a = (a * 10) / 100;
            d = (d * 10) / 100;
            a = a + d;
            Console.WriteLine("Cavab :" + a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto Label1;
        }
    }
}
#endregion

#region MyTask14
internal class task14
{
    static void Task14()
    //6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
    // I neticeden II neticeni cix.Alinan cavabin 10% tap.Neticenin uzerine V ve VI ededleri gel.Yekunda alinan cavabin 11% tap
    {
        double a; double b; double n;
        double c; double d; double e;
        Console.WriteLine("      Programa xosh gelmisiniz");
    Label1:
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue3 = Console.ReadLine();
        double.TryParse(inputvalue3, out c);
        if (double.TryParse(inputvalue3, out c) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue4 = Console.ReadLine();
        double.TryParse(inputvalue4, out d);
        if (double.TryParse(inputvalue4, out d) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue5 = Console.ReadLine();
        double.TryParse(inputvalue5, out e);
        if (double.TryParse(inputvalue5, out e) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue6 = Console.ReadLine();
        double.TryParse(inputvalue6, out n);
        if (double.TryParse(inputvalue6, out n) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        if (a > 99999 && a <= 999999 && (b > 99999 && b <= 999999) && (c > 99999 && c <= 999999) && (d > 99999 && d <= 999999) && (e > 99999 && e <= 999999) && (n > 99999 && n <= 999999))
        {
            b = a + b + c + d + e + n;
            d = a * 1000000 + c;
            a = b - d;
            a = (a * 10) / 100;
            a = a + e + n;
            a = (a * 11) / 100;
            Console.WriteLine(a);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto Label1;
        }

    }
}
#endregion

#region MyTask15
internal class task15
{
    static void Task15()
    //7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
    // 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
    // Sonra neticenin axirina 7 reqemini artir.Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
    //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
    //Sonra alinan cavabin ustune gel 6 reqemli ededi.
    //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
    //Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
    //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
    {
        double a; double b; double n; double x;
        double c; double d; double e; double menimset;
        Console.WriteLine("      Programa xosh gelmisiniz");
    Label1:
        Console.WriteLine("3 reqemli ededi daxil edin");
        string inputvalue = Console.ReadLine();
        double.TryParse(inputvalue, out a);
        if (double.TryParse(inputvalue, out a) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("3 reqemli ededi daxil edin");
        string inputvalue2 = Console.ReadLine();
        double.TryParse(inputvalue2, out b);
        if (double.TryParse(inputvalue2, out b) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("4 reqemli ededi daxil edin");
        string inputvalue3 = Console.ReadLine();
        double.TryParse(inputvalue3, out c);
        if (double.TryParse(inputvalue3, out c) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("4 reqemli ededi daxil edin");
        string inputvalue4 = Console.ReadLine();
        double.TryParse(inputvalue4, out d);
        if (double.TryParse(inputvalue4, out d) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue5 = Console.ReadLine();
        double.TryParse(inputvalue5, out e);
        if (double.TryParse(inputvalue5, out e) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("5 reqemli ededi daxil edin");
        string inputvalue6 = Console.ReadLine();
        double.TryParse(inputvalue6, out n);
        if (double.TryParse(inputvalue6, out n) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        Console.WriteLine("6 reqemli ededi daxil edin");
        string inputvalue7 = Console.ReadLine();
        double.TryParse(inputvalue7, out x);
        if (double.TryParse(inputvalue7, out x) != true)
        {
            Console.WriteLine("Tam ededi daxil edin");
            goto Label1;
        }
        if (a > 99 && a <= 999 && (b > 99 && b <= 999) && (c > 999 && c <= 9999) && (d > 999 && d <= 9999) && (e > 9999 && e <= 99999) && (n > 9999 && n <= 99999) && (x > 99999 && x <= 999999))
        {

            a = a + b;
            c = c * d;
            a = a + c;
            a = a * 10;
            a = a + 7;
            menimset = e + n;
            menimset = a + menimset;
            a = a * b;
            a = a * 10;
            a = a + 1;
            menimset = menimset - a;
            menimset = menimset + x;
            x = a + b + c + d;
            menimset = menimset - x;
            menimset = (menimset * 18) / 100;
            menimset = (menimset * 3) / 100;
            menimset = (menimset * 1) / 100;
            x = e + n;
            menimset = menimset + x;
            Console.WriteLine(menimset);
            return;
        }
        else
        {
            Console.WriteLine("Duzgun ededi daxil edin");
            goto Label1;
        }


    }
}
#endregion

