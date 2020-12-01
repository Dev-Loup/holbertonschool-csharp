using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        int iter = 0;
		for(iter = 1;iter <=3; iter++)
        {
            Console.Write("{0}", str);
        }
        Console.Write("\n{0}\n", str.Substring(0,9));
        }
}
