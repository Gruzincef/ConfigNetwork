using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices ;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows;
using  System.Diagnostics;


namespace ConfigNetwork
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			LoadConfigARM();
			LoadConfig();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}


void Button1Click(object sender, EventArgs e){
	DialogResult dialogresult=MessageBox.Show("Изменить настройки сетевого интерфейса?", "Изменить настройки сетевого интерфейса?", MessageBoxButtons.YesNo);
	if(dialogresult==DialogResult.Yes){
		NewIp();
		SaveConfig();
		SetIP(NewIP.Text, Mask.Text, Gateway.Text, DNS1.Text+","+DNS2.Text);
	}
}
private NtwrkIntrfc[] ListNetworkInterface(){
	NetworkInterface[] nics=NetworkInterface.GetAllNetworkInterfaces();
	NtwrkIntrfc[] device = new NtwrkIntrfc[nics.Length];
	for(int x=0;x<=nics.Length-1;x++){
		device[x]=new NtwrkIntrfc();
		if(nics[x].GetIPProperties().UnicastAddresses.Count!=0){
			device[x]._IP=nics[x].GetIPProperties().UnicastAddresses[0].IPv4Mask.ToString();
		}
		device[x]._ID=nics[x].Id;
		device[x]._Description=nics[x].Description;
		device[x]._ID=nics[x].Id;
		device[x]._Name=nics[x].Name;
		device[x]._MAC=nics[x].GetPhysicalAddress().ToString();
		if(nics[x].GetIPProperties().DhcpServerAddresses.Count!=0)
			for(int y=0;y<=nics[x].GetIPProperties().DhcpServerAddresses.Count-1;y++)
				device[x]._DHCP.Add(nics[x].GetIPProperties().DhcpServerAddresses[y].ToString());
				
		if(nics[x].GetIPProperties().DnsAddresses.Count!=0)
			for(int y=0;y<=nics[x].GetIPProperties().DnsAddresses.Count-1;y++)
				device[x]._DNS.Add(nics[x].GetIPProperties().DnsAddresses[y].ToString());
		
		if(nics[x].GetIPProperties().GatewayAddresses.Count!=0)
			for(int y=0;y<=nics[x].GetIPProperties().GatewayAddresses.Count-1;y++)
				device[x]._Gateway.Add(nics[x].GetIPProperties().GatewayAddresses[y].ToString());
	
		}
	return device;
}

void Button3Click(object sender, EventArgs e){
SaveConfig();		
NewIp();
}

private void NewIp(){
 NewIP.Text=_NewIP=AddresEthernet.Text.Substring(0,AddresEthernet.Text.Length-1)+_IP.Substring(_IP.LastIndexOf(".")+1,_IP.Length-_IP.LastIndexOf(".")-1);
}
private void LoadConfigARM(){
	IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
	NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
	if (nics == null || nics.Length < 1) return;
    foreach (NetworkInterface adapter in nics) 
    	if((adapter.NetworkInterfaceType==NetworkInterfaceType.Ethernet)&&(adapter.OperationalStatus== OperationalStatus.Up)){
        IPInterfaceProperties properties = adapter.GetIPProperties();
        
     //   _CurrentMask=adapter.GetPhysicalAddress;
         if(properties.DnsAddresses[0]!=null)
        _CurrentDNS1=properties.DnsAddresses[0].ToString();
        if(properties.DnsAddresses[1]!=null)
        _CurrentDNS2=properties.DnsAddresses[1].ToString();
        if(properties.GatewayAddresses.Count>0)
       		_CurrentGateway=properties.GatewayAddresses[0].Address.ToString();
        
		UnicastIPAddressInformationCollection  uniCast   = properties.UnicastAddresses;
		if (uniCast  != null){
			_IP=uniCast[uniCast.Count-1].Address.ToString();
			_CurrentMask=uniCast[uniCast.Count-1].IPv4Mask.ToString();
			_CurrentNumberARM=_IP.Substring(_IP.LastIndexOf(".")+1,_IP.Length-_IP.LastIndexOf(".")-1);
			_CurrentAddresEthernet=_IP.Substring(0,_IP.LastIndexOf("."))+".0";
		}

}

}
private string _NewIP;
private string _IP;
private string _CurrentNumberARM;
private string _CurrentGateway;
private string _CurrentDNS1;
private string _CurrentDNS2;
private string _CurrentAddresEthernet;
private string _CurrentMask;

