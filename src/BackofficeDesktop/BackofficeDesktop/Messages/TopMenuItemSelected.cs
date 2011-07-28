namespace BackofficeDesktop.Messages
{
    public class TopMenuItemSelected
    {
        private readonly string _caption;

        public TopMenuItemSelected(string caption)
        {
            _caption = caption;
        }

        public string Caption
        {
            get { return _caption; }
        }
    }
}