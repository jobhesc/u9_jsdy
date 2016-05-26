-- 预置 生产管理 系统参数表
-- 操作时间
DECLARE @CurrentDate DATETIME
SET @CurrentDate = GETDATE()
-- 默认操作人
DECLARE @User NVARCHAR(50)
SET @User = 'admin'
-- 默认分组名称
DECLARE @GroupName NVARCHAR(50)
SET @GroupName = '客开参数配置'
-- 模块
DECLARE @Applicationtemp BIGINT
-- 序号起始
DECLARE @Sort BIGINT
SET @Sort = 950
-- ID 起始
DECLARE	@SNIndex BIGINT
IF OBJECT_ID('InnerAllocSerials') is null
    EXEC [dbo].[AllocSerials] @AllocCount = 100, @StartSN = @SNIndex OUTPUT
ELSE
    EXEC [dbo].[InnerAllocSerials] @AllocCount = 100, @StartSN = @SNIndex OUTPUT
-- 编码
DECLARE @Code NVARCHAR(50)

--客户端自动更新
SET @Code = 'Cust_IsClientAutoUpdate'
--delete Base_Profile_Trl where ID in (select ID from Base_Profile where Code = @Code )
--delete Base_Profile where Code = @Code 
IF  NOT EXISTS (SELECT ID FROM Base_Profile WHERE Code = @Code)
BEGIN
	SET @Sort = @Sort + 1
	SET @Applicationtemp=3000
	SET @SNIndex = @SNIndex + 1
	INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn, ModifiedBy, ProfileValueType, SubTypeName, DefaultValue, Code, [Application], ControlScope, SensitiveType ,ReferenceID, Sort) 
	VALUES (@SNIndex,@CurrentDate,@User,@CurrentDate,@User, 3, '', 'False', @Code, @Applicationtemp, 1, 4, '', @Sort)
	INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description], [Name], ProfileGroup)
	VALUES ('zh-CN', @SNIndex, '客户端自动更新', '客户端自动更新', @GroupName)
END


--出货虚拟仓
SET @Code = 'Cust_ShipVirtualWh'
--delete Base_Profile_Trl where ID in (select ID from Base_Profile where Code = @Code )
--delete Base_Profile where Code = @Code 
IF  NOT EXISTS (SELECT ID FROM Base_Profile WHERE Code = @Code)
BEGIN
	SET @Sort = @Sort + 1
	SET @Applicationtemp=3015
	SET @SNIndex = @SNIndex + 1
	INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn, ModifiedBy, ProfileValueType, SubTypeName, DefaultValue, Code, [Application], ControlScope, SensitiveType ,ReferenceID, Sort) 
	VALUES (@SNIndex,@CurrentDate,@User,@CurrentDate,@User, 7, 'UFIDA.U9.CBO.SCM.Warehouse.Warehouse', '', @Code, @Applicationtemp, 1, 4, 'e7b574ba-23e3-40d6-a291-60328ce65bfe', @Sort)
	INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description], [Name], ProfileGroup)
	VALUES ('zh-CN', @SNIndex, '出货虚拟仓', '出货虚拟仓', @GroupName)
END
