
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.JSDY.BarCode.TestSuite{

	/// <summary>
	/// ProductBarCode Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class ProductBarCodeTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void ProductBarCodeCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateProductBarCode
										obj  = UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(ProductBarCode).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode.EntityList list = UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveProductBarCode	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode).ToString() + "> failed.");
			}
		*/
		}
	}
}

