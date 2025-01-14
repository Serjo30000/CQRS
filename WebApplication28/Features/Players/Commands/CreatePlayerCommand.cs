﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication28.Features.Players.Interfaces;
using WebApplication28.Models;

namespace WebApplication28.Features.Players.Commands
{
    public class CreatePlayerCommand : IRequest<Player>
    {
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }

        public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, Player>
        {
            private readonly IPlayersService _playerService;

            public CreatePlayerCommandHandler(IPlayersService playerService)
            {
                _playerService = playerService;
            }

            public async Task<Player> Handle(CreatePlayerCommand command, CancellationToken cancellationToken)
            {
                var player = new Player()
                {
                    ShirtNo = command.ShirtNo.GetValueOrDefault(),
                    Name = command.Name,
                    Appearances = command.Appearances.GetValueOrDefault(),
                    Goals = command.Goals.GetValueOrDefault()
                };

                return await _playerService.CreatePlayer(player);
            }
        }
    }
}
