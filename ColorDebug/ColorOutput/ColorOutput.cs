//------------------------------------------------------------------------------
// <copyright file="ColorOutput.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using System.Linq;

namespace ColorDebug.ColorOutput
{
    /// <summary>
    /// Classifier that classifies all text as an instance of the "ColorOutput" classification type.
    /// </summary>
    internal class ColorOutput : IClassifier
    {
        /// <summary>
        /// Classification type.
        /// </summary>
        internal readonly IList<InformationAboutFormat> ClassificationTypes;

        private readonly IClassificationTypeRegistryService _registryService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorOutput"/> class.
        /// </summary>
        /// <param name="registry">Classification registry.</param>
        internal ColorOutput(IClassificationTypeRegistryService registry)
        {
            _registryService = registry;

            ClassificationTypes = new List<InformationAboutFormat>();

            ClassificationTypes.Add(new InformationAboutFormat("Information", "System.Windows.Data Information", true, registry.GetClassificationType("InformationOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("Warning", "System.Windows.Data Warning", true, registry.GetClassificationType("WarningOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("Warning", "System.Windows.ResourceDictionary Warning", true, registry.GetClassificationType("WarningOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("Error", "System.Windows.Data Error", true, registry.GetClassificationType("ErrorOutput")));

            ClassificationTypes.Add(new InformationAboutFormat("AddSubscribtion", "Add subscribtion", true, registry.GetClassificationType("AddSubscribtionOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("RemoveSubscribtion", "Remove subscribtion", true, registry.GetClassificationType("RemoveSubscribtionOutput")));

            ClassificationTypes.Add(new InformationAboutFormat("TestFinished", "Run test finished:", true, registry.GetClassificationType("TestFinishedOutput")));

            ClassificationTypes.Add(new InformationAboutFormat("BuildSuccess", @"Build: 0 succeeded, 0 failed, [1-9]+ up-to-date", false, registry.GetClassificationType("UpdateSolutionOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("BuildSuccess", @"Build: [1-9]+ succeeded, 0 failed, \d+ up-to-date", false, registry.GetClassificationType("SucceedSolutionOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("BuildFailed", @"Build: \d+ succeeded, [1-9]+ failed", false, registry.GetClassificationType("FailedSolutionOutput")));

            ClassificationTypes.Add(new InformationAboutFormat("ReBuildSuccess", @"(Rebuild All|Clean): 0 succeeded, 0 failed, [1-9]+ skipped", false, registry.GetClassificationType("UpdateSolutionOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("ReBuildSuccess", @"(Rebuild All|Clean): [1-9]+ succeeded, 0 failed, \d+ skipped", false, registry.GetClassificationType("SucceedSolutionOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("ReBuildFailed", @"(Rebuild All|Clean): \d+ succeeded, [1-9]+ failed, \d+ skipped", false, registry.GetClassificationType("FailedSolutionOutput")));

            ClassificationTypes.Add(new InformationAboutFormat("Loaded", @"Loaded:", false, registry.GetClassificationType("LoadedOutput")));
            ClassificationTypes.Add(new InformationAboutFormat("Unloaded", @"Unloaded:", false, registry.GetClassificationType("UnloadedOutput")));

            ClassificationTypes.Add(new InformationAboutFormat("Other", "", true, registry.GetClassificationType("OtherOutput")));
        }
        
        #region IClassifier

#pragma warning disable 67

        /// <summary>
        /// An event that occurs when the classification of a span of text has changed.
        /// </summary>
        /// <remarks>
        /// This event gets raised if a non-text change would affect the classification in some way,
        /// for example typing /* would cause the classification to change in C# without directly
        /// affecting the span.
        /// </remarks>
        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;

#pragma warning restore 67

        /// <summary>
        /// Gets all the <see cref="ClassificationSpan"/> objects that intersect with the given range of text.
        /// </summary>
        /// <remarks>
        /// This method scans the given SnapshotSpan for potential matches for this classification.
        /// In this instance, it classifies everything and returns each span as a new ClassificationSpan.
        /// </remarks>
        /// <param name="span">The span currently being classified.</param>
        /// <returns>A list of ClassificationSpans that represent spans identified to be of this classification.</returns>
        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            IList<ClassificationSpan> spans = new List<ClassificationSpan>();
            IClassificationType classificationType = null;
            string text = span.GetText();

            if (ClassificationTypes.FirstOrDefault(x => x.IsContain(text, out classificationType)) != null)
                spans.Add(new ClassificationSpan(new SnapshotSpan(span.Snapshot, new Span(span.Start, span.Length)), classificationType));
            return spans;
        }

        #endregion
    }
}
