/*
 * Created by SharpDevelop.
 * User: Colin
 * Date: 31/10/2007
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;
using cw.AboutBox;

namespace cw.TimeMonitor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmTime : Form
	{

		public frmTime()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

			//Build up control arrays
			m_TimeLabels = new Label[8]{this.lblTime1,this.lblTime2,this.lblTime3,this.lblTime4,this.lblTime5,this.lblTime6,this.lblTime7,this.lblTime8};
			m_StartButtons = new Button[8]{this.cmdStartStop1,this.cmdStartStop2,this.cmdStartStop3,this.cmdStartStop4,this.cmdStartStop5,this.cmdStartStop6,this.cmdStartStop7,this.cmdStartStop8};
			m_ClearButtons = new Button[8]{this.cmdClear1,this.cmdClear2,this.cmdClear3,this.cmdClear4,this.cmdClear5,this.cmdClear6,this.cmdClear7,this.cmdClear8};
			m_TaskBoxes = new TextBox[8]{this.txtTask1,this.txtTask2,this.txtTask3,this.txtTask4,this.txtTask5,this.txtTask6,this.txtTask7,this.txtTask8};
		}
		
		private void StartStop(int iBtnNo)
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTime));
			DateTime datNow = DateTime.Now;
			Button btnStStop = this.cmdStartStop1;
			Button btnClear = this.cmdClear1;
			Label ctlTime = this.lblTime1;

			//Initialize controls according to button no.
			ctlTime = m_TimeLabels[iBtnNo -1];
			btnStStop = m_StartButtons[iBtnNo -1];
			btnClear = m_ClearButtons[iBtnNo -1];

			if(m_CurrButton != 0){
				//Must be stopping
				stopTiming(m_CurrButton);
				m_StartButtons[m_CurrButton - 1].ImageIndex = 0;

                //Update CurrentButton No.
				if (m_CurrButton == iBtnNo){
					//Just stop current timer
					m_CurrButton = 0;
				}else{
					//Start new timer
					m_CurrButton = iBtnNo;
					m_StartTime = DateTime.Now;      //Reset time
					btnStStop.ImageIndex = 1;
				}
				m_StartTime = DateTime.Now;      //Reset time
			} else{
				//Start Timing
				m_CurrButton = iBtnNo;
				m_StartTime = DateTime.Now;      //Reset time
				btnStStop.ImageIndex = 1;
			}
		}

		private void ClearValue(int iBtnNo)
		{
			//Clears times and labels for selected button
			//

			//Stop timing if current time running still
			if (iBtnNo == m_CurrButton){
				StartStop(iBtnNo);
			}

			m_TimeLabels[iBtnNo - 1].Text = "0:00";
			m_TaskBoxes[iBtnNo - 1].Text = "Task...";

			//Update Totals
			CalcTotal();
		}

		private void CalcTotal()
		{
			//Declare variables
			Label ctlTotal;
			TimeSpan timTotal;
			TimeSpan timTemp;
			String strTime;

			//Initialise
			ctlTotal = this.lblTotal;
			timTotal = new TimeSpan(0,0,0);

			//Add Times
			for (int i=0;i<8;i++)
			{
				 strTime = m_TimeLabels[i].Text + ":00";
				 timTemp = TimeSpan.Parse(strTime);
				 timTotal = timTotal.Add(timTemp);
			}

			//Convert total time back to text
			if(timTotal.Minutes < 10){
				strTime = Convert.ToString(timTotal.Hours)+ ":0" + Convert.ToString(timTotal.Minutes);
			}else{
				strTime = Convert.ToString(timTotal.Hours)+ ":" + Convert.ToString(timTotal.Minutes);
			}

			//Update Total
			ctlTotal.Text = strTime;

		}

		private void CmdStartStop1Click(object sender, System.EventArgs e)
		{
			 StartStop(1);
		}
		private void CmdStartStop2Click(object sender, System.EventArgs e)
		{
			StartStop(2);
		}
		private void CmdStartStop3Click(object sender, System.EventArgs e)
		{
			StartStop(3);
		}
		private void CmdStartStop4Click(object sender, System.EventArgs e)
		{
			StartStop(4);
		}
		private void CmdStartStop5Click(object sender, System.EventArgs e)
		{
			StartStop(5);
		}
		private void CmdStartStop6Click(object sender, System.EventArgs e)
		{
			StartStop(6);
		}
		private void CmdStartStop7Click(object sender, System.EventArgs e)
		{
			StartStop(7);
		}
		private void CmdStartStop8Click(object sender, System.EventArgs e)
		{
			StartStop(8);
		}
 		private void CmdClear1Click(object sender, System.EventArgs e)
		{
			ClearValue(1);
		}
		private void CmdClear2Click(object sender, System.EventArgs e)
		{
			ClearValue(2);
		}
		private void CmdClear3Click(object sender, System.EventArgs e)
		{
			ClearValue(3);
		}
		private void CmdClear4Click(object sender, System.EventArgs e)
		{
			ClearValue(4);
		}
		private void CmdClear5Click(object sender, System.EventArgs e)
		{
			ClearValue(5);
		}
		private void CmdClear6Click(object sender, System.EventArgs e)
		{
			ClearValue(6);
		}
		private void CmdClear7Click(object sender, System.EventArgs e)
		{
			ClearValue(7);
		}
		private void CmdClear8Click(object sender, System.EventArgs e)
		{
			ClearValue(8);
		}

		private void stopTiming(int iBtnNo)
		{
			DateTime datTimeEnd;
			TimeSpan datTimePassed = new System.TimeSpan();
			DateTime datTimePrevious = new System.DateTime();;
			DateTime datTimeNew = new System.DateTime();;
			String strTime;
			Label myLabel = m_TimeLabels[iBtnNo - 1];

			int intMin;
			IFormatProvider format = new System.Globalization.CultureInfo("en-GB", true);

			//Exit if no current task running
			if(m_CurrButton == 0)
			{
				return;
			}

			//Calculate and display elapsed time for running task
			datTimeEnd = DateTime.Now;
			datTimePassed = datTimeEnd.Subtract(m_StartTime);

			//Get time from previous session and add to current
			strTime = myLabel.Text;

			datTimePrevious = System.DateTime.ParseExact(strTime,"h:mm",format);
			datTimeNew = datTimePrevious.Add(datTimePassed);
			intMin = datTimeNew.Minute;
			if(intMin < 10){
				strTime = Convert.ToString(datTimeNew.Hour)+ ":0" + Convert.ToString(datTimeNew.Minute);
			}else{
				strTime = Convert.ToString(datTimeNew.Hour)+ ":" + Convert.ToString(datTimeNew.Minute);
			}

			myLabel.Text = strTime;

			//Update Totals
			CalcTotal();
		}
		
				
		private void MnuExitClick(object sender, System.EventArgs e)
		{
			Application.Exit();

		}
		
		private void MnuClearAllClick(object sender, System.EventArgs e)
		{
			Int32 iCnt;
			DialogResult result;

			result = MessageBox.Show("This will reset all times and tasks. Do you want to continue?",
				"Are you sure?",
				MessageBoxButtons.YesNo);

			if(result == DialogResult.No)
			{
				return;
			}

			//Loop through items, resetting
			for (iCnt=1;iCnt<9;iCnt++)
			{
				ClearValue(iCnt);
			}

		}

		//Show the About form
		private void MnuAboutClick(object sender, System.EventArgs e)
		{
            //MessageBox.Show("About");

			frmAbout.ShowAboutForm(this);
		}

		//Save Settings
		private void SaveSettings()
		{
			//This saves the task titles for future use.  Titles
			//are saved to an XML file TimeMonitor.xml
			XmlDocument xmldoc;
			XmlNode xmlnode;
			XmlElement xmlelem;
			XmlElement xmlelem2;
			XmlText xmltext;

			xmldoc=new XmlDocument();
			//add the XML declaration section
			xmlnode=xmldoc.CreateNode(XmlNodeType.XmlDeclaration,"","");
			xmldoc.AppendChild(xmlnode);

			//add the root element
			xmlelem=xmldoc.CreateElement("","settings","");
			xmldoc.AppendChild(xmlelem);

			//add task elements (child of the root)
			for (int i=1;i<9;i++){
				xmlelem2=xmldoc.CreateElement("","task","");
				xmltext=xmldoc.CreateTextNode(m_TaskBoxes[i-1].Text);
				xmlelem2.AppendChild(xmltext);
				xmlelem2.SetAttribute("taskid",i.ToString());
                xmlelem2.SetAttribute("time", m_TimeLabels[i-1].Text);
                xmldoc.ChildNodes.Item(1).AppendChild(xmlelem2);
			}

			//try to save the XML document in a file: TimeMonitor.xml
			try
			{
				xmldoc.Save("TimeMonitor.xml"); //Save in same directory as EXE
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}


		}

		//Load Settings
		private void LoadSettings()
		{
			Int32 taskNum;
			try{
				XPathDocument xmldoc = new XPathDocument("TimeMonitorx.xml");
				XPathNavigator nav = xmldoc.CreateNavigator();


				//Select all task nodes.
				XPathExpression expr;
				expr = nav.Compile("/settings/task");

				//Display the selection.
				XPathNodeIterator iterator = nav.Select(expr);
				while (iterator.MoveNext()){
					taskNum = Int32.Parse(iterator.Current.GetAttribute("taskid",""));
					m_TaskBoxes[taskNum-1].Text = iterator.Current.ToString();
				}
			}
			catch(Exception ex){
				MessageBox.Show("Sorry, there are no saved task descriptions");
				Debug.WriteLine(ex.Message);
				return;
			}


		}
		
		private void MnuSaveClick(object sender, System.EventArgs e)
		{
			SaveSettings();
		}
		
		private void MnuLoadClick(object sender, System.EventArgs e)
		{
			LoadSettings();
		}


		
	}
}
