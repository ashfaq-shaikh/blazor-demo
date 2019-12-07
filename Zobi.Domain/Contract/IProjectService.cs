using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zobi.Domain.Entities;
using Zobi.Domain.Models;

namespace Zobi.Domain.Contract
{
    public interface IProjectService
    {
        List<Projects> GetProjects();
        Task<List<ProjectsModel>> GetProjects(string fy, string type, string lead, string month, string lever, string brag, string stage);
    }
}