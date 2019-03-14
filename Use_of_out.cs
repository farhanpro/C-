using System;
class farhan
{
		public void opt(out int i)
			{
				i=0;
				i+=10;
			}

		public static void Main(string[] args)
	{
			farhan obj =new farhan();
			int i=5;
			Console.WriteLine("Before calling the function : " +i);
			obj.opt(out i);
			Console.WriteLine("After calling the function : "+i);
	}
}

