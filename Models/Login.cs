namespace hotel.Models
{
    public class Login
    {
        string id {  get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }

        public loginType lType { get; set; }

    }

    public enum loginType
    {
        successfully,
        unsuccesfully,
        invalid
    
    }

}
