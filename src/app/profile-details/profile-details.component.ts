import { ProfileDetailService } from './../shared/profile-detail.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs'
import { from } from 'rxjs';

@Component({
  selector: 'app-profile-details',
  templateUrl: './profile-details.component.html',
  styles: [
  ]
})
export class ProfileDetailsComponent implements OnInit {

  users;
  selecteduser;

  constructor(public service: ProfileDetailService) { }


  ngOnInit(): void {
   this.users = this.service.refreshList();
    //console.log(this.service.refreshList)
  }
  public selectuser(us){
    this.selecteduser = us;
  }

}
