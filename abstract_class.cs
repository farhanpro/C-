using System;
public abstract class Base{
			public abstract void M1();
			public void M2(){
		Console.WriteLine("This is M2 method");
			}
		}
class Derived: Base{
			public override void M1(){
			Console.WriteLine("This Method is of M1");
		}
	}
class farhan{
			public static void Main(string [] args)
			{
				Derived obj = new Derived();
				obj.M1();
				obj.M2();
			}
	}
	
