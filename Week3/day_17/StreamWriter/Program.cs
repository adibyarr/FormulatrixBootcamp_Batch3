using System;
using System.IO;

class FileWriter : IDisposable
{
	private StreamWriter _writer;
	private bool _isDisposed = false;
	public FileWriter(string pathFile)
	{
		_writer = new StreamWriter(pathFile);
	}
	public void WriteData(string data)
	{
		_writer.WriteLine(data);
	}
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	
	protected virtual void Dispose(bool disposing)
	{
		if(!_isDisposed)
		{
			if(disposing)
			{
				if(_writer != null)
				{
					_writer.Dispose();
					_writer = null;
				}
			}
			_isDisposed = true;
		}
	}
	~FileWriter()
	{
		Dispose(false);
	}
}
class Program
{
	static void Main()
	{
		using(FileWriter writer = new FileWriter("hasil.txt"))
		{
			writer.WriteData("Line pertama");
			writer.WriteData("Line Ke 2");
		}
	}
}