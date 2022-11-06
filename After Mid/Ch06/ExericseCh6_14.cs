using System;
using System.IO;
using System.Threading;

class Account // 계정 클래스
{
    private double balance;
    public Account(double initialDeposit) // 생성자
    {
        balance = initialDeposit;
    }
    public double Balance // 프로퍼티
    {
        get { return balance; } // 잔액 조희
        //set { balence = value; } 
    }
    public void Deposit(double amount) // 총액 계산 및 기록
    {
        lock (this)
        {
            balance += amount;
        }
    }
}
class Teller            // 은행원 클래스
{
    string name;        // 은행원 이름
    Account account;    // 처리할 계정
    double amount;      // 예금액
    public Teller(string name, Account account, double amount)
    {
        this.name = name;
        this.account = account;
        this.amount = amount;
    }
    public void TellerTask()
    {
        account.Deposit(amount);
        Console.WriteLine(name + " : " + account.Balance);
    }
}
public class ExericseCh6_14
{
    public static void Main(String[] args)
    {
        // (2) Lock문 사용
        Account ac1 = new Account(1000);
        Account ac2 = new Account(1000);
        Teller Seo = null;
        Teller Park = null;
        for (int i = 1; i < 5; i++)
        {
            Seo = new Teller("Seo", ac1, 1000);
            Seo.TellerTask();
        }
        for (int i = 1; i < 5; i++)
        {
            Park = new Teller("Park", ac2, 100);
            Park.TellerTask();
        }

        // (1) 파일을 오픈 (예외처리)
        try
        {
            using (StreamReader sr = File.OpenText("data.txt"))
            {
                Console.WriteLine($"The first line of this file is {sr.ReadLine()}");
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"The file was not found: '{e}' ");
        }
    }
}