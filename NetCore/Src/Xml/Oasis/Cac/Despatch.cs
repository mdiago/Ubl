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
    /// A class to describe the despatching of goods (their pickup for delivery).
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Despatch
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this despatch event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// The despatch (pickup) date requested, normally by the buyer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime RequestedDespatchDate { get; set; }

        /// <summary>
        /// The despatch (pickup) time requested, normally by the buyer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime RequestedDespatchTime { get; set; }

        /// <summary>
        /// The estimated despatch (pickup) date.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime EstimatedDespatchDate { get; set; }

        /// <summary>
        /// The estimated despatch (pickup) time.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime EstimatedDespatchTime { get; set; }

        /// <summary>
        /// The actual despatch (pickup) date.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ActualDespatchDate { get; set; }

        /// <summary>
        /// The actual despatch (pickup) time.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime ActualDespatchTime { get; set; }

        /// <summary>
        /// The date guaranteed for the despatch (pickup).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime GuaranteedDespatchDate { get; set; }

        /// <summary>
        /// The time guaranteed for the despatch (pickup).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime GuaranteedDespatchTime { get; set; }

        /// <summary>
        /// An identifier for the release of the despatch used as security control or cargo control (pick-up).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ReleaseID { get; set; }

        /// <summary>
        /// <para> 	Text describing any special instructions applying to the despatch (pickup).</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Instructions { get; set; }

        /// <summary>
        /// The address of the despatch (pickup).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address DespatchAddress { get; set; }

        /// <summary>
        /// The location of the despatch (pickup).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location DespatchLocation { get; set; }

        /// <summary>
        ///	The party despatching the goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party DespatchParty { get; set; }

        /// <summary>
        /// The party carrying the goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party CarrierParty { get; set; }

        /// <summary>
        /// A party to be notified of this despatch (pickup).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Party> NotifyParty { get; set; }

        /// <summary>
        /// The primary contact for this despatch (pickup).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The period estimated for the despatch (pickup) of goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period EstimatedDespatchPeriod { get; set; }

        /// <summary>
        /// The period requested for the despatch (pickup) of goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period RequestedDespatchPeriod { get; set; }

        #endregion

    }

}