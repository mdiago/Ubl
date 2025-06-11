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
    /// A class to define an exchange rate.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class ExchangeRate
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The reference currency for this exchange rate; the currency from which the exchange is being made.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string SourceCurrencyCode { get; set; }

        /// <summary>
        /// In the case of a source currency with denominations of small value, the unit base.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal SourceCurrencyBaseRate { get; set; }

        /// <summary>
        /// The target currency for this exchange rate; the currency to which the exchange is being made.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TargetCurrencyCode { get; set; }

        /// <summary>
        /// In the case of a target currency with denominations of small value, the unit base.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal TargetCurrencyBaseRate { get; set; }

        /// <summary>
        /// An identifier for the currency exchange market used as the source of this exchange rate.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ExchangeMarketID { get; set; }

        /// <summary>
        /// The factor applied to the source currency to calculate the target currency.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal CalculationRate { get; set; }

        /// <summary>
        /// A code signifying whether the calculation rate is a multiplier or a divisor.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MathematicOperatorCode { get; set; }

        /// <summary>
        /// The date on which the exchange rate was established.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// A contract for foreign exchange.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Contract ForeignExchangeContract { get; set; }

        #endregion

    }

}