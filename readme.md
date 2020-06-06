## OpenVPN Adapter to use from Xamarin.Android and Xamarin.iOS

First of all, sorry for my bad english. Not a native english speaker. :)

This project aims to provide a demonstration about how to import openvpn library to android and iOS under c#. This project has been tested to be working under openvpn 3. It is a barebone project to transfer the beautiful library. 

Before starting, I would like to thank those where credit is due. Without them, it would not be possible to even think of this. 

OpenVPN Library https://github.com/OpenVPN/openvpn3  
schwabe OpenVPN Port for android https://github.com/schwabe/ics-openvpn  
ss-abramchuk OpenVPN Port for iOS https://github.com/ss-abramchuk/OpenVPNAdapter  

Dedicated platform specific code and scripting is required. Its possible to create a nuget package out of this project. Unfortunately I am not experienced enough to do this. Thats why, any contributions would be highly appreciated.  


The core library and the platforms specific ports contain their own license. I would advise you to visit the responding platform's source page and checkout their license.  
However, the codes used in this project by me is under MIT license. You are free to do however you see fit with this project. 

Please go though the platform specific code for implementation. A simple interface can later be created to start the vpn from xamarin.form supporting Android and iOS after platform specific implementation are working. 
 
Thanks.
