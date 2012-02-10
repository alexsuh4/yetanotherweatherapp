using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Weather
{
    public class drawPanel:Panel
    {
        int x = 0;
        int y = 20;
        public int speed = 2;
       
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            
            
            Bitmap bmp=new Bitmap(e.ClipRectangle.Right,e.ClipRectangle.Bottom);
            Graphics graph = Graphics.FromImage(bmp);

            graph.DrawImage(Resource1.cloud_icon_5, new System.Drawing.Rectangle(x, y, 120, 60));
            e.Graphics.DrawImage(bmp, new Point(0, 0));
            x = (x + speed) % this.Width;
        }
    }
}
