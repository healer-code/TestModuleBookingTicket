using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FilmSessionModel.Models;
using FilmSessionWeb.Models;

namespace FilmSessionWeb.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateFilm(this Film film, FilmViewModel filmVm)
        {
            film.FilmID = filmVm.FilmID;
            film.FilmPrefix = filmVm.FilmPrefix;
            film.FilmName = filmVm.FilmName;
            film.FilmDuration = filmVm.FilmDuration;
        }
    }
}