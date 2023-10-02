using System.ComponentModel.DataAnnotations.Schema;
using Models.Transaction;

namespace BankService.Models{
    public class Account : BaseEntity{
        public int Id {get; set;}
        public string Name {get; set;}
        public long Balance {get; set;}

        [InverseProperty(nameof(Transaction.ReceiverAccount ))]
        public ICollection<Transaction> ReceiverTransactions { get; }

        [InverseProperty(nameof(Transaction.SenderAccount))]
        public ICollection<Transaction> SenderTransactions { get; }
    }
}