// <copyright file="SampleViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Collections.ObjectModel;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.GiphyImage;

namespace GiphyDotNet.Sample.ViewModels
{
    public class SampleViewModel : BaseViewModel
    {
        private string searchParameter = string.Empty;
        private string apiKey = string.Empty;
        private Giphy? giphy;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleViewModel"/> class.
        /// </summary>
        /// <param name="services"><see cref="IServiceProvider"/>.</param>
        public SampleViewModel(IServiceProvider services)
            : base(services)
        {
            this.Title = "GiphyDotNet Sample";
            this.ApiKeyCommand = new AsyncCommand<string>(
                this.SetApiClient,
                (string key) =>
                {
                    return this.EnableApiKeyCommand;
                },
                this.ErrorHandler);
            this.SearchGifCommand = new AsyncCommand<string>(
                this.SearchGif,
                (string key) =>
                {
                    return this.EnableSearchCommand;
                },
                this.ErrorHandler);
            this.SearchStickerCommand = new AsyncCommand<string>(
                this.SearchSticker,
                (string key) =>
                {
                    return this.EnableSearchCommand;
                },
                this.ErrorHandler);
            this.RandomGifCommand = new AsyncCommand<string>(
                this.RandomGif,
                (string key) =>
                {
                    return this.EnableSearchCommand;
                },
                this.ErrorHandler);
            this.RandomStickerCommand = new AsyncCommand<string>(
                this.RandomSticker,
                (string key) =>
                {
                    return this.EnableSearchCommand;
                },
                this.ErrorHandler);
        }

        public AsyncCommand<string> ApiKeyCommand { get; private set; }

        public AsyncCommand<string> SearchGifCommand { get; private set; }

        public AsyncCommand<string> SearchStickerCommand { get; private set; }

        public AsyncCommand<string> RandomGifCommand { get; private set; }

        public AsyncCommand<string> RandomStickerCommand { get; private set; }

        public ObservableCollection<Data> Images { get; private set; } = new ObservableCollection<Data>();

        /// <summary>
        /// Gets a value indicating whether there is a valid API key set.
        /// </summary>
        public bool EnableApiKeyCommand => !this.IsBusy && this.giphy is null && !string.IsNullOrEmpty(this.apiKey);

        public bool EnableSearchCommand => !this.IsBusy && this.giphy is not null && !string.IsNullOrEmpty(this.searchParameter);

        /// <summary>
        /// Gets a value indicating whether the Api Key command is disbled.
        /// </summary>
        public bool DisableApiKeyCommand => !this.IsBusy && this.giphy is null;

        public bool EnableSearchStringCommand => !this.IsBusy && this.giphy is not null;

        /// <summary>
        /// Gets or sets a value for the Giphy API key.
        /// </summary>
        public string ApiKey
        {
            get { return this.apiKey; }
            set { this.SetProperty(ref this.apiKey, value); }
        }

        /// <summary>
        /// Gets or sets a value for the search parameter.
        /// </summary>
        public string SearchParameter
        {
            get { return this.searchParameter; }
            set { this.SetProperty(ref this.searchParameter, value); }
        }

        /// <inheritdoc/>
        public override void RaiseCanExecuteChanged()
        {
            base.RaiseCanExecuteChanged();
            this.ApiKeyCommand?.RaiseCanExecuteChanged();
            this.OnPropertyChanged(nameof(this.EnableApiKeyCommand));
            this.OnPropertyChanged(nameof(this.DisableApiKeyCommand));
            this.OnPropertyChanged(nameof(this.EnableSearchStringCommand));
        }

        private async Task SetApiClient(string apiKey)
        {
            this.IsBusy = true;

            try
            {
                this.giphy = new Giphy(apiKey);
                var result = await this.giphy.RandomGif(new Model.Parameters.RandomParameter() { Tag = "random" });
            }
            catch (Exception)
            {
                this.giphy = null;
                this.ApiKey = string.Empty;
                this.IsBusy = false;
                throw;
            }

            this.IsBusy = false;
        }

        private async Task SearchGif(string searchCommand)
        {
            ArgumentNullException.ThrowIfNull(this.giphy);

            // This will only get the first results.
            // If you need to pass in additional ones, you can add them to the Search Parameter object.
            var result = await this.giphy.GifSearch(new Model.Parameters.SearchParameter() { Query = searchCommand });
            if (result?.Data is null)
            {
                throw new NullReferenceException("Result is null");
            }

            this.SetImages(result.Data);
        }

        private async Task SearchSticker(string searchCommand)
        {
            ArgumentNullException.ThrowIfNull(this.giphy);

            // This will only get the first results.
            // If you need to pass in additional ones, you can add them to the Search Parameter object.
            var result = await this.giphy.StickerSearch(new Model.Parameters.SearchParameter() { Query = searchCommand });
            if (result?.Data is null)
            {
                throw new NullReferenceException("Result is null");
            }

            this.SetImages(result.Data);
        }

        private async Task RandomGif(string searchCommand)
        {
            ArgumentNullException.ThrowIfNull(this.giphy);

            // This will only get the first results.
            // If you need to pass in additional ones, you can add them to the Search Parameter object.
            var result = await this.giphy.RandomGif(new Model.Parameters.RandomParameter() { Tag = searchCommand });
            if (result?.Data is null)
            {
                throw new NullReferenceException("Result is null");
            }

            this.SetImages(new Data[1] { result.Data });
        }

        private async Task RandomSticker(string searchCommand)
        {
            ArgumentNullException.ThrowIfNull(this.giphy);

            // This will only get the first results.
            // If you need to pass in additional ones, you can add them to the Search Parameter object.
            var result = await this.giphy.RandomSticker(new Model.Parameters.RandomParameter() { Tag = searchCommand });
            if (result?.Data is null)
            {
                throw new NullReferenceException("Result is null");
            }

            this.SetImages(new Data[1] { result.Data });
        }

        private void SetImages(Data[] images)
        {
            this.Images.Clear();

            foreach (var image in images)
            {
                this.Images.Add(image);
            }
        }
    }
}
