using System;
public class A{
		public void add(int a , int b)
		{
			Console.WriteLine("Addition of two numbers : " + (a+b));
		}
	 	public void add(int a , int b,int c)
		{
			Console.WriteLine("Addition of three numbers : "+(a+b+c));
		}
}
class farhan : A{
			public static void Main(string[] args)
			{
				A obj= new A();
				//A(1,2,3);
				obj.add(1,2);
				obj.add(1,2,3);
			}
	}

		
		
	
