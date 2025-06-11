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
    /// A class to describe a particular vehicle or vessel used 
    /// Conveyance
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class TransportMeans
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for the regular service schedule of this means of transport.
        /// Voyage Number, Scheduled Conveyance Identifier (WCO ID 205), Flight Number
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string JourneyID { get; set; }

        /// <summary>
        /// An identifier for the country in which this means of transport is registered.
        /// Nationality of Means of Transport (WCO 175, 178 and 179)
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RegistrationNationalityID { get; set; }

        /// <summary>
        /// <para> Text describing the country in which this means of transport is registered.</para>
        /// <para> Flag of Vessel, Nationality of Ship. Sample: Liberia.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] RegistrationNationality { get; set; }

        /// <summary>
        /// A code signifying the direction of this means of transport.
        /// Transit Direction. Sample: 	North , East
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string DirectionCode { get; set; }

        /// <summary>
        /// A code signifying the type of this means of transport (truck, vessel, etc.).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportMeansTypeCode { get; set; }

        /// <summary>
        /// A code signifying the service regularly provided by the carrier operating this means of transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TradeServiceCode { get; set; }

        /// <summary>
        /// The location within the means of transport where goods are to be or have been stowed.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Stowage Stowage { get; set; }

        /// <summary>
        /// An aircraft used for transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public AirTransport AirTransport { get; set; }

        /// <summary>
        /// A vehicle used for road transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public RoadTransport RoadTransport { get; set; }

        /// <summary>
        /// Equipment used for rail transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public RailTransport RailTransport { get; set; }

        /// <summary>
        /// A vessel used for transport by water (not only by sea).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public MaritimeTransport MaritimeTransport { get; set; }

        /// <summary>
        /// The party that owns this means of transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Party OwnerParty { get; set; }

        /// <summary>
        /// A measurable dimension (length, mass, weight, or volume) of this means of transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<Dimension> MeasurementDimension { get; set; }

        #endregion

    }

}