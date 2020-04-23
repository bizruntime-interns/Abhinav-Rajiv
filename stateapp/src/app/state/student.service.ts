import { Injectable } from '@angular/core';
import { ID } from '@datorama/akita';
import { HttpClient } from '@angular/common/http';
import { StudentStore } from './student.store';
import { Student } from './student.model';
import { tap } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class StudentService {

  constructor(private studentStore: StudentStore,
              private http: HttpClient) {
  }

  get() {
    return this.http.get<Student[]>('http://localhost:63314/api/Student').pipe(tap(entities => {
      this.studentStore.set(entities);
    }));
  }

  add(student: Student) {
    this.studentStore.add(student);
  }

  update(id, student: Partial<Student>) {
    this.studentStore.update(id, student);
  }

  remove(id: ID) {
    this.studentStore.remove(id);
  }
}
