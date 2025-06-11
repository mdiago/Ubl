/*
    This file is part of the Ubl (R) project.
    Copyright (c) 2025-2026 Irene Solutions SL
    Authors: Irene Solutions SL.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    IRENE SOLUTIONS SL. IRENE SOLUTIONS SL DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS
    
    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.
    
    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the Ubl software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving Ubl XML data on the fly in a web application, shipping Ubl
    with a closed source product.
    
    For more information, please contact Irene Solutions SL. at this
    address: info@irenesolutions.com
 */

using System;
using System.Xml.Serialization;
using Ubl.Xml.Oasis.Cbc;

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe a set of payment terms.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public partial class PaymentTerms
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this set of payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// An identifier for a means of payment associated with these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] PaymentMeansID { get; set; }

        /// <summary>
        /// An identifier for a reference to a prepaid payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PrepaidPaymentReferenceID { get; set; }

        /// <summary>
        /// Free-form text conveying information that is not contained explicitly in other structures.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Note { get; set; }

        /// <summary>
        /// A code signifying the event during which these terms are offered.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ReferenceEventCode { get; set; }

        /// <summary>
        /// The percentage for the settlement discount that is offered for payment under these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal SettlementDiscountPercent { get; set; }

        /// <summary>
        /// The penalty for payment after the settlement period, expressed as a percentage of the payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal PenaltySurchargePercent { get; set; }

        /// <summary>
        /// The part of a payment, expressed as a percent, relevant for these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal PaymentPercent { get; set; }

        /// <summary>
        /// The monetary amount covered by these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The amount of a settlement discount offered for payment under these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount SettlementDiscountAmount { get; set; }

        /// <summary>
        /// The monetary amount of the penalty for payment after the settlement period.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount PenaltyAmount { get; set; }

        /// <summary>
        /// The Uniform Resource Identifier (URI) of a document providing additional details regarding these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PaymentTermsDetailsURI { get; set; }

        /// <summary>
        /// The due date for these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime PaymentDueDate { get; set; }

        /// <summary>
        /// The due date for an installment payment for these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime InstallmentDueDate { get; set; }

        /// <summary>
        /// A reference to the payment terms used by the invoicing party. This may have been requested of the payer by the payee to accompany its remittance.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string InvoicingPartyReference { get; set; }

        /// <summary>
        /// The period during which settlement may occur.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period SettlementPeriod { get; set; }

        /// <summary>
        /// The period during which penalties may apply.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period PenaltyPeriod { get; set; }

        /// <summary>
        /// The currency exchange rate for purposes of these payment terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ExchangeRate ExchangeRate { get; set; }

        /// <summary>
        /// 	The period during which these payment terms are valid.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period ValidityPeriod { get; set; }

        #endregion

    }

}
