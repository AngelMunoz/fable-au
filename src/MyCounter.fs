module MyCounter

open Fable.Core

open Fable.Core.JsInterop
open type Aurelia.Decorators

[<AttachMembers>]
type MyCounter() =
    let mutable counter = 0

    member _.increment() : unit = counter <- counter + 1

    member _.decrement() : unit = counter <- counter - 1


CustomElement
    ({| template = importDefault "./my-counter.html"
        name = "my-counter" |})
    jsConstructor<MyCounter>
