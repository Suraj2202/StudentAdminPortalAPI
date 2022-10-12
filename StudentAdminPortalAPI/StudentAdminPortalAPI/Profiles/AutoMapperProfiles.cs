using AutoMapper;
using StudentAdminPortalAPI.Profiles.AfterMaps;
using DataModel = StudentAdminPortalAPI.DataModels;
using DomainModel = StudentAdminPortalAPI.DomainModels;

namespace StudentAdminPortalAPI.Profiles
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModel.Student, DomainModel.Student>()
                .ReverseMap();

            CreateMap<DataModel.Gender, DomainModel.Gender>()
                            .ReverseMap();

            CreateMap<DataModel.Address, DomainModel.Address>()
                            .ReverseMap();

            CreateMap<DomainModel.UpdateStudentRequest, DataModel.Student>()
                .AfterMap<UpdateStudentRequestAfterMap>();

        }
    }
}
