using AppQuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.ViewModel
{
    internal class SinhVienViewModel
    {
        public int ID { get; set; }

        public string MaSinhVien { get; set; }

        public string HoDem { get; set; }

        public string Ten { get; set; }

        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        public string QueQuan { get; set; }

        public int? IDLopHoc { get; set; }


        /// <summary>
        /// Lấy toàn bộ sinh viên
        /// </summary>
        /// <returns></returns>
        public static List<SinhVienViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.SinhVien.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                MaSinhVien = e.MaSinhVien,
                HoDem = e.HoDem,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh,
                QueQuan = e.QueQuan,
                IDLopHoc = e.IDLopHoc,

            }).ToList();

            return rs;
        }

        public static List<SinhVienViewModel> GetList(int idLopHoc)
        {
            var db = new AppDBContext();
            var rs = db.SinhVien
                .Where(e => e.IDLopHoc == idLopHoc)
                .Select(e => new SinhVienViewModel
                {
                    ID = e.ID,
                    GioiTinh = e.GioiTinh,
                    MaSinhVien = e.MaSinhVien,
                    HoDem = e.HoDem,
                    Ten = e.Ten,
                    NgaySinh = e.NgaySinh,
                    QueQuan = e.QueQuan,
                    IDLopHoc = e.IDLopHoc,

                }).ToList();

            return rs;
        }

        public static void AddSinhVien(SinhVien sv)
        {
            var db = new AppDBContext();
            db.SinhVien.Add(sv);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
