﻿// Learn more about F# at http://fsharp.org

open Suave

[<EntryPoint>]
let main argv =
    startWebServer defaultConfig (Successful.OK "Hello World!")
    0 // return an integer exit code
