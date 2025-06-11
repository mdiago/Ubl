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
    /// <para> A class to define a credit card, debit card, or charge card account.</para>
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class CardAccount
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// <para> An identifier of the card (e.g., the Primary Account Number (PAN)).</para>
        /// <para> Sample: 4558 XXXX XXXX XXXX (a real card number)</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PrimaryAccountNumberID { get; set; }

        /// <summary>
        /// <para> An identifier for the financial service network provider of the card.</para>
        /// <para> Sample: VISA, MasterCard, American Express.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string NetworkID { get; set; }

        /// <summary>
        /// <para> A mutually agreed code signifying the type of card. Examples of types are "debit", "credit" and "purchasing".</para>
        /// <para> Sample: Debit Card, Credit Card, Procurement Card.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CardTypeCode { get; set; }

        /// <summary>
        /// The date from which the card is valid.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ValidityStartDate { get; set; }

        /// <summary>
        /// The date on which the card expires.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// An identifier for the institution issuing the card.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string IssuerID { get; set; }

        /// <summary>
        /// An identifier for the card, specified by the issuer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string IssueNumberID { get; set; }

        /// <summary>
        /// An identifier for the Card Verification Value (often found on the reverse of the card itself).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CV2ID { get; set; }

        /// <summary>
        /// A mutually agreed code to distinguish between CHIP and MAG STRIPE cards.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CardChipCode { get; set; }

        /// <summary>
        /// An identifier on the chip card for the application that provides the quoted information; an AID (application ID).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ChipApplicationID { get; set; }

        /// <summary>
        /// The name of the cardholder.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HolderName { get; set; }

        #endregion

    }

}