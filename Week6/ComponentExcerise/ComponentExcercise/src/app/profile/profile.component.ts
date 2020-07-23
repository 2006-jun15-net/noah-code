import { Component, OnInit } from '@angular/core';
import User from '../user';
@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  public user: User; 
  public show: boolean = true;
  constructor() { }
  toggle(showButton: HTMLElement):void
  {
        if(this.show)
        {
          this.show = false;
          showButton.innerHTML = "show";
        }
        else
        {
          this.show = true;
          showButton.innerHTML = "hide";
        }
        
  }
  ngOnInit(): void {
    this.user = {
      Id: 1,
      FirstName: "Noah",
      LastName: "Funtanilla",
      UserName: "nFun"
    }
    
  }

}
