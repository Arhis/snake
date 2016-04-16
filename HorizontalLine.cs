/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 16.04.2016
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	/// <summary>
	/// Description of HorizontalLine.
	/// </summary>
	///
	class HorizontalLine
	{
		List<Point> pList;
		
		public HorizontalLine(int xLeft, int xRight, int y, char sym)
		{
			pList = new List<Point>();
			for(int x = xLeft; x<xRight; x++)
			{
				Point p = new Point(x, y, sym);	
				pList.Add(p);
			}
		}
		
		public void Drow ()
		{
			foreach (Point p in pList) 
			{
				p.Draw();
			}
				
		}
	}
}
