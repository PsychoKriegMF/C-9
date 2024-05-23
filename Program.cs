namespace C_9
{
    //Исключения
    internal class Program 
    {
        static void Main(string[] args)
        {
            try 
            { }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { } // выполниться даже при сработке исключения

            Money money1 = new Money(100, 50);
            Money money2 = new Money(50, 25);
            Console.WriteLine(money1.ToString());
            Console.WriteLine(money2.ToString());
            try
            {
                //BankruptException банкрота, денег меньше нуля
                //Money m = money1 - new Money(100, 55);


                //Exception деления на ноль
                //int a = Convert.ToInt32(Console.ReadLine());
                //Money sum2 = money1 / a;
                //Console.WriteLine(sum2.ToString());

                Money sum = money1 + money2;
                Console.WriteLine(sum.ToString());

                Money diff = money1 - money2;
                Console.WriteLine(diff.ToString());

                Money div = money1 / 2;
                Console.WriteLine(div.ToString());

                Money mul = money2 * 2;
                Console.WriteLine(mul.ToString());

                Money inc = ++money2;
                Console.WriteLine(inc.ToString());

                Money dec = --money2;
                Console.WriteLine(dec.ToString());

                Console.WriteLine("Money 1 > Money 2 : " + (money1 > money2));
                Console.WriteLine("Money 1 < Money 2 : " + (money1 < money2));
                Console.WriteLine("Money 1 == Money 2 : " + (money1 == money2));
            }
            catch(BankruptException ex)
            {
                Console.WriteLine("Bankrupt ex : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            

            try
            {
                Console.WriteLine("Введите число -> ");                
                int num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch(OverflowException) 
            {
                Console.WriteLine("Число выходит за границы диапазона");
            }
            catch (FormatException)
            {
                Console.WriteLine("Значение не является числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка" + ex.Message);
            }

            try
            {
                Console.WriteLine("Введите ваш возраст ->");
                int rage = int.Parse(Console.ReadLine());
                if(rage >= 18)
                {
                    Console.WriteLine("Добро пожаловать!");
                }                
                else
                {
                    throw new UnderRageException("Доступ запрещен! Ты пЕздюк!!!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Значение не является числом");
            }
            catch (UnderRageException ex)
            {
               Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка" + ex.Message);
            }

            StudentManagementSystem stu = new StudentManagementSystem();
            stu.AddStudent("asd", 35);
            stu.AddStudent("ad", 30);
            stu.AddStudent("sd", 32);
            stu.RemoveStudent("sd");
            stu.Print();


            //Console.WriteLine(stu.GetStudent("asd"));
        }
    }
}
