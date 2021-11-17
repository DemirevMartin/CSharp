/*
 * Created by SharpDevelop.
 * User: User
 * Date: 3.10.2019 г.
 * Time: 8:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Array
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int[] scores=new int[26];
			double avr=0;
			int countAvr=0;
			Random r=new Random();
			label2.Text="";
			for(int i=0;i<scores.Length; i++)
			{
				scores[i] = r.Next(2,7);
				label2.Text+=scores[i]+" ";
				avr+=scores[i];
			}
			avr/=scores.Length;
			label4.Text=avr.ToString("F2");
			
			for(int i=0; i<scores.Length; i++)
			{
				if(Math.Abs(avr-scores[i]) <= 0.5) countAvr++;
			}
			label6.Text=countAvr.ToString();
		}
	}
}
