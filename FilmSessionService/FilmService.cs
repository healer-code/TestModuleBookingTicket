using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionModel.Models;
using FilmSessionData.Repositories;
using FilmSessionData.Infrastructures;
using FilmSessionCommon.BookingTime;

namespace FilmSessionService
{
    public interface IFilmService
    {
        Film Add(Film film);
        Film Delete(Film film);
        IEnumerable<Film> GetAll();
        Film GetFilmDetail(int id);
        Film GetFilmWithSessionTime(int id);
        BookingPlan GenerateBookingPLan(Film film);
    }
    public class FilmService : IFilmService
    {
        private IFilmRepository _filmRepository;
        private IUnitOfWork _unitOfWork;

        public FilmService(IFilmRepository filmRepository, IUnitOfWork unitOfWork)
        {
            _filmRepository = filmRepository;
            _unitOfWork = unitOfWork;
        }

        public Film Add(Film film)
        {
            return _filmRepository.Add(film);
        }

        public Film Delete(Film film)
        {
            return _filmRepository.Delete(film);
        }

        public BookingPlan GetFilmSessionTime(Film film)
        {
            var filmSession = _filmRepository.GetFullFilmDetail(film.FilmID);
            return new BookingTimeHelpers().ConvertJsonToBookingTime(filmSession.FilmCalendar);
        }

        public IEnumerable<Film> GetAll()
        {
            return _filmRepository.GetAll();
        }

        public Film GetFilmDetail(int id)
        {
            return _filmRepository.GetSingleById(id);
        }

        public Film GetFilmWithSessionTime(int id)
        {
            return _filmRepository.GetFilmWithSessionTime(id);           
        }

        public BookingPlan GenerateBookingPLan(Film film)
        {
            if (film.FilmSessions.Count == 0) return null;
            return new BookingTimeHelpers().ConvertJsonToBookingTime(film.FilmSessions.Last().FilmCalendar);
        }
    }
}
