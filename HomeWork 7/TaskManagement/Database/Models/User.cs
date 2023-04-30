﻿using System.Data;
using System.Xml.Linq;
using TaskManagement.Contants;

namespace TaskManagement.Database.Models
{
    public class User
    {
        public static int IdCounter { get; private set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public UserRole Role { get; set; } 
        public bool IsBanned { get; set; }
        public string PhoneNumber { get; set; }

        public static CurrentLanguage Language { get; set; } = CurrentLanguage.Default;  

        public User(string name, string lastName, string password, string email, UserRole role = UserRole.Member, CurrentLanguage language = CurrentLanguage.Default)
            : this(name, lastName, password, email, DateTime.Now, role, language) { }

        public User(string name, string lastName, string password, string email, DateTime createdAt, UserRole role, CurrentLanguage language)
        { 
            Id = ++IdCounter;
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            CreatedAt = createdAt;
            Role = role;
            Language = language;
        }
        public User(string name, string lastName, string password, string email, DateTime createdAt, UserRole role)
        {
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            CreatedAt = createdAt;
            Role = role;
           



        }
        public string GetShortInfo()
        {
            return $"Id : {Id}, Full name : {Name} {LastName}, Email : {Email}, Is admin : {GetIsAdminInfo()}";
        }

        public string GetIsAdminInfo()
        {
            return Role == UserRole.Admin ? "Yes" : "No";
        }

        public string GetFullName()
        {
            return $"{Name} {LastName}";
        }
    }
}