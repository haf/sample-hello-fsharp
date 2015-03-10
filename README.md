# Sample F# Deis App

This sample shows how easy it is to create HTTP services with F# hosted on mono...

## Usage

Install Deis on some VMs, takes about 10 minutes to follow and about 15 minutes waiting. Meanwhile:

```
git clone git://github.com:haf/sample-hello-fsharp.git
cd sample-hello-fsharp
deis create sample-hello-fsharp
git push deis master
```

You can now surf to http://sample-hello-fsharp.example.com!


## Notes

You can find the dockerfile this is based on [at haf/dockerfiles](https://github.com/haf/dockerfiles).