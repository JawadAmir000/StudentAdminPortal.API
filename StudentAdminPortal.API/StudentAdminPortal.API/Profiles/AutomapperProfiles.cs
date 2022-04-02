using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StudentAdminPortal.API.Domain_Models;
using DataModels = StudentAdminPortal.API.DataModels;


namespace StudentAdminPortal.API.Profiles
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<DataModels.Student, Student>()
                .ReverseMap();

            CreateMap<DataModels.Student, Student>()
                .ReverseMap();

            CreateMap<DataModels.Student, Student>()
                .ReverseMap();
        }
    }
}
