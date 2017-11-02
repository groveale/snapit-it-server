using Microsoft.Azure.Mobile.Server;

namespace split_it_server.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}