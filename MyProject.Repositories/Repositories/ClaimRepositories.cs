using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    class ClaimRepositories : IClaim
    {

        void Delete(int id) { }

        List<Claim> IClaim.GetAll()
        {
            throw new NotImplementedException();
        }

        public Claim GetById()
        {
            throw new NotImplementedException();
        }

        Claim IClaim.Add(int id, string name)
        {
            throw new NotImplementedException();
        }

        Claim IClaim.Update(Claim Role)
        {
            throw new NotImplementedException();
        }

        void IClaim.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
