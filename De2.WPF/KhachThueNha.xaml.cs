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
    /// Interaction logic for KhachThueNha.xaml
    /// </summary>
    public partial class KhachThueNha : Window
    {
        QLChoThueNhaDBDataContext db = new QLChoThueNhaDBDataContext();
        public KhachThueNha()
        {
            InitializeComponent();
            loadKhachThue();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaKhach.Text) || string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                return;
            }
            if (db.KHACHTHUENHAs.Any(k => k.MaKhach == txtMaKhach.Text))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại.");
                return;
            }
            KHACHTHUENHA khach = new KHACHTHUENHA
            {
                MaKhach = txtMaKhach.Text,
                TenKhach = txtTenKhach.Text,
                GioiTinh = (bool)rdNam.IsChecked,
                NgaySinh = dpNgaySinh.SelectedDate ?? DateTime.Now
            };
            db.KHACHTHUENHAs.InsertOnSubmit(khach);
            db.SubmitChanges();
            loadKhachThue();
        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            var khach = db.KHACHTHUENHAs.FirstOrDefault(k => k.MaKhach == txtMaKhach.Text);
            if(khach != null)
            {
                khach.TenKhach = txtTenKhach.Text;
                khach.GioiTinh = (bool)rdNam.IsChecked;
                khach.NgaySinh = dpNgaySinh.SelectedDate ?? DateTime.Now;
                db.SubmitChanges();
                loadKhachThue();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với mã đã nhập.");
            }   
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            var result = db.KHACHTHUENHAs
                .Where(k => k.TenKhach.Contains(txtTimKiem.Text))
                .ToList();
            dtgKhachThue.ItemsSource = result;
        }
        private void loadKhachThue()
        {
            var dsKhach = from khach in db.KHACHTHUENHAs
                          select new
                          {
                              khach.MaKhach,
                              khach.TenKhach,
                              GioiTinh = khach.GioiTinh == true ? "Nam" : "Nữ",
                              NgaySinh = khach.NgaySinh.ToShortDateString()
                          };
            dtgKhachThue.ItemsSource = dsKhach.ToList();
        }
    }
}
