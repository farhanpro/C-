using System;
class farhan{
		public static void Main (string [] args){
			int [] arr = new int [5];
			int i,j,temp,step=0;
			for(i=1;i<=5;i++){
			 arr[i]=Convert.ToInt32(Console.ReadLine());
			}
			for(i=1;i<=arr.Length;i++){
				for(j=1;j<=arr.Length-1;j++)
				{
					if(arr[i] < arr[i+1]){
						temp=arr[i];
						arr[i]=arr[i+1];
						arr[i+1]=temp;
						step=1;
						}
					//step=1
					if(step==0){
							break;
						}
				}
			}
				Console.WriteLine("Sorted");			
			for(i=1;i<=arr.Length;i++){
			Console.WriteLine(arr[i]);
			}
}
}
			
			
