namespace WebAPI.Digital.API2.Model
{
    public class Tiers
    {
        public int Id { get; set; }
        public string CUserId { get; set; }
        public DateTime CDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string ActivityDomain { get; set; }

        public string AccessType { get; set; }
    }
}
