MonoTouch bindings for TestFlight SDK
=================================

Before diving in, please be aware that TestFlight's SDK is compiled with THUMB instructions. This means that you won't know if the SDK will work in your app or not. It may work one day, then the next day it might not. Please read [this](http://bugzilla.xamarin.com/show_bug.cgi?id=1686) for more info. Also, read the [Code Generation Engine](http://docs.xamarin.com/ios/advanced_topics/compilation) section on Xamarin's docs.

Adding this lib to your project
-------------------------------

The SDK will only run properly on the device when built using the LLVM compiler. Make sure this is enabled in your project's advanced build settings.

1. Download the [TestFlight SDK](https://testflightapp.com/sdk/download/)
2. git clone this repository (or just download the [src archive](https://github.com/ayoung/monotouch-testflight/zipball/master))
3. In terminal, run "make" within the cloned repository
4. Copy libTestFlight.a (downloaded from step 1) and monotouch-testflight.dll (generated from "make") to the root of your proj. You can copy them to another relative location but you'll have to modify the gcc_flags specified down below to match the paths.
5. Add the monotouch-testflight.dll reference in your MonoTouch project
6. In your MonoTouch project options > iPhone Build
    - Set Linker behavior to "Link SDK assemblies only"
    - Set the Extra arguments in all iPhone Build configurations that you want to use the SDK in to:

      `-nosymbolstrip -nostrip -cxx -gcc_flags "-lgcc_eh -L${ProjectDir} -ltestflight -ObjC"`
      