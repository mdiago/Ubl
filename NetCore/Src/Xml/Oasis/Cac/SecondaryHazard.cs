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
    /// A class to describe a property group or classification.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class SecondaryHazard
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// A class to describe a secondary hazard associated with a hazardous item.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// Text of the placard notation corresponding to the hazard class of this
        /// secondary hazard. Can also be the hazard identification number of
        /// the orange placard (upper part) required on the means of transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PlacardNotation { get; set; }

        /// <summary>
        /// Text of the placard endorsement for this secondary hazard that is to be
        /// shown on the shipping papers for a hazardous item. Can also be used for
        /// the number of the orange placard (lower part) required on the means of transport.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string PlacardEndorsement { get; set; }

        /// <summary>
        /// A code signifying the emergency procedures for this secondary hazard.
        /// EMG code, EMS Page Number.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string EmergencyProceduresCode { get; set; }

        /// <summary>
        /// <para> Additional information about the hazardous substance, which can be used (for example) to specify the type of regulatory requirements that apply to this secondary hazard.</para>
        /// <para> N.O.S. or a Waste Characteristics Code in conjunction with an EPA Waste Stream code</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] Extension { get; set; }

        #endregion

    }

}