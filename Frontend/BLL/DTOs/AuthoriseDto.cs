﻿using System;

namespace ERP.Application.DTOs
{
    public class AuthoriseDto
    {
        public string MaVaiTro { get; set; } = null!;
        public int MaQuyen { get; set; }
        public string? TenQuyen { get; set; }
        public string? HanhDong { get; set; }
    }

    public class AuthoriseInputDto
    {
        public string MaVaiTro { get; set; } = null!;
        public int MaQuyen { get; set; }
        public string? HanhDong { get; set; }
    }
}
