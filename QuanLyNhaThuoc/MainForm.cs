using QuanLyTichDiem_TNK47_Buoi3;

namespace QuanLyNhaThuoc
{
    public partial class MainForm : Form
    {
        QuanLyKhachHang qlkh = new QuanLyKhachHang();
        QuanLyDuLieuMoRong qlDuLieuMoRong = new QuanLyDuLieuMoRong();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            qlkh.DocTuFile("Data.txt");
            HienThiDanhSachKhachHang(qlkh.DsKhachHang);
        }
        public void HienThiDanhSachKhachHang(List<KhachHang> dsKhachHang)
        {
            lvDanhSach.Items.Clear();
            foreach (var kh in dsKhachHang)
            {
                ListViewItem item = new ListViewItem(kh.Sdt);
                item.SubItems.Add(kh.HoTen);
                item.SubItems.Add(kh.DiemTL.ToString());
                lvDanhSach.Items.Add(item);
            }
        }
        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            var maTim = txtTimKH.Text.Trim();
            var ketQua = qlkh.TimKhachHangTheoSDT(maTim);
            HienThiDanhSachKhachHang(ketQua);
        }
        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                var selectedItem = lvDanhSach.SelectedItems[0];
                if (selectedItem != null)
                {
                    mtbSdt.Text = selectedItem.SubItems[0].Text;
                    txtHoTen.Text = selectedItem.SubItems[1].Text;
                    nudDiem.Value = decimal.Parse(selectedItem.SubItems[2].Text);
                }
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var sdt = mtbSdt.Text.Trim();
            var hoTen = txtHoTen.Text.Trim();
            var diemTL = (int)nudDiem.Value;

            if (string.IsNullOrEmpty(sdt) || sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kh = qlkh.Tim1KhachHangTheoSDT(sdt);
            if (kh != null)
            {
                MessageBox.Show("Khách hàng đã tồn tại. Vui lòng nhập số điện thoại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                kh = new KhachHang
                {
                    Sdt = sdt,
                    HoTen = hoTen,
                    DiemTL = diemTL
                };

                qlkh.ThemKhachHang(kh);
                HienThiDanhSachKhachHang(qlkh.DsKhachHang);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var sdt = mtbSdt.Text.Trim();
            var diemThem = (int)nudDiem.Value;

            if (string.IsNullOrEmpty(sdt) || sdt.Length != 10)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập số điện thoại hợp lệ để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm khách hàng theo số điện thoại
            var kh = qlkh.Tim1KhachHangTheoSDT(sdt);
            if (kh != null)
            {
                kh.DiemTL += diemThem; // Cộng dồn thêm điểm mới vào điểm hiện tại
                HienThiDanhSachKhachHang(qlkh.DsKhachHang); // Làm mới lại bảng
                MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng này trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhToanHoaDon()
        {
            // 1. Lấy tổng tiền hóa đơn (Kiểm tra xem thu ngân nhập đúng số không)
            decimal tongTienHoaDon = 0;
            decimal.TryParse(txtTongHD.Text, out tongTienHoaDon);

            // Hiển thị lại ở phần Tổng Thanh Toán
            txtTongTienHang.Text = tongTienHoaDon.ToString("N0");

            // 2. Tính tiền giảm từ Điểm (1 điểm = 1 vnđ)
            decimal tienGiamTuDiem = nudDungDiem.Value;

            // 3. Tính tiền giảm từ Voucher (Giả sử combobox lưu giá trị số 10000, 15000...)
            decimal tienGiamVoucher = 0;
            if (cbDungVoucher.SelectedIndex > 0) // Có chọn voucher
            {
                // Ép kiểu giá trị từ ComboBox (bạn cần setup Datasource cho Combobox trước)
                // Ví dụ tạm thời gán cứng để test:
                tienGiamVoucher = 15000;
            }

            // 4. Tính tiền giảm từ Sinh nhật
            decimal tienGiamSinhNhat = 0;
            if (rdbGiam50k.Checked)
            {
                tienGiamSinhNhat = 50000;
            }

            // 5. Tổng giảm trừ
            decimal tongGiamTru = tienGiamTuDiem + tienGiamVoucher + tienGiamSinhNhat;

            // Chặn lỗi: Tiền giảm không được lớn hơn tổng tiền hóa đơn
            if (tongGiamTru > tongTienHoaDon)
            {
                tongGiamTru = tongTienHoaDon;
            }

            txtTienGiamTru.Text = tongGiamTru.ToString("N0");

            // 6. Tính số tiền cuối cùng khách cần trả
            decimal khachCanTra = tongTienHoaDon - tongGiamTru;
            txtKhachCanTra.Text = khachCanTra.ToString("N0");
        }
        private void txtTongHD_TextChanged(object sender, EventArgs e)
        {
            TinhToanHoaDon();
        }
        private void rdbGiam50k_CheckedChanged(object sender, EventArgs e)
        {
            TinhToanHoaDon();
        }
        private void rdbTangSui_CheckedChanged(object sender, EventArgs e)
        {
            TinhToanHoaDon();
        }
        private void nudDungDiem_ValueChanged(object sender, EventArgs e)
        {
            decimal tongTienHoaDon = 0;
            decimal.TryParse(txtTongHD.Text, out tongTienHoaDon);

            decimal soDiemMuonDung = nudDungDiem.Value;

            // Ràng buộc 1: Tối đa 50% giá trị đơn hàng
            decimal gioiHan50PhanTram = tongTienHoaDon * 0.5m;
            if (soDiemMuonDung > gioiHan50PhanTram)
            {
                MessageBox.Show("Chỉ được dùng điểm giảm trừ tối đa 50% giá trị đơn hàng!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudDungDiem.Value = gioiHan50PhanTram - (gioiHan50PhanTram % 5000); // Tự động lùi về mốc 5000 gần nhất
                return;
            }

            // Ràng buộc 2: Khách có đủ điểm không? (Giả sử bạn đang lưu điểm KH ở biến khachHangHienTai)
            // if (soDiemMuonDung > khachHangHienTai.DiemTL)
            // {
            //      nudDungDiem.Value = khachHangHienTai.DiemTL - (khachHangHienTai.DiemTL % 5000);
            //      return;
            // }

            // Gọi lại hàm tính toán để cập nhật UI
            TinhToanHoaDon();
        }

        private void btnTaoNhom_Click(object sender, EventArgs e)
        {
            string sdtChuHo = mstSdtChuHo.Text.Trim();

            if (sdtChuHo.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại chủ hộ gồm 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Kiểm tra xem nhóm đã tồn tại chưa
            bool daTonTai = false;
            foreach (NhomGiaDinh nhom in qlDuLieuMoRong.DsNhomGiaDinh) // Giả sử qlDuLieuMoRong là biến toàn cục chứa dữ liệu
            {
                if (nhom.MaGiaDinh == sdtChuHo)
                {
                    daTonTai = true;
                    break;
                }
            }

            if (daTonTai)
            {
                MessageBox.Show("Nhóm gia đình với SĐT này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Tạo nhóm mới và cập nhật khách hàng hiện tại thành chủ hộ
            qlDuLieuMoRong.DsNhomGiaDinh.Add(new NhomGiaDinh(sdtChuHo, DateTime.Now));

            KhachHang kh = qlkh.Tim1KhachHangTheoSDT(sdtChuHo);
            if (kh != null)
            {
                kh.MaGiaDinh = sdtChuHo;
            }
            else
            {
                // Nếu người này chưa là khách hàng, tự động tạo mới
                qlkh.ThemKhachHang(new KhachHang { Sdt = sdtChuHo, HoTen = "Chủ hộ mới", MaGiaDinh = sdtChuHo });
            }

            MessageBox.Show("Tạo nhóm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiThongTinNhom(sdtChuHo);
        }

        private void HienThiThongTinNhom(string sdtChuHo)
        {
        }
    }
}
