# Route Builder - Changelog
This changelog goes through all the changes that have been made in each release.

## v0.3.0 (2020-06-18)

General
* Updated GUI with window control buttons, sizeable window, status bar
* Replace toolbar button `info` with `help` pointing to documentation
* Code refactoring with improved exception handling
* [Settings](https://github.com/gtbikev/docs/blob/master/route-builder/SETTINGS.md) documentation

Convert Route
* Merge generate and specify textbox, move set course file button for better user experience
* Debug window for displaying output and map editor dataset
* Apply offsets for waypoints on X, Y, Z axis

Settings
* New settings GUI with treeview and pages
* New setting `Show Debug Window` to enable/disable debug window
* New setting `Enable Offsets` to apply specified offsets to waypoints
* New setting `X Offset` to apply X offset for each waypoint
* New setting `Y Offset` to apply Y offset for each waypoint
* New setting `Z Offset` to apply Z offset for each waypoint


## v0.2.0 (2020-06-08)

General
* Improved GUI with new toolbar (commands: start, reset, send feedback, about)
* Basic validation (drag'n'drop, start/reset command, read files)
* [Setup](https://github.com/gtbikev/docs/blob/master/route-builder/SETUP.md) documentation
* [Getting started](https://github.com/gtbikev/docs/blob/master/route-builder/GETTING-STARTED.md) documentation
* [Shortcuts](https://github.com/gtbikev/docs/blob/master/route-builder/SHORTCUTS.md) documentation

Convert Route
* Drag'n'drop for input fields (map editor file, course file)
* Generate course file name (course default directory + map editor file name)
* Specify course file name (for individual course file location)

Settings
* Read and save to .config file
* Set default file name
* Set default directories for input fields

## v0.1.0 (2020-06-01)

* Initial version of Route Builder
* Specify Map Editor file (.xml)
* Specify GT Bike V course file (.json)
* Create GT Bike V course file
* Clear Map Editor & GT Bike V source file