/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 20:50
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace AI.NeuronNetwork.Base
{
	/// <summary>
	/// Description of ILayer.
	/// </summary>
	public interface ILayer<T>
	{
		int[] SizeOut{set; get;}
		int OutDim{set; get;}
		
		double Norm{set; get;}
		
		//Дельты
		Tensor4<T> Delts{set; get;}
		
		// ------- Метки весов для регуляризации ----
		// Если false, то вес может иметь любое значение и изменяться
		// в процессе обучения, если true, то значение только 0 и изменения невозможны. 		
		Tensor4<bool> Drop{set; get;}
		
		// Веса НС
		Tensor4<T> Weights{set; get;}
		
		// Прямой проход сети
		Tensor4<T> Output(Tensor4<T> input);
		
		// Ошибка на выходе
		void Delt(Tensor4<T> ideal);
		
		void DeltH(ILayer<T> layer);
		
		// Обратный проход
		Tensor4<T> Backwards();
		
		void Train();
		
		void SetParam(int inp, int outp, int deep, int batchSize);
	}
}
