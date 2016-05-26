

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
	public class GenProductBarCodesByShipTest
	{
		private Proxy.GenProductBarCodesByShipProxy obj = new Proxy.GenProductBarCodesByShipProxy();

		public GenProductBarCodesByShipTest()
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