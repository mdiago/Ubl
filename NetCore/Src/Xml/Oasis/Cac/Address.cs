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
    /// Address.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Address
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An indicator that this party is "care of" (c/o) (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// An indicator that this party is "for the attention of" (FAO) (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AddressTypeCode { get; set; }

        /// <summary>
        /// The Uniform Resource Identifier (URI) that identifies this party's web site; i.e., the web site's Uniform Resource Locator (URL).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AddressFormatCode { get; set; }

        /// <summary>
        /// An identifier for this party's logo.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Postbox { get; set; }

        /// <summary>
        /// An identifier for the end point of the routing service (e.g., EAN Location Number, GLN).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Floor { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Room { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string StreetName { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AdditionalStreetName { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BlockName { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BuildingName { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string InhouseMail { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Department { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MarkAttention { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string MarkCare { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PlotIdentification { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CitySubdivisionName { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CityName { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PostalZone { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CountrySubentity { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CountrySubentityCode { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Region { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string District { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string TimezoneOffset { get; set; }


        /// <summary>
        /// Identifiers for this party.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] AddressLine { get; set; }

        /// <summary>
        /// This party's Industry Classification Code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Country { get; set; }

        /// <summary>
        /// The geographical coordinates of this address.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public LocationCoordinate[] LocationCoordinate { get; set; }

        #endregion

    }

}