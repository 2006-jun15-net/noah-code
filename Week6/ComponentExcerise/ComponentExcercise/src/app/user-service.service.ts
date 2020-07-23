import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import {Person} from './Person';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor(private httpClient: HttpClient) { }

  GetUsers(){
    return this.httpClient.get<Person[]>("https://jsonplaceholder.typicode.com/users")
    .toPromise();
  }
}
