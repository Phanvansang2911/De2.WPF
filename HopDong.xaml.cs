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
using System.Windows.Shapes;

namespace De2.WPF
{
    /// <summary>
    /// Interaction logic for HopDong.xaml
    /// </summary>
    public partial class HopDong : Window
    {
        QLChoThueNhaDBDataContext db = new QLChoThueNhaDBDataContext();
        public HopDong()
        {
            InitializeComponent();
            loadHopDong();
        }

        private void btnHienThi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            var maxHD = (from hd in db.HOPDONGs
                         join nha in db.NHAs on hd.MaNha equals nha.MaNha
                         select new
                         {
                             hd,
                             ThanhTien = (decimal)(((hd.NgayKetThuc - hd.NgayBatDau).Days / 30.0) * nha.GiaThue)
                         })
                            .OrderByDescending(x => x.ThanhTien)
                            .FirstOrDefault();
            if (maxHD != null)
            {
                MessageBox.Show($"Hợp đồng có giá trị cao nhất:\nSố Hợp Đồng: {maxHD.hd.SoHD}\nKhách Thuê: {maxHD.hd.MaKhach}\nNhà: {maxHD.hd.MaNha}\nGiá Trị: {maxHD.ThanhTien:C}");
            }
            else
            {
                MessageBox.Show("Không có hợp đồng nào.");
            }
        }
        private void loadHopDong()
        {
            var ds = from hd in db.HOPDONGs
                     join kh in db.KHACHTHUENHAs on hd.MaKhach equals kh.MaKhach
                     join n in db.NHAs on hd.MaNha equals n.MaNha
                     select new
                     {
                         hd.SoHD,
                         TenChuNha = n.TenChuNha,
                         TenKhach = kh.TenKhach,
                         hd.NgayBatDau,
                         hd.NgayKetThuc,
                         ThanhTien = (decimal)(((hd.NgayKetThuc - hd.NgayBatDau).Days / 30.0) * n.GiaThue)
                     };
            dtgHopDong.ItemsSource = ds.ToList();
        }
    }
}
