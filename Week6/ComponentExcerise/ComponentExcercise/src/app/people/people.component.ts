import { Component, OnInit } from '@angular/core';
import {Person} from '../Person';
import {UserServiceService} from '../user-service.service';
@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {

  people: Person[] | null;
  constructor(private userService: UserServiceService) { }

  ngOnInit(): void {
    this.userService.GetUsers()
    .then(items => {this.people = items;})
  }

}
