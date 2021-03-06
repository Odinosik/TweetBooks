﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetbook.Contracts.V1.Responses;
using Tweetbook.Domain;

namespace Tweetbook.Mapping
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Post, PostResponse>()
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(x => new TagResponse { Name = x.TagName })));
            CreateMap<Tag, TagResponse>();
        }
    }
}
