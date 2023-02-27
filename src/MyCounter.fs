module MyCounter

open Fable.Core

open Fable.Core.JsInterop

open Aurelia
open type Aurelia.Decorators



[<AttachMembers>]
type MyCounter(logger: ILogger) =


    let _logger = logger.scopeTo (nameof (MyCounter))
    let mutable counter = 0
    do logger.info ("olv")
    static member inject = [| jsConstructor<ILogger> |]

    member _.increment() : unit = counter <- counter + 1

    member _.decrement() : unit = counter <- counter - 1

    member _.counterChanged(newValue: int, oldValue: int) : unit =
        logger.info ($"{newValue} - {oldValue}")
        _logger.info ($"{newValue} - {oldValue}")



CustomElement
    ({| template = importDefault "./my-counter.html"
        name = "my-counter"
        bindables = [| "counter" |] |})
    jsConstructor<MyCounter>
