﻿namespace UniMeetUpApplication.Model
{
    public class MessageForLoad
    {
        public MessageForLoad(string userId, string message)
        {
            UserId = userId;
            Message = message;
        }
        public string UserId { get; set; }
        public string Message { get; set; }
    }
}

