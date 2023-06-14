using System;

public class Program
{
    public Operations myOperator;

    public void Main()
    {
        myOperator = new Operations();

        Console.WriteLine("Hello World");
        myOperator.DoMath(10, 4);
        myOperator.DoMath(20, 7);
        myOperator.DoMath(30, 15);
        myOperator.Compare(4, 3);
        myOperator.Compare(3, 4);
        myOperator.CheckPassword("sevenofnine");
        myOperator.CheckPassword("0U812");
    }

    public void DoMath(int value, int value2)
    {
        var number = value + 2;
        Console.WriteLine(number);
    }

    public void Compare(int value, int value2)
    {
        if(value > value2)
        {
            Console.WriteLine("True, the first is greater.");
        }
        else
        {
            Console.WriteLine("false, the second it greater.");
        }
    }

    public void CheckPassword(string password)
    {
        if(password == "0U812")
        {
            Console.WriteLine("Correct Password");
        }
        else
        {
            Console.WriteLine("Incorrect Password");
        }
    }
}

public class Operations
{
    public void DoMath(int value, int value2)
    {
        var number = value + 2;
        Console.WriteLine(number);
    }

    public void Compare(int value, int value2)
    {
        if (value > value2)
        {
            Console.WriteLine("True, the first is greater.");
        }
        else
        {
            Console.WriteLine("false, the second it greater.");
        }
    }

    public void CheckPassword(string password)
    {
        if (password == "0U812")
        {
            Console.WriteLine("Correct Password");
        }
        else
        {
            Console.WriteLine("Incorrect Password");
        }
    }
}

public class Program
{
    public GameStates gameStates;

    public void Main()
    {
        gameStates = new GameStates();
        gameStates.currentState = GameStates.States.Playing;
        gameStates.CheckState();
    }
}

public class GameStates
{

    public enum States
    {
        Starting,
        Playing,
        Ending
    }

    public States currentState = States.Starting;

    public void CheckState()
    {
        switch (currentState)
        {
            case States.Starting:
                Console.WriteLine("Starting");
                break;
            case States.Playing:
                Console.WriteLine("Playing");
                break;
            case States.Ending:
                Console.WriteLine("Ending");
                break;
        }
    }
}
