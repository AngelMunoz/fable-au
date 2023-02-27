import { class_type } from "./fable_modules/fable-library.4.0.0-theta-018/Reflection.js";
import { Decorators_CustomElement_4E60E31B } from "./Aurelia.js";

function html(s) {
    return s;
}

export class AppRoot {
    constructor() {
    }
}

export function AppRoot$reflection() {
    return class_type("AppRoot.AppRoot", void 0, AppRoot);
}

export function AppRoot_$ctor() {
    return new AppRoot();
}

Decorators_CustomElement_4E60E31B({
    name: "app-root",
    template: html("\r\n        <h1>Hello Aurelia From F#!</h1>\r\n        <my-counter></my-counter>"),
})(AppRoot);

