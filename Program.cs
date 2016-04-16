/*
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
using System.Threading.Tasks;

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
				
			Point p3=new Point(6, 7, '*');			
				p3.Draw();
				
			Point p4=new Point(7, 8, '#');			
				p4.Draw();	
				
			List <int> numList= new List<int>();
			numList.Add(0);
			numList.Add(1);
			numList.Add(2);	
			
			
			int x= numList[0];
			int y= numList[1];
			int z= numList[2];
			
			numList.RemoveAt(0);
			//foreach(int i in numList)
			//{
			//	Console.WriteLine(i);
			//}			
			
			List<Point> pList=new List<Point>();
			pList.Add(p1);
			pList.Add(p2);
			
			List<Point> pList2=new List<Point>();
			pList2.Add(p3);
			pList2.Add(p4);
			Console.ReadLine();						
		}	
	}
}