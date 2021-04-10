﻿using devshops.Core.Repository.Position;
using devshops.Domain.ViewModels.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Services.Position
{
    public class PositionService : IPositionService
    {
        protected readonly IPositionRepository _positionRepository;
        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }
        public Task<IEnumerable<PositionViewModel>> GetAllPositions()
        {
            return _positionRepository.GetAllPositions();
        }
    }
}
