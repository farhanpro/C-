using System;
	class farhan{
			int id;
			string name;
			
			public void getdata(int i , string specific_name)
			{
				id = i;
				name = specific_name;
			}
			public void showdata()
			{
				Console.WriteLine("The Roll number  of the student is :  " +id); 
				Console.WriteLine("The name of the student is : " +name);
			}
			farhan(){
			Console.WriteLine("This is default constructor");
				}
		public static void Main(string[] args)
		{
			farhan obj =new farhan();
			farhan obj2 = new farhan();
			
			obj.getdata(1,"farhan");
			obj.showdata();
			
			obj2.getdata(2,"nitish");
			obj2.showdata();
		}
}

