using System;

namespace eCommerce_Inefavel.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string MsgErro { get; set; }
    }
}
