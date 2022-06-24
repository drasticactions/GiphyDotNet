// <copyright file="MainPage.xaml.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using GiphyDotNet.Sample.ViewModels;

namespace GiphyDotNet.Sample;

public partial class MainPage : ContentPage
{
    private SampleViewModel vm;

    public MainPage(SampleViewModel vm)
    {
        this.InitializeComponent();
        this.vm = vm;
        this.BindingContext = vm;
    }

    /// <inheritdoc/>
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await this.vm.OnLoad();
    }
}