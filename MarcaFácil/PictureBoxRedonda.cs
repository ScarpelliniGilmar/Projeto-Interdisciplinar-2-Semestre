using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MarcaFácil
{
    class PictureBoxRedonda : PictureBox
    {
        public PictureBoxRedonda()
        {
            BackColor = Color.Transparent;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
                Region = new Region(gp);
            }
        }
    }
}
