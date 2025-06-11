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
    /// A class to describe information about a charge or discount as applied to a price component.
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NamespaceCac)]
    [XmlRoot(Namespace = Namespaces.NamespaceCac, IsNullable = false)]
    public class AllowanceCharge
    {

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// An identifier for this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string ID { get; set; }

        /// <summary>
        /// An indicator that this AllowanceCharge describes a charge (true) or a discount (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool ChargeIndicator { get; set; }

        /// <summary>
        /// A mutually agreed code signifying the reason for this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AllowanceChargeReasonCode { get; set; }

        /// <summary>
        /// The reason for this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string[] AllowanceChargeReason { get; set; }

        /// <summary>
        /// A number by which the base amount is multiplied to calculate the actual amount of this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public decimal MultiplierFactorNumeric { get; set; }

        /// <summary>
        /// An indicator that this allowance or charge is prepaid (true) or not (false).
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public bool PrepaidIndicator { get; set; }

        /// <summary>
        /// A number indicating the order of this allowance or charge in the sequence of calculations applied when there are multiple allowances or charges.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public int SequenceNumeric { get; set; }

        /// <summary>
        /// The monetary amount of this allowance or charge to be applied.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The monetary amount to which the multiplier factor is applied in calculating the amount of this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount BaseAmount { get; set; }

        /// <summary>
        /// The accounting cost centre used by the buyer to account for this allowance or charge, expressed as a code.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountingCostCode { get; set; }

        /// <summary>
        /// The accounting cost centre used by the buyer to account for this allowance or charge, expressed as text.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public string AccountingCost { get; set; }

        /// <summary>
        /// The allowance or charge per item; the total allowance or charge
        /// is calculated by multiplying the per unit amount by the quantity
        /// of items, either at the level of the individual transaction line
        /// or for the total number of items in the document, depending
        /// on the context in which it appears.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCbc)]
        public Amount PerUnitAmount { get; set; }

        /// <summary>
        /// A tax category applicable to this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<TaxCategory> TaxCategory { get; set; }

        /// <summary>
        /// The total of all the taxes applicable to this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public TaxTotal TaxTotal { get; set; }

        /// <summary>
        /// A means of payment for this allowance or charge.
        /// </summary>
        [XmlElement(Namespace = Namespaces.NamespaceCac)]
        public List<PaymentMeans> PaymentMeans { get; set; }

        #endregion

    }

}