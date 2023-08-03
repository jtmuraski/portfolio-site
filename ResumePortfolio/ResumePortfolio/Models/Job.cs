namespace ResumePortfolio.Models
{
    /// <summary>
    /// Model to hold the Job data from JobHistory.json
    /// </summary>
    public class Job
    {
        public string Company { get; set; }
        public string Title { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public string StartDateMonth { get; set; }
        public int StartDateYear { get; set; }
        public string? EndDateMonth { get; set; }
        public int? EndDateYear { get; set; }
        public bool IsPresentJob { get; set; }
        public string? ShortSummary { get; set; }

        public string? Description { get; set; }
        public List<string>? Achievements { get; set; }
        public List<string>? Awards { get; set; }
    }
}
