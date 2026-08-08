namespace TreasuryToolkit.App
{
    public partial class ExceptionHandlerForm : Form
    {
        private readonly Exception exception;

        public ExceptionHandlerForm(Exception exception)
        {
            InitializeComponent();
            this.exception = exception;
        }

        override protected void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TxtExceptionDetails.Text = $"{exception.Message}\n\n\n{exception.InnerException}";
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void BtnCopyDtls_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtExceptionDetails.Text);
        }
    }
}
