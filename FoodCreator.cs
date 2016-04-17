/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 17.04.2016
 * Time: 9:16
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
	/// Description of FoodCreator.
	/// </summary>
	class FoodCreator
	{
		int mapWidth;
		int mapHeight;
		char sym;
		
		Random random = new Random();
		
		public FoodCreator(int mapWidth, int mapHeight, char sym)
		{
			this.mapWidth=mapWidth;
			this.mapHeight=mapHeight;
			this.sym=sym;
		}
		
		public Point CreateFood()
		{
			int x=random.Next(2, mapWidth-2);
			int y=random.Next(2, mapHeight-2);
			return new Point(x,y,sym);
		}
	}
}
