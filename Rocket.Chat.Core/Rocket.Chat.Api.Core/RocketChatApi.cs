using Rocket.Chat.Api.Core.Services;

namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApi
    {
        IGroupsService Groups { get; }
        IChannelsService Channels { get; }
        IAuthenticationService Authentication { get; }
    }

    public class RocketChatApi : IRocketChatApi
    {
        public RocketChatApi(
            IGroupsService groupsService,
            IChannelsService channelsService,
            IAuthenticationService authenticationService)
        {
            Groups = groupsService;
            Channels = channelsService;
            Authentication = authenticationService;
        }

        public IGroupsService Groups { get; }
        public IChannelsService Channels { get; }
        public IAuthenticationService Authentication { get; }
    }
}