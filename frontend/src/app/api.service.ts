import { Injectable } from "@angular/core"
import { HttpClient } from "@angular/common/http"

@Injectable()
export class ApiService {
  constructor(private http: HttpClient) { }
  postQuestoin(question: JSON) {
    this.http.post('https://localhost:44336/api/questions', question).subscribe(res => {
      console.log(res);
    });
  }
}
