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
    /// A class to define the subtotal for a particular tax category within a particular taxation scheme, such as standard rate within VAT.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    public class TaxSubtotal
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The net amount to which the tax percent (rate) is applied to calculate the tax amount.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount TaxableAmount { get; set; }

        /// <summary>
        /// The amount of this tax subtotal.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount TaxAmount { get; set; }

        /// <summary>
        /// The number of this tax subtotal in the sequence of subtotals corresponding to the
        /// order in which multiple taxes are applied. If all taxes are applied to the same
        /// taxable amount (i.e., their order of application is inconsequential),
        /// then CalculationSequenceNumeric is 1 for all tax subtotals applied to a given amount.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public int CalculationSequenceNumeric { get; set; }

        /// <summary>
        /// The amount of this tax subtotal, expressed in the currency used for invoicing.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount TransactionCurrencyTaxAmount { get; set; }

        /// <summary>
        /// The tax rate of the tax category applied to this tax subtotal, expressed as a percentage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal Percent { get; set; }

        /// <summary>
        /// The unit of measure on which the tax calculation is based
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BaseUnitMeasure { get; set; }

        /// <summary>
        /// Where a tax is applied at a certain rate per unit, the rate per unit applied.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount PerUnitAmount { get; set; }

        /// <summary>
        /// Where a tax is tiered, the range of taxable amounts that determines the rate of tax applicable to this tax subtotal.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TierRange { get; set; }

        /// <summary>
        /// Where a tax is tiered, the tax rate that applies within a specified range of taxable amounts for this tax subtotal.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal TierRatePercent { get; set; }

        /// <summary>
        /// The tax category applicable to this subtotal.
        /// </summary>
        public TaxCategory TaxCategory { get; set; }

        #endregion

    }

}