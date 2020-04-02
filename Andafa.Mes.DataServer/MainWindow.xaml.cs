using Andafa.Mes.Bll.ScadaBll;
using Andafa.Mes.Common.Tools;
using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Andafa.Mes.DataServer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载并设置按钮状态
        /// </summary>
        private void LoadServiceStatus()
        {
            ServiceController serviceCtrl = GetServicesByName("DataService");
            if (serviceCtrl == null)
            {
                btnSetupOrUninstallService.Content = "安装服务";
                btnSetupOrUninstallService.IsEnabled = true;
                btnStartOrStopService.Content = "启动服务";
                btnStartOrStopService.IsEnabled = false;
                //btnStartOrStopLog.Content = "启用日志";
                //btnStartOrStopLog.IsEnabled = false;
            }
            else
            {
                btnSetupOrUninstallService.Content = "卸载服务";
                btnStartOrStopService.IsEnabled = true;
                //btnStartOrStopLog.IsEnabled = true;
                switch (serviceCtrl.Status)
                {
                    case ServiceControllerStatus.Running:
                        btnStartOrStopService.Content = "停止服务";
                        btnSetupOrUninstallService.IsEnabled = false;
                        break;
                    case ServiceControllerStatus.StartPending:
                    case ServiceControllerStatus.ContinuePending:
                    case ServiceControllerStatus.PausePending:
                    case ServiceControllerStatus.Paused:
                    case ServiceControllerStatus.StopPending:
                        serviceCtrl.Stop();
                        btnStartOrStopService.Content = "启动服务";
                        btnSetupOrUninstallService.IsEnabled = true;
                        break;
                    case ServiceControllerStatus.Stopped:
                        btnStartOrStopService.Content = "启动服务";
                        btnSetupOrUninstallService.IsEnabled = true;
                        break;
                    default:
                        break;
                }
            }
            LoadBtnBackground();
        }

        /// <summary>
        /// load button background
        /// </summary>
        private void LoadBtnBackground()
        {
            if (btnSetupOrUninstallService.IsEnabled)
            {
                btnSetupOrUninstallService.Background = new SolidColorBrush(Color.FromRgb((byte)42, (byte)72, (byte)254));
            }
            else
            {
                btnSetupOrUninstallService.Background = new SolidColorBrush(Color.FromRgb((byte)212, (byte)208, (byte)200));
            }
            if (btnStartOrStopService.IsEnabled)
            {
                btnStartOrStopService.Background = new SolidColorBrush(Color.FromRgb((byte)42, (byte)72, (byte)254));
            }
            else
            {
                btnStartOrStopService.Background = new SolidColorBrush(Color.FromRgb((byte)212, (byte)208, (byte)200));
            }
            if (ConvertTool.GetBool(XmlTool.GetNodeValueByXPath(_xPathIsLogging, _path)))
            {
                btnStartOrStopLog.Content = "停用日志";
            }
            else
            {
                btnStartOrStopLog.Content = "启用日志";
            }
        }

        /// <summary>
        /// config path
        /// </summary>
        private string _path = AppDomain.CurrentDomain.BaseDirectory + @"\Config\ServiceConfig.xml";

        /// <summary>
        /// is logging xpath
        /// </summary>
        private string _xPathIsLogging = @"/ServiceConfig/IsLogging";

        /// <summary>
        /// 服务安装卸载按钮
        /// </summary>
        /// <param name="sender">按钮对象</param>
        /// <param name="e">按钮事件句柄</param>
        private void btnStartAndUnist_Click(object sender, EventArgs e)
        {
            if (btnSetupOrUninstallService.Content.ToString() == "安装服务")
            {
                string[] args = { "Andafa.Mes.DataService.exe" };
                ServiceController serviceCtrl = GetServicesByName("DataService");
                if (serviceCtrl == null)//这里的Service1是对应真实项目中的服务名称
                {
                    try
                    {
                        ManagedInstallerClass.InstallHelper(args);  //参数 args 就是你用 InstallUtil.exe 工具安装时的参数。一般就是一个exe的文件名
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务成功安装\n";
                        ResultOutPut(msg);
                    }
                    catch (Exception ex)
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务安装失败\n" + ex.ToString() + "\n";
                        ResultOutPut(msg);
                        return;
                    }
                }
                else
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t该服务已经存在，禁止重复安装\n" + "\n";
                    ResultOutPut(msg);
                }
                btnSetupOrUninstallService.Content = "卸载服务";
                btnStartOrStopService.IsEnabled = true;
            }
            else
            {
                string[] args = { "/u", "Andafa.Mes.DataService.exe" };
                ServiceController serviceCtrl = GetServicesByName("DataService");
                if (serviceCtrl != null)//这里的Service1是对应真实项目中的服务名称
                {
                    try
                    {
                        ManagedInstallerClass.InstallHelper(args);  //参数 args 就是你用 InstallUtil.exe 工具安装时的参数。一般就是一个exe的文件名
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务成功卸载\n";
                        ResultOutPut(msg);
                        btnStartOrStopService.IsEnabled = false;
                        btnSetupOrUninstallService.Content = "安装服务";
                    }
                    catch (Exception ex)
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务无法卸载\n" + ex.ToString() + "\n";
                        ResultOutPut(msg);
                        return;
                    }
                }
                else
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务不存在，无法卸载\n";
                    ResultOutPut(msg);
                }
            }
            LoadBtnBackground();
        }

        /// <summary>  
        /// 获取指定服务  
        /// </summary>  
        /// <param name="svcName">服务名</param>  
        /// <returns>对应的服务，若无此服务返回空</returns>  
        private ServiceController GetServicesByName(string svcName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController s in services)
            {
                if (s.ServiceName == svcName)
                {
                    return s;
                }
            }
            return null;
        }

        /// <summary>
        /// 启动和停止按钮事件
        /// </summary>
        /// <param name="sender">按钮对象</param>
        /// <param name="e">按钮事件句柄</param>
        private void btnStartAndStop_Click(object sender, EventArgs e)
        {
            ServiceController serviceCtrl = GetServicesByName("DataService");
            if (btnStartOrStopService.Content.ToString() == "启动服务")
            {
                try
                {
                    if (serviceCtrl != null)
                    {
                        serviceCtrl.Start();
                        btnSetupOrUninstallService.IsEnabled = false;
                        btnStartOrStopService.Content = "停止服务";
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务启动成功\n";
                        ResultOutPut(msg);
                    }
                    else
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务启动失败\n";
                        ResultOutPut(msg);
                    }
                }
                catch (Exception ex)
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务无法启动\n" + ex.ToString() + "\n";
                    ResultOutPut(msg);
                }
            }
            else
            {
                try
                {
                    if (serviceCtrl != null)
                    {
                        serviceCtrl.Stop();
                        btnSetupOrUninstallService.IsEnabled = true;
                        btnStartOrStopService.Content = "启动服务";
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务停止成功\n";
                        ResultOutPut(msg);
                    }
                    else
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务停止失败\n";
                        ResultOutPut(msg);
                    }
                }
                catch (Exception ex)
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务无法停止\n" + ex.ToString() + "\n";
                    ResultOutPut(msg);
                }
            }
            LoadBtnBackground();
        }


        /// <summary>
        /// 过程记录输出到前台
        /// </summary>
        /// <param name="msg"></param>
        private void ResultOutPut(string msg)
        {
            this.txtMsg.Dispatcher.Invoke(new Action<string>(MsgWrite), msg);
        }

        /// <summary>
        /// 数据写入
        /// </summary>
        /// <param name="msg">数据</param>
        private void MsgWrite(string msg)
        {
            this.txtMsg.Text = msg;
        }

        /// <summary>
        /// 主窗体加载事件
        /// </summary>
        /// <param name="sender">事件触发对象</param>
        /// <param name="e">事件参数</param>
        private void MainWindowLoad(object sender, RoutedEventArgs e)
        {
            LoadServiceStatus();
            btnStartOrStopLog.IsEnabled = true;
        }

        /// <summary>
        /// 服务启停按钮单击事件
        /// </summary>
        /// <param name="sender">事件触发对象</param>
        /// <param name="e">事件参数</param>
        private void btnStartOrStopService_Click(object sender, RoutedEventArgs e)
        {
            ServiceController serviceCtrl = GetServicesByName("DataService");
            if (btnStartOrStopService.Content.ToString() == "启动服务")
            {
                try
                {
                    if (serviceCtrl != null)
                    {
                        serviceCtrl.Start();
                        btnSetupOrUninstallService.IsEnabled = false;
                        btnStartOrStopService.Content = "停止服务";
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务启动成功\n";
                        ResultOutPut(msg);
                    }
                    else
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务启动失败\n";
                        ResultOutPut(msg);
                    }
                }
                catch (Exception ex)
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务无法启动\n" + ex.ToString() + "\n";
                    ResultOutPut(msg);
                }
            }
            else
            {
                try
                {
                    if (serviceCtrl != null)
                    {
                        serviceCtrl.Stop();
                        btnSetupOrUninstallService.IsEnabled = true;
                        btnStartOrStopService.Content = "启动服务";
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务停止成功\n";
                        ResultOutPut(msg);
                    }
                    else
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务停止失败\n";
                        ResultOutPut(msg);
                    }
                }
                catch (Exception ex)
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务无法停止\n" + ex.ToString() + "\n";
                    ResultOutPut(msg);
                }
            }
            LoadBtnBackground();
        }

        /// <summary>
        /// 服务安装卸载单击事件
        /// </summary>
        /// <param name="sender">事件触发对象</param>
        /// <param name="e">事件参数</param>
        private void btnSetupOrUninstallService_Click(object sender, RoutedEventArgs e)
        {
            if (btnSetupOrUninstallService.Content.ToString() == "安装服务")
            {
                string[] args = { "Andafa.Mes.DataService.exe" };
                ServiceController serviceCtrl = GetServicesByName("DataService");
                if (serviceCtrl == null)//这里的Service1是对应真实项目中的服务名称
                {
                    try
                    {
                        ManagedInstallerClass.InstallHelper(args);  //参数 args 就是你用 InstallUtil.exe 工具安装时的参数。一般就是一个exe的文件名
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务成功安装\n";
                        ResultOutPut(msg);
                    }
                    catch (Exception ex)
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务安装失败\n" + ex.ToString() + "\n";
                        ResultOutPut(msg);
                        return;
                    }
                }
                else
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t该服务已经存在，禁止重复安装\n" + "\n";
                    ResultOutPut(msg);
                }
                btnSetupOrUninstallService.Content = "卸载服务";
                btnStartOrStopService.IsEnabled = true;
            }
            else
            {
                string[] args = { "/u", "Andafa.Mes.DataService.exe" };
                ServiceController serviceCtrl = GetServicesByName("DataService");
                if (serviceCtrl != null)//这里的Service1是对应真实项目中的服务名称
                {
                    try
                    {
                        ManagedInstallerClass.InstallHelper(args);  //参数 args 就是你用 InstallUtil.exe 工具安装时的参数。一般就是一个exe的文件名
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务成功卸载\n";
                        ResultOutPut(msg);
                        btnStartOrStopService.IsEnabled = false;
                        btnSetupOrUninstallService.Content = "安装服务";
                    }
                    catch (Exception ex)
                    {
                        string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务无法卸载\n" + ex.ToString() + "\n";
                        ResultOutPut(msg);
                        return;
                    }
                }
                else
                {
                    string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t服务不存在，无法卸载\n";
                    ResultOutPut(msg);
                }
            }
            LoadBtnBackground();
        }

        /// <summary>
        /// 日志启停单击按钮事件
        /// </summary>
        /// <param name="sender">事件触发对象</param>
        /// <param name="e">事件参数</param>
        private void btnStartOrStopLog_Click(object sender, RoutedEventArgs e)
        {
            //if (btnStartOrStopLog.Content=="启用日志")
            //{
            //    XmlTool.SetNodeValueByXPath(_path, "True", _xPathIsLogging);
            //}
            //else
            //{
            //    XmlTool.SetNodeValueByXPath(_path, "False", _xPathIsLogging);
            //}
            DataSyncBll bll = new DataSyncBll();
            bll.SyncData();
        }
    }
}
