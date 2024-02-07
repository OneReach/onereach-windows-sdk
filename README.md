
# OneReach.ai on Windows

OneReach.ai provides a set of features available on different operating systems and platforms. The features are delivered to the end users using applications - `Apps`. Each `App` offers one or a set of features integrated with a platform or operating system the `App` is running on. The `Apps SDK` allows to use `Apps` on Windows.


## Apps SDK

### Integration

`Apps SDK` is distributed as a nuget package https://www.nuget.org/packages/OneReach.SDK.Apps

### Supported projects

Currently `Apps SDK` can be used for MSIX-packaged .NET projects (.NET ≥ 7.0) for x64 platform.

## Apps

### App URL

Each `App` has an `App URL` that looks like
`https://apps.onereach.ai/vWT5IwGnRdqadZc6JzetZg` or `https://apps.onereach.ai/vWT5IwGnRdqadZc6JzetZg.apps.onereach.ai`.
Both forms can be used to launch an `App`.

### App Launch

To launch the `App` means to make `App` to start doing its duty. `Apps SDK` provides the `LaunchApp` method for this. Each `App` should be installed on `Device` before the first launch. So when `LaunchApp` is called for the first time for a particular App, the `App` installation starts first. Once the install finished, the installed `App` launches.

It is easy to launch the `App` from your application using the next code:

```csharp
OneReach.SDK.Apps.LaunchApp("https://apps.onereach.ai/vWT5IwGnRdqadZc6JzetZg");
```

On Windows, this will create and activate a new window. This function should be called on the main thread since it communicates with the UI layer.
