using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Zobi.Data;
using Zobi.Domain.Contract;
using Zobi.Domain.Entities;
using Zobi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace Zobi.Domain.Services
{
    public class ProjectService : IProjectService
    {
        IUnitOfWork _uow;
        IServiceProvider _serviceProvider;
        IHostingEnvironment _env;
        public ProjectService(IUnitOfWork uow, IServiceProvider serviceProvider, IHostingEnvironment env)
        {
            _uow = uow;
            this._serviceProvider = serviceProvider;
            _env = env;
        }

        public List<Projects> GetProjects()
        {
            var repo = _uow.GetRepository<Projects>();
            var p = repo.Get();
            return p;
        }
        public async Task<List<ProjectsModel>> GetProjects(string fy, string type, string lead, string month, string lever, string brag, string stage)
        {
            SqlParameter[] sqlParams = {
                new SqlParameter("FY", SqlDbType.VarChar) { Value = (object)fy ?? DBNull.Value},
                new SqlParameter("Type", SqlDbType.VarChar) { Value = (object)type ?? DBNull.Value},
                new SqlParameter("Lead",SqlDbType.VarChar) { Value = (object)lead ?? DBNull.Value},
                new SqlParameter("Month",SqlDbType.VarChar) { Value = (object)month ?? DBNull.Value},
                new SqlParameter("Lever",SqlDbType.VarChar) { Value = (object)lever ?? DBNull.Value},
                new SqlParameter("BRAG",SqlDbType.VarChar) { Value = (object)brag ?? DBNull.Value},
                new SqlParameter("Stage",SqlDbType.VarChar) { Value = (object)stage ?? DBNull.Value},

            };

            var repo = _uow.GetRepository<Projects>();
            var _DbContext = repo.GetContext();

            if (((ZobiDBContext)_DbContext).Database.GetDbConnection().ConnectionString == string.Empty)
            {
                repo.SetContext(ServiceInitializer.InitializeContext(_env));
            }

            var data = repo.ExecProcedure<ProjectsModel>("GetProjectData", sqlParams);
            //var data = repo.Query("GetProjectData @FY,@Type,@Lead,@Month,@Lever,@REG,@Stage", sqlParams).ToListAsync();
            return await data;
        }
    }


}