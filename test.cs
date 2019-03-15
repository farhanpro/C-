using System;
public abstract class Base {
					public abstract void mul();
				}

				
class Derived : Base {
			public override void mul(){
				Console.WriteLine("Abstraction succesfull");
			}
		}
class farhan{
			public static void Main(string []args){
			Derived obj = new Derived();
			obj.mul();
		}
	}	
