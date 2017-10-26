using System;

namespace Model.Moip.boleto
{
    public class boleto
    {
        public DateTime expirationDate { get; set; }
        public onlineBankDebit onlineBankDebit { get; set; }
    }
}