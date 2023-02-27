module AppRoot

open type Aurelia.Decorators
open Fable.Core.JsInterop

let private html (s: string) = s

type AppRoot() =
    class
    end

CustomElement
    ({| name = "app-root"
        template =
         html
             $"""
        <h1>Hello Aurelia From F#!</h1>
        <my-counter></my-counter>""" |})
    jsConstructor<AppRoot>
