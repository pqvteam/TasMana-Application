﻿using Repositories;
using Repositories.Entities;
using Repositories.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Services
{
    public class GiaoViecService
    {
        GiaoViecRepository repository = new GiaoViecRepository();

        public GiaoViec? findAssignedTask(string assignedTaskID)
        {
            GiaoViec? assignedTask = repository.Get(assignedTaskID);
            if (assignedTask == null) return null;
            return assignedTask;
        }

        //public List<GiaoViec> getAllTasksOfStaff(string staffID)
        //{
        //    return repository.getAllTaskOfStaff(staffID);
        //}

        public bool assignTask(string description, string day, string deadline, string status, string file, string id, int mode, string name, string vanue, string receiverID, int isCEO, string CEOID, string authorizedBy, int intime, string sharedDepartment)
        {
            return repository.Create(description, day, deadline, status, file, id, mode, name, vanue, receiverID, isCEO, CEOID, authorizedBy, intime, sharedDepartment);
        }

        public bool updateTask(string description, string day, string deadline, string status, string file, string id, int mode, string name, string vanue, string receiverID, int isCEO, string CEOID, string authorizedBy, int intime, string sharedDepartment)
        {
            return repository.Update(description, day, deadline, status, file, id, mode, name, vanue, receiverID, isCEO, CEOID, authorizedBy, intime, sharedDepartment);
        }

        public void downloadAttachedFile(string id)
        {
            repository.DownLoadFile(id);
        }

        public void UpdateProcess(string id, string status, DateTime selectedDate)
        {
            repository.UpdateProcess(id, status, selectedDate);
        }

        public bool checkValidPdf(string id)
        {
            return repository.IsPdfValid(id);
        }

        public string getAssignTaskID(string assignerID)
        {
            return GiaoViecUtilities.createAssignTaskID(assignerID);
        }
        public List<GiaoViec> getAll()
        {
            return repository.GetAll(); 
        }
        public List<GiaoViec> getTaskOfDeparment(string department)
        {
            return repository.getAllTaskOfDepartment(department);
        }
    }
}
