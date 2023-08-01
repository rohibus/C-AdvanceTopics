using System;
namespace Events
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var video = new Video { Title = "Iron Man" };
			var videoEncoder = new VideoEncoderWithoutEventHandler();
			var mailService = new MailService();
			var messageService = new MessageService();

			videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            var videoEncoder1 = new VideoEncoder();

            videoEncoder1.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder1.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder1.Encode(video);
        }
	}
}

