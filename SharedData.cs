using Yudin_back.Models;
using System.Collections.Generic;

namespace Yudin_back
{
    public static class SharedData
    {
        public static List<User> Users { get; } = new List<User>
        {
            new User(){ Login = "user", Password = "user" },
            //new User(){ Login = "volunteer", Password = "volunteer" },
            new User(){ Login = "admin", Password = "admin" },
        };
    }
}