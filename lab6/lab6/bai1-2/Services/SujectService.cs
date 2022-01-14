using lab3.Models;
using System.Collections.Generic;

namespace lab3.services
{
    public class SubjectService : List<SubjectModel>
    {
        public SubjectService()
        {
            Add(new SubjectModel()
            {
                Name = "THIẾT KẾ ĐỒ HOẠ",
                Image = "dohoa.jfif"
            });

            Add(new SubjectModel()
            {
                Name = "LẬP TRÌNH MÁY TÍNH - THIẾT BỊ DI ĐỘNG",
                Image = "didong.png"
            });
            Add(new SubjectModel()
            {
                Name = "THIẾT KẾ WEDSITE",
                Image = "wedsite.jfif"
            });
            Add(new SubjectModel()
            {
                Name = "CNTT - ỨNG DỤNG PHẦN MỀM",
                Image = "udpm.jfif"
            });
        }
    }



}

