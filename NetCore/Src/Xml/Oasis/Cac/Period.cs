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
    /// A class to describe a period of time.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Period
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The date on which this period begins.
        /// Date.Type
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The time at which this period begins.
        /// Time.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The date on which this period ends.
        /// Date.Type
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The time at which this period ends.
        /// Time.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The duration of this period, expressed as an ISO 8601 code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DurationMeasure { get; set; }

        /// <summary>
        ///  A description of this period, expressed as a code.
        /// Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DescriptionCode { get; set; }

        /// <summary>
        /// A description of this period, expressed as text.
        /// Text.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Description { get; set; }

        #endregion

    }

}