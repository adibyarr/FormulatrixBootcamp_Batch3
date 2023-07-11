// See https://aka.ms/new-console-template for more information
namespace DelegateGeneric
{
	public class Program
	{
		static void Main()
		{
			var pubs = new MyEventPubs<int>();
			var subs = new MyEventSubs();
			
			pubs.MyEvent += subs.MyEventHandler;
			
			pubs.DoKickflip(20);
			pubs.DoKickflip(-3);
		}
	}
}