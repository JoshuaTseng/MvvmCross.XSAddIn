﻿using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin (
    "MVVMCross.XSAddIn",
    Namespace = "MVVMCross.XSAddIn",
    Version = "1.4.10"
)]

[assembly: AddinName ("MvvmCross Template pack")]
[assembly: AddinCategory ("IDE extensions")]
[assembly: AddinDescription ("Adds 2 new project types for creating cross-plaform MvvmCross apps either using Xamarin.iOS and Xamarin.Android, or using Xamarin.Forms.\n" +
                             "The project that is created for Xamarin iOS and Xamarin.Android is " +
                             "the same as what you would get if you installed the MvvmCross Starter Pack nuget and followed the instructions.\n" +
                             "The project that is created for Xamarin.Forms is the same as the example from the MvvmCross-Forms repo on GitHub.")]
[assembly: AddinAuthor ("Jim Bennett")]
