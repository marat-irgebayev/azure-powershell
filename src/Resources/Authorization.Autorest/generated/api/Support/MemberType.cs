// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support
{

    /// <summary>Membership type of the role assignment schedule</summary>
    public partial struct MemberType :
        System.IEquatable<MemberType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType Direct = @"Direct";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType Group = @"Group";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType Inherited = @"Inherited";

        /// <summary>the value for an instance of the <see cref="MemberType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MemberType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MemberType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MemberType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MemberType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MemberType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MemberType && Equals((MemberType)obj);
        }

        /// <summary>Returns hashCode for enum MemberType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MemberType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MemberType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MemberType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MemberType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MemberType" />.</param>

        public static implicit operator MemberType(string value)
        {
            return new MemberType(value);
        }

        /// <summary>Implicit operator to convert MemberType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MemberType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MemberType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType e1, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MemberType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType e1, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType e2)
        {
            return e2.Equals(e1);
        }
    }
}