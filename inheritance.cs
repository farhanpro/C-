using System;
public class A{
		public int a=10;
		public void show(){	
			Console.WriteLine(a);
				}
		}
public class B :A {
		public 	int b=10;
			public void mul()
			{
			Console.WriteLine(b);
			//Console.WriteLine("Multiplication of both is :" + (a*b));
			}
		}	
	public class C :B{
			public void mul(){
			  int c=30;
				Console.WriteLine(c);
				Console.WriteLine("Multiplication of all three id :"+(a*b*c));
}
}
 class farhan :C
		{
			public static void Main(string [] args)
		{
			C obj =new C();
			obj.show();
			obj.mul();
		}
}	
