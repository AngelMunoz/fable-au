module Main

open Fable.Core
open Fable.Core.JsInterop

open Aurelia
open Aurelia.Decorators

open AppRoot
open MyCounter

Aurelia
    .register(jsConstructor<MyCounter>)
    .register(jsConstructor<JsonValueConverter>)
    .app(jsConstructor<AppRoot>)
    .start ()
