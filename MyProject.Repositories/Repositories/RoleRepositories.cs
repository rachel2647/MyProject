﻿using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;
        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public Role Add(int id, string name, string desc)
        {
            Role role = new Role() { Id = id, Name = name, Description = desc };
            _context.Roles.Add(role);
            return role;
        }

        public void Delete(int id)
        {
            Role r = GetById(id);
            _context.Roles.Remove(r);
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                    return _context.Roles[i];
            }
            return null;
        }

        public Role Update(Role role)
        {
            Role r = GetById(role.Id);
            r.Name = role.Name;
            r.Description = role.Description;
            return r;
        }
    }
}
