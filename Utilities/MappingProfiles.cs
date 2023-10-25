using AutoMapper;
using BlogApp.Data.Entities;
using BlogApp.Data.Model;
using System.Net;

namespace BlogApp.Utilities
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<UserAddModel ,User>();
            CreateMap<UpdateNameModel, User>();
            CreateMap<BlogAddModel, Blog>();
            CreateMap<BlogUpdateModel, Blog>();
            CreateMap<ContactMessageAddModel, ContactForm>();
            CreateMap<TagModel, Tag>();
        }
    }
}
