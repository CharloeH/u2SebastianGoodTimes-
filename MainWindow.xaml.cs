using System;
using System.Collections.Generic;
using System.Linq;
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

namespace u2SebastianGoodTimes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            string TimeInput = txtInput.Text;
            int OriginalTime = 0;

            string OutputTime = "";
            int.TryParse(TimeInput.Substring(0, TimeInput.Length), out OriginalTime);
            int StJohnsTime = OriginalTime + 130;
            int HalifaxTime = OriginalTime + 100;
            int VictoriaTime = OriginalTime - 300;
            int WinnepegTime = OriginalTime - 100;
            int EdmontonTime = OriginalTime - 200;
     
            CreateLabel(OriginalTime, VictoriaTime, EdmontonTime, WinnepegTime, OriginalTime, HalifaxTime, StJohnsTime);
        }

        private void CreateLabel(int time1, int time2, int time3, int time4, int time5, int time6, int time7)
        {
            Label myLabel = new Label();
            myLabel.Content = time1 + " in ottawa \r" + time2 + " in Victoria \r" + time3 + " in Edmonton \r" + time4 + " in Winnepeg \r" + time5 + " in Toronto \r" + time6 + " in Halifax \r" + time7 + " in St. John's \r";
            myStack.Children.Add(myLabel);
            
        }
    }
}



