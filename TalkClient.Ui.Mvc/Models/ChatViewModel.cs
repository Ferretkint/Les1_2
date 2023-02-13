namespace TalkClient.Ui.Mvc.Models
{
    public class ChatViewModel
    {
        public IList<ChatChannel>? Channels { get; set; }
        public IList<ChatMessage>? Messages { get;set; }
    }
}
