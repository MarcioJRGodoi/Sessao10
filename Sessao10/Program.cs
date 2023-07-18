using Sessao10.Entities;
using Sessao10.Entities.Enums;
using System.Globalization;

namespace sessao10
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.WriteLine("Health expenditures: ");
                    double healthExpendifures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExpendifures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employes = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employes));
                }
                
            }
            double sum = 0.0;
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name} $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            //List<Shape> shapes = new List<Shape>();

            //Console.WriteLine("Enter the number of shapes: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Shape #{i + 1} data: ");
            //    Console.Write("Ractangle or Circle (r/c)? ");
            //    char ch = char.Parse(Console.ReadLine());
            //    Console.Write("Color (Back/BLue/Red): ");
            //    Color color = Enum.Parse<Color>(Console.ReadLine());

            //    if(ch == 'r')
            //    {
            //        Console.Write("Width: ");
            //        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        Console.Write("Height: ");
            //        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        shapes.Add(new Rectangle(width, height, color));
            //    }
            //    else
            //    {
            //        Console.Write("Radius: ");
            //        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        shapes.Add(new Circle(radius, color));
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("SHAPE AREAS: ");
            //foreach (Shape shape in shapes)
            //{
            //    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            //}

            //List<Account> accounts = new List<Account>();

            //accounts.Add(new SavingAccount(1001, "Alex", 500.00, 0.01));
            //accounts.Add(new BusinessAccount(1002, "Maria", 500.00, 400));
            //accounts.Add(new SavingAccount(1003, "Bob", 500.00, 0.01));
            //accounts.Add(new BusinessAccount(1004, "Anna", 500.00, 500));

            //double sum = 0.0;
            //foreach (Account account in accounts)
            //{
            //    sum += account.Balance;
            //}
            //Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));

            //foreach (Account account in accounts) {
            //    account.Withdraw(10.0);
            //}

            //foreach (Account account in accounts)
            //{
            //    Console.WriteLine($"Saldo atualziado da conta {account.Number}: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            //}
            //List<Product> products = new List<Product>();

            //Console.Write("Enter the number of products: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Product #{i + 1} data: ");
            //    Console.Write("Common, used or imported (c/u/i)? ");
            //    char ch = char.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    if (ch == 'i')
            //    {
            //        Console.Write("Customs Fee: ");
            //        double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        products.Add(new ImportedProduct(name, price, customsfee));
            //    } else if (ch == 'u')
            //    {
            //        Console.Write("Manufacture date: (DD/MM/YYYY): ");
            //        DateTime manufacture = DateTime.Parse(Console.ReadLine());
            //        products.Add(new UsedProduct(name, price, manufacture));
            //    }
            //    else
            //    {
            //        products.Add(new Product(name, price));
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Price Tags");


            //foreach(Product product in products)
            //{
            //    Console.WriteLine(product.PriceTag());
            //}


            //List<Employe> list = new List<Employe>();

            //Console.Write("Enter the number of employees: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Employee #{i + 1} data: ");
            //    Console.Write("Outsourced (y/n)? ");
            //    char ch = char.Parse(Console.ReadLine());
            //    Console.Write("Nome: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Hours: ");
            //    int hours = int.Parse(Console.ReadLine());
            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    if( ch == 'y')
            //    {
            //        Console.Write("Aditional Charge: ");
            //        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        list.Add(new OutsourceEmploye(name, hours,valuePerHour, additionalCharge));
            //    }
            //    else
            //    {
            //        list.Add(new Employe(name, hours, valuePerHour));
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("PAYMENTS:");
            //foreach (Employe employe in list)
            //{
            //    Console.WriteLine($"{employe.Name} - $ {employe.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            //}

            //Account acc1 = new Account(1001, "Alex", 500);
            //Account acc2 = new SavingAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);



            ////BusinessAccount account = new BusinessAccount(8010, "Marcio", 100.0, 500.0);
            ////Console.WriteLine(account.Balance);

            //Account acc = new Account(1001, "Alex", 0);
            //BusinessAccount bacc = new BusinessAccount(1102, "maria", 0, 500.00);


            ////Upcasting
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            //Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);


            ////DownCasting
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100);

            ////BusinessAccount acc5 = (BusinessAccount)acc3;
            //if(acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(100);
            //    Console.WriteLine("Loan!");
            //}
            //if(acc3 is SavingAccount)
            //{
            //    //SavingAccount acc5 = (SavingAccount)acc3;
            //    SavingAccount acc5 = acc3 as SavingAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}
        }
    }
}
