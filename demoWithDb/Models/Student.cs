using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoWithDb.Models
{
    public class Student
    {
        
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public string EmailId { get; set; }
            public string Gender { get; set; }
            [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime? DOB { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            
    }
}