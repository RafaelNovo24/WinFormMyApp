using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FancyWinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelSebMenu2.Visible = false;
            panelSubMedia.Visible = false;
            panelSubMenu3.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMedia.Visible == true)  
            {
                panelSubMedia.Visible = false;
            }
            if (panelSebMenu2.Visible == true)
            {
                panelSebMenu2.Visible = false;
            }
            if (panelSubMenu3.Visible ==true)
            {
                panelSubMenu3.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMedia);
        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSebMenu2);
        }

        private void buttonMenu2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }
    }
}
