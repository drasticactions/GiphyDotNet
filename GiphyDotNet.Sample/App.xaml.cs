// <copyright file="App.xaml.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace GiphyDotNet.Sample;

public partial class App : Application
{
    private IServiceProvider serviceProvider;

    public App(IServiceProvider services)
    {
        this.InitializeComponent();
        this.serviceProvider = services;
        this.MainPage = new MainPage(new ViewModels.SampleViewModel(this.serviceProvider));
    }
}
