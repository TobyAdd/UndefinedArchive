using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UndefinedArchive
{
    public partial class About : Form
    {
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
                m.Result = (IntPtr)(0x2);
        }
        public About()
        {
            InitializeComponent();
            Paint += (s, e) => { ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.White, ButtonBorderStyle.Solid); };
            buttonClose.Click += (s, e) => { Close(); };
        }
    }
}
