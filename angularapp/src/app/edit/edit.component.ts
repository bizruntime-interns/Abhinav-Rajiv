import { Component, OnInit } from '@angular/core';
import { httpobserver } from '../common/ultil';
import { map, concatMap } from 'rxjs/operators';
import { Student } from 'src/model/studentModel';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { EditformComponent } from '../editform/editform.component';
import { Observable } from 'rxjs';
import { StudentserviceService } from '../studentservices/studentservice.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  student: Student;
  stud$: Observable<Student[]>;
  constructor(private dialog: MatDialog, private studentservice: StudentserviceService) { }

  ngOnInit(): void {
    const relod$ = this.relod();
    relod$.subscribe();
  }

  edit(studen: Student) {
    const dialogconf = new MatDialogConfig();
    dialogconf.disableClose = true;
    dialogconf.data = studen;
    const dialogref = this.dialog.open(EditformComponent, dialogconf);
    dialogref.afterClosed().subscribe(val => this.savecontent(val));

  }

  savecontent(stud: Student) {
    console.log(stud);
    const upd$ = this.studentservice.putstudent(stud);
    const rel$ = upd$.pipe(concatMap(val => this.relod())).subscribe();

  }

  relod() {
    const stu$ = httpobserver("http://localhost:63314/api/Student");
    return this.stud$ = stu$.pipe(map(val => val));
  }

}
