import aurelia from "aurelia";
import { MyCounter } from "./MyCounter.js";
import { DecoratorsModule_JsonValueConverter } from "./Aurelia.js";
import { AppRoot } from "./AppRoot.js";

aurelia.register(MyCounter).register(DecoratorsModule_JsonValueConverter).app(AppRoot).start();

