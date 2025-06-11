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
    /// A class for describing the terms and conditions applying to the delivery of goods.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class DeliveryTerms
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// <para> An identifier for the referenced document.</para>
        /// <para> Sample: CIF, FOB, or EXW from the INCOTERMS Terms of Delivery. (2000 version preferred.)</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// <para> A description of any terms or conditions relating to the delivery items.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] SpecialTerms { get; set; }


        /// <summary>
        /// A code that identifies one of various responsibilities for loss risk in the execution of the delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string LossRiskResponsibilityCode { get; set; }

        /// <summary>
        /// <para> 	A description of responsibility for risk of loss in execution of the delivery, expressed as text.</para>
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] LossRisk { get; set; }

        /// <summary>
        /// The monetary amount covered by these delivery terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The location for the contracted delivery.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public Location DeliveryLocation { get; set; }

        /// <summary>
        /// An allowance or charge covered by these delivery terms.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public AllowanceCharge AllowanceCharge { get; set; }

        #endregion

    }

}