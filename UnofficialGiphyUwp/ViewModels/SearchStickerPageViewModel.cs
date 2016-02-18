using Template10.Mvvm;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using UnofficialGiphyUwp.Tools.ScrollingCollection;

namespace UnofficialGiphyUwp.ViewModels
{
    public class SearchStickerPageViewModel : ViewModelBase
    {
        public SearchStickerPageViewModel()
        {
        }
        private readonly Giphy _giphy = new Giphy();
        private SearchStickerScrollingCollection _searchScrollingCollection;
        public SearchStickerScrollingCollection SearchScrollingCollection { get { return _searchScrollingCollection; } set { Set(ref _searchScrollingCollection, value); } }
        string _Value = string.Empty;
        public string Value { get { return _Value; } set { Set(ref _Value, value); } }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (state.Any())
            {
                Value = state[nameof(Value)]?.ToString();
                state.Clear();
            }
            return Task.CompletedTask;
        }

        public override Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending)
        {
            if (suspending)
            {
                state[nameof(Value)] = Value;
            }
            return Task.CompletedTask;
        }

        public override Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            return Task.CompletedTask;
        }

        public void SearchQuery()
        {
            if (string.IsNullOrEmpty(Value)) return;
            SearchScrollingCollection = new SearchStickerScrollingCollection(new SearchParameter()
            {
                Query = Value
            });
        }

        public async void TranslateTest()
        {
            var result = await _giphy.TranslateIntoSticker(new TranslateParameter()
            {
                Phrase = "superman"
            });
        }

        public async void RandomTest()
        {
            var result = await _giphy.RandomSticker(new RandomParameter()
            {
                Tag = "american psycho"
            });
        }

        public async void TrendingTest()
        {
            var result = await _giphy.TrendingStickers(new TrendingParameter());
        }
    }
}

