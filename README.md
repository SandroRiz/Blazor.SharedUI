# Blazor.SharedUI
Test/Demo Project for UI sharing between Blazor WASM/Server Web UI and MAUI windows/android native UI

Basically it shows the use of a Razor Class Library the contains all the Pages, Components (both Razor Components), MainLayout and assets (css, images, js, etc.)

![maui](https://user-images.githubusercontent.com/7381657/187089447-dfffc613-edef-46a7-961c-38c4a4a6a367.png)


Some considerations [in this blog post](https://www.rizzetto.com/Blog/post/share-ui-between-web-blazor-and-maui-desktop-apps) (italian only, sorry!)


Please don't use HttpClient like in this project (demo purpose only) but check [this video](https://www.youtube.com/watch?v=Z6Y2adsMnAA) for the right use (IHttpClientFactory)
