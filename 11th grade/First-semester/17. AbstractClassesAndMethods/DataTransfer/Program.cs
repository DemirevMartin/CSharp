using System;
namespace DataTransfer
{
	public interface IConnectable
	{
		bool Connect();
        void Disconnect();
	}
	public interface ITransferable
	{
		string ReceiveMessage();
        void SendMessage(string message);
	}
	public class DBConnection : IConnectable, ITransferable
	{
		private string dbServer, dbUser, dbPass;
		private bool isConnected;
		public DBConnection (string dbServer, string dbUser, string dbPass)
		{
			this.dbServer = dbServer;
			this.dbUser = dbUser;
			this.dbPass = dbPass;
			isConnected = false;
		}
		public bool Connect()
		{
			Console.WriteLine("Опит за свързване с DB Server: {0}", dbServer);
			Random r = new Random();
			int a = r.Next(1, 11);
			if(a == 10)
			{
			    Console.WriteLine("Неуспешно свързване, моля проверете потребителското име и паролата!");
			    isConnected = false;
			    return false;
			}
			else
			{
				Console.WriteLine("Успешно свързване с базата данни");
				isConnected = true;
			    return true;
			}
		}
		public void Disconnect()
		{
			Console.WriteLine("Край на връзката с DB Server: {0}", dbServer);
			isConnected = false;
		}
		public string ReceiveMessage()
		{
			string s = "";
			Random rnd = new Random();
			while(s.Length != 10)
			{
			    int position = 0;
				for(char c = 'а'; c <= 'я'; c++) //Използва буквите от руската азбука
			    {
			        int letterPosition = rnd.Next(1, 34);
					position++;
				    if(position == letterPosition)
				    {
				    	s += c;
				    	break;
				    }
			    }
			}
			return s;
		}
		public void SendMessage(string message)
		{
			Console.WriteLine("Към базата данни е изпратено съобщението: {0}", message);
		}
	}
	public class CellPhoneConnection : IConnectable, ITransferable
	{
		private string numToCall;
		public CellPhoneConnection (string numToCall)
		{
			this.numToCall = numToCall;
		}
		public bool Connect()
		{
			Console.WriteLine("Опит за свързване с телефонен номер: {0}", numToCall);
			Random r = new Random();
			int a = r.Next(1, 21);
			if(a > 15)
			{
				Console.WriteLine("Абонатът е зает, моля опитайте по-късно!");
				return false;
			}
			else
			{
				Console.WriteLine("Успешно свързване!");
				return true;
			}
		}
		public void Disconnect()
		{
			Console.WriteLine("Край на разговора с телефонен номер: {0}", numToCall);
		}
		public string ReceiveMessage()
		{
			return "Ало";
		}
		public void SendMessage(string message)
		{
			Console.WriteLine("По телефона е предадено съобщението: {0}", message);
		}
	}
	public class BluetoothConnection : IConnectable, ITransferable
	{
		private string deviceToPair;
		public BluetoothConnection()
		{
			deviceToPair = "";
		}
		public bool Connect()
		{
			Console.Write("Въведете устройство за свързване: ");
			deviceToPair  = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Опит за установяване на Bluetooth връзка с устройство: {0}", deviceToPair);
			Random r = new Random();
			int a = r.Next(1, 9);
			if(a > 5)
			{
				Console.WriteLine("Неуспешно сдвояване, моля опитайте по-късно!");
				return false;
			}
			else
			{
				Console.WriteLine("Успешно сдвояване!");
				return true;
			}
		}
		public void Disconnect()
		{
			Console.WriteLine("Прекратена е Bluetooth връзка с устройство: {0}", deviceToPair);
		}
		public string ReceiveMessage()
		{
			return "Bluetooth поздрав!";
		}
		public void SendMessage(string message)
		{
			Console.WriteLine("На Bluetooth сдвоеното устройство е предадено съобщението: {0}", message);
		}
	}
	public class AirFlowConnection : IConnectable
	{
		private bool connected;
		public AirFlowConnection()
		{
			connected = false;
		}
		public bool Connect()
		{
			Console.Write("Да се свърже ли помещението към общата вентилационна система? ");
			string answer = Convert.ToString(Console.ReadLine());
			if(answer == "Да")
			{
				Console.WriteLine("Успешно свързване към общата вентилационна система!");
				return true;
			}
			else
			{
				Console.WriteLine("Неуспешно свързване към общата вентилационна система!");
				return false;
			}
		}
		public void Disconnect()
		{
			Console.WriteLine("Прекъсната е връзката с общата вентилационна система!");
			connected = false;
		}
	}
	class Program
	{
		public static void TestConnection(IConnectable cntn)
		{
			IConnectable ic = (IConnectable) cntn;
			bool result = cntn.Connect();
			if(result)
			{
				if(cntn is ITransferable)
                {
                   ITransferable itr = (ITransferable)cntn;
                   Console.WriteLine("Получено е съобщение: {0}", itr.ReceiveMessage());
                   itr.SendMessage("Здравей");
				}
				cntn.Disconnect();
			}
		}
		public static void Main(string[] args)
		{
			DBConnection bd = new DBConnection("SQL_server", "Admin", "pass123");
			TestConnection(bd);
			Console.WriteLine("");
			CellPhoneConnection cp = new CellPhoneConnection("052100102");
			TestConnection(cp);
			Console.WriteLine("");
			BluetoothConnection bt = new BluetoothConnection();
			TestConnection(bt);
			Console.WriteLine("");
			AirFlowConnection af = new AirFlowConnection();
			TestConnection(af);
			Console.ReadKey(true);
		}
	}
}