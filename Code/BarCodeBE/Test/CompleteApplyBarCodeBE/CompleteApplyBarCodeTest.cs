
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.JSDY.BarCode.TestSuite{

	/// <summary>
	/// CompleteApplyBarCode Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class CompleteApplyBarCodeTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void CompleteApplyBarCodeCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCompleteApplyBarCode
										obj  = UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(CompleteApplyBarCode).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode.EntityList list = UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCompleteApplyBarCode	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode).ToString() + "> failed.");
			}
		*/
		}
	}
}

