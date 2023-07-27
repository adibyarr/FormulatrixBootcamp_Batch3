using System;
namespace DisposePattern
{
	public class Resource : IDisposable
	{
		//Memanage resource(object mengimplements IDisposable)
		private bool _isDisposed = false;
		
		//Constructor
		public Resource()
		{
			Console.WriteLine("Masukkin: ");
		}
		
		// custom method biar bekerja dengan resource
		public void DoSomething()
		{
			if(_isDisposed)
				throw new ObjectDisposedException("Resource ", " gabisa akses dispose object");
		}
		//Dispose method untuk ngerelease resource
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		//Protected metod untuk dispose
		protected virtual void Dispose(bool disposing)
		{
			if(!_isDisposed)
			{
				if(disposing)
				{
					Console.WriteLine(_isDisposed);
				}
				//tanda kalo udah ke dispose
				_isDisposed = true;
			}
		}
	}
}