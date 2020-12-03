using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading;
using PushNotificationApi.Services.Firebase;
using PushNotificationApi.Dtos;
using PushNotificationApi.Models.Firebase;
using Microsoft.AspNetCore.Http;


namespace PushNotificationApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirebaseNotificationController
    {
 
        private readonly ISendNotificationService sendNotificationService;

        public FirebaseNotificationController( ISendNotificationService sendNotificationService)
        {
            this.sendNotificationService = sendNotificationService;

        }

        [HttpPost]
        [Route("send-notification")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SendNotification([FromBody] SendNotificationPost model)
        {
            var input = new SendNotificationInput(model);
            
            return new OkObjectResult(await sendNotificationService.SendNotification(input));
        }
    }
}
