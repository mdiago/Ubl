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
    /// A class to describe a price, expressed in a data structure containing multiple properties (compare with UnstructuredPrice).
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Price
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The amount of the price.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount PriceAmount { get; set; }

        /// <summary>
        /// The quantity at which this price applies.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity BaseQuantity { get; set; }

        /// <summary>
        /// A reason for a price change.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] PriceChangeReason { get; set; }

        /// <summary>
        /// The type of price, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PriceTypeCode { get; set; }

        /// <summary>
        /// The type of price, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PriceType { get; set; }

        /// <summary>
        /// The factor by which the base price unit can be converted to the orderable unit.
        /// Nails are priced by weight but ordered by quantity. So this would say how many nails per kilo.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal OrderableUnitFactorRate { get; set; }

        /// <summary>
        /// A period during which this price is valid.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Period> ValidityPeriod { get; set; }

        /// <summary>
        /// Information about a price list applicable to this price.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public PriceList PriceList { get; set; }

        /// <summary>
        /// An allowance or charge associated with this price.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<AllowanceCharge> AllowanceCharge { get; set; }

        /// <summary>
        /// The exchange rate applicable to this price, if it differs from the exchange rate applicable to the document as a whole.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ExchangeRate PricingExchangeRate { get; set; }

        #endregion

    }

}