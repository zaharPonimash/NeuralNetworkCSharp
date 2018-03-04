/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 21:40
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace AI.NeuronNetwork.Base.ActivationType
{
	/// <summary>
	/// Description of Sigmoid.
	/// </summary>
	public class Sigmoid<T>: ILayer<T>, IActivation
	{
		public int OutDim {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public double Norm {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Tensor4<bool> Drop {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

	public Tensor4<T> Weights {
		get {
			throw new NotImplementedException();
		}
		set {
			throw new NotImplementedException();
		}
	}

		public Sigmoid()
		{
		}

		#region ILayer implementation

		public Tensor4<T> Output(Tensor4<T> input)
		{
			Tensor4<T> newTen = new Tensor4<T>(input.W, input.H, input.D, input.BS);
			
			#region Вычисление активации		
			if(input[0,0,0,0] is double)
			{
				for (int i = 0; i < input.W; i++)
				for (int j = 0; j < input.H; j++)
					for(int k = 0; k<input.D; k++)
						for (int z = 0; z < input.BS; z++)
						{
							newTen[i,j,k,z] = 1.0/(1+Math.Exp(-(input[i,j,k,z] as dynamic)));
						}
			}
			else if(input[0,0,0,0] is float)
			{
				for (int i = 0; i < input.W; i++)
				for (int j = 0; j < input.H; j++)
					for(int k = 0; k<input.D; k++)
						for (int z = 0; z < input.BS; z++)
						{
					newTen[i,j,k,z] = (dynamic)((float)(1.0/(1+Math.Exp(-(input[i,j,k,z] as dynamic)))));
						}	
			}
			
			else if(input[0,0,0,0] is int)
			{
				for (int i = 0; i < input.W; i++)
				for (int j = 0; j < input.H; j++)
					for(int k = 0; k<input.D; k++)
						for (int z = 0; z < input.BS; z++)
						{
							newTen[i,j,k,z] = (dynamic)((int)(10/(1+Math.Exp(-(input[i,j,k,z] as dynamic)))));
						}	
			}
	
			
		#endregion
			
			return newTen;
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

		public void SetParam(int inp, int outp, int deep, int batchSize)
		{
			throw new NotImplementedException();
		}

		public int[] SizeOut{get; set;}

		public double Eps {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Tensor4<T> Delts {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		#endregion
	}
}
