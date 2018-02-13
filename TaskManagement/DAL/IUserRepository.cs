﻿using System;
using System.Collections.Generic;
using API.Models;

namespace TaskManagement.DAL {
    
    // Interface for UserRespository that will be used for DI
    public interface IUserRepository : IDisposable {

        IEnumerable<User> GetUsers();
        User GetUserByID(int UserId);
        //a method that posts user
        System.Threading.Tasks.Task InsertUser(User User);
        void DeleteUser(int UserID);
        void UpdateUser(User User);
        void Save();

    }
}