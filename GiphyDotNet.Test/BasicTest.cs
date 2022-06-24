using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using System;
using System.Linq;
using Xunit;

namespace GiphyDotNet.Test
{
    public class BasicTest
    {
        string api_token;
        Giphy giphy;
        public BasicTest()
        {
            api_token = Environment.GetEnvironmentVariable("GIPHY_TOKEN");
            if (string.IsNullOrEmpty(api_token))
                throw new Exception("You must set the API Token in your Environment Variables!");
            giphy = new Giphy(api_token);
        }

        [Fact]
        public async void GifSearch()
        {
            var searchParameter = new SearchParameter()
            {
                Query = "awesome"
            };

            // Returns gif results
            var gifResult = await giphy.GifSearch(searchParameter);
            Assert.True(gifResult != null);
            Assert.True(gifResult.Data.Any());
            Assert.False(gifResult.Data.First().IsSticker);
        }

        [Fact]
        public async void GifSearchLanguage()
        {
            var searchParameter = new SearchParameter()
            {
                Query = "awesome",
                Language = "ja",
            };

            // Returns gif results
            var gifResult = await giphy.GifSearch(searchParameter);
            Assert.True(gifResult != null);
            Assert.True(gifResult.Data.Any());
            Assert.False(gifResult.Data.First().IsSticker);
        }

        [Fact]
        public async void StickerSearch()
        {
            var searchParameter = new SearchParameter()
            {
                Query = "awesome"
            };

            // Returns gif results
            var gifResult = await giphy.StickerSearch(searchParameter);
            Assert.True(gifResult != null);
            Assert.True(gifResult.Data.Any());
            Assert.True(gifResult.Data.First().IsSticker);
        }

        [Fact]
        public async void IdSearch()
        {
            var gifResult = await giphy.GetGifById("feqkVgjJpYtjy");
            Assert.True(gifResult != null);
            var gifsResult = await giphy.GetGifsByIds(new string[] { "feqkVgjJpYtjy", "7rzbxdu0ZEXLy" });
            Assert.True(gifsResult != null);
            Assert.True(gifsResult.Data.Length > 0);
        }

        [Fact]
        public async void RandomGifSearch()
        {
            var gifResult = await giphy.RandomGif(new RandomParameter()
            {
                Tag = "american psycho"
            });
            Assert.True(gifResult != null);
        }

        [Fact]
        public async void RandomStickerSearch()
        {
            var gifResult = await giphy.RandomSticker(new RandomParameter()
            {
                Tag = "american psycho"
            });
            Assert.True(gifResult != null);
        }

        [Fact]
        public async void BadRandomStickerSearch()
        {
            var gifResult = await giphy.RandomSticker(new RandomParameter()
            {
                Tag = "dfafnoewiqnfopafkmasdf"
            });
            Assert.True(gifResult != null);
        }
    }
}
