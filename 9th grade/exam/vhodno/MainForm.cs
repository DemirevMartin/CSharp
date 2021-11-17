/*
 * Created by SharpDevelop.
 * User: User
 * Date: 10.10.2019 г.
 * Time: 12:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace vhodno
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
			string[]text = File.ReadAllLines("bau.txt");
			textBox2.Text="";
			for(int i=0; i<text.Length; i++)
			{
				textBox2.Text += text[i] + Environment.NewLine;
			}
			button3.Enabled=true;
			button2.Enabled=true;
			button1.Enabled=false;
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			string[]text = File.ReadAllLines("bau.txt");
			textBox2.Text="";
			for(int i=0; i<text.Length-5; i++)
			{
				textBox2.Text += text[i] + Environment.NewLine;
			}
			for(int i=text.Length-5; i<text.Length; i++)
			{
				textBox2.Text += "+++++++++++++++++++" + Environment.NewLine;
			}
			
			button1.Enabled=true;
			button3.Enabled=true;
			button2.Enabled=false;
			textBox1.Enabled=true;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			File.WriteAllText(textBox1.Text,textBox2.Text);
			button1.Enabled=true;
			button3.Enabled=false;
			button2.Enabled=true;
			textBox1.Enabled=false;
			MessageBox.Show("Успешно записване!");
		}
	}
}
