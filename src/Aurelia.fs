module Aurelia

open Fable.Core
open Fable.Core.JsInterop

[<Import("customElement", from = "aurelia")>]
let private customelement (config: obj) : 'T -> unit = jsNative

[<Import("valueConverter", from = "aurelia")>]
let private valueconverter (name: string) : 'T -> unit = jsNative

[<ImportDefault "aurelia">]
type Aurelia =

    static member register(obj) : Aurelia = jsNative
    member _.register(obj) : Aurelia = jsNative

    static member app(obj) : Aurelia = jsNative
    member _.app(obj) : Aurelia = jsNative

    static member start() : unit = jsNative
    member _.start() : unit = jsNative



type Decorators =

    static member CustomElement(config: obj) : obj -> unit = customelement config

    static member ValueConverter(name: string) : obj -> unit = valueconverter name


module Decorators =
    [<AttachMembers>]
    type JsonValueConverter() =
        member _.toView(value: obj) = JS.JSON.stringify (value)

    Decorators.ValueConverter ("json") jsConstructor<JsonValueConverter>
