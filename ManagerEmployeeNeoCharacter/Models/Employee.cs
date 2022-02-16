using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagerEmployeeNeoCharacter.Models
{
    public class SearchParameterModel
    {

        [Display(Name = "Search By Terrritory")]
        public string LastName
        {
            get;

            set;
        }
        public string Format
        {
            get;

            set;
        }

    }
  

    public class Employee
    {
        private string m_LastName;
        private string m_FirstMidName;
        private string m_EnetrDate;
        private string m_NameFather;

        public int EmployeeID
        {
            get;

            set;
        }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "نام خانوادگی")]
        [StringLength(100, ErrorMessage = "لطفا به اندازه 100 حروف وارد کنید.")]
        public string LastName
        {
            get { return m_LastName; }

            set { value = m_LastName; }
        }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "نام")]
        [StringLength(50, ErrorMessage = "لطفا به اندازه 50 حروف وارد کنید.")]
        public string FirstMidName
        {
            get { return m_FirstMidName; }

            set { value = m_FirstMidName; }
        }




        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "تاریخ ورود")]
        public string EnetrDate
        {
            get { return m_EnetrDate; }

            set { value = m_EnetrDate; }
        }



        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "نام پدر")]
        public string NameFather
        {
            get { return m_NameFather; }

            set { value = m_NameFather; }
        }

        [Display(Name = "تاریخ تولد")]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "شماره شناسنامه")]
        public string BirthCertificateNumber { get; set; }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "تلفن منزل")]
        public string HomeTell { get; set; }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "تلفن همراه")]
        public string MobileTell { get; set; }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "آدرس منزل")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "آدرس محل کار")]
        public string OfficeAddress { get; set; }

       

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "شغل مورد نظر در شرکت")]
        public string TheCompanyJobs { get; set; }

        [Required(ErrorMessage = "لطفا اطلاعات را تکمیل کنید.")]
        [Display(Name = "استان محل اقامت")]
        public string Province { get; set; }

        public string FullName
        {
            get { return LastName + " " + FirstMidName; }
        }

        public virtual ICollection<Neo> Neos { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Statuss> Statusss { get; set; }


         public Employee()  { }

         public Employee(string lastName, string firstMidName, string enetrDate, string nameFather)
            {
                m_LastName = lastName;
                m_FirstMidName = firstMidName;
                m_EnetrDate = enetrDate;
                m_NameFather = nameFather;

          
            }
    }
}