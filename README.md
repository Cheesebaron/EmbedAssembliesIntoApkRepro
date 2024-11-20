# EmbedAssembliesIntoApkRepro

Repro for https://github.com/dotnet/android/issues/9532

If you run the application with `EmbedAssembliesIntoApk` = `true` the toggle button does not pick up the translation from the `de-DE` ResX file.

If `EmbedAssembliesIntoApk` = `false` the toggle button changes the translation in the text field correctly.
