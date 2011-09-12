using MonoTouch.Foundation;  
using System;

namespace TestFlightSdk
{
	[BaseType (typeof (NSObject))]  
	interface TestFlight
	{
		// + (void)addCustomEnvironmentInformation:(NSString *)information forKey:(NSString*)key;
		[Static, Export ("addCustomEnvironmentInformation:forKey:")]
		void AddCustomEnvironmentInformation (string information, string key);

		// + (void)takeOff:(NSString *)teamToken;
		[Static, Export ("takeOff:")]
		void TakeOff (string teamToken);
		
		// + (void)setOptions:(NSDictionary*)options;
		[Static, Export ("setOptions:")]
		void SetOptions (NSDictionary options);

		// + (void)passCheckpoint:(NSString *)checkpointName;
		[Static, Export ("passCheckpoint:")]
		void PassCheckpoint (string checkpointName);
		
		// + (void)openFeedbackView;
		[Static, Export ("openFeedbackView")]
		void OpenFeedbackView ();

	}
}