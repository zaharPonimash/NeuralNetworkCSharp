/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 02.03.2018
 * Время: 13:53
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace AI.NeuronNetwork.Base.ActivationType
{
	/// <summary>
	/// Description of Linear.
	/// </summary>
	public class Linear<T> : ILayer<T>, IActivation
	{
		public Linear()
		{
			
		}

		#region IActivation implementation
		public double Eps {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}
		#endregion
		
		#region ILayer implementation

		public Tensor4<T> Output(Tensor4<T> input)
		{
			return input;
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

		public int[] SizeOut {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

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

		public Tensor4<T> Delts {
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

		#endregion
	}
}
