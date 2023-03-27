using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GT.Trace.PrintingCompanion
{
    public sealed class PrinterNameEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            // Indicates that this editor can display a Form-based interface.
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(
            ITypeDescriptorContext context,
            IServiceProvider provider,
            object value)
        {
            // Attempts to obtain an IWindowsFormsEditorService.
            IWindowsFormsEditorService edSvc =
                (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc == null)
            {
                return null;
            }

            // Displays a StringInputDialog Form to get a user-adjustable
            // string value.
            using (var form = new SelectPrinterForm((PrinterName)value, new Labels.Templates.Services.PrintService()))
            {
                if (edSvc.ShowDialog(form) == DialogResult.OK)
                {
                    return form.SelectedPrinter;
                }
            }

            // If OK was not pressed, return the original value
            return value;
        }
    }
}