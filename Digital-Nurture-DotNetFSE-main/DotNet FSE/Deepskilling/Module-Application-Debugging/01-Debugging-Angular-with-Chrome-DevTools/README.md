# 01 - Debugging Angular with Chrome DevTools

## Overview

This exercise demonstrates how to debug an Angular application using **Google Chrome DevTools**. Chrome DevTools helps developers inspect HTML elements, analyze CSS, monitor JavaScript execution, debug TypeScript using source maps, and identify runtime errors efficiently.

---

## Objective

- Run an Angular application.
- Open Chrome DevTools.
- Inspect the DOM structure.
- Debug TypeScript code using breakpoints.
- Analyze variables and the call stack.
- Use the Console for logging and debugging.

---

## Prerequisites

- Visual Studio Code
- Node.js
- Angular CLI
- Google Chrome
- Angular Project

---

## Files

```
01-Debugging-Angular-with-Chrome-DevTools/
│
├── README.md
├── Notes.md
└── Output.png
```

---

## Project Code

### app.html

```html
<h1>Angular Debugging Demo</h1>

<p>Welcome to Angular Chrome DevTools Debugging</p>

<button (click)="showMessage()">
  Click Me to Debug
</button>
```

### app.ts

```typescript
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  title = 'Angular Debugging Demo';

  showMessage(): void {
    debugger;
    console.log("Button clicked successfully!");
    alert("Debugging Successful!");
  }

}
```

---

## Steps to Execute

### Step 1

Open the project in Visual Studio Code.

### Step 2

Run the Angular application.

```bash
ng serve
```

### Step 3

Open the browser.

```
http://localhost:4200
```

### Step 4

Press **F12** to open Chrome DevTools.

### Step 5

Open the **Sources** tab.

### Step 6

Click the **Click Me to Debug** button.

### Step 7

Execution pauses at the `debugger` statement.

### Step 8

Inspect:

- Variables
- Scope
- Call Stack
- Breakpoints

### Step 9

Press **F8 (Resume Script Execution)** to continue.

---

## Expected Output

- Angular application runs successfully.
- Chrome DevTools opens.
- Execution pauses at the `debugger` statement.
- Console displays:

```
Button clicked successfully!
```

- Alert message appears:

```
Debugging Successful!
```

---

## Learning Outcome

After completing this exercise, I learned how to:

- Debug Angular applications using Chrome DevTools.
- Inspect the DOM using the Elements panel.
- Use the Sources panel for debugging.
- Set and use breakpoints.
- Inspect variables, scope, and the call stack.
- Debug TypeScript code using source maps.
- Improve application quality by identifying and resolving runtime issues.

---

## Conclusion

Chrome DevTools is a powerful debugging tool that enables developers to efficiently inspect, analyze, and troubleshoot Angular applications. Using breakpoints, source maps, and the console significantly improves the debugging process and helps build reliable web applications.
