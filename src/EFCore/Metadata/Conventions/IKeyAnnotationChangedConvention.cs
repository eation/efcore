// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microsoft.EntityFrameworkCore.Metadata.Conventions
{
    /// <summary>
    ///     Represents an operation that should be performed when an annotation is changed on a key.
    /// </summary>
    public interface IKeyAnnotationChangedConvention : IConvention
    {
        /// <summary>
        ///     Called after an annotation is changed on a key.
        /// </summary>
        /// <param name="keyBuilder"> The builder for the key. </param>
        /// <param name="name"> The annotation name. </param>
        /// <param name="annotation"> The new annotation. </param>
        /// <param name="oldAnnotation"> The old annotation.  </param>
        /// <param name="context"> Additional information associated with convention execution. </param>
        void ProcessKeyAnnotationChanged(
            IConventionKeyBuilder keyBuilder,
            string name,
            IConventionAnnotation? annotation,
            IConventionAnnotation? oldAnnotation,
            IConventionContext<IConventionAnnotation> context);
    }
}