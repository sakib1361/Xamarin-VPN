## Android development
The android part of the Xamarin.Android uses the openvpn3 specific code. The required api is Android 21 (5.0). Its possible to support previous android versions all the way upto android ics (4.0). But currently not tested and out of the procedure for todays walkthrough

The android code solely depends on the https://github.com/schwabe/ics-openvpn.  
Please have a look there and checkout the sourcecode. 

The development is divided into two parts. We would be building a aar library from android studio and use that library to import in xamarin. We would slightly extend the interface within jave to be readily available to use within our c# environment. All the source code and prebuilt aar library can be found in the Android folder.

# Lets start. 

a. Android Studio.
   Please follow the https://github.com/schwabe/ics-openvpn to succesfully build the apk on android studio. You would be requiring several sub libraries to complete the process. Once you are confident that the build is successful, we can proceed to make a bindable library out of it. 

1. We would require to mimic the process, but this time we would only create a library outputting the aar library files. So create a new android library project.
2. Use all the build process used to build apk. Here we would only use the build procedure for openvpn 3. We would require to copy the cpp libraries to the new project. The sample files have been added to the BindableLibrary. U can also import this to the current schwabe project and copy the cpp there. 
3. Take a look at DroidVpnContainer.java, this would be used as our c# entrypoint which in terms extends ClientAPI_OpenVPNClient. This is absolutely necessary. Otherwise c# wont see ClientAPI_OpenVPNClient and ommit importing this. 
4. Build the library. You can use a single output with aar. Platform specific library can be seperated later.

b. Visual Studio.
Now we have a prebuild either from android studio.  
1. Create a new project with type android binding library. 
2. Import the aar file to folder jars and set build type to "LibraryProjectZip". Please see microsoft documents for more details. 
3. Build and ensure that it builts. (Quick hint, output dll would be 15~25 MB).
4. Reference this project with main Xamarin.Android project. 
5. Extend our DroidVpnContainer 

...
 public class OpenVpnManagement : DroidVpnContainer, Java.Lang.IRunnable, IOpenVpnManagement
    {

        //Do not use this. Only for internal library
        public OpenVpnManagement()
        {

        }
...
You must have the parameterless constructor. Othersise, may face with some termination issues. You can add other constructor without issues. 

6. Now you can follow the schwabe library to build a management on top of the interface. This may have a notification handler, a vpn management and some config files. The codes here are pretty similar with OpenVPNManagement3 in the library.  
(Quick hint, if needed threading and or timer, please use the java thread and status poller. The .net ones work upto some extent, but not reliable)

Happy coding. 