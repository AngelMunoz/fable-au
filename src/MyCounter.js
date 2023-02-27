import { class_type } from "./fable_modules/fable-library.4.0.0-theta-018/Reflection.js";
import { Decorators_CustomElement_4E60E31B } from "./Aurelia.js";
import my_counter from "./my-counter.html";

export class MyCounter {
    constructor() {
        this.counter = 0;
    }
    increment() {
        const _ = this;
        _.counter = ((_.counter + 1) | 0);
    }
    decrement() {
        const _ = this;
        _.counter = ((_.counter - 1) | 0);
    }
}

export function MyCounter$reflection() {
    return class_type("MyCounter.MyCounter", void 0, MyCounter);
}

export function MyCounter_$ctor() {
    return new MyCounter();
}

Decorators_CustomElement_4E60E31B((() => {
    const template = my_counter;
    return {
        name: "my-counter",
        template: template,
    };
})())(MyCounter);

