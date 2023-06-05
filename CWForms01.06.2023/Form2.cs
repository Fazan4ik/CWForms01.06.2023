using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWForms01._06._2023
{
    public partial class Form2 : Form
    {
        private MenuStrip menuStrip;
        private int menuItemCounter = 1;
        public Form2()
        {
            InitializeComponent();
            InitializeMenu();
        }
        private void InitializeMenu()
        {
            menuStrip = new MenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Menu 1");
            menuStrip.Items.Add(menuItem1);
            menuItem1.MouseEnter += MenuItem_MouseEnter;
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            menuItemCounter++;
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.DropDownItems.Clear();
            ToolStripMenuItem newMenuItem = new ToolStripMenuItem($"Menu {menuItemCounter}");
            menuItem.DropDownItems.Add(newMenuItem);
            newMenuItem.MouseEnter += MenuItem_MouseEnter;
        }
    }
}
