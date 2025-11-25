using AutoMapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TaskViewModel, DBTask>();
        CreateMap<DBTask, TaskViewModel>();
        CreateMap<DBApplicationUser, RegisterViewModel>();
        CreateMap<RegisterViewModel, DBApplicationUser>();
    }
}