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

[<ImportMember "aurelia">]
type IRegistry =
    interface
    end

[<ImportMember "aurelia">]
type LoggerConfiguration =
    static member create(config: obj) : IRegistry = jsNative

let ConsoleSink: obj = importMember "aurelia"

[<ImportMember "aurelia">]
type ILogger =
    abstract scopeTo: name: string -> ILogger
    abstract debug: value: string -> unit
    abstract info: value: string -> unit
    abstract warn: value: string -> unit
    abstract trace: value: string -> unit




type Decorators =

    static member CustomElement(config: obj) : obj -> unit = customelement config

    static member ValueConverter(name: string) : obj -> unit = valueconverter name


module Decorators =
    [<AttachMembers>]
    type JsonValueConverter() =
        member _.toView(value: obj) = JS.JSON.stringify (value)

    Decorators.ValueConverter ("json") jsConstructor<JsonValueConverter>
