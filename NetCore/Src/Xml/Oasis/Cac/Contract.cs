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
    /// A class to describe a contract.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Contract
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this contract.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// The date on which this contract was issued.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// The time at which this contract was issued.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime IssueTime { get; set; }

        /// <summary>
        /// In a transportation contract, the deadline date by which the services
        /// referred to in the transport execution plan have to be booked.
        /// For example, if this service is a carrier service scheduled for
        /// Wednesday 16 February 2011 at 10 a.m. CET, the nomination date
        /// might be Tuesday15 February 2011.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime NominationDate { get; set; }

        /// <summary>
        /// In a transportation contract, the deadline time by which the services
        /// referred to in the transport execution plan have to be booked.
        /// For example, if this service is a carrier service scheduled for
        /// Wednesday 16 February 2011 at 10 a.m. CET, the nomination date
        /// might be Tuesday15 February 2011 and the nomination time 4 p.m. at the latest.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime NominationTime { get; set; }

        /// <summary>
        /// The type of this contract, expressed as a code, such as
        /// "Cost plus award fee" and "Cost plus fixed fee" from UNCEFACT
        /// Contract Type code list.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ContractTypeCode { get; set; }

        /// <summary>
        /// The type of this contract, expressed as text, such as
        /// "Cost plus award fee" and "Cost plus fixed fee" from
        /// UNCEFACT Contract Type code list.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ContractType { get; set; }

        /// <summary>
        /// <para> Free-form text conveying information that is not contained explicitly in other structures.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Note { get; set; }

        /// <summary>
        /// 	An identifier for the current version of this contract.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string VersionID { get; set; }

        /// <summary>
        /// <para>Text describing this contract.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        /// <summary>
        /// The period during which this contract is valid.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period ValidityPeriod { get; set; }

        /// <summary>
        /// A reference to a contract document.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DocumentReference> ContractDocumentReference { get; set; }

        /// <summary>
        /// In a transportation contract, the period required to book the services specified in the contract before the services can begin.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period NominationPeriod { get; set; }

        /// <summary>
        /// In a transportation contract, the delivery of the services required to book the services specified in the contract.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Delivery ContractualDelivery { get; set; }

        #endregion

    }

}