using System;
using System.ComponentModel.DataAnnotations;




namespace TodoList.Models
{
    public class Todos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Todo { get; set; }

    }
}
