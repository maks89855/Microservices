using PlatformSerice.Models;

namespace PlatformService.Data
{
    public class PlatformRep : IPlatformRep
    {
        private readonly ApplicationDataContext _context;

        public PlatformRep(ApplicationDataContext context)
        {
            _context = context;
        }
        public void CreatePlatform(Platform platform)
        {
            if (platform != null)
            {
                _context.Add(platform);
            }
            else
            {
                throw new ArgumentNullException(nameof(platform));
            }
            
        }

        public IEnumerable<Platform> GetAllPlatform()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.First(i => i.Id == id);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
