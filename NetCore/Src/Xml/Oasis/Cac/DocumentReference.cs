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
    /// A class to define a reference to a document.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class DocumentReference
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for the referenced document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// An indicator that the referenced document is a copy (true) or the original (false).
        /// Indicator.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool CopyIndicator { get; set; }

        /// <summary>
        /// A universally unique identifier for this document reference.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string UUID { get; set; }

        /// <summary>
        /// The date, assigned by the sender of the referenced document, on which the document was issued.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// The time, assigned by the sender of the referenced document, at which the document was issued.
        /// Time.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime IssueTime { get; set; }

        /// <summary>
        /// The type of document being referenced, expressed as a code.
        /// Code.Type.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DocumentTypeCode { get; set; }

        /// <summary>
        /// The type of document being referenced, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DocumentType { get; set; }

        /// <summary>
        /// A reference to another place in the same XML document instance in which DocumentReference appears.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string XPath { get; set; }

        /// <summary>
        /// An identifier for the language used in the referenced document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LanguageID { get; set; }

        /// <summary>
        /// A code signifying the locale in which the language in the referenced document is used.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LocaleCode { get; set; }

        /// <summary>
        /// An identifier for the current version of the referenced document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string VersionID { get; set; }

        /// <summary>
        /// A code signifying the status of the reference document with respect to its original state.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DocumentStatusCode { get; set; }

        /// <summary>
        /// <para> Text describing the referenced document.</para>
        /// <para> Sample: stock no longer provided</para>
        /// </summary>
        public string[] DocumentDescription { get; set; }
        
        #endregion

    }

}