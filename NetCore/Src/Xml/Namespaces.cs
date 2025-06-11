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

using System.Collections.Generic;

namespace Ubl.Xml
{

    /// <summary>
    /// Espacios de nombre de OASIS.
    /// </summary>
    public class Namespaces
    {

        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Prefijo de espacios de nombres OASIS.  
        /// </summary>
        public const string NamespacePrefix = "urn:oasis:names:specification:ubl:schema:xsd:";

        /// <summary>
        /// Espacio de nombres cbc
        /// </summary>
        public const string NamespaceCbc = NamespacePrefix + "CommonBasicComponents-2";

        /// <summary>
        /// Espacio de nombres cac
        /// </summary>
        public const string NamespaceCac = NamespacePrefix + "CommonAggregateComponents-2";

        /// <summary>
        /// Espacio de nombres Invoice
        /// </summary>
        public const string NamespaceInvoice = NamespacePrefix + "Invoice-2";     

        /// <summary>
        /// Espacio de nombres soap
        /// </summary>
        public const string NamespaceSoap = "http://schemas.xmlsoap.org/soap/envelope/";

        /// <summary>
        /// Diccionario de espacios de nombres.
        /// </summary>
        public static Dictionary<string, string> Items = new Dictionary<string, string>()
        {
            { "soapenv",    NamespaceSoap},
            { "cbc",        NamespaceCbc },
            { "cac",        NamespaceCac },
            { "",           NamespaceInvoice }
        };    

        #endregion       

    }

}