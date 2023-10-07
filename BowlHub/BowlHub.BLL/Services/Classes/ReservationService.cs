using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.BLL.Services.Classes;

public class ReservationService : IReservationService
{
    private readonly IReservationRepository _reservationRepository;
    private readonly IMapper _mapper;
    
    public ReservationService(IReservationRepository repository, IMapper mapper)
    {
        _reservationRepository = repository;
        _mapper = mapper;
    }
    
    public async Task<Dictionary<string, List<int[]>>> GetTimeInfoByLineId(Guid id, int lineId, DateTime date)
    {
        return await _reservationRepository.GetTimeInfoByLineId(id, lineId, date);
    }

    public async Task<ReservationModel> AddNewReservation(ReservationModel reservationModel)
    {
        var result = await _reservationRepository.AddAsync(_mapper.Map<ReservationEntity>(reservationModel));
        return _mapper.Map<ReservationModel>(result);
    }
}