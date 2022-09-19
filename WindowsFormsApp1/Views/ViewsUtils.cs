using System.Windows.Forms;

namespace GehaOverFlow.Views
{
    static class ViewsUtils
    {
        /// <summary>
        /// Returns true if one the provided TextBoxes is empty
        /// </summary>
        /// <param name="inputs">TextBoxes to validate</param>
        /// <returns>bool</returns>
        public static bool EmptyInputs(params TextBox[] inputs)
        {
            foreach (var input in inputs)
                if (input.Text.Trim() == "") return true;

            return false;
        }

        public static void SwitchForms(Form src, Form dst)
        {
            src.Hide();
            dst.ShowDialog();
            src.Close();
        }
    }
}
