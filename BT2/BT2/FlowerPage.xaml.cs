using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BT2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlowerPage : ContentPage
    {
        ObservableCollection<Hoa> Hoas = new ObservableCollection<Hoa>();
        public FlowerPage()
        {
            InitializeComponent();
            Hoas.Add(new Hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "donxuan.jpg", Mota = "Hoa cúc các màu: trắng, vàng cam" });
            Hoas.Add(new Hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "honnhien.jpg", Mota = "Hoa anh đào màu: trắng, hồng" });
            Hoas.Add(new Hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "tim.jpg", Mota = "Hoa cúc tím thủy chung" });

            lsvHoa.ItemsSource = Hoas;

        }
    }
}