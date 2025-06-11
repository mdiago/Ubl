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
    /// A class to describe one of the tax categories within a taxation scheme (e.g., High Rate VAT, Low Rate VAT).
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class TaxCategory
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this tax category.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// The name of this tax category.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Name { get; set; }

        /// <summary>
        /// The tax rate for this category, expressed as a percentage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal Percent { get; set; }

        /// <summary>
        /// Where a tax is applied at a certain rate per unit, the rate per unit applied.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount PerUnitAmount { get; set; }

        /// <summary>
        /// The reason for tax being exempted, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TaxExemptionReasonCode { get; set; }

        /// <summary>
        /// The reason for tax being exempted, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] TaxExemptionReason { get; set; }

        /// <summary>
        /// Where a tax is tiered, the range of taxable amounts that determines the rate of tax applicable to this tax category.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TierRange { get; set; }

        /// <summary>
        /// Where a tax is tiered, the tax rate that applies within the specified range of taxable amounts for this tax category.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal TierRatePercent { get; set; }

        /// <summary>
        /// The taxation scheme within which this tax category is defined.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TaxScheme TaxScheme { get; set; }

        #endregion

    }

}