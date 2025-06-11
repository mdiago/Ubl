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

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe the condition or position of an object.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Status
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Specifies the status condition of the related object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ConditionCode { get; set; }

        /// <summary>
        /// The reference date for this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ReferenceDate { get; set; }

        /// <summary>
        /// The reference time for this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime ReferenceTime { get; set; }

        /// <summary>
        /// Text describing this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        /// <summary>
        /// The reason for this status condition or position, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string StatusReasonCode { get; set; }

        /// <summary>
        /// The reason for this status condition or position, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] StatusReason { get; set; }

        /// <summary>
        /// A sequence identifier for this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string SequenceID { get; set; }

        /// <summary>
        /// Provides any textual information related to this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Text { get; set; }

        /// <summary>
        /// Specifies an indicator relevant to a specific status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool IndicationIndicator { get; set; }

        /// <summary>
        /// A percentage meaningful in the context of this status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal Percent { get; set; }

        /// <summary>
        /// The reliability of this status, expressed as a percentage.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal ReliabilityPercent { get; set; }

        /// <summary>
        /// Measurements that quantify the condition of the objects covered by the status.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Condition> Condition { get; set; }

        #endregion

    }

}