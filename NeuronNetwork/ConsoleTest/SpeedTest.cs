/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 02.03.2018
 * Время: 19:59
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Diagnostics;
using AI.NeuronNetwork;
using AI.NeuronNetwork.Base;
using AI.NeuronNetwork.Base.ActivationType;
using AI.NeuronNetwork.Base.LayerType;

namespace ConsoleTest
{
	/// <summary>
	/// Description of SpeedTest.
	/// </summary>
	public static class SpeedTest
	{
		public static void SpeedFloat()
		{
			Console.WriteLine("================ Float Test ============== \n\n");
			int count = 10000;
			
			var Fc = new FullConnect<float>(100, 3, 1);
			var sig = new Sigmoid<float>();
			var net = new Network<float>(OptimiserType.LevenbergMarquardt);
			
			net.Add(Fc);
			net.Add(sig);
			var rnd = new Random();
			
			var sw = new Stopwatch();
			
			
			
			var tInp = new Tensor4<float>(1, 1, 100, 1, rnd);
			Tensor4<float> outp = new Tensor4<float>(1,1,1,1);
			
			
			sw.Start();
			for (int j = 0; j < count; j++)
			{
				outp = net.Forward(tInp);
			}
			
			Console.WriteLine("Прямой проход слоя составляет: "+ sw.ElapsedMilliseconds/(double)count+" мс");
			
			sw.Stop();
			
			Console.WriteLine("\n\n");
			
			for (int i = 0; i < outp.D; i++)
				Console.WriteLine(outp[0,0,i,0]);
		}
		
		
		
		
		
		public static void SpeedDoubleTest()
		{
			
			
			Console.WriteLine("================ Double Test ============== \n\n");
			int count = 10000;
			
			var Fc = new FullConnect<double>(100, 3, 1);
			var sig = new Sigmoid<double>();
			var net = new Network<double>(OptimiserType.LevenbergMarquardt);
			
			net.Add(Fc);
			net.Add(sig);
			var rnd = new Random();
			
			var sw = new Stopwatch();
			
			var tInp = new Tensor4<double>(1, 1, 100, 1, rnd);
			Tensor4<double> outp = new Tensor4<double>(1,1,1,1);
			
			sw.Start();
			for (int j = 0; j < count; j++)
			{
				outp = net.Forward(tInp);
			}
			
			Console.WriteLine("Прямой проход слоя составляет: "+ sw.ElapsedMilliseconds/(double)count+" мс");
			
			sw.Stop();
			
			Console.WriteLine("\n\n");
			
			for (int i = 0; i < outp.D; i++)
				Console.WriteLine(outp[0,0,i,0]);
		}
		
		
		
		public static void SpeedInt32Test()
		{
			Console.WriteLine("================ Int Test ============== \n\n");
			int count = 10000;
			
			var Fc = new FullConnect<int>(100, 3, 1);
			var sig = new Sigmoid<int>();
			var net = new Network<int>(OptimiserType.LevenbergMarquardt);
			
			net.Add(Fc);
			net.Add(sig);
			var rnd = new Random();
			
			var sw = new Stopwatch();
			
			var tInp = new Tensor4<int>(1, 1, 100, 1, rnd);
			Tensor4<int> outp = new Tensor4<int>(1,1,1,1);
			
			sw.Start();
			for (int j = 0; j < count; j++)
			{
				outp = net.Forward(tInp);
			}
			
			Console.WriteLine("Прямой проход слоя составляет: "+ sw.ElapsedMilliseconds/(double)count+" мс");
			
			sw.Stop();
			
			Console.WriteLine("\n\n");
			
			for (int i = 0; i < outp.D; i++)
				Console.WriteLine(outp[0,0,i,0]);
		}
	}
}
