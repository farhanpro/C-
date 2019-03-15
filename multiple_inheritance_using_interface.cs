using System;
public interface A{
			void M1();
		}
public interface A1{
			void M1();
			void M2();
		}
class B :A,A1{
		public void M1(){
			Console.WriteLine("Multiple inheritance sucessfull");
			}
			public void M2(){
			Console.WriteLine("Second Interface is also sucessfull ");
			}
}

class C{
		public static void Main(string [] args)
		{
			B obj = new B();
  			obj.M1();
			obj.M2();
		}
	}


