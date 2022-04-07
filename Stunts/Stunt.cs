namespace Stunts
{
    class Stunt
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        //public enum Category 
        public int Difficulty { get; private set; }
        public string Requirements { get; private set; }
        public string Instructions { get; private set; }
        public string AdvancedTechniques { get; private set; }
        public string Experiences { get; private set; }
        public bool Equipment { get; private set; }
        public string VideoLink { get; private set; }

        public Stunt(int id, string name, /*asi string CATEGORY??,*/ 
            int difficulty, string requirements, string
            instructions, string advancedTechniques, string 
            experiences, bool equipment, string videolink)
        {
            Id = id;
            Name = name;
            //enum Category = ;
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