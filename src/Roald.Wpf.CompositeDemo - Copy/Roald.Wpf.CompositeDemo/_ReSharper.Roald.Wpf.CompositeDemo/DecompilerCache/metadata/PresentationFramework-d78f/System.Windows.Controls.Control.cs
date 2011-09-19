// Type: System.Windows.Controls.Control
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.ComponentModel;
using System.Runtime;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace System.Windows.Controls
{
    public class Control : FrameworkElement
    {
        public static readonly DependencyProperty BorderBrushProperty;
        public static readonly DependencyProperty BorderThicknessProperty;
        public static readonly DependencyProperty BackgroundProperty;
        public static readonly DependencyProperty ForegroundProperty;
        public static readonly DependencyProperty FontFamilyProperty;
        public static readonly DependencyProperty FontSizeProperty;
        public static readonly DependencyProperty FontStretchProperty;
        public static readonly DependencyProperty FontStyleProperty;
        public static readonly DependencyProperty FontWeightProperty;
        public static readonly DependencyProperty HorizontalContentAlignmentProperty;
        public static readonly DependencyProperty VerticalContentAlignmentProperty;
        public static readonly DependencyProperty TabIndexProperty;
        public static readonly DependencyProperty IsTabStopProperty;
        public static readonly DependencyProperty PaddingProperty;
        public static readonly DependencyProperty TemplateProperty;
        public static readonly RoutedEvent PreviewMouseDoubleClickEvent;
        public static readonly RoutedEvent MouseDoubleClickEvent;
        public Control();

        [Category("Appearance")]
        [Bindable(true)]
        public Brush BorderBrush { get; set; }

        [Category("Appearance")]
        [Bindable(true)]
        public Thickness BorderThickness { get; set; }

        [Bindable(true)]
        [Category("Appearance")]
        public Brush Background { get; set; }

        [Bindable(true)]
        [Category("Appearance")]
        public Brush Foreground { get; set; }

        [Bindable(true)]
        [Localizability(LocalizationCategory.Font)]
        [Category("Appearance")]
        public FontFamily FontFamily { get; set; }

        [TypeConverter(typeof (FontSizeConverter))]
        [Localizability(LocalizationCategory.None)]
        [Bindable(true)]
        [Category("Appearance")]
        public double FontSize { get; set; }

        [Category("Appearance")]
        [Bindable(true)]
        public FontStretch FontStretch { get; set; }

        [Category("Appearance")]
        [Bindable(true)]
        public FontStyle FontStyle { get; set; }

        [Bindable(true)]
        [Category("Appearance")]
        public FontWeight FontWeight { get; set; }

        [Bindable(true)]
        [Category("Layout")]
        public HorizontalAlignment HorizontalContentAlignment { get; set; }

        [Bindable(true)]
        [Category("Layout")]
        public VerticalAlignment VerticalContentAlignment { get; set; }

        [Category("Behavior")]
        [Bindable(true)]
        public int TabIndex { get; set; }

        [Bindable(true)]
        [Category("Behavior")]
        public bool IsTabStop { get; set; }

        [Category("Layout")]
        [Bindable(true)]
        public Thickness Padding { get; set; }

        public ControlTemplate Template { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; set; }

        protected internal virtual bool HandlesScrolling { get; }
        protected virtual void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
        public override string ToString();
        protected virtual void OnPreviewMouseDoubleClick(MouseButtonEventArgs e);
        protected virtual void OnMouseDoubleClick(MouseButtonEventArgs e);
        protected override Size MeasureOverride(Size constraint);
        protected override Size ArrangeOverride(Size arrangeBounds);
        public event MouseButtonEventHandler PreviewMouseDoubleClick;
        public event MouseButtonEventHandler MouseDoubleClick;
    }
}
