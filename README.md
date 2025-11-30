
# .NET MAUI App Startup Performance Profiling

## Device: Samsung Tab Active5 SM-X300

## .NET 9.0.100

.\profile.ps1 -package com.companyname.mauiappdefault -activity crc6401f73e8879e5c160.MainActivity

Results: 
Average(ms): 2307.4
Std Err(ms): 5.25822107645627
Std Dev(ms): 16.6279550423042

## .NET 10.0.10

.\profile.ps1 -package com.companyname.mauiapp10default -activity crc64cfb40c98d3edc3e2.MainActivity

Results: 
Average(ms): 2410.6
Std Err(ms): 6.08495412198536
Std Dev(ms): 19.2423144831038


## .NET 9.0.100 - MauiReactor 3.0.39

.\profile.ps1 -package com.companyname.mauiappreactor -activity crc64bfb9b07720d9155f.MainActivity

Results: 
Average(ms): 1601.3
Std Err(ms): 5.42022959743302
Std Dev(ms): 17.1402709689459


## .NET 10.0.10 - MauiReactor 4.0.2-beta

.\profile.ps1 -package com.companyname.mauiapp10reactor -activity crc64153b342623c39f56.MainActivity

Results: 
Average(ms): 1388.4
Std Err(ms): 3.91350936571711
Std Dev(ms): 12.3756032400669

## Startup Performance Comparison

### .NET 9.0.100
```
MauiReactor .NET 9   █████████████████████████████████████████ 1601.3ms
Standard .NET 9      ███████████████████████████████████████████████████████████████ 2307.4ms
```

### .NET 10.0.10
```
MauiReactor .NET 10  ████████████████████████████████████ 1388.4ms
Standard .NET 10     ████████████████████████████████████████████████████████████████████ 2410.6ms
```
*Scale: Each █ represents ~37ms*


# How to run the profiling script

## Prerequisites
- Ensure you have ADB (Android Debug Bridge) installed and added to your system PATH.
- Connect your Android device via USB and enable USB debugging.
- Make sure all the .NET MAUI app are installed on the device in release mode (run at least one time all the project in release mode)
- PowerShell 5.0 or higher is installed on your machine.


## Steps to Run the Profiling Script
1. Restart your Android device to ensure a clean state.
2. Run the profile-all powershell script:
   ```powershell
   .\profile-all.ps1
   ```

