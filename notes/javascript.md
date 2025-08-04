<article>
<div class="entry-content-wrap primary-entry-content">
<header class="entry-header"><h1 class="entry-title">Javascript Programming Interview Questions and Answers</h1>
</header>
<div class="entry-content">
<p>The majority of big tech companies utilize JavaScript to build complex and powerful web-based applications. And with the launch of node.js, it has become one of the top languages for building server-side applications. However, the web still needs to be bigger to utilize JavaScript's full potential and flexibility.

A list of JavaScript developer interview questions and answers to help you ace your next JavaScript interview and land your desired job.</p>
<h3><span class="ez-toc-section" id="Basic-NET-Core-interview-questions"></span>
<a href="#basic-net-core-interview-questions">Javascript Interview Questions</a><span class="ez-toc-section-end"></span></h3>
<ol>
<li><a href="#what-is-net-core-framework-and-how-does-it-work">New features in ES6 version</a></li>
<li><a href="#what-is-the-latest-version-of-net-core">Is javascript a statically typed or a dynamically typed language?</a></li>
<li><a href="#share-specific-features-of-net-core">Explain scope and scope chain JavaScript</a></li>
<li><a href="#what-is-net-core-used-for">What are the differences between var, const & let in JavaScript?</a></li>
<li><a href="#discuss-critical-components-in-net-core">What is closure in JavaScript?</a></li>
<li><a href="#what-is-the-difference-between-net-core-and-mono">What is hoisting in JavaScript?</a></li>
<li><a href="#what-is-net-core-corefx">Explain temporal dead zone.</a></li>
<li><a href="#what-is-coreclr">What are differences between “==” & “===”?</a></li>
<li><a href="#how-is-net-core-sdk-different-from-net-core-runtime">What is NaN property?</a></li>
<li><a href="#where-should-you-not-use-net-core">What is the difference between null and undefined?</a></li>
<li><a href="#what-are-the-advantages-of-net-core">What are the terms BOM and DOM in JavaScript?</a></li>
<li><a href="#what-is-kestrel">What is Critical Rendering Path?</a></li>
<li><a href="#what-do-you-know-about-net-core-middleware">What are basic JavaScript array methods?</a></li>
<li><a href="#what-are-razor-pages-in-net-core">What is the rest parameter and spread operator?</a></li>
<li><a href="#what-are-service-lifetimes-in-net-core">Explain this keyword</a></li>
<li><a href="#what-are-the-differences-between-net-core-and-net-framework">Explain call(), apply() and, bind() methods.</a></li> 
<li><a href="#explain-docker-in-net-core">Is JavaScript single-threaded, if yes then how it works as an multi-threaded language? OR What is event loop in javascript?</a></li>
<li><a href="#what-is-net-core-cli">What is callback hell?</a></li>
<li><a href="#what-is-hosting-environment-management">What are promises, async-await and callback?</a></li>
<li><a href="#garbage-collection-its-benefits-and-its-condition">The callback hell looks like below</a></li>
<li><a href="#discuss-cts-types-in-net-core">What are observables?</a></li>
<li><a href="#explain-corert">22.What are the differences between promises and observables?</a></li>
<li><a href="#why-is-startup-class-important">What is the difference between setTimeout, setImmediate and process.nextTick?</a></li>
<li><a href="#what-do-you-mean-by-state-management">What is microtask in JavaScript?</a></li>
<li><a href="#what-is-the-best-way-to-manage-errors-in-net-core">What Pure Functions in JavaScript?</a></li>
<li><a href="#is-mef-still-available-in-net-core">What is an error object and its different error name object?</a></li>
<li><a href="#what-is-response-caching-in-net-core">What are the various statements in error handling?</a></li>
<li><a href="#what-is-a-generic-host-in-net-core">What do you mean by strict mode in javascript and characteristics of javascript strict-mode?</a></li>
<li><a href="#what-is-routing-in-net-core">What are the differences between cookie, local storage and session storage?</a></li>
<li><a href="#what-is-dependency-injection-in-net-core">Explain prototype chaining</a></li>
<li><a href="#what-is-dependency-injection-in-net-core">What are generators and what are its different kinds?</a></li>
<li><a href="#what-is-dependency-injection-in-net-core"> Difference between Debouncing and Throttling</a></li>
</ol>

