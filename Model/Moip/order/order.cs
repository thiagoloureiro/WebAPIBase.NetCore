using System.Collections.Generic;

namespace Model.Moip.order
{
    public class order
    {
        public string ownId { get; set; }
        public amount amount { get; set; }
        public List<items> items { get; set; }
        public customer.customer customer { get; set; }
        public checkoutPreferences checkoutPreferences { get; set; }
        public List<receivers> receivers { get; set; }
    }
}