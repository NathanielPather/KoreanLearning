namespace KoreanLearning.Core.Models
{
    public class Practice
    {
        public int Id { get; set; }
        public float Retention { get; set; }
        public DateTime LastSuccess { get; set; }
        public int CharacterId { get; set; }
        public Characters Characters { get; set; }
    }
}
