using PushNotificationApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushNotificationApi.Models.Firebase
{
    public class SendNotificationInput
    {
        public String RegistrationToken { set; get; }
        public String NotificationTitle { set; get; }
        public String NotificationBody { set; get; }
        public String DisplayedTitle { set; get; }
        public String DisplayedBody { set; get; }
        public String Topic { set; get; }


        public SendNotificationInput(SendNotificationPost model)
        {
            this.RegistrationToken = model.RegistrationToken;
            this.NotificationTitle = model.NotificationTitle;
            this.NotificationBody = model.NotificationBody;
            this.DisplayedTitle = model.DisplayedTitle;
            this.DisplayedBody = model.DisplayedBody;
            this.Topic = model.Topic;
        }
    }
}
