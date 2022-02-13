using System;
namespace Heater
{
	public class Heater
	{
		protected bool isWorking;
		protected Heater()
		{
			isWorking = false;
		}
		
		public virtual void TurnOn()
		{
			if(isWorking) return;
			Console.WriteLine("Изпълнете посочените действия и се насладете на топлината :)");
			isWorking = true;
		}
		
		public virtual void TurnOff()
		{
			if(!isWorking) return;
			Console.WriteLine("Изпълнете точно изброените действия!");
			isWorking = false;
		}
	}
	class Fireplace : Heater
	{
		public Fireplace()
		{
			Console.WriteLine("Камина с дърва");
		}
		public override void TurnOn()
		{
			if(isWorking)
			{
				return;
			}
			else
			{
				base.TurnOn();
				Console.WriteLine("Изчистете камината, ако е нужно. \nЗаредете я с дърва.\nОтворете клапата и запалете огъня.");
			}
		}
		public override void TurnOff()
		{
			if(!isWorking)
			{
				return;
			}
			else
			{
				base.TurnOff();
				Console.WriteLine("Затворете клапата на камината. \nУверете се, че дървата за загаснали.\nУверете се, че няма останали живи въглени. " +
				                  "\nСъберете и изхвърлете пепелта.");
			}
		}
	}
	class GasStove : Heater
	{
		public GasStove()
		{
			Console.WriteLine("Газова печка");
		}
		public override void TurnOn()
		{
			if(isWorking)
			{
				return;
			}
			else
			{
				base.TurnOn();
				Console.WriteLine("Отворете клапата на газта и запалете. \nИзберете желаната степен.");
			}
		}
		public override void TurnOff()
		{
			if(!isWorking)
			{
				return;
			}
			else
			{
				base.TurnOff();
				Console.WriteLine("Загасете пламъка и затворете клапата на газта. \nПроверете повторно дали клапата на газта е затворена!");
			}
		}
	}
	class ElectricRadiator : Heater
	{
		public ElectricRadiator()
		{
			Console.WriteLine("Електрически радиатор");
		}
		public override void TurnOn()
		{
			if(isWorking)
			{
				return;
			}
			else
			{
				base.TurnOn();
				Console.WriteLine("Включете радиатора в захранването. "+
				"\nПоставете бутона за включване/изключване в позиция \"Включено\". \nИзберете желаната степен.");
			}
		}
		public override void TurnOff()
		{
			if(!isWorking)
			{
				return;
			}
			else
			{
				base.TurnOff();
				Console.WriteLine("Поставете бутона за включване/изключване в позиция \"Изключено\"."
				                  +"\nИзключете радиатора от захранването.");
			}
		}
	}
	class AirConditioner : Heater
    {
		public AirConditioner()
		{
			Console.WriteLine("Климатик");
		}
		public override void TurnOn()
		{
			if(isWorking)
			{
				return;
			}
			else
			{
				base.TurnOn();
				Console.WriteLine("Включете климатика в захранването. \nВключете го от дистанционното управление."+
				"\nНастройте на \"Отопление\". \nИзберете желаната температура.");
			}
		}
		public override void TurnOff()
		{
			if(!isWorking)
			{
				return;
			}
			else
			{
				base.TurnOff();
				Console.WriteLine("Изключете климатика от дистанционното управление.");
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Fireplace f = new Fireplace();
			f.TurnOn();
			Console.WriteLine("");
			Console.WriteLine("");
			f.TurnOff();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			GasStove g = new GasStove();
			g.TurnOn();
			Console.WriteLine("");
			Console.WriteLine("");
			g.TurnOff();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			ElectricRadiator e = new ElectricRadiator();
			e.TurnOn();
			Console.WriteLine("");
			Console.WriteLine("");
			e.TurnOff();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			AirConditioner a = new AirConditioner();
			a.TurnOn();
			Console.WriteLine("");
			Console.WriteLine("");
			a.TurnOff();
			Console.ReadKey(true);
		}
	}
}