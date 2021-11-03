// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Microsoft.EntityFrameworkCore.Query
{
    /// <summary>
    ///     Service which helps with various aspects of shared type entity expansion extensibility.
    /// </summary>
    /// <remarks>
    ///     See <see href="https://aka.ms/efcore-docs-providers">Implementation of database providers and extensions</see>
    ///     and <see href="https://aka.ms/efcore-how-queries-work">How EF Core queries work</see> for more information.
    /// </remarks>
    public interface ISharedTypeEntityExpansionHelper
    {
        /// <summary>
        /// Creates a SelectExpression representing owned type.
        /// </summary>
        public SelectExpression CreateInnerSelectExpression(
            TableExpressionBase sourceTable,
            IEntityType targetEntityType);
    }
}
