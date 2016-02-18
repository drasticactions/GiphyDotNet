# GiphyDotNet

GiphyDotNet is a simple .NET wrapper library for the [Giphy](http://giphy.com) API. Giphy is a search engine for gifs, enabling developers to find new and interesting ways to intergrate gifs from the Internet into their applications (and ways for people in Marketing to annoy people like me with endless amounts of Cat gifs in Slack). GiphyDotNet is a way to consume to Giphy API without having to handle the requests yourself.

###Getting Started

Simply go to [Nuget](https://www.nuget.org/packages/GiphyDotNet/) and download the library. You can also get it directly from the package manager.

###Gif/Sticker Search

```c#
var giphy = new Giphy("apikey");
var searchParameter = new SearchParameter()
            {
                Query = "awesome"
            };
// Returns gif results
var gifResult = await giphy.GifSearch(searchParameter);

var stickerResult = await giphy.StickerSearch(searchParameter);
```

###Gif By ID/IDs

```c#
var giphy = new Giphy("apikey");
var gifResult = await giphy.GetGifById("feqkVgjJpYtjy");
var gifsResult = await giphy.GetGifsByIds(new string[] { "feqkVgjJpYtjy", "7rzbxdu0ZEXLy" });
```

###Random Gif/Sticker

```c#
var giphy = new Giphy("apikey");
var gifresult = await giphy.RandomGif(new RandomParameter()
{
   Tag = "american psycho"
});
var stickerresult = await giphy.RandomSticker(new RandomParameter()
{
   Tag = "american psycho"
});
```

###Translate Into Gif/Sticker

```c#
var giphy = new Giphy("apikey");
var gifresult = await giphy.TranslateIntoGif(new RandomParameter()
{
   Tag = "american psycho"
});
var stickerresult = await giphy.TranslateIntoSticker(new RandomParameter()
{
   Tag = "american psycho"
});
```

###Trending Gif/Stickers

```c#
var giphy = new Giphy("apikey");
var gifResult = await giphy.TrendingGifs(new TrendingParameter());
var stickerresult = await giphy.TrendingStickers(new TrendingParameter());
```

###License

This library is licensed under the MIT License.
