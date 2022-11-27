using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Common.Utilities
{
    public static class GlobalEnums
    {

        #region Common
        public enum ContractorType
        {
            [Display(Name = "جمع آوری")]
            Pickup = 1,
            [Display(Name = "توزیع")]
            Deliver = 2,
            [Display(Name = "جمع آوری و توزیع")]
            PickupAndDelivery = 3,
        }

        #endregion

        #region Branch
        public enum BranchSearchType
        {
            HasFullAccess = 1,
            HasLimitedAccess = 2
        }

        public enum BranchType
        {
            [Display(Name = "سرپرستی")]
            Supervisor = 1,
            [Display(Name = "نمایندگی")]
            Branch = 2,
            [Display(Name = "کارپوینت/سرویس پوینت")]
            ServicePoint = 3,
            [Display(Name = "اکسس پوینت")]
            AccessPoint = 4,
            [Display(Name = "تیپاکس")]
            Tipax = 5,
            [Display(Name = "هاب")]
            Hub = 6,
            [Display(Name = "مرکز تجمیع و توزیع منطقه ای (RCDC)")]
            RCDC = 7,
            [Display(Name = "مرکز تجمیع و توزیع محلی (LCDC)")]
            LCDC = 8,
            [Display(Name = "پشتیبانی عملیات آدرس و بسته بندی")]
            PackingOperationsSupport = 9,
            [Display(Name = "پشتیبانی عملیات جمع آوری و توزیع")]
            CollectAndDistributionsSupport = 10,
            [Display(Name = "بازرسی (امنیت شبکه)")]
            Inspection = 11,
            [Display(Name = "بررسی و پیگیری")]
            FollowUp = 12,
            [Display(Name = "حمل و نقل")]
            Transportation = 13,
            [Display(Name = "نمایندگی نوین")]
            NewFranchise = 14
        }

        public enum BranchGrade
        {
            [Display(Name = "A")]
            A = 1,
            [Display(Name = "B")]
            B = 2,
            [Display(Name = "C")]
            C = 3,
            [Display(Name = "D")]
            D = 4,
        }

        #endregion

        #region People
        public enum PeopleType
        {
            [Display(Name = "حقیقی")]
            Individual = 1,
            [Display(Name = "حقوقی")]
            Company = 2
        }
        #endregion

        #region Finance
        public enum FinanceRoleType
        {
            SuperAdmin = 1,
            Vehicle = 2,
            MyBranch = 3,
            AllBranch = 4
        }
        public enum FinanceAccountType
        {
            Branch = 1,
            Vehicle = 2
        }
        public enum TransactionType
        {
            [Display(Name = "حساب های دریافتنی معمولی")]
            RegularAccount = 1,
            [Display(Name = "حساب های دریافتنی اینترنتی")]
            InternetAccounts = 2,
            [Display(Name = "حساب های دریافتنی نقدی-پسکرایه")]
            CashAccounts = 3,
        }
        public enum FinanceAccountNature
        {
            [Display(Name = "تعیین نشده")]
            NotSpecified = 1,
            [Display(Name = "بدهکار")]
            Debit = 2,
            [Display(Name = "بستانکار")]
            Credit = 3
        }
        #endregion

        #region Logistics
        public enum NetworkPathDirectionType
        {
            [Display(Name = "رفت")]
            Outbound = 1,
            [Display(Name = "برگشت")]
            Inbound = 2,
            [Display(Name = "رفت و برگشت")]
            OutboundAndInbound = 3
        }
        public enum DirectionType
        {
            [Display(Name = "رفت")]
            Outbound = 1,
            [Display(Name = "برگشت")]
            Inbound = 2,
            [Display(Name = "رفت و برگشت")]
            OutboundAndInbound = 3
        }

        public enum NetworkPathLevelType
        {
            [Display(Name = "اصلی")]
            Major = 1,
            [Display(Name = "فرعی")]
            Minor = 2
        }
        public enum LevelType
        {
            [Display(Name = "اصلی")]
            Major = 1,
            [Display(Name = "فرعی")]
            Minor = 2
        }

        public enum NetworkPathStopType
        {
            [Display(Name = "مستقیم")]
            Direct = 1,
            [Display(Name = "غیر مستقیم")]
            Indirect = 2
        }
        public enum StopType
        {
            [Display(Name = "مستقیم")]
            Direct = 1,
            [Display(Name = "غیر مستقیم")]
            Indirect = 2
        }

        public enum PlanOperationType
        {
            [Display(Name = "برنامه لجستیک")]
            LogisticPlan = 1,
            [Display(Name = "برنامه عملیاتی ترابری")]
            TransportationOperationPlan = 2
        }

        public enum OperationType
        {
            [Display(Name = "برنامه لجستیک")]
            LogisticPlan = 1,
            [Display(Name = "برنامه عملیاتی ترابری")]
            TransportationOperationPlan = 2
        }

        #endregion

        #region Order

        public enum OrderChannel
        {
            [Display(Name = "ای تیپاکس")]
            ETipax = 1,
            [Display(Name = "نمایندگی")]
            Branch = 2,
            [Display(Name = "جت")]
            JET = 3
        }

        public enum OrderDestination
        {
            Sender = 1,
            Receiver = 2,
            Both = 3
        }


        public enum OrderStackeholder
        {
            [Display(Name = "فرستنده")]
            Sender = 0,
            [Display(Name = "گیردنده")]
            Receiver = 1,
            [Display(Name = "نا مشخص")]
            Unknown = 2
        }

        public enum OrderStatus
        {
            [Display(Name = "تایید شده")]
            Confirmed = 1,
            [Display(Name = "جمع آوری شده")]
            PickedUp = 2,
            [Display(Name = "تحویل شده")]
            Delivered = 3,
            [Display(Name = "وضعیت های مختلف")]
            MultiStatus = 4,
        }

        public enum ParcelStatus
        {
            [Display(Name = "در انتظار تخصیص به نمایندگی جهت حمع آوری")]
            WatingToAssignmentForPickup = 1,
            [Display(Name = "در محدوده شبکه جهت جمع آوری نیست")]
            NotInNeworkRangeForPickup = 2,
            [Display(Name = "تخصیص یافته به نمایندگی مبدا جهت جمع آوری")]
            AssignedToBranchForPickup = 3,
            [Display(Name = "در محدوده شبکه جهت توزیع قرار ندارد")]
            NotInNeworkRangeForDelivery = 4,
            [Display(Name = "عدم تایید توسط نمایندگی جهت جمع آوری")]
            NotConfirmedByBranchForPickup = 5,
            [Display(Name = "تایید شده توسط نمایندگی جهت جمع آوری")]
            ConfirmedByBranchForPickup = 6,
            [Display(Name = "تخصیص یافته به تیپاکسیار جهت جمع آوری")]
            AssignedToTipaxyarForPickup = 7,
            [Display(Name = "جمع آوری شده")]
            PickedUp = 8,
            [Display(Name = "تحویل شده به هاب اول")]
            DeliveredToFirstHub = 9,
            [Display(Name = "تفکیک شده")]
            Sorted = 10,
            [Display(Name = "تحویل شده به حامل")]
            DeliveredToCarrier = 11,
            [Display(Name = "در حال حمل")]
            Carrying = 12,
            [Display(Name = "تحویل به هاب دوم")]
            DeliverdToSecondHub = 13,
            [Display(Name = "تحویل شده به نمایندگی مقصد")]
            DeliverdToDelivererBranch = 14,
            [Display(Name = "در مسیر توزیع")]
            AssignedToTipaxyarForDelivery = 15,
            [Display(Name = "توزیع شده")]
            Delivered = 16,
            [Display(Name = "عودتی")]
            ReturnedByRequest = 17,
            [Display(Name = "برگشت به فرستنده")]
            Returned = 18,
            [Display(Name = "بلاتکلیف")]
            Indeterminated = 19,
            [Display(Name = "جاری")]
            ContractStatus_InProcess = 20,
            [Display(Name = "مختومه_تحویل به گیرنده")]
            ContractStatus_Delivered = 21,
            [Display(Name = "ابطال شده")]
            ContractStatus_Terminated = 22,
            [Display(Name = "عودت داده شده")]
            ContractStatus_GivenBack = 23,
            [Display(Name = "پیش درخواست")]
            ContractStatus_Request = 24,
            [Display(Name = "قبول شده")]
            ContractStatus_Accepted = 25,
            [Display(Name = "جمع آوری شده")]
            ContractStatus_PickedUp = 26,
            [Display(Name = "تخصیص یافته به پیمانکار جهت جمع آوری")]
            AssignedToContractorForPickup = 27,
            [Display(Name = "در مسیر توزیع توسط پیمانکار")]
            AssignedToContractorForDelivery = 28,
            [Display(Name = "تخصیص یافته به تیپاکسیار جهت توزیع")]
            AssignedToTipaxyarForDeliver = 29,
        }

        public enum ParcelStatusStage
        {
            [Display(Name = "قبل از جمع آوری")]
            PrePickup = 1,
            [Display(Name = "بعد از جمع آوری")]
            PostPickup = 2,
        }

        public enum ParcelTotalAssigningStatus
        {
            [Display(Name = "غیره")]
            Other = 0,
            [Display(Name = "تخصیص یافته برای جمع آوری")]
            Pickup = 1,
            [Display(Name = "توزیع")]
            Deliver = 2,
            [Display(Name = "هردو")]
            Both = 3,
        }

        #endregion

        #region ParcelManagement
        public enum HandoverReceiptStatus
        {
            [Display(Name = "باز")]
            Open = 1,
            [Display(Name = "بسته")]
            Close = 2,
            [Display(Name = "بسته شده الزامی")]
            ForceClosed = 3,

        }

        public enum PackageType
        {
            [Display(Name = "پاکت کوچک")]
            SmallEnvelope = 24,
            [Display(Name = "پاکت بزرگ")]
            BigEnvelope = 18,
            [Display(Name = "پاکات")]
            Envelope = 16,

        }

        public enum ParcelEventType
        {
            [Display(Name = "درخواست جمع آوری ثبت شد")]
            CollectionRequestRegistered = 1,
            //DONE
            [Display(Name = "به نمایندگی مبدا جهت جمع آوری تخصیص شد")]
            AssignedToOriginAgencyForCollection = 2,
            //DONE
            [Display(Name = "به تیپاکس یار مبدا جهت جمع آوری تخصیص شد")]
            AllocatedToTipaxYarForCollection = 3,
            [Display(Name = "ابطال شد")]
            Canceled = 4,
            [Display(Name = "تیپاکس یار جهت جمع آوری به محل فرستنده اعزام شد")]
            TipaxYarSentForCollection = 5,
            [Display(Name = "تیاکسیار به محل فرستنده رسید")]
            TipaxYarArrivedToSender = 6,
            [Display(Name = "درخواست تغییر تیپاکسیار مبدا ثبت شد")]
            RequestToChangeTheOriginTipaxYar = 7,
            [Display(Name = "جمع آوری شد")]
            Collected = 8,
            [Display(Name = "به مرکز پردازش مبدا تحویل شد")]
            DeliveredToOriginProcessingCenter = 9,
            [Display(Name = "تفکیک شد")]
            Separated = 10,
            [Display(Name = "درخواست تعیین تکلیف صادر شد")]
            AssignmentRequestWasIssued = 11,
            [Display(Name = "به حامل تحویل شد")]
            DeliveredToCarrier = 12,
            [Display(Name = "سیر پارسل متوقف شد")]
            ParcelStopped = 13,
            [Display(Name = "به مرکز پردازش میانی تحویل شد")]
            DeliveredToIntermediateProcessingCenter = 14,
            [Display(Name = "به مرکز پردازش مقصد تحویل شد")]
            DeliveredToDestinationProcessingCenter = 15,
            //DONE
            [Display(Name = "به نمایندگی مقصد تحویل شد")]
            DeliveredToDestinationBranch = 16,
            //DONE
            [Display(Name = "به تیپاکس یار مقصد جهت توزیع تخصیص شد")]
            AllocatedToDestinationTipaxYarForDistribution = 17,
            [Display(Name = "تیپاکس یار مقصد به محل توزیع اعزام شد")]
            TipaxYarSentToDistributionPoint = 18,
            [Display(Name = "تیپاکس یار به محل توزیع رسید")]
            TipaxYarArrivedToDistributionPoint = 19,
            [Display(Name = "به گیرنده تحویل شد")]
            DeliveredToRecipient = 20,
            [Display(Name = "عودت شد")]
            SentBack = 21,
            [Display(Name = "برگشت خورد")]
            Returned = 22,
            //DONE
            [Display(Name = "لغو تخصیص بسته به نمایندگی مبدا جهت جمع آوری")]
            UnAssignedToOriginAgencyForCollection = 23,
            //DONE
            [Display(Name = "لغو تخصیص بسته به تیپاکس یار مبدا جهت جمع آوری")]
            UnAllocatedToTipaxYarForCollection = 24,
            //DONE
            [Display(Name = "لغو تخصیص بسته به نمایندگی مقصد جهت جمع آوری")]
            UnAssignedToDestinationAgencyForDistribution = 25,
            //DONE
            [Display(Name = "لغو تخصیص بسته به تیپاکس یار مقصد جهت جمع آوری")]
            UnAllocatedToDestinationTipaxYarForDistribution = 26,
            [Display(Name = "سورت عبوری")]
            SortTransient = 27,
            [Display(Name = "سورت با برنچ")]
            SortViaBranch = 28,
            [Display(Name = "سورت با شهر")]
            SortViaCity = 29,
            [Display(Name = "سورت بلاتکلیف")]
            SortUndecided = 30,
            [Display(Name = "سورت بدون دیتا")]
            SortNoData = 31,
            [Display(Name = "سورت اکسپرس")]
            SortExpress = 32,
            [Display(Name = "مرسوله در تحویل، تحویل دهنده نیست")]
            ErrNotInDelivererDelivery = 33,
            [Display(Name = "تخلیه در نمایندگی اشتباه")]
            UnLoadInWrongNode = 34,
            [Display(Name = "ثبت خرابی بسته")]
            DamageRegisteredForParcel = 35,
            [Display(Name = "بارگیری در نمایندگی اشتباه")]
            LoadInWrongNode = 36,
        }
        public enum ParcelEventLevel
        {
            [Display(Name = "اطلاعات")]
            Information = 1,
            [Display(Name = "هشدار")]
            Warning = 2,
            [Display(Name = "خطا")]
            Error = 3,
            [Display(Name = "بحران")]
            Crisis = 4,
        }
        #endregion

        #region Transportation
        public enum ActualAndTripPlanDifferenceStatus
        {
            ActualNotSubmitted = 0,
            Early = 1,
            Okay = 2,
            WarningLate = 3,
            DangerLate = 4
        }

        public enum ConfirmationStep
        {
            [Display(Name = "ترابری")]
            Transportation = 1,
            [Display(Name = "مالی")]
            Financial = 2,
            [Display(Name = "پرداخت")]
            Paid = 3,
        }

        public enum ActualReportType
        {
            [Display(Name = "توماتیک")]
            Automatic = 1,
            [Display(Name = "دستی")]
            Manual = 2,
        }

        public enum NodeIndex
        {
            [Display(Name = "شروع")]
            Start = 1,
            [Display(Name = "میانی")]
            Middle = 2,
            [Display(Name = "پایانی")]
            End = 3,
        }

        public enum ConfirmStatus
        {
            [Display(Name = "در انتظار تایید")]
            Pending = 1,
            [Display(Name = "تایید شده")]
            Confirmed = 2,
            [Display(Name = "تایید نشده")]
            Rejected = 3,
            [Display(Name = "همه")]
            All = 4,
        }

        public enum BOLIssuerServiceProvider
        {
            [Display(Name = "آبادان")]
            Abadan = 1,
        }

        public enum BillOfLadingStatus
        {
            [Display(Name = "ثبت ناموفق")]
            RegisterFail = 1,
            [Display(Name = "ثبت موفق")]
            RegisterSuccess = 2,
            [Display(Name = "درخواست بارنامه ناموفق")]
            RequestFail = 3,
            [Display(Name = "درخواست بارنامه")]
            RequestSuccess = 4,
            [Display(Name = "لغو بارنامه")]
            Cancel = 5,
            [Display(Name = "لغو بارنامه  ناموفق")]
            CancelFail = 6,
            [Display(Name = "صدور بارنامه ناموفق")]
            RequestIssueFail = 7,
            [Display(Name = "بارنامه صادر شده")]
            RequestIssued = 8,
        }

        public enum TripStatusStage
        {
            [Display(Name = "ترابری")]
            Transportation = 1,
            [Display(Name = "مالی")]
            Financial = 2,
        }

        public enum TripStatus
        {
            [Display(Name = "سفر  برنامه ریزی شده")]
            PlannedTrip = 1,
            [Display(Name = "در حال سفر")]
            OnTrip = 2,
            [Display(Name = "پایان سفر")]
            FinishTrip = 3,
            [Display(Name = "تسویه حساب")]
            CheckOut = 4,
        }


        public enum TripEventType
        {
            [Display(Name = "سفر  برنامه ریزی شده")]
            PlannedTrip = 1,
            [Display(Name = "ورود به مرکز بارگیری مبدا")]
            EnterFirstNode = 2,
            [Display(Name = "سفر قطعی شده")]
            ConfirmedTrip = 3,
            [Display(Name = "پلمپ")]
            Seal = 4,
            [Display(Name = "خروج از مبدا و شروع سفر")]
            StartedTrip = 5,
            [Display(Name = "ورود به مرکز تخلیه بارگیری")]
            EnterNode = 6,
            [Display(Name = "در حال تخلیه و بارگیری")]
            LoadingAndUnLoading = 7,
            [Display(Name = "خروج از مرکز تخلیه و بارگیری")]
            ExistNode = 8,
            [Display(Name = "حوادث")]
            Disaster = 9,
            [Display(Name = "ورود به مرکز مبادالت مقصد")]
            EnterDestinationLoad = 10,
            [Display(Name = "شروع عملیات تخلیه در مقصد")]
            StartUnloadingInDestination = 11,
            [Display(Name = "اختتام سفر")]
            FinishTrip = 12,
            [Display(Name = "تایید شده توسط ترابری برای پرداخت")]
            ApprovedByShippingForPayment = 13,
            [Display(Name = "عدم تایید ترابری")]
            NonApprovalOfTransportation = 14,
            [Display(Name = "تایید مالی")]
            FinancialApproved = 15,
            [Display(Name = "عدم تایید مالی")]
            FinancialUnpproved = 16,
            [Display(Name = "پرداخت شده")]
            Payed = 17,
            [Display(Name = "عملیات فک پلمپ با شماره اشتباه")]
            UnSealWithWrongSealNumber = 18,
            [Display(Name = "عملیات تخلیه بارگیری در نود اشتباه")]
            UnknownNodeInLoadingAndUnLoading = 19,
            [Display(Name = "فک پلمپ")]
            UnSeal = 20,

        }

        public enum SealStatus
        {
            [Display(Name = "پلمپ شده")]
            Sealed = 1,
            [Display(Name = "فک پلمپ")]
            UnSealed = 2,
        }


        public enum ScaleType
        {
            [Display(Name = "توان")]
            Toman = 0,

            [Display(Name = "روز")]
            Day = 1,

            [Display(Name = "درصد")]
            Percent = 2,

            [Display(Name = "فقره")]
            Item = 3,

            [Display(Name = "عدد")]
            Number = 4,

            [Display(Name = "دیوایس")]
            Device = 5,

            [Display(Name = "ساعت")]
            Hour = 6,

            [Display(Name = "امتیاز")]
            Point = 7,

        }

        public enum StatusTripFinancial
        {
            [Display(Name = "تعرفه مسیر")]
            TripFinancial = 1,
            [Display(Name = "توقف")]
            StopCity = 2,
            [Display(Name = "راننده اضافه")]
            Driver = 3,
            [Display(Name = "هزینه بارنامه")]
            BillOfLading = 4,
            [Display(Name = "مبلغ توافقی")]
            AgreedPrice = 5,
        }


        public enum StatusTransportationTariffCostType
        {
            [Display(Name = "راننده اضافه")]
            Drivers = 1,
            [Display(Name = "استاپ سیتی")]
            StopCity = 2,

        }

        #endregion

        #region Time
        public enum TimeDuration
        {
            [Display(Name = "در دیتابیس موجود نمی باشد.")]
            NotUsedInDatabase00 = 0,
            [Display(Name = "2 هفته")]
            Days14 = 1,
            [Display(Name = "1 هفته")]
            Days07 = 2,
            [Display(Name = "6 روز")]
            Days06 = 3,
            [Display(Name = "5 روز")]
            Days05 = 4,
            [Display(Name = "4 روز")]
            Days04 = 5,
            [Display(Name = "3 روز")]
            Days03 = 6,
            [Display(Name = "2 روز")]
            Days02 = 7,
            [Display(Name = "1 روز")]
            Days01 = 8,
            [Display(Name = "18 ساعت")]
            Hours18 = 9,
            [Display(Name = "12 ساعت")]
            Hours12 = 10,
            [Display(Name = "11 ساعت")]
            Hours11 = 11,
            [Display(Name = "10 ساعت")]
            Hours10 = 12,
            [Display(Name = "9 ساعت")]
            Hours09 = 13,
            [Display(Name = "8 ساعت")]
            Hours08 = 14,
            [Display(Name = "7 ساعت")]
            Hours07 = 15,
            [Display(Name = "6 ساعت")]
            Hours06 = 16,
            [Display(Name = "5 ساعت")]
            Hours05 = 17,
            [Display(Name = "4 ساعت")]
            Hours04 = 18,
            [Display(Name = "3 ساعت")]
            Hours03 = 19,
            [Display(Name = "2 ساعت")]
            Hours02 = 20,
            [Display(Name = "1.5 ساعت")]
            Minutes90 = 21,
            [Display(Name = "1 ساعت")]
            Hours01 = 22,
            [Display(Name = "45 دقیقه")]
            Minutes45 = 23,
            [Display(Name = "30 دقیقه")]
            Minutes30 = 24,
            [Display(Name = "20 دقیقه")]
            Minutes20 = 25,
            [Display(Name = "15 دقیقه")]
            Minutes15 = 26,
            [Display(Name = "10 دقیقه")]
            Minutes10 = 27,
            [Display(Name = "5 دقیقه")]
            Minutes05 = 28,
            [Display(Name = "0 دقیقه")]
            Minutes00 = 29
        }
        public enum StatisticPeriodTime
        {
            [Display(Name = "هفتگی")]
            Weekly = 0,
            [Display(Name = "ماهانه")]
            Montly = 1,
            [Display(Name = "سالانه")]
            Yearly = 2,
        }
        #endregion

        #region Ticket
        public enum TicketStatus
        {
            [Display(Name = "باز")]
            Open = 1,
            [Display(Name = "بسته")]
            Close = 2,
            [Display(Name = "در حال بررسی")]
            InProgress = 3,
        }

        public enum TicketPriority
        {
            [Display(Name = "مهم")]
            Critical = 1,
            [Display(Name = "عادی")]
            Normal = 2,
            [Display(Name = "کم اهمیت")]
            NotImportant = 3,
        }
        #endregion

        #region Product
        public enum ProductType
        {
            [Display(Name = "بسته بندی")]
            Packing = 1,
        }

        public enum ProductOrderStatus
        {
            [Display(Name = "تایید شده")]
            Approved = 1,
            [Display(Name = "عدم تایید")]
            NotApproved = 2,
            [Display(Name = "در انتظار تایید")]
            WaitingForApprove = 3,
        }
        #endregion

        #region Complaint
        public enum CustomerType
        {
            [Display(Name = "قراردادی")]
            Contractual = 1,
            [Display(Name = "عمومی")]
            General = 2,
            [Display(Name = "حقوقی")]
            Company = 3,
            [Display(Name = "شعب")]
            Branches = 4,
            [Display(Name = "سایر")]
            Other = 5,
        }
        public enum ComplaintStatus
        {
            [Display(Name = "جاری")]
            InProgress = 1,
            [Display(Name = "ارجاع")]
            Referenced = 2,
            [Display(Name = "تکمیل")]
            Complete = 3,
            [Display(Name = "در انتظار صورتجلسه سازش")]
            WaitingForMinute = 4,
            [Display(Name = "کمیسیون")]
            Commission = 6,
            [Display(Name = "جبران خسارت")]
            Compensation = 7,
            [Display(Name = "ارجاع به مالی")]
            ReferToFinantial = 8,
            [Display(Name = "ارجاع به تنخواه")]
            ReferToFund = 9,
            [Display(Name = "ارجاع به QC")]
            ReferToQC = 10,
            [Display(Name = "مختومه")]
            Closed = 11,
            [Display(Name = "سایر")]
            Other = 12,
        }
        public enum ComplaintState
        {
            [Display(Name = "اتمام فرآیند")]
            CompleteProcess = 1,
            [Display(Name = "ارجاع به بخش شکایت")]
            ReferToComplaintSection = 2,
            [Display(Name = "ارجاع به بازاریابی")]
            ReferToMarketing = 3,
            [Display(Name = "ارجاع به پشتیبان مای تیپاکس")]
            ReferToMyTipaxSupport = 4,
            [Display(Name = "ارجاع به بين الملل")]
            ReferToInternational = 5,
            [Display(Name = "ثبت از وب سایت")]
            RegisteredFromWebsite = 6,
            [Display(Name = "ارجاع به مای تیپاکس")]
            ReferToMyTipax = 7,
            [Display(Name = "درحال پیگیری")]
            InProgress = 8,
            [Display(Name = "ارجاع به فروش نمايندگان")]
            ReferToSales = 9,
            [Display(Name = "ارجاع به امور قراردادی")]
            ReferToContractualMatters = 10,
            [Display(Name = "ارجاع به شکایت")]
            ReferToComplaint = 11,
            [Display(Name = "توضیحات تکمیلی")]
            FurtherDetails = 15,
        }

        #endregion

        #region Application
        public enum ApplicationType
        {
            [Display(Name = "وب اپلیکیشن")]
            WebApplication = 1,
            [Display(Name = "اندروید اپلیکشن IGT")]
            AndroidApplicationIGT = 2,
            [Display(Name = "اندروید اپلیکشن IGT_Beta")]
            AndroidApplicationIGTBeta = 3,
            [Display(Name = "اندروید اپلیکشن Jet")]
            AndroidApplicationJet = 4,
        }
        public enum ArticleElementType
        {
            [Display(Name = "عنوان")]
            Title = 1,
            [Display(Name = "پاراگراف")]
            Paragraph = 2,
            [Display(Name = "عکس")]
            Image = 3
        }
        public enum ArticleType
        {
            [Display(Name = "راهنما")]
            Help = 1,
            [Display(Name = "ورژن")]
            ApplicationVersion = 2,
        }
        #endregion

        #region Polygon
        public enum GisLayers
        {
            [Display(Name = "اکسپرس زمینی-فعال")]
            RoadExpressActive = 1,
            [Display(Name = "اکسپرس زمینی-مصوب")]
            RoadExpressDesign = 2,
            [Display(Name = "محدوده جغرافیایی مسفا")]
            MasfaGeofence = 3,
            //[Display(Name = "نیو فرنچایزیی")]
            //NewFranchise = 4
        }
        #endregion

        #region Sort Type
        public enum ShootType
        {
            [Display(Name = "نرمال")]
            Normal = 1,
            [Display(Name = "عبوری")]
            Transient = 2,
            [Display(Name = "NoData")]
            NoData = 3,
            [Display(Name = "بلاتکلیف")]
            UnDecided = 4,
            [Display(Name = "اکسپرس")]
            Express = 5
        }
        #endregion

        #region Default Lines
        public enum DefaultLines
        {
            [Display(Name = "لاین 0")]
            zero = 0,
        }

        #endregion

        #region Sorting data status
        public enum SortingDataStatus
        {
            [Display(Name = "موفق")]
            Success = 1,
            [Display(Name = "نا موفق")]
            Failed = 2,
            [Display(Name = "رفع اشکال شده")]
            Resolved = 3,
        }

        #endregion

        #region DamageSubject
        public enum DamageSubject
        {
            [Display(Name = "آسیب بسته بندی")]
            Packaging = 1,
            [Display(Name = "خسارت محتویات")]
            Content = 2,
            [Display(Name = "کسر محتویات")]
            Fraction = 3,
        }
        #endregion

        #region DamageType
        public enum DamageType
        {
            [Display(Name = "پارگی")]
            Ripped = 1,
            [Display(Name = "ترکیدگی")]
            Cracked = 2,
            [Display(Name = "خیس شدگی")]
            Soaked = 3,
            [Display(Name = "شکستگی")]
            Broken = 4,
            [Display(Name = "له شدگی")]
            Squashed = 5,
            [Display(Name = "ساییدگی")]
            Abrasion = 6,
        }
        #endregion

        #region DamageReason
        public enum DamageReason
        {
            [Display(Name = "بارگیری نامناسب")]
            Loading = 1,
            [Display(Name = "بسته بندی نامناسب")]
            Packaging = 2,
            [Display(Name = "مرسوله دیگر")]
            OtherParcel = 3,
            [Display(Name = "عدم تطابق محتویات با بسته بندی")]
            UnMatched = 4,
        }
        #endregion

        #region DamageStep
        public enum DamageStep
        {
            [Display(Name = "حمل و نقل به تی هاب")]
            THub = 1,
            [Display(Name = "تی هاب به تیپاکسیار")]
            THubToTipaxAssistance = 2,
            [Display(Name = "تی هاب به راننده")]
            THubToDraver = 3,
            [Display(Name = "حمل و نقل به سوپروایزر")]
            Supervisor = 4,
            [Display(Name = "حمل و نقل به نمایندگی")]
            Branch = 5,
        }
        #endregion

        #region Damage Sign Confirmation Status
        public enum DamageSignConfirmationStatus
        {
            [Display(Name = "تایید نشده")]
            Rejected = 1,
            [Display(Name = "تایید شده")]
            Confirmed = 2,
            [Display(Name = "امتناع از تایید")]
            Refused = 3,
            [Display(Name = "تایید سوپروایزر")]
            ConfirmedbySupervisor = 4,
            [Display(Name = "تایید با سمت سوپروایزر")]
            ConfirmedbySupervisorRole = 5,
            [Display(Name = "تایید با سمت تی هاب")]
            ConfirmedbyTHubRole = 6,
            [Display(Name = "تایید با سمت تنظیم کننده")]
            ConfirmedbyDeliveryRole = 7,
            [Display(Name = "تایید با سمت تحویل گیرنده")]
            ConfirmedbyReceiverRole = 8
        }
        #endregion

        #region Signature Type
        public enum SignatureType
        {
            [Display(Name = "خسارت")]
            Damage = 1,
        }
        #endregion

        #region Damage role
        public enum DamageRole
        {
            [Display(Name = "تنظیم کننده")]
            Doer = 1,
            [Display(Name = "ناظر")]
            Controller = 2,
            [Display(Name = "تحویل دهنده")]
            Delivery = 3,
            [Display(Name = "تحویل گیرنده")]
            Receiver = 4,
        }
        #endregion

        #region Server Type
        public enum ServerType
        {
            [Display(Name = "https://igttestapi.tipax.ir")]
            Development = 1,
            [Display(Name = "https://igtstagingapi.tipax.ir")]
            Staging = 2,
            [Display(Name = "https://integrationapi.tipax.ir")]
            Production = 3,
        }

        #endregion

    }
}