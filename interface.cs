using System;
public interface A{
			void m1();
		}
class B : A{
		public void m1(){
		Console.WriteLine("This is interface");
			}
	}
class C {
	public static void Main (string [] args)
	{
		B obj = new B();
		obj.m1();	
}
}

	