<h3><span class="ez-toc-section" id="1-What-is-NET-Core-Framework-and-how-does-it-work"></span>
<section id="what-is-net-core-framework-and-how-does-it-work"><span style="color: #f66700;">1.New features in ES6 version</span></section>
<span class="ez-toc-section-end"></span></h3>
The new features introduced in ES6 version of JavaScriptare:
- Arrow functions.
- Multi-line Strings.
- The destructuring assignment.
- Enhanced object literals.
- Promises

<h3><span class="ez-toc-section" id="2-What-is-the-latest-version-of-NET-Core-Share-one-specific-attribute"></span>
<section id="what-is-the-latest-version-of-net-core"><span style="color: #f66700;">2.Is javascript a statically typed or a dynamically typed language?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>JavaScript is a dynamically typed language. In a dynamically typed language, the type of a variable is checked during run-time in contrast to a statically typed language, where the type of a variable is checked during compile-time.</p>
- Static Typing
	- Variables have types
	- Variables cannot change type

- Dynamic Typing
	- Variables have no types
	- Variables can change type

<h3><span class="ez-toc-section" id="3-Share-specific-features-of-NET-Core"></span>
<section id="share-specific-features-of-net-core"><span style="color: #f66700;">3. Explain scope and scope chain JavaScript</span></section>
<span class="ez-toc-section-end"></span></h3>

JavaScript has the following kinds of scopes:
- Global Scope: A variable with global scope is one that can be accessed from anywhere in the application. It is the default scope for all code running in script mode.
Example:
{
	var x = 2;
}
console.log(x) //global scope

- Local Scope: Any declared variable inside of a function is referred to as having local scope. Within a function, a local variable can be accessed. It throws an error if you attempt to access any variables specified inside a function from the outside or another function.The scope for code running in module mode.
Example:
```
// This part of code cannot use x
function myFunction() {
	let x = 1;
	// This part of code can use x
}
```

This part of code cannot use x

- Function Scope: In JavaScript, every new function results in the generation of a fresh scope. Variables declared inside a function cannot be accessed from outside the function or from another function. When used inside of a function, var, let, and const all act similarly. The scope created with a function. 

```
function myFunction() {
	const firstName = "Krishna"; // Function Scope
}
```
Scope Chain refers to the situation when one variable, which may have a global, local, function, or block scope, is used by another variable, function, or block, which may also have a global, local, function, or block scope. This entire chain construction continues till the user decides to halt it in accordance with the need.



<h3><span class="ez-toc-section" id="4-What-is-NET-Core-used-for"></span>
<section id="what-is-net-core-used-for"><span style="color: #f66700;">4. What are the differences between var, const & let in JavaScript?</span></section>
<span class="ez-toc-section-end"></span></h3>
- <b>var</b>
    - The scope of a var variable is functional scope.
    - It can be updated and redeclared into the scope.
    - It can be declared without initialization.
    - It can be accessed without initialization as its default value is “undefined”.
    - Hoisting done, with initializing as ‘default’ value

