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

namespace SalesDashboardUi.Controls
{
    /// <summary>
    /// Interaction logic for UserCard.xaml
    /// </summary>
    public partial class UserCard : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(UserCard));
        public static readonly DependencyProperty UpPriceProperty = DependencyProperty.Register("UpPrice", typeof(string), typeof(UserCard));
        public static readonly DependencyProperty DownPriceProperty = DependencyProperty.Register("DownPrice", typeof(string), typeof(UserCard));
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(UserCard));


        public UserCard()
        {
            InitializeComponent();
        }
    }
}
