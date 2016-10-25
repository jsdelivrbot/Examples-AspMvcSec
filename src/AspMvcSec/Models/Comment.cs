using System;

namespace AspMvcSec.Models
{
  public class Comment
  {
    public DateTime Date { get; set; } = DateTime.Now;
    public string Who { get; set; }
    public string Text { get; set; }

  }
}