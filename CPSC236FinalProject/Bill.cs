namespace CPSC236FinalProject
{
    public class Bill
    {
        public Bill(string paid_by, string paid_to, string desc, float amount)
        {
            this.Paid_by = paid_by;
            this.Paid_to = paid_to;
            this.Description = desc;
            this.Amount = amount;
        }

        public string Paid_by { get; set; }
        public string Paid_to { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
    }
}