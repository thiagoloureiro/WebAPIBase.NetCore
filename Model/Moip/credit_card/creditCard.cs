using Model.Moip.credit_card;

namespace Model.Moip
{
    public class creditCard
    {
        public string id { get; set; }
        public string hash { get; set; }
        public string number { get; set; }
        public int expirationMonth { get; set; }
        public int expirationYear { get; set; }
        public int cvc { get; set; }
        public bool store { get; set; }
        public holder holder { get; set; }
    }
}