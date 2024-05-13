# Bridge Pattern Project
This repository contains a C# project that demonstrates the Bridge design pattern. The project implements a user interface (UI) framework that supports different types of user interfaces (UIs) and themes using the Bridge pattern.

## Overview
The Bridge pattern is a structural design pattern that decouples an abstraction from its implementation, allowing both to vary independently. In this project, we use the Bridge pattern to separate UI rendering from theme customization. This allows new UI types and themes to be added independently without modifying existing code.

## Features
Support for different types of user interfaces:
Desktop
Mobile
Web
Customizable themes:
Light theme
Dark theme
##Project Structure
Interfaces:

IUITheme: Defines methods for different themes.
UIRenderer: Defines methods for rendering UI components.
Themes:

LightTheme: Concrete implementation of the light theme.
DarkTheme: Concrete implementation of the dark theme.
Renderers:

DesktopUIRenderer: Renders UI components for desktop platform.
MobileUIRenderer: Renders UI components for mobile platform.
WebUIRenderer: Renders UI components for web platform.
Main Program:

Program.cs: Demonstrates the usage of different UI renderers with different themes.
## Usage
Clone this repository to your local machine.
Open the project in your preferred IDE (e.g., Visual Studio).
Compile and run the project to see the Bridge pattern in action with different UI types and themes.
Contribution
Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

## Fork the repository.
Create your feature branch (git checkout -b feature/your-feature).
Commit your changes (git commit -am 'Add your feature').
Push to the branch (git push origin feature/your-feature).
Create a new Pull Request.
