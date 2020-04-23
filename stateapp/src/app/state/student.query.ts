import { Injectable } from '@angular/core';
import { QueryEntity } from '@datorama/akita';
import { StudentStore, StudentState } from './student.store';

@Injectable({ providedIn: 'root' })
export class StudentQuery extends QueryEntity<StudentState> {

  constructor(protected store: StudentStore) {
    super(store);
  }

}
