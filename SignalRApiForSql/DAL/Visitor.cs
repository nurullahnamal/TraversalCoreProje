namespace SignalRApiForSql.DAL
{

    public enum ECity
    {
        İstanbul = 1,
        Ankara = 2,
        İzmir = 3,
        Konya = 4,
        Antalya = 5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime? VisitDate { get; set; }
    }

}
