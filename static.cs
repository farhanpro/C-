using System;
	class A{
		static	int count =0;
		public 	void add()
		{
			count ++;
			Console.WriteLine("Object called and number of student is updated : "+count);
		}
	}
	class farhan{

		public static void Main(string [] args)
		{
			A obj =new A();
			A obj2 =new A();
			A obj3=new A();
			obj.add();
			obj2.add();
			obj3.add();
		}
	}

			
