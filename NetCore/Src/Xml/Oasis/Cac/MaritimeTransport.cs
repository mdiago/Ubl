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
using Ubl.Xml.Oasis.Cbc;

namespace Ubl.Xml.Oasis.Cac
{

    /// <summary>
    /// A class to describe a vessel used for transport by water (including sea, river, and canal).
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class MaritimeTransport
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for a specific vessel.
        /// Lloyds Number, Registration Number (WCO ID 167)
        /// International Maritime Organisation number of a vessel
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string VesselID { get; set; }

        /// <summary>
        /// The name of the vessel.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string VesselName { get; set; }

        /// <summary>
        /// The radio call sign of the vessel.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string RadioCallSignID { get; set; }

        /// <summary>
        /// <para> Information about what services a vessel will require when it arrives at a port, such as refueling, maintenance, waste disposal etc.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] ShipsRequirements { get; set; }

        /// <summary>
        /// Gross tonnage is calculated by measuring a ship's volume (from keel to funnel, to the outside of the hull framing) and applying a mathematical formula and is used to determine things such as a ship's manning regulations, safety rules, registration fees and port dues.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure GrossTonnageMeasure { get; set; }

        /// <summary>
        /// Net tonnage is calculated by measuring a ship's internal volume and applying a mathematical formula and is used to calculate the port duties.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Measure NetTonnageMeasure { get; set; }

        /// <summary>
        /// The certificate issued to the ship by the ships registry in a given flag state.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public DocumentReference RegistryCertificateDocumentReference { get; set; }

        /// <summary>
        /// The port in which a vessel is registered or permanently based.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location RegistryPortLocation { get; set; }

        #endregion

    }

}