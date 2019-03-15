using System;
public abstract class A {
				public abstract  void m1();
			}
class B :A {
		public override void  m1(){
			Console.WriteLine("Abstraction");
	}
	}
class C 
{
		public static void Main(string [] args)
		{
			B obj =new B();
			obj.m1();
		}
}

