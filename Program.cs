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
			Point p1=new Point();
			p1.x=1;
			p1.y=3;
			p1.sym='*';
			p1.Draw();
			
			Point p2=new Point();
			p2.x=4;
			p2.y=5;
			p2.sym='#';
			p2.Draw();
			
			Console.ReadLine();
		}
	}
}