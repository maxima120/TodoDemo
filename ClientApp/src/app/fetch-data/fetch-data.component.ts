import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public items: TodoItem[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<TodoItem[]>(baseUrl + 'todo').subscribe(result => {
      this.items = result;
    }, error => console.error(error));
  }
}

interface TodoItem {
  name: string;
  priority: number;
  status: number;
}
