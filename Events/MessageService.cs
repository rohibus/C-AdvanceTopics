using System;
namespace Events
{
	public class MessageService
	{
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message... ");
        }

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message... " + e.Video.Title);
        }
    }
}

