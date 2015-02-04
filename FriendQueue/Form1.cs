using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendQueue
{
    public partial class Form1 : Form
    {
        private FileDAL _dal;
        private List<Friend> _friends;

        public Form1()
        {
            InitializeComponent();
            _dal = new FileDAL("friends.dat");
            _friends = _dal.Read();
            FillListView();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new frmAddFriend())
            {
                addForm.ShowDialog();
                if (addForm.Result != null)
                {
                    _friends.Add(addForm.Result);
                    _friends = _friends
                        .OrderBy(f => f.Date)
                        .ToList();
                    Persist();
                }
            }
        }

        private void Persist()
        {
            lvFriends.Items.Clear();
            FillListView();
            _dal.Write(_friends);
        }

        private void FillListView()
        {
            for (var i = 0; i < _friends.Count; i++)
            {
                var friend = _friends[i];
                lvFriends.Items.Add(new ListViewItem(new[]
                                                         {
                                                             (i + 1).ToString(),
                                                             friend.Name,
                                                             friend.Date.ToShortDateString()
                                                         }) { Tag = friend.Id });
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            var editedFriend = _friends.FirstOrDefault(f => f.Id == (Guid)lvFriends.FocusedItem.Tag);
            using (var addForm = new frmAddFriend(editedFriend))
            {
                addForm.ShowDialog();
                if (editedFriend != null)
                {
                    _friends = _friends
                        .OrderBy(f => f.Date)
                        .ToList();
                    Persist();
                }
            }
        }

        private void lvFriends_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvFriends.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsListItem.Show(Cursor.Position);
                }
            } 
        }

        private void cmsLv_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = cmsListItem.Visible;
        }

        private void tmsiDelete_Click(object sender, EventArgs e)
        {
            _friends.RemoveAll(f => f.Id == (Guid)lvFriends.FocusedItem.Tag);
            Persist();
        }
    }
}
