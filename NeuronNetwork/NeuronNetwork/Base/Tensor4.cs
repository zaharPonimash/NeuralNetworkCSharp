/*
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
			Tensor = new T[w,h,d,bs];
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
		
		
		
		
		public static Tensor4<T> Convolutional(Tensor4<T> A, Tensor4<T> B)
		{
			throw new NotImplementedException();
		}
		
		
		public static Tensor4<T> MultAsMatrix(Tensor4<T> A, Tensor4<T> B)
		{
			throw new NotImplementedException();
		}
		
		public static Tensor4<T> DeepAdd1(Tensor4<T> A)
		{
			throw new NotImplementedException();
		}
	}
}
