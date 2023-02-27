module Main

open Fable.Core
open Fable.Core.JsInterop

open Aurelia
open Aurelia.Decorators

open AppRoot
open MyCounter
open Fable.Core.JS

importSideEffects "@shoelace-style/shoelace/dist/shoelace.js"
importSideEffects "@shoelace-style/shoelace/dist/themes/light.css"
importSideEffects "@shoelace-style/shoelace/dist/themes/dark.css"

Aurelia
    .register(
        Aurelia.LoggerConfiguration.create (
            {| level = 0
               sinks = [| ConsoleSink |] |}
        )
    )
    .register(jsConstructor<MyCounter>)
    .register(jsConstructor<JsonValueConverter>)
    .app(jsConstructor<AppRoot>)
    .start ()
