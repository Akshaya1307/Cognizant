import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
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
