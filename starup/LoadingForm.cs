using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starup
{
    public partial class LoadingForm : Form
    {
        private LayoutManager layoutManager;
        private LoadingLogic _loadingLogic;

        public LoadingForm(LoadingLogic logic)
        {
            InitializeComponent();
            layoutManager = new LayoutManager(this);
            _loadingLogic = logic;
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            // Center the loading elements
            layoutManager.CenterControl(hvezdaLoading, -70);
            layoutManager.PositionBelow(textLoading, hvezdaLoading, 40);

            // Wait for 3.5 seconds before loading the next form
            await Task.Delay(3500);

            // Use the UI thread for UI updates
            this.Invoke((Action)(() =>
            {
                try
                {
                    // Get the next form based on the loading logic
                    Form nextForm = _loadingLogic.GetNextFormAfterLoading();

                    if (nextForm != null)
                    {
                        // Close the loading form first to make sure it's disposed of properly
                        this.Close();  // Close the loading form

                        // Dispose the loading form to ensure it's fully removed from the memory
                        this.Dispose();

                        // Show the next form
                        nextForm.ShowDialog();  // Show the next form modally
                    }
                    else
                    {
                        // If no valid next form, just close the loading form
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while transitioning to the next form: " + ex.Message);
                }
            }));
        }

        private void hvezdaLoading_Click(object sender, EventArgs e)
        {
            // Handle click if necessary
        }
    }
}

