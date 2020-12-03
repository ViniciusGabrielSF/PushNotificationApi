using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushNotificationApi.Dtos
{
    public class SendNotificationPost
    {
        public String RegistrationToken { set; get; }
        public String NotificationTitle { set; get; }
        public String NotificationBody { set; get; }
        public String DisplayedTitle { set; get; }
        public String DisplayedBody { set; get; }
        public String Topic { set; get; }
    }
}
