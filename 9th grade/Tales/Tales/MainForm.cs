/*
 * Created by SharpDevelop.
 * User: User
 * Date: 3.10.2019 г.
 * Time: 9:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Tales
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
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
		
		void Button1Click(object sender, EventArgs e)
		{
			string[] text=File.ReadAllLines("folk.txt");
			textBox1.Text="";
			for(int i=0;i<text.Length;i++)
			{
				textBox1.Text="Tale" + (i+1) + " " + text[i] + "\r\n";
			}
			label1.Text="A list of" + text.Length + "English Folk Tales";
		}
	}
}
