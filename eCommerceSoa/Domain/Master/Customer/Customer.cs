using System.Collections.Generic;
using Domain.Common;
using Domain.Transaction;

namespace Domain.Master.Customer
{
    public class Customer
    {
        /// <summary>
        /// Customer record identifier
        /// </summary>
        public long CustomerId { get; private set; }

        /// <summary>
        /// Customer first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customer middle name
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Customer gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Customer date of birth
        /// </summary>
        public Date DateofBirth { get; set; }

        /// <summary>
        /// Customer email address
        /// </summary>
        public Email EmailAddress { get; set; }

        /// <summary>
        /// List of customer addresses
        /// </summary>
        public IList<CustomerAddress> Addresses { get; set; }

        /// <summary>
        /// List of customer phones
        /// </summary>
        public IList<CustomerPhone> Phone { get; set; }

        /// <summary>
        /// List of customer faxes
        /// </summary>
        public IList<Fax> Fax { get; set; }

        public ShoppingCart Cart { get; set; }

        public CustomerPaymentOption PaymentOptions { get; set; }
    }
}
