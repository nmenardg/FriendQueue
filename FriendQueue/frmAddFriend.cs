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
    public partial class frmAddFriend : Form
    {
        public Friend Result;

        public frmAddFriend(Friend friend = null)
        {
            InitializeComponent();
            Result = friend;
            if (friend != null)
            {
                txtName.Text = friend.Name;
                if (friend.Date == DateTime.MinValue)
                {
                    chkNever.Checked = true;
                }
                else
                {
                    dtpDate.Value = friend.Date;
                }
            }
        }

        private void chkNever_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = !chkNever.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Result == null)
            {
                Result = new Friend(txtName.Text, chkNever.Checked ? DateTime.MinValue : dtpDate.Value);
            }
            else
            {
                Result.Name = txtName.Text;
                Result.Date = chkNever.Checked ? DateTime.MinValue : dtpDate.Value;
            }
            Close();
        }
    }
}
