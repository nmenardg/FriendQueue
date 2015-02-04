using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendQueue
{
    public class FileDAL
    {
        private readonly string _file;

        public FileDAL(string file)
        {
            _file = file;
        }

        public List<Friend> Read()
        {
            if (File.Exists(_file))
            {
                return File.ReadAllLines(_file)
                    .Select(line => new Friend(line))
                    .OrderBy(f => f.Date)
                    .ToList();
            }
            return new List<Friend>(0);
        }

        public void Write(IEnumerable<Friend> friends)
        {
            var directory = new FileInfo(_file).Directory;
            if (!directory.Exists)
            {
                directory.Create();
            }
            File.WriteAllLines(_file, friends.Select(friend => friend.Serialize()));
        }
    }
}
