namespace CPSC236FinalProject
{
    public class Bill
    {
        public Bill(long id, string paid_by, string paid_to, string desc, float amount, bool accepted, bool settled)
        {
            this.id = id;
            this.Paid_by = paid_by;
            this.Paid_to = paid_to;
            this.Description = desc;
            this.Amount = amount;
            this.isAccepted = accepted;
            this.isSettled = settled;
        }

        public long id { get; }
        public string Paid_by { get; set; }
        public string Paid_to { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public bool isAccepted { get; set; }
        public bool isSettled { get; set; }
    }
}