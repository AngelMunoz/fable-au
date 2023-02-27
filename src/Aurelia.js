import { class_type } from "./fable_modules/fable-library.4.0.0-theta-018/Reflection.js";
import { valueConverter, customElement } from "aurelia";

export class Decorators {
    constructor() {
    }
}

export function Decorators$reflection() {
    return class_type("Aurelia.Decorators", void 0, Decorators);
}

export function Decorators_CustomElement_4E60E31B(config) {
    return customElement(config);
}

export function Decorators_ValueConverter_Z721C83C5(name) {
    return valueConverter(name);
}

export class DecoratorsModule_JsonValueConverter {
    constructor() {
    }
    toView(value) {
        return JSON.stringify(value);
    }
}

export function DecoratorsModule_JsonValueConverter$reflection() {
    return class_type("Aurelia.DecoratorsModule.JsonValueConverter", void 0, DecoratorsModule_JsonValueConverter);
}

export function DecoratorsModule_JsonValueConverter_$ctor() {
    return new DecoratorsModule_JsonValueConverter();
}

Decorators_ValueConverter_Z721C83C5("json")(DecoratorsModule_JsonValueConverter);

