// Type: System.Windows.Controls.DataGridRow
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;

namespace System.Windows.Controls
{
    public class DataGridRow : Control
    {
        public static readonly DependencyProperty ItemProperty;
        public static readonly DependencyProperty ItemsPanelProperty;
        public static readonly DependencyProperty HeaderProperty;
        public static readonly DependencyProperty HeaderStyleProperty;
        public static readonly DependencyProperty HeaderTemplateProperty;
        public static readonly DependencyProperty HeaderTemplateSelectorProperty;
        public static readonly DependencyProperty ValidationErrorTemplateProperty;
        public static readonly DependencyProperty DetailsTemplateProperty;
        public static readonly DependencyProperty DetailsTemplateSelectorProperty;
        public static readonly DependencyProperty DetailsVisibilityProperty;
        public static readonly DependencyProperty AlternationIndexProperty;
        public static readonly DependencyProperty IsSelectedProperty;
        public static readonly RoutedEvent SelectedEvent;
        public static readonly RoutedEvent UnselectedEvent;
        public static readonly DependencyProperty IsEditingProperty;
        public DataGridRow();
        public object Item { get; set; }
        public ItemsPanelTemplate ItemsPanel { get; set; }
        public object Header { get; set; }
        public Style HeaderStyle { get; set; }
        public DataTemplate HeaderTemplate { get; set; }
        public DataTemplateSelector HeaderTemplateSelector { get; set; }
        public ControlTemplate ValidationErrorTemplate { get; set; }
        public DataTemplate DetailsTemplate { get; set; }
        public DataTemplateSelector DetailsTemplateSelector { get; set; }
        public Visibility DetailsVisibility { get; set; }
        public int AlternationIndex { get; }

        [Bindable(true)]
        [Category("Appearance")]
        public bool IsSelected { get; set; }

        public bool IsEditing { get; internal set; }
        protected virtual void OnItemChanged(object oldItem, object newItem);
        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
        protected virtual void OnHeaderChanged(object oldHeader, object newHeader);
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);

        protected internal virtual void OnColumnsChanged(ObservableCollection<DataGridColumn> columns,
                                                         NotifyCollectionChangedEventArgs e);

        protected virtual void OnSelected(RoutedEventArgs e);
        protected virtual void OnUnselected(RoutedEventArgs e);
        protected override AutomationPeer OnCreateAutomationPeer();
        protected override Size ArrangeOverride(Size arrangeBounds);
        public int GetIndex();
        public static DataGridRow GetRowContainingElement(FrameworkElement element);
        public event RoutedEventHandler Selected;
        public event RoutedEventHandler Unselected;
    }
}
