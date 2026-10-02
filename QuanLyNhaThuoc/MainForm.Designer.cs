namespace QuanLyNhaThuoc
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            nudDiem = new NumericUpDown();
            btnThem = new Button();
            btnCapNhat = new Button();
            label4 = new Label();
            txtTimKH = new TextBox();
            lvDanhSach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            mtbSdt = new MaskedTextBox();
            txtHangThe = new TextBox();
            label6 = new Label();
            txtDiemKhaDung = new TextBox();
            label7 = new Label();
            txtLuuY = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            rdbTangSui = new RadioButton();
            rdbGiam50k = new RadioButton();
            cbDungVoucher = new ComboBox();
            nudDungDiem = new NumericUpDown();
            txtTongHD = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnXuatHoaDon = new Button();
            txtKhachCanTra = new TextBox();
            txtTienGiamTru = new TextBox();
            txtTongTienHang = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox4 = new GroupBox();
            txtQuyDiemChung = new TextBox();
            txtHangGiaDinh = new TextBox();
            txtTongChiTieuNhom = new TextBox();
            txtSoLuongThanhVien = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label19 = new Label();
            mstSdtChuHo = new MaskedTextBox();
            btnTaoNhom = new Button();
            btnTimNhom = new Button();
            label18 = new Label();
            label20 = new Label();
            groupBox3 = new GroupBox();
            btnThemThanhVien = new Button();
            lvThanhVienNhom = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            mstNhapSdtMoi = new MaskedTextBox();
            label21 = new Label();
            groupBox5 = new GroupBox();
            lvKhoVoucherGiaDinh = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDungDiem).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 15);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập Số Điện Thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 48);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên Khách Hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 181);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Điểm Tích Lũy:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(183, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(341, 27);
            txtHoTen.TabIndex = 4;
            // 
            // nudDiem
            // 
            nudDiem.Location = new Point(183, 179);
            nudDiem.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudDiem.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(124, 27);
            nudDiem.TabIndex = 5;
            nudDiem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThem
            // 
            btnThem.Location = new Point(330, 177);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm Khách Hàng";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(430, 177);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "Cập Nhật Điểm";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 235);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 8;
            label4.Text = "Nhập Thông Tin Cần Tìm:";
            // 
            // txtTimKH
            // 
            txtTimKH.Location = new Point(232, 232);
            txtTimKH.Name = "txtTimKH";
            txtTimKH.Size = new Size(209, 27);
            txtTimKH.TabIndex = 9;
            txtTimKH.Click += txtTimKH_TextChanged;
            // 
            // lvDanhSach
            // 
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.Location = new Point(32, 265);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(492, 424);
            lvDanhSach.TabIndex = 10;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            lvDanhSach.SelectedIndexChanged += lvDanhSach_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Số Điện Thoại";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ Tên Khách Hàng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Điểm Tích Lũy";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // mtbSdt
            // 
            mtbSdt.Location = new Point(183, 12);
            mtbSdt.Mask = "0000000000";
            mtbSdt.Name = "mtbSdt";
            mtbSdt.Size = new Size(341, 27);
            mtbSdt.TabIndex = 11;
            // 
            // txtHangThe
            // 
            txtHangThe.Location = new Point(183, 78);
            txtHangThe.Name = "txtHangThe";
            txtHangThe.Size = new Size(341, 27);
            txtHangThe.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 81);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 14;
            label6.Text = "Hạng Thẻ:";
            // 
            // txtDiemKhaDung
            // 
            txtDiemKhaDung.Location = new Point(183, 111);
            txtDiemKhaDung.Name = "txtDiemKhaDung";
            txtDiemKhaDung.Size = new Size(341, 27);
            txtDiemKhaDung.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 114);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 16;
            label7.Text = "Điểm Khả Dụng:";
            // 
            // txtLuuY
            // 
            txtLuuY.Location = new Point(183, 144);
            txtLuuY.Name = "txtLuuY";
            txtLuuY.Size = new Size(341, 27);
            txtLuuY.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 147);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 18;
            label8.Text = "Lưu ý:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbTangSui);
            groupBox1.Controls.Add(rdbGiam50k);
            groupBox1.Controls.Add(cbDungVoucher);
            groupBox1.Controls.Add(nudDungDiem);
            groupBox1.Controls.Add(txtTongHD);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(573, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 250);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn và Áp Dụng Ưu Đãi";
            // 
            // rdbTangSui
            // 
            rdbTangSui.AutoSize = true;
            rdbTangSui.Location = new Point(275, 186);
            rdbTangSui.Name = "rdbTangSui";
            rdbTangSui.Size = new Size(110, 24);
            rdbTangSui.TabIndex = 26;
            rdbTangSui.Text = "Tặng 1 sủi C";
            rdbTangSui.UseVisualStyleBackColor = true;
            rdbTangSui.CheckedChanged += rdbTangSui_CheckedChanged;
            // 
            // rdbGiam50k
            // 
            rdbGiam50k.AutoSize = true;
            rdbGiam50k.Location = new Point(176, 184);
            rdbGiam50k.Name = "rdbGiam50k";
            rdbGiam50k.Size = new Size(92, 24);
            rdbGiam50k.TabIndex = 25;
            rdbGiam50k.Text = "Giảm 50k";
            rdbGiam50k.UseVisualStyleBackColor = true;
            rdbGiam50k.CheckedChanged += rdbGiam50k_CheckedChanged;
            // 
            // cbDungVoucher
            // 
            cbDungVoucher.FormattingEnabled = true;
            cbDungVoucher.Location = new Point(176, 140);
            cbDungVoucher.Name = "cbDungVoucher";
            cbDungVoucher.Size = new Size(209, 28);
            cbDungVoucher.TabIndex = 24;
            // 
            // nudDungDiem
            // 
            nudDungDiem.Location = new Point(176, 94);
            nudDungDiem.Name = "nudDungDiem";
            nudDungDiem.Size = new Size(209, 27);
            nudDungDiem.TabIndex = 23;
            // 
            // txtTongHD
            // 
            txtTongHD.Location = new Point(176, 44);
            txtTongHD.Name = "txtTongHD";
            txtTongHD.Size = new Size(209, 27);
            txtTongHD.TabIndex = 22;
            txtTongHD.TextChanged += txtTongHD_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 48);
            label11.Name = "label11";
            label11.Size = new Size(142, 20);
            label11.TabIndex = 4;
            label11.Text = "Tổng Tiền Hóa Đơn:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 96);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 3;
            label10.Text = "Dùng Điểm:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 143);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 2;
            label9.Text = "Dùng Voucher:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 186);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 1;
            label5.Text = "Qùa Sinh Nhật:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXuatHoaDon);
            groupBox2.Controls.Add(txtKhachCanTra);
            groupBox2.Controls.Add(txtTienGiamTru);
            groupBox2.Controls.Add(txtTongTienHang);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(573, 385);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 303);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tổng Thanh Toán ";
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.Location = new Point(176, 222);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(141, 45);
            btnXuatHoaDon.TabIndex = 32;
            btnXuatHoaDon.Text = "Xuất Hóa Đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtKhachCanTra
            // 
            txtKhachCanTra.Location = new Point(176, 164);
            txtKhachCanTra.Name = "txtKhachCanTra";
            txtKhachCanTra.Size = new Size(209, 27);
            txtKhachCanTra.TabIndex = 31;
            // 
            // txtTienGiamTru
            // 
            txtTienGiamTru.Location = new Point(176, 113);
            txtTienGiamTru.Name = "txtTienGiamTru";
            txtTienGiamTru.Size = new Size(209, 27);
            txtTienGiamTru.TabIndex = 30;
            // 
            // txtTongTienHang
            // 
            txtTongTienHang.Location = new Point(176, 59);
            txtTongTienHang.Name = "txtTongTienHang";
            txtTongTienHang.Size = new Size(209, 27);
            txtTongTienHang.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 62);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 29;
            label12.Text = "Tổng Tiền Hàng:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 116);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 28;
            label13.Text = "Tiền Giảm Trừ:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 167);
            label14.Name = "label14";
            label14.Size = new Size(105, 20);
            label14.TabIndex = 27;
            label14.Text = "Khách Cần Trả:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtQuyDiemChung);
            groupBox4.Controls.Add(txtHangGiaDinh);
            groupBox4.Controls.Add(txtTongChiTieuNhom);
            groupBox4.Controls.Add(txtSoLuongThanhVien);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(mstSdtChuHo);
            groupBox4.Controls.Add(btnTaoNhom);
            groupBox4.Controls.Add(btnTimNhom);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label20);
            groupBox4.Location = new Point(1038, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(571, 204);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông Tin Nhóm:";
            // 
            // txtQuyDiemChung
            // 
            txtQuyDiemChung.Location = new Point(186, 171);
            txtQuyDiemChung.Name = "txtQuyDiemChung";
            txtQuyDiemChung.Size = new Size(229, 27);
            txtQuyDiemChung.TabIndex = 43;
            // 
            // txtHangGiaDinh
            // 
            txtHangGiaDinh.Location = new Point(186, 138);
            txtHangGiaDinh.Name = "txtHangGiaDinh";
            txtHangGiaDinh.Size = new Size(229, 27);
            txtHangGiaDinh.TabIndex = 42;
            // 
            // txtTongChiTieuNhom
            // 
            txtTongChiTieuNhom.Location = new Point(186, 105);
            txtTongChiTieuNhom.Name = "txtTongChiTieuNhom";
            txtTongChiTieuNhom.Size = new Size(229, 27);
            txtTongChiTieuNhom.TabIndex = 41;
            // 
            // txtSoLuongThanhVien
            // 
            txtSoLuongThanhVien.Location = new Point(186, 72);
            txtSoLuongThanhVien.Name = "txtSoLuongThanhVien";
            txtSoLuongThanhVien.Size = new Size(229, 27);
            txtSoLuongThanhVien.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(28, 138);
            label17.Name = "label17";
            label17.Size = new Size(109, 20);
            label17.TabIndex = 39;
            label17.Text = "Hạng Gia Đình:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(28, 174);
            label16.Name = "label16";
            label16.Size = new Size(124, 20);
            label16.TabIndex = 38;
            label16.Text = "Qũy Điểm Chung:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 108);
            label15.Name = "label15";
            label15.Size = new Size(148, 20);
            label15.TabIndex = 37;
            label15.Text = "Tổng Chi Tiêu Nhóm:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(28, 75);
            label19.Name = "label19";
            label19.Size = new Size(152, 20);
            label19.TabIndex = 36;
            label19.Text = "Số Lượng Thành Viên:";
            // 
            // mstSdtChuHo
            // 
            mstSdtChuHo.Location = new Point(126, 31);
            mstSdtChuHo.Mask = "0000000000";
            mstSdtChuHo.Name = "mstSdtChuHo";
            mstSdtChuHo.Size = new Size(289, 27);
            mstSdtChuHo.TabIndex = 35;
            // 
            // btnTaoNhom
            // 
            btnTaoNhom.Location = new Point(433, 66);
            btnTaoNhom.Name = "btnTaoNhom";
            btnTaoNhom.Size = new Size(113, 33);
            btnTaoNhom.TabIndex = 25;
            btnTaoNhom.Text = "Tạo Nhóm";
            btnTaoNhom.UseVisualStyleBackColor = true;
            btnTaoNhom.Click += btnTaoNhom_Click;
            // 
            // btnTimNhom
            // 
            btnTimNhom.Location = new Point(433, 28);
            btnTimNhom.Name = "btnTimNhom";
            btnTimNhom.Size = new Size(113, 33);
            btnTimNhom.TabIndex = 24;
            btnTimNhom.Text = "Tìm Nhóm";
            btnTimNhom.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 34);
            label18.Name = "label18";
            label18.Size = new Size(92, 20);
            label18.TabIndex = 4;
            label18.Text = "SĐT Chủ Hộ:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(28, 109);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThemThanhVien);
            groupBox3.Controls.Add(lvThanhVienNhom);
            groupBox3.Controls.Add(mstNhapSdtMoi);
            groupBox3.Controls.Add(label21);
            groupBox3.Location = new Point(1038, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(565, 247);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Đóng Góp Của Thành Viên ";
            // 
            // btnThemThanhVien
            // 
            btnThemThanhVien.Location = new Point(167, 59);
            btnThemThanhVien.Name = "btnThemThanhVien";
            btnThemThanhVien.Size = new Size(132, 33);
            btnThemThanhVien.TabIndex = 44;
            btnThemThanhVien.Text = "Thêm Thành Viên";
            btnThemThanhVien.UseVisualStyleBackColor = true;
            // 
            // lvThanhVienNhom
            // 
            lvThanhVienNhom.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvThanhVienNhom.FullRowSelect = true;
            lvThanhVienNhom.GridLines = true;
            lvThanhVienNhom.Location = new Point(28, 104);
            lvThanhVienNhom.Name = "lvThanhVienNhom";
            lvThanhVienNhom.Size = new Size(518, 129);
            lvThanhVienNhom.TabIndex = 46;
            lvThanhVienNhom.UseCompatibleStateImageBehavior = false;
            lvThanhVienNhom.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "SĐT";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Họ Tên";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Chi Tiêu (VNĐ)";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Lượt Mua";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Vai Trò";
            // 
            // mstNhapSdtMoi
            // 
            mstNhapSdtMoi.Location = new Point(167, 26);
            mstNhapSdtMoi.Mask = "0000000000";
            mstNhapSdtMoi.Name = "mstNhapSdtMoi";
            mstNhapSdtMoi.Size = new Size(248, 27);
            mstNhapSdtMoi.TabIndex = 45;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(28, 29);
            label21.Name = "label21";
            label21.Size = new Size(109, 20);
            label21.TabIndex = 44;
            label21.Text = "Nhập SĐT Mới:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lvKhoVoucherGiaDinh);
            groupBox5.Controls.Add(label22);
            groupBox5.Location = new Point(1038, 501);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(565, 188);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kho Voucher";
            // 
            // lvKhoVoucherGiaDinh
            // 
            lvKhoVoucherGiaDinh.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10 });
            lvKhoVoucherGiaDinh.FullRowSelect = true;
            lvKhoVoucherGiaDinh.GridLines = true;
            lvKhoVoucherGiaDinh.Location = new Point(28, 26);
            lvKhoVoucherGiaDinh.Name = "lvKhoVoucherGiaDinh";
            lvKhoVoucherGiaDinh.Size = new Size(518, 146);
            lvKhoVoucherGiaDinh.TabIndex = 5;
            lvKhoVoucherGiaDinh.UseCompatibleStateImageBehavior = false;
            lvKhoVoucherGiaDinh.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Voucher";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Ghi Chú";
            columnHeader10.Width = 300;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(19, 26);
            label22.Name = "label22";
            label22.Size = new Size(0, 20);
            label22.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 461);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(txtLuuY);
            Controls.Add(label8);
            Controls.Add(txtDiemKhaDung);
            Controls.Add(label7);
            Controls.Add(txtHangThe);
            Controls.Add(label6);
            Controls.Add(mtbSdt);
            Controls.Add(lvDanhSach);
            Controls.Add(txtTimKH);
            Controls.Add(label4);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(nudDiem);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDungDiem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHoTen;
        private NumericUpDown nudDiem;
        private Button btnThem;
        private Button btnCapNhat;
        private Label label4;
        private TextBox txtTimKH;
        private ListView lvDanhSach;
        private MaskedTextBox mtbSdt;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtHangThe;
        private Label label6;
        private TextBox txtDiemKhaDung;
        private Label label7;
        private TextBox txtLuuY;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label5;
        private RadioButton rdbTangSui;
        private RadioButton rdbGiam50k;
        private ComboBox cbDungVoucher;
        private NumericUpDown nudDungDiem;
        private TextBox txtTongHD;
        private TextBox txtKhachCanTra;
        private TextBox txtTienGiamTru;
        private TextBox txtTongTienHang;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnXuatHoaDon;
        private GroupBox groupBox4;
        private Label label18;
        private Label label20;
        private Button btnTimNhom;
        private Button btnTaoNhom;
        private Label label19;
        private MaskedTextBox mstSdtChuHo;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtQuyDiemChung;
        private TextBox txtHangGiaDinh;
        private TextBox txtTongChiTieuNhom;
        private TextBox txtSoLuongThanhVien;
        private GroupBox groupBox3;
        private ListView lvThanhVienNhom;
        private MaskedTextBox mstNhapSdtMoi;
        private Label label21;
        private GroupBox groupBox5;
        private Label label22;
        private Button btnThemThanhVien;
        private ListView lvKhoVoucherGiaDinh;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}
