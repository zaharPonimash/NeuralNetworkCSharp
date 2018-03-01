# NeuralNetworkCSharp
Нейронная сеть с поддержкой всех типов слоев


Пример теста скорости работы полносвязного слоя:

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
