﻿using System;
namespace Events
{
	public class MailService
	{
		public void OnVideoEncoded(object source, EventArgs e)
		{
			Console.WriteLine("MailService: Sending an email... ");
		}

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email... " + e.Video.Title);
        }
    }
}

