using System.Collections.Generic;

namespace API.Models
{
    public class TokenInfo
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }

    public class CustomerInfo
    {
        public string customer_code { get; set; }
        public string from_period { get; set; } //yyyy-MM
        public string to_period { get; set; } //yyyy-MM
    }

    public class CustomerWebResult
    {
        public string error_code { get; set; }
        public string error_message { get; set; }
        public List<CustomerWebGen> data { get; set; }
    }

    public class CustomerWebGen
    {
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string customer_tax_reg_no { get; set; }
        public List<CustomerWebDetail> details { get; set; }

    }

    public class CustomerWebDetail
    {
        public string period_no { get; set; }
        public int old_index { get; set; }
        public int new_index { get; set; }
        public int quantity { get; set; }
        public string einvoice_reservation { get; set; }
        public string einvoice_no { get; set; }
        public string einvoice_date { get; set; }
        public string einvoice_form { get; set; }
        public string einvoice_serial { get; set; }
        public double amount { get; set; }
        public double paid_amount { get; set; }
        public double debit_amount { get; set; }
        public string payment_status { get; set; }
    }
}
