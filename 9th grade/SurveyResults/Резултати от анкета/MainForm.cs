/*
 * Created by SharpDevelop.
 * User: User
 * Date: 27.11.2019 г.
 * Time: 10:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Резултати_от_анкета
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		void CalcPercentage(TextBox textBoxA, TextBox textBoxB, TextBox textBoxC, Label labelA, Label labelB, Label labelC)
		{
			int y=Convert.ToInt32(textBoxA.Text);
			int n=Convert.ToInt32(textBoxB.Text);
			int dn=Convert.ToInt32(textBoxC.Text);
			double sum=y+n+dn;
			labelA.Text=(y/sum*100).ToString("F2") + "%";
			labelB.Text=(n/sum*100).ToString("F2") + "%";
			labelC.Text=(dn/sum*100).ToString("F2") + "%";
		}
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
		
		void Button1Click(object sender, EventArgs e)
		{
			CalcPercentage(textBox1,textBox2,textBox3,label17,label18,label19);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
            CalcPercentage(textBox4,textBox5,textBox6,label20,label21,label22);			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
            CalcPercentage(textBox7,textBox8,textBox9,label23,label24,label25);				
		}
	}
}
