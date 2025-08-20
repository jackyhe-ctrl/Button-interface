using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Button_interface
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        public Form1()
        {
            InitializeComponent();
            SetupLayout();
            AllocConsole();
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Ensure console supports UTF-8
        }
        private readonly string shortcutPath = @"C:\Users\jacky.he\OneDrive - Kids II\Desktop\RealTime 2.2 V09.10.023 - 3.lnk";
        private readonly string processName = "RealTime"; // Process name without .exe

        private void SetupLayout()
        {
            this.Text = "Button Interface";
            this.Size = new System.Drawing.Size(1800, 600); // Increased height to accommodate 10 new rows
            this.BackColor = System.Drawing.Color.LightGray;

            // Use TableLayoutPanel for grid layout
            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 17,
                RowCount = 15, // Increased to 15 to include 10 new rows
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            // Set column styles to distribute evenly
            for (int i = 0; i < 17; i++)
            {
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 17));
            }

            // Set row styles
            for (int i = 0; i < 15; i++)
            {
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 15));
            }

            // Row 0 - Column Headers
            AddButtonToTable(tableLayout, "Group", 0, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Category", 1, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Product/Project Name", 2, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Product Innovation Type", 3, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Phase", 4, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Condition", 5, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Status", 6, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "OBS Date", 7, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Next Gate", 8, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "CPM", 9, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "PE", 10, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "CDM", 11, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "MPE", 12, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "DE", 13, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Awarded Vendor", 14, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Potential Vendor", 15, 0, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Material Number", 16, 0, Color.Red, Color.White);

            // Row 1 to 10 - Light green background, blank content
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 0; col < 17; col++)
                {
                    AddButtonToTable(tableLayout, "", col, row, Color.LightGreen, Color.Black);
                }
            }

            // Row 11 (originally Row 1)
            AddButtonToTable(tableLayout, "Select All", 0, 11, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "UnSelect All", 1, 11, Color.LightGray, Color.Black);
            AddButtonToTable(tableLayout, "Total: 504, 1 Cells Selected", 2, 11, Color.Pink, Color.Black);
            AddButtonToTable(tableLayout, "Loan Title", 3, 11, Color.Pink, Color.Black);
            AddButtonToTable(tableLayout, "Kanban All", 4, 11, Color.LightSalmon, Color.Black);
            AddButtonToTable(tableLayout, "Prod Sync 1080", 5, 11, Color.LightYellow, Color.Black);
            AddButtonToTable(tableLayout, "Name", 6, 11, Color.White, Color.Black);
            AddButtonToTable(tableLayout, "Late Tasks", 7, 11, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Key Milestones", 8, 11, Color.Yellow, Color.Black);
            AddButtonToTable(tableLayout, "Gate Submit", 9, 11, Color.LightYellow, Color.Black);
            AddButtonToTable(tableLayout, "Update Data", 10, 11, Color.Pink, Color.Black);
            AddButtonToTable(tableLayout, "All Actions", 11, 11, Color.Magenta, Color.White);
            AddButtonToTable(tableLayout, "", 12, 11, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 13, 11, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 14, 11, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 15, 11, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 16, 11, Color.White, Color.Black); // Placeholder

            // Row 12 (originally Row 2)
            AddButtonToTable(tableLayout, "82", 0, 12, Color.Pink, Color.Black);
            AddButtonToTable(tableLayout, "Kan Forecast", 1, 12, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "ProdSync 2K", 2, 12, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Assignee", 3, 12, Color.White, Color.Black);
            AddButtonToTable(tableLayout, "Late & Upcoming", 4, 12, Color.Yellow, Color.Black);
            AddButtonToTable(tableLayout, "Timelines", 5, 12, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "Material Status", 6, 12, Color.Black, Color.White);
            AddButtonToTable(tableLayout, "Get Material No", 7, 12, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Action List", 8, 12, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Open", 9, 12, Color.LightGray, Color.Black);
            AddButtonToTable(tableLayout, "Tool Release Check", 10, 12, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "PEM Timeline", 11, 12, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "", 12, 12, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 13, 12, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 14, 12, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 15, 12, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 16, 12, Color.White, Color.Black); // Placeholder

            // Row 13 (originally Row 3)
            AddButtonToTable(tableLayout, "Refresh the List", 0, 13, Color.LightGreen, Color.Black);
            AddButtonToTable(tableLayout, "Summary", 1, 13, Color.Khaki, Color.Black);
            AddButtonToTable(tableLayout, "Kanban 4 - Cost", 2, 13, Color.LightCoral, Color.Black);
            AddButtonToTable(tableLayout, "Core Team Deck", 3, 13, Color.LightPink, Color.Black);
            AddButtonToTable(tableLayout, "WF Project", 4, 13, Color.LightCyan, Color.Black);
            AddButtonToTable(tableLayout, "Find Projects", 5, 13, Color.LightBlue, Color.Black);
            AddButtonToTable(tableLayout, "All Open Tasks", 6, 13, Color.LightCyan, Color.Black);
            AddButtonToTable(tableLayout, "Time & Owner", 7, 13, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "MSRP FOB", 8, 13, Color.Black, Color.White);
            AddButtonToTable(tableLayout, "Business Brief", 9, 13, Color.Orange, Color.Black);
            AddButtonToTable(tableLayout, "All Action List", 10, 13, Color.LightCyan, Color.Black);
            AddButtonToTable(tableLayout, "Sample Tracker", 11, 13, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "Gate Deliverables", 12, 13, Color.Pink, Color.Black);
            AddButtonToTable(tableLayout, "Get Values", 13, 13, Color.Pink, Color.Black);
            AddButtonToTable(tableLayout, "", 14, 13, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 15, 13, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 16, 13, Color.White, Color.Black); // Placeholder

            // Row 14 (originally Row 5)
            AddButtonToTable(tableLayout, "Choose Views", 0, 14, Color.Pink, Color.Black);
            AddButtonToTable(tableLayout, "Load All Projects", 1, 14, Color.Yellow, Color.Black);
            AddButtonToTable(tableLayout, "Start RT", 2, 14, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Kanban 2", 3, 14, Color.LightSalmon, Color.Black);
            AddButtonToTable(tableLayout, "Budget - All", 4, 14, Color.LightBlue, Color.Black);
            AddButtonToTable(tableLayout, "Vendor Deck", 5, 14, Color.Yellow, Color.Black);
            AddButtonToTable(tableLayout, "Folder List", 6, 14, Color.LightCyan, Color.Black);
            AddButtonToTable(tableLayout, "Assignment", 7, 14, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Smart Sheet (TBD)", 8, 14, Color.Purple, Color.White);
            AddButtonToTable(tableLayout, "PKG Timeline", 9, 14, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "Brief Summary", 10, 14, Color.Orange, Color.Black);
            AddButtonToTable(tableLayout, "PAE Test Lab", 11, 14, Color.Black, Color.White);
            AddButtonToTable(tableLayout, "LRB Timeline", 12, 14, Color.Blue, Color.White);
            AddButtonToTable(tableLayout, "Plan VS Actual", 13, 14, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "Kids2 EE Site", 14, 14, Color.Red, Color.White);
            AddButtonToTable(tableLayout, "", 15, 14, Color.White, Color.Black); // Placeholder
            AddButtonToTable(tableLayout, "", 16, 14, Color.White, Color.Black); // Placeholder

            this.Controls.Add(tableLayout);
        }

        private void AddButtonToTable(TableLayoutPanel table, string text, int col, int row, Color backColor, Color foreColor)
        {
            Button button = new Button
            {
                Text = text,
                BackColor = backColor,
                ForeColor = foreColor,
                FlatStyle = FlatStyle.Flat,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };
            button.Click += ClickButton; // Add click event handler
            table.Controls.Add(button, col, row);
        }

        private void ClickButton(object? sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton != null)
            {
                Console.WriteLine($"点击: {clickedButton.Text}");
                clickedButton.ForeColor = Color.Aqua; // Change text color to white on click
                clickedButton.BackColor = Color.White; // Change background color to dark gray on click
                if (clickedButton.Text == "Start RT")
                {
                    Process[] isOpen = Process.GetProcessesByName(processName);
                    if (isOpen.Length > 0)
                    {
                        MessageBox.Show("Please close the RealTime before restarting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("RealTime is not open, proceeding to Start.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    try
                    {
                        System.Diagnostics.Process.Start
                        (
                            new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = shortcutPath,
                                UseShellExecute = true // Use shell to open the file
                            }
                        );
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show($"Error opening shortcut: {E.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}