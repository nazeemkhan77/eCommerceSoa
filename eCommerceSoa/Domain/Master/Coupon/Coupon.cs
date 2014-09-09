using System;
using System.Collections.Generic;
using eCommerceSoa.Domain.Common;
using eCommerceSoa.Domain.Master.Product;

namespace eCommerceSoa.Domain.Master.Coupon
{
    public class Coupon
    {
        public long Id { get; set; }

        public string Code { get; set; }

        public long MaxCount { get; set; }

        public Date StartDate { get; set; }
        public Date EndDate { get; set; }

        public TimeZone TimeZone { get; set; }

        public IList<ProductCategory> ProductCategories { get; set; }
    }
}
