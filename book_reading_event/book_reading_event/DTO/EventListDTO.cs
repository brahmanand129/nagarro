using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace book_reading_event.DTO
{
    public class EventListDTO
    {
        public int Id { get; set; }
        [Required]
        public string EventType { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
     
    
        //public string Type { get; set; }
        [DataType(DataType.Duration)]
        [Display(Name = "Duration(in hr. )")]
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Invite { get; set; }
    }
}