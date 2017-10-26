using Model.Moip.credit_card;
using System;

namespace Model.Moip.customer
{
    public class customer
    {
        public string id { get; set; }
        public string ownId { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public phone phone { get; set; }
        public string birthDate { get; set; }
        public taxDocument taxDocument { get; set; }
        public shippingAddress shippingAddress { get; set; }
    }
}