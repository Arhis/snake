/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 16.04.2016
 * Time: 17:51
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
	/// Description of VerticalLine.
	/// </summary>
	class VerticalLine : Figure
	{   
		
		
		public VerticalLine(int yTop, int yBottom , int x , char sym)
		{
			pList=new List<Point>();
			for (int y=yTop; y<=yBottom; y++)
			{
				Point p= new Point(x,y,sym);
				pList.Add(p);
			}	
		}	
	
	}
}
