using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionModel.Models;
using FilmSessionData.Infrastructures;
using FilmSessionData.Repositories;

namespace FilmSessionService
{
    public interface IRoomFilmService
    {
        RoomFilm GetSingleById(int id);
    }
    class RoomFilmService : IRoomFilmService
    {
        private IRoomFilmRepository _roomFilmRepository;
        private IUnitOfWork _unitOfWork;
        public RoomFilmService(IRoomFilmRepository roomFilmRepository, IUnitOfWork unitOfWork)
        {
            _roomFilmRepository = roomFilmRepository;
            _unitOfWork = unitOfWork;
        }
        public RoomFilm GetSingleById(int id)
        {
            return _roomFilmRepository.GetSingleById(id);
        }
    }
}
