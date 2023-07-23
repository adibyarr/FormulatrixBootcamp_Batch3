namespace DelegateGeneric
{
	public class MyEventSubs
	{
		public void MyEventHandler(int data)
		
		{
			Console.WriteLine($"Event handled by subs. Data:{data}");
		}
	}
}