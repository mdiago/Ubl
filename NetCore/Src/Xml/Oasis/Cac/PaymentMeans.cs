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

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe a means of payment.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class PaymentMeans
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// A code signifying the type of this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PaymentMeansCode { get; set; }

        /// <summary>
        /// 	The date on which payment is due for this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime PaymentDueDate { get; set; }

        /// <summary>
        /// A code signifying the payment channel for this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PaymentChannelCode { get; set; }

        /// <summary>
        /// An identifier for the payment instruction.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string InstructionID { get; set; }

        /// <summary>
        /// Free-form text conveying information that is not contained explicitly in other structures.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] InstructionNote { get; set; }

        /// <summary>
        /// An identifier for a payment made using this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] PaymentID { get; set; }

        /// <summary>
        /// A credit card, debit card, or charge card account that constitutes this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public CardAccount CardAccount { get; set; }

        /// <summary>
        /// The payer's financial account.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public FinancialAccount PayerFinancialAccount { get; set; }

        /// <summary>
        /// The payee's financial account.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public FinancialAccount PayeeFinancialAccount { get; set; }

        /// <summary>
        /// A credit account associated with this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public CreditAccount CreditAccount { get; set; }

        /// <summary>
        ///	The payment mandate associated with this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public PaymentMandate PaymentMandate { get; set; }

        /// <summary>
        ///	A trade finance agreement applicable to this means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TradeFinancing TradeFinancing { get; set; }

        #endregion

    }

}