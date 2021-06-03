using System;

namespace WindowsFormsExplorer.Samples.WorkbookView
{
    public partial class DesignerAndExplorerDialogsSample : SampleUserControl
    {
        // Most of the relevant SpreadsheetGear code for this sample is in this member's class, located within the
        // SamplesLibrary project.  It is shared sample code that can be run from this WindowsFormsExplorer samples 
        // app as well as the WPFExplorer samples app.
        public SamplesLibrary.Samples.WorkboookView.DesignerAndExplorerDialogsSample Sample { get; private set; }

        private void buttonWorkbookDesigner_Click(object sender, EventArgs e)
        {
            Sample.ShowWorkbookDesigner(workbookView);
        }

        private void buttonWorkbookExplorer_Click(object sender, EventArgs e)
        {
            Sample.ShowWorkbookExplorer(workbookView);
        }

        private void buttonRangeExplorer_Click(object sender, EventArgs e)
        {
            /// Disposes of the IWorkbookSet (and IWorkbook objects contained within it) used by the WorkbookView and sets it 
            /// up with a new workbook.  Disposal of old workbooks is necessary when using SpreadsheetGear in the "Free" mode,
            /// which has a 3 workbook limit.  If you are copying and pasting this sample code to your own projects and have a
            /// Signed License that activates either the fully-licensed or 30-day evaluation mode of the software, then this
            /// workbook disposal strategy is not needed. See the comments in the <see cref="SamplesLibrary.SGDisposalManager"/> 
            /// code file for more details.
            DisposalManager.ResetWorkbookView(workbookView);

            // "Or" together all of the selected RangeExplorerCategoryFlags.
            // You can limit which categories are displayed in the RangeExplorer by passing in only 
            // the desired RangeExplorerCategoryFlags, or show all with the "All" flag.
            var categoryFlags = SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.None;
            if (checkBox_rangeCategories_numberFormats.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.NumberFormat;
            if (checkBox_rangeCategories_alignment.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.Alignment;
            if (checkBox_rangeCategories_font.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.Font;
            if (checkBox_rangeCategories_borders.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.Borders;
            if (checkBox_rangeCategories_interior.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.Interior;
            if (checkBox_rangeCategories_protection.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.Protection;
            if (checkBox_rangeCategories_hyperlink.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.Hyperlink;
            if (checkBox_rangeCategories_validation.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.Validation;
            if (checkBox_rangeCategories_conditionalFormats.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.RangeExplorerCategoryFlags.FormatConditions;

            // Run the sample, passing in the selected category flags.
            Sample.ShowRangeExplorer(workbookView, categoryFlags);
        }

        private void buttonChartExplorer_Click(object sender, EventArgs e)
        {
            /// Disposes of the IWorkbookSet (and IWorkbook objects contained within it) used by the WorkbookView and sets it 
            /// up with a new workbook.  Disposal of old workbooks is necessary when using SpreadsheetGear in the "Free" mode,
            /// which has a 3 workbook limit.  If you are copying and pasting this sample code to your own projects and have a
            /// Signed License that activates either the fully-licensed or 30-day evaluation mode of the software, then this
            /// workbook disposal strategy is not needed. See the comments in the <see cref="SamplesLibrary.SGDisposalManager"/> 
            /// code file for more details.
            DisposalManager.ResetWorkbookView(workbookView);

            // "Or" together all of the selected ChartExplorerCategoryFlags.
            // You can limit which categories are displayed in the ChartExplorer by passing in only 
            // the desired ChartExplorerCategoryFlags, or show all with the "All" flag.
            var categoryFlags = SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.None;
            if (checkBox_chartCategories_chartArea.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.ChartArea;
            if (checkBox_chartCategories_chartData.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.ChartData;
            if (checkBox_chartCategories_plotArea.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.PlotArea;
            if (checkBox_chartCategories_legend.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.Legend;
            if (checkBox_chartCategories_title.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.ChartTitle;
            if (checkBox_chartCategories_axes.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.Axes;
            if (checkBox_chartCategories_series.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.SeriesCollection;
            if (checkBox_chartCategories_pageSetup.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ChartExplorerCategoryFlags.PageSetup;

            Sample.ShowChartExplorer(workbookView, categoryFlags);
        }

        private void buttonShapeExplorer_Click(object sender, EventArgs e)
        {
            /// Disposes of the IWorkbookSet (and IWorkbook objects contained within it) used by the WorkbookView and sets it 
            /// up with a new workbook.  Disposal of old workbooks is necessary when using SpreadsheetGear in the "Free" mode,
            /// which has a 3 workbook limit.  If you are copying and pasting this sample code to your own projects and have a
            /// Signed License that activates either the fully-licensed or 30-day evaluation mode of the software, then this
            /// workbook disposal strategy is not needed. See the comments in the <see cref="SamplesLibrary.SGDisposalManager"/> 
            /// code file for more details.
            DisposalManager.ResetWorkbookView(workbookView);

            // "Or" together all of the selected ShapeExplorerCategoryFlags.
            // You can limit which categories are displayed in the ShapeExplorer by passing in only 
            // the desired ShapeExplorerCategoryFlags, or show all with the "All" flag.
            var categoryFlags = SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.None;
            if (checkBox_shapeCategories_alignment.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.Alignment;
            if (checkBox_shapeCategories_font.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.Font;
            if (checkBox_shapeCategories_fill.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.Fill;
            if (checkBox_shapeCategories_line.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.Line;
            if (checkBox_shapeCategories_protection.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.Protection;
            if (checkBox_shapeCategories_autoShape.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.AutoShape;
            if (checkBox_shapeCategories_control.Checked)
                categoryFlags |= SpreadsheetGear.Windows.Forms.ShapeExplorerCategoryFlags.Control;

            Sample.ShowShapeExplorer(workbookView, categoryFlags);
        }


        #region Sample Initialization Code
        public DesignerAndExplorerDialogsSample()
        {
            InitializeComponent();
            InitializeSample();
        }


        private void InitializeSample()
        {
            Sample = new SamplesLibrary.Samples.WorkboookView.DesignerAndExplorerDialogsSample();
            DisposalManager.RegisterWorkbookViews(workbookView);
        }
        #endregion
    }
}
