using System.Reflection;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("ELITE")]
[assembly: AssemblyProduct("3E MatterSphere Core")]
[assembly: AssemblyCopyright("� 2024 Elite. All rights reserved.")]
[assembly: AssemblyTrademark("All trademarks reserved")]
[assembly: AssemblyCulture("")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:


[assembly: AssemblyVersion("10.1.0.0")]
[assembly: AssemblyFileVersion("10.1.1.0")]

#if BL

[assembly: FWBS.VersionConditional("4.5.0.30")]
[assembly: FWBS.VersionConditional("4.5.0.31")]

[assembly: FWBS.VersionConditional("5.0.0.0")]
[assembly: FWBS.VersionConditional("7.0.0.0")]
[assembly: FWBS.VersionConditional("7.1.0.0")]
[assembly: FWBS.VersionConditional("7.2.0.0")]
[assembly: FWBS.VersionConditional("8.0.0.0")]
[assembly: FWBS.VersionConditional("8.1.0.0")]
[assembly: FWBS.VersionConditional("9.0.0.0")]
[assembly: FWBS.VersionConditional("9.1.0.0")]
[assembly: FWBS.VersionConditional("10.0.0.0")]
[assembly: FWBS.VersionConditional("10.1.0.0")]

#endif