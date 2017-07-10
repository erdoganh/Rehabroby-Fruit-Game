using UnityEngine;
using System.Collections;
using System.IO;
using System.IO.Ports;
using System.Threading;

public class RS232PortController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	public partial class Form1 : Form
	{
		private delegate void SetTextDeleg(string data);
		
		public Form1()
		{
			InitializeComponent();
			SettingRS232();
		}
		
		public void SettingRS232 ()
		{
			try
			{
				SerialPort mySerialPort = new SerialPort("COM6");
				
				mySerialPort.BaudRate = 9600;
				mySerialPort.Parity = Parity.None;
				mySerialPort.StopBits = StopBits.One;
				mySerialPort.DataBits = 8;
				mySerialPort.Handshake = Handshake.None;
				mySerialPort.ReadTimeout = 2000;
				mySerialPort.WriteTimeout = 500;
				
				mySerialPort.DtrEnable = true;
				mySerialPort.RtsEnable = true;
				
				mySerialPort.Open();
				//mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
				mySerialPort.DataReceived += DataReceivedHandler;
				
				textBox1.Text = "Serial Port is Ready.";
				
			}
			catch (Exception ex)
			{
				textBox1.Text = ex.Message;    
			}
			
		}
		
		public void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;
			System.Threading.Thread.Sleep(500);
			string indata = sp.ReadExisting();
			this.BeginInvoke(new SetTextDeleg(DisplayToUI), new object[] { indata });
			//textBox1.Text += indata;
			
		}
		
		private void DisplayToUI(string displayData)
		{
			textBox1.Text += displayData.Trim();
			// textBox1.Text += displayData;
			
		}
		
	}
*/
}