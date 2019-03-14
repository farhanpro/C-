using System;
	class farhan{
			public  void mul  (ref int val){
					val =val+10;
				Console.WriteLine("When value is inside : "+(val));
				}
		public static void Main(string [] args)
{
		int  val =15;
		Console.WriteLine("Value before calling the function : " + val);
		farhan obj = new farhan();
		obj.mul(ref  val);
		Console.WriteLine("Value after calling the function : " + val);		
}
}





