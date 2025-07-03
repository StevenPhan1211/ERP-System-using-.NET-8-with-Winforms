﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Application.DTOs
{
    public class InsuranceDto
    {
        public int MaBH { get; set; }         // Mã bảo hiểm
        public int MaNV { get; set; }         // Mã nhân viên
        public string LoaiBH { get; set; } = null!;
        public string SoBH { get; set; } = null!;
        public string? BenhVien { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string TinhTrang => NgayHetHan >= DateTime.Today
            ? "Còn hiệu lực"
            : "Hết hiệu lực";
    }

    public class InsuranceInputDto
    {
        [Required(ErrorMessage = "Mã nhân viên là bắt buộc")]
        public int MaNV { get; set; }

        [Required(ErrorMessage = "Loại bảo hiểm không được bỏ trống")]
        [StringLength(10, ErrorMessage = "Loại bảo hiểm không vượt quá 10 ký tự")]
        public string LoaiBH { get; set; } = null!;

        [Required(ErrorMessage = "Số bảo hiểm không được bỏ trống")]
        [StringLength(20, ErrorMessage = "Số bảo hiểm không vượt quá 20 ký tự")]
        public string SoBH { get; set; } = null!;

        public string? BenhVien { get; set; }

        [Required(ErrorMessage = "Ngày cấp là bắt buộc")]
        public DateTime NgayCap { get; set; }

        [Required(ErrorMessage = "Ngày hết hạn là bắt buộc")]
        public DateTime NgayHetHan { get; set; }
    }
}
