#r "utils/paket.exe"

open System
open System.IO

//Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

Paket.Dependencies.Install """
source https://nuget.org/api/v2
nuget Suave
""";;

#r "packages/Suave/lib/net40/Suave.dll"

open Suave
open Suave.Http.Successful
open Suave.Web

startWebServer defaultConfig (OK "Hello World!")