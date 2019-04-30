# launch-gal-props
Utilized to launch Global Address List properties for a specific Active Directory ID directly from Lync 2013 or Skype for Business 2016.

For more information please see the [blog post here](https://nigglingaspirations.blogspot.com/2017/11/skype-for-business-lync-2013-outlook.html).

In earlier version of Office Communication Server 2007 / Lync 2010, we were able to directly right click on someone's name and launch the Outlook properties dialog.  This functionality has been removed in later versions of the Lync Client (2013 and onwards).  In order to restore this functionality, we are able to utilize the methodology described by Microsoft [here](https://docs.microsoft.com/en-us/lyncserver/lync-server-2013-adding-commands-to-lync-menus).

Instructions:

1. Clone or download the repository zip and extract it to wherever (ex. C:\LaunchGALProps)
2. Compile the attached Program.cs -- if you do not have Visual Studio or an alternative installed, but you do in fact have .NET v4.0 (or higher) installed, you can utilize the command line compiler like so: `C:\Windows\Microsoft.Net\v4.0.30319\csc.exe /out:C:\LaunchGALProps\LaunchGALProps.exe Program.cs`
3. Once you have successfully compiled the application, drop it in a known point and update the LaunchGALProps.reg's **ApplicationInstallPath** and **Path** values.
