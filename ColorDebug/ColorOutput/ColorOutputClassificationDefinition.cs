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
        private static ClassificationTypeDefinition removeSubscribtionTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("UpdateSolutionOutput")]
        private static ClassificationTypeDefinition updateTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SucceedSolutionOutput")]
        private static ClassificationTypeDefinition succeedTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("FailedSolutionOutput")]
        private static ClassificationTypeDefinition failedTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("TestFinishedOutput")]
        private static ClassificationTypeDefinition testFinishedTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LoadedOutput")]
        private static ClassificationTypeDefinition loadedTypeDefinition;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("UnloadedOutput")]
        private static ClassificationTypeDefinition unloadedTypeDefinition;

#pragma warning restore 169
    }
}
