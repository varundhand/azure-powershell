// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.PowerShell;

    /// <summary>The properties of Azure Storage SMB file share endpoint to update.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureStorageSmbFileShareEndpointUpdatePropertiesTypeConverter))]
    public partial class AzureStorageSmbFileShareEndpointUpdateProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AzureStorageSmbFileShareEndpointUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureStorageSmbFileShareEndpointUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("EndpointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).EndpointType = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType) content.GetValueForProperty("EndpointType",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).EndpointType, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AzureStorageSmbFileShareEndpointUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureStorageSmbFileShareEndpointUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("EndpointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).EndpointType = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType) content.GetValueForProperty("EndpointType",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).EndpointType, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AzureStorageSmbFileShareEndpointUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAzureStorageSmbFileShareEndpointUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAzureStorageSmbFileShareEndpointUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureStorageSmbFileShareEndpointUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AzureStorageSmbFileShareEndpointUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAzureStorageSmbFileShareEndpointUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAzureStorageSmbFileShareEndpointUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureStorageSmbFileShareEndpointUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureStorageSmbFileShareEndpointUpdateProperties" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzureStorageSmbFileShareEndpointUpdateProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAzureStorageSmbFileShareEndpointUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The properties of Azure Storage SMB file share endpoint to update.
    [System.ComponentModel.TypeConverter(typeof(AzureStorageSmbFileShareEndpointUpdatePropertiesTypeConverter))]
    public partial interface IAzureStorageSmbFileShareEndpointUpdateProperties

    {

    }
}