﻿// Tumakov

namespace Programm
{
    public class Tumakov
    {
        /* #1 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
        банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
        доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
        вывести информацию об объекте класса на печать. */
        public static void Task1()
        {
            Console.WriteLine("Ответ на 1 задание: ");
            // Создаем объект банковского счета
            BankAccount account = new BankAccount("1234567890", 1000.50m, AccountType.Savings);

            // Вывод информации о счете
            account.DisplayAccountInfo();

            // Обновляем баланс
            Console.WriteLine("Обновление баланса...");
            account.UpdateBalance(500.75m);

            // Изменяем тип счета
            Console.WriteLine("Изменение типа счета...");
            account.ChangeAccountType(AccountType.Checking);

            // Вывод обновленной информации
            Console.WriteLine("Обновленная информация о счете:");
            account.DisplayAccountInfo();
            Console.WriteLine();
        }
        /* #2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
        номер счета генерировался сам и был уникальным.Для этого надо создать в классе
        статическую переменную и метод, который увеличивает значение этого переменной. */
        public static void Task2()
        {
            Console.WriteLine("Ответ на 2 задание: ");
            BankAccount2 account2 = new BankAccount2("1234567890", 1000.50m, AccountType2.Savings2);

            account2.DisplayAccountInfo2();

            Console.WriteLine("Обновление баланса...");
            account2.UpdateBalance2(500.75m);

            Console.WriteLine("Изменение типа счета...");
            account2.ChangeAccountType2(AccountType2.Checking2);

            Console.WriteLine("Обновленная информация о счете:");
            account2.DisplayAccountInfo2();
            Console.WriteLine();
        }

        /* #3 Добавить в класс счет в банке два метода: снять со счета и положить на
        счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
        положительного результата изменяет баланс.*/
        public static void Task3()
        {
            Console.WriteLine("Ответ на 3 задание: ");
            BankAccount3 account3 = new BankAccount3("1234567890", 1000.50m, AccountType3.Savings3);

            account3.DisplayAccountInfo3();

            Console.WriteLine("Пополнение счета...");
            account3.Deposit3(300.00m);

            Console.WriteLine("Снятие средств...");
            account3.Withdraw3(500.00m);

            Console.WriteLine("Снятие средств (сумма превышает баланс)...");
            account3.Withdraw3(2000.00m);

            Console.WriteLine("Пополнение счета (некорректная сумма)...");
            account3.Deposit3(-50.00m);

            Console.WriteLine("Обновленная информация о счете:");
            account3.DisplayAccountInfo3();
            Console.WriteLine();
        }
        // #1

        // Перечислимый тип для банковского счета
        public enum AccountType
            {
                Savings,    // Сберегательный
                Checking,   // Расчетный
                Business    // Бизнес-счет
            }

        // Класс банковского счета
        public class BankAccount
        {
            // Закрытые поля
            private string accountNumber;
            private decimal balance;
            private AccountType accountType;

            // Конструктор для создания счета
            public BankAccount(string accountNumber, decimal initialBalance, AccountType accountType)
            {
                this.accountNumber = accountNumber;
                this.balance = initialBalance;
                this.accountType = accountType;
            }

            // Метод для чтения информации о счете
            public void DisplayAccountInfo()
            {
                Console.WriteLine("Информация о счете:");
                Console.WriteLine($"Номер счета: {accountNumber}");
                Console.WriteLine($"Баланс: {balance:C}");
                Console.WriteLine($"Тип счета: {accountType}");
            }

            // Метод для изменения баланса
            public void UpdateBalance(decimal amount)
            {
                balance += amount;
                Console.WriteLine($"Баланс обновлен. Новый баланс: {balance:C}");
            }

            // Метод для получения текущего баланса
            public decimal GetBalance()
            {
                return balance;
            }

            // Метод для получения типа счета
            public AccountType GetAccountType()
            {
                return accountType;
            }

            // Метод для изменения типа счета
            public void ChangeAccountType(AccountType newType)
            {
                accountType = newType;
                Console.WriteLine($"Тип счета изменен на: {accountType}");
            }
        }

