// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>
    /// Represents set of actions written in SQL language-based syntax that is performed against a ServiceBus.Messaging.BrokeredMessage
    /// </summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class SqlRuleAction :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.ISqlRuleAction,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.ISqlRuleActionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IAction"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IAction __action = new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.Action();

        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inherited)]
        public int? CompatibilityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IActionInternal)__action).CompatibilityLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IActionInternal)__action).CompatibilityLevel = value ?? default(int); }

        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inherited)]
        public bool? RequiresPreprocessing { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IActionInternal)__action).RequiresPreprocessing; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IActionInternal)__action).RequiresPreprocessing = value ?? default(bool); }

        /// <summary>SQL expression. e.g. MyProperty='ABC'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inherited)]
        public string SqlExpression { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IActionInternal)__action).SqlExpression; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IActionInternal)__action).SqlExpression = value ?? null; }

        /// <summary>Creates an new <see cref="SqlRuleAction" /> instance.</summary>
        public SqlRuleAction()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__action), __action);
            await eventListener.AssertObjectIsValid(nameof(__action), __action);
        }
    }
    /// Represents set of actions written in SQL language-based syntax that is performed against a ServiceBus.Messaging.BrokeredMessage
    public partial interface ISqlRuleAction :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IAction
    {

    }
    /// Represents set of actions written in SQL language-based syntax that is performed against a ServiceBus.Messaging.BrokeredMessage
    internal partial interface ISqlRuleActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.IActionInternal
    {

    }
}