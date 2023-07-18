// See https://aka.ms/new-console-template for more information
namespace DelegateEvet
{
	public class Program
	{
		public static void Main()
		{
			EmailService emailService = new EmailService();
			EmailClient emailClient = new EmailClient();
			
			emailService.EmailSent += emailClient.HandlingEmailSent;

			Console.WriteLine("Enter email address: ");
			Console.Write("Sender: ");
			string sender = Console.ReadLine();
			Console.Write("Receipent: ");
			string receipent = Console.ReadLine();
			Console.Write("Subject: ");
			string subject = Console.ReadLine();
			Console.Write("Body: ");
			string body = Console.ReadLine();
			
			emailService.SendEmail(sender, receipent, subject, body);
			Console.ReadLine(); 
		}
	}
}
