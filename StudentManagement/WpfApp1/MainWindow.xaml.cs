using System;
using System.Windows;
using Student_System_Server;
using System.ServiceModel;

namespace DesktopClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private DatabaseInterface foob;
        public MainWindow()
        {
            InitializeComponent();

            ChannelFactory<DatabaseInterface> foobFactory;
            NetTcpBinding tcp = new NetTcpBinding();
            //Set the URL and create the conncetion!
            string URL = "net.tcp://localhost:8100/StudentService";
            foobFactory = new ChannelFactory<DatabaseInterface>(tcp, URL);
            foob = foobFactory.CreateChannel();
            //Also, tell me how many entries are in the DB
            StudentIndex.Text = foob.GetNumEntries().ToString();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string name = null;
            int id = 0;
            string universityName = null;
            foob.GetValuesForEntry(Int32.Parse(StudentIndex.Text), out name, out id, out universityName);
            StudentId.Text = id.ToString();
            StudentName.Text = name;
            StudentUni.Text = universityName;
        }
    }
}
