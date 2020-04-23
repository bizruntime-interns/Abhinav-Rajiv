export interface Student {

  id: number;
  name: string;
  location: string;
  salary: number;
  city: string;

}

export function createStudent(params: Partial<Student>) {
  return {

  } as Student;
}
