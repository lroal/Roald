// Type: System.Windows.Controls.ItemsControl
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using MS.Internal.Controls;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;

namespace System.Windows.Controls
{
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    [DefaultEvent("OnItemsChanged")]
    [ContentProperty("Items")]
    [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof (FrameworkElement))]
    [DefaultProperty("Items")]
    public class ItemsControl : Control, IAddChild, IGeneratorHost
    {
        public static readonly DependencyProperty ItemsSourceProperty;
        public static readonly DependencyProperty HasItemsProperty;
        public static readonly DependencyProperty DisplayMemberPathProperty;
        public static readonly DependencyProperty ItemTemplateProperty;
        public static readonly DependencyProperty ItemTemplateSelectorProperty;
        public static readonly DependencyProperty ItemStringFormatProperty;
        public static readonly DependencyProperty ItemBindingGroupProperty;
        public static readonly DependencyProperty ItemContainerStyleProperty;
        public static readonly DependencyProperty ItemContainerStyleSelectorProperty;
        public static readonly DependencyProperty ItemsPanelProperty;
        public static readonly DependencyProperty IsGroupingProperty;
        public static readonly DependencyProperty GroupStyleSelectorProperty;
        public static readonly DependencyProperty AlternationCountProperty;
        public static readonly DependencyProperty AlternationIndexProperty;
        public static readonly DependencyProperty IsTextSearchEnabledProperty;
        public static readonly DependencyProperty IsTextSearchCaseSensitiveProperty;
        public ItemsControl();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Bindable(true)]
        public ItemCollection Items { get; }

        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEnumerable ItemsSource { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Bindable(false)]
        public ItemContainerGenerator ItemContainerGenerator { get; }

        protected internal override IEnumerator LogicalChildren { get; }

        [Browsable(false)]
        [Bindable(false)]
        public bool HasItems { get; }

        [Bindable(true)]
        public string DisplayMemberPath { get; set; }

        [Bindable(true)]
        public DataTemplate ItemTemplate { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(true)]
        public DataTemplateSelector ItemTemplateSelector { get; set; }

        [Bindable(true)]
        public string ItemStringFormat { get; set; }

        [Bindable(true)]
        public BindingGroup ItemBindingGroup { get; set; }

        [Bindable(true)]
        [Category("Content")]
        public Style ItemContainerStyle { get; set; }

        [Bindable(true)]
        [Category("Content")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StyleSelector ItemContainerStyleSelector { get; set; }

        [Bindable(false)]
        public ItemsPanelTemplate ItemsPanel { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(false)]
        public bool IsGrouping { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<GroupStyle> GroupStyle { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(true)]
        public GroupStyleSelector GroupStyleSelector { get; set; }

        #region IGeneratorHost Members

        [Bindable(true)]
        public int AlternationCount { get; set; }

        #endregion

        public bool IsTextSearchEnabled { get; set; }
        public bool IsTextSearchCaseSensitive { get; set; }

        #region IAddChild Members

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        void IAddChild.AddChild(object value);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        void IAddChild.AddText(string text);

        #endregion

        [EditorBrowsable(EditorBrowsableState.Never)]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public bool ShouldSerializeItems();

        protected virtual void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue);
        protected virtual void OnItemsChanged(NotifyCollectionChangedEventArgs e);
        protected virtual void OnDisplayMemberPathChanged(string oldDisplayMemberPath, string newDisplayMemberPath);
        protected virtual void OnItemTemplateChanged(DataTemplate oldItemTemplate, DataTemplate newItemTemplate);

        protected virtual void OnItemTemplateSelectorChanged(DataTemplateSelector oldItemTemplateSelector,
                                                             DataTemplateSelector newItemTemplateSelector);

        protected virtual void OnItemStringFormatChanged(string oldItemStringFormat, string newItemStringFormat);

        protected virtual void OnItemBindingGroupChanged(BindingGroup oldItemBindingGroup,
                                                         BindingGroup newItemBindingGroup);

        protected virtual void OnItemContainerStyleChanged(Style oldItemContainerStyle, Style newItemContainerStyle);

        protected virtual void OnItemContainerStyleSelectorChanged(StyleSelector oldItemContainerStyleSelector,
                                                                   StyleSelector newItemContainerStyleSelector);

        public static ItemsControl GetItemsOwner(DependencyObject element);
        protected virtual void OnItemsPanelChanged(ItemsPanelTemplate oldItemsPanel, ItemsPanelTemplate newItemsPanel);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGroupStyle();

        protected virtual void OnGroupStyleSelectorChanged(GroupStyleSelector oldGroupStyleSelector,
                                                           GroupStyleSelector newGroupStyleSelector);

        protected virtual void OnAlternationCountChanged(int oldAlternationCount, int newAlternationCount);
        public static int GetAlternationIndex(DependencyObject element);
        public static ItemsControl ItemsControlFromItemContainer(DependencyObject container);
        public static DependencyObject ContainerFromElement(ItemsControl itemsControl, DependencyObject element);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public DependencyObject ContainerFromElement(DependencyObject element);

        protected virtual void AddChild(object value);

        protected virtual void AddText(string text);
        public override void BeginInit();
        public override void EndInit();
        protected virtual bool IsItemItsOwnContainerOverride(object item);
        protected virtual DependencyObject GetContainerForItemOverride();
        protected virtual void PrepareContainerForItemOverride(DependencyObject element, object item);
        protected virtual void ClearContainerForItemOverride(DependencyObject element, object item);
        protected override void OnTextInput(TextCompositionEventArgs e);
        protected override void OnKeyDown(KeyEventArgs e);
        protected virtual bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
        public override string ToString();
    }
}
