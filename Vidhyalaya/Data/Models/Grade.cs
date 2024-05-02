using System;
using System.ComponentModel.DataAnnotations;
public class Grade
{
    [Key] // Specify that Label is the primary key
    public int Label { get; set; }
    public string ClassTeacher { get; set; }
    public string Medium { get; set; }
    public string Subject { get; set; }
    public DateTime Session { get; set; }
   
}
