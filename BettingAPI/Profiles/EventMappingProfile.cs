using AutoMapper;
using BettingAPI.Dtos;
using BettingAPI.Entities;
using System;

namespace BettingAPI.Profiles
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile()
        {
            CreateMap<Event, EventDto>()
                .ForMember(x => x.City, c => c.MapFrom(s => s.EventAdress.City))
                .ForMember(x => x.Country, c => c.MapFrom(s => s.EventAdress.Country))
                .ForMember(x => x.Street, c => c.MapFrom(s => s.EventAdress.Street));

            CreateMap<Confrontation, ConfrontationDto>();
            CreateMap<CreateEventDto, Event>()
                .ForMember(x => x.EventAdress, c => c.MapFrom(dto => new EventAdress
                {
                    City = dto.City,
                    Street = dto.Street,
                    Country = dto.Country
                }))
                .ForMember(x => x.DateFrom, c => c.MapFrom(s => DateTime.Now));

        }

    }
}
