/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 16.04.2016
 * Time: 19:53
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
	/// Description of Figure.
	/// </summary>
	class Figure
	{
		protected List <Point> pList;
		
		public void Drow ()
		{
			foreach (Point p in pList) 
			{
				p.Draw();
			}
				
		}
	}
}
