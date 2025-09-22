## JellyfinLoader Example Plugin

A simple example plugin that uses [JellyfinLoader](https://github.com/stenlan/JellyfinLoader/) for early injection and Harmony patching. It applies [a single Harmony patch](./LoggerPatch.cs) that overwrites format arguments passed to `ILogger#LogInformation`. The result can be seen below:

![patch result](https://i.imgur.com/xCOJqYK.png)