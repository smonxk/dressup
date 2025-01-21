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
            // centering the loading elements
            layoutManager.CenterControl(hvezdaLoading, -70);
            layoutManager.PositionBelow(textLoading, hvezdaLoading, 40);

            //  3.5 second swait  before loading the next form
            await Task.Delay(2500);

            // Use the UI thread for UI updates
            this.Invoke((Action)(() =>
            {
                try
                {
                    
                    Form nextForm = _loadingLogic.GetNextFormAfterLoading();

                    if (nextForm != null)

                    { 
                        this.Close(); 
                        this.Dispose();
                        nextForm.ShowDialog();  
                    }
                    else
                    {
                        
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while transitioning to the next form: " + ex.Message);
                }
            }));
        }
    }
}
