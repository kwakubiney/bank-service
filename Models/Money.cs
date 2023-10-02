namespace BankService.Models{
    public class Money{
        public Money(long value){
            Value = value ;
        }
        public long Value {get; set;}

        public double Float64()
        {
            return (double)Value / 100;
        }

        public long Int64()
        {
            return Value;
        }
    }
}