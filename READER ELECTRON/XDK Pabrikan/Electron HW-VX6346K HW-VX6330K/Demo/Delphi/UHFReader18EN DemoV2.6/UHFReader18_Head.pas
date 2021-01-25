unit UHFReader18_Head;

interface

Const
    COM1 = 1;
    COM2 = 2;
    COM3 = 3;
    COM4 = 4;
    COM5 = 5;
    COM6 = 6;
    COM7 = 7;
    COM8 = 8;
    COM9 = 9;
    COM10 = 10;


    OK			    	= $00;

    NoElectronicTag     = $0e;
    OperationError      = $0f;



    OtherError             = $00;//��������
    MemoryOutPcNotSupport  = $03;//�洢�����޻򲻱�֧�ֵ�PCֵ
    MemoryLocked           = $04;//�洢������
    NoPower                = $0b;//��Դ����
    NotSpecialError        = $0f;//���ض�����


    CmdNotIdentify                = $02;
    OperationNotSupport_          = $03;
    UnknownError                  = $0f;

  	AbnormalCommunication  = $02;

    CommunicationErr = $30;
    RetCRCErr        = $31;
    RetDataErr       = $32;    //���ݳ����д���
    CommunicationBusy= $33;
    ExecuteCmdBusy   = $34;
    ComPortOpened    = $35;
    ComPortClose     = $36;
    InvalidHandle    = $37;
    InvalidPort      = $38;
    RecmdErr         = $EE;    //����ָ�����
    InventoryReturnEarly_G2   = $01;//ѯ��ʱ�����ǰ����
  	InventoryTimeOut_G2       = $02;// ָ����ѯ��ʱ�����
  	InventoryMoreData_G2      = $03; //������Ϣ֮�󣬻�����Ϣ
    ReadermoduleMCUFull_G2    = $04;// ��дģ��洢�ռ�����
  	AccessPasswordError          = $05;//�����������
    DestroyPasswordError=$09; // �����������
    DestroyPasswordCannotZero=$0a; //�������벻��Ϊȫ0
    TagNotSupportCMD=$0b;// ���ӱ�ǩ��֧�ָ�����
    AccessPasswordCannotZero=$0c;// �Ը�����������벻��Ϊȫ0
    TagProtectedCannotSetAgain=$0d;//���ӱ�ǩ�Ѿ��������˶������������ٴ�����
    TagNoProtectedDonotNeedUnlock=$0e;//  ���ӱ�ǩû�б����ö�����������Ҫ����
    ByteLockedWriteFail=$10;//  ���ֽڿռ䱻������д��ʧ��
    CannotLock=$11;// ��������
    LockedCannotLockAgain=$12;// �Ѿ������������ٴ�����
    ParameterSaveFailCanUseBeforeNoPower=$13;// ��������ʧ��,�����õ�ֵ�ڶ�дģ��ϵ�ǰ��Ч
    CannotAdjust=$14;//�޷�����
    InventoryReturnEarly_6B=$15;// ѯ��ʱ�����ǰ����
    InventoryTimeOut_6B=$16;//ָ����ѯ��ʱ�����
    InventoryMoreData_6B=$17;// ������Ϣ֮�󣬻�����Ϣ
    ReadermoduleMCUFull_6B=$18;// ��дģ��洢�ռ�����
    NotSupportCMDOrAccessPasswordCannotZero=$19;  //���Ӳ�֧�ָ�������߷������벻��Ϊ0
    CMDExecuteErr=$F9;// ����ִ�г���
    GetTagPoorCommunicationCannotOperation=$FA; //�е��ӱ�ǩ����ͨ�Ų������޷�����
    NoTagOperation=$FB; //�޵��ӱ�ǩ�ɲ���
    TagReturnErrorCode=$FC;// ���ӱ�ǩ���ش������
    CMDLengthWrong=$FD;// ����ȴ���
    IllegalCMD=$FE;//���Ϸ�������
    ParameterError=$FF;// ��������

    Function UHFReader18_GetErrorCodeDesc(errorCode : Byte) : String;
    Function UHFReader18_GetReturnCodeDesc(retCode : Byte) : String;
    Function GeteCodeDesc(retCode : string) : String;

