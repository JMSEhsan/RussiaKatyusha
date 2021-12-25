using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace RussiaKatyusha
{
	public partial class RussiaKatyusha : Form
	{
		public RussiaKatyusha()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			this.Width = 1000;
			this.Height = 600;
			this.BackColor = Color.WhiteSmoke;
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			DrawFlag(g, 20, 20, this.Width - 60);
			g.Dispose();
		}
		private void DrawFlag(Graphics g, float x0, float y0, float width)
		{
			SolidBrush whitesmokeBrush = new SolidBrush(Color.WhiteSmoke);
			SolidBrush whiteBrush = new SolidBrush(Color.White);
			SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 51, 160));
			SolidBrush redBrush = new SolidBrush(Color.FromArgb(218, 41, 28));

			float height = 10 * width / 19;

			g.FillRectangle(whitesmokeBrush, x0, y0, width, height);

            for (int i = 0; i < 400; i++)
            {
                
				g.FillRectangle(whiteBrush, x0, y0 + (399 - i) * height / 399, width, height / 3);
				//g.FillRectangle(whitesmokeBrush, x0-1, y0 + height + 0, width+2, 50);
				g.FillRectangle(blueBrush, x0, y0 + (399 - i) * height / 399 + height / 3, width, height / 3);
				//g.FillRectangle(whitesmokeBrush, x0-1, y0 + height + 0, width+2, 50);
				g.FillRectangle(redBrush, x0, y0 + (399 - i) * height / 399 + 2 * height / 3, width, height / 3);
				g.FillRectangle(whitesmokeBrush, x0-1, y0 + (399 - i) * height / 299 + height, width+2, 50);
				Thread.Sleep(200);			
			}
			whitesmokeBrush.Dispose();
			whiteBrush.Dispose();
			blueBrush.Dispose();
			redBrush.Dispose();
		}
		
	}
}