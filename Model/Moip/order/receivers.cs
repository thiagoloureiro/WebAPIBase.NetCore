namespace Model.Moip.order
{
    public class receivers
    {
        public string type { get; set; }
        public bool feePayor { get; set; }

        public moipAccount moipAccount { get; set; }
        public amountReceivers amount { get; set; }
    }
}