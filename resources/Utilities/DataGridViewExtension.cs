using System.Linq;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    static class DataGridViewExtensions
    {
        public static void SetVisible(this DataGridViewRow r, bool value)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)r.DataGridView.Parent.BindingContext[r.DataGridView.DataSource];
            currencyManager1.SuspendBinding();
            r.Visible = value;
            currencyManager1.ResumeBinding();
        }
        public static object GetCellValueFromColumnHeader(this DataGridViewCellCollection CellCollection, string HeaderText)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value;
        }
    }
}
