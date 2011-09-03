MonoTouch bindings for TestFlight SDK v0.6 beta
=================================

Adding this lib to your project
-------------------------------

- Download the TestFlight SDK from their site.
- Clone this repository
- Run "make"
- Copy libTestFlight.a (downloaded step 1) and monotouch-testflight.dll (generated from "make") to the root of your proj. You can copy them to another relative location but you'll have to modify the gcc_flags specified down below to match the paths.
- Add .dll reference in your MonoTouch project for monotouch-testflight.dll
- In your MonoTouch project options > iPhone Build
    - Set Linker behavior to "Link SDK assemblies only"
    - Set the Extra arguments in all iPhone Build configurations that you want to use the SDK in to:

      `-v -v -v -nosymbolstrip -gcc_flags "-L${ProjectDir} -ltestflight -ObjC"`