import { Component } from "@angular/core"

@Component({
  selector: 'question',
  //template: 'this is our question'
  templateUrl: './question.component.html'
})
export class QuestionComponent {
  question: string = ''
  post() {
    console.log(this.question);
  }
}
