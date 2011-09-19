// Type: System.Windows.Controls.DataGrid
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime;
using System.Security;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace System.Windows.Controls
{
    public class DataGrid : MultiSelector
    {
        public static readonly DependencyProperty CanUserResizeColumnsProperty;
        public static readonly DependencyProperty ColumnWidthProperty;
        public static readonly DependencyProperty MinColumnWidthProperty;
        public static readonly DependencyProperty MaxColumnWidthProperty;
        public static readonly DependencyProperty GridLinesVisibilityProperty;
        public static readonly DependencyProperty HorizontalGridLinesBrushProperty;
        public static readonly DependencyProperty VerticalGridLinesBrushProperty;
        public static readonly DependencyProperty RowStyleProperty;
        public static readonly DependencyProperty RowValidationErrorTemplateProperty;
        public static readonly DependencyProperty RowStyleSelectorProperty;
        public static readonly DependencyProperty RowBackgroundProperty;
        public static readonly DependencyProperty AlternatingRowBackgroundProperty;
        public static readonly DependencyProperty RowHeightProperty;
        public static readonly DependencyProperty MinRowHeightProperty;
        public static readonly DependencyProperty RowHeaderWidthProperty;
        public static readonly DependencyProperty RowHeaderActualWidthProperty;
        public static readonly DependencyProperty ColumnHeaderHeightProperty;
        public static readonly DependencyProperty HeadersVisibilityProperty;
        public static readonly DependencyProperty CellStyleProperty;
        public static readonly DependencyProperty ColumnHeaderStyleProperty;
        public static readonly DependencyProperty RowHeaderStyleProperty;
        public static readonly DependencyProperty RowHeaderTemplateProperty;
        public static readonly DependencyProperty RowHeaderTemplateSelectorProperty;
        public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;
        public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;
        public static readonly RoutedCommand BeginEditCommand;
        public static readonly RoutedCommand CommitEditCommand;
        public static readonly RoutedCommand CancelEditCommand;
        public static readonly DependencyProperty IsReadOnlyProperty;
        public static readonly DependencyProperty CurrentItemProperty;
        public static readonly DependencyProperty CurrentColumnProperty;
        public static readonly DependencyProperty CurrentCellProperty;
        public static readonly DependencyProperty CanUserAddRowsProperty;
        public static readonly DependencyProperty CanUserDeleteRowsProperty;
        public static readonly DependencyProperty RowDetailsVisibilityModeProperty;
        public static readonly DependencyProperty AreRowDetailsFrozenProperty;
        public static readonly DependencyProperty RowDetailsTemplateProperty;
        public static readonly DependencyProperty RowDetailsTemplateSelectorProperty;
        public static readonly DependencyProperty CanUserResizeRowsProperty;
        public static readonly DependencyProperty SelectionModeProperty;
        public static readonly DependencyProperty SelectionUnitProperty;
        public static readonly DependencyProperty CanUserSortColumnsProperty;
        public static readonly DependencyProperty AutoGenerateColumnsProperty;
        public static readonly DependencyProperty FrozenColumnCountProperty;
        public static readonly DependencyProperty NonFrozenColumnsViewportHorizontalOffsetProperty;
        public static readonly DependencyProperty EnableRowVirtualizationProperty;
        public static readonly DependencyProperty EnableColumnVirtualizationProperty;
        public static readonly DependencyProperty CanUserReorderColumnsProperty;
        public static readonly DependencyProperty DragIndicatorStyleProperty;
        public static readonly DependencyProperty DropLocationIndicatorStyleProperty;
        public static readonly DependencyProperty ClipboardCopyModeProperty;
        public static readonly DependencyProperty CellsPanelHorizontalOffsetProperty;
        public DataGrid();

        public ObservableCollection<DataGridColumn> Columns { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public bool CanUserResizeColumns { get; set; }
        public DataGridLength ColumnWidth { get; set; }
        public double MinColumnWidth { get; set; }
        public double MaxColumnWidth { get; set; }
        public DataGridGridLinesVisibility GridLinesVisibility { get; set; }
        public Brush HorizontalGridLinesBrush { get; set; }
        public Brush VerticalGridLinesBrush { get; set; }
        public Style RowStyle { get; set; }
        public ControlTemplate RowValidationErrorTemplate { get; set; }

        public ObservableCollection<ValidationRule> RowValidationRules { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public StyleSelector RowStyleSelector { get; set; }
        public Brush RowBackground { get; set; }
        public Brush AlternatingRowBackground { get; set; }
        public double RowHeight { get; set; }
        public double MinRowHeight { get; set; }
        public double RowHeaderWidth { get; set; }
        public double RowHeaderActualWidth { get; internal set; }
        public double ColumnHeaderHeight { get; set; }
        public DataGridHeadersVisibility HeadersVisibility { get; set; }
        public Style CellStyle { get; set; }
        public Style ColumnHeaderStyle { get; set; }
        public Style RowHeaderStyle { get; set; }
        public DataTemplate RowHeaderTemplate { get; set; }
        public DataTemplateSelector RowHeaderTemplateSelector { get; set; }
        public static ComponentResourceKey FocusBorderBrushKey { get; }
        public static IValueConverter HeadersVisibilityConverter { get; }
        public static IValueConverter RowDetailsScrollingConverter { get; }
        public ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
        public ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
        protected internal override bool HandlesScrolling { get; }
        public static RoutedUICommand DeleteCommand { get; }
        public bool IsReadOnly { get; set; }
        public object CurrentItem { get; set; }
        public DataGridColumn CurrentColumn { get; set; }
        public DataGridCellInfo CurrentCell { get; set; }
        public bool CanUserAddRows { get; set; }
        public bool CanUserDeleteRows { get; set; }
        public DataGridRowDetailsVisibilityMode RowDetailsVisibilityMode { get; set; }
        public bool AreRowDetailsFrozen { get; set; }
        public DataTemplate RowDetailsTemplate { get; set; }
        public DataTemplateSelector RowDetailsTemplateSelector { get; set; }
        public bool CanUserResizeRows { get; set; }

        public IList<DataGridCellInfo> SelectedCells { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public static RoutedUICommand SelectAllCommand { get; }
        public DataGridSelectionMode SelectionMode { get; set; }
        public DataGridSelectionUnit SelectionUnit { get; set; }
        public bool CanUserSortColumns { get; set; }
        public bool AutoGenerateColumns { get; set; }
        public int FrozenColumnCount { get; set; }
        public double NonFrozenColumnsViewportHorizontalOffset { get; internal set; }
        public bool EnableRowVirtualization { get; set; }
        public bool EnableColumnVirtualization { get; set; }
        public bool CanUserReorderColumns { get; set; }
        public Style DragIndicatorStyle { get; set; }
        public Style DropLocationIndicatorStyle { get; set; }
        public DataGridClipboardCopyMode ClipboardCopyMode { get; set; }
        public double CellsPanelHorizontalOffset { get; private set; }
        public DataGridColumn ColumnFromDisplayIndex(int displayIndex);
        protected internal virtual void OnColumnDisplayIndexChanged(DataGridColumnEventArgs e);
        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
        protected override bool IsItemItsOwnContainerOverride(object item);
        protected override DependencyObject GetContainerForItemOverride();
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
        protected virtual void OnLoadingRow(DataGridRowEventArgs e);
        protected virtual void OnUnloadingRow(DataGridRowEventArgs e);
        public void SetDetailsVisibilityForItem(object item, Visibility detailsVisibility);
        public Visibility GetDetailsVisibilityForItem(object item);
        public void ClearDetailsVisibilityForItem(object item);
        public void ScrollIntoView(object item);
        public void ScrollIntoView(object item, DataGridColumn column);
        protected override void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
        protected virtual void OnCanExecuteBeginEdit(CanExecuteRoutedEventArgs e);
        protected virtual void OnExecutedBeginEdit(ExecutedRoutedEventArgs e);
        protected virtual void OnCanExecuteCommitEdit(CanExecuteRoutedEventArgs e);
        protected virtual void OnExecutedCommitEdit(ExecutedRoutedEventArgs e);
        protected virtual void OnRowEditEnding(DataGridRowEditEndingEventArgs e);
        protected virtual void OnCellEditEnding(DataGridCellEditEndingEventArgs e);
        protected virtual void OnCanExecuteCancelEdit(CanExecuteRoutedEventArgs e);
        protected virtual void OnExecutedCancelEdit(ExecutedRoutedEventArgs e);
        protected virtual void OnCanExecuteDelete(CanExecuteRoutedEventArgs e);
        protected virtual void OnExecutedDelete(ExecutedRoutedEventArgs e);
        protected virtual void OnCurrentCellChanged(EventArgs e);
        protected virtual void OnBeginningEdit(DataGridBeginningEditEventArgs e);
        protected internal virtual void OnPreparingCellForEdit(DataGridPreparingCellForEditEventArgs e);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public bool BeginEdit();

        public bool BeginEdit(RoutedEventArgs editingEventArgs);
        public bool CancelEdit();
        public bool CancelEdit(DataGridEditingUnit editingUnit);
        public bool CommitEdit();
        public bool CommitEdit(DataGridEditingUnit editingUnit, bool exitEditingMode);
        protected virtual void OnInitializingNewItem(InitializingNewItemEventArgs e);
        protected virtual void OnLoadingRowDetails(DataGridRowDetailsEventArgs e);
        protected virtual void OnUnloadingRowDetails(DataGridRowDetailsEventArgs e);
        protected internal virtual void OnRowDetailsVisibilityChanged(DataGridRowDetailsEventArgs e);
        protected virtual void OnSelectedCellsChanged(SelectedCellsChangedEventArgs e);
        public void SelectAllCells();
        public void UnselectAllCells();
        protected override void OnSelectionChanged(SelectionChangedEventArgs e);
        protected override void OnKeyDown(KeyEventArgs e);
        protected override void OnMouseMove(MouseEventArgs e);
        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
        protected override AutomationPeer OnCreateAutomationPeer();
        protected virtual void OnSorting(DataGridSortingEventArgs eventArgs);
        protected virtual void OnAutoGeneratedColumns(EventArgs e);
        protected virtual void OnAutoGeneratingColumn(DataGridAutoGeneratingColumnEventArgs e);
        protected override Size MeasureOverride(Size availableSize);
        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue);
        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
        public static Collection<DataGridColumn> GenerateColumns(IItemProperties itemProperties);
        public override void OnApplyTemplate();
        protected internal virtual void OnColumnHeaderDragStarted(DragStartedEventArgs e);
        protected internal virtual void OnColumnReordering(DataGridColumnReorderingEventArgs e);
        protected internal virtual void OnColumnHeaderDragDelta(DragDeltaEventArgs e);
        protected internal virtual void OnColumnHeaderDragCompleted(DragCompletedEventArgs e);
        protected internal virtual void OnColumnReordered(DataGridColumnEventArgs e);
        protected virtual void OnCanExecuteCopy(CanExecuteRoutedEventArgs args);

        [SecurityCritical]
        [SecurityTreatAsSafe]
        protected virtual void OnExecutedCopy(ExecutedRoutedEventArgs args);

        protected virtual void OnCopyingRowClipboardContent(DataGridRowClipboardEventArgs args);

        public event EventHandler<DataGridColumnEventArgs> ColumnDisplayIndexChanged;
        public event EventHandler<DataGridRowEventArgs> LoadingRow;
        public event EventHandler<DataGridRowEventArgs> UnloadingRow;
        public event EventHandler<DataGridRowEditEndingEventArgs> RowEditEnding;
        public event EventHandler<DataGridCellEditEndingEventArgs> CellEditEnding;
        public event EventHandler<EventArgs> CurrentCellChanged;
        public event EventHandler<DataGridBeginningEditEventArgs> BeginningEdit;
        public event EventHandler<DataGridPreparingCellForEditEventArgs> PreparingCellForEdit;
        public event InitializingNewItemEventHandler InitializingNewItem;
        public event EventHandler<DataGridRowDetailsEventArgs> LoadingRowDetails;
        public event EventHandler<DataGridRowDetailsEventArgs> UnloadingRowDetails;
        public event EventHandler<DataGridRowDetailsEventArgs> RowDetailsVisibilityChanged;
        public event SelectedCellsChangedEventHandler SelectedCellsChanged;
        public event DataGridSortingEventHandler Sorting;
        public event EventHandler AutoGeneratedColumns;
        public event EventHandler<DataGridAutoGeneratingColumnEventArgs> AutoGeneratingColumn;
        public event EventHandler<DataGridColumnReorderingEventArgs> ColumnReordering;
        public event EventHandler<DragStartedEventArgs> ColumnHeaderDragStarted;
        public event EventHandler<DragDeltaEventArgs> ColumnHeaderDragDelta;
        public event EventHandler<DragCompletedEventArgs> ColumnHeaderDragCompleted;
        public event EventHandler<DataGridColumnEventArgs> ColumnReordered;
        public event EventHandler<DataGridRowClipboardEventArgs> CopyingRowClipboardContent;
    }
}
