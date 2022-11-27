using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Common
{
    public enum ApiResultStatusCode
    {
        [Display(Name = "عملیات با موفقیت انجام شد")]
        Success = 0,

        [Display(Name = "خطایی در سرور رخ داده است")]
        ServerError = 1,

        [Display(Name = "پارامتر های ارسالی معتبر نیستند")]
        BadRequest = 2,

        [Display(Name = "یافت نشد")]
        NotFound = 3,

        [Display(Name = "لیست خالی است")]
        ListEmpty = 4,

        [Display(Name = "خطایی در پردازش رخ داد")]
        LogicError = 5,

        [Display(Name = "خطای احراز هویت")]
        UnAuthorized = 6,

        [Display(Name = "نام یا نام خانوادگی الزامی است")]
        FirstNameOrLastNameIsRequired = 7,

        [Display(Name = "کد ملی الزامی است")]
        NationalIdIsRequired = 8,

        [Display(Name = "نام کاربری تکراری است")]
        UserNameIsExists = 9,

        [Display(Name = "نام الزامیست")]
        NameIsRequired = 10,

        [Display(Name = "نام تکراری است")]
        NameIsExists = 11,

        [Display(Name = "درج نقش با خطا مواجه شد")]
        RoleCreationFailed = 12,

        [Display(Name = "نام کاربری یا رمز عبور اشتباه است")]
        UserNameOrPasswordIsWrong = 13,

        [Display(Name = "OAuth flow is not password")]
        OAuthFlowIsNotPassword = 14,

        [Display(Name = "کد ملی تکراری است")]
        NationalIdExists = 15,

        [Display(Name = "خطا در درج اطلاعات")]
        InsertFailed = 16,

        [Display(Name = "نام شرکت الزامیست")]
        CompanyNameIsREquired = 17,

        [Display(Name = "نام شرکت تکراری است")]
        CompanyNameExists = 18,

        [Display(Name = "اطلاعات شخص حقیقی یا حقوقی باید پر شده باشد")]
        CompanyOrIndividualIsRequired = 18,

        [Display(Name = "شماره پلاک تکراری است")]
        PlateNumberExists = 19,

        [Display(Name = "این شخص قبلا به عنوان راننده ثبت شده است")]
        DriverExists = 20,

        [Display(Name = "اطلاعات شخص الزامیست")]
        PersonInfoIsRequired = 21,

        [Display(Name = "این شخص قبلا به در این نمایندگی ثبت شده است")]
        PersonAlreadyExistsInThisBranch = 22,

        [Display(Name = "فرمت کد ملی اشتباه است")]
        NationalCodeFormatIsWrong = 23,

        [Display(Name = "تعداد رکورد درخواستی شما بیش از حد مجاز است")]
        MaximumRecordsPerPageExceeded = 24,

        [Display(Name = "حداقل یک شماره موبایل الزامیست")]
        AtleastOneMobileNoRequired = 25,

        [Display(Name = "نوع شخص وارد شده معتبر نیست")]
        PersonTypeIsWrong = 26,

        [Display(Name = "شماره موبایل تکراری است")]
        MobileExists = 27,

        [Display(Name = "اطلاعات قبلا ثبت شده است")]
        InformationExists = 28,

        [Display(Name = "بروزرسانی موفقیت آمیز نبود")]
        UpdateFailed = 29,

        [Display(Name = "نام کاربری معتبر نیست")]
        UsernameIsNotValid = 30,

        [Display(Name = "تغییر رمزعبور موفقیت آمیز نبود")]
        PasswordChangeFailed = 31,

        [Display(Name = "کلمه عبور اشتباه است")]
        CurrentPasswordIsWrong = 32,

        [Display(Name = "این خودرو قبلا به این نمایندگی افزوده شده است")]
        VehicleExistsInBranch = 33,

        [Display(Name = "ثبت تنظمیات در جدول مربوطه با خطا روبرو شد")]
        InsertConfigFailed = 34,

        [Display(Name = "خطا در به روز رسانی اطلاعات پایه")]
        UpdateBasicInformationFailed = 35,

        [Display(Name = "نام نقش باید بیشتر از 4 کاراکتر باشد")]
        RoleNameLenght = 36,

        [Display(Name = "توضیحات بیشتر از ۵ کاراکتر باشد")]
        DescriptionRoleLenght = 37,

        [Display(Name = "این نقش قبلا به این کاربر اضافه شده است ")]
        ExistRoleInUser = 38,

        [Display(Name = "این کابر قبلا به این گروه اضافه شده است ")]
        ExistUserInGroup = 39,

        [Display(Name = "این نقش قبلا به این گروه اضافه شده است ")]
        ExistRoleInGroup = 40,

        [Display(Name = "این تعرفه غیر فعال است")]
        NotActiveRoutesTariff = 41,

        [Display(Name = "این تعرفه قبلا در این تاریخ اعمال ثبت شده است")]
        RoutesTariffInApplicableDateIsExist = 42,

        [Display(Name = "این اعزام ثبت نشده است")]
        TripPlanNoExist = 43,

        [Display(Name = "این راننده قبلا در لیست اعزام این تاریخ ثبت شده است")]
        DriverExistInTripPlan = 44,

        [Display(Name = "این راننده مناسب برای این اعزام نیست")]
        DriverNoExist = 45,

        [Display(Name = "این ماشین مناسب برای این اعزام نیست")]
        VehicleNoExist = 46,

        [Display(Name = "این ماشین قبلا در این اعزام ثبت نشده است")]
        VehicleNoExistInTripPlan = 47,

        [Display(Name = "این مسیرمناسب برای این اعزام نیست")]
        PlanRouteNoExist = 48,

        [Display(Name = "این ماشین قبلا در لیست اعزام این تاریخ ثبت شده است")]
        VehicleExistInTripPlan = 49,

        [Display(Name = "این راننده قبلا در لیست اعزام این تاریخ ثبت نشده است")]
        DriverNoExistInTripPlan = 50,

        [Display(Name = "لیست اعزام روز جاری باید خالی باشد")]
        TripPlanExistInCurrentDay = 51,

        [Display(Name = "این قرارداد در این بازه ی تاریخی با قرارداد دیگر تداخل تاریخی دارد")]
        VehicleContractExistInDate = 52,

        [Display(Name = "قرارداد فعال وجود ندارد")]
        NotActiveVehicleContract = 53,

        [Display(Name = "ایستگاه مسیر وجود ندارد")]
        RoutesBranchNoExist = 54,

        [Display(Name = "ایستگاه مسیر در این لیست اعزام وجود ندارد")]
        RoutesBranchNoExistInTripPlan = 55,

        [Display(Name = "محور وجود ندارد.")]
        NetPathIsNotFound = 56,

        [Display(Name = "محور به دلیل استفاده در مسیر قابل ویرایش نیست.")]
        NetPathIsNotEditable = 57,

        [Display(Name = "شناسه برنچ های معرفی شده در سامانه وجود ندارند .")]
        NetLinkCantConvertBranchToNode = 58,

        [Display(Name = "لینک جدید به لینکهای موجود در محور قابل وصل نیست.")]
        NetPathNewLinkIsNotChainable = 59,

        [Display(Name = "اشکال در داده های ورودی وجود دارد.")]
        InvalidInputData = 60,

        [Display(Name = "داده موجود برگردانده شد.")]
        ReturnExistingData = 61,

        [Display(Name = "نمایندگی در سامانه وجود ندارد.")]
        BranchNotFound = 62,

        [Display(Name = "مسافت یا زمان لینک جدید از لینک موجود بزرگتر است یا انتهای لینک جدید و موجود یکی است.")]
        NetLinkCanNotSplit = 63,

        [Display(Name = "محور دارای لینک مورد نظر نمی باشد.")]
        NetPathLinkIsNotFound = 64,

        [Display(Name = "برنچ مورد تقاضا ابتدا یا انتهای محور می باشد و قابل حذف نیست.")]
        NetPathLinkCanNotDeleteStartOrEndPathBranch = 65,

        [Display(Name = "ابتدای لینک منطبق بر انتهای محور یا انتهای لینک منطبق بر ابتدای محور است.")]
        NetPathAndLinkBranchConflict = 66,

        [Display(Name = "گره ابتدا و انتهای لینک یکسان است.")]
        NetLinkHasSameNodeForStartAndEnd = 67,

        [Display(Name = "محور به دلیل استفاده در لیست اعزام قابل ویرایش نیست.")]
        PlanRouteisNotEditable = 68,

        [Display(Name = "این برنامه مسیر مربوط به این تاریخ نیست")]
        PlanRouteIsNotInDate = 69,

        [Display(Name = "برای این برنامه اعزام گزارش سفری ثبت نشده است")]
        NoActualsInTripPlan = 70,

        [Display(Name = "این متد غیر فعال شده است.")]
        MethodIsDisabled = 71,

        [Display(Name = "شناسه کاربر ویرایش یا ایجاد کننده موجود نیست.")]
        CreatorOrModifierUserIdNotFound = 72,
        [Display(Name = "پلیگون پیدا نشد.")]
        PolygonNotFound = 73,
        [Display(Name = "نقطه محل نمایندگی در پلیگون نمایندگی قرار ندارد یا پلیگون نمایندگی ترسیم نشده است.")]
        BranchXYIsNotInsideItsPolygon = 74,
        [Display(Name = "شما به این بخش دسترسی ندارید")]
        Forbidden = 75,
        [Display(Name = "اطلاعات فرستنده را وارد کنید")]
        SenderNotExist = 76,
        [Display(Name = "اطلاعات گیرنده را وارد کنید")]
        ReceiverNotExist = 77,
        [Display(Name = "وارد کردن  فرستنده الزامیست")]
        SenderAddressIsRequired = 78,
        [Display(Name = "درصورت جمع آوری نمایندگی جمع آوری شده باشد انتخاب شود")]
        BranchIsRequiredInPickup = 79,
        [Display(Name = "سفارش مورد نظر یافت نشد")]
        OrderNoExist = 80,
        [Display(Name = "تیپاکس یار مورد نظر یافت نشد")]
        TipaxYarNoExist = 81,
        [Display(Name = " به این سفارش در این وضعیت اختصاص تیپاکس یار امکان پذیر نمی باشد")]
        NotAllowedTipaxYarToOrder = 82,
        [Display(Name = "در این وضعیت سفارش امکان حذف تیپاکس یار وجود ندارد")]
        NotAllowedToUnAssignedTipaxyar = 83,
        [Display(Name = "رسید تحویل موجود نمی باشد")]
        HandoverReceiptNotExist = 84,
        [Display(Name = "مرسوله موجود نمی باشد")]
        ParcelNotExist = 85,
        [Display(Name = "این مرسوله قبلا در این رسید ثبت شده است")]
        ParcelExistInReceipt = 86,
        [Display(Name = "فاقد بیمه نامه معتبر")]
        NotValidVehicleInsurance = 87,
        [Display(Name = "فاقد قرارداد معتبر")]
        NotValidVehicleContracts = 88,
        [Display(Name = "فاقد معاینه فنی معتبر")]
        NotValidVehicleTechnicalDiagnosis = 89,
        [Display(Name = "این قیمت قبلا در این تاریخ اعمال ثبت شده است")]
        PriceInApplicableDateIsExist = 90,
        [Display(Name = "این قیمت غیر فعال است")]
        NotActivePackagingPrice = 91,
        [Display(Name = "این برنامه مسیر مربوط به لیست اعزام نیست")]
        PlanRouteIsNotOperational = 92,
        [Display(Name = "محور مورد نظر وجود ندارد")]
        PlanRouteisNotExist = 93,
        [Display(Name = "برای این سفر بارنامه ثبت شده است")]
        TripBillOfLadingExist = 94,
        [Display(Name = "این سفر توسط ترابری تایید شده است")]
        TransportationConfirmation = 95,
        [Display(Name = "این عملیات برای این سفر مجاز نیست")]
        OprationNotAllowedForTrip = 96,
        [Display(Name = "مقدار درصد مالکیت بالاتر از حد مجاز است")]
        HigherPercentAllowedInOwnerBranch = 97,
        [Display(Name = "تعداد درخواست بالاتر از حد مجاز است، لطفا دقایقی دیگر تلاش کنید")]
        ToManyRequestAllowedInForgetPassword = 98,
        [Display(Name = "کد معتبر نمی باشد")]
        ForgetPasswordCodeIsNotValid = 99,
        [Display(Name = "تیکت به شما ارجاع نشده است یا شما سازنده این تیکت نیستید")]
        TicketIsNotRefered = 100,
        [Display(Name = "این شماره شبا قبلا ثبت شده است")]
        DuplicateShebaNumber = 101,
        [Display(Name = "ثبت حداقل یک راننده الزامیست")]
        DriverInTripPlanIsRequired = 102,
        [Display(Name = "حذف حساب پیش فرض امکانپذیر نیست")]
        ImpossibleAccountDelete = 104,

        [Display(Name = "خطایی در سیستم رخ داده است")]
        Failed = 105,

        [Display(Name = "رسیدی دریافت نشد")]
        ErrNoRecietInput = 106,

        [Display(Name = "بارکدی دریافت نشد")]
        ErrNoBarcodeInput = 107,

        [Display(Name = "رسیدی یافت نشد")]
        ErrNoRecietId = 108,

        [Display(Name = "پیمانکار مورد نظر یافت نشد")]
        ContractorNoExist = 109,
        [Display(Name = " به این سفارش در این وضعیت اختصاص پیمانکار امکان پذیر نمی باشد")]
        NotAllowedContractorToOrder = 110,
        [Display(Name = "در این وضعیت سفارش امکان حذف پیمانکار وجود ندارد")]
        NotAllowedToUnAssignedContractor = 111,
        [Display(Name = "به این نمایندگی کد مالی تخصیص نشده است.")]
        AccountIdNotAllocated = 112,

        [Display(Name = "کد ملی اشتباه است")]
        IncorrectNationalId = 113,
        [Display(Name = "کد ملی صحیح است")]
        CorrectNationalId = 114,

        [Display(Name = "آدرس باید ثبت شده باشد")]
        AddressMustExist = 115,

        [Display(Name = "سورت پلن در حال استفاده وجود دارد")]
        SortplanInUseExist = 116,
        [Display(Name = "شماره پلمپ یکسان نیست.")]
        SealIsNotOkay = 117,
        [Display(Name = "رسید مرسوله باید باز باشد")]
        HandoverReceiptNotOpen = 118,
        [Display(Name = "کد نمایندگی نمی تواند خالی باشد")]
        BranchIdNotExist = 119,
        
        [Display(Name = "تعداد تایید شده بزرگتر از تعداد درخواستی است")]
        ConfirmedCountIsGreaterThanRequestedCount = 120,
        [Display(Name = "محصول یافت نشد")]
        ProductNotFound = 122,
        [Display(Name = "سفارش در وضعیت در انتظار تایید نیست.")]
        OrderNotWaitingForApprove = 123,
        [Display(Name = "متن پیام تیکت نمی تواند خالی باشد.")]
        TicketDescriptionEmpty = 124,
        [Display(Name = "ایجاد تیکت با شناسه تکراری امکانپذیر نمی باشد.")]
        TicketIdExists = 125,
        [Display(Name = "قرارداد قبلا ثبت شده است")]
        OrderExists = 126,

    }
}
