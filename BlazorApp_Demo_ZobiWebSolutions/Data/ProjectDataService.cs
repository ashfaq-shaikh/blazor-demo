using System;
using System.Linq;
using System.Threading.Tasks;
using Zobi.Data;
using Zobi.Domain;
using Zobi.Domain.Contract;
using Zobi.Domain.Entities;
using Zobi.Domain.Models;
using Zobi.Domain.Services;

namespace BlazorApp_Demo_ZobiWebSolutions.Data
{
    public class ProjectDataService
    {
        IUnitOfWork _unitOfWork;
        IUserService _userService;
        IProjectService _projectService;
        public ProjectDataService(IUnitOfWork unitOfWork, IUserService userService, IProjectService projectService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
            _projectService = projectService;
        }

        /// <summary>
        /// get projects list with filter options.
        /// </summary>
        /// <param name="fy">FY CSV value</param>
        /// <param name="type">type CSV value</param>
        /// <param name="lead">lead CSV value</param>
        /// <param name="month">month CSV value</param>
        /// <param name="lever">lever CSV value</param>
        /// <param name="brag">brag CSV value</param>
        /// <param name="stage">stage CSV value</param>
        /// <returns></returns>
        public Task<ProjectsModel[]> GetProjectListAsync(string fy, string type, string lead, string month, string lever, string brag, string stage)
        {
            var p = _projectService.GetProjects(fy, type, lead, month, lever, brag, stage);
            return Task.FromResult(p.Result.ToArray());
        }
    }
}
