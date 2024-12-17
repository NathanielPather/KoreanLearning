namespace KoreanLearning.Application
{
    public class Services
    {
        private readonly AppDbContext _context;
        public Services(AppDbContext context)
        {

            _context = context;

        }

        public void GetLowestRetention()
        {
            var lowestRetentionItem = _context.Practice.OrderBy(p => p.Retention).FirstOrDefault();
            //return GetCharacterById(lowestRetentionItem.characterId);
        }

        public IQueryable<Characters> GetCharacterById(int id)
        {
            return _context.Characters.Where(c => c.Id == id);
        }
    }
}
