using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using PushNotificationApi.Models.Firebase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushNotificationApi.Services.Firebase
{
    public class SendNotificationService : ISendNotificationService
    {
        FirebaseApp app;
        public SendNotificationService()
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.GetApplicationDefault(),
            });
        }
        async Task<String> ISendNotificationService.SendNotification(SendNotificationInput input)
        {
            var notification = new Notification()
            {
                Title = input.NotificationTitle,
                Body = input.NotificationBody,
            };

            var data = new Dictionary<string, string>()
                {
                    { "displayedTitle", input.DisplayedTitle },
                    { "displayedBody", input.DisplayedBody },
                    { "click_action", "FLUTTER_NOTIFICATION_CLICK"},
                };

            var message = new Message()
            {
                Token = input.RegistrationToken,
                Notification = notification,
                Data = data,
                Topic = input.Topic,
            };

            return await FirebaseMessaging.DefaultInstance.SendAsync(message);

            
        }
    }



}
