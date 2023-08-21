using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewModels
{
    public class TodoViewModel
    {
        [Required]
        public string Title { get; set; }

    }
}
