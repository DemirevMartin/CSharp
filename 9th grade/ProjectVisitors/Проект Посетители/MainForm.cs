/*
 * Created by SharpDevelop.
 * User: User
 * Date: 8.4.2019 г.
 * Time: 11:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Проект_Посетители
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int[] visitors;
		
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
             textBox1.Text="";
             string[] data = File.ReadAllLines("visitorslog.txt");
             visitors = new int[data.Length];
             for (int i= 0; i < visitors.Length; i++)
             {
             	visitors[i] = int.Parse(data[i]);
             	textBox1.Text += visitors[i] + Environment.NewLine;
             }
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int total=0, max = visitors[0], min = visitors[0];
			double avgVis = 0;
			for (int i = 0; i < visitors.Length; i++)
			{
				total += visitors[i];
				if(visitors[i] > max)
				{
					max = visitors[i];
				}
				else if(visitors[i] < min)
				{
					min = visitors[i];
				}
			}
			avgVis = total/visitors.Length;
			label5.Text = total.ToString();
			label6.Text = avgVis.ToString("f1");
			label7.Text = max.ToString();
			label8.Text = min.ToString();
		}
	}
}
