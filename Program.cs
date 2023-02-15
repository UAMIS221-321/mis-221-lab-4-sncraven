GetFull();
GetPartial();

static void GetFull() {
    System.Console.WriteLine("enter a number 3-9");
    int count = int.Parse(Console.ReadLine());
    for (int i=0; i<= count; i++) {
        for (int j=0; j<=i; j++) {
        Console.Write("o");
        }
        Console.Write("\n");
    }
}



static void GetPartial() {
    Random rnd = new Random();
    int number = rnd.Next(3,9);
    for (int i = 0; i < number; i++) {
        for (int j = 0; j <= i; j++) { 
            int choice = rnd.Next(2);
            if (choice == 0) {
            Console.Write("o");
            }
        }
        Console.Write("\n");
    }
        
}
    


    