using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using DTechPack.Properties;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Threading;

namespace DTechPack
{
    class Mehods
    {

        public void CopyFile(string FileSource, string FileDestination, ProgressBar progressBar1)
            {

                    int NumRead; Int64 FileLengh;
                    FileStream From = new FileStream(FileSource, FileMode.Open);
                    FileStream To = new FileStream(FileDestination, FileMode.CreateNew);
                    byte[] Buffer = new byte[1024];
                    FileLengh = From.Length;
                    progressBar1.Minimum = 0; progressBar1.Maximum = (int)FileLengh;
                    while (FileLengh > 0)
                    {
                        BinaryReader Reader = new BinaryReader(From);
                        NumRead = Reader.Read(Buffer, 0, 1024);
                        FileLengh = FileLengh - NumRead;
                        BinaryWriter Writer = new BinaryWriter(To);
                        Writer.Write(Buffer, 0, NumRead);
                        progressBar1.Value = progressBar1.Value + NumRead;
                        Writer.Flush();
                    }
                    From.Close(); To.Close();
                    if (progressBar1.Value > 99)
                        progressBar1.Value = 0;  
            }

        public void LoadList(ListBox lst, Type typ)
        {
            lst.DataSource = System.Enum.GetNames(typ);
        }

        public void getXXXP(ListView lst,string address)
        {
            lst.Items.Clear();
            if (File.Exists(address))
            {
                Process processX = new Process();
                ProcessStartInfo psi = new ProcessStartInfo(address);
                lst.Items.Clear(); 
                processX.StartInfo = psi;
                processX.Start();
                Thread.Sleep(100);
                ProcessModule processModule;
                ProcessModuleCollection processMC = processX.Modules;
                for (int i = 0; i < processMC.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    ListViewItem lviSize = new ListViewItem();
                    processModule = processMC[i];
                    lvi.Text = processModule.ModuleName.ToString();
                    lvi.Name = processModule.FileName.ToString();
                    lviSize.Text = "Size: " + processModule.ModuleMemorySize.ToString();
                    lst.Items.Add(lvi);
                    lvi.SubItems.Add(lviSize.ToString());
                    lst.Items.Add(lviSize);  
                }
            }
        }

        public void XPWithoutSize(ListView lst, string address)
        {
            lst.Items.Clear();
            try
            {
                Process processX = new Process();
                ProcessStartInfo psi = new ProcessStartInfo(address);
                lst.Items.Clear();
                processX.StartInfo = psi;
                processX.Start();
                Thread.Sleep(100);
                ProcessModule processModule;
                ProcessModuleCollection processMC = processX.Modules;
                for (int i = 0; i < processMC.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    processModule = processMC[i];
                    lvi.Text = processModule.ModuleName.ToString();
                    lvi.Name = processModule.FileName.ToString();
                    lst.Items.Add(lvi);

                }
            }
            catch { }
        }

        public void X2Process(ListView lst, string xm)
        {
            lst.Items.Clear();
            try
            {
                Process[] prcsX = Process.GetProcesses();
                Process P1;
                for (int i = 0; i < prcsX.Length; i++)
                {
                    P1 = prcsX[i];
                    if (xm == P1.ProcessName)
                    {
                        //P1.Start();
                        //Thread.Sleep(10);
                        ProcessModule processM;
                        ProcessModuleCollection ProcessMC = P1.Modules;
                        for (int j = 0; j < ProcessMC.Count; j++)
                        {
                            ListViewItem lvi = new ListViewItem();
                            ListViewItem lviSize = new ListViewItem();
                            processM = ProcessMC[j];
                            lvi.Text = processM.ModuleName.ToString().ToString();
                            lvi.Name = processM.FileName.ToString();
                            lst.Items.Add(lvi);

                        }

                    }
                }
            }
            catch {   }
        }

        public void LoadList(ListBox lst, ICollection ic)
        {
            string[] astrItems = new string[ic.Count];
            ic.CopyTo(astrItems, 0);
            lst.DataSource = astrItems;

        }

        public void GetProcess(ListView lv)
        {
            Process[] prc = Process.GetProcesses();
            try
            {
                foreach (Process px in prc)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = px.ProcessName;
                    lvi.Name = px.Modules.ToString();
                    lv.Items.Add(lvi);
                }
            }
            catch { }
        }

        public void GetProcessLB(ListBox lsb)
        {
            lsb.Items.Clear();
            Process[] x = Process.GetProcesses();
            foreach (Process px in x)
            {
                lsb.Items.Add(px.ProcessName);
                if (px.MainWindowTitle != "")
                    lsb.Items.Add("-> " + px.MainWindowTitle);

            }
        }

        public void GetProcessLBTaskProcess(ListBox lsb)
        {
            lsb.Items.Clear();
            Process[] x = Process.GetProcesses();
            foreach (Process px in x)
            {
                if (px.MainWindowTitle != "")
                {
                    lsb.Items.Add(px.ProcessName);
                    lsb.Items.Add("-> " + px.MainWindowTitle);
                }
            }
        }

        public void PrcsKill(string prsstring)
        {
            Process[] ppp = Process.GetProcesses();
            try
            {
                foreach (Process p in ppp)
                {
                    if (p.ProcessName.ToString() == prsstring)
                        p.Kill();
                }
            }
            catch {    }

        }

        public void GetModules(ListView lsb, string prcstart)
        {
            Process Xprocess = new Process();
            ProcessStartInfo XprocessInfo = new ProcessStartInfo(prcstart);
            Xprocess.StartInfo = XprocessInfo;
            Xprocess.Start();
            System.Threading.Thread.Sleep(100);
            ProcessModule PrcModule;
            ProcessModuleCollection PrcMC = Xprocess.Modules;
            for (int i = 0; i < PrcMC.Count; i++)
            {
                ListViewItem lvitm = new ListViewItem();
                PrcModule = PrcMC[i];
                lvitm.Text = PrcModule.ModuleName;
                lvitm.Name = PrcModule.FileName;
                lsb.Items.Add(lvitm);
            }
        }
        #region Safe
        string SStatuse;
        private bool Check()
        {
        	bool flag;
            DriveInfo[] drvc = DriveInfo.GetDrives();
            DriveInfo drv;
            for (int i = 0; i <= drvc.Length; i++)
            {
                try
                {
                    drv = drvc[i];
                    if (drv.IsReady && drv.VolumeLabel == Settings.Default.SafeLock)
                    {
                    	flag=true;
                    	return flag;
                        break;
                    }
                }
                catch { }
            }
            return false;
        }
        public void XCheck()
        {
           
        	if (Check())
            {
                DialogResult dr= MessageBox.Show("The HDLock Not Found !", "SAFE Error",
                 MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                if (dr == DialogResult.Retry)
                    XCheck();
                else
                {
                    Application.Exit();
                } 
            }
        }
        #endregion


    }
}
