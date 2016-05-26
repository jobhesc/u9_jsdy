
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart.dll  .\..\..\..\..\..\U9V50\Portal\\UILib
copy .\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart.pdb  .\..\..\..\..\..\U9V50\Portal\\UILib

echo begin run build UI Script
echo 目录：.\..\..\..\..\U9.VOB.Product.Other\\u_ui\UIScript\

echo .\..\..\..\..\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "packet size=4096;user id=sa;Connection Timeout=150;Max Pool size=1500;data source=localhost;persist security info=True;initial catalog=jsdy;password=ufida123" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\u_ui\UIScript\

echo ui buid end
pause

