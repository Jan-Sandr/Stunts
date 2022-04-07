namespace Stunts
{
    class Stunt
    {
        public int Id { get; }
        public string Name { get; }
        public StuntCategory Category { get; } 
        public int Difficulty { get; }
        public string Requirements { get; }
        public string Instructions { get; }
        public string AdvancedTechniques { get; }
        public string Experiences { get; }
        public bool Equipment { get; }
        public string VideoLink { get; }

        public enum StuntCategory
        {
            Gymnastics,
            Parkour,
            Other
        };

        public Stunt(int id, string name, int category, 
            int difficulty, string requirements, string
            instructions, string advancedTechniques, string 
            experiences, bool equipment, string videolink)
        {
            Id = id;
            Name = name;
            Category = (StuntCategory)category;
            Difficulty = difficulty;
            Requirements = requirements;
            Instructions = instructions;
            AdvancedTechniques = advancedTechniques;
            Experiences = experiences;
            Equipment = equipment;
            VideoLink = videolink;
        }
    }
}