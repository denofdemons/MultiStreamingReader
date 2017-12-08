using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using System.Net;
using TwitchLib.Extensions.Client;
using MultiStreamingReader.Model;

namespace MultiStreamingReader.Repository
{
    class TwitchClientApp
    {
        TwitchClient client;
        ConnectionCredentials credentials;

        public TwitchClientApp(UserInfo user)
        {
            credentials = new ConnectionCredentials(user.UserId, user.AccessToken);
            client = new TwitchClient(credentials, user.ChannelId);
            client.OnJoinedChannel += onJoinedChannel;
            client.OnMessageReceived += onMessageReceived;
            client.OnWhisperReceived += onWhisperReceived;
            client.OnNewSubscriber += onNewSubscriber;

            client.Connect();
        }

        private void onJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            client.SendMessage("Hey guys! I am a bot connected via TwitchLib!");
        }
        private void onMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.Contains("badword"))
                client.TimeoutUser(e.ChatMessage.Username, TimeSpan.FromMinutes(30), "Bad word! 30 minute timeout!");
        }
        private void onCommandReceived(object sender, OnWhisperCommandReceivedArgs e)
        {
            if (e.Command == "help")
                client.SendMessage($"Hi there {e.WhisperMessage.Username}! You can view all commands using !command");
        }
        private void onWhisperReceived(object sender, OnWhisperReceivedArgs e)
        {
            if (e.WhisperMessage.Username == "my_friend")
                client.SendWhisper(e.WhisperMessage.Username, "Hey! Whispers are so cool!!");
        }
        private void onNewSubscriber(object sender, OnNewSubscriberArgs e)
        {
            if (e.Subscriber.IsTwitchPrime)
                client.SendMessage($"Welcome {e.Subscriber.DisplayName} to the substers! You just earned 500 points! So kind of you to use your Twitch Prime on this channel!");
            else
                client.SendMessage($"Welcome {e.Subscriber.DisplayName} to the substers! You just earned 500 points!");
        }
    }
}
