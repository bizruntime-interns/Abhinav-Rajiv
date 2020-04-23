import { Component, OnInit, AfterViewInit } from '@angular/core';
import { StudentStore } from './state/student.store';
import { StudentQuery } from './state/student.query';
import { map } from 'rxjs/operators';
import { Student } from './state/student.model';
import { Observable } from 'rxjs';
import { StudentService } from './state/student.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  student$: Observable<Student[]>;
  constructor(private store: StudentStore, private storequery: StudentQuery, private storeservice: StudentService) {

  }
  ngOnInit() {

  }
  ngAfterViewInit(): void {
    this.storeservice.get().subscribe();
    this.student$ = this.storequery.selectAll();
    console.log(this.student$);
  }
}
