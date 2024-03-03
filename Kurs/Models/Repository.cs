namespace Kurs.Models
{
    public class Repository
    {
        private static List<Candidate> applications = new List<Candidate>();//new() ilede tanımlanır
        public static IEnumerable<Candidate> Applications=> applications;
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}
