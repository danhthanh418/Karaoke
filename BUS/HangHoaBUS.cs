﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class HangHoaBUS
    {
        public static List<HangHoa> XemHangHoa(int loai, int pageNumber, int pageSize,int loaiChiTiet=0)
        {
            return DAO.HangHoaDAO.XemHangHoa(loai, pageNumber, pageSize, loaiChiTiet);
        }
        public static List<HangHoa> XemHangHoaGoiMon(int loai, int pageNumber, int pageSize)
        {
            return DAO.HangHoaDAO.XemHangHoaGoiMon(loai, pageNumber, pageSize);
        }
        
        public static int DemHangHoa(int loai,int loaiChiTiet=0)
        {
            return DAO.HangHoaDAO.DemHangHoa(loai,loaiChiTiet);
        }
        public static int DemHangHoaGoiMon(int loai)
        {
            return DAO.HangHoaDAO.DemHangHoaGoiMon(loai);
        }
        public static List<LoaiHangHoa> XemLoaiMon(int loai)
        {
            return DAO.HangHoaDAO.XemLoaiMon(loai);
        }
    }
}
