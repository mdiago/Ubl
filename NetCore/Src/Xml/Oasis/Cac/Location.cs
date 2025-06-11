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
    /// Location.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class Location
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this location, e.g., the EAN Location Number, GLN.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// Text describing this location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Description { get; set; }

        /// <summary>
        /// Free-form text describing the physical conditions of the location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Conditions { get; set; }

        /// <summary>
        /// A territorial division of a country, such as a county or state, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CountrySubentity { get; set; }

        /// <summary>
        /// A territorial division of a country, such as a county or state, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string CountrySubentityCode { get; set; }

        /// <summary>
        /// A code signifying the type of location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LocationTypeCode { get; set; }

        /// <summary>
        /// The Uniform Resource Identifier (URI) of a document providing information about this location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string InformationURI { get; set; }

        /// <summary>
        /// The name of this location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string Name { get; set; }

        /// <summary>
        /// A period during which this location can be used (e.g., for delivery).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Period[] ValidityPeriod { get; set; }

        /// <summary>
        /// The address of this location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Address Address { get; set; }

        /// <summary>
        ///A location subsidiary to this location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location[] SubsidiaryLocation { get; set; }

        /// <summary>
        /// The geographical coordinates of this location.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public LocationCoordinate[] LocationCoordinate { get; set; }

        #endregion

    }

}