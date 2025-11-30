#first time setup

cls

# .NET 9.0.100
.\profile.ps1 -package com.companyname.mauiappdefault -activity crc6401f73e8879e5c160.MainActivity

# .NET 10.0.10
.\profile.ps1 -package com.companyname.mauiapp10default -activity crc64cfb40c98d3edc3e2.MainActivity


# .NET 9.0.100 MauiReactor
.\profile.ps1 -package com.companyname.mauiappreactor -activity crc64bfb9b07720d9155f.MainActivity

# .NET 10.0.10 MauiReactor
.\profile.ps1 -package com.companyname.mauiapp10reactor -activity crc64153b342623c39f56.MainActivity

cls

# real run

# .NET 9.0.100
.\profile.ps1 -package com.companyname.mauiappdefault -activity crc6401f73e8879e5c160.MainActivity

# .NET 10.0.10
.\profile.ps1 -package com.companyname.mauiapp10default -activity crc64cfb40c98d3edc3e2.MainActivity


# .NET 9.0.100 MauiReactor
.\profile.ps1 -package com.companyname.mauiappreactor -activity crc64bfb9b07720d9155f.MainActivity

# .NET 10.0.10 MauiReactor
.\profile.ps1 -package com.companyname.mauiapp10reactor -activity crc64153b342623c39f56.MainActivity
