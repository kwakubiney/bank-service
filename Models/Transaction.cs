using System.ComponentModel.DataAnnotations.Schema;
using BankService.Models;

namespace Models.Transaction{
    public class Transaction : BaseEntity{
        public int Id {get; set;}
        public decimal Credit {get; set;}
        public decimal Debit {get; set;}

        [ForeignKey(nameof(SenderAccountId ))]
        [InverseProperty(nameof(Account.SenderTransactions))]
        public Account SenderAccount {get; set;}
        public int SenderAccountId {get; set;}

        [ForeignKey(nameof(ReceiverAccountId ))]
        [InverseProperty(nameof(Account.ReceiverTransactions))]
        public Account ReceiverAccount{get; set;}
        public int ReceiverAccountId{get; set;}
    }
}