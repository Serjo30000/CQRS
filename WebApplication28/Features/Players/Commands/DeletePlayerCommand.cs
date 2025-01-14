﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication28.Features.Players.Interfaces;

namespace WebApplication28.Features.Players.Commands
{
    public class DeletePlayerCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommand, int>
        {
            private readonly IPlayersService _playerService;

            public DeletePlayerCommandHandler(IPlayersService playerService)
            {
                _playerService = playerService;
            }

            public async Task<int> Handle(DeletePlayerCommand command, CancellationToken cancellationToken)
            {
                var player = await _playerService.GetPlayerById(command.Id);
                if (player == null)
                    return default;

                return await _playerService.DeletePlayer(player);
            }
        }
    }
}
