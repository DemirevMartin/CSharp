/*
 * Created by SharpDevelop.
 * User: User
 * Date: 15.4.2019 г.
 * Time: 8:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Отпуснати_кредити
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int[] krediti;
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
			string[] data = File.ReadAllLines("krediti.txt");
			krediti = new Int32[data.Length];
			for(int i = 0; i < data.Length; i++)
			{
				krediti[i]=Convert.ToInt32(data[i]);
				textBox1.Text = textBox1.Text + data[i] + Environment.NewLine;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Array.Sort(krediti);
			textBox1.Text = "";
			for(int i = 0; i < krediti.Length; i++)
			{
				textBox1.Text+=Convert.ToString(krediti[i]) + Environment.NewLine;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
	        int sum=0;
	    	int br=0;
	    	int br200=0;
	    	double result;
	    	if(radioButton1.Checked)
	    	{
	    		for(int i = 0; i < krediti.Length; i++)
	    		{
	    			if(krediti[i] <= 50000)
	    			{
	    				sum = sum+krediti[i];
	    				br++;
	    			}
	    			if(krediti[i] >= 20000)
	    			{
	    				br200++;
	    			}
	    		}
	    	}
	    	if(radioButton2.Checked)
	    	{
	    		for(int i = 0; i<krediti.Length; i++)
	    		{
	    			if(krediti[i] >= 20000)
	    			{
	    				br200++;
	    			}
                    if (krediti[i] >= 50000)
                    {
                        sum = sum + krediti[i];
                        br++;
                    }
	    		}
	    	}
	    	result = sum/br;
	    	label2.Text=Convert.ToString(result);
	    	label4.Text=Convert.ToString(br200);
	    }
	}
}

	    	
