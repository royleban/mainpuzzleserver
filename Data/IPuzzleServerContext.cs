﻿using Microsoft.EntityFrameworkCore;

namespace ServerCore.DataModel
{
    public interface IPuzzleServerContext
    {
        DbSet<Event> Events { get; set; }
        DbSet<EventAdmins> EventAdmins { get; set; }
        DbSet<EventAuthors> EventAuthors { get; set; }
        DbSet<EventTeams> EventTeams { get; set; }
        DbSet<Feedback> Feedback { get; set; }
        DbSet<Invitation> Invitations { get; set; }
        DbSet<Prerequisites> Prerequisites { get; set; }
        DbSet<Puzzle> Puzzles { get; set; }
        DbSet<PuzzleAuthors> PuzzleAuthors { get; set; }
        DbSet<ContentFile> ContentFiles { get; set; }
        DbSet<PuzzleStatePerTeam> PuzzleStatePerTeam { get; set; }
        DbSet<Response> Responses { get; set; }
        DbSet<Submission> Submissions { get; set; }
        DbSet<TeamMembers> TeamMembers { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<PuzzleUser> PuzzleUsers { get; set; }
    }
}