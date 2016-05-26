
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\Entity\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeBE.Deploy.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationLib
copy .\Entity\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeBE.Deploy.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationLib

copy .\Entity\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeBE.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeBE.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeBE.Deploy.dll  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeBE.Deploy.pdb  .\..\..\..\..\..\U9V50\Portal\\ApplicationServer\Libs



echo begin run build component Script
echo DIR1: .\..\..\..\..\U9.VOB.Product.Other\\Unconfiged\MetadataScript\
echo DIR2: .\..\..\..\..\U9.VOB.Product.Other\\Unconfiged\DBScript\
echo .\..\..\..\..\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "packet size=4096;user id=sa;Connection Timeout=150;Max Pool size=1500;data source=localhost;persist security info=True;initial catalog=jsdy;password=ufida123" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\Unconfiged\MetadataScript\ ..\..\U9.VOB.Product.Other\Unconfiged\DBScript\

echo componet  buid end
pause

