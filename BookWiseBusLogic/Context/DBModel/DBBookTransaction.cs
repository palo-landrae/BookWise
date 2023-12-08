using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWiseBusLogic.Context.DBModel
{
    public class DBBookTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TransactionDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [ForeignKey("UserId")]
        public DBUser User { get; set; }

        [ForeignKey("BookId")]
        public DBBook Book { get; set; }
    }
}