        // #2 

        public enum AccountType2
        {
            Savings2,    // Сберегательный
            Checking2,   // Расчетный
            Business2    // Бизнес-счет
        }

        // Класс банковского счета
        public class BankAccount2
        {
            // Закрытые поля
            private string accountNumber2;
            private decimal balance2;
            private AccountType2 accountType2;

            // Конструктор для создания счета
            public BankAccount2(string accountNumber2, decimal initialBalance2, AccountType2 accountType2)
            {
                this.accountNumber2 = accountNumber2;
                this.balance2 = initialBalance2;
                this.accountType2 = accountType2;
            }

            // Метод для чтения информации о счете
            public void DisplayAccountInfo2()
            {
                Console.WriteLine("Информация о счете:");
                Console.WriteLine($"Номер счета: {accountNumber2}");
                Console.WriteLine($"Баланс: {balance2:C}");
                Console.WriteLine($"Тип счета: {accountType2}");
            }

            // Метод для изменения баланса
            public void UpdateBalance2(decimal amount2)
            {
                balance2 += amount2;
                Console.WriteLine($"Баланс обновлен. Новый баланс: {balance2:C}");
            }

            // Метод для получения текущего баланса
            public decimal GetBalance2()
            {
                return balance2;
            }

            // Метод для получения типа счета
            public AccountType2 GetAccountType2()
            {
                return accountType2;
            }

            // Метод для изменения типа счета
            public void ChangeAccountType2(AccountType2 newType2)
            {
                accountType2 = newType2;
                Console.WriteLine($"Тип счета изменен на: {accountType2}");
            }
        }

        // #3

        // Перечислимый тип для банковского счета
        enum AccountType3
        {
            Savings3,    // Сберегательный
            Checking3,   // Расчетный
            Business3    // Бизнес-счет
        }

        // Класс банковского счета
        class BankAccount3
        {
            // Закрытые поля
            private string accountNumber3;
            private decimal balance3;
            private AccountType3 accountType3;

            // Конструктор для создания счета
            public BankAccount3(string accountNumber3, decimal initialBalance3, AccountType3 accountType3)
            {
                this.accountNumber3= accountNumber3;
                this.balance3 = initialBalance3;
                this.accountType3 = accountType3;
            }

            // Метод для чтения информации о счете
            public void DisplayAccountInfo3()
            {
                Console.WriteLine("Информация о счете:");
                Console.WriteLine($"Номер счета: {accountNumber3}");
                Console.WriteLine($"Баланс: {balance3:C}");
                Console.WriteLine($"Тип счета: {accountType3}");
            }

            // Метод для изменения баланса (вклад на счет)
            public void Deposit3(decimal amount3)
            {
                if (amount3 <= 0)
                {
                    Console.WriteLine("Сумма депозита должна быть больше нуля.");
                    return;
                }

                balance3 += amount3;
                Console.WriteLine($"Вы успешно положили на счет {amount3:C}. Новый баланс: {balance3:C}");
            }

            // Метод для снятия средств со счета
            public void Withdraw3(decimal amount3)
            {
                if (amount3 <= 0)
                {
                    Console.WriteLine("Сумма для снятия должна быть больше нуля.");
                    return;
                }

                if (amount3 > balance3)
                {
                    Console.WriteLine("Недостаточно средств на счете для снятия.");
                    return;
                }

                balance3 -= amount3;
                Console.WriteLine($"Вы успешно сняли со счета {amount3:C}. Новый баланс: {balance3:C}");
            }

            // Метод для получения текущего баланса
            public decimal GetBalance3()
            {
                return balance3;
            }

            // Метод для получения типа счета
            public AccountType3 GetAccountType3()
            {
                return accountType3;
            }

            // Метод для изменения типа счета
            public void ChangeAccountType3(AccountType3 newType3)
            {
                accountType3 = newType3;
                Console.WriteLine($"Тип счета изменен на: {accountType3}");
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Task1();
                Task2();
                Task3();
            }
        }
    }
}