using PlatformSerice.Models;

namespace PlatformService.Data
{
    public interface IPlatformRep
    {
        bool SaveChanges ();
        IEnumerable<Platform> GetAllPlatform ();
        Platform GetPlatformById (int id);
        void CreatePlatform(Platform platform);
    }
}
