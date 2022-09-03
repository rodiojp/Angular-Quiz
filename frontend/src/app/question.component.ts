import { Component } from "@angular/core"
import { ApiService } from "./api.service";

@Component({
  selector: 'question',
  //template: 'this is our question'
  templateUrl: './question.component.html'
})
export class QuestionComponent {
  constructor(private api: ApiService) { }
  question: any =
    {
      text: "",
    };

  post() {
    this.api.postQuestoin(this.question);
  }
}
