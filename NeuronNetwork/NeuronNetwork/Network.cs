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
		
		public Network()
		{
		}
		
		
		
	}
}
