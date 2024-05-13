using Repositories;
using Repositories.Entities;
using Repositories.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Services
{
    public class GiaoViecService
    {
        GiaoViecRepository repository;

        public GiaoViec? findAssignedTask(string assignedTaskID)
        {
            repository = new GiaoViecRepository();
            GiaoViec? assignedTask = repository.Get(assignedTaskID);
            if (assignedTask == null) return null;
            return assignedTask;
        }

        public bool assignTask(string description, string day, string deadline, string status, string file, string id, int mode, string name, string vanue, string receiverID, int isCEO, string CEOID, string authorizedBy, int intime, string sharedDepartment)
        {
            repository = new GiaoViecRepository();
            return repository.Create(description, day, deadline, status, file, id, mode, name, vanue, receiverID, isCEO, CEOID, authorizedBy, intime, sharedDepartment);
        }

        public bool updateTask(string description, string day, string deadline, string status, string file, string id, int mode, string name, string vanue, string receiverID, int isCEO, string CEOID, string authorizedBy, int intime, string sharedDepartment)
        {
            repository = new GiaoViecRepository();
            return repository.Update(description, day, deadline, status, file, id, mode, name, vanue, receiverID, isCEO, CEOID, authorizedBy, intime, sharedDepartment);
        }

        public void downloadAttachedFile(string id)
        {
            repository = new GiaoViecRepository();
            repository.DownLoadFile(id);
        }

        public void UpdateProcess(string id, string status, DateTime selectedDate)
        {
            repository = new GiaoViecRepository();
            repository.UpdateProcess(id, status, selectedDate);
        }

        public bool checkValidPdf(string id)
        {
            repository = new GiaoViecRepository();
            return repository.IsPdfValid(id);
        }

        public string getAssignTaskID(string assignerID)
        {
            repository = new GiaoViecRepository();
            return GiaoViecUtilities.createAssignTaskID(assignerID);
        }
        public List<GiaoViec> getAll()
        {
            repository = new GiaoViecRepository();
            return repository.GetAll(); 
        }
        public List<GiaoViec> getTaskOfDeparment(string department, string staffID)
        {
            repository = new GiaoViecRepository();
            return repository.getAllTaskOfDepartment(department, staffID);
        }
    }
}
