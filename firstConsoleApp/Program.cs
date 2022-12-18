using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace firstConsoleApp
{
    class Program
    {
        public static void Main()
        {
            //Ввести номер необходимого задания//
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                ////Практикум 3
                case 0:
                    Cases.Case4();         // 1
                    break;
                case 1:
                    AvgGeo.avgGeometric(); // 2
                    break;

                ////Практикум 4
                case 2:
                    Console.WriteLine(Formula.func(5));  // 1
                    break;
                case 3:
                    Formula.cards(2, 10);                // 2
                    break;
                case 4:
                    numSum.numsCase5(1, 150, 1);         // 3
                    break;
                case 5:
                    Formula.funcCase(-0.4, 0.3, 0.05);   // 4
                    break;

                ////Практикум 5
                case 6:
                    Console.WriteLine(Formula.func1Case(5, 15)); // 1
                    break;
                case 7:
                    Console.WriteLine(numSum.sumDigits(55));     // 2
                    break;
                case 8:
                    numSum.numsCase1(10, 200);                         // a
                    break;
                case 9:
                    numSum.numsCase2(10, 200, 5);                      // б
                    break;
                case 10:
                    numSum.numsCase3(10, 200);                         // в
                    break;
                case 11:
                    Console.WriteLine(numSum.numsCase4(10, 200, 3));   // г
                    break;

                ////Практикум 6
                case 12:
                    Arrs.ArrsCase1(Arrs.randArray(Convert.ToInt32(Console.ReadLine()))); // 1
                    break;
                case 13:
                    int[] testArr = { -1, -15, 3, -22, -15, -6, 6, 11, 2 };
                    Arrs.ArrsCase2(testArr);                                             // 2
                    break;

                ////Практикум 7
                case 14:
                    Stocks Akcii = new Stocks("BeeLine", 20, 12.5);
                    Akcii.buy(20, 18);
                    Akcii.show();
                    Akcii.sell(40, 15);
                    Akcii.buy(30, 30.5);
                    Akcii.show();
                    Akcii.sell(40, 30.5);
                    Akcii.show();
                    break;

                ////Практикум 8
                case 15:
                    Human human1 = new Human("Kozlov", "Clubnaya 2, 50", "04.07.2002");
                    human1.Print();
                    Student Student1 = new Student("Strelkov", "Staraya 3, 10", "01.09.2003", "1819-2", 4, 14591);
                    Student1.Print();
                    break;
                ////Visa
                case 16:
                    Visa card = new Visa("Sample User Name", 0987654321, 0);
                    card.add(1500);
                    card.info();
                    card.take(500);
                    card.info();
                    card.take(9000);
                    card.info();
                    break;
                case 17:
                    ////VisaPlus
                    VisaPlus card1 = new VisaPlus("Sample User Name", 0987654321, 0);
                    card1.add(1000);
                    card1.info();
                    card1.take(1300);
                    card1.info();
                    card1.add(1200);
                    card1.info();
                    break;

                ////Практикум 9
                case 18:
                    // 1
                    Book b1 = new Book("Sample title", "Sample author", 155.5);
                    b1.Print();
                    BookGenre b2 = new BookGenre("Sample genre", "Sample title1", "Sample author1", 1551.5);
                    b2.Print();
                    BookGenrePubl b3 = new BookGenrePubl("Sample genre1", "Sample title2", "Sample author2", 1521.5, "Sample Publisher");
                    b3.Print();
                    break;
                case 19:
                    // 2
                    Circle circ = new Circle();
                    Console.WriteLine(circ.GetType().Name);
                    circ.Radius = 1;
                    circ.countPerimeter();
                    circ.countSquare();
                    Console.WriteLine($"{circ.Perimeter}, {circ.Square}");

                    Rectangle rect = new Rectangle();
                    Console.WriteLine(rect.GetType().Name);
                    rect.a = 5;
                    rect.b = 10;
                    rect.countPerimeter();
                    rect.countSquare();
                    Console.WriteLine($"{rect.Perimeter}, {rect.Square}");

                    Triagle tria = new Triagle();
                    Console.WriteLine(tria.GetType().Name);
                    tria.a = 3;
                    tria.b = 4;
                    tria.c = 5;
                    tria.countPerimeter();
                    tria.countSquare();
                    Console.WriteLine($"{tria.Perimeter}, {tria.Square}");
                    break;

                //Практикум 10
                case 20:
                    Cases.Case4();
                    break;

                //Практикум 11
                case 21:
                    WiseTree.WisesHandler();
                    break;

                case 22:
                    Account account = new Account(200);
                    Account.AccountStateHandler colorDelegate = new Account.AccountStateHandler(Account.Color_Message);
                    account.RegisterHandler(colorDelegate);
                    account.Withdraw(100);
                    account.Withdraw(50);
                    account.Put(300);
                    account.Withdraw(100);
                    break;

                //Практикум 12
                case 23:
                    Arrs.ArrayListCase(Arrs.randArrayList(Convert.ToInt32(Console.ReadLine())));
                    break;

                case 24:
                    PlayersList players = new();
                    break;

                case 25:
                    HRQueue queue = new();
                    break;

                case 26:
                    EntrantRegister ent = new();
                    break;
            }
        }
    }
}