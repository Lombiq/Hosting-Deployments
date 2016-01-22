# Hosting - Deployments readme



Functionalities related to continuous integration and deployment.


## Developer overview

Hosting Suite-integrated Orchard applications can also benefit from integration with a continuous integration/deployment system. This module serves as a connection between such systems and the Hosting Suite.

Here are the current integration points:

- Displaying the build number on the Dashboard in the Footer.


## Extensibility examples

### Displaying the build number on the Dashboard in the Footer

In `Views\BuildNumber.cshtml` there's a variable with the placeholder value `#build.number#` that is displayed next to the version number of Orchard if it's changed to something else that doesn't end in a hashmark. Replacing the placeholder can happen during the deployment process to indicate the build number: For example in TeamCity this can be achieved by adding a Build Feature called File Content Replacer that looks for the placeholder value and replaces it with `%build.number%`.