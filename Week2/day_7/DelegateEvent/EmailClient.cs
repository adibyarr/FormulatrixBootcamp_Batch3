namespace DelegateEvet
{
	public class EmailClient
	
	{
		public void HandlingEmailSent(string sender, string receipent, string subject, string body)
		{
			Console.WriteLine("New Emailsent:");
			Console.WriteLine("Sender: " + sender);
			Console.WriteLine("Receipent: " + receipent);
			Console.WriteLine("Subject: " + subject);
			Console.WriteLine("Body: " + body);
			
			Console.WriteLine();
			
		}
	}
}