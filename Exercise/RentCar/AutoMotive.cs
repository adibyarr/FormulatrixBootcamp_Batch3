namespace BetterOODemo
{
	
	public class AutoMotive
	
	{
		public int NumberOfPassengers{get; set;}
		public virtual void StartEngine()
		{
			Console.WriteLine("Turn key to set");
			Console.WriteLine("Key to on");
		}
		public virtual void StopEngine()
		{
			Console.WriteLine("Key to off"); 
		}
	}
}