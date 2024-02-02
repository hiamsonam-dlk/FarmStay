namespace API.Models
{
    public class ViettelApiParameters
    {
        public class ViettelTokenInfo
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public string refresh_token { get; set; }
            public int expires_in { get; set; }
            public string scope { get; set; }
            public int iat { get; set; }
            public string invoice_cluster { get; set; }
            public int type { get; set; }
            public string jti { get; set; }
        }

        public class ViettelGetFileResult
        {
            public string errorCode { get; set; }
            public string description { get; set; }
            public string fileToBytes { get; set; }
            public bool paymentStatus { get; set; }
            public string fileName { get; set; }
        }
    }
}
