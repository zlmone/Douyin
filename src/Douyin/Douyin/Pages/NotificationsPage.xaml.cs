using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Douyin.Pages
{
    public class NotificationsPage : UserControl
    {
        public NotificationsPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
