using System.Windows.Forms;

namespace Body_Factory_Manager
{
    static class DataGridViewRowExtensions
    {
        public static void SetVisible(this DataGridViewRow r, bool value)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)r.DataGridView.Parent.BindingContext[r.DataGridView.DataSource];
            currencyManager1.SuspendBinding();
            r.Visible = value;
            currencyManager1.ResumeBinding();
        }
    }
}
