using System.Collections.Generic;
using eCommerceSoa.Domain.Common;
using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Domain.Master.Coupon
{
    public class Coupon
    {
        public long CouponId { get; set; }

        public string Code { get; set; }

        public long Count { get; set; }

        public Date StartDate { get; set; }
        public Date EndDate { get; set; }

        public string TimeZone { get; set; }

        public IList<ProductCategory> ProductCategories { get; set; }
    }
}
