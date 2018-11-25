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
}
