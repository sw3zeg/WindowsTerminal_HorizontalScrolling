
# Windows Terminal Horizontal Scrolling

This application is needed to add horizontal scrolling to the windows terminal. 

It monitors hotkeys clicks using the windows API and modifies the windows terminal settings file.

## Installation

1. Install and unzip the archive from [releases](https://github.com/sw3zeg/WindowsTerminal_HorizontalScrolling/releases)

- If you have installed .NET 9.0 -- "WT_HorizontalScrolling_NET9.rar".

- If you don't have it installed -- "WT_HorizontalScrolling_x64.rar".

2. Run "Start_WTHorizontalScrolling.bat".

## Set up application:

### Setting Json File Path:

If you have a standard file location, just enter your username in the path. Or specify your own path.


### Hot Keys: 

You need write hot keys with one or more modifiers at the beginning (ctrl, shift, alt, win) and one key at the end (left, right, up, down, pg_up, pg_down, a-z) connected using a '+'

Examples of hot keys: alt+left; ctrl+right; alt+shift+pg_up; win+ctrl+shift+down ...

**Reset hot key** - shifts the content as much to the left as possible.

### Step:

This is actually the speed. how much will the content shift in one click

### +/- autorun

Adds or removes a application in autorun.

### Hide Window:

If you enable this setting and apply it, the window will disappear and the application will run as a background process.

**To reopen the settings window**, run "Start_WTHorizontalScrolling.bat".

### Apply

Applies the settings and starts/restarts the application.

##

![ezgif-2f019affa3c84](https://github.com/user-attachments/assets/6788fe2e-5f84-4529-ad2b-bc899d121e03)

![Без имени](https://github.com/user-attachments/assets/a0328b78-7aa1-45df-a4fa-deb5b09451ee)
