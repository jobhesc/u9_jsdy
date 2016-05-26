

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
	public class GenProductBarCodesByCompleteApplyTest
	{
		private Proxy.GenProductBarCodesByCompleteApplyProxy obj = new Proxy.GenProductBarCodesByCompleteApplyProxy();

		public GenProductBarCodesByCompleteApplyTest()
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