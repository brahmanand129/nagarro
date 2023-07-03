using BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace book_reading_event.Models
{
    public class Event1 : IEvent1
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

    }
}