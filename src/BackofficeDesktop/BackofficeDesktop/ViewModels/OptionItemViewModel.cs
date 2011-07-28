namespace BackofficeDesktop.ViewModels
{
    public class OptionItemViewModel
    {
        private readonly string _caption;

        public OptionItemViewModel(string caption)
        {
            _caption = caption;
        }

        public string Caption
        {
            get { return _caption; }
        }
    }
}