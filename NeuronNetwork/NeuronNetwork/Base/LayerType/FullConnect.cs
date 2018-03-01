/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 21:36
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using AI.NeuronNetwork.Base;

namespace AI.NeuronNetwork.Base.LayerType
{
	/// <summary>
	/// Description of FullConnect.
	/// </summary>
	public class FullConnect<T> : ILayer<T>
	{
		public int OutDim {get; set;}

		public double Norm{get; set;}

		public Tensor4<bool> Drop {get; set;}

		public Tensor4<T> Weights {get; set;}

		public int[] SizeOut {get; set;}

		public Tensor4<T> Delts {get; set;}
		
		Random rnd = new Random();
		
		
		
		public FullConnect( int inp, int outp, int bs)
		{
			SetParam(1, outp, inp, bs);
		}

		#region ILayer implementation

		public Tensor4<T> Output(Tensor4<T> input)
		{
			Tensor4<T> newInp = Tensor4<T>.DeepAdd1(input);
			return Tensor4<T>.MultAsMatrix(Weights, newInp);
		}

		public void Delt(Tensor4<T> ideal)
		{
			throw new NotImplementedException();
		}

		public void DeltH(ILayer<T> layer)
		{
			throw new NotImplementedException();
		}

		public Tensor4<T> Backwards()
		{
			throw new NotImplementedException();
		}

		public void Train()
		{
			throw new NotImplementedException();
		}

		public void SetParam(int w, int outp, int inp, int batchSize)
		{
			SizeOut = new int[4];
			rnd = new Random();
			SizeOut[0] 	= w;
			SizeOut[1]	= inp;
			SizeOut[2] 	= outp;
			SizeOut[3] 	= batchSize;
			Weights = new Tensor4<T>(1, inp+1, outp, 1, rnd);
		}


		#endregion
	}
}