- <b>let</b>
    - The scope of a let variable is block scope
    - It can be updated but cannot be re-declared into the scope.
    - It can be declared without initialization.
    - It cannot be accessed without initialization otherwise it will give ‘referenceError’.
    - Hoisting is done, but not initialized (this is the reason for the error when we access the let variable before  declaration/initialization


- <b>const</b>
    - The scope of a let variable is block scope.
    - It cannot be updated or redeclared into the scope.
    - It cannot be declared without initialization.
    - It cannot be accessed without initialization, as it cannot be declared without initialization.
    - Hoisting is done, but not initialized (this is the reason for the error when we access the const variable before declaration/ initialization

<h3><span class="ez-toc-section" id="5-Discuss-critical-components-in-NET-Core"></span>
<section id="discuss-critical-components-in-net-core"><span style="color: #f66700;">5.What is closure in JavaScript?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>A closure consists of references to the surrounding state (the lexical environment) and a function that has been wrapped (contained). In other words, a closure enables inner functions to access the scope of an outside function. Closures are formed whenever
a function is created in JavaScript, during function creation time.</p>


<h3><span class="ez-toc-section" id="6-What-is-the-difference-between-Net-Core-and-Mono"></span>
<section id="what-is-the-difference-between-net-core-and-mono"><span style="color: #f66700;">6. What is hoisting in JavaScript?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>Hoisting is the default behaviour of javascript where all the variable and function declarations are moved on top.
This means that irrespective of where the variables and functions are declared, they are moved on top of the scope. The scope can be both local and global.</p>

<h3><span class="ez-toc-section" id="7-What-is-NET-Core-CoreFX"></span>
<section id="what-is-net-core-corefx"><span style="color: #f66700;">7. Explain temporal dead zone.</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>Temporal Dead Zone is a behaviour that occurs with variables declared using let and const keywords. It is a behaviour where we try to access a variable before it is initialized.
</p>

```
Examples of temporal dead zone:
num = 23; // Gives reference error

let num;
function func(){
greeting = "Hi"; // Throws a reference error
let greeting;
}
func();</p>
```

<h3><span class="ez-toc-section" id="8-What-is-CoreCLR"></span>
<section id="what-is-coreclr"><span style="color: #f66700;">8. What are differences between “==” & “===”?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>The == operator performs a loose equality comparison that, if necessary to enable the comparison, applies type coercion. On the other hand, the === operator conducts a strict equality comparison without type coercion and necessitates that the operands be of the same type (as well as the same value).</p>


<h3><span class="ez-toc-section" id="9-How-is-NET-Core-SDK-different-from-NET-Core-Runtime"></span>
<section id="how-is-net-core-sdk-different-from-net-core-runtime"><span style="color: #f66700;">9. What is NaN property?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>The NaN property is a global property that represents "Not-a-Number" value. i.e, It indicates that a value is not a legal number. It is very rare to use NaN in a program but it can be used as return value for few cases</p>
```
Math.sqrt(-1);
parseInt("Hello");
```

<h3><span class="ez-toc-section" id="10-Where-should-you-not-use-NET-Core"></span>
<section id="where-should-you-not-use-net-core"><span style="color: #f66700;">10. What is the difference between null and undefined?</span></section>
<span class="ez-toc-section-end"></span></h3>

- <b>null</b>
    - It is an assignment value which indicates that variable points to no object.
    - Type of null is object
    - The null value is a primitive value that represents the null, empty, or non-existent reference.
    - Indicates the absence of a value for a variable
    - Converted to zero (0) while performing primitive operations

- <b>undefined</b>
    - It is not an assignment value where a variable has been declared but has not yet been assigned a value.
    - Type of undefined is undefined
    - The undefined value is a primitive value used when a variable has not been assigned a value.
    - Indicates absence of variable itself Converted to NaN while performing primitive operations


<h3><span class="ez-toc-section" id="11-What-are-the-advantages-of-NET-Core"></span>
<section id="what-are-the-advantages-of-net-core"><span style="color: #f66700;">11. What are the terms BOM and DOM in JavaScript?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>DOM stands for and BOM for Document Object Model and BOM Browswer Object Model..</p>

- DOM
- An element may be added, changed, or removed from a document using the Document Object Model (DOM), a programming interface for HTML and XML documents. It specifies how a document is accessed and handled, as well as its logical structure. The DOM allows the webpage to be represented as a structured hierarchy, making it simple to access and modify HTML tags, IDs, classes, attributes, and elements using the Document object's provided commands and methods. This makes it easier for programmers and users to understand the document.

    - DOM provides several methods to find & manipulate the behavior of the HTML element:
    - getElementById() Method
    - getElementsByClassName() Method
    - getElementsByName() Method
    - getElementsByTagName() Method
    - querySelector() Method
    - querySelectorAll() Method

- BOM: is a browser-specific convention referring to all the objects exposed by the web browser. The BOM allows JavaScript to “interact
with” the browser. The window object represents a browser window and all its corresponding features. A window object is created automatically by the browser itself. JavaScript’s window.screen object contains information about the user’s screen.

- Window properties of BOM are:
    - screen.width
    - screen.height
    - screen.availWidth
    - screen.availHeight
    - screen.colorDepth
    - screen.pixelDepth

- Window methods of BOM are:
    - window.open() Method
    - window.close() Method
    - window.moveTo() Method
    - window moveBy() Method
    - window.resizeTo() Method

<h3><span class="ez-toc-section" id="13-What-do-you-know-about-NET-Core-middleware"></span>

<section id="what-do-you-know-about-net-core-middleware"><span style="color: #f66700;">12. What is Critical Rendering Path?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>The Critical Rendering Path is the sequence of steps the browser goes through to convert the HTML, CSS, and JavaScript into pixels on the screen. Optimizing the critical render path improves render performance. The critical rendering path includes the Document Object Model (DOM), CSS Object Model (CSSOM), render tree and layout.</p>

<h3><span class="ez-toc-section" id="13-What-do-you-know-about-NET-Core-middleware"></span>
<section id="what-do-you-know-about-net-core-middleware"><span style="color: #f66700;">13.What are basic JavaScript array methods??</span></section>
<span class="ez-toc-section-end"></span></h3>

- push() method: adding a new element to an array. Since JavaScript arrays are changeable objects, adding and removing elements from an array is simple. Additionally, it alters itself when we change the array's elements.
Syntax: Array.push(item1, item2 …)

- pop() method: This method is used to remove elements from the end of an array.
Syntax: Array.pop()
- slice() method: This method returns a new array containing a portion of the original array, based on the start and end index provided as arguments
Syntax: Array.slice (startIndex , endIndex);
- map() method: The map() method in JavaScript creates an array by calling a specific function on each element present in the parent array. It is a nonmutating method. Generally, the map() method is used to iterate over an array and call the function on
every element of an array.
Syntax: Array.map(function(currentValue,index, arr), thisValue)
- reduce() method: The array reduce() method in JavaScript is used to reduce the array to a single value and executes a provided function for each value of the array (from left to right) and the return value of the function is stored in an accumulator. 
Syntax: Array.reduce(function(total,currentValue, currentIndex, arr), initialValue)


<h3><span class="ez-toc-section" id="19-What-is-Hosting-Environment-Management"></span>
<section id="what-is-hosting-environment-management"><span style="color: #f66700;">19. What is the rest parameter and spread operator?</span></section>
<span class="ez-toc-section-end"></span></h3>
Rest parameter ( … ):
- It offers a better method of managing a function's parameters.
- We can write functions that accept a variable number of arguments using the rest parameter syntax.
- The remainder parameter will turn any number of inputs into an array.
- Additionally, it assists in extracting all or some of the arguments.
- Applying three dots (...) before the parameters enables the use of rest parameters.

<h3><span class="ez-toc-section" id="20-Briefly-explain-Garbage-Collection-its-benefits-and-its-condition"></span>
<section id="garbage-collection-its-benefits-and-its-condition"><span style="color: #f66700;">20.Explain this keyword</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>In JavaScript, the this keyword always refers to an object. The thing about it is that the object it refers to 
will vary depending on how and where this is being called. If we call this by itself, meaning not within a function, object, or whatever, it will refer to the global window object. The majority of the time, the value of this depends on the runtime binding used to call a function. It may change every time the function is called and cannot be changed by assignment while the function is being executed. Although arrow functions don't give their own this binding (it keeps the this value of the enclosing lexical context), the bind() method can set the value of a function's this regardless of how it's called. </p>

<h3><span class="ez-toc-section" id="21-Discuss-CTS-types-in-NET-Core"></span>
<section id="discuss-cts-types-in-net-core"><span style="color: #f66700;">21.Explain call(), apply() and, bind() methods.</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>We use call, bind and apply methods to set the this keyword independent of how the function is called. This is
especially useful for the callbacks.Every function object is also given a few unique methods and attributes by
JavaScript. These are the methods that every JavaScript function inherits. Every function inherits certain methods, such as call, bind, and apply</p>

- bind(): The bind method creates a new function and sets the this keyword to the specified object.

```
Syntax:
function.bind(thisArg, optionalArguments)

For example:
Let’s suppose we have two person objects
const john = {
name: 'John',
age: 24,
};

const jane = {
name: 'Jane',
age: 22,
};
```


Let’s add a greeting function:

```
function greeting() {
	console.log(`Hi, I am ${this.name} and I am
	${this.age} years old`);
}
```

We can use the bind method on the greeting function to bind the this keyword to john and jane objects. 
For example:

```

const greetingJohn = greeting.bind(john);
// Hi, I am John and I am 24 years old
greetingJohn();
const greetingJane = greeting.bind(jane);
// Hi, I am Jane and I am 22 years old
greetingJane();

```

Here greeting.bind(john) creates a new function with this set to john object, which we then assign to greetingJohn variable. Similarly for greetingJane.

- call(): The call method initializes the this inside the function and launches it right away. 

In contrast to bind(), which produces a copy of the function and sets the this keyword, call() sets the this
keyword, executes the function instantly, and does not create a new copy of the function.


```
Syntax: function.call(thisArg, arg1, agr2, ...)
For example:
function greeting() {
	console.log(`Hi, I am ${this.name} and I am ${this.age} years old`);
}

const john = {
name: 'John',
age: 24,
};

const jane = {
name: 'Jane',
age: 22,
};

// Hi, I am John and I am 24 years old
greeting.call(john);
// Hi, I am Jane and I am 22 years old
greeting.call(jane);

```


Above example is similar to the bind() example except that call() does not create a new function. We are directly setting the this keyword using call()

apply(): The apply() method is similar to call(). The difference is that the apply() method accepts an array
of arguments instead of comma separated values.


```
Syntax: function.apply(thisArg, [argumentsArr])
For example:
function greet(greeting, lang) {
console.log(lang);
console.log(`${greeting}, I am ${this.name} and I am ${this.age} years old`);}
const john = {
name: 'John',
age: 24,
};

const jane = {
name: 'Jane',
age: 22,
};

// Hi, I am John and I am 24 years old

greet.apply(john, ['Hi', 'en']);

// Hi, I am Jane and I am 22 years old

greet.apply(jane, ['Hola', 'es'])

```




<h3><span class="ez-toc-section" id="22-Explain-CoreRT"></span>
<section id="explain-corert"><span style="color: #f66700;">22. Is JavaScript single-threaded, if yes then how it works as an multi-threaded language? OR What is event loop in javascript?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>JavaScript is a single-threaded asynchronous programming language. But what does it mean? What is this event loop in JavaScript that we all keep talking about?  </p>


<h3><span class="ez-toc-section" id="23-Why-is-Startup-Class-important"></span>
<section id="why-is-startup-class-important"><span style="color: #f66700;">23. What is callback hell?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>Callback Hell is an anti-pattern with multiple nested callbacks which makes code hard to read and debug when dealing with asynchronous logic.</p>

<h3><span class="ez-toc-section" id="24-What-do-you-mean-by-state-management"></span>
<section id="what-do-you-mean-by-state-management"><span style="color: #f66700;">24. WWhat are promises, async-await and callback?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>A Promise is a proxy for a value not necessarily known when the promise is created. It allows you to associate handlers with an asynchronous action's eventual success value or failure reason.</p>

<p>This lets asynchronous methods return values like synchronous methods: instead of immediately returning the final value, the asynchronous method returns a promise to supply the value at some point in the future.</p>

<p>A Promise is in one of these states:</p>
- pending: initial state, neither fulfilled nor rejected.
- fulfilled: meaning that the operation was completed successfully.
- rejected: meaning that the operation failed.

<p>A promise is said to be settled if it is either fulfilled or rejected, but not pending</p>

<p>Async simply allows us to write promises-based code as if it was synchronous and it checks that we are not breaking the execution thread. It operates asynchronously via the event loop. Async functions will always return a value. It makes sure that a promise is returned and if it is not returned then JavaScript automatically wraps it in a promise which is resolved with its value</p>

```
Syntax:
const func1 = async() => {
	return “Hello World!”;
}
```

<p>Await function is used to wait for the promise. It could be used within the async block only. It makes
the code wait until the promise returns a result. It only makes the async block wait</p>
```
Syntax:
const func2 = async () = {
	let x= await func1();
	console.log(x)
}
```

 
<h3><span class="ez-toc-section" id="26-IS-MEF-still-available-in-NET-Core"></span>
<section id="is-mef-still-available-in-net-core"><span style="color: #f66700;">26. The callback hell looks like below?</span></section>
<span class="ez-toc-section-end"></span></h3>
```
Syntax:
async1(function(){
async2(function(){
async3(function(){
async4(function(){
....
});
});
});
});
```

<h3><span class="ez-toc-section" id="27-What-is-response-caching-in-NET-Core"></span>
<section id="what-is-response-caching-in-net-core"><span style="color: #f66700;">27. What are observables?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>Observables in JavaScript are a way to handle asynchronous events. They are functions that return a stream of values, which can be used to represent data streams such as DOM events, mouse events, or HTTP requests.</p>
<p>Observables work by providing a way to subscribe to a stream of values, and then receiving those values as they become available. This allows you to respond to events in a more reactive way, without having to wait for the entire event stream to complete before processing it.</p>

To use observables in JavaScript, you can use the RxJS library.

```
import { Observable } from 'rxjs';

const observable = new Observable(subscriber => {

	subscriber.next(1);
	subscriber.next(2);
	subscriber.next(3);
	subscriber.complete();
});

observable.subscribe(value => {
	console.log(value);
	});

```

<h3><span class="ez-toc-section" id="28-What-is-a-generic-host-in-NET-Core"></span>
<section id="what-is-a-generic-host-in-net-core"><span style="color: #f66700;">28.What are the differences between promises and observables?</span></section>
<span class="ez-toc-section-end"></span></h3>
- <b>Promises</b>
    - Emits only a single value at a time
	- Eager in nature; they are going to be called immediately
	- Promise is always asynchronous even though it resolved immediately
	- Doesn't provide any operators
	- Cannot be cancelled
	
- <b>Observables</b>
	- Emits multiple values over a period of time(stream of values ranging from 0 to multiple)
	- Lazy in nature; they require subscription to be invoked
	- Observable can be either synchronous or asynchronous
	- Provides operators such as map, forEach, filter, reduce, retry, and retryWhen etc
	- Cancelled by using unsubscribe() method


<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">29. What is the difference between setTimeout, setImmediate and process.nextTick?</span></section>
<span class="ez-toc-section-end"></span></h3>
- <b>setTimeout()</b>: Using the setTimeout() method, a callback function can be scheduled to run once after a millisecond delay. 
- <b>setImmediate()</b>: Use the setImmediate function to run a function immediately following the conclusion of the current event loop.
- <b>process.nextTick()</b>:  If process.nextTick() is invoked in a given phase, all the callbacks passed to process.nextTick() will be resolved before the event loop continues. This will block the event loop and create I/O Starvation if process.nextTick() is called recursively.

<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">29. What is microtask in JavaScript?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>A function or section of code that always yields the same outcome when the same arguments are supplied is known as a pure function. It is independent of any state or data changes that occur while a program is running. Instead, it just relies on the arguments it is given.</p>
<p>Additionally, a pure function does not result in any side effects that can be seen, such as network queries, data alteration, etc.</p>

<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">What is an error object and its different error name object?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>When an error happens, an error object—a built-in error object—provides error information. There are two attributes: name and message. For instance, the following </p>

```

function records error information
Syntax:
try {
	greeting("Welcome");
} 
catch (err) {
	console.log(err.name + "<br>" + err.message);
}

```

<p>There are 6 different types of error names returned from error object</p>
- <b>EvalError</b> :An error has occurred in the eval() function
- RangeError :An error has occurred with a number "out of range"
- ReferenceError : An error due to an illegal reference
- SyntaxError: An error due to syntax
- TypeError:An error due to a type error
- URIError:An error due to encodeURI()


<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">What are the various statements in error handling?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>Below are the list of statements used in an error handling:</p>
	- try: This statement is used to test a block of code for errors
	- catch: This statement is used to handle the error
	- throw: This statement is used to create custom errors.
	- finally: This statement is used to execute code after try and
	- catch regardless of the result.


<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">What do you mean by strict mode in javascript and characteristics of javascript strict-mode?</span></section>
<span class="ez-toc-section-end"></span></h3>

<p>In ECMAScript 5, a new feature called JavaScript Strict Mode allows you to write a code or a function in a "strict"
operational environment. When it comes to throwing errors, javascript is often 'not extremely severe'. However,
in "Strict mode," all errors, even silent faults, will result in a throw. Debugging hence becomes more easier. Thus, the chance of a coder committing a mistake is decreased</p>

<p>Characteristics of strict mode in javascript</p>
	- Duplicate arguments are not allowed by developers.
	- Use of javascript’s keyword as parameter or function name is not allowed.
	- The 'use strict' keyword is used to define strict mode at the start of the script. Strict mode is supported by all browsers
	- Creating of global variables is not allowed.


<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">What are the differences between cookie, local storage and session storage?</span></section>
<span class="ez-toc-section-end"></span></h3>
- Cookie
	- Can be accessed on both server- side & client side
	- As configured using expires option
	- SSL is supported
	- Maximum size is 4 KB
- Local storage
	- Can be accessed on client- side only
	- Lifetime is until deleted
	- SSL is not supported
	- Maximum size is 5 MB
- Session
	- Can be accessed on client- side only
	- Lifetime is until tab is closed
	- SSL is not supported
	- Maximum size is 5 MB

    <h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">Explain prototype chaining</span></section>
<span class="ez-toc-section-end"></span></h3>

<p>Prototype chaining is used to build new types of objects based on existing ones. It is similar to inheritance in a
class based language.</p>

<p>The prototype on object instance is available through Object.getPrototypeOf(object) or __proto__ property
whereas prototype on constructors function is available through Object.prototype</p>




<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">What are generators and what are its different kinds?</span></section>
<span class="ez-toc-section-end"></span></h3>
<p>Introduced in the ES6 version, generator functions are a special class of functions. They can be stopped midway and then continue from where they had stopped. Generator functions are declared with the function* keyword instead of the normal function keyword.
</p>
There are five kinds of generators:
	1. Generator function declaration
	2. Generator function expressions
	3. Generator method definitions in object literals
	4. Generator method definitions in class
	5. Generator as a computed property





<h3><span class="ez-toc-section" id="29-What-is-routing-in-NET-Core"></span>
<section id="what-is-routing-in-net-core"><span style="color: #f66700;">Difference between Debouncing and Throttling</span></section>
<span class="ez-toc-section-end"></span></h3>

- Debouncing
    - Debouncing waits for a certain time before invoking the function again
    - Ensures that the function is called only once, even if the event is triggered multiple times.
    - Useful when you want to delay the invocation of a function until a certain period of inactivity has passed.

Eg. You can debounce an async API request function that is called every time the user types in an input field.
Syntax:
```
function debounce(func, delay) {

let timerId;

return function () {
	const context = this;
	const args = arguments;
	clearTimeout(timerId);

	timerId = setTimeout(function () {
						func.apply(context, args);
		  }, delay);

};
}
```

- <b>Throttling</b>
    - An error has occurred in the eval() function
    - An error has occurred with a number "out of range"
    - An error due to an illegal reference
    - An error due to syntax

```
Syntax:

function throttle(callback, delay=1000) {

let shouldWait = false;

return (...args) => {

if (shouldWait) return;

callback(...args);

shouldWait = true;

setTimeout(() => {

shouldWait = false;

}, delay);

};

}
```