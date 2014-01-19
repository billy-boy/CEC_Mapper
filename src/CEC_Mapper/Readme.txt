CEC_Mapper by billy-boy

The CEC_Mapper reacts on HDMI CEC events received by an adapter controlled from libCEC. This is normaly a Pulse-Eight USB CEC Adapter.
For more information about libCEC or Pulse-Eight please visit: http://www.pulse-eight.com/store/

You will not need to confg any other software or libCEC. This will be done all through CEC_Mapper.
Important: You can not use more than one software communicating with your adapter. So if you run this software please deactivate the libCEC controll in your MediaPortal, XBMC or whatever.

You have to copy your libCEC library to the applications base directory in order to work. Please the below at the section "libCEC".
Please be shure and patient to make the right settings for libCEC inside the configuration tool of CEC_Mapper. You can reach the configuration tool from the taskbar tray icon. libCEC is very sensitive with wrong settings.

The CEC_Mapper receives all the keys pressed on your remote (all the ones libCEC can handle) and some predefined events (only some of the ones libCEC can handle because most are not important).

CEC_Mapper will translate these keys to keyboard keys as you defined. These keyboard keys will be sent to your application like you pressed them on your keyboard. With this handling it's possible to use nearly any application with your TV's remote.
Because of limits in the Windows API it is only possible to send keyboard input to the actual front window. But this is no big problem. CEC_Mapper stores lists by process name. So you can save key mappings for more than one application.

Normaly you can configure all settings very easy through the config menu (you can find it in the tray icon). If you want to edit manualy here are some information:
Important: If you edit things manualy some of them could be overwritten if you then use the config tool later on. You can use the config tool to view all, but in some cases add/delete will overwrite manually settings.

libCEC
----------------
Please copy your libcec.dll and LibCecSharp.dll inside the applications base directory.
This is done because different versions of libCEC communicate with different firmwares of the adapters. To be open for own experimentations you can copy the versions you need.
We tested with libCEC 2.1.4.0-

Key Code Mapping
----------------
Under your application directory all the key mapping settings are stored in the "mapping" folder. For each process there exists a file called "PROCESSNAME.cfg". It's important that the name is right.
The file structure is very simple. There exist three sections to controll the mapping.

[Process]
Name=notepad
[KeyMap_KeyPress]
0=45,Shift
[KeyMap_Events]
SourceActivated=MAKRO:C:\Windows\system32\calc.exe

This is a small sample for the "notepad" as process with actual front window. The detecting is based on the real parent process's name of a window. So subwindows (like DialogBoxes) are detected well.
As you can see the section [KeyMap_KeyPress] stands for the remote keys while [KeyMap_Events] stands for all the events raised.

An [KeyMap_KeyPress] entry's token is presented by the 32-bit Integer value of it's enum given from libCEC (you can find it out by looking in the debug logs when pressing keys on your remote) or simple have a look in the documentation of libCEC. It represtens the "CecUserControlCode" enum.
An [KeyMap_Events] entry's token is presented by it's String-Definition. There are the following possible:
SourceActivated=
SourceDeactivated=
Please note. These events are only used if the actual front window of Windows belongs to the process specified! These aren't global hooks.

IMPORTANT: The event handling is not implemented in this version.

The value of each token consists either of the information to press a keyboard key or of the word "MAKRO:" in case the CEC_Mapper should execute another application.
A keyboard key is presented by it's 32-bit Interger value as it's defined in the .NET "Keys" enum (cast it to an int and you see the result). If there also should pressed modifier keys (Shift, Alt, Control) these must be added separated by comma:
0=45,Shift,Alt,Control
The order is not important. Only the first entry after the "=" has to be the 32-bit Integer value.
If yout want to change the mode a keyboard key is handled you can add the value 'KeyDownUp' separated by comma (like the Shift/Alt/Control). If you add this a remote control key down event will be send as a key down event to your application and the corresponding key up event as a key up event.
If you do not specify this CEC_Mapper will only react to the key up event from your remote control and raise a key press to your application. IMPORTANT: Some applications are coded to react only to the key up event (also known as key press then). In some applications this "key hold down" works in some you have to press the key multiple times.
A macro is presented by the word "MAKRO:" followed by the path to the application you want run. After that you can specify arguments for your application, if a window should created (in case of console scripts) or which window state this window should have:
0=MAKRO:C:\Windows\system32\shutdown.exe,-r,true,0
The parameters for Argument, CreateNoWindow and WindowState need not to exist. They are passed directly to .NET's ProcessStartInfo. The value for CreateNoWindow must be "true" or "false" and the value for WindowStyle represents the 32-Bit Integer cast of the System.Diagnostics.ProcessWindowStyle enum.

