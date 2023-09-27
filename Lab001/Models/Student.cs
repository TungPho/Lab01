using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Lab001.Models
{
	public class Student
	{
        public int Id { get; set; }//Mã sinh viên
        
        [Required(ErrorMessage = "Bắt buộc phải nhập tên")]
        public string? Name { get; set; } //Họ tên
        
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string? Email { get; set; } //Email
        
        
        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage = "Mật khẩu là bắt buộc và có độ dài ít nhất 8 ký tự")]
        public string? Password { get; set; }//Mật khẩu
        
        [Required(ErrorMessage = "Ngành học bắt buộc phải nhập")]
        public Branch? Branch { get; set; }//Ngành học
        
        [Required(ErrorMessage = "Giới tính bắt buộc phải được nhập")]
        public Gender? Gender { get; set; }//Giới tính
        
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        public string? Address { get; set; }//Địa chỉ
        
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh bắt buộc phải được nhập")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập từ 0.0 tới 10.0")]
		[Range(0.0, 10.0)]
        [Column(TypeName ="decimal(2,2)")]		
        public decimal Points { get; set; }

       
    }
}
