<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658152/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T204333)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658152/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T204333)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)

# WPF MVVM Framework - Execute Multiple Commands with CompositeCommandBehavior

## Overview

Follow the steps below to use the **CompositeCommandBehavior**:

1. Define the behavior for a target object.
2. Create [CommandItem](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CommandItem) objects that are commands which the behavior should execute. Pass them to the behavior.
3. Specify the [Command](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CommandItem.Command) property for an each command to bind it to a ViewModel’s command.

If the [CompositeCommandBehavior.CanExecuteCondition](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CompositeCommandBehavior.CanExecuteCondition) property is set to [AnyCommandCanBeExecuted](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CompositeCommandExecuteCondition.AnyCommandCanBeExecuted), the behavior executes the [CompositeCommand](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CompositeCommandBehavior.CompositeCommand) when at least **one** of its commands can be executed (the [CommandItem.CanExecute](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CommandItem.CanExecute) property is `true`).

The [CompositeCommandBehavior.CompositeCommand](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CompositeCommandBehavior.CompositeCommand) property returns the aggregated function.

<!-- default file list -->
## Files to look at:

* [MainView.xaml](./CS/CompositeCommandBehaviorExample/View/MainView.xaml) (VB: [MainView.xaml](./VB/CompositeCommandBehaviorExample/View/MainView.xaml))
* [MainViewModel.cs](./CS/CompositeCommandBehaviorExample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/CompositeCommandBehaviorExample/ViewModel/MainViewModel.vb))
<!-- default file list end -->

## Documentation

- [CompositeCommandBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.CompositeCommandBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
