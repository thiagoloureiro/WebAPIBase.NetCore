using System;

namespace Model.Moip.credit_card
{
    public class holder
    {
        public string fullname { get; set; }
        public DateTime birthdate { get; set; } //yyyy-mm-dd
        public taxDocument TaxDocument { get; set; }
        public phone phone { get; set; }
    }
}