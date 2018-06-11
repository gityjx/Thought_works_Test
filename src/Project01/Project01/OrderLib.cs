/*
 * Created by SharpDevelop.
 * User: syj
 * Date: 2018/6/9
 * Time: 12:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Project01
{
	/// <summary>
	/// Description of OrderLib.
	/// </summary>
	public class OrderLib
	{
		public List<string> NormalOrder = new List<string>();
			
		public List<string> BrakOrder = new List<string>();

		public static List<string> cateSplit(OrderLib LibAD, char LibStyle, bool AorC)
		{
			List<string> result = new List<string>();
			if(AorC)
			{
				int i=0;
				while(i< LibAD.NormalOrder.Count)
				{
					if(LibAD.NormalOrder[i][3] == LibStyle)
					{
						result.Add(LibAD.NormalOrder[i]);
					}
				}
				
			}else{
				int j=0;
				while(j < LibAD.BrakOrder.Count)
				{
					if(LibAD.BrakOrder[j][3] == LibStyle)
					{
						result.Add(LibAD.BrakOrder[j]);
					}
				}
			}
			
			return result;

		}
		#region
		public static  Dictionary<string, int>  printA_in(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.NormalOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.NormalOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "A")
				OrderDict.Add(LibAD.NormalOrder[i], getCost(LibAD.NormalOrder[i], true));

			}

			return OrderDict;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="LibAD"></param>
		/// <returns></returns>
		public static  Dictionary<string, int>  printA_ex(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.BrakOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.BrakOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "A")
				OrderDict.Add(LibAD.BrakOrder[i], getCost(LibAD.BrakOrder[i], false));

			}

			return OrderDict;
		}
		
		#endregion
		#region
		public static  Dictionary<string, int>  printB_in(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.NormalOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.NormalOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "B")
				OrderDict.Add(LibAD.NormalOrder[i], getCost(LibAD.NormalOrder[i], true));

			}

			return OrderDict;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="LibAD"></param>
		/// <returns></returns>
		public static  Dictionary<string, int>  printB_ex(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.BrakOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.BrakOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "B")
				OrderDict.Add(LibAD.BrakOrder[i], getCost(LibAD.BrakOrder[i], false));

			}

			return OrderDict;
		}
		#endregion
		
		#region
		public static  Dictionary<string, int>  printC_in(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.NormalOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.NormalOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "C")
				OrderDict.Add(LibAD.NormalOrder[i], getCost(LibAD.NormalOrder[i], true));

			}

			return OrderDict;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="LibAD"></param>
		/// <returns></returns>
		public static  Dictionary<string, int>  printC_ex(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.BrakOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.BrakOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "C")
				OrderDict.Add(LibAD.BrakOrder[i], getCost(LibAD.BrakOrder[i], true));

			}

			return OrderDict;
		}
		#endregion
		
		#region
		public static  Dictionary<string, int>  printD_in(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.NormalOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.NormalOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "D")
				OrderDict.Add(LibAD.NormalOrder[i], getCost(LibAD.NormalOrder[i], true));

			}

			return OrderDict;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="LibAD"></param>
		/// <returns></returns>
		public static  Dictionary<string, int>  printD_ex(OrderLib LibAD)
		{
			Dictionary<string, int> OrderDict = new Dictionary<string, int>();
			for(int i =0 ;i<LibAD.BrakOrder.Count;i++)
			{
//				string[] arr = LibAD.NormalOrder[i].Split[' '];
				string tmp = LibAD.BrakOrder[i];
				string[] arr = tmp.Split(' ');
				
				if(arr[3] == "D")
				OrderDict.Add(LibAD.BrakOrder[i], getCost(LibAD.BrakOrder[i], true));

			}

			return OrderDict;
		}
		#endregion
		/// <summary>
		/// 获得订单价格或者违约金
		/// </summary>
		/// <param name="newOrder"></param>
		/// <returns></returns>
		public static int getCost(string newOrder,bool OrderStyle)
		{
			
			string[] strArr = newOrder.Split(' ');
			string[] timeArr =strArr[2].Split('~');
			int starPoint = DateTime.Parse(timeArr[0]).Hour;
			int endPoint = DateTime.Parse(timeArr[1]).Hour;
			int sum = 0;
			string week = DateTime.Parse(strArr[1]).DayOfWeek.ToString();

			for(int i=starPoint;i<endPoint;i++)
			{
				
				if(i>=9 && i<12)
				{
					if(week =="Saturday" || week =="Sunday")
						sum += 40;
					else
						sum += 30;
				}
					
				else if(i>=12 && i<18)
				{
					sum += 50;
				}
				else if(i>=18 && i<20)
				{
					if(week =="Saturday" || week =="Sunday")
						sum += 60;
					else
						sum += 80;
				}
				else if(i>=20 && i<22)
					sum += 60;
			}
			if(OrderStyle == false)
			{
				if(week =="Saturday" || week =="Sunday")
				{
					return  int.Parse((sum*0.25).ToString());
				}else{
					return int.Parse((sum*0.5).ToString());
				}
			}

			return sum;
			

		}
		
		
	}
}
