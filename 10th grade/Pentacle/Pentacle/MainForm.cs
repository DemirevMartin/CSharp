using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pentacle
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            Point pA = new Point (320, 30);
            Point pB = new Point (250, 250);
            Point pC = new Point (390, 250);

            Point[] fig1 = {pA, pB, pC};
            g.FillPolygon(new SolidBrush(Color.Yellow), fig1);
            
            Point pD = new Point (10, 250);
            Point pE = new Point (250, 250);
            Point pF = new Point (210, 380);
            
            Point[] fig2 = {pD, pE, pF};
            g.FillPolygon(new SolidBrush(Color.Yellow), fig2);

            Point pG = new Point (210, 380);
            Point pH = new Point (320, 460);
            Point pI = new Point (120, 610);
            
            Point[] fig3 = {pG, pH, pI};
            g.FillPolygon(new SolidBrush(Color.Yellow), fig3);
            
            Point pJ = new Point (430, 380);
            Point pK = new Point (320, 460);
            Point pL = new Point (520, 610);
            
            Point[] fig4 = {pJ, pK, pL};
            g.FillPolygon(new SolidBrush(Color.Yellow), fig4);

            Point pM = new Point (390, 250);
            Point pN = new Point (630, 250);
            Point pO = new Point (430, 380);
            
            Point[] fig5 = {pM, pN, pO};
            g.FillPolygon(new SolidBrush(Color.Yellow), fig5); 

            Point pQ = new Point (250, 250-1);
            Point pW = new Point (210-1, 380+1);
            Point pY = new Point (320-1, 460+1);
            Point pX = new Point (430+1, 380+1);
            Point pV = new Point (390, 250-1);
            
            Point[] fig6 = {pQ, pW, pY, pX, pV};
            g.FillPolygon(new SolidBrush(Color.Yellow), fig6);             
		}
	}
}
