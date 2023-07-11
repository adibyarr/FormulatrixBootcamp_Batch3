namespace DelegateEvet
{
	public delegate void EmailEventHandler(string sender, string receipent, string subject, string body);
	
		public class EmailService
		{
			public event EmailEventHandler EmailSent;
			public void SendEmail(string sender, string receipent, string subject, string body)
			{
				OnEmailSent(sender, receipent, subject, body);
			}
			protected virtual void OnEmailSent(string sender, string receipent, string subject, string body)
			
			{
				EmailSent?.Invoke(sender, receipent, subject, body);
			}
		}
		
	
}