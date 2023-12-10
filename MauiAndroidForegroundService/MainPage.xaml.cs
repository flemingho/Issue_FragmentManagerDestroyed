using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAndroidForegroundService;

public partial class MainPage : FlyoutPage
{
    private readonly IMessenger _messenger;

    public MainPage()
	{
        _messenger = IPlatformApplication.Current.Services.GetService<IMessenger>();
        InitializeComponent();

        //_messenger = messenger;
    }

    private void Start_OnClicked(object sender, EventArgs e)
    {
        _messenger.Send(new MessageData(Input.Text, true));
    }

    private void Stop_OnClicked(object sender, EventArgs e)
    {
        _messenger.Send(new MessageData(Input.Text, false));
    }
}

