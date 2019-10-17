using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupFlower : ContentPage
    {
        public GroupFlower()
        {
            InitializeComponent();
            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.Loaihoas;
        }
    }
}