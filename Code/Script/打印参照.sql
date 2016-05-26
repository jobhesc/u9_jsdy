	declare	@SNIndex bigint
	exec	[dbo].[AllocSerials]
			@AllocCount = 10000,
			@StartSN = @SNIndex output
--Valid @SNIndex

DELETE FROM UBF_Print_Templates WHERE TemplateID in ('564f7e70-988e-4c63-acba-af4b607a6f35', '8e3fcd50-e64f-4549-b9ed-0d4c317c0ebe')
INSERT INTO UBF_Print_Templates(ID, CreatedOn, CreatedBy, ModifiedOn, ModifiedBy, Culture, IsDefault, CatalogType, TemplateName, TemplateID) VALUES (@SNIndex + 0, '2016/1/18 18:04:40', 'Administrator', '2016/1/18 18:04:40', 'Administrator', 'zh-CN', 0, 'UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode', '成品条码', '564f7e70-988e-4c63-acba-af4b607a6f35')
INSERT INTO UBF_Print_Templates(ID, CreatedOn, CreatedBy, ModifiedOn, ModifiedBy, Culture, IsDefault, CatalogType, TemplateName, TemplateID) VALUES (@SNIndex + 1, '2016/1/18 17:55:34', 'Administrator', '2016/1/18 17:55:34', 'Administrator', 'zh-CN', 1, 'UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode', '完工申报条码', '8e3fcd50-e64f-4549-b9ed-0d4c317c0ebe')
