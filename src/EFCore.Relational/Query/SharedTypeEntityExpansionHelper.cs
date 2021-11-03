// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Microsoft.EntityFrameworkCore.Query
{
    /// <inheritdoc/>
    public class SharedTypeEntityExpansionHelper : ISharedTypeEntityExpansionHelper
    {
        /// <summary>
        ///     Dependencies for this service.
        /// </summary>
        protected virtual SharedTypeEntityExpansionHelperDependencies Dependencies { get; }

        /// <summary>
        ///     Creates a new instance of the <see cref="SharedTypeEntityExpansionHelper" /> class.
        /// </summary>
        /// <param name="dependencies">Dependencies for this service.</param>
        public SharedTypeEntityExpansionHelper(SharedTypeEntityExpansionHelperDependencies dependencies)
        {
            Dependencies = dependencies;
        }

        /// <inheritdoc/>
        public virtual SelectExpression CreateInnerSelectExpression(
            TableExpressionBase sourceTable,
            IEntityType targetEntityType)
            => Dependencies.SqlExpressionFactory.Select(targetEntityType);
    }
}