implementation

Function GeteCodeDesc(retCode : string) : String;
begin
    result := '';
    if(retCode='C')then
    begin
       result := 'Command Error';
    end
    else if(retCode='R')then
    begin
      Result:='Device refused to do the order';
    end
    else if(retCode='D')then
    begin
      Result:='can not connect with device';
    end
    else if(retCode='F') then
    begin
      Result:='Command execution failed';
    end;
end;
Function UHFReader18_GetErrorCodeDesc(errorCode : Byte) : String;
begin
   result := '';
    case errorCode of
        OtherError            : result := 'Other error';
        MemoryOutPcNotSupport : result := 'Memory out or pc not support';
        MemoryLocked          : result := 'Memory Locked and unwritable';
        NoPower               : result := 'No Power,memory write operation cannot be executed';
        NotSpecialError       : result := 'Not Special Error,tag not support special errorcode';

    end;
end;

Function UHFReader18_GetReturnCodeDesc(retCode : Byte) : String;
begin
    result := '';
    case retCode of
        InventoryReturnEarly_G2               : result := 'Return before Inventory finished';
        InventoryTimeOut_G2                   : result := 'the Inventory-scan-time overflow';
        InventoryMoreData_G2                  : result := 'More Data';
        ReadermoduleMCUFull_G2                : result := 'Reader module MCU is Full';
        AccessPasswordError                   : result := 'Access Password Error';
        DestroyPasswordError                  : result := 'Destroy Password Error';
        DestroyPasswordCannotZero             : result := 'Destroy Password Error Cannot be Zero';
        TagNotSupportCMD                      : result := 'Tag Not Support the command';
        AccessPasswordCannotZero              : result := 'Use the commmand,Access Password Cannot be Zero';
        TagProtectedCannotSetAgain            : result := 'Tag is protected,cannot set it again';
        TagNoProtectedDonotNeedUnlock         : result := 'Tag is unprotected,no need to reset it';
        ByteLockedWriteFail                   : result := 'There is some locked bytes,write fail';
        CannotLock                            : result := 'can not lock it';
        LockedCannotLockAgain                 : result := 'is locked,cannot lock it again';
        ParameterSaveFailCanUseBeforeNoPower  : result := 'Parameter Save Fail,Can Use Before Power';
        CannotAdjust                          : result := 'Cannot adjust';
        InventoryReturnEarly_6B               : result := 'Return before Inventory finished';
        InventoryTimeOut_6B                   : result := 'Inventory-Scan-Time overflow';
        InventoryMoreData_6B                  : result := 'More Data';
        ReadermoduleMCUFull_6B                : result := 'Reader module MCU is full';
        NotSupportCMDOrAccessPasswordCannotZero : result := 'Not Support Command Or AccessPassword Cannot be Zero';
        GetTagPoorCommunicationCannotOperation: result := 'Get Tag,Poor Communication,Inoperable';
        NoTagOperation                        : result := 'No Tag Operable';
        TagReturnErrorCode                    : result := 'Tag Return ErrorCode';
        CMDLengthWrong                        : result := 'Command length wrong';
        IllegalCMD                            : result := 'Illegal command';
        ParameterError                        : result := 'Parameter Error';


        RecmdErr            : result := 'Return command error';
        CommunicationErr    : result := 'Communication error';
        RetCRCErr           : result := 'CRC checksummat error';
        RetDataErr          : result := 'Return data length error';
        CommunicationBusy   : result := 'Communication busy';
        ExecuteCmdBusy      : result := 'Busy,command is being executed';
        ComPortOpened       : result := 'ComPort Opened';
        ComPortClose        : result := 'ComPort Closed';
        InvalidHandle       : result := 'Invalid Handle';
        InvalidPort         : result := 'Invalid Port';
    end;
end;

end.
