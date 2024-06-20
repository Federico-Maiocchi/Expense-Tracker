using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        //id
        [Key]
        public int TransactionId { get; set; }

        //relazione con la tabella Category(Categorie)
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //importo
        
        public int Amount { get; set; }

        //note
        //possono essere null
        [Column(TypeName = "nvarchar(150)")]
        public string? Note { get; set; }

        //data
        public DateTime Date {  get; set; } = DateTime.Now;

       


    }
}
