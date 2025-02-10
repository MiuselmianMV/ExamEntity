namespace FinalWork.DAL.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Draws { get; set; }
        public int Scores { get; set; }
        public int MissedGoals { get; set; }

    }
}
