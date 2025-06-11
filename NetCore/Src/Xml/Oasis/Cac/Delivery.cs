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
    /// A class to describe a delivery.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Delivery
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// The quantity of items, child consignments, shipments in this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity Quantity { get; set; }

        /// <summary>
        /// The minimum quantity of items, child consignments, shipments in this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity MinimumQuantity { get; set; }

        /// <summary>
        /// The maximum quantity of items, child consignments, shipments in this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Quantity MaximumQuantity { get; set; }

        /// <summary>
        /// The actual date of delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime ActualDeliveryDate { get; set; }

        /// <summary>
        /// The actual time of delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime ActualDeliveryTime { get; set; }

        /// <summary>
        /// The latest date of delivery allowed by the buyer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "date")]
        public DateTime LatestDeliveryDate { get; set; }

        /// <summary>
        /// The latest time of delivery allowed by the buyer.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc, DataType = "time")]
        public DateTime LatestDeliveryTime { get; set; }

        /// <summary>
        /// An identifier used for approval of access to delivery locations (e.g., port terminals).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ReleaseID { get; set; }

        /// <summary>
        /// The delivery Tracking ID (for transport tracking).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TrackingID { get; set; }

        /// <summary>
        /// The delivery address.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// The delivery location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location DeliveryLocation { get; set; }

        /// <summary>
        /// An alternative delivery location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location AlternativeDeliveryLocation { get; set; }

        /// <summary>
        /// The period requested for delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period RequestedDeliveryPeriod { get; set; }

        /// <summary>
        /// The period promised for delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period PromisedDeliveryPeriod { get; set; }

        /// <summary>
        /// The period estimated for delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Period EstimatedDeliveryPeriod { get; set; }

        /// <summary>
        /// The party responsible for delivering the goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party CarrierParty { get; set; }

        /// <summary>
        /// The party to whom the goods are delivered.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party DeliveryParty { get; set; }

        /// <summary>
        ///	A party to be notified of this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Party> NotifyParty { get; set; }

        /// <summary>
        /// The despatch (pickup) associated with this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Despatch Despatch { get; set; }

        /// <summary>
        ///	Terms and conditions relating to the delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<DeliveryTerms> DeliveryTerms { get; set; }

        /// <summary>
        /// The minimum delivery unit for this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DeliveryUnit MinimumDeliveryUnit { get; set; }

        /// <summary>
        /// The maximum delivery unit for this delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DeliveryUnit MaximumDeliveryUnit { get; set; }

        /// <summary>
        /// The shipment being delivered.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Shipment Shipment { get; set; }

        #endregion

    }

}