using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(RunInBackground.BuildInfo.Description)]
[assembly: AssemblyDescription(RunInBackground.BuildInfo.Description)]
[assembly: AssemblyCompany(RunInBackground.BuildInfo.Company)]
[assembly: AssemblyProduct(RunInBackground.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + RunInBackground.BuildInfo.Author)]
[assembly: AssemblyTrademark(RunInBackground.BuildInfo.Company)]
[assembly: AssemblyVersion(RunInBackground.BuildInfo.Version)]
[assembly: AssemblyFileVersion(RunInBackground.BuildInfo.Version)]
[assembly: MelonInfo(typeof(RunInBackground.TestMod), RunInBackground.BuildInfo.Name, RunInBackground.BuildInfo.Version, RunInBackground.BuildInfo.Author, RunInBackground.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]