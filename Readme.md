# Hosting - Deployments readme

Orchard 1 module to display the build version (e.g., semver string, commit hash) optionally as a link to the build on the Admin Dashboard. There is also an [Orchard Core-variant of this module](https://github.com/Lombiq/Hosting-Build-Version-Display).

## How to use it

When this module is enabled, the `Views\BuildNumber.cshtml` template's contents will be displayed in the Admin Dashboard in the Footer zone. This contains technical strings that will be swapped with the values of the `BuildVersionDisplay_BuildText` and `BuildVersionDisplay_BuildUrl` MSBuild parameters when at least one of them is provided. If neither is provided, it won't display anything. CI integration examples:

- In general, pass these parameters to the MSBuild command, e.g.:
```
/p:BuildVersionDisplay_BuildText="My best commit ever" /p:BuildVersionDisplay_BuildUrl="https://link-to-build.localhost"
```
- GitHub Actions: Our [MSBuild action](https://github.com/Lombiq/GitHub-Actions/blob/dev/.github/actions/msbuild/action.yml) (and the workflows that use it) supports this out of the box.
- TeamCity: Other than passing the parameters to the MSBuild command, you can also use the Build Feature called File Content Replacer to modify the template's content - check out _Lombiq.Hosting.Deployments.csproj_ to see what to replace.

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://lombiq.com/open-source-guidelines) while doing so.

This project is developed by [Lombiq Technologies](https://lombiq.com/). Commercial-grade support is available through Lombiq.
