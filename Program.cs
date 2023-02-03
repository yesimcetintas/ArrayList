using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        // list.Add("Ayşe");
        // list.Add(2);
        // list.Add(true);
        // list.Add("a");

        // Console.WriteLine("*****Verilere Erişim*****");

        // foreach (var item in list)
        // {
        //     Console.WriteLine(item);
        // }

        Console.WriteLine("*****AddRange*****");
        // string[] renkler= {"kırmızı", "sarı", "yesil"};
        List<int> sayilar= new List<int>(){1,8,3,7,9,92,5};
        // list.AddRange(renkler);
        list.AddRange(sayilar);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("*****Sort******");
        list.Sort();

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("****Binary Search******");
        Console.WriteLine(list.BinarySearch(9));

        Console.WriteLine("*****Reverse*****");
        list.Reverse();
        foreach (var item in list)
        {
            Console.WriteLine(item);   
        }

        Console.WriteLine("****Clear****");
        list.Clear();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }
}