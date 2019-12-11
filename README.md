# Rocket.Chat.Core
Rocket .Chat interface for .NET Core

# Usage Example

```csharp
string host = "https://rocket.chat.server";
IRocketChatApi rocketChat = new RocketChat(host).Api;

var loginResult = await rocketChat.Authentication.Login("username", "password");
if (loginResult.Success)
{
    Result<IEnumerable<Channel>> channelsResult = await rocketChat.Channels.ListJoined();
    if (channelsResult.Success)
    {
        IEnumerable<Channel> channelsJoined = channelsResult.Content;
        .
        .
        .
    }
}
```