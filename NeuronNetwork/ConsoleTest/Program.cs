/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 20:45
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using AI.NeuronNetwork.Base.LayerType;
using AI.NeuronNetwork.Base;
using AI.NeuronNetwork;
using System.Diagnostics;

namespace ConsoleTest
{
	class Program
	{
		public static void Main(string[] args)
		{
			var Fc = new FullConnect<float>(100, 3, 1);
			var net = new Network<float>(OptimiserType.LevenbergMarquardt);
			
			net.Add(Fc);
			var rnd = new Random();
			
			var sw = new Stopwatch();
			
			sw.Start();
			
			var tInp = new Tensor4<float>(1, 1, 100, 1, rnd);
			
			for (int j = 0; j < 100000; j++)
			{
				Tensor4<float> outp = net.Forward(tInp);
			}
			
			sw.Stop();
			
			
			Console.WriteLine("Прямой проход слоя составляет: "+ sw.ElapsedMilliseconds/100000.0+" мс");
			
			Console.ReadKey(true);
		}
	}
}