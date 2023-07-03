using System;
using System.ComponentModel.DataAnnotations;

namespace book_reading_event.Models
{
    public class EventMaster : IEventMaster
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; }
        [Required]
        public int Event_Type { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [DataType(DataType.Duration)]
        [Display(Name = "Duration(in hr. )")]
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Invite { get; set; }
    }
}