using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Session
{
    private static Session instance;

    // Các thuộc tính của phiên
    public string Email { get; set; }
    public string UserName { get; set; }//maThanhVien

    public string Name;

    public byte[] Avatar;
    public bool laQuanLi { get; set; }

    public bool laTruongNhom { get; set; }

    public bool laCEO { get; set; }

    public bool daNghiViec { get; set; }

    // Hàm khởi tạo private để ngăn chặn việc tạo đối tượng từ bên ngoài lớp
    private Session() { }

    // Phương thức static để truy xuất đến đối tượng Session
    public static Session Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }
    }
}


