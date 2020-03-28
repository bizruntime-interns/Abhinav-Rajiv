import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { student } from '../dbdata';
import { Observable, noop, interval, merge, Subscribable, Subscription } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { Student } from 'src/model/studentModel';
import { StudentserviceService } from './studentservices/studentservice.service';
import { httpobserver } from './common/ultil';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  // stu:Student;
  stu$: Observable<Student[]>;
  mapsub: Subscription;
  datenow = new Date();

  data = {
    title: 'angularfirst'
  };

  // stu;
  constructor(private studentservice: StudentserviceService) {
  }
  ngOnInit() {


    // const interval1$ = interval(1000);
    // const interval2$ = interval1$.pipe(map(val => 10 * val));
    // const result$ = merge(interval1$, interval2$);
    // this.mapsub = result$.subscribe(console.log);



    //this.stu$ = this.studentservice.getallStudent();
    const http$ = httpobserver("http://localhost:63314/api/Student");

    this.stu$ = http$.pipe(map(val => val));

    // const student$ = http$.pipe(map(res => Object.values(res) ,shareReplay())
    // );

    // student$.subscribe(val => console.log(val) , noop, () => console.log("completed"));

    // http$.subscribe(student => console.log("kjbdfsjks", student),
    //   noop,
    //   () => console.log("completed")
    // );

    // // this.http.get('http://localhost:63314/api/Student').subscribe(val=>this.stu$=val);
    // this.stu$=this.http.get<Student[]>('http://localhost:63314/api/Student');


  }


  // stu1=student[0];
  // stu2=student[1];
  // stu3=student[2];
  // stu4=student[3];


  alert() {
   // this.mapsub.unsubscribe();
    alert("submitted");
  }

  onkey(name: string) {
    this.data.title = name;
  }

  emmitedvalue(stud: Student) {
    console.log(stud, "emitted");
    // this.studentservice.putstudent(stud).subscribe(
    //   () => console.log("student saved")
    // );
  }

}

