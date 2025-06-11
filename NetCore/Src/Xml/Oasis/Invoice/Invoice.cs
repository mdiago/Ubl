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
using Ubl.Xml.Oasis.Cac;

namespace Ubl.Xml.Oasis.Invoice
{

    /// <summary>
    /// A document used to request payment.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceInvoice)]
    [XmlRoot(Namespace = Namespaces.NamespaceInvoice, IsNullable = false)]
    public class Invoice
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type
        /// that defines all of the elements that might be encountered in the current instance.
        /// Identifier.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string UBLVersionID { get; set; }

        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// Identifier.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CustomizationID { get; set; }

        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// Identifier.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ProfileID { get; set; }

        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// Identifier.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ProfileExecutionID { get; set; }

        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// Identifier.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// Indicator.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool CopyIndicator { get; set; }

        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// Identifier.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string UUID { get; set; }

        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// Date.Type
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// Time.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime IssueTime { get; set; }

        /// <summary>
        /// The date on which Invoice is due.
        /// Date.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// A code signifying the type of the Invoice.
        /// Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// Text.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Note { get; set; }

        /// <summary>
        /// The date of the Invoice, used to indicate the point at which tax becomes applicable.
        /// Date.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime TaxPointDate { get; set; }

        /// <summary>
        /// A code signifying the default currency for this document.
        /// Currency_ Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DocumentCurrencyCode { get; set; }

        /// <summary>
        /// A code signifying the default currency for this document.
        /// Currency_ Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TaxCurrencyCode { get; set; }

        /// <summary>
        /// A code signifying the currency used for prices in the Invoice.
        /// Currency_ Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PricingCurrencyCode { get; set; }

        /// <summary>
        /// A code signifying the currency used for payment in the Invoice.
        /// Currency_ Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PaymentCurrencyCode { get; set; }

        /// <summary>
        /// A code signifying the alternative currency used for payment in the Invoice.
        /// Currency_ Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PaymentAlternativeCurrencyCode { get; set; }

        /// <summary>
        /// The buyer's accounting code, applied to the Invoice as a whole.
        /// Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountingCostCode { get; set; }

        /// <summary>
        /// The buyer's accounting code, applied to the Invoice as a whole, expressed as text.
        /// Text.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountingCost { get; set; }

        /// <summary>
        /// The number of lines in the document.
        /// Numeric.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public int LineCountNumeric { get; set; }

        /// <summary>
        /// A reference provided by the buyer used for internal routing of the document.
        /// Text.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BuyerReference { get; set; }

        /// <summary>
        /// A period to which the Invoice applies.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period InvoicePeriod { get; set; }

        /// <summary>
        /// A reference to the Order with which this Invoice is associated.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public OrderReference OrderReference { get; set; }

        /// <summary>
        /// A reference to a billing document associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public BillingReference BillingReference { get; set; }

        /// <summary>
        /// A reference to a Despatch Advice associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference DespatchDocumentReference { get; set; }

        /// <summary>
        /// A reference to a Receipt Advice associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference ReceiptDocumentReference { get; set; }

        /// <summary>
        /// A reference to a Statement associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference StatementDocumentReference { get; set; }

        /// <summary>
        /// A reference to an originator document associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference OriginatorDocumentReference { get; set; }

        /// <summary>
        /// A reference to a contract associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference ContractDocumentReference { get; set; }

        /// <summary>
        /// A reference to an additional document associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference AdditionalDocumentReference { get; set; }

        /// <summary>
        ///	Information about a project.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ProjectReference> ProjectReference { get; set; }

        /// <summary>
        /// The accounting supplier party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public SupplierParty AccountingSupplierParty { get; set; }

        /// <summary>
        /// The accounting customer party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public CustomerParty AccountingCustomerParty { get; set; }

        /// <summary>
        /// The payee.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party PayeeParty { get; set; }

        /// <summary>
        /// The buyer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public CustomerParty BuyerCustomerParty { get; set; }

        /// <summary>
        /// The seller.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public SupplierParty SellerSupplierParty { get; set; }

        /// <summary>
        /// The tax representative.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party TaxRepresentativeParty { get; set; }

        /// <summary>
        /// A delivery associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Delivery> Delivery { get; set; }

        /// <summary>
        /// A set of delivery terms associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DeliveryTerms DeliveryTerms { get; set; }

        /// <summary>
        /// Expected means of payment.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<PaymentMeans> PaymentMeans { get; set; }

        /// <summary>
        /// A set of payment terms associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<PaymentTerms> PaymentTerms { get; set; }

        /// <summary>
        /// A set of payment terms associated with this document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Payment> PrepaidPayment { get; set; }

        /// <summary>
        /// A discount or charge that applies to a price component.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<AllowanceCharge> AllowanceCharge { get; set; }

        /// <summary>
        /// The exchange rate between the document currency and the tax currency.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ExchangeRate TaxExchangeRate { get; set; }

        /// <summary>
        /// The exchange rate between the document currency and the pricing currency.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ExchangeRate PricingExchangeRate { get; set; }

        /// <summary>
        /// The exchange rate between the document currency and the payment currency.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ExchangeRate PaymentExchangeRate { get; set; }

        /// <summary>
        /// The exchange rate between the document currency and the payment alternative currency.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ExchangeRate PaymentAlternativeExchangeRate { get; set; }

        /// <summary>
        /// The total amount of a specific type of tax
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TaxTotal> TaxTotal { get; set; }

        /// <summary>
        /// The total amount payable on the Invoice, including Allowances, Charges, and Taxes.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public MonetaryTotal LegalMonetaryTotal { get; set; }

        /// <summary>
        /// A line describing an invoice item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<InvoiceLine> InvoiceLine { get; set; }

        #endregion

    }

}