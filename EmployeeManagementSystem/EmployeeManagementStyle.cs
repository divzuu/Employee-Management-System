using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    internal static class EmployeeManagementStyle
    {
        private static readonly Color FormBackground =
            Color.FromArgb(245, 247, 250);

        private static readonly Color PrimaryColor =
            Color.FromArgb(45, 99, 150);

        private static readonly Color SecondaryColor =
            Color.FromArgb(230, 236, 243);

        public static void Apply(Form form)
        {
            form.BackColor = FormBackground;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;

            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Label)
                {
                    control.ForeColor = Color.FromArgb(40, 50, 60);
                }
                else if (control is Button)
                {
                    StyleButton((Button)control);
                }
                else if (control is DataGridView)
                {
                    StyleGrid((DataGridView)control);
                }
                else if (control is TextBoxBase ||
                         control is ComboBox ||
                         control is DateTimePicker ||
                         control is NumericUpDown)
                {
                    control.BackColor = Color.White;
                }

                if (control.HasChildren)
                {
                    ApplyToControls(control.Controls);
                }
            }
        }

        private static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = PrimaryColor;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(4, 2, 4, 2);

            if (button.Name == "btnDelete")
            {
                button.BackColor = Color.FromArgb(190, 65, 65);
            }
            else if (button.Name == "btnClear")
            {
                button.BackColor = Color.FromArgb(100, 110, 120);
            }
            else if (button.Name == "btnEmployeeHistory")
            {
                button.BackColor = Color.FromArgb(70, 130, 100);
            }
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.EnableHeadersVisualStyles = false;
            grid.AllowUserToAddRows = false;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(40, 50, 60);
            grid.DefaultCellStyle.SelectionBackColor = SecondaryColor;
            grid.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(20, 30, 40);
            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);
        }
    }
}