private void LoadConfig(){
		if(System.IO.File.Exists("cnfg.txt")){
		string[] s= System.IO.File.ReadAllLines("cnfg.txt");
		if(s.Length>0) AddresEthernet.Text=s[0];
		if(s.Length>1) NumberARM.Text=s[1];
		if(s.Length>2) Gateway.Text=s[2];
		if(s.Length>3) DNS1.Text=s[3];
		if(s.Length>4) DNS2.Text=s[4];
		if(s.Length>5) Mask.Text=s[5];
		}else{
		AddresEthernet.Text=_CurrentAddresEthernet;
		NumberARM.Text=_CurrentNumberARM;
		Gateway.Text=_CurrentGateway;
		Mask.Text=_CurrentMask;
		DNS1.Text=_CurrentDNS1;
		DNS2.Text=_CurrentDNS2;
		Mask.Text=_CurrentMask;
	}
	OldIP.Text=_IP;
	NewIp();
}
		
private void SaveConfig(){
	if(System.IO.File.Exists("cnfg.txt"))
		System.IO.File.Delete("cnfg.txt");
		string[] s= new String[6];
		s[0]=AddresEthernet.Text;
		s[1]=NumberARM.Text;
		s[2]=Gateway.Text;
		s[3]=DNS1.Text;
		s[4]=DNS2.Text;
		s[5]=Mask.Text;
		System.IO.File.WriteAllLines("cnfg.txt",s);

}
void Button2Click(object sender, EventArgs e){
	DialogResult dialogresult=MessageBox.Show("Удалить настройки?", "Удалить настройки?", MessageBoxButtons.YesNo);
		if(dialogresult==DialogResult.Yes){
		if(System.IO.File.Exists("cnfg.txt"))
			System.IO.File.Delete("cnfg.txt");
		LoadConfigARM();
		LoadConfig();	
	}
}
private void SetIP(string ipAddress, string subnetMask, string gateway, string DNS)  {
			using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration")){
            using (var networkConfigs = networkConfigMng.GetInstances()){
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"])){
                    using (var newIP = managementObject.GetMethodParameters("EnableStatic")) {
                        // Set new IP address and subnet if needed
                        if ((!String.IsNullOrEmpty(ipAddress)) || (!String.IsNullOrEmpty(subnetMask))) {
                            if (!String.IsNullOrEmpty(ipAddress)) {
                                newIP["IPAddress"] = new[] { ipAddress };
                            }
                            if (!String.IsNullOrEmpty(subnetMask)){
                                newIP["SubnetMask"] = new[] { subnetMask };
                            }
                            managementObject.InvokeMethod("EnableStatic", newIP, null);
                        }
                        // Set mew gateway if needed
                        if (!String.IsNullOrEmpty(gateway)) {
                            using (var newGateway = managementObject.GetMethodParameters("SetGateways")){
                                newGateway["DefaultIPGateway"] = new[] { gateway };
                                newGateway["GatewayCostMetric"] = new[] { 1 };
                                managementObject.InvokeMethod("SetGateways", newGateway, null);
                            }
                        }
                       //newIP["DNSServerSearchOrder"] = DNS.Split(',');
            			//ManagementBaseObject setDNS = newIP.iInvokeMethod("SetDNSServerSearchOrder", newIP, null);
   					}
					ManagementBaseObject newDNS =managementObject.GetMethodParameters("SetDNSServerSearchOrder");
           			newDNS["DNSServerSearchOrder"] = DNS.Split(',');
            		ManagementBaseObject setDNS =managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
          		}
			}
		}
}
		
		
void OpisToolStripMenuItemClick(object sender, EventArgs e){
	System.Diagnostics.Process.Start(@"https://github.com/Gruzincef/ConfigNetwork");	
}
}
public class NtwrkIntrfc
	{
		public string _ID;
		public string _Name;
		public string _Description;
		public string _IP;
		public List<string> _Gateway=new List<string>();
		public string  _Mask;
		public string  _MAC;
		public List<string> _DHCP=new List<string>();
		public List<string> _DNS = new List<string>();
		public Object _Obj;
		//public List<string> 			
	}
	
