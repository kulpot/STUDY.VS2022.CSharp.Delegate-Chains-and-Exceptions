using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        //Action del = new Action(Moo) + BeNaughty + Goo;
        Action del = (Action)Moo + BeNaughty + Goo;
        foreach(Action a in del.GetInvocationList())
        {
            try
            {
                a();
            }
            catch
            {

            }
        }
        
    }
    static void Moo()
    {
        Console.WriteLine("Moo()");
    }
    static void BeNaughty()
    {
        throw new Exception();
    }
    static void Goo()
    {
        Console.WriteLine("Goo()");
    }
}