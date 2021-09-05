using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
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

                    break;
                case 1:
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
