using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.ShowDialog();
        } 

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember obj = new NewMember();
            obj.ShowDialog();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff obj = new NewStaff();
            obj.ShowDialog();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment obj = new Equipment();
            obj.ShowDialog();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMembers obj = new SearchMembers();
            obj.ShowDialog();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMembers obj = new DeleteMembers();
            obj.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox obj = new AboutBox();
            obj.ShowDialog();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
