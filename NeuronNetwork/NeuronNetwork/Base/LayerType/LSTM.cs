/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 21:38
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace AI.NeuronNetwork.Base.LayerType
{
	/// <summary>
	/// Description of LSTM.
	/// </summary>
	public class LSTM<T> : ILayer<T>
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

		public LSTM()
		{
		}

		#region ILayer implementation

		public Tensor4<T> Output(Tensor4<T> input)
		{
			throw new NotImplementedException();
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
