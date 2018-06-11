/*
 * Created by SharpDevelop.
 * User: syj
 * Date: 2018/6/9
 * Time: 10:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Project01
{
	class Program
	{
		
			
		public static void Main(string[] args)
		{
			
		OrderLib LibAD = new OrderLib();
//		OrderLib LibB = new OrderLib();
//		OrderLib LibC = new OrderLib();
//		OrderLib LibD = new OrderLib();
		
//		string[] UserOpration = new string[]
//		{
//			"abcdefghijklmnopqrst1234567890",
////			"U001 2016-06-02 22:00~22:00 A",
//			"U002 2017-08-01 19:00~22:00 A",
//			"U003 2017-08-22 13:00~17:00 B",
//			"U004 2017-08-03 15:00~16:00 C",
//			"U005 2017-08-05 09:00~11:00 D"
//		};
	
	//例二
		string[] UserOpration = new string[]
		{
			"U002 2017-08-01 19:00~22:00 A",
			"U003 2016-06-02 18:00~20:00 A",
			"U002 2017-08-01 19:00~22:00 A C",
			"U002 2017-08-01 19:00~22:00 A C",
			"U003 2017-08-01 18:00~20:00 C",
			"U003 2017-08-02 13:00~17:00 D"
		};

		
		int i=0;
		while(i<UserOpration.Length){
			string newOrder= UserOpration[i];
			// 判断字符串是否符合要求
			if (!InitalValidate(newOrder))
				Console.WriteLine("> Error: the booking is invalid!");
			else{
				string[] str = newOrder.Split(' ');
				
				//反向单
				if(str.Length == 5 && str[4] == "C"){
					if(JudgeCollide(newOrder,LibAD, false))
					 {
					   	Console.WriteLine("> the booking has been contained in Library");
					 }
					 else{
						CancelOrder(newOrder, LibAD);
						Console.WriteLine("> Success: the booking is accepted!");
					 }
				}
				//正向单
				else{
					if(JudgeCollide(newOrder, LibAD, true))
					{
						Console.WriteLine("> the booking has been contained in Library");
					}
					else{
						AddNormalOrder(newOrder,LibAD);
						Console.WriteLine("> Success: the booking is accepted!");
					}
				}
					
			}
				
		
			i++;
		}
		#region 汇总部分
		var result_Ai = OrderLib.printA_in(LibAD);
		var result_Ao = OrderLib.printA_ex(LibAD);
		var result_Bi = OrderLib.printB_in(LibAD);
		var result_Bo = OrderLib.printB_ex(LibAD);
		var result_Ci = OrderLib.printC_in(LibAD);
		var result_Co = OrderLib.printC_ex(LibAD);
		var result_Di = OrderLib.printD_in(LibAD);
		var result_Do = OrderLib.printD_ex(LibAD);
		
		
		int k=0;
		
		#endregion
		
		
		
		
			
		#region
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		#endregion
		}
		
		/// <summary>
		/// 初始验证字符串是否符合格式
		/// </summary>
		/// <param name="newOrder"></param>
		/// <returns></returns>
		public static bool InitalValidate(string newOrder)
		{
			if(newOrder[0] == 'U')
			{
				return true;
			}
			
			return false;
		}
		public static bool JudgeCancel(string newrder)
		{
			
			return false;
		}
		public static bool JudgeCorOrder(string newOrder,OrderLib LibAD)
		{
			
			return false;
		}
		
		/// <summary>
		/// 取消订单
		/// </summary>
		/// <param name="newOrder"></param>
		/// <param name="LibAD"></param>
		public static void CancelOrder(string newOrder, OrderLib LibAD)
		{
			LibAD.NormalOrder.Remove(newOrder);
			LibAD.BrakOrder.Add(newOrder);
		}
		
		/// <summary>
		/// 判断订单是否冲突
		/// </summary>
		/// <param name="newOrder"></param>
		/// <param name="LibAD"></param>
		/// <returns></returns>
		public static bool JudgeCollide(string newOrder, OrderLib LibAD, bool AorC)
		{
			if(AorC){
				return LibAD.NormalOrder.Contains(newOrder);
			}
			return LibAD.BrakOrder.Contains(newOrder);
			 
			
		}
		public static void AddNormalOrder(string newOrder, OrderLib LibAD)
		{
			LibAD.NormalOrder.Add(newOrder);
		}
		
	}
}