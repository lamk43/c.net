﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong,
    }
    public class TenGoiViewModel
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public int? ID_Nhom { get; set; }
    }
}
