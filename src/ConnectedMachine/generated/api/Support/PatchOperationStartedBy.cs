// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support
{

    /// <summary>Indicates if operation was triggered by user or by platform.</summary>
    public partial struct PatchOperationStartedBy :
        System.IEquatable<PatchOperationStartedBy>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy Platform = @"Platform";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy User = @"User";

        /// <summary>the value for an instance of the <see cref="PatchOperationStartedBy" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PatchOperationStartedBy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PatchOperationStartedBy" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PatchOperationStartedBy(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PatchOperationStartedBy</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PatchOperationStartedBy (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PatchOperationStartedBy && Equals((PatchOperationStartedBy)obj);
        }

        /// <summary>Returns hashCode for enum PatchOperationStartedBy</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PatchOperationStartedBy"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PatchOperationStartedBy(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PatchOperationStartedBy</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PatchOperationStartedBy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PatchOperationStartedBy" />.</param>

        public static implicit operator PatchOperationStartedBy(string value)
        {
            return new PatchOperationStartedBy(value);
        }

        /// <summary>Implicit operator to convert PatchOperationStartedBy to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PatchOperationStartedBy" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PatchOperationStartedBy</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PatchOperationStartedBy</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchOperationStartedBy e2)
        {
            return e2.Equals(e1);
        }
    }
}