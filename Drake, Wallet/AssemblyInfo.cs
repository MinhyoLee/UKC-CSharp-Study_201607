using System.Reflection;
using System.Runtime.CompilerServices;

//
// ������� ���� �Ϲ� ������ ���� Ư�� ������ ���� ����˴ϴ�. 
// ������� ���õ� ������ �����Ϸ���
// �� Ư�� ���� �����Ͻʽÿ�.
//
[assembly: AssemblyTitle("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

//
// ������� ���� ������ ���� �� ���� ������ �����˴ϴ�.
//
//      �� ����
//      �� ���� 
//      ���� ��ȣ
//      ���� ��ȣ
//
// ��� ���� �����ϰų�
// �Ʒ��� ���� '*'�� ����Ͽ� ���� ��ȣ �� ���� ��ȣ�� �ڵ����� �����ǵ��� �� �� �ֽ��ϴ�.

[assembly: AssemblyVersion("1.0.*")]

//
// ������� �����Ϸ��� ����� Ű�� �����ؾ� �մϴ�. ����� ���� ���� �ڼ��� ������ 
// Microsoft .NET Framework ������ �����Ͻʽÿ�.
//
// �����ϴ� �� ����� Ű�� �����Ϸ��� �Ʒ� Ư���� ����մϴ�. 
//
// ����: 
//   (*) Ű�� �������� ������ ������� ������ �� �����ϴ�.
//   (*) KeyName��
//       ����� ��ǻ���� CSP(��ȣȭ ���� ������)��
//        ��ġ�Ǿ� �ִ� Ű�� �����ϰ� KeyFile�� Ű�� ���Ե� ������
//        �����մϴ�.
//   (*) KeyFile�� KeyName ���� ��� �����ϸ� 
//       ������ ���� ���μ����� �߻��մϴ�.
//       (1) CSP�� KeyName�� ������ �ش� Ű�� ���˴ϴ�.
//       (2) KeyName�� ����, KeyFile�� ������ 
//           KeyFile�� Ű�� CSP�� ��ġ�Ǿ� ���˴ϴ�.
//   (*) sn.exe(������ �̸� ��ƿ��Ƽ)�� ����ϸ� KeyFile�� ���� �� �ֽ��ϴ�.
//        KeyFile�� �����ϴ� ���
//       KeyFile�� ��ġ�� %Project Directory%\obj\<configuration>�� ������Ʈ ��� ���͸� ��ġ�� �������� �ϴ� ��� ��ġ�̾�� �մϴ�.
//       ���� ���, KeyFile�� ������Ʈ ���͸��� �ִ� ���
//       AssemblyKeyFile Ư���� 
//       [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]�� �����մϴ�.
//   (*) ���� ����� ��� �ɼ��Դϴ�.
//       �� �ɼǿ� ���� �ڼ��� ������ Microsoft .NET Framework ������ �����Ͻʽÿ�.
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("")]
[assembly: AssemblyKeyName("")]
