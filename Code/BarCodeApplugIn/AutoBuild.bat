
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeAppPlugIn.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\bin\Debug\UFIDA.U9.Cust.JSDY.BarCodeAppPlugIn.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\Document\XZ.sub.xml  C:\yonyou\U9V50\Portal\bin

pause

