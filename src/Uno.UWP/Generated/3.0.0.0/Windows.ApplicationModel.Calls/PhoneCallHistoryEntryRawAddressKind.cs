#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum PhoneCallHistoryEntryRawAddressKind 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		PhoneNumber,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		Custom,
		#endif
	}
	#endif
}
