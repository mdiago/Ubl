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
    /// A class to describe hazardous goods in transit.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class HazardousGoodsTransit
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for a transport emergency card describing the actions to be taken
        /// in an emergency in transporting the hazardous goods. It may be the identity
        /// number of a hazardous emergency response plan assigned by the appropriate
        /// authority.
        /// TREM card
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportEmergencyCardCode { get; set; }

        /// <summary>
        /// A code signifying the packaging requirement for transportation of the
        /// hazardous goods as assigned by IATA, IMDB, ADR, RID etc.
        /// Packing Group
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PackingCriteriaCode { get; set; }

        /// <summary>
        /// A code signifying the set of legal regulations governing the transportation of the hazardous goods.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string HazardousRegulationCode { get; set; }

        /// <summary>
        /// A code signifying the Inhalation Toxicity Hazard Zone for the hazardous goods, as defined by the US Department of Transportation.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string InhalationToxicityZoneCode { get; set; }

        /// <summary>
        /// A code signifying authorization for the transportation of hazardous cargo.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TransportAuthorizationCode { get; set; }

        /// <summary>
        /// The maximum temperature at which the hazardous goods can safely be transported.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MaximumTemperature { get; set; }

        /// <summary>
        /// The minimum temperature at which the hazardous goods can safely be transported.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Temperature MinimumTemperature { get; set; }

        #endregion

    }

}