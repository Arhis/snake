/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 15.04.2016
 * Time: 6:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace snake
{
	class Program
	{
		public static void Main(string[] args)
		{		
			Point p1=new Point(1, 3, '*');			
				p1.Draw();
			
			Point p2=new Point(4, 5, '#');			
				p2.Draw();
			
			Console.ReadLine();
		}
	}
}