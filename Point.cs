/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 15.04.2016
 * Time: 10:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace snake
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	class Point
	{	
		public int x;
		public int y;
		public char sym;
		
		public Point (int _x, int _y, char _sym)
		{
			y=_y;
			x=_x;
			sym=_sym;
		}
		
		public void Draw () {
			Console.SetCursorPosition(x,y);
			Console.Write(sym);
		}
	}
}
