﻿

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using NUnit.Framework;
	
	/// <summary>
	/// Business operation test
	/// </summary> 
	[TestFixture]		
	public class QueryWhQohTest
	{
		private Proxy.QueryWhQohProxy obj = new Proxy.QueryWhQohProxy();

		public QueryWhQohTest()
		{
		}
		#region AutoTestCode ...
		[Test]
		public void TestDo()
		{
			obj.Do() ;  
		
		}
		#endregion 				
	}
	
}