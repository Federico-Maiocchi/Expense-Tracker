using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        //id
        [Key]
        public string CategoryId {  get; set; }

        //titolo
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        //icone
        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        //Tipi
        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense";

    }
}
