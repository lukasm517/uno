﻿#if !__ANDROID__ && !__IOS__ && !__MACCATALYST__ && !__SKIA__ && !__WASM__
#nullable enable

using Uno.UI.Xaml.Controls;

namespace Microsoft.Web.WebView2.Core;

public partial class CoreWebView2
{
	internal INativeWebView? GetNativeWebViewFromTemplate() => null;
}
#endif
