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

namespace Ubl.Xml.Oasis.Cbc
{

    /// <summary>
    /// A counted number of non-monetary units, possibly including a fractional part.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCbc)]
    [XmlRoot(Namespace = Namespaces.NamespaceCbc, IsNullable = false)]
    public partial class Quantity
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor
        /// </summary>
        public Quantity() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">A counted number of non-monetary units, possibly including a fractional part.</param>
        public Quantity(decimal value)
        {

            Value = value;

        }

        #endregion

        #region Operadores de Conversión 

        /// <summary>
        /// Convierte de objeto Quantity a decimal.
        /// </summary>
        /// <param name="quantity">Cantidad a convertir.</param>
        public static implicit operator decimal(Quantity quantity) => quantity.Value;

        /// <summary>
        /// Convierte de decimal a objeto Quantity.
        /// </summary>
        /// <param name="value">Objeto Quantity a convertir.</param>
        public static implicit operator Quantity(decimal value) => new Quantity(value);

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// The unit of the quantity
        /// </summary>
        [XmlAttribute("unitCode")] 
        public string UnitCode { get; set; }

        /// <summary>
        /// The identification of the agency that maintains the quantity unit code list
        /// </summary>
        [XmlAttribute("unitCodeListAgencyID")] 
        public string UnitCodeListAgencyID { get; set; }

        /// <summary>
        /// The name of the agency which maintains the quantity unit code list.
        /// </summary>
        [XmlAttribute("unitCodeListAgencyName")] 
        public string UnitCodeListAgencyName { get; set; }

        /// <summary>
        /// The quantity unit code list.
        /// </summary>
        [XmlAttribute("unitCodeListID")] 
        public string UnitCodeListID { get; set; }

        /// <summary>
        /// A counted number of non-monetary units, possibly including a fractional part.
        /// </summary>
        [XmlText()]
        public decimal Value { get; set; }

        #endregion

    }

}