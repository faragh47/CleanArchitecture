using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common.Utilities
{
    public enum SortingDataErrorEnum
    {
        [Display(Name = "عملیات با موفقیت انجام شد")]
        Success = 1,
        [Display(Name = "عبوری")]
        Transient = 2,
        [Display(Name = "NoData")]
        NoData = 3,
        [Display(Name = "بلاتکلیف")]
        Undecided = 4,
        [Display(Name = "بیش از یک قراداد جاری برای این بارکد وجود دارد")]
        ErrMoreThan1InProcessContract = 5,
        [Display(Name = "مرسوله در تحویل، تحویل دهنده نیست")]
        ErrNotInDelivererDelivery = 6,
        [Display(Name = "موفق دارای نمایندگی")]
        SuccessWithBranch = 7,
        [Display(Name = "موفق دارای شهر")]
        SuccessWithCity = 8,
        [Display(Name = "عملیات تحویل گرفتن با خطا مواجه شد")]
        ErrAccepting = 9,
        [Display(Name = "قرارداد جاری برای این بارکد وجود ندارد")]
        ErrNoInProcessContract = 10,
        [Display(Name = "مرسوله دارای شهر مقصد نیست")]
        ErrNoDestinationCity = 11,
        [Display(Name = "Unknown Error")]
        ErrUnknown = -99999
    }
}
