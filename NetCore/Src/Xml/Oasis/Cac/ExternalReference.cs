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

    #region Propiedades Públicas de Instancia

    /// <summary>
    /// A class to describe an external object, such as a document stored at a remote location.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class ExternalReference
    {

        /// <summary>
        /// The Uniform Resource Identifier (URI) that identifies the external object as an Internet resource.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string URI { get; set; }

        /// <summary>
        /// A hash value for the externally stored object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DocumentHash { get; set; }

        /// <summary>
        /// A hash algorithm used to calculate the hash value of the externally stored object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HashAlgorithmMethod { get; set; }


        /// <summary>
        /// The date on which availability of the resource can no longer be relied upon.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The time after which availability of the resource can no longer be relied upon.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime ExpiryTime { get; set; }

        /// <summary>
        /// A code signifying the mime type of the external object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MimeCode { get; set; }

        /// <summary>
        /// A code signifying the format of the external object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string FormatCode { get; set; }

        /// <summary>
        /// A code signifying the encoding/decoding algorithm used with the external object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string EncodingCode { get; set; }

        /// <summary>
        /// A code signifying the character set of an external document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CharacterSetCode { get; set; }

        /// <summary>
        /// The file name of the external object.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string FileName { get; set; }

        /// <summary>
        /// <para> Text describing the external object.</para>
        /// <para> Sample: computer accessories for laptops</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        #endregion

    }

}