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
    /// A class to describe a specific property of an item.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class ItemProperty
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this property of an item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// The name of this item property.
        /// Energy Rating , Collar Size , Fat Content
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Name { get; set; }

        /// <summary>
        /// The name of this item property, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string NameCode { get; set; }

        /// <summary>
        /// The method of testing the value of this item property.
        /// 100 watts , 15 European , 20% +/- 5%
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TestMethod { get; set; }

        /// <summary>
        /// The value of this item property, expressed as text.
        /// 100 watts , 15 European , 20% +/- 5%
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Value { get; set; }

        /// <summary>
        /// 	The value of this item property, expressed as a quantity.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity ValueQuantity { get; set; }

        /// <summary>
        /// <para> Text qualifying the value of the property.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] ValueQualifier { get; set; }

        /// <summary>
        /// A code signifying the importance of this property in using it to describe a related Item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ImportanceCode { get; set; }

        /// <summary>
        /// <para> The value expressed as a text in case the property is a value in a list. For example, a colour.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] ListValue { get; set; }

        /// <summary>
        /// The period during which this item property is valid.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period UsabilityPeriod { get; set; }

        /// <summary>
        ///A description of the property group to which this item property belongs.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ItemPropertyGroup> ItemPropertyGroup { get; set; }

        /// <summary>
        /// The range of values for the dimensions of this property.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Dimension RangeDimension { get; set; }

        /// <summary>
        /// A range of values for this item property.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public ItemPropertyRange ItemPropertyRange { get; set; }

        #endregion

    }

}