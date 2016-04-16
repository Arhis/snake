/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 16.04.2016
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;	
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	/// <summary>
	/// Description of Snake.
	/// </summary>
	class Snake :Figure
	{
		public Snake(Point tail, int lenght, Direction direction) 
		{
			pList = new List<Point>();
			for (int i=0; i<lenght; i++)
			{
				Point p=new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}
	}
}
