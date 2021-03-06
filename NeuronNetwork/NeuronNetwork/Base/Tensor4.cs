﻿/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 28.02.2018
 * Время: 20:48
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace AI.NeuronNetwork.Base
{
	/// <summary>
	/// Description of Tensor4.
	/// </summary>
	public class Tensor4<T>
	{
		
		public T[,,,] Tensor{get; set;}
		public Int32 W{get; private set;}
		public Int32 H{get; private set;}
		public Int32 D{get; private set;}
		public Int32 BS{get; private set;}
		
		public T this[int w, int h, int d, int bs]
		{
			get
			{
				return Tensor[w,h,d,bs];
			}
			set
			{
				Tensor[w,h,d,bs] = value;
			}
		}
		
		
		
		public Tensor4(int w, int h, int d, int bs)
		{
			W = w;
			H = h;
			D = d;
			BS = bs;
			Tensor = new T[w,h,d,bs];
		}
		
		
		public Tensor4(T[] data)
		{
			W = 1;
			H = 1;
			D = data.Length;
			BS = 1;
			Tensor = new T[1,1,D,1];
			
			for (int i = 0; i < D; i++) {
				Tensor[0,0,i,0] = data[i];
			}
		}
		
		
		public Tensor4(int w, int h, int d, int bs, Random rnd)
		{
			Tensor = new T[w,h,d,bs];
			W = w;
			H = h;
			D = d;
			BS = bs;
			
			try
			{
			float scale = (float)2.0/(w*h*d*bs);
			
			for (int i = 0; i < w; i++) 
				for (int j = 0; j < h; j++)
					for (int k = 0; k < d; k++)
						for (int z = 0; z < bs; z++)
							Tensor[i, j, k, z] = (dynamic)(float)((rnd.NextDouble()-0.5)*scale);
			}
			
			catch
			{
			for (int i = 0; i < w; i++) 
				for (int j = 0; j < h; j++)
					for (int k = 0; k < d; k++)
						for (int z = 0; z < bs; z++)
							Tensor[i, j, k, z] = (dynamic)((rnd.Next(-10, 10)));
			
			}
		}
		
		
		
		#region Операции
		public static Tensor4<T> operator+ (Tensor4<T> A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = (A[i,j,k,z] as dynamic) +(B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		
		public static Tensor4<T> operator- (Tensor4<T> A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = (A[i,j,k,z] as dynamic) - (B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		public static Tensor4<T> operator/ (Tensor4<T> A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = (A[i,j,k,z] as dynamic)/(B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		public static Tensor4<T> operator* (Tensor4<T> A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = (A[i,j,k,z] as dynamic)*(B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		
		public static Tensor4<T> operator+ (dynamic A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = A + (B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		
		
		public static Tensor4<T> operator+(Tensor4<T> B, dynamic A )
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = A + (B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		
		
		public static Tensor4<T> operator- (dynamic A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = A - (B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		
		
		public static Tensor4<T> operator- ( Tensor4<T> B, dynamic A)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = (B[i,j,k,z] as dynamic) - A;
						}
						
			return newTen;
		}
		
		public static Tensor4<T> operator* (dynamic A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = A + (B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		
		
		public static Tensor4<T> operator*(Tensor4<T> B, dynamic A )
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = A * (B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		public static Tensor4<T> operator/ (dynamic A, Tensor4<T> B)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = A / (B[i,j,k,z] as dynamic);
						}
						
			return newTen;
		}
		
		
		
		public static Tensor4<T> operator/ ( Tensor4<T> B, dynamic A)
		{
			Tensor4<T> newTen = new Tensor4<T>(A.W, A.H, A.D, A.BS);
			
			for (int i = 0; i < A.W; i++)
				for (int j = 0; j < A.H; j++)
					for(int k = 0; k<A.D; k++)
						for (int z = 0; z < A.BS; z++)
						{
								newTen[i,j,k,z] = (B[i,j,k,z] as dynamic) / A;
						}
						
			return newTen;
		}
		
		#endregion
		
		
		
		// Сама функция может быть запараллелина, но параллелизация вдоль bs недопустима,
		// т.к. собьются метки классов
		public static Tensor4<T> ConvolutionalLayerForward(Tensor4<T> map, Tensor4<T> feature)
		{
			throw new NotImplementedException();
		}
		
		// Матрицей считается размерности h, d. Вектором d
		// Первый аргумент -- матрица весов, батч во втором
		public static Tensor4<T> MultAsMatrix(Tensor4<T> A, Tensor4<T> B)
		{
			Tensor4<T> result = new Tensor4<T>(A.W, B.H, A.D, B.BS);
			
			for(int i = 0; i < B.BS; i++)
				for (int j = 0; j < B.H; j++)
					for (int k = 0; k < A.D; k++)
						for (int z = 0; z < A.H; z++) 
							result[0, j, k, i] += (A[0, z, k, i]as dynamic) *(B[0, j, z, i] as dynamic);
			
			return result;
		}
		
		// Добавляет едину в конец к размерность d
		// чтобы выполнить поляризацию нейрона
		public static Tensor4<T> DeepAdd1(Tensor4<T> A)
		{
			Tensor4<T> result = new Tensor4<T>(A.W, A.H, A.D+1, A.BS);
			
			for (int i = 0; i < A.W; i++) 
				for (int j = 0; j < A.H; j++)
					for (int k = 0; k < A.D; k++)
						for (int z = 0; z < A.BS; z++)
							result[i, j, k, z] = A[i, j, k, z];
			
				for (int i = 0; i < A.W; i++) 
				for (int j = 0; j < A.H; j++)
						for (int z = 0; z < A.BS; z++)
							result[i, j, A.D, z] = (dynamic)1;
			
				return result;
		}
	}
}
