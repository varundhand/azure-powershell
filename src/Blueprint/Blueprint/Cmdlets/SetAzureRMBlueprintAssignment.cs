﻿using System;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.PowerShell.Cmdlets.Blueprint.Properties;
using ParameterSetNames = Microsoft.Azure.Commands.Blueprint.Common.BlueprintConstants.ParameterSetNames;
using ParameterHelpMessages = Microsoft.Azure.Commands.Blueprint.Common.BlueprintConstants.ParameterHelpMessages;
using System.Text.RegularExpressions;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Blueprint.Models;
using System.Collections;
using Microsoft.Azure.Management.Blueprint.Models;
using Microsoft.Azure.Commands.Blueprint.Common;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Blueprint.Cmdlets
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "BlueprintAssignment", SupportsShouldProcess = true, DefaultParameterSetName = ParameterSetNames.CreateBlueprintAssignment), OutputType(typeof(PSBlueprintAssignment))]
    public class SetAzureRMBlueprintAssignment : BlueprintCmdletBase
    {
        #region Parameters
        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.BlueprintAssignmentName)]
        [ValidatePattern("^[0-9a-zA-Z_-]*$", Options = RegexOptions.Compiled | RegexOptions.CultureInvariant)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.BlueprintObject)]
        [ValidateNotNull]
        public PSBlueprintBase Blueprint { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.SubscriptionIdToAssign)]
        [ValidateNotNullOrEmpty]
        public string[] SubscriptionId { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.Location)]
        [ValidateNotNullOrEmpty]
        [LocationCompleter("Microsoft.Batch/operations")]
        public string Location { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = false, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public Hashtable ResourceGroup { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.Parameters)]
        [ValidateNotNull]
        public Hashtable Parameter { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = false, HelpMessage = ParameterHelpMessages.SystemAssignedIdentity)]
        public SwitchParameter SystemAssignedIdentity { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.UserAssignedIdentity)]
        [ValidateNotNullOrEmpty]
        public string UserAssignedIdentity { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.CreateBlueprintAssignment, Mandatory = false, HelpMessage = ParameterHelpMessages.LockFlag)]
        public PSLockMode? Lock { get; set; }
        #endregion Parameters

        #region Cmdlet Overrides
        public override void ExecuteCmdlet()
        {
            try
            {
                var subscriptionsList = SubscriptionId ?? new[] { DefaultContext.Subscription.Id };

                if (ShouldProcess(string.Join(",", subscriptionsList), string.Format(Resources.UpdateAssignmentShouldProcessString, Name)))
                {
                    // If explicitly requested to use user assigned identity let's do that, otherwise let's default to system assigned
                    if (this.IsParameterBound(c => c.UserAssignedIdentity))
                    {
                        var userAssignedIdentity = new Dictionary<string, UserAssignedIdentity>()
                        {
                            { UserAssignedIdentity, new UserAssignedIdentity() }
                        };

                        var assignment = CreateAssignmentObject(ManagedServiceIdentityType.UserAssigned,
                            userAssignedIdentity,
                            Location,
                            Blueprint.Id,
                            Lock,
                            Parameter,
                            ResourceGroup);

                        foreach (var subscription in subscriptionsList)
                        {
                            var scope = Utils.GetScopeForSubscription(subscription);
                            ThrowIfAssignmentNotExist(scope, Name);
                            // Register Blueprint RP
                            RegisterBlueprintRp(subscription);

                            WriteObject(BlueprintClient.CreateOrUpdateBlueprintAssignment(scope, Name, assignment));
                        }
                    }
                    else
                    {
                        var assignment = CreateAssignmentObject(ManagedServiceIdentityType.SystemAssigned,
                            null,
                            Location,
                            Blueprint.Id,
                            Lock,
                            Parameter,
                            ResourceGroup);

                        foreach (var subscription in subscriptionsList)
                        {
                            var scope = Utils.GetScopeForSubscription(subscription);
                            ThrowIfAssignmentNotExist(scope, Name);
                            // First Register Blueprint RP and grant owner permission to BP service principal
                            RegisterBlueprintRp(subscription);
                            var servicePrincipal = GetBlueprintSpn();
                            AssignOwnerPermission(subscription, servicePrincipal);

                            WriteObject(BlueprintClient.CreateOrUpdateBlueprintAssignment(scope, Name, assignment));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteExceptionError(ex);
            }
        }
        #endregion Cmdlet Overrides
    }
}
