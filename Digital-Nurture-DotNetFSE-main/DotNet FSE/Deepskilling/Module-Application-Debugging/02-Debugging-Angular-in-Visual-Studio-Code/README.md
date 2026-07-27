# 02 - Debugging Angular in Visual Studio Code

## Overview

This exercise demonstrates how to debug an Angular application using the Visual Studio Code debugger. It covers configuring the debugger, setting breakpoints, inspecting variables, using the Watch window, and analyzing the call stack to identify and resolve issues efficiently.

---

## Objective

- Configure Visual Studio Code for Angular debugging.
- Create a launch.json configuration.
- Launch the Angular application in debug mode.
- Set breakpoints in TypeScript files.
- Inspect variables and expressions.
- Use the Watch window and Call Stack.
- Debug application flow effectively.

---

## Prerequisites

- Visual Studio Code
- Node.js
- Angular CLI
- Google Chrome
- Angular Language Service Extension
- Angular Project

---

## Files

```
02-Debugging-Angular-in-VS-Code/
│
├── README.md
├── launch.json
├── Notes.md
└── Output.png
```

---

## launch.json

Create a `.vscode` folder and add the following configuration.

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "type": "chrome",
            "request": "launch",
            "name": "Launch Angular App",
            "url": "http://localhost:4200",
            "webRoot": "${workspaceFolder}"
        }
    ]
}
```

---

## Sample Angular Code

### app.html

```html
<h1>Angular VS Code Debugging</h1>

<button (click)="showMessage()">
    Debug Application
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

  showMessage() {
    debugger;
    console.log("VS Code Debugging Started");
    alert("Debugging Successful");
  }

}
```

---

## Steps to Execute

### Step 1

Open the Angular project in Visual Studio Code.

### Step 2

Run the Angular application.

```bash
ng serve
```

### Step 3

Create the `.vscode` folder and add `launch.json`.

### Step 4

Open the **Run and Debug** panel.

### Step 5

Select **Launch Angular App**.

### Step 6

Press **F5**.

### Step 7

Click the **Debug Application** button.

### Step 8

Execution pauses at the `debugger` statement.

### Step 9

Inspect:

- Variables
- Watch
- Call Stack
- Breakpoints

---

## Expected Output

- Angular application launches in Chrome.
- VS Code attaches the debugger.
- Execution pauses at the breakpoint.
- Variables and Call Stack are displayed.
- Console displays:

```
VS Code Debugging Started
```

- Alert displays:

```
Debugging Successful
```

---

## Learning Outcome

After completing this exercise, I learned how to configure Visual Studio Code for Angular debugging, attach the debugger, set breakpoints, inspect variables, analyze the call stack, and efficiently troubleshoot TypeScript code.

---

## Conclusion

Visual Studio Code provides powerful debugging capabilities for Angular applications, making it easier to identify, analyze, and fix issues during development.
