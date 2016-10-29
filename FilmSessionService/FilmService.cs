using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionModel.Models;
using FilmSessionData.Repositories;
using FilmSessionData.Infrastructures;

namespace FilmSessionService
{
    public interface IFilmService
    {
        Film Add(Film film);
        Film Delete(Film film);
        IEnumerable<Film> GetAll();

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

        public IEnumerable<Film> GetAll()
        {
            return _filmRepository.GetAll();
        }
    }
}
