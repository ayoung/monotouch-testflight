SOURCES = \
	TestFlightSdk.cs

all: monotouch-testflight.dll

monotouch-testflight.dll: $(SOURCES)
	/Developer/MonoTouch/usr/bin/btouch -out=monotouch-testflight.dll TestFlightSdk.cs
