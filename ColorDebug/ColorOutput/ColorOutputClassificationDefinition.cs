//------------------------------------------------------------------------------
// <copyright file="ColorOutputClassificationDefinition.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace ColorDebug.ColorOutput
{
    /// <summary>
    /// Classification type definition export for ColorOutput
    /// </summary>
    internal static class ColorOutputClassificationDefinition
    {
        // This disables "The field is never used" compiler's warning. Justification: the field is used by MEF.
#pragma warning disable 169

        /// <summary>
        /// Defines the "ColorOutput" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("InformationOutput")]
        private static ClassificationTypeDefinition informationTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("WarningOutput")]
        private static ClassificationTypeDefinition warningTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ErrorOutput")]
        private static ClassificationTypeDefinition errorTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("OtherOutput")]
        private static ClassificationTypeDefinition otherTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("AddSubscribtionOutput")]
        private static ClassificationTypeDefinition addSubscribtionTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("RemoveSubscribtionOutput")]
        private static ClassificationTypeDefinition removeSubscribtion;

#pragma warning restore 169
    }
}
