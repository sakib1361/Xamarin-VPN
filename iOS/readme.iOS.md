## IOS Development
The iOS project solely depends on ss-abramchuk OpenVPN Port for iOS https://github.com/ss-abramchuk/OpenVPNAdapter

The steps are divided into two parts. Build the xcodeproj using sharpie. And import the built library to our network extension.

Before starting, please read through ss-abramchuk on https://github.com/ss-abramchuk/OpenVPNAdapter and please make sure you understand all the requirements and apple developer account setup. 
Also a good source of helpful setup https://github.com/yaooort/OpenVPN-IOS

The steps also assumes that you have a xamarin iOS project up and built with Xamarin.iOS.


a. MAC Built. 
If you dont want to build library yourself, you can use the prebuil framework under prebuilt. However, I would encourage to follow this none the less which would give you latest update from the library and help you understand how things work.
    1. Clone https://github.com/ss-abramchuk/OpenVPNAdapter
    2. Install Sharpie Pod https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started
    3. Follow the procedure discussed here to create a framework built. 
        https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/examples/xcode?context=xamarin/ios
        
        After the built has been completed by sharpie, you should have a pretty similar structure wlike the prebuilt folder. Take some time to understand apidefinations. We will next be importing this built/prebuilt to our visual studio. 


b. Xamarin.iOS built.
After you have completed MAC built (or if skipped), you should be having a OpenVPNAdapter.framwork under Build=>Products. 
Also a ApiDefinations.cs and StructsAndEnum.cs under root. These 3 files are necessary under Xamarin project. I would suggest this step to be completed under Visual Studio MAC for the first time as intellisense wont work on windows version for APIDefination.cs.

    1. Create A new project with type iOS binding Library. (I would keep this under folder iOSHelpers both in Solution and Directory)
    2. Under Native Reference, import the OpenVPNAdapter.framework.
    3. Replace ApiDEfinations.cs and Enum with our sharpie built files. 
    4. Ensure that all data-types are working. Some complex types like byte[] are not supported. :(

    5. Create another new project with type Notification Extension. (Or whichever you preferred unlike ms adds network extension. It does not matter as we would be changing info.plist and entitlement.plist anyway). 
    Import/reference the iOS binding library created a 1.
    6. Follow the entitlement and info required by apple developer documents. The extension name must match with the developer dashboard. To be noted, you will require two set of entitlements. One for main app and another for extension. Make sure they are grouped. 
    7. Import the three files PacketTunnelProvider, ConfigHandler and delegator. The packet tunnel provider takes a Dictionary with profile, username, password. If you have encrypted password before, now is a good time to decrypt it just before prviding it to the library. 

    8. Setup of extension is complete. Now we need to make sure that the main app can start the tunnel. 
    The main application will also require the vpn and packet-tunnel permission as its extension.
    9. A sample iOSPlatformservice (Demo) has been added. You can follow this to start the tunnel. From here, its basically same. Create dictionary, create manager. Save preference. Start. Please follow the apple developer document and example if you are stuck here. 

Build and Test.

