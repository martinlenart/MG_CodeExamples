using System;

namespace MG_CodeExample1
{
    struct Apple
    {
        public string Name;
        public string Taste;
        public string Color;

        public Apple (string name, string taste, string color)
        {
            Name = name;
            Taste = taste;
            Color = color;
        }
        public string StringToPrint()
        {
            return $"Apple has the name {Name}. It is {Color} and {Taste}";
        }
        public string StringToPrint1() => $"Apple has the name {Name}. It is {Color} and {Taste}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Apple myApple1 = new Apple("Ingrid Marie", "Red", "Delicious");
            //Console.WriteLine($"myApple1 has the name {myApple1.Name}. It is {myApple1.Color} and {myApple1.Taste}");
            //Console.WriteLine(StringToPrint(myApple1));
            Console.WriteLine(myApple1.StringToPrint());

            Apple myApple2 = new Apple { Name = "Granny Smith", Color = "Green", Taste = "Sour"};
            //Console.WriteLine($"myApple2 has the name {myApple2.Name}. It is {myApple2.Color} and {myApple2.Taste}");
            //Console.WriteLine(StringToPrint(myApple2));
            Console.WriteLine(myApple2.StringToPrint1());

            Apple[] apples = new Apple[4];
            apples[0] = new Apple("Ingrid Marie", "Red", "Delicious");
            apples[1] = new Apple { Name = "Granny Smith", Color = "Green", Taste = "Sour" };
            apples[2] = new Apple("Golden Delicous", "Yellow", "Bitter");
            apples[3] = new Apple { Name = "Granny Smith", Color = "Yellow", Taste = "Good" };

            Console.WriteLine();
            foreach (var item in apples)
            {
                if (item.Taste == "Sour")
                    continue;
                Console.WriteLine(item.StringToPrint1());
            }

            Console.WriteLine();
            for (int i = 0; i < apples.Length; i++)
            {
                if (apples[i].Taste == "Bitter") 
                    continue;

                Console.WriteLine(apples[i].StringToPrint1());
            }
        }

        static string StringToPrint(Apple anApple)
        {
            string sRet = $"Apple has the name {anApple.Name}. It is {anApple.Color} and {anApple.Taste}";
            return sRet;
        }
    }
}
