namespace Model.Moip
{
    public class MoipCreatePayment
    {
        public int order_id { get; set; }
        public int installmentCount { get; set; }
        public string statementDescriptor { get; set; }
        public bool delayCapture { get; set; }
        public fundingInstrument fundingInstrument { get; set; }
        public device device { get; set; }
    }
}