// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Encryption settings
    /// </summary>
    public partial class AccountEncryption
    {
        /// <summary>
        /// Initializes a new instance of the AccountEncryption class.
        /// </summary>
        public AccountEncryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountEncryption class.
        /// </summary>

        /// <param name="keySource">The encryption keySource (provider). Possible values (case-insensitive): 
        /// Microsoft.NetApp, Microsoft.KeyVault
        /// Possible values include: 'Microsoft.NetApp', 'Microsoft.KeyVault'</param>

        /// <param name="keyVaultProperties">Properties provided by KeVault. Applicable if keySource is
        /// &#39;Microsoft.KeyVault&#39;.
        /// </param>

        /// <param name="identity">Identity used to authenticate to KeyVault. Applicable if keySource is
        /// &#39;Microsoft.KeyVault&#39;.
        /// </param>
        public AccountEncryption(string keySource = default(string), KeyVaultProperties keyVaultProperties = default(KeyVaultProperties), EncryptionIdentity identity = default(EncryptionIdentity))

        {
            this.KeySource = keySource;
            this.KeyVaultProperties = keyVaultProperties;
            this.Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the encryption keySource (provider). Possible values
        /// (case-insensitive):  Microsoft.NetApp, Microsoft.KeyVault Possible values include: &#39;Microsoft.NetApp&#39;, &#39;Microsoft.KeyVault&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keySource")]
        public string KeySource {get; set; }

        /// <summary>
        /// Gets or sets properties provided by KeVault. Applicable if keySource is
        /// &#39;Microsoft.KeyVault&#39;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultProperties")]
        public KeyVaultProperties KeyVaultProperties {get; set; }

        /// <summary>
        /// Gets or sets identity used to authenticate to KeyVault. Applicable if
        /// keySource is &#39;Microsoft.KeyVault&#39;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public EncryptionIdentity Identity {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.KeyVaultProperties != null)
            {
                this.KeyVaultProperties.Validate();
            }

        }
    }
}