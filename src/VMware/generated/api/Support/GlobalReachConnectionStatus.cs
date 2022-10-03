// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The connection status of the global reach connection</summary>
    public partial struct GlobalReachConnectionStatus :
        System.IEquatable<GlobalReachConnectionStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus Connected = @"Connected";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus Connecting = @"Connecting";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus Disconnected = @"Disconnected";

        /// <summary>
        /// the value for an instance of the <see cref="GlobalReachConnectionStatus" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to GlobalReachConnectionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GlobalReachConnectionStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new GlobalReachConnectionStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type GlobalReachConnectionStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type GlobalReachConnectionStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is GlobalReachConnectionStatus && Equals((GlobalReachConnectionStatus)obj);
        }

        /// <summary>Returns hashCode for enum GlobalReachConnectionStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="GlobalReachConnectionStatus"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private GlobalReachConnectionStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for GlobalReachConnectionStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to GlobalReachConnectionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GlobalReachConnectionStatus" />.</param>

        public static implicit operator GlobalReachConnectionStatus(string value)
        {
            return new GlobalReachConnectionStatus(value);
        }

        /// <summary>Implicit operator to convert GlobalReachConnectionStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="GlobalReachConnectionStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum GlobalReachConnectionStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum GlobalReachConnectionStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}