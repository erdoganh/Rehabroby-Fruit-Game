using UnityEngine;
using System.Collections;
using System;
using System.Threading;
using System.IO;
using System.IO.Ports;

public class PortController : MonoBehaviour{
	//public 
	static public string portName = "COM3";
	static public int baudRate = 9600;
	static private SerialPort serialPort = new SerialPort( "COM3", 9600);
	
	void Start()
	{
		Debug.Log("Connecting ...");
		showPort();
		OpenConnection();
	}

	void Update(){
		if(Input.GetKey(KeyCode.Space)){
			//char test = ReceiveMessage();
		}
	}

	void showPort()
	{
		// Get a list of serial port names. 
		string[] ports = SerialPort.GetPortNames();
		
		Debug.Log("The following serial ports were found:");
		
		// Display each port name to the console. 
		foreach (string port in ports)
		{
			Debug.Log(port);
		}
	}
	
	void OpenConnection()
	{
		if (serialPort != null)
		{
			if (!serialPort.IsOpen)
			{
				serialPort.Open(); // ouverture de la connection
				serialPort.ReadTimeout = 1;
				Debug.Log("Port ouvert");
			}
		}
		
		else
		{
			Debug.Log("Port == null");
		}

	}

	public static string ReceiveMessage(){
		string receivedData = serialPort.ReadLine();
		return receivedData;
	}

	public static void WriteMessage(String message){
		serialPort.WriteLine(String.Format("Message : {0}",message));
	}

	public static void SendIntMessage(int pin, int value)
	{
		string pinMessage = Convert.ToString(pin);
		string valueMessage = Convert.ToString(value);
		
		char[] message = new char[6]; ;
		
		if (value >= 100) // si la valeur est superieure a 100
		{
			if (pin < 10)
			{
				message[0] = '0';
				message[1] = pinMessage[0];
				message[2] = valueMessage[0];
				message[3] = valueMessage[1];
				message[4] = valueMessage[2];
				message[5] = '\n';
			}
			else
			{
				message[0] = pinMessage[0];
				message[1] = pinMessage[1];
				message[2] = valueMessage[0];
				message[3] = valueMessage[1];
				message[4] = valueMessage[2];
				message[5] = '\n';
			}
		}
		else if (value < 100 && value >= 10) // si la valeur est entre 99 & 10
		{
			if (pin < 10)
			{
				message[0] = '0';
				message[1] = pinMessage[0];
				message[2] = '0';
				message[3] = valueMessage[0];
				message[4] = valueMessage[1];
				message[5] = '\n';
				
				
			}
			else
			{
				message[0] = pinMessage[0];
				message[1] = pinMessage[1];
				message[2] = '0';
				message[3] = valueMessage[0];
				message[4] = valueMessage[1];
				message[5] = '\n';
			}
		}
		
		else if (value < 10) // si la valeur est inferieure a 10
		{
			if (pin < 10)
			{
				message[0] = '0';
				message[1] = pinMessage[0];
				message[2] = '0';
				message[3] = '0';
				message[4] = valueMessage[0];
				message[5] = '\n';
			}
			else
			{
				message[0] = pinMessage[0];
				message[1] = pinMessage[1];
				message[2] = '0';
				message[3] = '0';
				message[4] = valueMessage[0];
				message[5] = '\n';
			}
		}
		
		serialPort.Write(message, 0, 6);
		//Debug.Log("send");
	}    
}