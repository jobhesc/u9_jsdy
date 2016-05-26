
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.JSDY.BarCode.TestSuite{

	/// <summary>
	/// CheckBarCode Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class CheckBarCodeTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void CheckBarCodeCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCheckBarCode
										obj  = UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(CheckBarCode).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode.EntityList list = UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCheckBarCode	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode).ToString() + "> failed.");
			}
		*/
		}
	}
}

