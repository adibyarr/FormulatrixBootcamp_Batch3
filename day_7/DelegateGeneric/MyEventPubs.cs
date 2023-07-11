namespace DelegateGeneric
{
	public delegate void MyDelegate<T>(T data);
	public class MyEventPubs<T>
	{
		public event MyDelegate<T> MyEvent;
		public void DoKickflip(T data)
		
		{
			Console.WriteLine("Doing Kickflip. .");
			
			if(data is int intValue && intValue > 0)
			
			{
				OnMyEvent(data);
			}
		}
		protected virtual void OnMyEvent(T data)
		{
			MyEvent?.Invoke(data);
		}
		
	}
}