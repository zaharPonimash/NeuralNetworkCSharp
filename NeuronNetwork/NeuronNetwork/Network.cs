/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 22:12
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using AI.NeuronNetwork.Base;
using System.Collections.Generic;

namespace AI.NeuronNetwork
{
	/// <summary>
	/// Description of Network.
	/// </summary>
	public class Network<T>
	{
		
		List<ILayer<T>> layers = new List<ILayer<T>>();
		OptimiserType optimiserType;
		
		public Network(OptimiserType opt = OptimiserType.StohasticGradientDecent)
		{
			optimiserType = opt;
		}
		
		
		public void Add(ILayer<T> layer)
		{
			if(layers.Count == 0)
			{
				layers.Add(layer);
			}
			
			else if(layer is IActivation<T>)
			{
				layer.SizeOut = layers[layers.Count-1].SizeOut;
				layers.Add(layer);
			}
			
			else
			{
				int[] param = layers[layers.Count-1].SizeOut;
				layer.SetParam(param[0], layer.OutDim, param[2], param[3]);
				layers.Add(layer);
			}
		}
		
		
		public Tensor4<T> Forward(Tensor4<T> input)
		{
			Tensor4<T> output = layers[0].Output(input);
			
			for (int i = 1; i < layers.Count; i++) {
				output = layers[i].Output(output);
			}
			
			return output;
		}
		
		
		public void Train(Tensor4<T> input, Tensor4<T> output)
		{
			Forward(input);
			
			layers[layers.Count-1].Delt(output);
			layers[layers.Count-1].Train();
			
			for(int i = layers.Count-2; i>-1; i--)
			{
				layers[i].DeltH(layers[i+1]);
				layers[i].Train();
			}
		}
		
		
		
	}
	
	/// <summary>
	/// Методы обучения
	/// </summary>
	public enum OptimiserType
	{
		Adam,
		Adadelta,
		Adagrad,
		Windowgrad,
		StohasticGradientDecent,
		GradientDecent,
		LevenbergMarquardt
	}
}
