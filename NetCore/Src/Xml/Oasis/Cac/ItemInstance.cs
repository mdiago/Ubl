﻿/*
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

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe a specific, trackable instance of an item.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class ItemInstance
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// A class to describe a specific, trackable instance of an item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ProductTraceID { get; set; }

        /// <summary>
        /// The date on which this item instance was manufactured.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ManufactureDate { get; set; }

        /// <summary>
        /// The time at which this item instance was manufactured..
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime ManufactureTime { get; set; }

        /// <summary>
        /// The date before which it is best to use this item instance.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime BestBeforeDate { get; set; }

        /// <summary>
        /// The registration identifier of this item instance.
        /// car registration or licensing number.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RegistrationID { get; set; }

        /// <summary>
        /// The serial number of this item instance.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string SerialID { get; set; }

        /// <summary>
        /// An additional property of this item instance.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<ItemProperty> AdditionalItemProperty { get; set; }

        /// <summary>
        /// The lot identifier of this item instance (the identifier that allows recall of the item if necessary).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<LotIdentification> LotIdentification { get; set; }

        #endregion

    }

}