What to do if you want a global key mapping or event raising?
If we don't know the actual foreground window, there is no way for global mapping actually (use the sources and code it yourself -.-)
But if you're running Windows without any opened Window then you can simply use "explorer" as process name, because this is the name of the foreground windows's process (the desktop).

Key sender configuration
------------------------
In 'mapper.cfg' you can control what should happen if a process is not known or a key mapping entry is not found.
You can specify a default process (e.g. a dummy process) and use the keymap of this instead. Remember: The keys are always sent to the foreground window. This is more usable for macros.

DefaultProcess=DUMMY
UseDefaultOnProcessNotFound=true
UseDefaultOnKeyMapNotFound=false

libCEC configuration
--------------------
The most problems resist in HDMI CEC configuration. Please be absolutely shure that all the settings here are correct. You can edit them in the program base dir in "config.cfg" (and via config tool also).
It looks like:

DeviceType=1
DeviceName=HTPC
ConnectionTimeout=2000
CEC_LogLevel=31
CEC_Vendor=240
HDMI_Port=3
CEC_BaseDevice=5

The DeviceType is the type of device THIS pc is reacting at. Mostly it's "RecordingDevice1". The DeviceType is presented by the 32-Bit Integer cast oft it's libCEC value. See below for a list!
The DeviceName is the name which is shown on your TV for this device.
The ConnectionTimeout is the timeout between liBCEC and your adapter. So if your adapter does not answear after this time it raises a failure. But don't be worry, CEC_Mapper trys again and again. ;-)
The CEC_LogLevel represent the level of log given from your adapter to libCEC. With this we could get all the traffic on the HDMI CEC. It's again a cast to 32-bit Integer.
Important: If you want to see the log messages you have to turn on DEBUG-Log for the CEC_Mapper which is done in the applications XML configuration.
The CEC_Vendor (hey it's an 32-Bit integer cast) representes vendor specific CEC extensions for libCEC. Select your Vendor or None.
The HDMI_Port is the most important value. It's an Byte cast! As I know libCEC can handle only numbers from 1 to 15. It represents the port number on which your PC is connected to the next device (TV or AVR).
This number is very important and must be right. If it's wrong there is no communication!
The CEC_BaseDevice represents the device on which this PC is connected (AVR or TV or so on). It's very important again that this is correct! A list of numbers you can find below in the section "SpecialOperations". Do not use the values from "DeviceType"!

Here is an overview of the value for the DeviceType:

Int32 value of CecDeviceType
----------------------------
Tv: 0
RecordingDevice: 1		<- Normaly HTPC is this
Reserved: 2
Tuner: 3
PlaybackDevice: 4		<- If HTPC only playback's it could also be this
AudioSystem: 5

Logging
--------------------
If you want to have a look whats going on (which keys are translated to what or why not) you can look in the application log. The log is in the application base dir and called 'Log.txt'.
If you want to see debug information (for libCEC log messages or so on) you can enable this in the applications XML configuration. We are using log4net for this.
For more information visit: http://logging.apache.org/log4net/
Improtant: You have to restart the whole application to make this setting valid.


CommandLine Arguments
----------------------
If you want to actively send CEC messages you can do this by running the application with command line arguments:
CEC_Wakeup[=CecLogicalAddress]		-> Wakes up the specified device or (if no device provided) wakes up TV and AV receiver. The device has to be specified by it's 32-bit integer value (see abobe).
CEC_Standby[=CecLogicalAddress]		-> Sends the specified device to standby or (if no device provided) sends TV and AV receiver to standby. The device has to be specified by it's 32-bit integer value (see abobe).
CEC_ActiveSource					-> Sets this source as the active source (so TV switches to this source)
CEC_InactiveSource					-> Sets this source inactive (so TV can do something else like switch away from this source)

These are the Int32 values of the HDMI CEC components to wakeup/standby. You have to test to which one your device answears and if it answears (not all do):

32-bit Integer values of CecLogicalAddress
-------------------------------------------
Tv: 0									<- TV itself
RecordingDevice1: 1						<- e.g. HDD combo
RecordingDevice2: 2
Tuner1: 3
PlaybackDevice1: 4						<- e.g. BluRay player
AudioSystem: 5							<- AV receivers
Tuner2: 6
Tuner3: 7
PlaybackDevice2: 8
RecordingDevice3: 9
Tuner4: 10
PlaybackDevice3: 11
Reserved1: 12
Reserved2: 13
FreeUse: 14
Broadcast: 15							<- Everything!
