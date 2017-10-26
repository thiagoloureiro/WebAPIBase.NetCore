using System.Collections.Generic;

namespace Model.Moip.order
{
    public class checkoutPreferences
    {
        public redirectUrls redirectUrls { get; set; }
        public List<installments> installments { get; set; }
    }
}