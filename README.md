MonoTouch bindings for TestFlight SDK
=================================

Adding this lib to your project
-------------------------------

1. Download the TestFlight SDK from their site.
2. Clone this repository
3. In terminal, run "make" within the cloned repository
4. Copy libTestFlight.a (downloaded step 1) and monotouch-testflight.dll (generated from "make") to the root of your proj. You can copy them to another relative location but you'll have to modify the gcc_flags specified down below to match the paths.
5. Add the monotouch-testflight.dll reference in your MonoTouch project
6. In your MonoTouch project options > iPhone Build
    - Set Linker behavior to "Link SDK assemblies only"
    - Set the Extra arguments in all iPhone Build configurations that you want to use the SDK in to:

      `-nosymbolstrip -nostrip -cxx -gcc_flags "-lgcc_eh -L${ProjectDir} -ltestflight -ObjC"`
      