using System;

namespace FriendQueue
{
    [Serializable]
    public class Friend
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Friend(string name, DateTime date)
        {
            Id = Guid.NewGuid();
            Name = name;
            Date = date;
        }

        public Friend(string serialized)
        {
            var data = serialized.Split(';');
            Id = new Guid(Convert.FromBase64String(data[0]));
            Name = data[1];
            Date = DateTime.FromBinary(BitConverter.ToInt64(Convert.FromBase64String(data[2]), 0));
        }

        public string Serialize()
        {
            return String.Join(";",
                               Convert.ToBase64String(Id.ToByteArray()),
                               Name,
                               Convert.ToBase64String(
                                   BitConverter.GetBytes(
                                       Date.ToBinary()
                                       )
                                   )
                );
        }
    }
}
