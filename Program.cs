﻿/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 15.04.2016
 * Time: 6:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
	class Program
	{
		public static void Main(string[] args)
		{	
			//Задание экранному пространству определенного размера
			Console.SetBufferSize(80,25);
			
			// Отрисовка линий
				HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');				
				HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
				VerticalLine leftLine=new VerticalLine(0, 24, 0, '+');
				VerticalLine rightLine=new VerticalLine(0, 24, 78, '+');
			 	upLine.Drow();
			 	downLine.Drow();
				leftLine.Drow();
				rightLine.Drow();
				
			//Отрисовка точек
			Point p= new Point(4, 5, '*');
			Snake snake=new Snake(p, 4, Direction.RIGHT);
			snake.Drow();
			
			FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
			Point food = foodCreator.CreateFood();
			food.Draw();
			
			while(true)
			{
				if(snake.Eat( food ) )
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}					

				Thread.Sleep( 100 );

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey( key.Key );
				}
			}					
		}
	}
}