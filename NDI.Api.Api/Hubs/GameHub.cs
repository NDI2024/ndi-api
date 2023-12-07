using Microsoft.AspNetCore.SignalR;

namespace NDI.Api.Api.Hubs;

public class GameHub : Hub
{
    public async Task JoinGame(string gameId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, gameId);
        await Clients.Group(gameId).SendAsync("UserJoinNotification", $"{Context.ConnectionId} has joined the group {gameId}.");
    }
    
    public async Task LeaveGame(string gameId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, gameId);
        await Clients.Group(gameId).SendAsync("UserLeaveNotification", $"{Context.ConnectionId} has left the group {gameId}.");
    }
    
    public async Task SendGameMessage(string gameId, string message)
    {
        await Clients.Group(gameId).SendAsync("ReceiveGameMessage", $"{Context.ConnectionId}: {message}");
    }
    
    public async Task PlayRound(string gameId)
    {
        await Clients.Group(gameId).SendAsync("ReceiveGameMessage", $"{Context.ConnectionId} has played a round.");
    }
}