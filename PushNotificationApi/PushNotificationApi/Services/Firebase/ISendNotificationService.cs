using PushNotificationApi.Models.Firebase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushNotificationApi.Services.Firebase
{
    public interface ISendNotificationService
    {
        Task<String> SendNotification(SendNotificationInput input);
    }
}