//*******************************************************
public class NetworkDrive
{
private enum ResourceScope
{
RESOURCE_CONNECTED = 1,
RESOURCE_GLOBALNET,
RESOURCE_REMEMBERED,
RESOURCE_RECENT,
RESOURCE_CONTEXT
}
private enum ResourceType
{
RESOURCETYPE_ANY,
RESOURCETYPE_DISK,
RESOURCETYPE_PRINT,
RESOURCETYPE_RESERVED
}
private enum ResourceUsage
{
RESOURCEUSAGE_CONNECTABLE = 0x00000001,
RESOURCEUSAGE_CONTAINER = 0x00000002,
RESOURCEUSAGE_NOLOCALDEVICE = 0x00000004,
RESOURCEUSAGE_SIBLING = 0x00000008,
RESOURCEUSAGE_ATTACHED = 0x00000010
}
private enum ResourceDisplayType
{
RESOURCEDISPLAYTYPE_GENERIC,
RESOURCEDISPLAYTYPE_DOMAIN,
RESOURCEDISPLAYTYPE_SERVER,
RESOURCEDISPLAYTYPE_SHARE,
RESOURCEDISPLAYTYPE_FILE,
RESOURCEDISPLAYTYPE_GROUP,
RESOURCEDISPLAYTYPE_NETWORK,
RESOURCEDISPLAYTYPE_ROOT,
RESOURCEDISPLAYTYPE_SHAREADMIN,
RESOURCEDISPLAYTYPE_DIRECTORY,
RESOURCEDISPLAYTYPE_TREE,
RESOURCEDISPLAYTYPE_NDSCONTAINER
}
[StructLayout(LayoutKind.Sequential)]
private struct NETRESOURCE
{
public ResourceScope oResourceScope;
public ResourceType oResourceType;
public ResourceDisplayType oDisplayType;
public ResourceUsage oResourceUsage;
public string sLocalName;
public string sRemoteName;
public string sComments;
public string sProvider;
}

[DllImport("mpr.dll")]
private static extern int WNetAddConnection2
(ref NETRESOURCE oNetworkResource, string sPassword,
string sUserName, int iFlags);

[DllImport("mpr.dll")]
private static extern int WNetCancelConnection2
(string sLocalName, uint iFlags, int iForce);

public static void MapNetworkDrive(string sDriveLetter, string sNetworkPath)
{
//Checks if the last character is \ as this causes error on mapping a drive.
if (sNetworkPath.Substring(sNetworkPath.Length - 1, 1) == @"\")
{
sNetworkPath = sNetworkPath.Substring(0, sNetworkPath.Length - 1);
}
NETRESOURCE oNetworkResource = new NETRESOURCE()
{
oResourceType = ResourceType.RESOURCETYPE_DISK,
sLocalName = sDriveLetter + ":",
sRemoteName = sNetworkPath
};

//If Drive is already mapped disconnect the current
//mapping before adding the new mapping
if (IsDriveMapped(sDriveLetter))
{
DisconnectNetworkDrive(sDriveLetter, true);
}
WNetAddConnection2(ref oNetworkResource, null, null, 0);
}
public static int DisconnectNetworkDrive(string sDriveLetter, bool bForceDisconnect)
{
if (bForceDisconnect)
{
return WNetCancelConnection2(sDriveLetter + ":", 0, 1);
}
else
{
return WNetCancelConnection2(sDriveLetter + ":", 0, 0);
}
}
public static bool IsDriveMapped(string sDriveLetter)
{
string[] DriveList = Environment.GetLogicalDrives();
for (int i = 0; i < DriveList.Length; i++)
{
if (sDriveLetter + ":\\" == DriveList[i].ToString())
{
return true;
}
}
return false;
}
}
/*********************************************/
	
	
	
}
