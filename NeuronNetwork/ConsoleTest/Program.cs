﻿/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 20:45
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace ConsoleTest
{
	class Program
	{
		public static void Main(string[] args)
		{
			SpeedTest.SpeedFloat();
			SpeedTest.SpeedDoubleTest();
			SpeedTest.SpeedInt32Test();
			
			Console.ReadKey(true);
		}
	}
}