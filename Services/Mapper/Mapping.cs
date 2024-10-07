using AutoMapper;
using Repository.Models;
using Services.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapper
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<ChatRequest, MessageDtoRequest>().ReverseMap();
            CreateMap<ChatRequest, MessageDtoResponse>().ReverseMap();
        }
    }
}
