using Repositories;
using Repositories.Entities;

namespace Services
{
    public class GiaoViecService
    {
        // Get GiaoViec
        public GiaoViec? findAssignedTask(string assignedTaskID)
        {   
            GiaoViecRepository repository = new GiaoViecRepository();
            GiaoViec? assignedTask = repository.Get(assignedTaskID);
            if (assignedTask == null) return null;
            return assignedTask;
        }
    }
}
