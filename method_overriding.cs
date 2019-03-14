using System;
class b{
		public void add(int i,int j)
			{
			Console.WriteLine("Addition came from base class  : " +(i+j));
			}
	}
class A:b {
		public void add(int i , int j)
		{
		Console.WriteLine("Addition came from derived class  :"+(i+j));
		}
	}
class B :A{
		public static void Main(string [] args)
		{
			B obj = new B();
			obj.add(5,6);
			b obj2 =new b();
			obj2.add(4,1);
		}
}


