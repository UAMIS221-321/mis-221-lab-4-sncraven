//System.Console.WriteLine("enter a number");
//int count = int.Parse(Console.ReadLine());
//for (int i=0; i<=count; i++) {
//    for (int j=0; j<=i; j++) {
//       Console.Write("*");
//    }
//    Console.Write("\n");
//}

Random rnd = new Random();
int number = rnd.Next();
System.Console.WriteLine("enter a number");
int count = int.Parse(Console.ReadLine());
for (int i=0; i<=count; i++) {
    for (int j=0; j<=i; j++) {
        System.Console.WriteLine(rnd.Next(2));
        Console.Write("*");
    }
    Console.Write("\n");
}

    