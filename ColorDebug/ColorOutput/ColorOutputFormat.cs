//------------------------------------------------------------------------------
// <copyright file="ColorOutputFormat.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace ColorDebug.ColorOutput
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "InformationOutput")]
    [Name("CB Binding Information")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class InformationOutputFormat : ClassificationFormatDefinition
    {
        public InformationOutputFormat()
        {
            this.ForegroundColor = Colors.GreenYellow;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "WarningOutput")]
    [Name("CB Binding Warning")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class WarningOutputFormat : ClassificationFormatDefinition
    {
        public WarningOutputFormat()
        {
            this.ForegroundColor = Colors.Orange;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ErrorOutput")]
    [Name("CB Binding Error")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ErrorOutputFormat : ClassificationFormatDefinition
    {
        public ErrorOutputFormat()
        {
            this.ForegroundColor = Colors.Red;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "OtherOutput")]
    [Name("CB Other")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class OtherOutputFormat : ClassificationFormatDefinition
    {
        public OtherOutputFormat()
        {
            this.ForegroundColor = Colors.DeepSkyBlue;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "AddSubscribtionOutput")]
    [Name("CB Add Subscribtion")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class AddSubscribtionOutputFormat : ClassificationFormatDefinition
    {
        public AddSubscribtionOutputFormat()
        {
            this.ForegroundColor = Colors.HotPink;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "RemoveSubscribtionOutput")]
    [Name("CB Remove Subscribtion")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class RemoveSubscribtionOutputFormat : ClassificationFormatDefinition
    {
        public RemoveSubscribtionOutputFormat()
        {
            this.ForegroundColor = Colors.Violet;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "UpdateSolutionOutput")]
    [Name("CB Update solution")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class UpdateSolutionOutputFormat : ClassificationFormatDefinition
    {
        public UpdateSolutionOutputFormat()
        {
            this.ForegroundColor = Colors.PaleGreen;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SucceedSolutionOutput")]
    [Name("CB Succeed solution")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class SucceedSolutionOutputFormat : ClassificationFormatDefinition
    {
        public SucceedSolutionOutputFormat()
        {
            this.ForegroundColor = Colors.GreenYellow;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "FailedSolutionOutput")]
    [Name("CB Failed solution")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class FailedSolutionOutputFormat : ClassificationFormatDefinition
    {
        public FailedSolutionOutputFormat()
        {
            this.ForegroundColor = Colors.Red;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "TestFinishedOutput")]
    [Name("CB Test finished")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class TestFinishedOutputFormat : ClassificationFormatDefinition
    {
        public TestFinishedOutputFormat()
        {
            this.ForegroundColor = Colors.PaleGreen;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LoadedOutput")]
    [Name("CB Loaded")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class LoadedOutputFormat : ClassificationFormatDefinition
    {
        public LoadedOutputFormat()
        {
            this.ForegroundColor = Colors.MistyRose;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "UnloadedOutput")]
    [Name("CB Unloaded")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class UnloadedOutputFormat: ClassificationFormatDefinition
    {
        public UnloadedOutputFormat()
        {
            this.ForegroundColor = Colors.Azure;
        }
    }
}
