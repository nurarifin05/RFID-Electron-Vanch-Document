Attribute VB_Name = "Module1"
Option Explicit

Public Declare Function OpenComPort Lib "UHFReader18.dll" (ByVal Port As Long, ByRef ComAdr As Byte, ByVal Baud As Byte, ByRef FrmHandle As Long) As Long
                                                                
Public Declare Function CloseComPort Lib "UHFReader18.dll" () As Long

Public Declare Function OpenNetPort Lib "UHFReader18.dll" (ByVal Port As Long, ByVal IPaddr As String, ByRef ComAdr As Byte, ByRef FrmHandle As Long) As Long

Public Declare Function CloseNetPort Lib "UHFReader18.dll" (ByVal FrmHandle As Long) As Long

Public Declare Function GetReaderInformation Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef VersionInfo As Byte, ByRef ReaderType As Byte, ByRef TrType As Byte, ByRef dmaxfre As Byte, ByRef dminfre As Byte, ByRef PowerDbm As Byte, ByRef ScanTime As Byte, ByVal FrmHandle As Long) As Long
                                  
Public Declare Function WriteComAdr Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef ComAdrData As Byte, ByVal FrmHandle As Long) As Long
                                
Public Declare Function SetPowerDbm Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByVal PowerDbm As Byte, ByVal FrmHandle As Long) As Long

Public Declare Function Writedfre Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef dmaxfre As Byte, ByRef dminfre As Byte, ByVal FrmHandle As Long) As Long

Public Declare Function Writebaud Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef Baud As Byte, ByVal FrmHandle As Long) As Long

Public Declare Function WriteScanTime Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef ScanTime As Byte, ByVal FrmHandle As Long) As Long

Public Declare Function Inventory_G2 Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByVal AdrTID As Byte, ByVal LenTID As Byte, ByVal TIDFlag As Byte, ByRef EPClenandEPC As Byte, ByRef Totallen As Long, ByRef CardNum As Long, ByVal FrmHandle As Long) As Long

Public Declare Function SetWorkMode Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef Parameter As Byte, ByVal FrmHandle As Long) As Long
   
Public Declare Function GetWorkModeParameter Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef Parameter As Byte, ByVal FrmHandle As Long) As Long
   
Public Declare Function ReadCard_G2 Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef EPC As Byte, ByVal Mem As Byte, ByVal WordPtr As Byte, ByVal Num As Byte, ByRef Password As Byte, ByVal maskadr As Byte, ByVal maskLen As Byte, ByVal maskFlag As Byte, ByRef Data As Byte, ByVal EPClength As Byte, ByRef errorcode As Long, ByVal FrmHandle As Long) As Long

Public Declare Function WriteCard_G2 Lib "UHFReader18.dll" (ByRef ComAdr As Byte, ByRef EPC As Byte, ByVal Mem As Byte, ByVal WordPtr As Byte, ByVal Writedatalen As Byte, ByRef WrittenData As Byte, ByRef Password As Byte, ByVal maskadr As Byte, ByVal maskLen As Byte, ByVal maskFlag As Byte, ByRef WrittenDataNum As Long, ByVal EPClength As Byte, ByRef errorcode As Long, ByVal FrmHandle As Long) As Long

Public Declare Function ReadActiveModeData Lib "UHFReader18.dll" (ByRef ScanModeData As Byte, ByRef ValidDatalength As Long, ByVal frmComPortindex As Long) As Long

