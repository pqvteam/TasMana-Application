using Repositories.Entities;

namespace Repositories
{
    public class GiaoViecRepository
    {
        // We interact with DB here

        public GiaoViec? Get(string assignTaskID)
        {
            // Access DB
            TasManaContext db = new TasManaContext();
            return db.GiaoViecs.FirstOrDefault(x => x.MaGiaoViec.Equals(assignTaskID));
        }
    }
}
