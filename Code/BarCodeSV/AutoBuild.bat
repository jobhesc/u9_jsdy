
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Deploy.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationLib
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Deploy.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Agent.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Agent.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationLib

copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Deploy.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Deploy.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Agent.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.Agent.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeSV.ubfsvc  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs


copy .\BpImplement\UFIDA.U9.Cust.JSDY.BarCode.IGenCheckBarCodes.svc  .\..\..\..\..\..\U9V50\Portal\\Services
copy .\BpImplement\UFIDA.U9.Cust.JSDY.BarCode.IGenProductBarCodesByCompleteApply.svc  .\..\..\..\..\..\U9V50\Portal\\Services
copy .\BpImplement\UFIDA.U9.Cust.JSDY.BarCode.IGenProductBarCodesByRMA.svc  .\..\..\..\..\..\U9V50\Portal\\Services
copy .\BpImplement\UFIDA.U9.Cust.JSDY.BarCode.IGenProductBarCodesByShip.svc  .\..\..\..\..\..\U9V50\Portal\\Services

echo 请手工将该bat文件打开，将下面这段内容与.\..\..\..\..\..\U9V50\Portal\\RestServices\web.config进行合并。
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGenCheckBarCodes" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGenProductBarCodesByCompleteApply" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGenProductBarCodesByRMA" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGenProductBarCodesByShip" /> 
	</service>


pause