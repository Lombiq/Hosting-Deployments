# Hosting - Deployments readme



Functionalities related to continuous integration and deployment.


## Developer overview

Hosting Suite-integrated Orchard applications can also benefit from integration with a continuous integration/deployment system. This module serves as a connection between such systems and the Hosting Suite.

Here are the current integration points:

- Displaying the build number on the Dashboard in the Footer.


## Extensibility examples

### Displaying the build number on the Dashboard in the Footer

When this module is enabled, the `Views\BuildNumber.cshtml` template's contents will be displayed in the Admin Dashboard in the Footer zone. This contains technical strings that will be swapped with the values of the `BuildVersionDisplay_BuildText` and `BuildVersionDisplay_BuildUrl` MSBuild parameters when at least one of them is provided. CI integration examples:

- In general, pass these parameters to the MSBuild command, e.g.:
```
/p:BuildVersionDisplay_BuildText="My best commit ever" /p:BuildVersionDisplay_BuildUrl="https://link-to-build.localhost"
```
- GitHub Actions: Our [MSBuild action](https://github.com/Lombiq/GitHub-Actions/blob/dev/.github/actions/msbuild/action.yml) (and the workflows that use it) supports this out of the box.
- TeamCity: Other than passing the parameters to the MSBuild command, you can also use the Build Feature called File Content Replacer to modify the template's content - check out _Lombiq.Hosting.Deployments.csproj_ to see what to replace.