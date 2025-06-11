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
    /// A class that refers to a phase of work. Used for instance to specify what part of the contract the billing is referring to.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class WorkPhaseReference
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this phase of work.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// A code signifying this phase of work.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string WorkPhaseCode { get; set; }

        /// <summary>
        /// <para> Text describing this phase of work.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] WorkPhase { get; set; }

        /// <summary>
        /// The progress percentage of the work phase.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal ProgressPercent { get; set; }

        /// <summary>
        /// The date on which this phase of work begins.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date on which this phase of work ends.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// A reference to a document regarding the work order for the project in which this phase of work takes place.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DocumentReference> WorkOrderDocumentReference { get; set; }

        #endregion

    }

}