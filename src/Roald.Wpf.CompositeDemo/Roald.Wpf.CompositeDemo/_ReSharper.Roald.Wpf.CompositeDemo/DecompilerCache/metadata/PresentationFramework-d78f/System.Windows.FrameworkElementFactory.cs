// Type: System.Windows.FrameworkElementFactory
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System;
using System.Runtime;
using System.Windows.Data;

namespace System.Windows
{
    [Localizability(LocalizationCategory.NeverLocalize)]
    public class FrameworkElementFactory
    {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public FrameworkElementFactory();

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public FrameworkElementFactory(Type type);

        public FrameworkElementFactory(string text);
        public FrameworkElementFactory(Type type, string name);

        public Type Type { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; set; }

        public string Text { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; set; }

        public string Name { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; set; }

        public bool IsSealed { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public FrameworkElementFactory Parent { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public FrameworkElementFactory FirstChild { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public FrameworkElementFactory NextSibling { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public void AppendChild(FrameworkElementFactory child);
        public void SetValue(DependencyProperty dp, object value);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void SetBinding(DependencyProperty dp, BindingBase binding);

        public void SetResourceReference(DependencyProperty dp, object name);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void AddHandler(RoutedEvent routedEvent, Delegate handler);

        public void AddHandler(RoutedEvent routedEvent, Delegate handler, bool handledEventsToo);
        public void RemoveHandler(RoutedEvent routedEvent, Delegate handler);
    }
}
