using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using FilmSessionModel.Models;
using FilmSessionWeb.Models;

namespace FilmSessionWeb.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Film, FilmViewModel>();
            Mapper.CreateMap<Cinema, CinemaViewModel>();
            Mapper.CreateMap<FilmSession, FilmSessionViewModel>();
            Mapper.CreateMap<RoomFilm, RoomFilmViewModel>();
            Mapper.CreateMap<SeatList, SeatListViewModel>();
            Mapper.CreateMap<SeatTable, SeatTableViewModel>();
            Mapper.CreateMap<SeatType, SeatTypeViewModel>();
            Mapper.CreateMap<Status, StatusViewModel>();
            Mapper.CreateMap<TimeSession, TimeSessionViewModel>();
        }
    }
}