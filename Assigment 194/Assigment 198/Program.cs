using System;
using System.Collections.Generic;

    class Program
    {
    static void Main()

    {

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        List<string> players = new List<string>();
        players.Add("Peter");
        players.Add("Lucas");
        players.Remove("Mark");

        Console.WriteLine(players[0]);
        Console.ReadLine();



        int[] numArray1 = {6, 9, 10, 100, 4000, 8000};
        Console.WriteLine(numArray1[0]);
        Console.ReadLine();

         }
}
