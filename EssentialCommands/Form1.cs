using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;

namespace EssentialCommands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Runcommand1(string command)
        {


            //Using mmc.exe to lounch .msc files

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "mmc.exe",
                Arguments = command,  // Pass the path to services.msc as an argument
                UseShellExecute = true  // UseShellExecute must be true to run it as an application
            };

            Process.Start(psi);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // At form load add items to the combobox2
            comboBox2.Items.Add("services.msc: Open the Services Manager. ");
            comboBox2.Items.Add("taskschd.msc: Access the Task Scheduler. ");
            comboBox2.Items.Add("diskmgmt.msc: Manage partitions and disks. ");
            comboBox2.Items.Add("devmgmt.msc: Open the Device Manager. ");
            comboBox2.Items.Add("compmgmt.msc: Access Computer Management tools. ");
            comboBox2.Items.Add("wmimgmt.msc: Open the WMI Management Console. ");
            comboBox2.Items.Add("msconfig: Configure startup and services. ");
            comboBox2.Items.Add("perfmon.msc: Launch the Performance Monitor. ");
            comboBox2.Items.Add("secpol.msc: Configure local security policies. ");
            comboBox2.Items.Add("gpedit.msc: Manage local group policies.");

            // At form load add items to the combobox1
            comboBox1.Items.Add("appwiz.cpl: Manage installed programs and features. ");
            comboBox1.Items.Add("control folders: Access File Explorer Options. ");
            comboBox1.Items.Add("desk.cpl: Configure display settings. ");
            comboBox1.Items.Add("intl.cpl: Set regional and language options. ");
            comboBox1.Items.Add("timedate.cpl: Set the date and time. ");
            comboBox1.Items.Add("sysdm.cpl: Open System Properties. ");
            comboBox1.Items.Add("firewall.cpl: Manage the Windows Firewall. ");
            comboBox1.Items.Add("powercfg.cpl: Modify power settings. ");
            comboBox1.Items.Add("mmsys.cpl: Configure audio devices. ");

            // At form load add items to the combobox3
            comboBox3.Items.Add("ipconfig: Display and configure IP settings. ");
            comboBox3.Items.Add("wf.msc: Manage advanced Windows Firewall settings. ");
            comboBox3.Items.Add("ncpa.cpl: Access network connections. ");
            comboBox3.Items.Add("netplwiz: Manage users and their access rights. ");
            comboBox3.Items.Add("ping [ip address]: Check network connectivity. ");
            comboBox3.Items.Add("tracert [ip address]: Diagnose the network path. ");
            comboBox3.Items.Add("netsh wlan show profiles: List saved Wi-Fi profiles.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    // Action for index 0
                    MessageBox.Show("You selected index 0");
                    string path0 = @"C:\Windows\System32\services.msc";

                    Runcommand1(path0);

                    break;
                case 1:
                    // Action for index 1
                    MessageBox.Show("You selected index 1");
                    string path1 = @"C:\Windows\System32\taskschd.msc";

                    Runcommand1(path1);
                    break;
                case 2:
                    // Action for index 2
                    MessageBox.Show("You selected index 2");
                    string path2 = @"C:\Windows\System32\diskmgmt.msc";

                    Runcommand1(path2);
                    break;
                case 3:
                    //Action for index 3
                    MessageBox.Show("You selected index 3");
                    string path3 = @"C:\Windows\System32\devmgmt.msc";

                    Runcommand1(path3);
                    break;
                case 4:
                    //Action for index 4
                    MessageBox.Show("You selected index 4");
                    string path4 = @"C:\Windows\System32\compmgmt.msc";

                    Runcommand1(path4);
                    break;
                case 5:
                    //Action for index 5
                    MessageBox.Show("You selected index 5");
                    string path5 = @"C:\Windows\System32\wmimgmt.msc";

                    Runcommand1(path5);
                    break;
                case 6:
                    //Action for index 6
                    MessageBox.Show("You selected index 6");

                    Process.Start("msconfig");

                    break;
                case 7:
                    //Action for index 7
                    MessageBox.Show("You selected index 7");
                    string path7 = @"C:\Windows\System32\perfmon.msc";

                    Runcommand1(path7);
                    break;
                case 8:
                    //Action for index 8
                    MessageBox.Show("You selected index 8");
                    string path8 = @"C:\Windows\System32\secpol.msc";

                    Runcommand1(path8);
                    break;
                case 9:
                    // Action for index 9
                    MessageBox.Show("You selected index 9");
                    string path9 = @"C:\Windows\System32\gpedit.msc";

                    Runcommand1(path9);
                    break;
                default:
                    MessageBox.Show("Please select a valid option.");
                    break;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    // Action for index 0
                    MessageBox.Show("You selected index 0");


                    Process.Start(new ProcessStartInfo("appwiz.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 1:
                    // Action for index 1
                    MessageBox.Show("You selected index 1");

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "control.exe";
                    startInfo.Arguments = "folders";

                    Process.Start(startInfo);

                    break;
                case 2:
                    // Action for index 2
                    MessageBox.Show("You selected index 2");

                    Process.Start(new ProcessStartInfo("desk.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 3:
                    // Action for index 3
                    MessageBox.Show("You selected index 3");

                    Process.Start(new ProcessStartInfo("intl.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 4:
                    // Action for index 4
                    MessageBox.Show("You selected index 4");

                    Process.Start(new ProcessStartInfo("timedate.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 5:
                    // Action for index 5
                    MessageBox.Show("You selected index 5");

                    Process.Start(new ProcessStartInfo("sysdm.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 6:
                    // Action for index 6
                    MessageBox.Show("You selected index 6");

                    Process.Start(new ProcessStartInfo("firewall.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 7:
                    // Action for index 
                    MessageBox.Show("You selected index 7");

                    Process.Start(new ProcessStartInfo("powercfg.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 8:
                    // Action for index 8
                    MessageBox.Show("You selected index 8");

                    Process.Start(new ProcessStartInfo("mmsys.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;
                default:
                    MessageBox.Show("Please select a valid option.");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox3.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    // Action for index 0
                    MessageBox.Show("You selected index 0");

                    Process.Start(new ProcessStartInfo("cmd.exe", "/k ipconfig")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 1:
                    // Action for index 1
                    MessageBox.Show("You selected index 1");

                    Process.Start(new ProcessStartInfo("wf.msc")
                    {
                        UseShellExecute = true
                    });

                    break;
                case 2:
                    // Action for index 2
                    MessageBox.Show("You selected index 2");

                    Process.Start(new ProcessStartInfo("ncpa.cpl")
                    {
                        UseShellExecute = true
                    });

                    break;


                default:
                    MessageBox.Show("Please select a valid option.");
                    break;

            }
            }
    }
}
