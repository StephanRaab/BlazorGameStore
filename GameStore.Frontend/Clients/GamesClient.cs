using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games = [
       new() {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Action",
            Price = 19.99M ,
            ReleaseDate = new DateOnly(1992, 7, 15)
            },
            new() {
            Id = 2,
            Name = "Final Fantasy IX",
            Genre = "Roleplaying",
            Price = 59.99M ,
            ReleaseDate = new DateOnly(2000, 7, 7)
            },
            new() {
            Id = 3,
            Name = "Fifa 23",
            Genre = "Sports",
            Price = 69.99M ,
            ReleaseDate = new DateOnly(2022, 9, 30)
        },
];

    public GameSummary[] GetGames => [.. games];
}
