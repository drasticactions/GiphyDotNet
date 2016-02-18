using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Media.Streaming.Adaptive;
using Windows.UI.Xaml.Data;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.GiphyImage;
using GiphyDotNet.Model.Parameters;

namespace UnofficialGiphyUwp.Tools.ScrollingCollection
{
    public class SearchStickerScrollingCollection : ObservableCollection<Data>, ISupportIncrementalLoading
    {
        public SearchStickerScrollingCollection(SearchParameter search)
        {
            _search = search;
            HasMoreItems = true;
        }

        private readonly Giphy _giphy = new Giphy();
        private readonly SearchParameter _search;
        public int Offset;
        private bool _isEmpty;
        private int _total;
        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading; }

            private set
            {
                _isLoading = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IsLoading"));
            }
        }

        public int Total
        {
            get { return _total; }

            private set
            {
                _total = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
        }

        public bool IsEmpty
        {
            get { return _isEmpty; }

            private set
            {
                _isEmpty = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IsEmpty"));
            }
        }

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            return LoadDataAsync(count).AsAsyncOperation();
        }

        private async Task<LoadMoreItemsResult> LoadDataAsync(uint count)
        {
            return await SearchQuery(count);
        }

        private async Task<LoadMoreItemsResult> SearchQuery(uint count)
        {
            IsLoading = true;
            _search.Offset = Offset;
            var result = await _giphy.StickerSearch(_search);
            foreach (var item in result.Data)
            {
                Add(item);
            }
            if (!result.Data.Any())
            {
                HasMoreItems = false;
            }
            Offset += result.Pagination.Count;
            Total = result.Pagination.TotalCount;
            IsLoading = false;
            return new LoadMoreItemsResult { Count = count };
        }

        public bool HasMoreItems { get; protected set; }
    }
}
