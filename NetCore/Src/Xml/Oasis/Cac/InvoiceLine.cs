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
using System.Collections.Generic;
using System.Xml.Serialization;
using Ubl.Xml.Oasis.Cbc;

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to define a line in an Invoice.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public partial class InvoiceLine
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// A universally unique identifier for this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string UUID { get; set; }

        /// <summary>
        /// <para> Free-form text conveying information that is not contained explicitly in other structures.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Note { get; set; }

        /// <summary>
        /// The quantity (of items) on this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity InvoicedQuantity { get; set; }

        /// <summary>
        /// The total amount for this invoice line, including allowance charges but net of taxes.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount LineExtensionAmount { get; set; }

        /// <summary>
        /// The date of this invoice line, used to indicate the point at which tax becomes applicable.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime TaxPointDate { get; set; }

        /// <summary>
        /// The buyer's accounting cost centre for this invoice line, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountingCostCode { get; set; }

        /// <summary>
        /// The buyer's accounting cost centre for this invoice line, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountingCost { get; set; }

        /// <summary>
        /// A code signifying the business purpose for this payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PaymentPurposeCode { get; set; }

        /// <summary>
        /// An indicator that this invoice line is free of charge (true) or not (false). The default is false.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool FreeOfChargeIndicator { get; set; }

        /// <summary>
        /// An invoice period to which this invoice line applies.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Period> InvoicePeriod { get; set; }

        /// <summary>
        /// A reference to an order line associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<OrderLineReference> OrderLineReference { get; set; }

        /// <summary>
        /// A reference to an order line associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<LineReference> DespatchLineReference { get; set; }

        /// <summary>
        /// A reference to a receipt line associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<LineReference> ReceiptLineReference { get; set; }

        /// <summary>
        /// A reference to a billing document associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<BillingReference> BillingReference { get; set; }

        /// <summary>
        /// A reference to a document associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DocumentReference> DocumentReference { get; set; }

        /// <summary>
        /// A reference to a document associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public PricingReference PricingReference { get; set; }

        /// <summary>
        /// The party who originated the Order to which the Invoice is related.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party OriginatorParty { get; set; }

        /// <summary>
        /// A delivery associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Delivery> Delivery { get; set; }

        /// <summary>
        /// A specification of payment terms associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<PaymentTerms> PaymentTerms { get; set; }

        /// <summary>
        /// An allowance or charge associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<AllowanceCharge> AllowanceCharge { get; set; }

        /// <summary>
        /// A total amount of taxes of a particular kind applicable to this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TaxTotal> TaxTotal { get; set; }

        /// <summary>
        /// A reference to a TaxTotal class describing the amount that has been withhold by the authorities, e.g. if the creditor is in dept because of non paid taxes.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TaxTotal> WithholdingTaxTotal { get; set; }

        /// <summary>
        /// The item associated with this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Item Item { get; set; }

        /// <summary>
        /// The price of the item associated with this invoice line.
        /// Unit Price, Base Price
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Price Price { get; set; }

        /// <summary>
        /// Terms and conditions of the delivery associated with this invoice line. 
        /// </summary>
        public DeliveryTerms DeliveryTerms { get; set; }

        /// <summary>
        /// An invoice line subsidiary to this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<InvoiceLine> SubInvoiceLine { get; set; }

        /// <summary>
        /// The price extension, calculated by multiplying the price per unit by the quantity of items on this invoice line.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public PriceExtension ItemPriceExtension { get; set; }

        #endregion

    }

}