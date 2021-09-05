﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loading_screen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowValue();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowValue();
        }

        private static Guid GUID_SLEEP_SUBGROUP =
            new Guid("238c9fa8-0aad-41ed-83f4-97be242c8f20");
        private static Guid AFTER_SLEEP =
            new Guid("29f6c1db-86da-48c5-9fdb-f2b67b1f44da");
        private static Guid GUID_DISPLAY_SUBGROUP =
            new Guid("7516b95f-f776-4464-8c53-06167f40cc99");
        private static Guid TURNOFF_AFTER =
            new Guid("3c0bc021-c8a8-4e07-a973-6b14cbcb2b7e");

        [DllImport("powrprof.dll")]
        static extern uint PowerGetActiveScheme(
            IntPtr UserRootPowerKey,
            ref IntPtr ActivePolicyGuid);

        [DllImport("powrprof.dll")]
        static extern uint PowerReadACValue(
            IntPtr RootPowerKey,
            ref Guid SchemeGuid,
            ref Guid SubGroupOfPowerSettingGuid,
            ref Guid PowerSettingGuid,
            ref int Type,
            ref int Buffer,
            ref uint BufferSize);
        private void ShowValue()
        {
            Debug.WriteLine("Selected:{0}", tabControl1.SelectedIndex);

            int i;
            
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    for(i = 0; i < lstDisplayHardware.Items.Count; i++)
                    {
                        ListViewItem item = lstDisplayHardware.Items[i];
                        Debug.WriteLine("{0}:{1}:{2}", i, item.SubItems[0].Text, item.SubItems[1].Text);
                    }

                    // Host Name
                    String Key = "Win32_ComputerSystem";
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);
                    foreach (ManagementObject share in searcher.Get())
                    {
                        if(share.Properties.Count > 0)
                        {
                            lstDisplayHardware.Items[0].SubItems[1].Text = share.Properties["Name"].Value.ToString();
                        }
                        break;
                    }

                    // System Model, Serial Number
                    Key = "Win32_BaseBoard";
                    searcher = new ManagementObjectSearcher("select * from " + Key);
                    foreach (ManagementObject share in searcher.Get())
                    {
                        if (share.Properties.Count > 0)
                        {
                            lstDisplayHardware.Items[1].SubItems[1].Text = share.Properties["Manufacturer"].Value.ToString() + " " + share.Properties["Product"].Value.ToString();
                            lstDisplayHardware.Items[2].SubItems[1].Text = share.Properties["SerialNumber"].Value.ToString();
                        }
                        break;
                    }

                    // IP Address
                    try
                    {

                        //var host = Dns.GetHostEntry(Dns.GetHostName());
                        //foreach (var ip in host.AddressList)
                        //{
                        //    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        //    {
                        //        lstDisplayHardware.Items[3].SubItems[1].Text = ip.ToString();
                        //        break;
                        //    }
                        //}
                        using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                        {
                            socket.Connect("8.8.8.8", 65530);
                            IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                            lstDisplayHardware.Items[3].SubItems[1].Text = endPoint.Address.ToString();
                        }
                    }
                    catch
                    {

                    }

                    // DNS Address
                    lstDisplayHardware.Items[4].SubItems[1].Text = Dns.GetHostName();

                    // Static
                    lstDisplayHardware.Items[5].SubItems[1].Text = "";
                    Key = "Win32_NetworkAdapterConfiguration";
                    searcher = new ManagementObjectSearcher("select * from " + Key);
                    foreach (ManagementObject share in searcher.Get())
                    {
                        foreach (var prop in share.Properties)
                        {
                            if(prop.Name.Equals("IPAddress") && prop.Value != null)
                            {
                                String strValue = "";
                                if (prop.Value != null && prop.Value.ToString() != "")
                                {
                                    switch (prop.Value.GetType().ToString())
                                    {
                                        case "System.String[]":
                                            string[] str = (string[])prop.Value;

                                            string str2 = "";
                                            foreach (string st in str)
                                                str2 += st + " ";

                                            strValue = str2;

                                            break;
                                        case "System.UInt16[]":
                                            ushort[] shortData = (ushort[])prop.Value;


                                            string tstr2 = "";
                                            foreach (ushort st in shortData)
                                                tstr2 += st.ToString() + " ";

                                            strValue = tstr2;

                                            break;

                                        default:
                                            strValue = prop.Value.ToString();
                                            break;
                                    }
                                }
                                Debug.WriteLine("IP:" + prop.Value.ToString());
                                if(strValue.Contains(lstDisplayHardware.Items[3].SubItems[1].Text))
                                {
                                    lstDisplayHardware.Items[5].SubItems[1].Text = share.Properties["DHCPEnabled"].Value.ToString();
                                    lstDisplayHardware.Items[6].SubItems[1].Text = share.Properties["WINSEnableLMHostsLookup"].Value.ToString();
                                    break;
                                }
                            }
                            Console.WriteLine(string.Format("Name: {0} Value: {1}", prop.Name, prop.Value));
                        }

                        if (!lstDisplayHardware.Items[5].SubItems[1].Text.Equals(""))
                            break;
                    }

                    // Time Zone
                    TimeZone localZone = TimeZone.CurrentTimeZone;
                    lstDisplayHardware.Items[7].SubItems[1].Text = localZone.StandardName;

                    // CPU
                    Key = "Win32_Processor";
                    searcher = new ManagementObjectSearcher("select * from " + Key);
                    foreach (ManagementObject share in searcher.Get())
                    {
                        if (share.Properties.Count > 0)
                        {
                            lstDisplayHardware.Items[8].SubItems[1].Text = share.Properties["Name"].Value.ToString();
                        }
                        break;
                    }

                    // Storage
                    Key = "Win32_DiskDrive";
                    searcher = new ManagementObjectSearcher("select * from " + Key);
                    foreach (ManagementObject share in searcher.Get())
                    {
                        if (share.Properties.Count > 0)
                        {
                            lstDisplayHardware.Items[9].SubItems[1].Text = share.Properties["Size"].Value.ToString();
                        }
                        break;
                    }

                    // RAM
                    Key = "Win32_ComputerSystem";
                    searcher = new ManagementObjectSearcher("select * from " + Key);
                    foreach (ManagementObject share in searcher.Get())
                    {
                        if (share.Properties.Count > 0)
                        {
                            lstDisplayHardware.Items[10].SubItems[1].Text = share.Properties["TotalPhysicalMemory"].Value.ToString();
                        }
                        break;
                    }

                    // Screen resolution
                    Rectangle resolution = Screen.PrimaryScreen.Bounds;
                    lstDisplayHardware.Items[11].SubItems[1].Text = String.Format("{0} X {1}", resolution.Width, resolution.Height);

                    // Sleep After AC Power Value
                    var activePolicyGuidPTR = IntPtr.Zero;
                    PowerGetActiveScheme(IntPtr.Zero, ref activePolicyGuidPTR);

                    Guid activePolicyGuid = (Guid)Marshal.PtrToStructure(activePolicyGuidPTR, typeof(Guid));
                    var type = 0;
                    var value = 0;
                    var valueSize = 4u;
                    PowerReadACValue(IntPtr.Zero, ref activePolicyGuid,
                        ref GUID_SLEEP_SUBGROUP, ref AFTER_SLEEP,
                        ref type, ref value, ref valueSize);

                    lstDisplayHardware.Items[12].SubItems[1].Text = String.Format("0x{0:X8}",  value);

                    // Turn off display after AC Power value
                    type = 0;
                    value = 0;
                    valueSize = 4u;
                    PowerReadACValue(IntPtr.Zero, ref activePolicyGuid,
                        ref GUID_DISPLAY_SUBGROUP, ref TURNOFF_AFTER,
                        ref type, ref value, ref valueSize);

                    lstDisplayHardware.Items[13].SubItems[1].Text = String.Format("0x{0:X8}", value);

                    break;
                case 1:
                    listViewCertificate.Items.Clear();

                    var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                    store.Open(OpenFlags.ReadOnly);

                    i = 1;
                    foreach (X509Certificate2 mCert in store.Certificates)
                    {
                        ListViewGroup grp;
                        String strTemp = String.Format("Certificate {0}", i++);
                        grp = listViewCertificate.Groups.Add(strTemp, strTemp);
                        ListViewItem item1 = new ListViewItem(grp);
                        item1.Text = "Issuer";
                        item1.SubItems.Add(mCert.Issuer);
                        listViewCertificate.Items.Add(item1);

                        ListViewItem item2 = new ListViewItem(grp);
                        item2.Text = "Subject";
                        item2.SubItems.Add(mCert.Subject);
                        listViewCertificate.Items.Add(item2);

                        ListViewItem item3 = new ListViewItem(grp);
                        item3.Text = "Expire";
                        item3.SubItems.Add(mCert.GetExpirationDateString());
                        listViewCertificate.Items.Add(item3);
                    }

                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}
