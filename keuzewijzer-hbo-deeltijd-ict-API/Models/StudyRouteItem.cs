namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class StudyRouteItem
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public int StudyRouteId { get; set; }
        public StudyRoute StudyRoute { get; set; } = null!;

        public StudyRouteItem(int id, int year, int semester, int studyRouteId, StudyRoute studyRoute)
        {
            Id = id;
            Year = year;
            Semester = semester;
            StudyRouteId = studyRouteId;
            StudyRoute = studyRoute;
        }
    }
}
