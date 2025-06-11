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
    /// A class defining an identifiable collection of one or more goods
    /// items to be transported between the seller party and the buyer party.
    /// This information may be defined within a commercial contract.
    /// A shipment can be transported in different consignments
    /// (e.g., split for logistical purposes).
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class TransportEvent
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// <para> An identifier for this transport event within an agreed event identification scheme.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string IdentificationID { get; set; }

        /// <summary>
        /// The date of this transport event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime OccurrenceDate { get; set; }

        /// <summary>
        /// The time of this transport event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime OccurrenceTime { get; set; }

        /// <summary>
        /// <para> A code signifying the type of this transport event.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportEventTypeCode { get; set; }

        /// <summary>
        /// <para> The handling required for this shipment, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        /// <summary>
        /// An indicator that this transport event has been completed (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool CompletionIndicator { get; set; }

        /// <summary>
        /// The shipment involved in this transport event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Shipment ReportedShipment { get; set; }

        /// <summary>
        /// The current status of this transport event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Status> CurrentStatus { get; set; }

        /// <summary>
        /// A contact associated with this transport event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Contact> Contact { get; set; }

        /// <summary>
        /// The location associated with this transport event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location Location { get; set; }

        /// <summary>
        /// A signature that can be used to sign for an entry or
        /// an exit at a transport location (e.g., port terminal).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Signature Signature { get; set; }

        /// <summary>
        /// A period of time associated with this transport event.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Period> Period { get; set; }

        #endregion

    }

}