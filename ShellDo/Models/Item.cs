using System;

namespace ShellDo.Models
{
    public class Item
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Text { get; set; }
        public string Description { get; set; }

    }
}