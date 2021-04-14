using GigHubMosh.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace GigHubMosh.Dtos
{
    public class NotificationDto
    {
       
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; set; }

        public DateTime? OriginalDateTime { get; set; }

        public string OriginalVenue { get; set; }

        [Required]
        public GigDto Gig { get; set; }
    }
}